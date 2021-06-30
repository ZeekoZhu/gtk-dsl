module GtkDsl.Binding.Grid
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type GridProperty =
    | RowSpacing of System.UInt32
    | ColumnSpacing of System.UInt32
    | RowHomogeneous of System.Boolean
    | ColumnHomogeneous of System.Boolean
    | BaselineRow of System.Int32
    | LeftAttach of System.Int32
    | TopAttach of System.Int32
    | Width of System.Int32
    | Height of System.Int32
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

let bindProperty (widget: Grid) (prop: GridProperty) =
    match prop with
    | GridProperty.RowSpacing value -> widget.RowSpacing <- value
    | GridProperty.ColumnSpacing value -> widget.ColumnSpacing <- value
    | GridProperty.RowHomogeneous value -> widget.RowHomogeneous <- value
    | GridProperty.ColumnHomogeneous value -> widget.ColumnHomogeneous <- value
    | GridProperty.BaselineRow value -> widget.BaselineRow <- value
    | GridProperty.LeftAttach value -> widget.LeftAttach <- value
    | GridProperty.TopAttach value -> widget.TopAttach <- value
    | GridProperty.Width value -> widget.Width <- value
    | GridProperty.Height value -> widget.Height <- value
    | GridProperty.Orientation value -> widget.Orientation <- value
    | GridProperty.ResizeMode value -> widget.ResizeMode <- value
    | GridProperty.BorderWidth value -> widget.BorderWidth <- value
    | GridProperty.Name value -> widget.Name <- value
    | GridProperty.Parent value -> widget.Parent <- value
    | GridProperty.WidthRequest value -> widget.WidthRequest <- value
    | GridProperty.HeightRequest value -> widget.HeightRequest <- value
    | GridProperty.Visible value -> widget.Visible <- value
    | GridProperty.Sensitive value -> widget.Sensitive <- value
    | GridProperty.AppPaintable value -> widget.AppPaintable <- value
    | GridProperty.CanFocus value -> widget.CanFocus <- value
    | GridProperty.HasFocus value -> widget.HasFocus <- value
    | GridProperty.IsFocus value -> widget.IsFocus <- value
    | GridProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | GridProperty.CanDefault value -> widget.CanDefault <- value
    | GridProperty.HasDefault value -> widget.HasDefault <- value
    | GridProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | GridProperty.Style value -> widget.Style <- value
    | GridProperty.Events value -> widget.Events <- value
    | GridProperty.NoShowAll value -> widget.NoShowAll <- value
    | GridProperty.HasTooltip value -> widget.HasTooltip <- value
    | GridProperty.TooltipText value -> widget.TooltipText <- value
    | GridProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | GridProperty.Window value -> widget.Window <- value
    | GridProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | GridProperty.Halign value -> widget.Halign <- value
    | GridProperty.Valign value -> widget.Valign <- value
    | GridProperty.MarginLeft value -> widget.MarginLeft <- value
    | GridProperty.MarginRight value -> widget.MarginRight <- value
    | GridProperty.MarginStart value -> widget.MarginStart <- value
    | GridProperty.MarginEnd value -> widget.MarginEnd <- value
    | GridProperty.MarginTop value -> widget.MarginTop <- value
    | GridProperty.MarginBottom value -> widget.MarginBottom <- value
    | GridProperty.Margin value -> widget.Margin <- value
    | GridProperty.Hexpand value -> widget.Hexpand <- value
    | GridProperty.HexpandSet value -> widget.HexpandSet <- value
    | GridProperty.Vexpand value -> widget.Vexpand <- value
    | GridProperty.VexpandSet value -> widget.VexpandSet <- value
    | GridProperty.Expand value -> widget.Expand <- value
    | GridProperty.Opacity value -> widget.Opacity <- value
    | GridProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | GridProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | GridProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | GridProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | GridProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | GridProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | GridProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | GridProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | GridProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | GridProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | GridProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | GridProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | GridProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | GridProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | GridProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | GridProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | GridProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | GridProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | GridProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | GridProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | GridProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | GridProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | GridProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | GridProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | GridProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | GridProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | GridProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | GridProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | GridProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | GridProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | GridProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | GridProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | GridProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | GridProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | GridProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | GridProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | GridProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | GridProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | GridProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | GridProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | GridProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | GridProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | GridProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | GridProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | GridProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | GridProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | GridProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | GridProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | GridProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | GridProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | GridProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | GridProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | GridProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | GridProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | GridProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | GridProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | GridProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | GridProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | GridProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | GridProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type GridPropertyBuilder() =
    inherit BasePropertyBuilder<GridProperty>()
    [<CustomOperation("rowSpacing")>]
    member this.RowSpacing(it: GridProperty seq, value: System.UInt32) =
        seq { yield! it; yield GridProperty.RowSpacing value } 
    [<CustomOperation("columnSpacing")>]
    member this.ColumnSpacing(it: GridProperty seq, value: System.UInt32) =
        seq { yield! it; yield GridProperty.ColumnSpacing value } 
    [<CustomOperation("rowHomogeneous")>]
    member this.RowHomogeneous(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.RowHomogeneous value } 
    [<CustomOperation("columnHomogeneous")>]
    member this.ColumnHomogeneous(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.ColumnHomogeneous value } 
    [<CustomOperation("baselineRow")>]
    member this.BaselineRow(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.BaselineRow value } 
    [<CustomOperation("leftAttach")>]
    member this.LeftAttach(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.LeftAttach value } 
    [<CustomOperation("topAttach")>]
    member this.TopAttach(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.TopAttach value } 
    [<CustomOperation("width")>]
    member this.Width(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.Width value } 
    [<CustomOperation("height")>]
    member this.Height(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.Height value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: GridProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield GridProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: GridProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield GridProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: GridProperty seq, value: System.UInt32) =
        seq { yield! it; yield GridProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: GridProperty seq, value: System.String) =
        seq { yield! it; yield GridProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: GridProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield GridProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: GridProperty seq, value: Gtk.Style) =
        seq { yield! it; yield GridProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: GridProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield GridProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: GridProperty seq, value: System.String) =
        seq { yield! it; yield GridProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: GridProperty seq, value: System.String) =
        seq { yield! it; yield GridProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: GridProperty seq, value: Gdk.Window) =
        seq { yield! it; yield GridProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: GridProperty seq, value: Gtk.Align) =
        seq { yield! it; yield GridProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: GridProperty seq, value: Gtk.Align) =
        seq { yield! it; yield GridProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: GridProperty seq, value: System.Int32) =
        seq { yield! it; yield GridProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: GridProperty seq, value: System.Boolean) =
        seq { yield! it; yield GridProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: GridProperty seq, value: System.Double) =
        seq { yield! it; yield GridProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: GridProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield GridProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: GridProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: GridProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: GridProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: GridProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: GridProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: GridProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: GridProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: GridProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: GridProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield GridProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: GridProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: GridProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: GridProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: GridProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: GridProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield GridProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: GridProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield GridProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: GridProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: GridProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: GridProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: GridProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: GridProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: GridProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield GridProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: GridProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield GridProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: GridProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: GridProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: GridProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: GridProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: GridProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: GridProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: GridProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: GridProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: GridProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: GridProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: GridProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: GridProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: GridProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield GridProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: GridProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: GridProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: GridProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: GridProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: GridProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: GridProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield GridProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: GridProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: GridProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: GridProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: GridProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: GridProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: GridProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield GridProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: GridProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield GridProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: GridProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: GridProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: GridProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: GridProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: GridProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: GridProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield GridProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: GridProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: GridProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: GridProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: GridProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield GridProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: GridProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield GridProperty.OnFocused value } 

let prop = GridPropertyBuilder()

type GridDescriptor(props) =
    inherit BaseWidgetDescriptor<Grid, GridProperty>(props, bindProperty)
    override this.CreateTyped() = new Grid()

let grid props = GridDescriptor(props)

