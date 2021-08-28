module Gtk.DSL.GtkSharp

open System
open System.Collections.Concurrent
open System.Reactive.Subjects
open Gtk
open Gtk.DSL.Component
open Gtk.DSL.Core
open System.Reactive.Linq

type DefaultPatchScheduler<'w>() =
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

type GtkSharpWidgetAdaptor() =
    let ensureContainer (widget: Widget) fn =
        match widget with
        | :? Container as container -> fn container
        | _ -> failwith $"'{widget.GetType()}' is not a container"

    interface IWidgetAdaptor<Widget> with
        member this.SetNodeType widget typeId = widget.Data.[Symbols.typeId] <- typeId

        member this.GetNodeType widget =
            match widget.Data.[Symbols.typeId] with
            | :? DslSymbol as typeId -> typeId
            | _ -> failwith $"{widget.GetType().FullName} is not created by dsl functions"

        member this.GetChildren container =
            ensureContainer container
            <| fun container -> container.Children

        member this.TryGetComponentFeatures widget =
            match widget.Data.[Symbols.dslComp] with
            | :? ComponentFeatures as features -> Some features
            | _ -> None

        member this.SetComponentFeatures widget features =
            widget.Data.[Symbols.dslComp] <- (features :> obj)

        member this.RemoveChild container child =
            ensureContainer container
            <| fun container -> container.Remove child

        member this.Destory widget = widget.Destroy()

        member this.ShowAll container =
            ensureContainer container
            <| fun container -> container.ShowAll()

        member this.CreateComponentHost typeId =
            new ComponentHost(typeId, this) :> IComponentHost<Widget>

type GtkSharpDslContext() =
    let adaptor =
        GtkSharpWidgetAdaptor() :> IWidgetAdaptor<Widget>

    let scheduler =
        DefaultPatchScheduler() :> IPatchScheduler<Widget>

    interface IDslContext<Widget> with
        member this.WidgetAdaptor = adaptor
        member this.Scheduler = scheduler

let setup () =
    let agent = new Subject<VoidCallback>()

    let dslLoop =
        (agent :> IObservable<_>)
            .Subscribe(fun fn -> Application.Invoke(EventHandler(fun _ _ -> fn ())))

    Application.Default.Shutdown.Add(fun _ -> dslLoop.Dispose())
    agent

let gtkThreadAgent = setup ()

let mount (renderContainer: #Container) widgetDescriptor =
    let dslContext =
        GtkSharpDslContext() :> IDslContext<Widget>

    let disposeHandle =
        dslContext
            .Scheduler
            .Updated
            .Throttle(TimeSpan.FromMilliseconds(float 10))
            .Subscribe(fun x -> gtkThreadAgent.OnNext(runNextUpdate dslContext))

    renderContainer.Destroyed.Add(fun _ -> disposeHandle.Dispose())
    let root = widgetDescriptor.CreateWidget dslContext

    dslContext.Scheduler.Update
        { Widget = root
          Descriptor = widgetDescriptor }

    renderContainer.Add root
    root.ShowAll()
