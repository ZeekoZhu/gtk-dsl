module Gtk.DSL.Core

open System
open System.Runtime.CompilerServices
open Gtk
open Gtk
open Gtk.Container


type DslEvent = { Event: string }
type DslSymbol = { Value: string }

let registerListener (widget: Widget) (event: string) (disposable: IDisposable) =
    let event = { Event = event }

    if widget.Data.ContainsKey event then
        let prev = widget.Data.[event] :?> IDisposable
        prev.Dispose()
    else
        widget.Data.Add(event, disposable)

type WidgetDescriptor =
    abstract member Create : unit -> Widget
    abstract member Bind : Widget option -> Widget

[<AbstractClass>]
type BaseWidgetDescriptor<'w, 'p when 'w :> Widget>(props: 'p seq, bindProperty: 'w -> 'p -> unit) =
    abstract member BindTyped : 'w -> unit
    abstract member CreateTyped : unit -> 'w
    default this.BindTyped(widget: 'w) = props |> Seq.iter (bindProperty widget)

    interface WidgetDescriptor with
        member this.Create() = this.CreateTyped() :> Widget

        member this.Bind(widget: Widget option) =
            let createNew () =
                let w = this.CreateTyped()
                this.BindTyped(w)
                w :> Widget

            match widget with
            | Some widget ->
                match widget with
                | :? 'w as w ->
                    this.BindTyped(w)
                    w :> Widget
                | _ -> createNew ()
            | None -> createNew ()


type BasePropertyBuilder<'p>() =
    member this.Yield(()) = Seq.empty<'p>
    member this.For(items: 't seq, fn: 't -> 'p seq) = items |> Seq.map fn


let componentSymbol = { Value = "Component" }
let parentSymbol = { Value = "Parent" }

[<AbstractClass>]
type AbstractContainerDescriptor<'w, 'p when 'w :> Container>(props: 'p seq, bindProperty: 'w -> 'p -> unit) =
    inherit BaseWidgetDescriptor<'w, 'p>(props, bindProperty)
    abstract member Replace : #Widget * #Widget -> unit
    member this.SetParent(widget: #Container) =
        widget.ChildGetProperty

[<Extension>]
type WidgetExtensions() =
    [<Extension>]
    static member DSLDestroy(widget: Widget) =
        let comp = widget.Data.Item componentSymbol

        match comp with
        | :? IDisposable as dis -> dis.Dispose()
        | _ -> widget.Destroy()

[<AbstractClass>]
type StatefulComponent() =
    let mutable widget : Widget = null
    abstract member Render : unit -> #WidgetDescriptor
    abstract member OnInit : unit -> unit
    abstract member OnUpdate : unit -> bool
    abstract member OnDestroy : unit -> unit

    member private this.Update() = if this.OnUpdate() then ()

    member this.SetState(fn: unit -> unit) =
        fn ()
        this.Update()

    interface IDisposable with
        member this.Dispose() =
            this.OnDestroy()
            if widget <> null then widget.Destroy()

//    interface WidgetDescriptor with
//        member this.Create() =
//            this.OnInit()
//            widget <- this.Render().Create()
//            widget.Data.Add(componentSymbol, widget)
//            widget
//
//        member this.Bind(_: Widget option) =
