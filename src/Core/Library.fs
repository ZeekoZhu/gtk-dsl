module Gtk.DSL.Core

open System
open System.Runtime.CompilerServices
open Gtk



type DslEvent = { Event: string }
type DslSymbol = { Value: string }

let registerListener (widget: Widget) (event: string) (disposable: IDisposable) =
    let event = { Event = event }

    if widget.Data.ContainsKey event then
        let prev = widget.Data.[event] :?> IDisposable
        prev.Dispose()
        widget.Data.Remove(event)
    widget.Data.Add(event, disposable)

type WidgetDescriptor =
    abstract member Create : unit -> Widget
    abstract member Bind : Widget option -> Widget

[<AbstractClass>]
type BaseWidgetDescriptor<'w, 'p when 'w :> Widget>(props: 'p seq, bindProperty: 'w -> 'p -> unit) =
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
        member this.Create() = this.CreateTyped() :> Widget

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

type ChildHolder() =
    inherit Bin()

    member this.Replace(child: #Widget) =
        if this.Child <> null then
            this.Child.Destroy()

        this.Add(child)

let wrapChild (child: #Widget) =
    let childHolder = new ChildHolder()
    childHolder.Add(child)
    childHolder :> Widget

[<AbstractClass>]
type ComponentDescriptor<'p when 'p: comparison>(props: Set<'p>) =
    abstract member Render : props: Set<'p> -> #WidgetDescriptor

    interface WidgetDescriptor with
        member this.Create() =
            let subTree = this.Render(props)
            subTree.Create()

        member this.Bind(widget: Widget option) =
            let subTree = this.Render(props)
            subTree.Bind(widget)

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

        container.Children
        |> Seq.iter (fun x -> x.Destroy())

        for childDesc in children do
            let holder = new ChildHolder()
            childDesc.ChildProperties.AddChild(container, holder)
            let childContent = childDesc.Child.Create()
            let childContent = childDesc.Child.Bind(Some childContent)
            holder.Replace(childContent)
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
