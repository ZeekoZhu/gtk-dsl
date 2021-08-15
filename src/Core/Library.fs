module Gtk.DSL.Core

open System
open System.Collections.Concurrent
open System.Reactive.Subjects
open Gtk
open Gtk.DSL.MutableLookup

type VoidCallback = unit -> unit
type DslEvent = { Event: string }
type DslSymbol = { Value: string }

[<RequireQualifiedAccess>]
module Symbols =
    let typeId = { Value = "DSL:TypeId" }
    let dslComp = { Value = "DSL:Component" }

let gtkMainThreadAgent = new Subject<VoidCallback>()

let dslLoop =
    (gtkMainThreadAgent :> IObservable<_>)
        .Subscribe(fun fn -> Application.Invoke(EventHandler(fun _ _ -> fn ())))

Application.Default.Shutdown.Add(fun _ -> dslLoop.Dispose())

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
      /// create a new widget
      CreateWidget: unit -> Widget
      /// patch existing widget
      PatchWidget: PatchScheduler -> Widget -> unit }

and PatchScheduler() =
    let updateQueue = ConcurrentQueue<PatchUnit>()
    let patchQueue = ConcurrentQueue<PatchUnit>()
    let scheduledEvent = Event<unit>()

    let update (pu: PatchUnit) =
        updateQueue.Enqueue pu
        scheduledEvent.Trigger()

    let patch (pu: PatchUnit) =
        patchQueue.Enqueue pu

    /// Update a widget from event handler
    member _.Update(pu) = update pu
    /// Patch a widget during update
    member _.Patch(pu) = patch pu

    member this.Next() =
        match patchQueue.TryDequeue() with
        | false, _ ->
            match updateQueue.TryDequeue() with
            | false, _ -> None
            | true, pu -> Some pu
        | true, pu -> Some pu

    member this.Updated = scheduledEvent.Publish

and PatchUnit =
    { Widget: Widget
      Descriptor: WidgetDescriptor }


let baseWidget<'w, 'p when 'w :> Widget> (bindProperty: 'w -> 'p -> unit) (create: unit -> 'w) (props: 'p seq) =
    let typeId = { Value = typeof<'w>.FullName }

    let setProperties widget = props |> Seq.iter (bindProperty widget)

    let createNew () =
        let w = create ()
        setProperties w
        setNodeType w typeId
        w :> Widget

    let patchWidget _ (widget: Widget) =
        match widget with
        | :? 'w as w -> setProperties w
        | _ ->
            failwith $"try to update widget of type {widget.GetType().FullName} with descriptor of type {typeId.Value}"

    { NodeType = typeId
      CreateWidget = createNew
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

let patchContainer (scheduler: PatchScheduler) (c: #Container) (patches: PatchChildrenAction<#Container> seq) =
    for child in c.Children do
        // detach child from widget tree
        c.Remove(child)

    let patch =
        function
        | Add (desc, widget) ->
            let widget =
                match widget with
                | Some w -> w
                | None -> desc.Child.CreateWidget()

            desc.ChildProperties.AddChild(c, widget)

            scheduler.Patch(
                { Widget = widget
                  Descriptor = desc.Child }
            )
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

let patchChildren (scheduler: PatchScheduler) (container: 'w) (childrenDesc: ChildDescriptor<'w> seq) =
    createPatchActions container.Children childrenDesc
    |> patchContainer scheduler container

let containerWidget<'w, 'p when 'w :> Container>
    (bindProperty: 'w -> 'p -> unit)
    (create: unit -> 'w)
    (props: 'p seq, children: seq<ChildDescriptor<'w>>)
    =
    let widgetBase = baseWidget bindProperty create props

    let patchWidget scheduler widget =
        widgetBase.PatchWidget scheduler widget

        let container = widget :?> 'w
        patchChildren scheduler container children
        container.ShowAll()

    { widgetBase with
          PatchWidget = patchWidget }

let rec runNextUpdate (scheduler: PatchScheduler) () =
    match scheduler.Next() with
    | None -> ()
    | Some pu ->
        pu.Descriptor.PatchWidget scheduler pu.Widget
        runNextUpdate scheduler ()

let mount (window: #Container) widgetDescriptor =
    let scheduler = PatchScheduler()

    let disposeHandle =
        scheduler.Updated.Subscribe(fun () -> gtkMainThreadAgent.OnNext(runNextUpdate scheduler))

    window.Destroyed.Add(fun _ -> disposeHandle.Dispose())
    let root = widgetDescriptor.CreateWidget()

    scheduler.Update
        { Widget = root
          Descriptor = widgetDescriptor }

    window.Add root
    window.ShowAll()
