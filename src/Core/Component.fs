module Gtk.DSL.Component

open Gtk
open Gtk.DSL.Core
open System
open System.Collections.Generic
open System.Reactive.Linq
open System.Reactive.Subjects

/// Hold persisted data for a component during different rendering
type RenderContext() =
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
type ComponentFeatures =
    { OnCreated: VoidCallback
      OnDestroy: VoidCallback
      RegisterUpdateCallback: (unit -> unit) -> unit
      State: RenderContext }

type ValueRef<'v>(initValue: 'v) =
    let subject = new BehaviorSubject<'v>(initValue)

    member this.Value
        with get () = subject.Value
        and set (value: 'v) = subject.OnNext(value)

    member this.Stream = subject.AsObservable()

let setComponentFeatures (widget: #Widget) (features: ComponentFeatures) =
    widget.Data.[Symbols.dslComp] <- (features :> obj)

let getComponentFeatures (widget: #Widget) =
    match widget.Data.[Symbols.dslComp] with
    | :? ComponentFeatures as features -> Some features
    | _ -> None

/// Every component's root widget will be wrapped inside a ComponentHost
/// this host widget use component's typeId as its NodeType
/// and also holds the features for the component instance
type ComponentHost(typeId: DslSymbol) as this =
    inherit Bin()
    do setNodeType this typeId

    override this.Destroy() =
        // hooks on destroy
        match getComponentFeatures this.Child with
        | Some features -> features.OnDestroy()
        | None -> ()

        base.Destroy()

    member this.Replace(child: #Widget) =
        if this.Child <> null then
            this.Child.Destroy()

        this.Add(child)

type WidgetRef<'w>() =
    let mutable current = None

    member this.Current
        with get () = current
        and set (value: 'w option) = current <- value

/// Define component features when rendering
type ComponentContext(renderContext: RenderContext) =
    do renderContext.Reset()
    let onCreated = List<VoidCallback>()
    let onDestroy = List<VoidCallback>()
    let mutable callbackOnUpdate = fun () -> ()

    let runCallbacks callbacks =
        fun () -> callbacks |> Seq.iter (fun fn -> fn ())

    member this.OnCreated fn = onCreated.Add fn
    member this.OnDestroy fn = onDestroy.Add fn

    member this.UseState(initValue: 't) =
        let state, _ =
            renderContext.GetState
                (fun () ->
                    let state = ValueRef(initValue)

                    let dispose =
                        state.Stream.Subscribe(ignore >> callbackOnUpdate)

                    this.OnDestroy(fun () -> dispose.Dispose())
                    state)

        state

    member this.UseRef<'w>() =
        let wRef, _ =
            renderContext.GetState(fun () -> WidgetRef<'w>())

        wRef

    /// Create component features, it should be called only once after first render
    member internal this.Build() =
        { OnCreated = runCallbacks onCreated
          OnDestroy = runCallbacks onDestroy
          RegisterUpdateCallback = fun fn -> callbackOnUpdate <- fn
          State = renderContext }

/// Rerender the component
let updateComponent (scheduler: PatchScheduler) (host: ComponentHost) (desc: WidgetDescriptor) =

    if desc.NodeType = getNodeType host.Child then
        scheduler.Update
            { Widget = host.Child
              Descriptor = desc }
    else
        let newRoot = desc.CreateWidget()

        scheduler.Update
            { Widget = host.Child
              Descriptor = desc }

        host.Replace newRoot

let statefullComponent (render: 'p -> ComponentContext -> WidgetDescriptor) props =
    let typeId = { Value = render.GetType().FullName }

    let update (scheduler: PatchScheduler) features host () =
        let ctx = ComponentContext(features.State)
        let desc = render props ctx
        updateComponent scheduler host desc

    let createNew () =
        let ctx = ComponentContext(RenderContext())
        let features = ctx.Build()
        let host = new ComponentHost(typeId)
        setComponentFeatures host features
        let desc = render props ctx
        let widget = desc.CreateWidget()
        host.Add widget
        // hook onCreated
        features.OnCreated()
        host :> Widget

    let patchWidget (scheduler: PatchScheduler) (w: Widget) =
        match (getComponentFeatures w), w with
        | Some features, (:? ComponentHost as host) ->
            features.RegisterUpdateCallback (update scheduler features host)
            update scheduler features host ()
        | _, _ -> failwith "it is not a component"


    { NodeType = typeId
      CreateWidget = createNew
      PatchWidget = patchWidget }
