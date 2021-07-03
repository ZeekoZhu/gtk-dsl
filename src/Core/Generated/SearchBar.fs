module Gtk.DSL.Binding.SearchBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SearchBarProperty =
    | SearchModeEnabled of System.Boolean
    | ShowCloseButton of System.Boolean
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

let bindProperty (widget: SearchBar) (prop: SearchBarProperty) =
    match prop with
    | SearchBarProperty.SearchModeEnabled value -> widget.SearchModeEnabled <- value
    | SearchBarProperty.ShowCloseButton value -> widget.ShowCloseButton <- value
    | SearchBarProperty.ResizeMode value -> widget.ResizeMode <- value
    | SearchBarProperty.BorderWidth value -> widget.BorderWidth <- value
    | SearchBarProperty.Name value -> widget.Name <- value
    | SearchBarProperty.Parent value -> widget.Parent <- value
    | SearchBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | SearchBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | SearchBarProperty.Visible value -> widget.Visible <- value
    | SearchBarProperty.Sensitive value -> widget.Sensitive <- value
    | SearchBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | SearchBarProperty.CanFocus value -> widget.CanFocus <- value
    | SearchBarProperty.HasFocus value -> widget.HasFocus <- value
    | SearchBarProperty.IsFocus value -> widget.IsFocus <- value
    | SearchBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SearchBarProperty.CanDefault value -> widget.CanDefault <- value
    | SearchBarProperty.HasDefault value -> widget.HasDefault <- value
    | SearchBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SearchBarProperty.Style value -> widget.Style <- value
    | SearchBarProperty.Events value -> widget.Events <- value
    | SearchBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | SearchBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | SearchBarProperty.TooltipText value -> widget.TooltipText <- value
    | SearchBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SearchBarProperty.Window value -> widget.Window <- value
    | SearchBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SearchBarProperty.Halign value -> widget.Halign <- value
    | SearchBarProperty.Valign value -> widget.Valign <- value
    | SearchBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | SearchBarProperty.MarginRight value -> widget.MarginRight <- value
    | SearchBarProperty.MarginStart value -> widget.MarginStart <- value
    | SearchBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | SearchBarProperty.MarginTop value -> widget.MarginTop <- value
    | SearchBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | SearchBarProperty.Margin value -> widget.Margin <- value
    | SearchBarProperty.Hexpand value -> widget.Hexpand <- value
    | SearchBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | SearchBarProperty.Vexpand value -> widget.Vexpand <- value
    | SearchBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | SearchBarProperty.Expand value -> widget.Expand <- value
    | SearchBarProperty.Opacity value -> widget.Opacity <- value
    | SearchBarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | SearchBarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | SearchBarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | SearchBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SearchBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SearchBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SearchBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SearchBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SearchBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SearchBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SearchBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SearchBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SearchBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SearchBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SearchBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SearchBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SearchBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SearchBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SearchBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SearchBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SearchBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SearchBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SearchBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SearchBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SearchBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SearchBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SearchBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SearchBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SearchBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SearchBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SearchBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SearchBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SearchBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SearchBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SearchBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SearchBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SearchBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SearchBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SearchBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SearchBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SearchBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SearchBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SearchBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SearchBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SearchBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SearchBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SearchBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SearchBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SearchBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SearchBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SearchBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SearchBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SearchBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SearchBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SearchBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SearchBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SearchBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SearchBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SearchBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SearchBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SearchBarPropertyBuilder() =
    inherit BasePropertyBuilder<SearchBarProperty>()
    [<CustomOperation("searchModeEnabled")>]
    member this.SearchModeEnabled(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.SearchModeEnabled value } 
    [<CustomOperation("showCloseButton")>]
    member this.ShowCloseButton(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.ShowCloseButton value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: SearchBarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield SearchBarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: SearchBarProperty seq, value: System.UInt32) =
        seq { yield! it; yield SearchBarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: SearchBarProperty seq, value: System.String) =
        seq { yield! it; yield SearchBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SearchBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SearchBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SearchBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SearchBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SearchBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SearchBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SearchBarProperty seq, value: System.String) =
        seq { yield! it; yield SearchBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SearchBarProperty seq, value: System.String) =
        seq { yield! it; yield SearchBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SearchBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SearchBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SearchBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SearchBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SearchBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SearchBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SearchBarProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SearchBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchBarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SearchBarProperty seq, value: System.Double) =
        seq { yield! it; yield SearchBarProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: SearchBarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: SearchBarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: SearchBarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SearchBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SearchBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SearchBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SearchBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SearchBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SearchBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SearchBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SearchBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SearchBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SearchBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SearchBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SearchBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SearchBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SearchBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SearchBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SearchBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SearchBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SearchBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SearchBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SearchBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SearchBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SearchBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SearchBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SearchBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SearchBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SearchBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SearchBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SearchBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SearchBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SearchBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SearchBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SearchBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SearchBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SearchBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SearchBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SearchBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SearchBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SearchBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SearchBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SearchBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SearchBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SearchBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SearchBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SearchBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SearchBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SearchBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SearchBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SearchBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SearchBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SearchBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SearchBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SearchBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SearchBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SearchBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SearchBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SearchBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SearchBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SearchBarProperty.OnFocused value } 

let prop = SearchBarPropertyBuilder()

type SearchBarDescriptor(props) =
    inherit BaseWidgetDescriptor<SearchBar, SearchBarProperty>(props, bindProperty)
    override this.CreateTyped() = new SearchBar()

let searchBar props = SearchBarDescriptor(props)

