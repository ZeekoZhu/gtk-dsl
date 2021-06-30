module GtkDsl.Binding.FlowBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FlowBoxProperty =
    | SelectionMode of Gtk.SelectionMode
    | ActivateOnSingleClick of System.Boolean
    | Homogeneous of System.Boolean
    | MinChildrenPerLine of System.UInt32
    | MaxChildrenPerLine of System.UInt32
    | RowSpacing of System.UInt32
    | ColumnSpacing of System.UInt32
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
    |  OnMoveCursor of (Gtk.MoveCursorArgs -> unit)
    |  OnChildActivated of (Gtk.ChildActivatedArgs -> unit)
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

let bindProperty (widget: FlowBox) (prop: FlowBoxProperty) =
    match prop with
    | FlowBoxProperty.SelectionMode value -> widget.SelectionMode <- value
    | FlowBoxProperty.ActivateOnSingleClick value -> widget.ActivateOnSingleClick <- value
    | FlowBoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | FlowBoxProperty.MinChildrenPerLine value -> widget.MinChildrenPerLine <- value
    | FlowBoxProperty.MaxChildrenPerLine value -> widget.MaxChildrenPerLine <- value
    | FlowBoxProperty.RowSpacing value -> widget.RowSpacing <- value
    | FlowBoxProperty.ColumnSpacing value -> widget.ColumnSpacing <- value
    | FlowBoxProperty.Orientation value -> widget.Orientation <- value
    | FlowBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | FlowBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | FlowBoxProperty.Name value -> widget.Name <- value
    | FlowBoxProperty.Parent value -> widget.Parent <- value
    | FlowBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | FlowBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | FlowBoxProperty.Visible value -> widget.Visible <- value
    | FlowBoxProperty.Sensitive value -> widget.Sensitive <- value
    | FlowBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | FlowBoxProperty.CanFocus value -> widget.CanFocus <- value
    | FlowBoxProperty.HasFocus value -> widget.HasFocus <- value
    | FlowBoxProperty.IsFocus value -> widget.IsFocus <- value
    | FlowBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FlowBoxProperty.CanDefault value -> widget.CanDefault <- value
    | FlowBoxProperty.HasDefault value -> widget.HasDefault <- value
    | FlowBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FlowBoxProperty.Style value -> widget.Style <- value
    | FlowBoxProperty.Events value -> widget.Events <- value
    | FlowBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | FlowBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | FlowBoxProperty.TooltipText value -> widget.TooltipText <- value
    | FlowBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FlowBoxProperty.Window value -> widget.Window <- value
    | FlowBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FlowBoxProperty.Halign value -> widget.Halign <- value
    | FlowBoxProperty.Valign value -> widget.Valign <- value
    | FlowBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | FlowBoxProperty.MarginRight value -> widget.MarginRight <- value
    | FlowBoxProperty.MarginStart value -> widget.MarginStart <- value
    | FlowBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | FlowBoxProperty.MarginTop value -> widget.MarginTop <- value
    | FlowBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | FlowBoxProperty.Margin value -> widget.Margin <- value
    | FlowBoxProperty.Hexpand value -> widget.Hexpand <- value
    | FlowBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | FlowBoxProperty.Vexpand value -> widget.Vexpand <- value
    | FlowBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | FlowBoxProperty.Expand value -> widget.Expand <- value
    | FlowBoxProperty.Opacity value -> widget.Opacity <- value
    | FlowBoxProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | FlowBoxProperty.OnChildActivated handler -> 
        let disposable = widget.ChildActivated.Subscribe(handler)
        registerListener widget "ChildActivated" disposable
    | FlowBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FlowBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FlowBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FlowBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FlowBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FlowBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FlowBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FlowBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FlowBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FlowBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FlowBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FlowBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FlowBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FlowBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FlowBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FlowBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FlowBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FlowBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FlowBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FlowBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FlowBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FlowBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FlowBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FlowBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FlowBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FlowBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FlowBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FlowBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FlowBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FlowBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FlowBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FlowBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FlowBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FlowBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FlowBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FlowBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FlowBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FlowBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FlowBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FlowBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FlowBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FlowBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FlowBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FlowBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FlowBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FlowBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FlowBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FlowBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FlowBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FlowBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FlowBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FlowBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FlowBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FlowBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FlowBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FlowBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FlowBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FlowBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FlowBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FlowBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FlowBoxPropertyBuilder() =
    inherit BasePropertyBuilder<FlowBoxProperty>()
    [<CustomOperation("selectionMode")>]
    member this.SelectionMode(it: FlowBoxProperty seq, value: Gtk.SelectionMode) =
        seq { yield! it; yield FlowBoxProperty.SelectionMode value } 
    [<CustomOperation("activateOnSingleClick")>]
    member this.ActivateOnSingleClick(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.ActivateOnSingleClick value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.Homogeneous value } 
    [<CustomOperation("minChildrenPerLine")>]
    member this.MinChildrenPerLine(it: FlowBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield FlowBoxProperty.MinChildrenPerLine value } 
    [<CustomOperation("maxChildrenPerLine")>]
    member this.MaxChildrenPerLine(it: FlowBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield FlowBoxProperty.MaxChildrenPerLine value } 
    [<CustomOperation("rowSpacing")>]
    member this.RowSpacing(it: FlowBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield FlowBoxProperty.RowSpacing value } 
    [<CustomOperation("columnSpacing")>]
    member this.ColumnSpacing(it: FlowBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield FlowBoxProperty.ColumnSpacing value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: FlowBoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield FlowBoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FlowBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FlowBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FlowBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield FlowBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FlowBoxProperty seq, value: System.String) =
        seq { yield! it; yield FlowBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FlowBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FlowBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FlowBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FlowBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FlowBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FlowBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FlowBoxProperty seq, value: System.String) =
        seq { yield! it; yield FlowBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FlowBoxProperty seq, value: System.String) =
        seq { yield! it; yield FlowBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FlowBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FlowBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FlowBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FlowBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FlowBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FlowBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FlowBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FlowBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FlowBoxProperty seq, value: System.Double) =
        seq { yield! it; yield FlowBoxProperty.Opacity value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: FlowBoxProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnMoveCursor value } 
    [<CustomOperation("onChildActivated")>]
    member this.OnChildActivated(it: FlowBoxProperty seq, value: Gtk.ChildActivatedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnChildActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FlowBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FlowBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FlowBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FlowBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FlowBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FlowBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FlowBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FlowBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FlowBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FlowBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FlowBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FlowBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FlowBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FlowBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FlowBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FlowBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FlowBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FlowBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FlowBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FlowBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FlowBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FlowBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FlowBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FlowBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FlowBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FlowBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FlowBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FlowBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FlowBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FlowBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FlowBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FlowBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FlowBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FlowBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FlowBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FlowBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FlowBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FlowBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FlowBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FlowBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FlowBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FlowBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FlowBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FlowBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FlowBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FlowBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FlowBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FlowBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FlowBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FlowBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FlowBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FlowBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FlowBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FlowBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FlowBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FlowBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FlowBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FlowBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FlowBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FlowBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FlowBoxProperty.OnFocused value } 

let prop = FlowBoxPropertyBuilder()

type FlowBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<FlowBox, FlowBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new FlowBox()

let flowBox props = FlowBoxDescriptor(props)

