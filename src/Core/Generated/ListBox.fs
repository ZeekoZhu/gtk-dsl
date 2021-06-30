module GtkDsl.Binding.ListBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ListBoxProperty =
    | SelectionMode of Gtk.SelectionMode
    | ActivateOnSingleClick of System.Boolean
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
    |  OnRowSelected of (Gtk.RowSelectedArgs -> unit)
    |  OnListRowActivated of (Gtk.ListRowActivatedArgs -> unit)
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

let bindProperty (widget: ListBox) (prop: ListBoxProperty) =
    match prop with
    | ListBoxProperty.SelectionMode value -> widget.SelectionMode <- value
    | ListBoxProperty.ActivateOnSingleClick value -> widget.ActivateOnSingleClick <- value
    | ListBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | ListBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | ListBoxProperty.Name value -> widget.Name <- value
    | ListBoxProperty.Parent value -> widget.Parent <- value
    | ListBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | ListBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | ListBoxProperty.Visible value -> widget.Visible <- value
    | ListBoxProperty.Sensitive value -> widget.Sensitive <- value
    | ListBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | ListBoxProperty.CanFocus value -> widget.CanFocus <- value
    | ListBoxProperty.HasFocus value -> widget.HasFocus <- value
    | ListBoxProperty.IsFocus value -> widget.IsFocus <- value
    | ListBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ListBoxProperty.CanDefault value -> widget.CanDefault <- value
    | ListBoxProperty.HasDefault value -> widget.HasDefault <- value
    | ListBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ListBoxProperty.Style value -> widget.Style <- value
    | ListBoxProperty.Events value -> widget.Events <- value
    | ListBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | ListBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | ListBoxProperty.TooltipText value -> widget.TooltipText <- value
    | ListBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ListBoxProperty.Window value -> widget.Window <- value
    | ListBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ListBoxProperty.Halign value -> widget.Halign <- value
    | ListBoxProperty.Valign value -> widget.Valign <- value
    | ListBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | ListBoxProperty.MarginRight value -> widget.MarginRight <- value
    | ListBoxProperty.MarginStart value -> widget.MarginStart <- value
    | ListBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | ListBoxProperty.MarginTop value -> widget.MarginTop <- value
    | ListBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | ListBoxProperty.Margin value -> widget.Margin <- value
    | ListBoxProperty.Hexpand value -> widget.Hexpand <- value
    | ListBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | ListBoxProperty.Vexpand value -> widget.Vexpand <- value
    | ListBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | ListBoxProperty.Expand value -> widget.Expand <- value
    | ListBoxProperty.Opacity value -> widget.Opacity <- value
    | ListBoxProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | ListBoxProperty.OnRowSelected handler -> 
        let disposable = widget.RowSelected.Subscribe(handler)
        registerListener widget "RowSelected" disposable
    | ListBoxProperty.OnListRowActivated handler -> 
        let disposable = widget.ListRowActivated.Subscribe(handler)
        registerListener widget "ListRowActivated" disposable
    | ListBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ListBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ListBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ListBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ListBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ListBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ListBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ListBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ListBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ListBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ListBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ListBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ListBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ListBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ListBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ListBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ListBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ListBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ListBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ListBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ListBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ListBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ListBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ListBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ListBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ListBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ListBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ListBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ListBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ListBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ListBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ListBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ListBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ListBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ListBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ListBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ListBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ListBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ListBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ListBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ListBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ListBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ListBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ListBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ListBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ListBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ListBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ListBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ListBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ListBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ListBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ListBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ListBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ListBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ListBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ListBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ListBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ListBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ListBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ListBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ListBoxPropertyBuilder() =
    inherit BasePropertyBuilder<ListBoxProperty>()
    [<CustomOperation("selectionMode")>]
    member this.SelectionMode(it: ListBoxProperty seq, value: Gtk.SelectionMode) =
        seq { yield! it; yield ListBoxProperty.SelectionMode value } 
    [<CustomOperation("activateOnSingleClick")>]
    member this.ActivateOnSingleClick(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.ActivateOnSingleClick value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ListBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ListBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ListBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield ListBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ListBoxProperty seq, value: System.String) =
        seq { yield! it; yield ListBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ListBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ListBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ListBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ListBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ListBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ListBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ListBoxProperty seq, value: System.String) =
        seq { yield! it; yield ListBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ListBoxProperty seq, value: System.String) =
        seq { yield! it; yield ListBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ListBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ListBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ListBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ListBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ListBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ListBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ListBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ListBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ListBoxProperty seq, value: System.Double) =
        seq { yield! it; yield ListBoxProperty.Opacity value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: ListBoxProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnMoveCursor value } 
    [<CustomOperation("onRowSelected")>]
    member this.OnRowSelected(it: ListBoxProperty seq, value: Gtk.RowSelectedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnRowSelected value } 
    [<CustomOperation("onListRowActivated")>]
    member this.OnListRowActivated(it: ListBoxProperty seq, value: Gtk.ListRowActivatedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnListRowActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ListBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ListBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ListBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ListBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ListBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ListBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ListBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ListBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ListBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ListBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ListBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ListBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ListBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ListBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ListBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ListBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ListBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ListBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ListBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ListBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ListBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ListBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ListBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ListBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ListBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ListBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ListBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ListBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ListBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ListBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ListBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ListBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ListBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ListBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ListBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ListBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ListBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ListBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ListBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ListBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ListBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ListBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ListBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ListBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ListBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ListBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ListBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ListBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ListBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ListBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ListBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ListBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ListBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ListBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ListBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ListBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ListBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ListBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ListBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ListBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ListBoxProperty.OnFocused value } 

let prop = ListBoxPropertyBuilder()

type ListBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<ListBox, ListBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new ListBox()

let listBox props = ListBoxDescriptor(props)

