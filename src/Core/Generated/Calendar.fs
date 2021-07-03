module Gtk.DSL.Binding.Calendar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type CalendarProperty =
    | Year of System.Int32
    | Month of System.Int32
    | Day of System.Int32
    | ShowHeading of System.Boolean
    | ShowDayNames of System.Boolean
    | NoMonthChange of System.Boolean
    | ShowWeekNumbers of System.Boolean
    | DetailWidthChars of System.Int32
    | DetailHeightRows of System.Int32
    | ShowDetails of System.Boolean
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

let bindProperty (widget: Calendar) (prop: CalendarProperty) =
    match prop with
    | CalendarProperty.Year value -> widget.Year <- value
    | CalendarProperty.Month value -> widget.Month <- value
    | CalendarProperty.Day value -> widget.Day <- value
    | CalendarProperty.ShowHeading value -> widget.ShowHeading <- value
    | CalendarProperty.ShowDayNames value -> widget.ShowDayNames <- value
    | CalendarProperty.NoMonthChange value -> widget.NoMonthChange <- value
    | CalendarProperty.ShowWeekNumbers value -> widget.ShowWeekNumbers <- value
    | CalendarProperty.DetailWidthChars value -> widget.DetailWidthChars <- value
    | CalendarProperty.DetailHeightRows value -> widget.DetailHeightRows <- value
    | CalendarProperty.ShowDetails value -> widget.ShowDetails <- value
    | CalendarProperty.Name value -> widget.Name <- value
    | CalendarProperty.Parent value -> widget.Parent <- value
    | CalendarProperty.WidthRequest value -> widget.WidthRequest <- value
    | CalendarProperty.HeightRequest value -> widget.HeightRequest <- value
    | CalendarProperty.Visible value -> widget.Visible <- value
    | CalendarProperty.Sensitive value -> widget.Sensitive <- value
    | CalendarProperty.AppPaintable value -> widget.AppPaintable <- value
    | CalendarProperty.CanFocus value -> widget.CanFocus <- value
    | CalendarProperty.HasFocus value -> widget.HasFocus <- value
    | CalendarProperty.IsFocus value -> widget.IsFocus <- value
    | CalendarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | CalendarProperty.CanDefault value -> widget.CanDefault <- value
    | CalendarProperty.HasDefault value -> widget.HasDefault <- value
    | CalendarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | CalendarProperty.Style value -> widget.Style <- value
    | CalendarProperty.Events value -> widget.Events <- value
    | CalendarProperty.NoShowAll value -> widget.NoShowAll <- value
    | CalendarProperty.HasTooltip value -> widget.HasTooltip <- value
    | CalendarProperty.TooltipText value -> widget.TooltipText <- value
    | CalendarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | CalendarProperty.Window value -> widget.Window <- value
    | CalendarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | CalendarProperty.Halign value -> widget.Halign <- value
    | CalendarProperty.Valign value -> widget.Valign <- value
    | CalendarProperty.MarginLeft value -> widget.MarginLeft <- value
    | CalendarProperty.MarginRight value -> widget.MarginRight <- value
    | CalendarProperty.MarginStart value -> widget.MarginStart <- value
    | CalendarProperty.MarginEnd value -> widget.MarginEnd <- value
    | CalendarProperty.MarginTop value -> widget.MarginTop <- value
    | CalendarProperty.MarginBottom value -> widget.MarginBottom <- value
    | CalendarProperty.Margin value -> widget.Margin <- value
    | CalendarProperty.Hexpand value -> widget.Hexpand <- value
    | CalendarProperty.HexpandSet value -> widget.HexpandSet <- value
    | CalendarProperty.Vexpand value -> widget.Vexpand <- value
    | CalendarProperty.VexpandSet value -> widget.VexpandSet <- value
    | CalendarProperty.Expand value -> widget.Expand <- value
    | CalendarProperty.Opacity value -> widget.Opacity <- value
    | CalendarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | CalendarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | CalendarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | CalendarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | CalendarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | CalendarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | CalendarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | CalendarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | CalendarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | CalendarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | CalendarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | CalendarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | CalendarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | CalendarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | CalendarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | CalendarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | CalendarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | CalendarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | CalendarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | CalendarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | CalendarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | CalendarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | CalendarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | CalendarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | CalendarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | CalendarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | CalendarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | CalendarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | CalendarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | CalendarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | CalendarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | CalendarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | CalendarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | CalendarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | CalendarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | CalendarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | CalendarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | CalendarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | CalendarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | CalendarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | CalendarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | CalendarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | CalendarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | CalendarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | CalendarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | CalendarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | CalendarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | CalendarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | CalendarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | CalendarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | CalendarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | CalendarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | CalendarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | CalendarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | CalendarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | CalendarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | CalendarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type CalendarPropertyBuilder() =
    inherit BasePropertyBuilder<CalendarProperty>()
    [<CustomOperation("year")>]
    member this.Year(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.Year value } 
    [<CustomOperation("month")>]
    member this.Month(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.Month value } 
    [<CustomOperation("day")>]
    member this.Day(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.Day value } 
    [<CustomOperation("showHeading")>]
    member this.ShowHeading(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.ShowHeading value } 
    [<CustomOperation("showDayNames")>]
    member this.ShowDayNames(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.ShowDayNames value } 
    [<CustomOperation("noMonthChange")>]
    member this.NoMonthChange(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.NoMonthChange value } 
    [<CustomOperation("showWeekNumbers")>]
    member this.ShowWeekNumbers(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.ShowWeekNumbers value } 
    [<CustomOperation("detailWidthChars")>]
    member this.DetailWidthChars(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.DetailWidthChars value } 
    [<CustomOperation("detailHeightRows")>]
    member this.DetailHeightRows(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.DetailHeightRows value } 
    [<CustomOperation("showDetails")>]
    member this.ShowDetails(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.ShowDetails value } 
    [<CustomOperation("name")>]
    member this.Name(it: CalendarProperty seq, value: System.String) =
        seq { yield! it; yield CalendarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: CalendarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CalendarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: CalendarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield CalendarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: CalendarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield CalendarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: CalendarProperty seq, value: System.String) =
        seq { yield! it; yield CalendarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: CalendarProperty seq, value: System.String) =
        seq { yield! it; yield CalendarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: CalendarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield CalendarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: CalendarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CalendarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: CalendarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CalendarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: CalendarProperty seq, value: System.Int32) =
        seq { yield! it; yield CalendarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: CalendarProperty seq, value: System.Boolean) =
        seq { yield! it; yield CalendarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: CalendarProperty seq, value: System.Double) =
        seq { yield! it; yield CalendarProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: CalendarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: CalendarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: CalendarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: CalendarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: CalendarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: CalendarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: CalendarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: CalendarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: CalendarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: CalendarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: CalendarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: CalendarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: CalendarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: CalendarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: CalendarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: CalendarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: CalendarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: CalendarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: CalendarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: CalendarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: CalendarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: CalendarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: CalendarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: CalendarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: CalendarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: CalendarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: CalendarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: CalendarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: CalendarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: CalendarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: CalendarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: CalendarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: CalendarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: CalendarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: CalendarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: CalendarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: CalendarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: CalendarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: CalendarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: CalendarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: CalendarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: CalendarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: CalendarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: CalendarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: CalendarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: CalendarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: CalendarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: CalendarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: CalendarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: CalendarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: CalendarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: CalendarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: CalendarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: CalendarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: CalendarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: CalendarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: CalendarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield CalendarProperty.OnFocused value } 

let prop = CalendarPropertyBuilder()

type CalendarDescriptor(props) =
    inherit BaseWidgetDescriptor<Calendar, CalendarProperty>(props, bindProperty)
    override this.CreateTyped() = new Calendar()

let calendar props = CalendarDescriptor(props)

