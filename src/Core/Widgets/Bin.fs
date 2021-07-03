module Gtk.DSL.Widgets.Bin

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

let inline add child =
    { ChildProperties =
          { new ChildPropertyDescriptor<#Bin> with
              member this.AddChild(binLike, child) = binLike.Add(child) }
      Child = child }


type ButtonDescriptor(props: BindingInfo<Button> seq, children: ChildDescriptor<Button>) =
    inherit BaseContainerDescriptor<Button, BindingInfo<Button>>(props, bindProperty, Seq.singleton children)

    override this.CreateTyped() = new Button()


let button props child = ButtonDescriptor(props, (add child))
