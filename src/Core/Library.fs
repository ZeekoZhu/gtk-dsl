module Gtk.DSL.Core

open System
open Gtk
open Gtk.DSL.MutableLookup

type VoidCallback = unit -> unit
type DslEvent = { Event: string }
type DslSymbol = { Value: string }

[<RequireQualifiedAccess>]
module Symbols =
    let typeId = { Value = "DSL:TypeId" }
    let dslComp = { Value = "DSL:Component" }


let setNodeType (widget: #Widget) (typeId: DslSymbol) = widget.Data.[Symbols.typeId] <- typeId

let getNodeType (widget: #Widget) =
    match widget.Data.[Symbols.typeId] with
    | :? DslSymbol as typeId -> typeId
    | _ -> failwith $"{widget.GetType().FullName} is not created by dsl functions"


let registerListener (widget: Widget) (event: string) (disposable: IDisposable) =
    let event = { Event = event }

    if widget.Data.ContainsKey event then
        let prev = widget.Data.[event] :?> IDisposable
        prev.Dispose()
        widget.Data.Remove(event)

    widget.Data.Add(event, disposable)

type WidgetDescriptor =
    { NodeType: DslSymbol
      PatchWidget: Widget option -> Widget }

let baseWidget<'w, 'p when 'w :> Widget> (bindProperty: 'w -> 'p -> unit) (create: unit -> 'w) (props: 'p seq) =
    let typeId = { Value = typeof<'w>.FullName }

    let patchWidget (widget: Widget option) =
        let setProperties widget = props |> Seq.iter (bindProperty widget)

        let createNew () =
            let w = create ()
            setProperties w
            w :> Widget

        match widget with
        | Some widget ->
            match widget with
            | :? 'w as w ->
                setProperties w
                w :> Widget
            | _ ->
                failwith
                    $"try to update widget of type {widget.GetType().FullName} with descriptor of type {typeId.Value}"
        | None ->
            let widget = createNew ()
            setNodeType widget typeId
            widget

    { NodeType = typeId
      PatchWidget = patchWidget }

type ChildPropertyDescriptor<'c when 'c :> Container> =
    abstract member AddChild : 'c * #Widget -> unit

type ChildDescriptor<'c when 'c :> Container> =
    { ChildProperties: ChildPropertyDescriptor<'c>
      Child: WidgetDescriptor }

let componentSymbol = { Value = "Component" }
let parentSymbol = { Value = "Parent" }

type PatchChildrenAction<'c when 'c :> Container> =
    | Add of ChildDescriptor<'c> * Widget option
    | Remove of Widget

let patchContainer (c: #Container) (patches: PatchChildrenAction<#Container> seq) =
    for child in c.Children do
        // detach child from widget tree
        c.Remove(child)

    let patch =
        function
        | Add (desc, widget) ->
            let widget = desc.Child.PatchWidget widget
            desc.ChildProperties.AddChild(c, widget)
        | Remove widget -> widget.Destroy()

    for action in patches do
        patch action

let private createPatchActions (children: Widget []) (descriptors: ChildDescriptor<'w> seq) =
    let lookup = MutableLookup(children, getNodeType)

    seq {
        for descriptor in descriptors do
            let existing = lookup.TryPop descriptor.Child.NodeType
            Add(descriptor, existing)

        for previous in lookup do
            Remove previous
    }

let patchChildren (container: 'w) (childrenDesc: ChildDescriptor<'w> seq) =
    createPatchActions container.Children childrenDesc
    |> patchContainer container

let containerWidget<'w, 'p when 'w :> Container>
    (bindProperty: 'w -> 'p -> unit)
    (create: unit -> 'w)
    (props: 'p seq, children: seq<ChildDescriptor<'w>>)
    =
    let widgetBase = baseWidget bindProperty create props

    let patchWidget widget =
        let container = widgetBase.PatchWidget widget :?> 'w
        patchChildren container children
        container.ShowAll()
        container :> Widget

    { widgetBase with
          PatchWidget = patchWidget }

let mount (window: #Container) widgetDescriptor =
    let root = widgetDescriptor.PatchWidget None
    window.Add root
    window.ShowAll()
