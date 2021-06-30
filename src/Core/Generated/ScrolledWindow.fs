module GtkDsl.Binding.ScrolledWindow
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ScrolledWindowProperty =
    | Hadjustment of Gtk.Adjustment
    | Vadjustment of Gtk.Adjustment
    | HscrollbarPolicy of Gtk.PolicyType
    | VscrollbarPolicy of Gtk.PolicyType
    | WindowPlacement of Gtk.CornerType
    | WindowPlacementSet of System.Boolean
    | ShadowType of Gtk.ShadowType
    | MinContentWidth of System.Int32
    | MinContentHeight of System.Int32
    | KineticScrolling of System.Boolean
    | OverlayScrolling of System.Boolean
    | MaxContentWidth of System.Int32
    | MaxContentHeight of System.Int32
    | PropagateNaturalWidth of System.Boolean
    | PropagateNaturalHeight of System.Boolean
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
    |  OnScrollChild of (Gtk.ScrollChildArgs -> unit)
    |  OnEdgeOvershot of (Gtk.EdgeOvershotArgs -> unit)
    |  OnMoveFocusOut of (Gtk.MoveFocusOutArgs -> unit)
    |  OnEdgeReached of (Gtk.EdgeReachedArgs -> unit)
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

let bindProperty (widget: ScrolledWindow) (prop: ScrolledWindowProperty) =
    match prop with
    | ScrolledWindowProperty.Hadjustment value -> widget.Hadjustment <- value
    | ScrolledWindowProperty.Vadjustment value -> widget.Vadjustment <- value
    | ScrolledWindowProperty.HscrollbarPolicy value -> widget.HscrollbarPolicy <- value
    | ScrolledWindowProperty.VscrollbarPolicy value -> widget.VscrollbarPolicy <- value
    | ScrolledWindowProperty.WindowPlacement value -> widget.WindowPlacement <- value
    | ScrolledWindowProperty.WindowPlacementSet value -> widget.WindowPlacementSet <- value
    | ScrolledWindowProperty.ShadowType value -> widget.ShadowType <- value
    | ScrolledWindowProperty.MinContentWidth value -> widget.MinContentWidth <- value
    | ScrolledWindowProperty.MinContentHeight value -> widget.MinContentHeight <- value
    | ScrolledWindowProperty.KineticScrolling value -> widget.KineticScrolling <- value
    | ScrolledWindowProperty.OverlayScrolling value -> widget.OverlayScrolling <- value
    | ScrolledWindowProperty.MaxContentWidth value -> widget.MaxContentWidth <- value
    | ScrolledWindowProperty.MaxContentHeight value -> widget.MaxContentHeight <- value
    | ScrolledWindowProperty.PropagateNaturalWidth value -> widget.PropagateNaturalWidth <- value
    | ScrolledWindowProperty.PropagateNaturalHeight value -> widget.PropagateNaturalHeight <- value
    | ScrolledWindowProperty.ResizeMode value -> widget.ResizeMode <- value
    | ScrolledWindowProperty.BorderWidth value -> widget.BorderWidth <- value
    | ScrolledWindowProperty.Name value -> widget.Name <- value
    | ScrolledWindowProperty.Parent value -> widget.Parent <- value
    | ScrolledWindowProperty.WidthRequest value -> widget.WidthRequest <- value
    | ScrolledWindowProperty.HeightRequest value -> widget.HeightRequest <- value
    | ScrolledWindowProperty.Visible value -> widget.Visible <- value
    | ScrolledWindowProperty.Sensitive value -> widget.Sensitive <- value
    | ScrolledWindowProperty.AppPaintable value -> widget.AppPaintable <- value
    | ScrolledWindowProperty.CanFocus value -> widget.CanFocus <- value
    | ScrolledWindowProperty.HasFocus value -> widget.HasFocus <- value
    | ScrolledWindowProperty.IsFocus value -> widget.IsFocus <- value
    | ScrolledWindowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ScrolledWindowProperty.CanDefault value -> widget.CanDefault <- value
    | ScrolledWindowProperty.HasDefault value -> widget.HasDefault <- value
    | ScrolledWindowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ScrolledWindowProperty.Style value -> widget.Style <- value
    | ScrolledWindowProperty.Events value -> widget.Events <- value
    | ScrolledWindowProperty.NoShowAll value -> widget.NoShowAll <- value
    | ScrolledWindowProperty.HasTooltip value -> widget.HasTooltip <- value
    | ScrolledWindowProperty.TooltipText value -> widget.TooltipText <- value
    | ScrolledWindowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ScrolledWindowProperty.Window value -> widget.Window <- value
    | ScrolledWindowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ScrolledWindowProperty.Halign value -> widget.Halign <- value
    | ScrolledWindowProperty.Valign value -> widget.Valign <- value
    | ScrolledWindowProperty.MarginLeft value -> widget.MarginLeft <- value
    | ScrolledWindowProperty.MarginRight value -> widget.MarginRight <- value
    | ScrolledWindowProperty.MarginStart value -> widget.MarginStart <- value
    | ScrolledWindowProperty.MarginEnd value -> widget.MarginEnd <- value
    | ScrolledWindowProperty.MarginTop value -> widget.MarginTop <- value
    | ScrolledWindowProperty.MarginBottom value -> widget.MarginBottom <- value
    | ScrolledWindowProperty.Margin value -> widget.Margin <- value
    | ScrolledWindowProperty.Hexpand value -> widget.Hexpand <- value
    | ScrolledWindowProperty.HexpandSet value -> widget.HexpandSet <- value
    | ScrolledWindowProperty.Vexpand value -> widget.Vexpand <- value
    | ScrolledWindowProperty.VexpandSet value -> widget.VexpandSet <- value
    | ScrolledWindowProperty.Expand value -> widget.Expand <- value
    | ScrolledWindowProperty.Opacity value -> widget.Opacity <- value
    | ScrolledWindowProperty.OnScrollChild handler -> 
        let disposable = widget.ScrollChild.Subscribe(handler)
        registerListener widget "ScrollChild" disposable
    | ScrolledWindowProperty.OnEdgeOvershot handler -> 
        let disposable = widget.EdgeOvershot.Subscribe(handler)
        registerListener widget "EdgeOvershot" disposable
    | ScrolledWindowProperty.OnMoveFocusOut handler -> 
        let disposable = widget.MoveFocusOut.Subscribe(handler)
        registerListener widget "MoveFocusOut" disposable
    | ScrolledWindowProperty.OnEdgeReached handler -> 
        let disposable = widget.EdgeReached.Subscribe(handler)
        registerListener widget "EdgeReached" disposable
    | ScrolledWindowProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ScrolledWindowProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ScrolledWindowProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ScrolledWindowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ScrolledWindowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ScrolledWindowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ScrolledWindowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ScrolledWindowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ScrolledWindowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ScrolledWindowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ScrolledWindowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ScrolledWindowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ScrolledWindowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ScrolledWindowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ScrolledWindowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ScrolledWindowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ScrolledWindowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ScrolledWindowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ScrolledWindowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ScrolledWindowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ScrolledWindowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ScrolledWindowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ScrolledWindowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ScrolledWindowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ScrolledWindowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ScrolledWindowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ScrolledWindowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ScrolledWindowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ScrolledWindowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ScrolledWindowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ScrolledWindowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ScrolledWindowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ScrolledWindowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ScrolledWindowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ScrolledWindowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ScrolledWindowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ScrolledWindowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ScrolledWindowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ScrolledWindowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ScrolledWindowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ScrolledWindowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ScrolledWindowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ScrolledWindowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ScrolledWindowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ScrolledWindowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ScrolledWindowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ScrolledWindowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ScrolledWindowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ScrolledWindowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ScrolledWindowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ScrolledWindowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ScrolledWindowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ScrolledWindowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ScrolledWindowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ScrolledWindowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ScrolledWindowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ScrolledWindowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ScrolledWindowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ScrolledWindowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ScrolledWindowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ScrolledWindowPropertyBuilder() =
    inherit BasePropertyBuilder<ScrolledWindowProperty>()
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: ScrolledWindowProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ScrolledWindowProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: ScrolledWindowProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ScrolledWindowProperty.Vadjustment value } 
    [<CustomOperation("hscrollbarPolicy")>]
    member this.HscrollbarPolicy(it: ScrolledWindowProperty seq, value: Gtk.PolicyType) =
        seq { yield! it; yield ScrolledWindowProperty.HscrollbarPolicy value } 
    [<CustomOperation("vscrollbarPolicy")>]
    member this.VscrollbarPolicy(it: ScrolledWindowProperty seq, value: Gtk.PolicyType) =
        seq { yield! it; yield ScrolledWindowProperty.VscrollbarPolicy value } 
    [<CustomOperation("windowPlacement")>]
    member this.WindowPlacement(it: ScrolledWindowProperty seq, value: Gtk.CornerType) =
        seq { yield! it; yield ScrolledWindowProperty.WindowPlacement value } 
    [<CustomOperation("windowPlacementSet")>]
    member this.WindowPlacementSet(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.WindowPlacementSet value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: ScrolledWindowProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield ScrolledWindowProperty.ShadowType value } 
    [<CustomOperation("minContentWidth")>]
    member this.MinContentWidth(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MinContentWidth value } 
    [<CustomOperation("minContentHeight")>]
    member this.MinContentHeight(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MinContentHeight value } 
    [<CustomOperation("kineticScrolling")>]
    member this.KineticScrolling(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.KineticScrolling value } 
    [<CustomOperation("overlayScrolling")>]
    member this.OverlayScrolling(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.OverlayScrolling value } 
    [<CustomOperation("maxContentWidth")>]
    member this.MaxContentWidth(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MaxContentWidth value } 
    [<CustomOperation("maxContentHeight")>]
    member this.MaxContentHeight(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MaxContentHeight value } 
    [<CustomOperation("propagateNaturalWidth")>]
    member this.PropagateNaturalWidth(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.PropagateNaturalWidth value } 
    [<CustomOperation("propagateNaturalHeight")>]
    member this.PropagateNaturalHeight(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.PropagateNaturalHeight value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ScrolledWindowProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ScrolledWindowProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ScrolledWindowProperty seq, value: System.UInt32) =
        seq { yield! it; yield ScrolledWindowProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ScrolledWindowProperty seq, value: System.String) =
        seq { yield! it; yield ScrolledWindowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ScrolledWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ScrolledWindowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ScrolledWindowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ScrolledWindowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ScrolledWindowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ScrolledWindowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ScrolledWindowProperty seq, value: System.String) =
        seq { yield! it; yield ScrolledWindowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ScrolledWindowProperty seq, value: System.String) =
        seq { yield! it; yield ScrolledWindowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ScrolledWindowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ScrolledWindowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ScrolledWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScrolledWindowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ScrolledWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScrolledWindowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ScrolledWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrolledWindowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ScrolledWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrolledWindowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ScrolledWindowProperty seq, value: System.Double) =
        seq { yield! it; yield ScrolledWindowProperty.Opacity value } 
    [<CustomOperation("onScrollChild")>]
    member this.OnScrollChild(it: ScrolledWindowProperty seq, value: Gtk.ScrollChildArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnScrollChild value } 
    [<CustomOperation("onEdgeOvershot")>]
    member this.OnEdgeOvershot(it: ScrolledWindowProperty seq, value: Gtk.EdgeOvershotArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnEdgeOvershot value } 
    [<CustomOperation("onMoveFocusOut")>]
    member this.OnMoveFocusOut(it: ScrolledWindowProperty seq, value: Gtk.MoveFocusOutArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnMoveFocusOut value } 
    [<CustomOperation("onEdgeReached")>]
    member this.OnEdgeReached(it: ScrolledWindowProperty seq, value: Gtk.EdgeReachedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnEdgeReached value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ScrolledWindowProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ScrolledWindowProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ScrolledWindowProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ScrolledWindowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ScrolledWindowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ScrolledWindowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ScrolledWindowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ScrolledWindowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ScrolledWindowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ScrolledWindowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ScrolledWindowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ScrolledWindowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ScrolledWindowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ScrolledWindowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ScrolledWindowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ScrolledWindowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ScrolledWindowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ScrolledWindowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ScrolledWindowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ScrolledWindowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ScrolledWindowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ScrolledWindowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ScrolledWindowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ScrolledWindowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ScrolledWindowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ScrolledWindowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ScrolledWindowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ScrolledWindowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ScrolledWindowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ScrolledWindowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ScrolledWindowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ScrolledWindowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ScrolledWindowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ScrolledWindowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ScrolledWindowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ScrolledWindowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ScrolledWindowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ScrolledWindowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ScrolledWindowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ScrolledWindowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ScrolledWindowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ScrolledWindowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ScrolledWindowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ScrolledWindowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ScrolledWindowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ScrolledWindowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ScrolledWindowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ScrolledWindowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ScrolledWindowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ScrolledWindowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ScrolledWindowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ScrolledWindowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ScrolledWindowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ScrolledWindowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ScrolledWindowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ScrolledWindowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ScrolledWindowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ScrolledWindowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ScrolledWindowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ScrolledWindowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ScrolledWindowProperty.OnFocused value } 

let prop = ScrolledWindowPropertyBuilder()

type ScrolledWindowDescriptor(props) =
    inherit BaseWidgetDescriptor<ScrolledWindow, ScrolledWindowProperty>(props, bindProperty)
    override this.CreateTyped() = new ScrolledWindow()

let scrolledWindow props = ScrolledWindowDescriptor(props)

