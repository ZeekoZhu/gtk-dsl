module Gtk.DSL.Component

open System.Collections.Generic
open Gtk
open DSL.Core

/// Hold state data for a component
type StateStore() =
    let states = List<obj>()
    let mutable idx = 0
    let reset () = idx <- 0
    let onSetState = Event<unit>()
    let mutable setStateHandler = ignore
    do onSetState.Publish.Add(fun () -> gtkMainThreadAgent.OnNext(setStateHandler))
    /// register setState callback
    /// the callback will be called when `setState` is called
    member this.OnSetState fn = setStateHandler <- fn
    /// reset useState status
    member this.Reset() = reset ()

    /// if it's the first time call this method, it will create a new state with then init value
    /// or else it will ignore the input and return the current state and state setter
    member this.GetState(initValue: 't) =
        let stateIdx = idx

        if states.Count <= idx then
            states.Add(initValue)

        let currentValue = states.[stateIdx] :?> 't

        let setState (value: 't) =
            states.[stateIdx] <- value
            onSetState.Trigger()

        idx <- idx + 1
        currentValue, setState

/// Component's lifecycle hooks and state data
type ComponentFeatures =
    { OnCreated: VoidCallback
      OnDestroy: VoidCallback
      State: StateStore }

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

/// Define component features when rendering
type ComponentContext(stateStore: StateStore) =
    do stateStore.Reset()
    let onCreated = List<VoidCallback>()

    let runCallbacks callbacks =
        fun () -> callbacks |> Seq.iter (fun fn -> fn ())

    let onDestroy = List<VoidCallback>()
    member this.OnCreated fn = onCreated.Add fn
    member this.OnDestroy fn = onDestroy.Add fn
    member this.UseState(initValue: 't) = stateStore.GetState initValue

    /// Create component features, it should be called only once after first render
    member internal this.Build() =
        { OnCreated = runCallbacks onCreated
          OnDestroy = runCallbacks onDestroy
          State = stateStore }

/// Rerender the component
let updateComponent (host: ComponentHost) (desc: WidgetDescriptor) =

    if desc.NodeType = getNodeType host.Child then
        desc.PatchWidget(host.Child)
    else
        let newRoot = desc.CreateWidget()
        host.Replace newRoot
        newRoot

let statefullComponent (render: 'p -> ComponentContext -> WidgetDescriptor) props =
    let typeId = { Value = render.GetType().FullName }

    let update features host () =
        let ctx = ComponentContext(features.State)
        let desc = render props ctx
        updateComponent host desc
    let createNew () =
        let ctx = ComponentContext(StateStore())
        let features = ctx.Build()
        let host = new ComponentHost(typeId)
        features.State.OnSetState((update features host) >> ignore)
        setComponentFeatures host features
        let desc = render props ctx
        let widget = desc.CreateWidget()
        host.Add widget
        // hook onCreated
        features.OnCreated()
        host :> Widget

    let patchWidget (w:Widget) =
        match (getComponentFeatures w), w with
        | Some features, (:? ComponentHost as host) ->
            features.State.OnSetState((update features host) >> ignore)
            update features host () |> ignore
            host :> Widget
        | _, _ -> failwith "it is not a component"


    { NodeType = typeId
      CreateWidget = createNew
      PatchWidget = patchWidget }
