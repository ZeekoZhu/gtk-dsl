module Gtk.DSL.Binding.ActionBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ActionBarProperty =
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

let bindProperty (widget: ActionBar) (prop: ActionBarProperty) =
    match prop with
    | ActionBarProperty.ResizeMode value -> widget.ResizeMode <- value
    | ActionBarProperty.BorderWidth value -> widget.BorderWidth <- value
    | ActionBarProperty.Name value -> widget.Name <- value
    | ActionBarProperty.Parent value -> widget.Parent <- value
    | ActionBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | ActionBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | ActionBarProperty.Visible value -> widget.Visible <- value
    | ActionBarProperty.Sensitive value -> widget.Sensitive <- value
    | ActionBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | ActionBarProperty.CanFocus value -> widget.CanFocus <- value
    | ActionBarProperty.HasFocus value -> widget.HasFocus <- value
    | ActionBarProperty.IsFocus value -> widget.IsFocus <- value
    | ActionBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ActionBarProperty.CanDefault value -> widget.CanDefault <- value
    | ActionBarProperty.HasDefault value -> widget.HasDefault <- value
    | ActionBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ActionBarProperty.Style value -> widget.Style <- value
    | ActionBarProperty.Events value -> widget.Events <- value
    | ActionBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | ActionBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | ActionBarProperty.TooltipText value -> widget.TooltipText <- value
    | ActionBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ActionBarProperty.Window value -> widget.Window <- value
    | ActionBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ActionBarProperty.Halign value -> widget.Halign <- value
    | ActionBarProperty.Valign value -> widget.Valign <- value
    | ActionBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | ActionBarProperty.MarginRight value -> widget.MarginRight <- value
    | ActionBarProperty.MarginStart value -> widget.MarginStart <- value
    | ActionBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | ActionBarProperty.MarginTop value -> widget.MarginTop <- value
    | ActionBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | ActionBarProperty.Margin value -> widget.Margin <- value
    | ActionBarProperty.Hexpand value -> widget.Hexpand <- value
    | ActionBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | ActionBarProperty.Vexpand value -> widget.Vexpand <- value
    | ActionBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | ActionBarProperty.Expand value -> widget.Expand <- value
    | ActionBarProperty.Opacity value -> widget.Opacity <- value
    | ActionBarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ActionBarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ActionBarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ActionBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ActionBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ActionBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ActionBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ActionBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ActionBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ActionBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ActionBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ActionBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ActionBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ActionBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ActionBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ActionBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ActionBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ActionBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ActionBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ActionBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ActionBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ActionBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ActionBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ActionBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ActionBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ActionBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ActionBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ActionBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ActionBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ActionBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ActionBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ActionBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ActionBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ActionBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ActionBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ActionBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ActionBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ActionBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ActionBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ActionBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ActionBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ActionBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ActionBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ActionBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ActionBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ActionBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ActionBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ActionBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ActionBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ActionBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ActionBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ActionBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ActionBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ActionBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ActionBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ActionBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ActionBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ActionBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ActionBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ActionBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ActionBarPropertyBuilder() =
    inherit BasePropertyBuilder<ActionBarProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ActionBarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ActionBarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ActionBarProperty seq, value: System.UInt32) =
        seq { yield! it; yield ActionBarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ActionBarProperty seq, value: System.String) =
        seq { yield! it; yield ActionBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ActionBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ActionBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ActionBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ActionBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ActionBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ActionBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ActionBarProperty seq, value: System.String) =
        seq { yield! it; yield ActionBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ActionBarProperty seq, value: System.String) =
        seq { yield! it; yield ActionBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ActionBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ActionBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ActionBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ActionBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ActionBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ActionBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ActionBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ActionBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ActionBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ActionBarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ActionBarProperty seq, value: System.Double) =
        seq { yield! it; yield ActionBarProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ActionBarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ActionBarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ActionBarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ActionBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ActionBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ActionBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ActionBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ActionBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ActionBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ActionBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ActionBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ActionBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ActionBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ActionBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ActionBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ActionBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ActionBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ActionBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ActionBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ActionBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ActionBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ActionBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ActionBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ActionBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ActionBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ActionBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ActionBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ActionBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ActionBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ActionBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ActionBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ActionBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ActionBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ActionBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ActionBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ActionBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ActionBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ActionBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ActionBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ActionBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ActionBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ActionBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ActionBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ActionBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ActionBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ActionBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ActionBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ActionBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ActionBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ActionBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ActionBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ActionBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ActionBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ActionBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ActionBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ActionBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ActionBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ActionBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ActionBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ActionBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ActionBarProperty.OnFocused value } 

let prop = ActionBarPropertyBuilder()

type ActionBarDescriptor(props) =
    inherit BaseWidgetDescriptor<ActionBar, ActionBarProperty>(props, bindProperty)
    override this.CreateTyped() = new ActionBar()

let actionBar props = ActionBarDescriptor(props)

