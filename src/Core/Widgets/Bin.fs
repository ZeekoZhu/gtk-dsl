module Gtk.DSL.Widgets.Bin

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

let inline add child =
    { ChildProperties =
          { new ChildPropertyDescriptor<#Bin> with
              member this.AddChild(binLike, child) = binLike.Add(child) }
      Child = child }


let button props child =
    containerWidget bindProperty (fun () -> new Button()) (props, add child |> Seq.singleton)
