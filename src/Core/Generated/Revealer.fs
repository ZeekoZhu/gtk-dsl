module Gtk.DSL.Binding.Revealer
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RevealerProperty =
    | TransitionType of Gtk.RevealerTransitionType
    | TransitionDuration of System.UInt32
    | RevealChild of System.Boolean
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

let bindProperty (widget: Revealer) (prop: RevealerProperty) =
    match prop with
    | RevealerProperty.TransitionType value -> widget.TransitionType <- value
    | RevealerProperty.TransitionDuration value -> widget.TransitionDuration <- value
    | RevealerProperty.RevealChild value -> widget.RevealChild <- value
    | RevealerProperty.ResizeMode value -> widget.ResizeMode <- value
    | RevealerProperty.BorderWidth value -> widget.BorderWidth <- value
    | RevealerProperty.Name value -> widget.Name <- value
    | RevealerProperty.Parent value -> widget.Parent <- value
    | RevealerProperty.WidthRequest value -> widget.WidthRequest <- value
    | RevealerProperty.HeightRequest value -> widget.HeightRequest <- value
    | RevealerProperty.Visible value -> widget.Visible <- value
    | RevealerProperty.Sensitive value -> widget.Sensitive <- value
    | RevealerProperty.AppPaintable value -> widget.AppPaintable <- value
    | RevealerProperty.CanFocus value -> widget.CanFocus <- value
    | RevealerProperty.HasFocus value -> widget.HasFocus <- value
    | RevealerProperty.IsFocus value -> widget.IsFocus <- value
    | RevealerProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RevealerProperty.CanDefault value -> widget.CanDefault <- value
    | RevealerProperty.HasDefault value -> widget.HasDefault <- value
    | RevealerProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RevealerProperty.Style value -> widget.Style <- value
    | RevealerProperty.Events value -> widget.Events <- value
    | RevealerProperty.NoShowAll value -> widget.NoShowAll <- value
    | RevealerProperty.HasTooltip value -> widget.HasTooltip <- value
    | RevealerProperty.TooltipText value -> widget.TooltipText <- value
    | RevealerProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RevealerProperty.Window value -> widget.Window <- value
    | RevealerProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RevealerProperty.Halign value -> widget.Halign <- value
    | RevealerProperty.Valign value -> widget.Valign <- value
    | RevealerProperty.MarginLeft value -> widget.MarginLeft <- value
    | RevealerProperty.MarginRight value -> widget.MarginRight <- value
    | RevealerProperty.MarginStart value -> widget.MarginStart <- value
    | RevealerProperty.MarginEnd value -> widget.MarginEnd <- value
    | RevealerProperty.MarginTop value -> widget.MarginTop <- value
    | RevealerProperty.MarginBottom value -> widget.MarginBottom <- value
    | RevealerProperty.Margin value -> widget.Margin <- value
    | RevealerProperty.Hexpand value -> widget.Hexpand <- value
    | RevealerProperty.HexpandSet value -> widget.HexpandSet <- value
    | RevealerProperty.Vexpand value -> widget.Vexpand <- value
    | RevealerProperty.VexpandSet value -> widget.VexpandSet <- value
    | RevealerProperty.Expand value -> widget.Expand <- value
    | RevealerProperty.Opacity value -> widget.Opacity <- value
    | RevealerProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RevealerProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RevealerProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RevealerProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RevealerProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RevealerProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RevealerProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RevealerProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RevealerProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RevealerProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RevealerProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RevealerProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RevealerProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RevealerProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RevealerProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RevealerProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RevealerProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RevealerProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RevealerProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RevealerProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RevealerProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RevealerProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RevealerProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RevealerProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RevealerProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RevealerProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RevealerProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RevealerProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RevealerProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RevealerProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RevealerProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RevealerProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RevealerProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RevealerProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RevealerProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RevealerProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RevealerProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RevealerProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RevealerProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RevealerProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RevealerProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RevealerProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RevealerProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RevealerProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RevealerProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RevealerProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RevealerProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RevealerProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RevealerProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RevealerProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RevealerProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RevealerProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RevealerProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RevealerProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RevealerProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RevealerProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RevealerProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RevealerProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RevealerProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RevealerProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RevealerPropertyBuilder() =
    inherit BasePropertyBuilder<RevealerProperty>()
    [<CustomOperation("transitionType")>]
    member this.TransitionType(it: RevealerProperty seq, value: Gtk.RevealerTransitionType) =
        seq { yield! it; yield RevealerProperty.TransitionType value } 
    [<CustomOperation("transitionDuration")>]
    member this.TransitionDuration(it: RevealerProperty seq, value: System.UInt32) =
        seq { yield! it; yield RevealerProperty.TransitionDuration value } 
    [<CustomOperation("revealChild")>]
    member this.RevealChild(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.RevealChild value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RevealerProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RevealerProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RevealerProperty seq, value: System.UInt32) =
        seq { yield! it; yield RevealerProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RevealerProperty seq, value: System.String) =
        seq { yield! it; yield RevealerProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RevealerProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RevealerProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RevealerProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RevealerProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RevealerProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RevealerProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RevealerProperty seq, value: System.String) =
        seq { yield! it; yield RevealerProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RevealerProperty seq, value: System.String) =
        seq { yield! it; yield RevealerProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RevealerProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RevealerProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RevealerProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RevealerProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RevealerProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RevealerProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RevealerProperty seq, value: System.Int32) =
        seq { yield! it; yield RevealerProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RevealerProperty seq, value: System.Boolean) =
        seq { yield! it; yield RevealerProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RevealerProperty seq, value: System.Double) =
        seq { yield! it; yield RevealerProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RevealerProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RevealerProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RevealerProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RevealerProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RevealerProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RevealerProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RevealerProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RevealerProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RevealerProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RevealerProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RevealerProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RevealerProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RevealerProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RevealerProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RevealerProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RevealerProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RevealerProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RevealerProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RevealerProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RevealerProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RevealerProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RevealerProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RevealerProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RevealerProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RevealerProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RevealerProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RevealerProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RevealerProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RevealerProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RevealerProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RevealerProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RevealerProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RevealerProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RevealerProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RevealerProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RevealerProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RevealerProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RevealerProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RevealerProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RevealerProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RevealerProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RevealerProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RevealerProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RevealerProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RevealerProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RevealerProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RevealerProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RevealerProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RevealerProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RevealerProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RevealerProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RevealerProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RevealerProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RevealerProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RevealerProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RevealerProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RevealerProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RevealerProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RevealerProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RevealerProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RevealerProperty.OnFocused value } 

let prop = RevealerPropertyBuilder()

type RevealerDescriptor(props) =
    inherit BaseWidgetDescriptor<Revealer, RevealerProperty>(props, bindProperty)
    override this.CreateTyped() = new Revealer()

let revealer props = RevealerDescriptor(props)

