module Gtk.DSL.Binding.HPaned
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HPanedProperty =
    | Position of System.Int32
    | PositionSet of System.Boolean
    | WideHandle of System.Boolean
    | Orientation of Gtk.Orientation
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
    |  OnToggleHandleFocus of (Gtk.ToggleHandleFocusArgs -> unit)
    |  OnCycleHandleFocus of (Gtk.CycleHandleFocusArgs -> unit)
    |  OnAcceptPosition of (Gtk.AcceptPositionArgs -> unit)
    |  OnMoveHandle of (Gtk.MoveHandleArgs -> unit)
    |  OnCancelPosition of (Gtk.CancelPositionArgs -> unit)
    |  OnCycleChildFocus of (Gtk.CycleChildFocusArgs -> unit)
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

let bindProperty (widget: HPaned) (prop: HPanedProperty) =
    match prop with
    | HPanedProperty.Position value -> widget.Position <- value
    | HPanedProperty.PositionSet value -> widget.PositionSet <- value
    | HPanedProperty.WideHandle value -> widget.WideHandle <- value
    | HPanedProperty.Orientation value -> widget.Orientation <- value
    | HPanedProperty.ResizeMode value -> widget.ResizeMode <- value
    | HPanedProperty.BorderWidth value -> widget.BorderWidth <- value
    | HPanedProperty.Name value -> widget.Name <- value
    | HPanedProperty.Parent value -> widget.Parent <- value
    | HPanedProperty.WidthRequest value -> widget.WidthRequest <- value
    | HPanedProperty.HeightRequest value -> widget.HeightRequest <- value
    | HPanedProperty.Visible value -> widget.Visible <- value
    | HPanedProperty.Sensitive value -> widget.Sensitive <- value
    | HPanedProperty.AppPaintable value -> widget.AppPaintable <- value
    | HPanedProperty.CanFocus value -> widget.CanFocus <- value
    | HPanedProperty.HasFocus value -> widget.HasFocus <- value
    | HPanedProperty.IsFocus value -> widget.IsFocus <- value
    | HPanedProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HPanedProperty.CanDefault value -> widget.CanDefault <- value
    | HPanedProperty.HasDefault value -> widget.HasDefault <- value
    | HPanedProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HPanedProperty.Style value -> widget.Style <- value
    | HPanedProperty.Events value -> widget.Events <- value
    | HPanedProperty.NoShowAll value -> widget.NoShowAll <- value
    | HPanedProperty.HasTooltip value -> widget.HasTooltip <- value
    | HPanedProperty.TooltipText value -> widget.TooltipText <- value
    | HPanedProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HPanedProperty.Window value -> widget.Window <- value
    | HPanedProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HPanedProperty.Halign value -> widget.Halign <- value
    | HPanedProperty.Valign value -> widget.Valign <- value
    | HPanedProperty.MarginLeft value -> widget.MarginLeft <- value
    | HPanedProperty.MarginRight value -> widget.MarginRight <- value
    | HPanedProperty.MarginStart value -> widget.MarginStart <- value
    | HPanedProperty.MarginEnd value -> widget.MarginEnd <- value
    | HPanedProperty.MarginTop value -> widget.MarginTop <- value
    | HPanedProperty.MarginBottom value -> widget.MarginBottom <- value
    | HPanedProperty.Margin value -> widget.Margin <- value
    | HPanedProperty.Hexpand value -> widget.Hexpand <- value
    | HPanedProperty.HexpandSet value -> widget.HexpandSet <- value
    | HPanedProperty.Vexpand value -> widget.Vexpand <- value
    | HPanedProperty.VexpandSet value -> widget.VexpandSet <- value
    | HPanedProperty.Expand value -> widget.Expand <- value
    | HPanedProperty.Opacity value -> widget.Opacity <- value
    | HPanedProperty.OnToggleHandleFocus handler -> 
        let disposable = widget.ToggleHandleFocus.Subscribe(handler)
        registerListener widget "ToggleHandleFocus" disposable
    | HPanedProperty.OnCycleHandleFocus handler -> 
        let disposable = widget.CycleHandleFocus.Subscribe(handler)
        registerListener widget "CycleHandleFocus" disposable
    | HPanedProperty.OnAcceptPosition handler -> 
        let disposable = widget.AcceptPosition.Subscribe(handler)
        registerListener widget "AcceptPosition" disposable
    | HPanedProperty.OnMoveHandle handler -> 
        let disposable = widget.MoveHandle.Subscribe(handler)
        registerListener widget "MoveHandle" disposable
    | HPanedProperty.OnCancelPosition handler -> 
        let disposable = widget.CancelPosition.Subscribe(handler)
        registerListener widget "CancelPosition" disposable
    | HPanedProperty.OnCycleChildFocus handler -> 
        let disposable = widget.CycleChildFocus.Subscribe(handler)
        registerListener widget "CycleChildFocus" disposable
    | HPanedProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | HPanedProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | HPanedProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | HPanedProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HPanedProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HPanedProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HPanedProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HPanedProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HPanedProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HPanedProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HPanedProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HPanedProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HPanedProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HPanedProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HPanedProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HPanedProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HPanedProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HPanedProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HPanedProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HPanedProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HPanedProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HPanedProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HPanedProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HPanedProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HPanedProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HPanedProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HPanedProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HPanedProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HPanedProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HPanedProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HPanedProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HPanedProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HPanedProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HPanedProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HPanedProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HPanedProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HPanedProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HPanedProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HPanedProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HPanedProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HPanedProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HPanedProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HPanedProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HPanedProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HPanedProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HPanedProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HPanedProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HPanedProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HPanedProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HPanedProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HPanedProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HPanedProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HPanedProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HPanedProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HPanedProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HPanedProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HPanedProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HPanedProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HPanedProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HPanedProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HPanedPropertyBuilder() =
    inherit BasePropertyBuilder<HPanedProperty>()
    [<CustomOperation("position")>]
    member this.Position(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.Position value } 
    [<CustomOperation("positionSet")>]
    member this.PositionSet(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.PositionSet value } 
    [<CustomOperation("wideHandle")>]
    member this.WideHandle(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.WideHandle value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: HPanedProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield HPanedProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: HPanedProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield HPanedProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: HPanedProperty seq, value: System.UInt32) =
        seq { yield! it; yield HPanedProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: HPanedProperty seq, value: System.String) =
        seq { yield! it; yield HPanedProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HPanedProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HPanedProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HPanedProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HPanedProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HPanedProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HPanedProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HPanedProperty seq, value: System.String) =
        seq { yield! it; yield HPanedProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HPanedProperty seq, value: System.String) =
        seq { yield! it; yield HPanedProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HPanedProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HPanedProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HPanedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HPanedProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HPanedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HPanedProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield HPanedProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield HPanedProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HPanedProperty seq, value: System.Double) =
        seq { yield! it; yield HPanedProperty.Opacity value } 
    [<CustomOperation("onToggleHandleFocus")>]
    member this.OnToggleHandleFocus(it: HPanedProperty seq, value: Gtk.ToggleHandleFocusArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnToggleHandleFocus value } 
    [<CustomOperation("onCycleHandleFocus")>]
    member this.OnCycleHandleFocus(it: HPanedProperty seq, value: Gtk.CycleHandleFocusArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnCycleHandleFocus value } 
    [<CustomOperation("onAcceptPosition")>]
    member this.OnAcceptPosition(it: HPanedProperty seq, value: Gtk.AcceptPositionArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnAcceptPosition value } 
    [<CustomOperation("onMoveHandle")>]
    member this.OnMoveHandle(it: HPanedProperty seq, value: Gtk.MoveHandleArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnMoveHandle value } 
    [<CustomOperation("onCancelPosition")>]
    member this.OnCancelPosition(it: HPanedProperty seq, value: Gtk.CancelPositionArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnCancelPosition value } 
    [<CustomOperation("onCycleChildFocus")>]
    member this.OnCycleChildFocus(it: HPanedProperty seq, value: Gtk.CycleChildFocusArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnCycleChildFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: HPanedProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: HPanedProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: HPanedProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HPanedProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HPanedProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HPanedProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HPanedProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HPanedProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HPanedProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HPanedProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HPanedProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HPanedProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HPanedProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HPanedProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HPanedProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HPanedProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HPanedProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HPanedProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HPanedProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HPanedProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HPanedProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HPanedProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HPanedProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HPanedProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HPanedProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HPanedProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HPanedProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HPanedProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HPanedProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HPanedProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HPanedProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HPanedProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HPanedProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HPanedProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HPanedProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HPanedProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HPanedProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HPanedProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HPanedProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HPanedProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HPanedProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HPanedProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HPanedProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HPanedProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HPanedProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HPanedProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HPanedProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HPanedProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HPanedProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HPanedProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HPanedProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HPanedProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HPanedProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HPanedProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HPanedProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HPanedProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HPanedProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HPanedProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HPanedProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HPanedProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HPanedProperty.OnFocused value } 

let prop = HPanedPropertyBuilder()

type HPanedDescriptor(props) =
    inherit BaseWidgetDescriptor<HPaned, HPanedProperty>(props, bindProperty)
    override this.CreateTyped() = new HPaned()

let hPaned props = HPanedDescriptor(props)

