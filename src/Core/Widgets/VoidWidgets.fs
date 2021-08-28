module Gtk.DSL.Widgets.VoidWidgets

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

let voidWidget props create = baseWidget bindProperty create props

let label props =
    voidWidget props (fun () -> new Label() :> Widget)
