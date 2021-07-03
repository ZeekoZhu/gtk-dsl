module Gtk.DSL.Binding.Fixed
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FixedProperty =
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

let bindProperty (widget: Fixed) (prop: FixedProperty) =
    match prop with
    | FixedProperty.ResizeMode value -> widget.ResizeMode <- value
    | FixedProperty.BorderWidth value -> widget.BorderWidth <- value
    | FixedProperty.Name value -> widget.Name <- value
    | FixedProperty.Parent value -> widget.Parent <- value
    | FixedProperty.WidthRequest value -> widget.WidthRequest <- value
    | FixedProperty.HeightRequest value -> widget.HeightRequest <- value
    | FixedProperty.Visible value -> widget.Visible <- value
    | FixedProperty.Sensitive value -> widget.Sensitive <- value
    | FixedProperty.AppPaintable value -> widget.AppPaintable <- value
    | FixedProperty.CanFocus value -> widget.CanFocus <- value
    | FixedProperty.HasFocus value -> widget.HasFocus <- value
    | FixedProperty.IsFocus value -> widget.IsFocus <- value
    | FixedProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FixedProperty.CanDefault value -> widget.CanDefault <- value
    | FixedProperty.HasDefault value -> widget.HasDefault <- value
    | FixedProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FixedProperty.Style value -> widget.Style <- value
    | FixedProperty.Events value -> widget.Events <- value
    | FixedProperty.NoShowAll value -> widget.NoShowAll <- value
    | FixedProperty.HasTooltip value -> widget.HasTooltip <- value
    | FixedProperty.TooltipText value -> widget.TooltipText <- value
    | FixedProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FixedProperty.Window value -> widget.Window <- value
    | FixedProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FixedProperty.Halign value -> widget.Halign <- value
    | FixedProperty.Valign value -> widget.Valign <- value
    | FixedProperty.MarginLeft value -> widget.MarginLeft <- value
    | FixedProperty.MarginRight value -> widget.MarginRight <- value
    | FixedProperty.MarginStart value -> widget.MarginStart <- value
    | FixedProperty.MarginEnd value -> widget.MarginEnd <- value
    | FixedProperty.MarginTop value -> widget.MarginTop <- value
    | FixedProperty.MarginBottom value -> widget.MarginBottom <- value
    | FixedProperty.Margin value -> widget.Margin <- value
    | FixedProperty.Hexpand value -> widget.Hexpand <- value
    | FixedProperty.HexpandSet value -> widget.HexpandSet <- value
    | FixedProperty.Vexpand value -> widget.Vexpand <- value
    | FixedProperty.VexpandSet value -> widget.VexpandSet <- value
    | FixedProperty.Expand value -> widget.Expand <- value
    | FixedProperty.Opacity value -> widget.Opacity <- value
    | FixedProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FixedProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FixedProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FixedProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FixedProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FixedProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FixedProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FixedProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FixedProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FixedProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FixedProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FixedProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FixedProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FixedProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FixedProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FixedProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FixedProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FixedProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FixedProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FixedProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FixedProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FixedProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FixedProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FixedProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FixedProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FixedProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FixedProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FixedProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FixedProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FixedProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FixedProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FixedProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FixedProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FixedProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FixedProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FixedProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FixedProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FixedProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FixedProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FixedProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FixedProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FixedProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FixedProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FixedProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FixedProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FixedProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FixedProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FixedProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FixedProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FixedProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FixedProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FixedProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FixedProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FixedProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FixedProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FixedProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FixedProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FixedProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FixedProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FixedProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FixedPropertyBuilder() =
    inherit BasePropertyBuilder<FixedProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FixedProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FixedProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FixedProperty seq, value: System.UInt32) =
        seq { yield! it; yield FixedProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FixedProperty seq, value: System.String) =
        seq { yield! it; yield FixedProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FixedProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FixedProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FixedProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FixedProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FixedProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FixedProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FixedProperty seq, value: System.String) =
        seq { yield! it; yield FixedProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FixedProperty seq, value: System.String) =
        seq { yield! it; yield FixedProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FixedProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FixedProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FixedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FixedProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FixedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FixedProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FixedProperty seq, value: System.Int32) =
        seq { yield! it; yield FixedProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FixedProperty seq, value: System.Boolean) =
        seq { yield! it; yield FixedProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FixedProperty seq, value: System.Double) =
        seq { yield! it; yield FixedProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FixedProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FixedProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FixedProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FixedProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FixedProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FixedProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FixedProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FixedProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FixedProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FixedProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FixedProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FixedProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FixedProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FixedProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FixedProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FixedProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FixedProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FixedProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FixedProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FixedProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FixedProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FixedProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FixedProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FixedProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FixedProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FixedProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FixedProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FixedProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FixedProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FixedProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FixedProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FixedProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FixedProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FixedProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FixedProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FixedProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FixedProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FixedProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FixedProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FixedProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FixedProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FixedProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FixedProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FixedProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FixedProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FixedProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FixedProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FixedProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FixedProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FixedProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FixedProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FixedProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FixedProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FixedProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FixedProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FixedProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FixedProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FixedProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FixedProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FixedProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FixedProperty.OnFocused value } 

let prop = FixedPropertyBuilder()

type FixedDescriptor(props) =
    inherit BaseWidgetDescriptor<Fixed, FixedProperty>(props, bindProperty)
    override this.CreateTyped() = new Fixed()

let _fixed props = FixedDescriptor(props)

