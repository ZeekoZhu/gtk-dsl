module Gtk.DSL.Binding.VSeparator
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VSeparatorProperty =
    | Orientation of Gtk.Orientation
    | Name of System.String
    | Parent of Gtk.Widget
    | WidthRequest of System.Int32
    | HeightRequest of System.Int32
    | Visible of System.Boolean
    | Sensitive of System.Boolean
    | AppPaintable of System.Boolean
    | CanFocus of System.Boolean
    | HasFocus of System.Boolean
    | IsFocus of System.Boolean
    | FocusOnClick of System.Boolean
    | CanDefault of System.Boolean
    | HasDefault of System.Boolean
    | ReceivesDefault of System.Boolean
    | [<Obsolete>] Style of Gtk.Style
    | Events of Gdk.EventMask
    | NoShowAll of System.Boolean
    | HasTooltip of System.Boolean
    | TooltipText of System.String
    | TooltipMarkup of System.String
    | Window of Gdk.Window
    | [<Obsolete>] DoubleBuffered of System.Boolean
    | Halign of Gtk.Align
    | Valign of Gtk.Align
    | [<Obsolete>] MarginLeft of System.Int32
    | [<Obsolete>] MarginRight of System.Int32
    | MarginStart of System.Int32
    | MarginEnd of System.Int32
    | MarginTop of System.Int32
    | MarginBottom of System.Int32
    | Margin of System.Int32
    | Hexpand of System.Boolean
    | HexpandSet of System.Boolean
    | Vexpand of System.Boolean
    | VexpandSet of System.Boolean
    | Expand of System.Boolean
    | Opacity of System.Double
    |  OnDamageEvent of (Gtk.DamageEventArgs -> unit)
    |  OnSizeAllocated of (Gtk.SizeAllocatedArgs -> unit)
    |  OnProximityOutEvent of (Gtk.ProximityOutEventArgs -> unit)
    |  OnDeleteEvent of (Gtk.DeleteEventArgs -> unit)
    |  OnDragMotion of (Gtk.DragMotionArgs -> unit)
    |  OnStateFlagsChanged of (Gtk.StateFlagsChangedArgs -> unit)
    |  OnGrabNotify of (Gtk.GrabNotifyArgs -> unit)
    |  OnConfigureEvent of (Gtk.ConfigureEventArgs -> unit)
    |  OnButtonPressEvent of (Gtk.ButtonPressEventArgs -> unit)
    |  OnFocusOutEvent of (Gtk.FocusOutEventArgs -> unit)
    |  OnUnmapEvent of (Gtk.UnmapEventArgs -> unit)
    |  OnHelpShown of (Gtk.HelpShownArgs -> unit)
    |  OnMoveFocus of (Gtk.MoveFocusArgs -> unit)
    |  OnScrollEvent of (Gtk.ScrollEventArgs -> unit)
    |  OnSelectionReceived of (Gtk.SelectionReceivedArgs -> unit)
    |  OnDirectionChanged of (Gtk.DirectionChangedArgs -> unit)
    |  OnPropertyNotifyEvent of (Gtk.PropertyNotifyEventArgs -> unit)
    |  OnDragDrop of (Gtk.DragDropArgs -> unit)
    |  OnStyleSet of (Gtk.StyleSetArgs -> unit)
    |  OnParentSet of (Gtk.ParentSetArgs -> unit)
    |  OnDragDataReceived of (Gtk.DragDataReceivedArgs -> unit)
    |  OnTouchEvent of (Gtk.TouchEventArgs -> unit)
    |  OnDrawn of (Gtk.DrawnArgs -> unit)
    |  OnSelectionRequestEvent of (Gtk.SelectionRequestEventArgs -> unit)
    |  OnEnterNotifyEvent of (Gtk.EnterNotifyEventArgs -> unit)
    |  OnDragDataDelete of (Gtk.DragDataDeleteArgs -> unit)
    |  OnScreenChanged of (Gtk.ScreenChangedArgs -> unit)
    |  OnWidgetEvent of (Gtk.WidgetEventArgs -> unit)
    |  OnSelectionClearEvent of (Gtk.SelectionClearEventArgs -> unit)
    |  OnChildNotified of (Gtk.ChildNotifiedArgs -> unit)
    |  OnWindowStateEvent of (Gtk.WindowStateEventArgs -> unit)
    |  OnDestroyEvent of (Gtk.DestroyEventArgs -> unit)
    |  OnSelectionGet of (Gtk.SelectionGetArgs -> unit)
    |  OnGrabBrokenEvent of (Gtk.GrabBrokenEventArgs -> unit)
    |  OnDragLeave of (Gtk.DragLeaveArgs -> unit)
    |  OnVisibilityNotifyEvent of (Gtk.VisibilityNotifyEventArgs -> unit)
    |  OnMotionNotifyEvent of (Gtk.MotionNotifyEventArgs -> unit)
    |  OnKeyReleaseEvent of (Gtk.KeyReleaseEventArgs -> unit)
    |  OnQueryTooltip of (Gtk.QueryTooltipArgs -> unit)
    |  OnMapEvent of (Gtk.MapEventArgs -> unit)
    |  OnFocusInEvent of (Gtk.FocusInEventArgs -> unit)
    |  OnHierarchyChanged of (Gtk.HierarchyChangedArgs -> unit)
    |  OnStateChanged of (Gtk.StateChangedArgs -> unit)
    |  OnDragDataGet of (Gtk.DragDataGetArgs -> unit)
    |  OnPopupMenu of (Gtk.PopupMenuArgs -> unit)
    |  OnAccelCanActivate of (Gtk.AccelCanActivateArgs -> unit)
    |  OnDragEnd of (Gtk.DragEndArgs -> unit)
    |  OnLeaveNotifyEvent of (Gtk.LeaveNotifyEventArgs -> unit)
    |  OnMnemonicActivated of (Gtk.MnemonicActivatedArgs -> unit)
    |  OnKeyPressEvent of (Gtk.KeyPressEventArgs -> unit)
    |  OnDragBegin of (Gtk.DragBeginArgs -> unit)
    |  OnWidgetEventAfter of (Gtk.WidgetEventAfterArgs -> unit)
    |  OnProximityInEvent of (Gtk.ProximityInEventArgs -> unit)
    |  OnButtonReleaseEvent of (Gtk.ButtonReleaseEventArgs -> unit)
    |  OnDragFailed of (Gtk.DragFailedArgs -> unit)
    |  OnSelectionNotifyEvent of (Gtk.SelectionNotifyEventArgs -> unit)
    |  OnFocused of (Gtk.FocusedArgs -> unit)

let bindProperty (widget: VSeparator) (prop: VSeparatorProperty) =
    match prop with
    | VSeparatorProperty.Orientation value -> widget.Orientation <- value
    | VSeparatorProperty.Name value -> widget.Name <- value
    | VSeparatorProperty.Parent value -> widget.Parent <- value
    | VSeparatorProperty.WidthRequest value -> widget.WidthRequest <- value
    | VSeparatorProperty.HeightRequest value -> widget.HeightRequest <- value
    | VSeparatorProperty.Visible value -> widget.Visible <- value
    | VSeparatorProperty.Sensitive value -> widget.Sensitive <- value
    | VSeparatorProperty.AppPaintable value -> widget.AppPaintable <- value
    | VSeparatorProperty.CanFocus value -> widget.CanFocus <- value
    | VSeparatorProperty.HasFocus value -> widget.HasFocus <- value
    | VSeparatorProperty.IsFocus value -> widget.IsFocus <- value
    | VSeparatorProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VSeparatorProperty.CanDefault value -> widget.CanDefault <- value
    | VSeparatorProperty.HasDefault value -> widget.HasDefault <- value
    | VSeparatorProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VSeparatorProperty.Style value -> widget.Style <- value
    | VSeparatorProperty.Events value -> widget.Events <- value
    | VSeparatorProperty.NoShowAll value -> widget.NoShowAll <- value
    | VSeparatorProperty.HasTooltip value -> widget.HasTooltip <- value
    | VSeparatorProperty.TooltipText value -> widget.TooltipText <- value
    | VSeparatorProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VSeparatorProperty.Window value -> widget.Window <- value
    | VSeparatorProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VSeparatorProperty.Halign value -> widget.Halign <- value
    | VSeparatorProperty.Valign value -> widget.Valign <- value
    | VSeparatorProperty.MarginLeft value -> widget.MarginLeft <- value
    | VSeparatorProperty.MarginRight value -> widget.MarginRight <- value
    | VSeparatorProperty.MarginStart value -> widget.MarginStart <- value
    | VSeparatorProperty.MarginEnd value -> widget.MarginEnd <- value
    | VSeparatorProperty.MarginTop value -> widget.MarginTop <- value
    | VSeparatorProperty.MarginBottom value -> widget.MarginBottom <- value
    | VSeparatorProperty.Margin value -> widget.Margin <- value
    | VSeparatorProperty.Hexpand value -> widget.Hexpand <- value
    | VSeparatorProperty.HexpandSet value -> widget.HexpandSet <- value
    | VSeparatorProperty.Vexpand value -> widget.Vexpand <- value
    | VSeparatorProperty.VexpandSet value -> widget.VexpandSet <- value
    | VSeparatorProperty.Expand value -> widget.Expand <- value
    | VSeparatorProperty.Opacity value -> widget.Opacity <- value
    | VSeparatorProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VSeparatorProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VSeparatorProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VSeparatorProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VSeparatorProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VSeparatorProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VSeparatorProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VSeparatorProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VSeparatorProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VSeparatorProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VSeparatorProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VSeparatorProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VSeparatorProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VSeparatorProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VSeparatorProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VSeparatorProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VSeparatorProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VSeparatorProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VSeparatorProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VSeparatorProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VSeparatorProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VSeparatorProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VSeparatorProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VSeparatorProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VSeparatorProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VSeparatorProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VSeparatorProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VSeparatorProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VSeparatorProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VSeparatorProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VSeparatorProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VSeparatorProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VSeparatorProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VSeparatorProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VSeparatorProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VSeparatorProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VSeparatorProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VSeparatorProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VSeparatorProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VSeparatorProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VSeparatorProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VSeparatorProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VSeparatorProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VSeparatorProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VSeparatorProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VSeparatorProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VSeparatorProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VSeparatorProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VSeparatorProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VSeparatorProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VSeparatorProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VSeparatorProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VSeparatorProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VSeparatorProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VSeparatorProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VSeparatorProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VSeparatorProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VSeparatorPropertyBuilder() =
    inherit BasePropertyBuilder<VSeparatorProperty>()
    [<CustomOperation("orientation")>]
    member this.Orientation(it: VSeparatorProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield VSeparatorProperty.Orientation value } 
    [<CustomOperation("name")>]
    member this.Name(it: VSeparatorProperty seq, value: System.String) =
        seq { yield! it; yield VSeparatorProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VSeparatorProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VSeparatorProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VSeparatorProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VSeparatorProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VSeparatorProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VSeparatorProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VSeparatorProperty seq, value: System.String) =
        seq { yield! it; yield VSeparatorProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VSeparatorProperty seq, value: System.String) =
        seq { yield! it; yield VSeparatorProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VSeparatorProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VSeparatorProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VSeparatorProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VSeparatorProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VSeparatorProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VSeparatorProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield VSeparatorProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield VSeparatorProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VSeparatorProperty seq, value: System.Double) =
        seq { yield! it; yield VSeparatorProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VSeparatorProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VSeparatorProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VSeparatorProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VSeparatorProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VSeparatorProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VSeparatorProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VSeparatorProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VSeparatorProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VSeparatorProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VSeparatorProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VSeparatorProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VSeparatorProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VSeparatorProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VSeparatorProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VSeparatorProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VSeparatorProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VSeparatorProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VSeparatorProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VSeparatorProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VSeparatorProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VSeparatorProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VSeparatorProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VSeparatorProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VSeparatorProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VSeparatorProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VSeparatorProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VSeparatorProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VSeparatorProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VSeparatorProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VSeparatorProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VSeparatorProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VSeparatorProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VSeparatorProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VSeparatorProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VSeparatorProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VSeparatorProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VSeparatorProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VSeparatorProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VSeparatorProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VSeparatorProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VSeparatorProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VSeparatorProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VSeparatorProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VSeparatorProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VSeparatorProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VSeparatorProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VSeparatorProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VSeparatorProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VSeparatorProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VSeparatorProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VSeparatorProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VSeparatorProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VSeparatorProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VSeparatorProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VSeparatorProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VSeparatorProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VSeparatorProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VSeparatorProperty.OnFocused value } 

let prop = VSeparatorPropertyBuilder()

type VSeparatorDescriptor(props) =
    inherit BaseWidgetDescriptor<VSeparator, VSeparatorProperty>(props, bindProperty)
    override this.CreateTyped() = new VSeparator()

let vSeparator props = VSeparatorDescriptor(props)

