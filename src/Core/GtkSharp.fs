module Gtk.DSL.GtkSharp

open System.Collections.Concurrent
open Gtk
open Gtk.DSL.Core

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
    let ensureContainer (widget : Widget) fn =
        match widget with
        | :? Container as container -> fn container
        | _ -> failwith $"'{widget.GetType()}' is not a container"

    interface IWidgetAdaptor<Widget> with
        member this.SetNodeType widget typeId =
            widget.Data.[Symbols.typeId] <- typeId
        member this.GetNodeType widget =
            match widget.Data.[Symbols.typeId] with
            | :? DslSymbol as typeId -> typeId
            | _ -> failwith $"{widget.GetType().FullName} is not created by dsl functions"
        member this.GetChildren container =
            ensureContainer container
                (fun x -> x)
            match container with
            | :? Container as container -> container.Children
            | _ -> failwith $"'{container.GetType()}' is not a container"
        member this.TryGetComponentFeatures widget =
            match widget.Data.[Symbols.dslComp] with
            | :? ComponentFeatures as features -> Some features
            | _ -> None
        member this.SetComponentFeatures widget features =
            widget.Data.[Symbols.dslComp] <- (features :> obj)
        member this.RemoveChild container child =
            match container with
            | :? Container as container -> container.Remove child
            | _ -> failwith $"'{container.GetType()}' is not a container"
        member this.Destory widget =
            widget.Destroy()
        member this.ShowAll container =

        member this.CreateComponentHost : typeId: DslSymbol -> IComponentHost<'w>
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
