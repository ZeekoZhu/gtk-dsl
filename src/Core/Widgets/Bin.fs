module Gtk.DSL.Widgets.Bin

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

let inline add child =
    { ChildProperties =
          { new ChildPropertyDescriptor<Widget> with
              member this.AddChild(binLike, child) =
                  match binLike with
                  | :? Bin as binLike -> binLike.Add(child)
                  | _ -> failwithf $"{binLike} is not a Bin widget" }
      Child = child }


let button props child =
    containerWidget bindProperty (fun () -> new Button() :> Widget) (props, add child |> Seq.singleton)
