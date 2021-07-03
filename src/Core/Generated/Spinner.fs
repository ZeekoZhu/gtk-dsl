module Gtk.DSL.Binding.Spinner
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SpinnerProperty =
    | Active of System.Boolean
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

let bindProperty (widget: Spinner) (prop: SpinnerProperty) =
    match prop with
    | SpinnerProperty.Active value -> widget.Active <- value
    | SpinnerProperty.Name value -> widget.Name <- value
    | SpinnerProperty.Parent value -> widget.Parent <- value
    | SpinnerProperty.WidthRequest value -> widget.WidthRequest <- value
    | SpinnerProperty.HeightRequest value -> widget.HeightRequest <- value
    | SpinnerProperty.Visible value -> widget.Visible <- value
    | SpinnerProperty.Sensitive value -> widget.Sensitive <- value
    | SpinnerProperty.AppPaintable value -> widget.AppPaintable <- value
    | SpinnerProperty.CanFocus value -> widget.CanFocus <- value
    | SpinnerProperty.HasFocus value -> widget.HasFocus <- value
    | SpinnerProperty.IsFocus value -> widget.IsFocus <- value
    | SpinnerProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SpinnerProperty.CanDefault value -> widget.CanDefault <- value
    | SpinnerProperty.HasDefault value -> widget.HasDefault <- value
    | SpinnerProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SpinnerProperty.Style value -> widget.Style <- value
    | SpinnerProperty.Events value -> widget.Events <- value
    | SpinnerProperty.NoShowAll value -> widget.NoShowAll <- value
    | SpinnerProperty.HasTooltip value -> widget.HasTooltip <- value
    | SpinnerProperty.TooltipText value -> widget.TooltipText <- value
    | SpinnerProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SpinnerProperty.Window value -> widget.Window <- value
    | SpinnerProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SpinnerProperty.Halign value -> widget.Halign <- value
    | SpinnerProperty.Valign value -> widget.Valign <- value
    | SpinnerProperty.MarginLeft value -> widget.MarginLeft <- value
    | SpinnerProperty.MarginRight value -> widget.MarginRight <- value
    | SpinnerProperty.MarginStart value -> widget.MarginStart <- value
    | SpinnerProperty.MarginEnd value -> widget.MarginEnd <- value
    | SpinnerProperty.MarginTop value -> widget.MarginTop <- value
    | SpinnerProperty.MarginBottom value -> widget.MarginBottom <- value
    | SpinnerProperty.Margin value -> widget.Margin <- value
    | SpinnerProperty.Hexpand value -> widget.Hexpand <- value
    | SpinnerProperty.HexpandSet value -> widget.HexpandSet <- value
    | SpinnerProperty.Vexpand value -> widget.Vexpand <- value
    | SpinnerProperty.VexpandSet value -> widget.VexpandSet <- value
    | SpinnerProperty.Expand value -> widget.Expand <- value
    | SpinnerProperty.Opacity value -> widget.Opacity <- value
    | SpinnerProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SpinnerProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SpinnerProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SpinnerProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SpinnerProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SpinnerProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SpinnerProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SpinnerProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SpinnerProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SpinnerProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SpinnerProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SpinnerProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SpinnerProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SpinnerProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SpinnerProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SpinnerProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SpinnerProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SpinnerProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SpinnerProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SpinnerProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SpinnerProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SpinnerProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SpinnerProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SpinnerProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SpinnerProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SpinnerProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SpinnerProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SpinnerProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SpinnerProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SpinnerProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SpinnerProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SpinnerProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SpinnerProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SpinnerProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SpinnerProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SpinnerProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SpinnerProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SpinnerProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SpinnerProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SpinnerProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SpinnerProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SpinnerProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SpinnerProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SpinnerProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SpinnerProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SpinnerProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SpinnerProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SpinnerProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SpinnerProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SpinnerProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SpinnerProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SpinnerProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SpinnerProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SpinnerProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SpinnerProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SpinnerProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SpinnerProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SpinnerPropertyBuilder() =
    inherit BasePropertyBuilder<SpinnerProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.Active value } 
    [<CustomOperation("name")>]
    member this.Name(it: SpinnerProperty seq, value: System.String) =
        seq { yield! it; yield SpinnerProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SpinnerProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SpinnerProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SpinnerProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SpinnerProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SpinnerProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SpinnerProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SpinnerProperty seq, value: System.String) =
        seq { yield! it; yield SpinnerProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SpinnerProperty seq, value: System.String) =
        seq { yield! it; yield SpinnerProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SpinnerProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SpinnerProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SpinnerProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SpinnerProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SpinnerProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SpinnerProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SpinnerProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinnerProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SpinnerProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinnerProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SpinnerProperty seq, value: System.Double) =
        seq { yield! it; yield SpinnerProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SpinnerProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SpinnerProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SpinnerProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SpinnerProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SpinnerProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SpinnerProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SpinnerProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SpinnerProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SpinnerProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SpinnerProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SpinnerProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SpinnerProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SpinnerProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SpinnerProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SpinnerProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SpinnerProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SpinnerProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SpinnerProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SpinnerProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SpinnerProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SpinnerProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SpinnerProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SpinnerProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SpinnerProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SpinnerProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SpinnerProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SpinnerProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SpinnerProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SpinnerProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SpinnerProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SpinnerProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SpinnerProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SpinnerProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SpinnerProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SpinnerProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SpinnerProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SpinnerProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SpinnerProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SpinnerProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SpinnerProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SpinnerProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SpinnerProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SpinnerProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SpinnerProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SpinnerProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SpinnerProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SpinnerProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SpinnerProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SpinnerProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SpinnerProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SpinnerProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SpinnerProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SpinnerProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SpinnerProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SpinnerProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SpinnerProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SpinnerProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SpinnerProperty.OnFocused value } 

let prop = SpinnerPropertyBuilder()

type SpinnerDescriptor(props) =
    inherit BaseWidgetDescriptor<Spinner, SpinnerProperty>(props, bindProperty)
    override this.CreateTyped() = new Spinner()

let spinner props = SpinnerDescriptor(props)

