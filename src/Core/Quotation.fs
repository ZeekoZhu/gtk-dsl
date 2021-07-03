module Gtk.DSL.Quotation

open System
open FSharp.Quotations.Evaluator
open Gtk
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Gtk.DSL.Core


let quote<'t> = Unchecked.defaultof<'t>

type PropBindingInfo<'w> =
    { SetValue: 'w -> unit
      PropName: string }

type EventBindingInfo<'w> = 'w -> unit

type BindingInfo<'w> =
    | PropBindingInfo of PropBindingInfo<'w>
    | EventBindingInfo of EventBindingInfo<'w>

let (:=) (propExpr: Expr<'t>) (value: 't) =
    match propExpr with
    | PropertyGet (_, prop, __) ->
        if prop.CanWrite then
            { SetValue = (fun widget -> prop.SetValue(widget, value))
              PropName = prop.Name }
        else
            failwith $"Property {prop.Name} is not writable"
    | _ -> failwith "Only property getter access is allowed here"
    |> PropBindingInfo

let register<'w, 'h, 'a when 'w :> Widget and 'h: delegate<'a, unit> and 'h :> Delegate>
    (eventExpr: Expr<IEvent<'h, 'a>>)
    (handler: 'a -> unit)
    =
    let widgetVar = Var("widget", typeof<'w>)
    let widgetVarExpr = Expr.Var widgetVar
    let mutable eventName = ""

    match eventExpr with
    | Call (_, createEventHelper, addHandler :: removeHandler :: createDelegate :: _) ->
        match (addHandler, removeHandler) with
        | Lambda (addDelegateVar, addBody), Lambda (removeDelegateVar, removeBody) ->
            match addBody, removeBody with
            | Call (_, addMethod, addParams), Call (_, removeMethod, removeParams) ->
                eventName <- addMethod.Name.Substring(4)

                let callAddHandler =
                    Expr.Call(widgetVarExpr, addMethod, addParams)

                let callRemoveHandler =
                    Expr.Call(widgetVarExpr, removeMethod, removeParams)

                let addHandler =
                    Expr.Lambda(addDelegateVar, callAddHandler)

                let removeHandler =
                    Expr.Lambda(removeDelegateVar, callRemoveHandler)

                let callCreateEvent =
                    Expr.Call(
                        createEventHelper,
                        [ addHandler
                          removeHandler
                          createDelegate ]
                    )

                let createEvent = Expr.Lambda(widgetVar, callCreateEvent)

                let createEvent =
                    QuotationEvaluator.EvaluateUntyped createEvent :?> 'w -> IEvent<'h, 'a>

                let registerHandler (widget: 'w) =
                    registerListener widget eventName ((createEvent widget).Subscribe(handler))

                registerHandler
            | _ -> failwith "not supported"
        | _ -> failwith "not supported"
    | _ -> failwith "not supported"
    |> EventBindingInfo

let inline (@=) a b = register a b

let bindProperty (widget: 'w) (binding: BindingInfo<'w>) =
    match binding with
    | PropBindingInfo propBinding -> propBinding.SetValue(widget)
    | EventBindingInfo register -> register widget
