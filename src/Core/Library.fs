module Gtk.DSL.Core

open System
open System.Runtime.CompilerServices
open Gtk



type DslEvent = { Event: string }
type DslSymbol = { Value: string }

[<RequireQualifiedAccess>]
module Symbols =
    let typeId = { Value = "TypeId" }

let registerListener (widget: Widget) (event: string) (disposable: IDisposable) =
    let event = { Event = event }

    if widget.Data.ContainsKey event then
        let prev = widget.Data.[event] :?> IDisposable
        prev.Dispose()
        widget.Data.Remove(event)
    widget.Data.Add(event, disposable)

type WidgetDescriptor =
    abstract member WidgetType : DslSymbol
    abstract member Create : unit -> Widget
    abstract member Bind : Widget option -> Widget

[<AbstractClass>]
type BaseWidgetDescriptor<'w, 'p when 'w :> Widget>(props: 'p seq, bindProperty: 'w -> 'p -> unit) =
    let typeId = { Value = typeof<'w>.FullName }
    abstract member BindTyped : 'w -> unit
    abstract member CreateTyped : unit -> 'w
    abstract member Bind : widget: Widget option -> Widget
    default this.BindTyped(widget: 'w) = props |> Seq.iter (bindProperty widget)

    default this.Bind(widget: Widget option) =
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

    interface WidgetDescriptor with
        member this.WidgetType = typeId
        member this.Create() =
            this.CreateTyped() :> Widget

        member this.Bind(widget: Widget option) = this.Bind(widget)



type BasePropertyBuilder<'p>() =
    member this.Yield(()) = Seq.empty<'p>
    member this.For(items: 't seq, fn: 't -> 'p seq) = items |> Seq.map fn

type ChildPropertyDescriptor<'c when 'c :> Container> =
    abstract member AddChild : 'c * #Widget -> unit

type ChildDescriptor<'c when 'c :> Container> =
    { ChildProperties: ChildPropertyDescriptor<'c>
      Child: WidgetDescriptor }

let componentSymbol = { Value = "Component" }
let parentSymbol = { Value = "Parent" }

type ChildHolder(typeId: DslSymbol) as this =
    inherit Bin()
    do this.Data.Add(Symbols.typeId, typeId)

    member this.Replace(child: #Widget) =
        if this.Child <> null then
            this.Child.Destroy()

        this.Add(child)

let wrapChild (child: #Widget) childType =
    let childHolder = new ChildHolder(childType)
    childHolder.Add(child)
    childHolder

type FunctionalComponent = obj -> WidgetDescriptor


let patchChildren (container: 'w) (childrenDesc: ChildDescriptor<'w> seq) =
    let mutable children =
        container.Children
        |> Seq.cast<ChildHolder>
        |> List.ofSeq

    let findChildByTypeId typeId =
        children
        |> List.tryFind (fun c -> c.Data.[Symbols.typeId] = typeId)

    for child in children do
        // detach child from widget tree
        container.Remove(child)

    for childDesc in childrenDesc do
        let matchedWidget =
            findChildByTypeId childDesc.Child.WidgetType

        let child =
            match matchedWidget with
            | Some matchedWidget ->
                // reuse previous widget
                childDesc.Child.Bind(Some matchedWidget.Child)
                |> ignore

                children <-
                    children
                    |> List.filter (fun x -> x <> matchedWidget)

                matchedWidget
            | _ ->
                printfn $"create new widget: {childDesc.Child}"
                wrapChild (childDesc.Child.Bind(None)) childDesc.Child.WidgetType

        childDesc.ChildProperties.AddChild(container, child)

    for remainsChild in children do
        remainsChild.Destroy()

[<AbstractClass>]
type BaseContainerDescriptor<'w, 'p when 'w :> Container>
    (
        props: 'p seq,
        bindProperty: 'w -> 'p -> unit,
        children: seq<ChildDescriptor<'w>>
    ) =
    inherit BaseWidgetDescriptor<'w, 'p>(props, bindProperty)

    override this.BindTyped(widget: 'w) =
        base.BindTyped(widget)
        let container = widget
        patchChildren container children
        container.ShowAll()

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
