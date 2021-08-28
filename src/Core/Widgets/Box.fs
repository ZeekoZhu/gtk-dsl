module Gtk.DSL.Widgets.Box

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

type BoxChildDescriptor(packType: PackType, expand: bool, fill: bool, padding: uint32) =
    interface ChildPropertyDescriptor<Widget> with
        member this.AddChild(box: Widget, child: Widget) =
            let box = box :?> Box
            let pack =
                match packType with
                | PackType.End -> box.PackEnd
                | _ -> box.PackStart

            pack (child, expand, fill, padding)

let gtkBox props children =
    containerWidget bindProperty (fun () -> new Box(Orientation.Horizontal, 0) :> Widget) (props, children)

let packStart (expand, fill, padding) child =
    { ChildProperties = BoxChildDescriptor(PackType.Start, expand, fill, padding)
      Child = child }

let packEnd (expand, fill, padding) child =
    { ChildProperties = BoxChildDescriptor(PackType.End, expand, fill, padding)
      Child = child }
