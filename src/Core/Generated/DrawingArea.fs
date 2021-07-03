module Gtk.DSL.Binding.DrawingArea
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type DrawingAreaProperty =
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

let bindProperty (widget: DrawingArea) (prop: DrawingAreaProperty) =
    match prop with
    | DrawingAreaProperty.Name value -> widget.Name <- value
    | DrawingAreaProperty.Parent value -> widget.Parent <- value
    | DrawingAreaProperty.WidthRequest value -> widget.WidthRequest <- value
    | DrawingAreaProperty.HeightRequest value -> widget.HeightRequest <- value
    | DrawingAreaProperty.Visible value -> widget.Visible <- value
    | DrawingAreaProperty.Sensitive value -> widget.Sensitive <- value
    | DrawingAreaProperty.AppPaintable value -> widget.AppPaintable <- value
    | DrawingAreaProperty.CanFocus value -> widget.CanFocus <- value
    | DrawingAreaProperty.HasFocus value -> widget.HasFocus <- value
    | DrawingAreaProperty.IsFocus value -> widget.IsFocus <- value
    | DrawingAreaProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | DrawingAreaProperty.CanDefault value -> widget.CanDefault <- value
    | DrawingAreaProperty.HasDefault value -> widget.HasDefault <- value
    | DrawingAreaProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | DrawingAreaProperty.Style value -> widget.Style <- value
    | DrawingAreaProperty.Events value -> widget.Events <- value
    | DrawingAreaProperty.NoShowAll value -> widget.NoShowAll <- value
    | DrawingAreaProperty.HasTooltip value -> widget.HasTooltip <- value
    | DrawingAreaProperty.TooltipText value -> widget.TooltipText <- value
    | DrawingAreaProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | DrawingAreaProperty.Window value -> widget.Window <- value
    | DrawingAreaProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | DrawingAreaProperty.Halign value -> widget.Halign <- value
    | DrawingAreaProperty.Valign value -> widget.Valign <- value
    | DrawingAreaProperty.MarginLeft value -> widget.MarginLeft <- value
    | DrawingAreaProperty.MarginRight value -> widget.MarginRight <- value
    | DrawingAreaProperty.MarginStart value -> widget.MarginStart <- value
    | DrawingAreaProperty.MarginEnd value -> widget.MarginEnd <- value
    | DrawingAreaProperty.MarginTop value -> widget.MarginTop <- value
    | DrawingAreaProperty.MarginBottom value -> widget.MarginBottom <- value
    | DrawingAreaProperty.Margin value -> widget.Margin <- value
    | DrawingAreaProperty.Hexpand value -> widget.Hexpand <- value
    | DrawingAreaProperty.HexpandSet value -> widget.HexpandSet <- value
    | DrawingAreaProperty.Vexpand value -> widget.Vexpand <- value
    | DrawingAreaProperty.VexpandSet value -> widget.VexpandSet <- value
    | DrawingAreaProperty.Expand value -> widget.Expand <- value
    | DrawingAreaProperty.Opacity value -> widget.Opacity <- value
    | DrawingAreaProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | DrawingAreaProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | DrawingAreaProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | DrawingAreaProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | DrawingAreaProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | DrawingAreaProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | DrawingAreaProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | DrawingAreaProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | DrawingAreaProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | DrawingAreaProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | DrawingAreaProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | DrawingAreaProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | DrawingAreaProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | DrawingAreaProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | DrawingAreaProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | DrawingAreaProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | DrawingAreaProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | DrawingAreaProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | DrawingAreaProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | DrawingAreaProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | DrawingAreaProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | DrawingAreaProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | DrawingAreaProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | DrawingAreaProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | DrawingAreaProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | DrawingAreaProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | DrawingAreaProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | DrawingAreaProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | DrawingAreaProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | DrawingAreaProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | DrawingAreaProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | DrawingAreaProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | DrawingAreaProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | DrawingAreaProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | DrawingAreaProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | DrawingAreaProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | DrawingAreaProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | DrawingAreaProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | DrawingAreaProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | DrawingAreaProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | DrawingAreaProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | DrawingAreaProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | DrawingAreaProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | DrawingAreaProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | DrawingAreaProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | DrawingAreaProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | DrawingAreaProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | DrawingAreaProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | DrawingAreaProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | DrawingAreaProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | DrawingAreaProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | DrawingAreaProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | DrawingAreaProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | DrawingAreaProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | DrawingAreaProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | DrawingAreaProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | DrawingAreaProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type DrawingAreaPropertyBuilder() =
    inherit BasePropertyBuilder<DrawingAreaProperty>()
    [<CustomOperation("name")>]
    member this.Name(it: DrawingAreaProperty seq, value: System.String) =
        seq { yield! it; yield DrawingAreaProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: DrawingAreaProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield DrawingAreaProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: DrawingAreaProperty seq, value: Gtk.Style) =
        seq { yield! it; yield DrawingAreaProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: DrawingAreaProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield DrawingAreaProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: DrawingAreaProperty seq, value: System.String) =
        seq { yield! it; yield DrawingAreaProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: DrawingAreaProperty seq, value: System.String) =
        seq { yield! it; yield DrawingAreaProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: DrawingAreaProperty seq, value: Gdk.Window) =
        seq { yield! it; yield DrawingAreaProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: DrawingAreaProperty seq, value: Gtk.Align) =
        seq { yield! it; yield DrawingAreaProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: DrawingAreaProperty seq, value: Gtk.Align) =
        seq { yield! it; yield DrawingAreaProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: DrawingAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield DrawingAreaProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: DrawingAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield DrawingAreaProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: DrawingAreaProperty seq, value: System.Double) =
        seq { yield! it; yield DrawingAreaProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: DrawingAreaProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: DrawingAreaProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: DrawingAreaProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: DrawingAreaProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: DrawingAreaProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: DrawingAreaProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: DrawingAreaProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: DrawingAreaProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: DrawingAreaProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: DrawingAreaProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: DrawingAreaProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: DrawingAreaProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: DrawingAreaProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: DrawingAreaProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: DrawingAreaProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: DrawingAreaProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: DrawingAreaProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: DrawingAreaProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: DrawingAreaProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: DrawingAreaProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: DrawingAreaProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: DrawingAreaProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: DrawingAreaProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: DrawingAreaProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: DrawingAreaProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: DrawingAreaProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: DrawingAreaProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: DrawingAreaProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: DrawingAreaProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: DrawingAreaProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: DrawingAreaProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: DrawingAreaProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: DrawingAreaProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: DrawingAreaProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: DrawingAreaProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: DrawingAreaProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: DrawingAreaProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: DrawingAreaProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: DrawingAreaProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: DrawingAreaProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: DrawingAreaProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: DrawingAreaProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: DrawingAreaProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: DrawingAreaProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: DrawingAreaProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: DrawingAreaProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: DrawingAreaProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: DrawingAreaProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: DrawingAreaProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: DrawingAreaProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: DrawingAreaProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: DrawingAreaProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: DrawingAreaProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: DrawingAreaProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: DrawingAreaProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: DrawingAreaProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: DrawingAreaProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield DrawingAreaProperty.OnFocused value } 

let prop = DrawingAreaPropertyBuilder()

type DrawingAreaDescriptor(props) =
    inherit BaseWidgetDescriptor<DrawingArea, DrawingAreaProperty>(props, bindProperty)
    override this.CreateTyped() = new DrawingArea()

let drawingArea props = DrawingAreaDescriptor(props)

