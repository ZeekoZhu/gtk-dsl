module GtkDsl.Binding.VPaned
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VPanedProperty =
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

let bindProperty (widget: VPaned) (prop: VPanedProperty) =
    match prop with
    | VPanedProperty.Position value -> widget.Position <- value
    | VPanedProperty.PositionSet value -> widget.PositionSet <- value
    | VPanedProperty.WideHandle value -> widget.WideHandle <- value
    | VPanedProperty.Orientation value -> widget.Orientation <- value
    | VPanedProperty.ResizeMode value -> widget.ResizeMode <- value
    | VPanedProperty.BorderWidth value -> widget.BorderWidth <- value
    | VPanedProperty.Name value -> widget.Name <- value
    | VPanedProperty.Parent value -> widget.Parent <- value
    | VPanedProperty.WidthRequest value -> widget.WidthRequest <- value
    | VPanedProperty.HeightRequest value -> widget.HeightRequest <- value
    | VPanedProperty.Visible value -> widget.Visible <- value
    | VPanedProperty.Sensitive value -> widget.Sensitive <- value
    | VPanedProperty.AppPaintable value -> widget.AppPaintable <- value
    | VPanedProperty.CanFocus value -> widget.CanFocus <- value
    | VPanedProperty.HasFocus value -> widget.HasFocus <- value
    | VPanedProperty.IsFocus value -> widget.IsFocus <- value
    | VPanedProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VPanedProperty.CanDefault value -> widget.CanDefault <- value
    | VPanedProperty.HasDefault value -> widget.HasDefault <- value
    | VPanedProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VPanedProperty.Style value -> widget.Style <- value
    | VPanedProperty.Events value -> widget.Events <- value
    | VPanedProperty.NoShowAll value -> widget.NoShowAll <- value
    | VPanedProperty.HasTooltip value -> widget.HasTooltip <- value
    | VPanedProperty.TooltipText value -> widget.TooltipText <- value
    | VPanedProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VPanedProperty.Window value -> widget.Window <- value
    | VPanedProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VPanedProperty.Halign value -> widget.Halign <- value
    | VPanedProperty.Valign value -> widget.Valign <- value
    | VPanedProperty.MarginLeft value -> widget.MarginLeft <- value
    | VPanedProperty.MarginRight value -> widget.MarginRight <- value
    | VPanedProperty.MarginStart value -> widget.MarginStart <- value
    | VPanedProperty.MarginEnd value -> widget.MarginEnd <- value
    | VPanedProperty.MarginTop value -> widget.MarginTop <- value
    | VPanedProperty.MarginBottom value -> widget.MarginBottom <- value
    | VPanedProperty.Margin value -> widget.Margin <- value
    | VPanedProperty.Hexpand value -> widget.Hexpand <- value
    | VPanedProperty.HexpandSet value -> widget.HexpandSet <- value
    | VPanedProperty.Vexpand value -> widget.Vexpand <- value
    | VPanedProperty.VexpandSet value -> widget.VexpandSet <- value
    | VPanedProperty.Expand value -> widget.Expand <- value
    | VPanedProperty.Opacity value -> widget.Opacity <- value
    | VPanedProperty.OnToggleHandleFocus handler -> 
        let disposable = widget.ToggleHandleFocus.Subscribe(handler)
        registerListener widget "ToggleHandleFocus" disposable
    | VPanedProperty.OnCycleHandleFocus handler -> 
        let disposable = widget.CycleHandleFocus.Subscribe(handler)
        registerListener widget "CycleHandleFocus" disposable
    | VPanedProperty.OnAcceptPosition handler -> 
        let disposable = widget.AcceptPosition.Subscribe(handler)
        registerListener widget "AcceptPosition" disposable
    | VPanedProperty.OnMoveHandle handler -> 
        let disposable = widget.MoveHandle.Subscribe(handler)
        registerListener widget "MoveHandle" disposable
    | VPanedProperty.OnCancelPosition handler -> 
        let disposable = widget.CancelPosition.Subscribe(handler)
        registerListener widget "CancelPosition" disposable
    | VPanedProperty.OnCycleChildFocus handler -> 
        let disposable = widget.CycleChildFocus.Subscribe(handler)
        registerListener widget "CycleChildFocus" disposable
    | VPanedProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | VPanedProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | VPanedProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | VPanedProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VPanedProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VPanedProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VPanedProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VPanedProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VPanedProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VPanedProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VPanedProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VPanedProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VPanedProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VPanedProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VPanedProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VPanedProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VPanedProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VPanedProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VPanedProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VPanedProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VPanedProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VPanedProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VPanedProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VPanedProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VPanedProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VPanedProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VPanedProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VPanedProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VPanedProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VPanedProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VPanedProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VPanedProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VPanedProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VPanedProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VPanedProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VPanedProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VPanedProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VPanedProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VPanedProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VPanedProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VPanedProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VPanedProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VPanedProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VPanedProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VPanedProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VPanedProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VPanedProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VPanedProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VPanedProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VPanedProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VPanedProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VPanedProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VPanedProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VPanedProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VPanedProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VPanedProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VPanedProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VPanedProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VPanedProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VPanedProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VPanedPropertyBuilder() =
    inherit BasePropertyBuilder<VPanedProperty>()
    [<CustomOperation("position")>]
    member this.Position(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.Position value } 
    [<CustomOperation("positionSet")>]
    member this.PositionSet(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.PositionSet value } 
    [<CustomOperation("wideHandle")>]
    member this.WideHandle(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.WideHandle value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: VPanedProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield VPanedProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: VPanedProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield VPanedProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: VPanedProperty seq, value: System.UInt32) =
        seq { yield! it; yield VPanedProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: VPanedProperty seq, value: System.String) =
        seq { yield! it; yield VPanedProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VPanedProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VPanedProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VPanedProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VPanedProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VPanedProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VPanedProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VPanedProperty seq, value: System.String) =
        seq { yield! it; yield VPanedProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VPanedProperty seq, value: System.String) =
        seq { yield! it; yield VPanedProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VPanedProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VPanedProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VPanedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VPanedProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VPanedProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VPanedProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VPanedProperty seq, value: System.Int32) =
        seq { yield! it; yield VPanedProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VPanedProperty seq, value: System.Boolean) =
        seq { yield! it; yield VPanedProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VPanedProperty seq, value: System.Double) =
        seq { yield! it; yield VPanedProperty.Opacity value } 
    [<CustomOperation("onToggleHandleFocus")>]
    member this.OnToggleHandleFocus(it: VPanedProperty seq, value: Gtk.ToggleHandleFocusArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnToggleHandleFocus value } 
    [<CustomOperation("onCycleHandleFocus")>]
    member this.OnCycleHandleFocus(it: VPanedProperty seq, value: Gtk.CycleHandleFocusArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnCycleHandleFocus value } 
    [<CustomOperation("onAcceptPosition")>]
    member this.OnAcceptPosition(it: VPanedProperty seq, value: Gtk.AcceptPositionArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnAcceptPosition value } 
    [<CustomOperation("onMoveHandle")>]
    member this.OnMoveHandle(it: VPanedProperty seq, value: Gtk.MoveHandleArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnMoveHandle value } 
    [<CustomOperation("onCancelPosition")>]
    member this.OnCancelPosition(it: VPanedProperty seq, value: Gtk.CancelPositionArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnCancelPosition value } 
    [<CustomOperation("onCycleChildFocus")>]
    member this.OnCycleChildFocus(it: VPanedProperty seq, value: Gtk.CycleChildFocusArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnCycleChildFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: VPanedProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: VPanedProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: VPanedProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VPanedProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VPanedProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VPanedProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VPanedProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VPanedProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VPanedProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VPanedProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VPanedProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VPanedProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VPanedProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VPanedProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VPanedProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VPanedProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VPanedProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VPanedProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VPanedProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VPanedProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VPanedProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VPanedProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VPanedProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VPanedProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VPanedProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VPanedProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VPanedProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VPanedProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VPanedProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VPanedProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VPanedProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VPanedProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VPanedProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VPanedProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VPanedProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VPanedProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VPanedProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VPanedProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VPanedProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VPanedProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VPanedProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VPanedProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VPanedProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VPanedProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VPanedProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VPanedProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VPanedProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VPanedProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VPanedProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VPanedProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VPanedProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VPanedProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VPanedProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VPanedProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VPanedProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VPanedProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VPanedProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VPanedProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VPanedProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VPanedProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VPanedProperty.OnFocused value } 

let prop = VPanedPropertyBuilder()

type VPanedDescriptor(props) =
    inherit BaseWidgetDescriptor<VPaned, VPanedProperty>(props, bindProperty)
    override this.CreateTyped() = new VPaned()

let vPaned props = VPanedDescriptor(props)

