module Gtk.DSL.Binding.Table
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type TableProperty =
    | NRows of System.UInt32
    | NColumns of System.UInt32
    | RowSpacing of System.UInt32
    | ColumnSpacing of System.UInt32
    | [<Obsolete>] Homogeneous of System.Boolean
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

let bindProperty (widget: Table) (prop: TableProperty) =
    match prop with
    | TableProperty.NRows value -> widget.NRows <- value
    | TableProperty.NColumns value -> widget.NColumns <- value
    | TableProperty.RowSpacing value -> widget.RowSpacing <- value
    | TableProperty.ColumnSpacing value -> widget.ColumnSpacing <- value
    | TableProperty.Homogeneous value -> widget.Homogeneous <- value
    | TableProperty.ResizeMode value -> widget.ResizeMode <- value
    | TableProperty.BorderWidth value -> widget.BorderWidth <- value
    | TableProperty.Name value -> widget.Name <- value
    | TableProperty.Parent value -> widget.Parent <- value
    | TableProperty.WidthRequest value -> widget.WidthRequest <- value
    | TableProperty.HeightRequest value -> widget.HeightRequest <- value
    | TableProperty.Visible value -> widget.Visible <- value
    | TableProperty.Sensitive value -> widget.Sensitive <- value
    | TableProperty.AppPaintable value -> widget.AppPaintable <- value
    | TableProperty.CanFocus value -> widget.CanFocus <- value
    | TableProperty.HasFocus value -> widget.HasFocus <- value
    | TableProperty.IsFocus value -> widget.IsFocus <- value
    | TableProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | TableProperty.CanDefault value -> widget.CanDefault <- value
    | TableProperty.HasDefault value -> widget.HasDefault <- value
    | TableProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | TableProperty.Style value -> widget.Style <- value
    | TableProperty.Events value -> widget.Events <- value
    | TableProperty.NoShowAll value -> widget.NoShowAll <- value
    | TableProperty.HasTooltip value -> widget.HasTooltip <- value
    | TableProperty.TooltipText value -> widget.TooltipText <- value
    | TableProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | TableProperty.Window value -> widget.Window <- value
    | TableProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | TableProperty.Halign value -> widget.Halign <- value
    | TableProperty.Valign value -> widget.Valign <- value
    | TableProperty.MarginLeft value -> widget.MarginLeft <- value
    | TableProperty.MarginRight value -> widget.MarginRight <- value
    | TableProperty.MarginStart value -> widget.MarginStart <- value
    | TableProperty.MarginEnd value -> widget.MarginEnd <- value
    | TableProperty.MarginTop value -> widget.MarginTop <- value
    | TableProperty.MarginBottom value -> widget.MarginBottom <- value
    | TableProperty.Margin value -> widget.Margin <- value
    | TableProperty.Hexpand value -> widget.Hexpand <- value
    | TableProperty.HexpandSet value -> widget.HexpandSet <- value
    | TableProperty.Vexpand value -> widget.Vexpand <- value
    | TableProperty.VexpandSet value -> widget.VexpandSet <- value
    | TableProperty.Expand value -> widget.Expand <- value
    | TableProperty.Opacity value -> widget.Opacity <- value
    | TableProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | TableProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | TableProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | TableProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | TableProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | TableProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | TableProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | TableProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | TableProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | TableProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | TableProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | TableProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | TableProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | TableProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | TableProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | TableProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | TableProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | TableProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | TableProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | TableProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | TableProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | TableProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | TableProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | TableProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | TableProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | TableProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | TableProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | TableProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | TableProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | TableProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | TableProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | TableProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | TableProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | TableProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | TableProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | TableProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | TableProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | TableProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | TableProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | TableProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | TableProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | TableProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | TableProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | TableProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | TableProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | TableProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | TableProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | TableProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | TableProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | TableProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | TableProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | TableProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | TableProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | TableProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | TableProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | TableProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | TableProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | TableProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | TableProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | TableProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type TablePropertyBuilder() =
    inherit BasePropertyBuilder<TableProperty>()
    [<CustomOperation("nRows")>]
    member this.NRows(it: TableProperty seq, value: System.UInt32) =
        seq { yield! it; yield TableProperty.NRows value } 
    [<CustomOperation("nColumns")>]
    member this.NColumns(it: TableProperty seq, value: System.UInt32) =
        seq { yield! it; yield TableProperty.NColumns value } 
    [<CustomOperation("rowSpacing")>]
    member this.RowSpacing(it: TableProperty seq, value: System.UInt32) =
        seq { yield! it; yield TableProperty.RowSpacing value } 
    [<CustomOperation("columnSpacing")>]
    member this.ColumnSpacing(it: TableProperty seq, value: System.UInt32) =
        seq { yield! it; yield TableProperty.ColumnSpacing value } 
    [<Obsolete>]
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.Homogeneous value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: TableProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield TableProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: TableProperty seq, value: System.UInt32) =
        seq { yield! it; yield TableProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: TableProperty seq, value: System.String) =
        seq { yield! it; yield TableProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: TableProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TableProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: TableProperty seq, value: Gtk.Style) =
        seq { yield! it; yield TableProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: TableProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield TableProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: TableProperty seq, value: System.String) =
        seq { yield! it; yield TableProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: TableProperty seq, value: System.String) =
        seq { yield! it; yield TableProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: TableProperty seq, value: Gdk.Window) =
        seq { yield! it; yield TableProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: TableProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TableProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: TableProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TableProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: TableProperty seq, value: System.Int32) =
        seq { yield! it; yield TableProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: TableProperty seq, value: System.Boolean) =
        seq { yield! it; yield TableProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: TableProperty seq, value: System.Double) =
        seq { yield! it; yield TableProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: TableProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield TableProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: TableProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: TableProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: TableProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: TableProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: TableProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: TableProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: TableProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: TableProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: TableProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield TableProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: TableProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: TableProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: TableProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: TableProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: TableProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield TableProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: TableProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield TableProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: TableProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: TableProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: TableProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: TableProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: TableProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: TableProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield TableProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: TableProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield TableProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: TableProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: TableProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: TableProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: TableProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: TableProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: TableProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: TableProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: TableProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: TableProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: TableProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: TableProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: TableProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: TableProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield TableProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: TableProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: TableProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: TableProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: TableProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: TableProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: TableProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield TableProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: TableProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: TableProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: TableProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: TableProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: TableProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: TableProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield TableProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: TableProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield TableProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: TableProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: TableProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: TableProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: TableProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: TableProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: TableProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield TableProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: TableProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: TableProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: TableProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: TableProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield TableProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: TableProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield TableProperty.OnFocused value } 

let prop = TablePropertyBuilder()

