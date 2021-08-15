module Gtk.DSL.Widgets.Bin

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

let inline add child =
    { ChildDescriptor =
          fun (container: Container) child ->
              let bin = container :?> Bin
              bin.Add child
      Child = child }


let button props child =
    containerWidget bindProperty (fun () -> new Button()) (props, add child |> Seq.singleton)
