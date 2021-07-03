module Gtk.DSL.Containers.Box

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Binding

type BoxChildDescriptor(packType: PackType, expand: bool, fill: bool, padding: uint32) =
    interface ChildPropertyDescriptor<Box> with
        member this.AddChild(box: Box, child: #Widget) =
            let pack =
                match packType with
                | PackType.End -> box.PackEnd
                | _ -> box.PackStart

            pack (child, expand, fill, padding)

type BoxDescriptor(props: Box.BoxProperty seq, children: ChildDescriptor<Box> seq) =
    inherit BaseContainerDescriptor<Box, Box.BoxProperty>(props, Box.bindProperty, children)

    override this.CreateTyped() = new Box(Orientation.Horizontal, 0)

let box props children = BoxDescriptor(props, children)

let packStart (expand, fill, padding) child =
    { ChildProperties = BoxChildDescriptor(PackType.Start, expand, fill, padding)
      Child = child }

let packEnd (expand, fill, padding) child =
    { ChildProperties = BoxChildDescriptor(PackType.End, expand, fill, padding)
      Child = child }
