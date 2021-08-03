module Gtk.DSL.Core

open System
open System.Reactive.Subjects
open System.Reactive.Linq
open Gtk
open Gtk.DSL.MutableLookup

type VoidCallback = unit -> unit
type DslEvent = { Event: string }
type DslSymbol = { Value: string }

[<RequireQualifiedAccess>]
module Symbols =
    let typeId = { Value = "DSL:TypeId" }
    let dslComp = { Value = "DSL:Component" }
    let componentSymbol = { Value = "Component" }
    let parentSymbol = { Value = "Parent" }

let gtkMainThreadAgent = new Subject<VoidCallback>()

let dslLoop =
    (gtkMainThreadAgent :> IObservable<_>)
        // todo
        .Buffer(
            TimeSpan.FromMilliseconds(5.0)
        )
        .Subscribe(fun fn -> Application.Invoke(EventHandler(fun _ _ -> fn |> Seq.iter (fun x -> x ()))))

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

type ChildDescriptor =
    { ChildDescriptor: Container -> Widget -> unit
      Child: WidgetDescriptor }

and WidgetRef =
    {
      /// this property is lazy set, generally it shouldn't be passed as an argument
      mutable Widget: Widget }

and DslAction =
    | Create of (unit -> Widget) * WidgetRef
    | SetNodeType of DslSymbol * Widget
    | SetProps of (Widget -> unit) * Widget
    | RemoveChild of (Container * Widget)
    | AddChild of (Container * ChildDescriptor * Widget)
    | Destroy of Widget

and WidgetDescriptor =
    { NodeType: DslSymbol
      /// WidgetRef holds the result produced by DslAction
      PatchWidget: Widget option -> DslAction seq * WidgetRef }


let baseWidget<'w, 'p when 'w :> Widget> (bindProperty: 'w -> 'p -> unit) (create: unit -> 'w) (props: 'p seq) =
    let typeId = { Value = typeof<'w>.FullName }

    let create = create >> (fun w -> w :> Widget)

    let patchWidget (widget: Widget option) =
        let result = { Widget = null }

        let setProperties (widget: Widget) =
            props |> Seq.iter (bindProperty (widget :?> 'w))

        let createNew () =
            seq {
                Create(create, result)
                SetProps(setProperties, result.Widget)
                SetNodeType(typeId, result.Widget)
            }

        let actions =
            match widget with
            | Some widget ->
                match widget with
                | :? 'w as w ->
                    result.Widget <- w
                    Seq.singleton (SetProps(setProperties, result.Widget))
                | _ ->
                    failwith
                        $"try to update widget of type {widget.GetType().FullName} with descriptor of type {typeId.Value}"
            | None -> createNew ()

        actions, result

    { NodeType = typeId
      PatchWidget = patchWidget }

type PatchChildrenAction =
    | Add of ChildDescriptor * Widget option
    | Remove of Widget

let patchContainer (c: Container) (patches: PatchChildrenAction seq) =
    let patch =
        function
        | Add (desc, widget) ->
            seq {
                let actions, result = desc.Child.PatchWidget widget
                // execute actions first, then result will be filled with patched widget
                yield! actions
                AddChild(c, desc, result.Widget)
            }
        | Remove widget -> Seq.singleton (Destroy widget)

    seq {
        for child in c.Children do
            RemoveChild(c, child)
    }
    |> Seq.append
    <| (patches |> Seq.collect patch)

let private createPatchActions (children: Widget []) (descriptors: ChildDescriptor seq) =
    let lookup = MutableLookup(children, getNodeType)

    seq {
        for descriptor in descriptors do
            let existing = lookup.TryPop descriptor.Child.NodeType
            Add(descriptor, existing)

        for previous in lookup do
            Remove previous
    }

let patchChildren (childrenDesc: ChildDescriptor seq) (container: Container) =
    createPatchActions container.Children childrenDesc
    |> patchContainer container

let containerWidget<'w, 'p when 'w :> Container>
    (bindProperty: 'w -> 'p -> unit)
    (create: unit -> 'w)
    (props: 'p seq, children: seq<ChildDescriptor>)
    =
    let widgetBase = baseWidget bindProperty create props

    let patchWidget widget =
        let actions, result = widgetBase.PatchWidget widget

        seq {
            yield! actions
            yield! patchChildren children (result.Widget :?> Container)
        },
        result

    { widgetBase with
          PatchWidget = patchWidget }

let rec exec act =
    match act with
    | Create (fn, wRef) -> wRef.Widget <- fn ()
    | SetNodeType (typeId, w) -> setNodeType w typeId
    | SetProps (fn, widget) -> fn widget
    | RemoveChild (container, widget) -> container.Remove(widget)
    | AddChild (container, childDesc, widget) -> childDesc.ChildDescriptor container widget
    | Destroy w -> w.Destroy()

let mount (window: #Container) widgetDescriptor =
    let actions, result = widgetDescriptor.PatchWidget None
    actions |> Seq.iter exec
    window.Add result.Widget
    window.ShowAll()
