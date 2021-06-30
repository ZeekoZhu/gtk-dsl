module GtkDsl.Binding.EventBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type EventBoxProperty =
    | VisibleWindow of System.Boolean
    | AboveChild of System.Boolean
    | [<Obsolete>] ResizeMode of Gtk.ResizeMode
    | BorderWidth of System.UInt32
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
    |  OnFocusChildSet of (Gtk.FocusChildSetArgs -> unit)
    |  OnRemoved of (Gtk.RemovedArgs -> unit)
    |  OnAdded of (Gtk.AddedArgs -> unit)
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

let bindProperty (widget: EventBox) (prop: EventBoxProperty) =
    match prop with
    | EventBoxProperty.VisibleWindow value -> widget.VisibleWindow <- value
    | EventBoxProperty.AboveChild value -> widget.AboveChild <- value
    | EventBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | EventBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | EventBoxProperty.Name value -> widget.Name <- value
    | EventBoxProperty.Parent value -> widget.Parent <- value
    | EventBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | EventBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | EventBoxProperty.Visible value -> widget.Visible <- value
    | EventBoxProperty.Sensitive value -> widget.Sensitive <- value
    | EventBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | EventBoxProperty.CanFocus value -> widget.CanFocus <- value
    | EventBoxProperty.HasFocus value -> widget.HasFocus <- value
    | EventBoxProperty.IsFocus value -> widget.IsFocus <- value
    | EventBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | EventBoxProperty.CanDefault value -> widget.CanDefault <- value
    | EventBoxProperty.HasDefault value -> widget.HasDefault <- value
    | EventBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | EventBoxProperty.Style value -> widget.Style <- value
    | EventBoxProperty.Events value -> widget.Events <- value
    | EventBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | EventBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | EventBoxProperty.TooltipText value -> widget.TooltipText <- value
    | EventBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | EventBoxProperty.Window value -> widget.Window <- value
    | EventBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | EventBoxProperty.Halign value -> widget.Halign <- value
    | EventBoxProperty.Valign value -> widget.Valign <- value
    | EventBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | EventBoxProperty.MarginRight value -> widget.MarginRight <- value
    | EventBoxProperty.MarginStart value -> widget.MarginStart <- value
    | EventBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | EventBoxProperty.MarginTop value -> widget.MarginTop <- value
    | EventBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | EventBoxProperty.Margin value -> widget.Margin <- value
    | EventBoxProperty.Hexpand value -> widget.Hexpand <- value
    | EventBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | EventBoxProperty.Vexpand value -> widget.Vexpand <- value
    | EventBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | EventBoxProperty.Expand value -> widget.Expand <- value
    | EventBoxProperty.Opacity value -> widget.Opacity <- value
    | EventBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | EventBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | EventBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | EventBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | EventBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | EventBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | EventBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | EventBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | EventBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | EventBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | EventBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | EventBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | EventBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | EventBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | EventBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | EventBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | EventBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | EventBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | EventBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | EventBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | EventBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | EventBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | EventBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | EventBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | EventBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | EventBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | EventBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | EventBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | EventBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | EventBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | EventBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | EventBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | EventBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | EventBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | EventBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | EventBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | EventBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | EventBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | EventBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | EventBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | EventBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | EventBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | EventBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | EventBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | EventBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | EventBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | EventBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | EventBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | EventBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | EventBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | EventBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | EventBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | EventBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | EventBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | EventBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | EventBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | EventBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | EventBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | EventBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | EventBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type EventBoxPropertyBuilder() =
    inherit BasePropertyBuilder<EventBoxProperty>()
    [<CustomOperation("visibleWindow")>]
    member this.VisibleWindow(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.VisibleWindow value } 
    [<CustomOperation("aboveChild")>]
    member this.AboveChild(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.AboveChild value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: EventBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield EventBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: EventBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield EventBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: EventBoxProperty seq, value: System.String) =
        seq { yield! it; yield EventBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: EventBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield EventBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: EventBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield EventBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: EventBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield EventBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: EventBoxProperty seq, value: System.String) =
        seq { yield! it; yield EventBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: EventBoxProperty seq, value: System.String) =
        seq { yield! it; yield EventBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: EventBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield EventBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: EventBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield EventBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: EventBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield EventBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: EventBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield EventBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: EventBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield EventBoxProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: EventBoxProperty seq, value: System.Double) =
        seq { yield! it; yield EventBoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: EventBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: EventBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: EventBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: EventBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: EventBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: EventBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: EventBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: EventBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: EventBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: EventBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: EventBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: EventBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: EventBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: EventBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: EventBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: EventBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: EventBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: EventBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: EventBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: EventBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: EventBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: EventBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: EventBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: EventBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: EventBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: EventBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: EventBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: EventBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: EventBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: EventBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: EventBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: EventBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: EventBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: EventBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: EventBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: EventBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: EventBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: EventBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: EventBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: EventBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: EventBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: EventBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: EventBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: EventBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: EventBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: EventBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: EventBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: EventBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: EventBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: EventBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: EventBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: EventBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: EventBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: EventBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: EventBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: EventBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: EventBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: EventBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: EventBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: EventBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield EventBoxProperty.OnFocused value } 

let prop = EventBoxPropertyBuilder()

type EventBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<EventBox, EventBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new EventBox()

let eventBox props = EventBoxDescriptor(props)

