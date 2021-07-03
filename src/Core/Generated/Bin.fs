module Gtk.DSL.Binding.Bin
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type BinProperty =
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

let bindProperty (widget: Bin) (prop: BinProperty) =
    match prop with
    | BinProperty.ResizeMode value -> widget.ResizeMode <- value
    | BinProperty.BorderWidth value -> widget.BorderWidth <- value
    | BinProperty.Name value -> widget.Name <- value
    | BinProperty.Parent value -> widget.Parent <- value
    | BinProperty.WidthRequest value -> widget.WidthRequest <- value
    | BinProperty.HeightRequest value -> widget.HeightRequest <- value
    | BinProperty.Visible value -> widget.Visible <- value
    | BinProperty.Sensitive value -> widget.Sensitive <- value
    | BinProperty.AppPaintable value -> widget.AppPaintable <- value
    | BinProperty.CanFocus value -> widget.CanFocus <- value
    | BinProperty.HasFocus value -> widget.HasFocus <- value
    | BinProperty.IsFocus value -> widget.IsFocus <- value
    | BinProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | BinProperty.CanDefault value -> widget.CanDefault <- value
    | BinProperty.HasDefault value -> widget.HasDefault <- value
    | BinProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | BinProperty.Style value -> widget.Style <- value
    | BinProperty.Events value -> widget.Events <- value
    | BinProperty.NoShowAll value -> widget.NoShowAll <- value
    | BinProperty.HasTooltip value -> widget.HasTooltip <- value
    | BinProperty.TooltipText value -> widget.TooltipText <- value
    | BinProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | BinProperty.Window value -> widget.Window <- value
    | BinProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | BinProperty.Halign value -> widget.Halign <- value
    | BinProperty.Valign value -> widget.Valign <- value
    | BinProperty.MarginLeft value -> widget.MarginLeft <- value
    | BinProperty.MarginRight value -> widget.MarginRight <- value
    | BinProperty.MarginStart value -> widget.MarginStart <- value
    | BinProperty.MarginEnd value -> widget.MarginEnd <- value
    | BinProperty.MarginTop value -> widget.MarginTop <- value
    | BinProperty.MarginBottom value -> widget.MarginBottom <- value
    | BinProperty.Margin value -> widget.Margin <- value
    | BinProperty.Hexpand value -> widget.Hexpand <- value
    | BinProperty.HexpandSet value -> widget.HexpandSet <- value
    | BinProperty.Vexpand value -> widget.Vexpand <- value
    | BinProperty.VexpandSet value -> widget.VexpandSet <- value
    | BinProperty.Expand value -> widget.Expand <- value
    | BinProperty.Opacity value -> widget.Opacity <- value
    | BinProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | BinProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | BinProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | BinProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | BinProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | BinProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | BinProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | BinProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | BinProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | BinProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | BinProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | BinProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | BinProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | BinProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | BinProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | BinProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | BinProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | BinProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | BinProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | BinProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | BinProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | BinProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | BinProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | BinProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | BinProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | BinProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | BinProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | BinProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | BinProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | BinProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | BinProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | BinProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | BinProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | BinProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | BinProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | BinProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | BinProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | BinProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | BinProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | BinProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | BinProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | BinProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | BinProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | BinProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | BinProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | BinProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | BinProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | BinProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | BinProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | BinProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | BinProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | BinProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | BinProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | BinProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | BinProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | BinProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | BinProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | BinProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | BinProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | BinProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type BinPropertyBuilder() =
    inherit BasePropertyBuilder<BinProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: BinProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield BinProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: BinProperty seq, value: System.UInt32) =
        seq { yield! it; yield BinProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: BinProperty seq, value: System.String) =
        seq { yield! it; yield BinProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: BinProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield BinProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: BinProperty seq, value: Gtk.Style) =
        seq { yield! it; yield BinProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: BinProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield BinProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: BinProperty seq, value: System.String) =
        seq { yield! it; yield BinProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: BinProperty seq, value: System.String) =
        seq { yield! it; yield BinProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: BinProperty seq, value: Gdk.Window) =
        seq { yield! it; yield BinProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: BinProperty seq, value: Gtk.Align) =
        seq { yield! it; yield BinProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: BinProperty seq, value: Gtk.Align) =
        seq { yield! it; yield BinProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: BinProperty seq, value: System.Int32) =
        seq { yield! it; yield BinProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: BinProperty seq, value: System.Boolean) =
        seq { yield! it; yield BinProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: BinProperty seq, value: System.Double) =
        seq { yield! it; yield BinProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: BinProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield BinProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: BinProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: BinProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: BinProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: BinProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: BinProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: BinProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: BinProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: BinProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: BinProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield BinProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: BinProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: BinProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: BinProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: BinProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: BinProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield BinProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: BinProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield BinProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: BinProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: BinProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: BinProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: BinProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: BinProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: BinProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield BinProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: BinProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield BinProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: BinProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: BinProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: BinProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: BinProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: BinProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: BinProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: BinProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: BinProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: BinProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: BinProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: BinProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: BinProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: BinProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield BinProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: BinProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: BinProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: BinProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: BinProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: BinProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: BinProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield BinProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: BinProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: BinProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: BinProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: BinProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: BinProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: BinProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield BinProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: BinProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield BinProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: BinProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: BinProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: BinProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: BinProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: BinProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: BinProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield BinProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: BinProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: BinProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: BinProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: BinProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield BinProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: BinProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield BinProperty.OnFocused value } 

let prop = BinPropertyBuilder()

