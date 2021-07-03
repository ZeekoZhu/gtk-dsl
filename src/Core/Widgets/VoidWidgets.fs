module Gtk.DSL.Widgets.VoidWidgets

open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Quotation

type VoidWidgetDescriptor<'w when 'w :> Widget>(props: BindingInfo<'w> seq, create: unit -> 'w) =
    inherit BaseWidgetDescriptor<'w, BindingInfo<'w>>(props, bindProperty)

    override this.CreateTyped() = create ()

let label props =
    VoidWidgetDescriptor(props, (fun () -> new Label()))
