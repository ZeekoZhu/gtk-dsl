module Gtk.DSL.Component

open Gtk.DSL.Core
open System
open System.Collections.Generic
open System.Reactive.Linq
open System.Reactive.Subjects

type ValueRef<'v>(initValue: 'v) =
    let subject = new BehaviorSubject<'v>(initValue)

    member this.Value
        with get () = subject.Value
        and set (value: 'v) = subject.OnNext(value)

    member this.Stream = subject.AsObservable()


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

let (|IsComponentHost|_|) (widget: 'w) =
    match widget :> obj with
    | :? IComponentHost<'w> as host -> Some host
    | _ -> None

/// Rerender the component
let updateComponent (ctx: IDslContext<'w>) (host: IComponentHost<'w>) (desc: WidgetDescriptor<'w>) =

    if desc.NodeType = (ctx.WidgetAdaptor.GetNodeType host.Child) then
        ctx.Scheduler.Update
            { Widget = host.Child
              Descriptor = desc }
    else
        let newRoot = desc.CreateWidget ctx

        ctx.Scheduler.Update
            { Widget = host.Child
              Descriptor = desc }

        host.Replace newRoot

let statefullComponent (render: 'p -> ComponentContext -> WidgetDescriptor<'w>) props =
    let typeId = { Value = render.GetType().FullName }

    let update (ctx: IDslContext<'w>) features host () =
        let compCtx = ComponentContext(features.State)
        let desc = render props compCtx
        updateComponent ctx host desc

    let createNew (ctx: IDslContext<'w>) =
        let compCtx = ComponentContext(RenderContext())
        let features = compCtx.Build()

        let host =
            ctx.WidgetAdaptor.CreateComponentHost(typeId)

        ctx.WidgetAdaptor.SetComponentFeatures host.Widget features
        let desc = render props compCtx
        let widget = desc.CreateWidget ctx
        host.Replace widget
        // hook onCreated
        features.OnCreated()
        host.Widget

    let patchWidget (ctx: IDslContext<'w>) (w: 'w) =
        match (ctx.WidgetAdaptor.TryGetComponentFeatures w), w with
        | Some features, IsComponentHost host ->
            features.RegisterUpdateCallback(update ctx features host)
            update ctx features host ()
        | _, _ -> failwith "it is not a component"


    { NodeType = typeId
      CreateWidget = createNew
      PatchWidget = patchWidget }
