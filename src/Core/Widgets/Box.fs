module Gtk.DSL.Widgets.Box

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

let private addChild (packType: PackType, expand: bool, fill: bool, padding: uint32) (container: Widget) widget =
    let box = container :?> Box

    let pack =
        match packType with
        | PackType.End -> box.PackEnd
        | _ -> box.PackStart

    pack (widget, expand, fill, padding)


let gtkBox props children =
    containerWidget bindProperty (fun () -> new Box(Orientation.Horizontal, 0)) (props, children)

let packStart (expand, fill, padding) child =
    { ChildDescriptor = addChild (PackType.Start, expand, fill, padding)
      Child = child }


let packEnd (expand, fill, padding) child =
    { ChildDescriptor = addChild (PackType.End, expand, fill, padding)
      Child = child }
