module Gtk.DSL.Binding.Paned
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PanedProperty =
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

let bindProperty (widget: Paned) (prop: PanedProperty) =
    match prop with
    | PanedProperty.Position value -> widget.Position <- value
    | PanedProperty.PositionSet value -> widget.PositionSet <- value
    | PanedProperty.WideHandle value -> widget.WideHandle <- value
    | PanedProperty.Orientation value -> widget.Orientation <- value
    | PanedProperty.ResizeMode value -> widget.ResizeMode <- value
    | PanedProperty.BorderWidth value -> widget.BorderWidth <- value
    | PanedProperty.Name value -> widget.Name <- value
    | PanedProperty.Parent value -> widget.Parent <- value
    | PanedProperty.WidthRequest value -> widget.WidthRequest <- value
    | PanedProperty.HeightRequest value -> widget.HeightRequest <- value
    | PanedProperty.Visible value -> widget.Visible <- value
    | PanedProperty.Sensitive value -> widget.Sensitive <- value
    | PanedProperty.AppPaintable value -> widget.AppPaintable <- value
    | PanedProperty.CanFocus value -> widget.CanFocus <- value
    | PanedProperty.HasFocus value -> widget.HasFocus <- value
    | PanedProperty.IsFocus value -> widget.IsFocus <- value
    | PanedProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PanedProperty.CanDefault value -> widget.CanDefault <- value
    | PanedProperty.HasDefault value -> widget.HasDefault <- value
    | PanedProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PanedProperty.Style value -> widget.Style <- value
    | PanedProperty.Events value -> widget.Events <- value
    | PanedProperty.NoShowAll value -> widget.NoShowAll <- value
    | PanedProperty.HasTooltip value -> widget.HasTooltip <- value
    | PanedProperty.TooltipText value -> widget.TooltipText <- value
    | PanedProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PanedProperty.Window value -> widget.Window <- value
    | PanedProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PanedProperty.Halign value -> widget.Halign <- value
    | PanedProperty.Valign value -> widget.Valign <- value
    | PanedProperty.MarginLeft value -> widget.MarginLeft <- value
    | PanedProperty.MarginRight value -> widget.MarginRight <- value
    | PanedProperty.MarginStart value -> widget.MarginStart <- value
    | PanedProperty.MarginEnd value -> widget.MarginEnd <- value
    | PanedProperty.MarginTop value -> widget.MarginTop <- value
    | PanedProperty.MarginBottom value -> widget.MarginBottom <- value
    | PanedProperty.Margin value -> widget.Margin <- value
    | PanedProperty.Hexpand value -> widget.Hexpand <- value
    | PanedProperty.HexpandSet value -> widget.HexpandSet <- value
    | PanedProperty.Vexpand value -> widget.Vexpand <- value
    | PanedProperty.VexpandSet value -> widget.VexpandSet <- value
    | PanedProperty.Expand value -> widget.Expand <- value
    | PanedProperty.Opacity value -> widget.Opacity <- value
    | PanedProperty.OnToggleHandleFocus handler -> 
        let disposable = widget.ToggleHandleFocus.Subscribe(handler)
        registerListener widget "ToggleHandleFocus" disposable
    | PanedProperty.OnCycleHandleFocus handler -> 
        let disposable = widget.CycleHandleFocus.Subscribe(handler)
        registerListener widget "CycleHandleFocus" disposable
    | PanedProperty.OnAcceptPosition handler -> 
        let disposable = widget.AcceptPosition.Subscribe(handler)
        registerListener widget "AcceptPosition" disposable
    | PanedProperty.OnMoveHandle handler -> 
        let disposable = widget.MoveHandle.Subscribe(handler)
        registerListener widget "MoveHandle" disposable
    | PanedProperty.OnCancelPosition handler -> 
        let disposable = widget.CancelPosition.Subscribe(handler)
        registerListener widget "CancelPosition" disposable
    | PanedProperty.OnCycleChildFocus handler -> 
        let disposable = widget.CycleChildFocus.Subscribe(handler)
        registerListener widget "CycleChildFocus" disposable
    | PanedProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PanedProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PanedProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PanedProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PanedProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PanedProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PanedProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PanedProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PanedProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PanedProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PanedProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PanedProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PanedProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PanedProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PanedProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PanedProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PanedProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PanedProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PanedProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PanedProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PanedProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PanedProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PanedProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PanedProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PanedProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PanedProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PanedProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PanedProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PanedProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PanedProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PanedProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PanedProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PanedProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PanedProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PanedProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PanedProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PanedProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PanedProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PanedProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PanedProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PanedProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PanedProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PanedProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PanedProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PanedProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PanedProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PanedProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PanedProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PanedProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PanedProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PanedProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PanedProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PanedProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PanedProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PanedProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PanedProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PanedProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PanedProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PanedProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PanedProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PanedPropertyBuilder() =
    inherit BasePropertyBuilder<PanedProperty>()
    [<CustomOperation("position")>]
    member this.Position(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.Position value } 
    [<CustomOperation("positionSet")>]
    member this.PositionSet(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.PositionSet value } 
    [<CustomOperation("wideHandle")>]
    member this.WideHandle(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.WideHandle value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: PanedProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield PanedProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PanedProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PanedProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PanedProperty seq, value: System.UInt32) =
        seq { yield! it; yield PanedProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PanedProperty seq, value: System.String) =
        seq { yield! it; yield PanedProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PanedProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PanedProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PanedProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PanedProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PanedProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PanedProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PanedProperty seq, value: System.String) =
        seq { yield! it; yield PanedProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PanedProperty seq, value: System.String) =
        seq { yield! it; yield PanedProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PanedProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PanedProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PanedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PanedProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PanedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PanedProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PanedProperty seq, value: System.Int32) =
        seq { yield! it; yield PanedProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield PanedProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PanedProperty seq, value: System.Double) =
        seq { yield! it; yield PanedProperty.Opacity value } 
    [<CustomOperation("onToggleHandleFocus")>]
    member this.OnToggleHandleFocus(it: PanedProperty seq, value: Gtk.ToggleHandleFocusArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnToggleHandleFocus value } 
    [<CustomOperation("onCycleHandleFocus")>]
    member this.OnCycleHandleFocus(it: PanedProperty seq, value: Gtk.CycleHandleFocusArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnCycleHandleFocus value } 
    [<CustomOperation("onAcceptPosition")>]
    member this.OnAcceptPosition(it: PanedProperty seq, value: Gtk.AcceptPositionArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnAcceptPosition value } 
    [<CustomOperation("onMoveHandle")>]
    member this.OnMoveHandle(it: PanedProperty seq, value: Gtk.MoveHandleArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnMoveHandle value } 
    [<CustomOperation("onCancelPosition")>]
    member this.OnCancelPosition(it: PanedProperty seq, value: Gtk.CancelPositionArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnCancelPosition value } 
    [<CustomOperation("onCycleChildFocus")>]
    member this.OnCycleChildFocus(it: PanedProperty seq, value: Gtk.CycleChildFocusArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnCycleChildFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PanedProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PanedProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PanedProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PanedProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PanedProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PanedProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PanedProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PanedProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PanedProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PanedProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PanedProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PanedProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PanedProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PanedProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PanedProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PanedProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PanedProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PanedProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PanedProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PanedProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PanedProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PanedProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PanedProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PanedProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PanedProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PanedProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PanedProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PanedProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PanedProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PanedProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PanedProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PanedProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PanedProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PanedProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PanedProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PanedProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PanedProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PanedProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PanedProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PanedProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PanedProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PanedProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PanedProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PanedProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PanedProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PanedProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PanedProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PanedProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PanedProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PanedProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PanedProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PanedProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PanedProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PanedProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PanedProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PanedProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PanedProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PanedProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PanedProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PanedProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PanedProperty.OnFocused value } 

let prop = PanedPropertyBuilder()

