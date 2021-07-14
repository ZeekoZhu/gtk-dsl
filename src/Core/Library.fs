module Gtk.DSL.Core

open System
open System.Collections.Generic
open Gtk



type VoidCallback = unit -> unit
type DslEvent = { Event: string }
type DslSymbol = { Value: string }

[<RequireQualifiedAccess>]
module Symbols =
    let typeId = { Value = "DSL:TypeId" }
    let dslComp = { Value = "DSL:Component" }

let registerListener (widget: Widget) (event: string) (disposable: IDisposable) =
    let event = { Event = event }

    if widget.Data.ContainsKey event then
        let prev = widget.Data.[event] :?> IDisposable
        prev.Dispose()
        widget.Data.Remove(event)

    widget.Data.Add(event, disposable)

type WidgetDescriptor =
    abstract member WidgetType : DslSymbol
    abstract member Bind : Widget option -> Widget
    abstract member OnDestroy : Widget -> unit

type WidgetDescriptor2 =
    { WidgetType: DslSymbol
      PatchWidget: Widget option -> Widget }

let baseWidget<'w, 'p when 'w :> Widget> (bindProperty: 'w -> 'p -> unit) (create: unit -> 'w) (props: 'p seq) =
    let typeId = { Value = typeof<'w>.FullName }

    let patchWidget (widget: Widget option) =
        let patchWidget widget = props |> Seq.iter (bindProperty widget)

        let createNew () =
            let w = create ()
            patchWidget w
            w :> Widget

        match widget with
        | Some widget ->
            match widget with
            | :? 'w as w ->
                patchWidget w
                w :> Widget
            | _ -> createNew ()
        | None -> createNew ()

    { WidgetType = typeId
      PatchWidget = patchWidget }


type BasePropertyBuilder<'p>() =
    member this.Yield(()) = Seq.empty<'p>
    member this.For(items: 't seq, fn: 't -> 'p seq) = items |> Seq.map fn

type ChildPropertyDescriptor<'c when 'c :> Container> =
    abstract member AddChild : 'c * #Widget -> unit

type ChildDescriptor<'c when 'c :> Container> =
    { ChildProperties: ChildPropertyDescriptor<'c>
      Child: WidgetDescriptor2 }

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
                childDesc.Child.PatchWidget(Some matchedWidget.Child)
                |> ignore

                children <-
                    children
                    |> List.filter (fun x -> x <> matchedWidget)

                matchedWidget
            | _ ->
                printfn $"create new widget: {childDesc.Child.WidgetType.Value}"
                wrapChild (childDesc.Child.PatchWidget(None)) childDesc.Child.WidgetType

        childDesc.ChildProperties.AddChild(container, child)

    for remainsChild in children do
        remainsChild.Destroy()

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

type ComponentFeatures =
    { OnCreated: VoidCallback
      OnDestroy: VoidCallback }

type ComponentContext() =
    let onCreated = List<VoidCallback>()

    let runCallbacks callbacks =
        fun () -> callbacks |> Seq.iter (fun fn -> fn ())

    let onDestroy = List<VoidCallback>()
    member this.OnCreated fn = onCreated.Add fn
    member this.OnDestroy fn = onDestroy.Add fn

    member this.Build() =
        { OnCreated = runCallbacks onCreated
          OnDestroy = runCallbacks onDestroy }

let saveComponentFeatures (widget: #Widget) (features: ComponentFeatures) =
    widget.Data.[Symbols.dslComp] <- (features :> obj)

let getComponentFeatures (widget: #Widget) =
    match widget.Data.[Symbols.dslComp] with
    | :? ComponentFeatures as features -> features
    | _ -> failwith $"{widget.GetType().FullName} is not created by a component"

let stateless (render: 'p -> ComponentContext -> WidgetDescriptor2) props =
    let typeId = { Value = render.GetType().FullName }

    let patchWidget =
        function
        | None ->
            let ctx = ComponentContext()
            let desc = render props ctx
            let features = ctx.Build()
            let widget = desc.PatchWidget None
            saveComponentFeatures widget features
            // on created hook
            features.OnCreated()
            widget
        | Some w ->
            let ctx = ComponentContext()
            let desc = render props ctx
            desc.PatchWidget(Some w)


    { WidgetType = typeId
      PatchWidget = patchWidget }
