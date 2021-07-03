module Gtk.DSL.Binding.HandleBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HandleBoxProperty =
    | [<Obsolete>] HandlePosition of Gtk.PositionType
    | [<Obsolete>] SnapEdge of Gtk.PositionType
    | SnapEdgeSet of System.Boolean
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
    |  OnChildAttached of (Gtk.ChildAttachedArgs -> unit)
    |  OnChildDetached of (Gtk.ChildDetachedArgs -> unit)
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

let bindProperty (widget: HandleBox) (prop: HandleBoxProperty) =
    match prop with
    | HandleBoxProperty.HandlePosition value -> widget.HandlePosition <- value
    | HandleBoxProperty.SnapEdge value -> widget.SnapEdge <- value
    | HandleBoxProperty.SnapEdgeSet value -> widget.SnapEdgeSet <- value
    | HandleBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | HandleBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | HandleBoxProperty.Name value -> widget.Name <- value
    | HandleBoxProperty.Parent value -> widget.Parent <- value
    | HandleBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | HandleBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | HandleBoxProperty.Visible value -> widget.Visible <- value
    | HandleBoxProperty.Sensitive value -> widget.Sensitive <- value
    | HandleBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | HandleBoxProperty.CanFocus value -> widget.CanFocus <- value
    | HandleBoxProperty.HasFocus value -> widget.HasFocus <- value
    | HandleBoxProperty.IsFocus value -> widget.IsFocus <- value
    | HandleBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HandleBoxProperty.CanDefault value -> widget.CanDefault <- value
    | HandleBoxProperty.HasDefault value -> widget.HasDefault <- value
    | HandleBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HandleBoxProperty.Style value -> widget.Style <- value
    | HandleBoxProperty.Events value -> widget.Events <- value
    | HandleBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | HandleBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | HandleBoxProperty.TooltipText value -> widget.TooltipText <- value
    | HandleBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HandleBoxProperty.Window value -> widget.Window <- value
    | HandleBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HandleBoxProperty.Halign value -> widget.Halign <- value
    | HandleBoxProperty.Valign value -> widget.Valign <- value
    | HandleBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | HandleBoxProperty.MarginRight value -> widget.MarginRight <- value
    | HandleBoxProperty.MarginStart value -> widget.MarginStart <- value
    | HandleBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | HandleBoxProperty.MarginTop value -> widget.MarginTop <- value
    | HandleBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | HandleBoxProperty.Margin value -> widget.Margin <- value
    | HandleBoxProperty.Hexpand value -> widget.Hexpand <- value
    | HandleBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | HandleBoxProperty.Vexpand value -> widget.Vexpand <- value
    | HandleBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | HandleBoxProperty.Expand value -> widget.Expand <- value
    | HandleBoxProperty.Opacity value -> widget.Opacity <- value
    | HandleBoxProperty.OnChildAttached handler -> 
        let disposable = widget.ChildAttached.Subscribe(handler)
        registerListener widget "ChildAttached" disposable
    | HandleBoxProperty.OnChildDetached handler -> 
        let disposable = widget.ChildDetached.Subscribe(handler)
        registerListener widget "ChildDetached" disposable
    | HandleBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | HandleBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | HandleBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | HandleBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HandleBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HandleBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HandleBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HandleBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HandleBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HandleBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HandleBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HandleBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HandleBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HandleBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HandleBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HandleBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HandleBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HandleBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HandleBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HandleBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HandleBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HandleBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HandleBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HandleBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HandleBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HandleBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HandleBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HandleBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HandleBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HandleBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HandleBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HandleBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HandleBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HandleBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HandleBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HandleBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HandleBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HandleBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HandleBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HandleBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HandleBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HandleBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HandleBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HandleBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HandleBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HandleBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HandleBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HandleBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HandleBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HandleBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HandleBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HandleBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HandleBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HandleBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HandleBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HandleBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HandleBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HandleBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HandleBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HandleBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HandleBoxPropertyBuilder() =
    inherit BasePropertyBuilder<HandleBoxProperty>()
    [<Obsolete>]
    [<CustomOperation("handlePosition")>]
    member this.HandlePosition(it: HandleBoxProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield HandleBoxProperty.HandlePosition value } 
    [<Obsolete>]
    [<CustomOperation("snapEdge")>]
    member this.SnapEdge(it: HandleBoxProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield HandleBoxProperty.SnapEdge value } 
    [<CustomOperation("snapEdgeSet")>]
    member this.SnapEdgeSet(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.SnapEdgeSet value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: HandleBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield HandleBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: HandleBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield HandleBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: HandleBoxProperty seq, value: System.String) =
        seq { yield! it; yield HandleBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HandleBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HandleBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HandleBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HandleBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HandleBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HandleBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HandleBoxProperty seq, value: System.String) =
        seq { yield! it; yield HandleBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HandleBoxProperty seq, value: System.String) =
        seq { yield! it; yield HandleBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HandleBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HandleBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HandleBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HandleBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HandleBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HandleBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HandleBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HandleBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HandleBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HandleBoxProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HandleBoxProperty seq, value: System.Double) =
        seq { yield! it; yield HandleBoxProperty.Opacity value } 
    [<CustomOperation("onChildAttached")>]
    member this.OnChildAttached(it: HandleBoxProperty seq, value: Gtk.ChildAttachedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnChildAttached value } 
    [<CustomOperation("onChildDetached")>]
    member this.OnChildDetached(it: HandleBoxProperty seq, value: Gtk.ChildDetachedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnChildDetached value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: HandleBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: HandleBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: HandleBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HandleBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HandleBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HandleBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HandleBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HandleBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HandleBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HandleBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HandleBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HandleBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HandleBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HandleBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HandleBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HandleBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HandleBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HandleBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HandleBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HandleBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HandleBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HandleBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HandleBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HandleBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HandleBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HandleBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HandleBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HandleBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HandleBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HandleBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HandleBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HandleBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HandleBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HandleBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HandleBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HandleBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HandleBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HandleBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HandleBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HandleBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HandleBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HandleBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HandleBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HandleBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HandleBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HandleBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HandleBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HandleBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HandleBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HandleBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HandleBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HandleBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HandleBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HandleBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HandleBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HandleBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HandleBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HandleBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HandleBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HandleBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HandleBoxProperty.OnFocused value } 

let prop = HandleBoxPropertyBuilder()

type HandleBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<HandleBox, HandleBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new HandleBox()

let handleBox props = HandleBoxDescriptor(props)

