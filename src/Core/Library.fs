module Gtk.DSL.Core

open System
open System.Collections.Concurrent
open System.Collections.Generic
open System.Reactive.Subjects
open Gtk
open Gtk.DSL.MutableLookup
open System.Reactive.Linq

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

//let setNodeType (widget: #Widget) (typeId: DslSymbol) = widget.Data.[Symbols.typeId] <- typeId
//
//let getNodeType (widget: #Widget) =
//    match widget.Data.[Symbols.typeId] with
//    | :? DslSymbol as typeId -> typeId
//    | _ -> failwith $"{widget.GetType().FullName} is not created by dsl functions"

type WidgetDescriptor<'w> =
    { NodeType: DslSymbol
      /// create a new widget
      CreateWidget: IDslContext<'w> -> 'w
      /// patch existing widget
      PatchWidget: IDslContext<'w> -> 'w -> unit }

and IPatchScheduler<'w> =
    /// Update a widget from event handler
    abstract member Update : PatchUnit<'w> -> unit
    /// Patch a widget during update
    abstract member Patch : PatchUnit<'w> -> unit
    abstract member Next : unit -> PatchUnit<'w> option
    abstract member Updated : IEvent<PatchUnit<'w>>
/// Every component's root widget will be wrapped inside a ComponentHost
/// this host widget use component's typeId as its NodeType
/// and also holds the features for the component instance
and IComponentHost<'w> =
    abstract member Widget : 'w
    abstract member Child : 'w
    abstract member Replace : child: 'w -> unit

and DefaultPatchScheduler<'w>() =
    let updateQueue = ConcurrentQueue<PatchUnit<'w>>()
    let patchQueue = ConcurrentQueue<PatchUnit<'w>>()
    let scheduledEvent = Event<PatchUnit<'w>>()

    let update (pu: PatchUnit<'w>) =
        updateQueue.Enqueue pu
        scheduledEvent.Trigger(pu)

    let patch (pu: PatchUnit<'w>) = patchQueue.Enqueue pu

    interface IPatchScheduler<'w> with
        member _.Update(pu) = update pu
        member _.Patch(pu) = patch pu

        member this.Next() =
            match patchQueue.TryDequeue() with
            | false, _ ->
                match updateQueue.TryDequeue() with
                | false, _ -> None
                | true, pu -> Some pu
            | true, pu -> Some pu

        member this.Updated = scheduledEvent.Publish

and PatchUnit<'w> =
    { Widget: 'w
      Descriptor: WidgetDescriptor<'w> }


/// Hold persisted data for a component during different rendering
and RenderContext() =
    let states = List<obj>()
    let mutable idx = 0
    let reset () = idx <- 0
    member this.Reset() = reset ()

    /// if it's the first time call this method, it will create a new state with then init value
    /// or else it will ignore the input and return the current state and state setter
    member this.GetState(initValue: unit -> 't) =
        let stateIdx = idx

        if states.Count <= idx then
            states.Add(initValue ())

        let currentValue = states.[stateIdx] :?> 't

        let setState (value: 't) = states.[stateIdx] <- value

        idx <- idx + 1
        currentValue, setState
/// Component's lifecycle hooks and state data
and ComponentFeatures =
    { OnCreated: VoidCallback
      OnDestroy: VoidCallback
      RegisterUpdateCallback: (unit -> unit) -> unit
      State: RenderContext }

and IWidgetAdaptor<'w> =
    abstract member SetNodeType : widget: 'w -> DslSymbol -> unit
    abstract member GetNodeType : widget: 'w -> DslSymbol
    abstract member GetChildren : container: 'w -> 'w []
    abstract member TryGetComponentFeatures : 'w -> ComponentFeatures option
    abstract member SetComponentFeatures : 'w -> ComponentFeatures -> unit
    abstract member RemoveChild : container: 'w -> child: 'w -> unit
    abstract member Destory : widget: 'w -> unit
    abstract member ShowAll : container: 'w -> unit
    abstract member CreateComponentHost : typeId: DslSymbol -> IComponentHost<'w>

and IDslContext<'w> =
    abstract member WidgetAdaptor : IWidgetAdaptor<'w>
    abstract member Scheduler : IPatchScheduler<'w>

let baseWidget<'w, 'p> (bindProperty: 'w -> 'p -> unit) (create: unit -> 'w) (props: 'p seq) =
    let typeId = { Value = typeof<'w>.FullName }

    let setProperties widget = props |> Seq.iter (bindProperty widget)

    let createNew (ctx: IDslContext<'w>) =
        let w = create ()
        setProperties w
        ctx.WidgetAdaptor.SetNodeType w typeId
        w

    let patchWidget _ (widget: 'w) = setProperties widget

    { NodeType = typeId
      CreateWidget = createNew
      PatchWidget = patchWidget }

type ChildPropertyDescriptor<'w> =
    abstract member AddChild : 'w * 'w -> unit

type ChildDescriptor<'w> =
    { ChildProperties: ChildPropertyDescriptor<'w>
      Child: WidgetDescriptor<'w> }

let componentSymbol = { Value = "Component" }
let parentSymbol = { Value = "Parent" }

type PatchChildrenAction<'w> =
    | Add of ChildDescriptor<'w> * 'w option
    | Remove of 'w

let patchContainer<'w> (ctx: IDslContext<'w>) (c: 'w) (patches: PatchChildrenAction<'w> seq) =
    for child in ctx.WidgetAdaptor.GetChildren c do
        // detach child from widget tree
        ctx.WidgetAdaptor.RemoveChild c child

    let patch =
        function
        | Add (desc, widget) ->
            let widget =
                match widget with
                | Some w -> w
                | None -> desc.Child.CreateWidget ctx

            desc.ChildProperties.AddChild(c, widget)

            ctx.Scheduler.Patch(
                { Widget = widget
                  Descriptor = desc.Child }
            )
        | Remove widget -> ctx.WidgetAdaptor.Destory widget

    for action in patches do
        patch action

let private createPatchActions (children: 'w []) (descriptors: ChildDescriptor<'w> seq) (ctx: IDslContext<'w>) =
    let lookup =
        MutableLookup(children, ctx.WidgetAdaptor.GetNodeType)

    seq {
        for descriptor in descriptors do
            let existing = lookup.TryPop descriptor.Child.NodeType
            Add(descriptor, existing)

        for previous in lookup do
            Remove previous
    }

let patchChildren (ctx: IDslContext<'w>) (container: 'w) (childrenDesc: ChildDescriptor<'w> seq) =
    createPatchActions (ctx.WidgetAdaptor.GetChildren container) childrenDesc ctx
    |> patchContainer ctx container

let containerWidget<'w, 'p>
    (bindProperty: 'w -> 'p -> unit)
    (create: unit -> 'w)
    (props: 'p seq, children: seq<ChildDescriptor<'w>>)
    =
    let widgetBase = baseWidget bindProperty create props

    let patchWidget ctx widget =
        widgetBase.PatchWidget ctx widget

        let container = widget
        patchChildren ctx container children
        ctx.WidgetAdaptor.ShowAll container

    { widgetBase with
          PatchWidget = patchWidget }

let rec runNextUpdate (ctx: IDslContext<'w>) () =
    match ctx.Scheduler.Next() with
    | None -> ()
    | Some pu ->
        pu.Descriptor.PatchWidget ctx pu.Widget
        runNextUpdate ctx ()

let mount (window: #Container) widgetDescriptor =
    let scheduler =
        DefaultPatchScheduler() :> IPatchScheduler<Widget>

    let disposeHandle =
        scheduler
            .Updated
            .Throttle(TimeSpan.FromMilliseconds(float 10))
            .Subscribe(fun () -> gtkMainThreadAgent.OnNext(runNextUpdate scheduler))

    window.Destroyed.Add(fun _ -> disposeHandle.Dispose())
    let root = widgetDescriptor.CreateWidget()

    scheduler.Update
        { Widget = root
          Descriptor = widgetDescriptor }

    window.Add root
    window.ShowAll()
