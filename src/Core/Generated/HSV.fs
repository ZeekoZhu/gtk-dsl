module Gtk.DSL.Binding.HSV
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HSVProperty =
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
    |  OnMove of (Gtk.MoveArgs -> unit)
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

let bindProperty (widget: HSV) (prop: HSVProperty) =
    match prop with
    | HSVProperty.Name value -> widget.Name <- value
    | HSVProperty.Parent value -> widget.Parent <- value
    | HSVProperty.WidthRequest value -> widget.WidthRequest <- value
    | HSVProperty.HeightRequest value -> widget.HeightRequest <- value
    | HSVProperty.Visible value -> widget.Visible <- value
    | HSVProperty.Sensitive value -> widget.Sensitive <- value
    | HSVProperty.AppPaintable value -> widget.AppPaintable <- value
    | HSVProperty.CanFocus value -> widget.CanFocus <- value
    | HSVProperty.HasFocus value -> widget.HasFocus <- value
    | HSVProperty.IsFocus value -> widget.IsFocus <- value
    | HSVProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HSVProperty.CanDefault value -> widget.CanDefault <- value
    | HSVProperty.HasDefault value -> widget.HasDefault <- value
    | HSVProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HSVProperty.Style value -> widget.Style <- value
    | HSVProperty.Events value -> widget.Events <- value
    | HSVProperty.NoShowAll value -> widget.NoShowAll <- value
    | HSVProperty.HasTooltip value -> widget.HasTooltip <- value
    | HSVProperty.TooltipText value -> widget.TooltipText <- value
    | HSVProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HSVProperty.Window value -> widget.Window <- value
    | HSVProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HSVProperty.Halign value -> widget.Halign <- value
    | HSVProperty.Valign value -> widget.Valign <- value
    | HSVProperty.MarginLeft value -> widget.MarginLeft <- value
    | HSVProperty.MarginRight value -> widget.MarginRight <- value
    | HSVProperty.MarginStart value -> widget.MarginStart <- value
    | HSVProperty.MarginEnd value -> widget.MarginEnd <- value
    | HSVProperty.MarginTop value -> widget.MarginTop <- value
    | HSVProperty.MarginBottom value -> widget.MarginBottom <- value
    | HSVProperty.Margin value -> widget.Margin <- value
    | HSVProperty.Hexpand value -> widget.Hexpand <- value
    | HSVProperty.HexpandSet value -> widget.HexpandSet <- value
    | HSVProperty.Vexpand value -> widget.Vexpand <- value
    | HSVProperty.VexpandSet value -> widget.VexpandSet <- value
    | HSVProperty.Expand value -> widget.Expand <- value
    | HSVProperty.Opacity value -> widget.Opacity <- value
    | HSVProperty.OnMove handler -> 
        let disposable = widget.Move.Subscribe(handler)
        registerListener widget "Move" disposable
    | HSVProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HSVProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HSVProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HSVProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HSVProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HSVProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HSVProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HSVProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HSVProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HSVProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HSVProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HSVProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HSVProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HSVProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HSVProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HSVProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HSVProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HSVProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HSVProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HSVProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HSVProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HSVProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HSVProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HSVProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HSVProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HSVProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HSVProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HSVProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HSVProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HSVProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HSVProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HSVProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HSVProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HSVProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HSVProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HSVProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HSVProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HSVProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HSVProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HSVProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HSVProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HSVProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HSVProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HSVProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HSVProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HSVProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HSVProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HSVProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HSVProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HSVProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HSVProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HSVProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HSVProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HSVProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HSVProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HSVProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HSVProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HSVPropertyBuilder() =
    inherit BasePropertyBuilder<HSVProperty>()
    [<CustomOperation("name")>]
    member this.Name(it: HSVProperty seq, value: System.String) =
        seq { yield! it; yield HSVProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HSVProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HSVProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HSVProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HSVProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HSVProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HSVProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HSVProperty seq, value: System.String) =
        seq { yield! it; yield HSVProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HSVProperty seq, value: System.String) =
        seq { yield! it; yield HSVProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HSVProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HSVProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HSVProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HSVProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HSVProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HSVProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HSVProperty seq, value: System.Int32) =
        seq { yield! it; yield HSVProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HSVProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSVProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HSVProperty seq, value: System.Double) =
        seq { yield! it; yield HSVProperty.Opacity value } 
    [<CustomOperation("onMove")>]
    member this.OnMove(it: HSVProperty seq, value: Gtk.MoveArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnMove value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HSVProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HSVProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HSVProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HSVProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HSVProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HSVProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HSVProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HSVProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HSVProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HSVProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HSVProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HSVProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HSVProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HSVProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HSVProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HSVProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HSVProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HSVProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HSVProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HSVProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HSVProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HSVProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HSVProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HSVProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HSVProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HSVProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HSVProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HSVProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HSVProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HSVProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HSVProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HSVProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HSVProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HSVProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HSVProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HSVProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HSVProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HSVProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HSVProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HSVProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HSVProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HSVProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HSVProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HSVProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HSVProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HSVProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HSVProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HSVProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HSVProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HSVProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HSVProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HSVProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HSVProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HSVProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HSVProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HSVProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HSVProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HSVProperty.OnFocused value } 

let prop = HSVPropertyBuilder()

type HSVDescriptor(props) =
    inherit BaseWidgetDescriptor<HSV, HSVProperty>(props, bindProperty)
    override this.CreateTyped() = new HSV()

let hSV props = HSVDescriptor(props)

