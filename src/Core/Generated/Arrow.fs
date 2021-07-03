module Gtk.DSL.Binding.Arrow
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ArrowProperty =
    | ArrowType of Gtk.ArrowType
    | ShadowType of Gtk.ShadowType
    | Xalign of System.Single
    | Yalign of System.Single
    | Xpad of System.Int32
    | Ypad of System.Int32
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

let bindProperty (widget: Arrow) (prop: ArrowProperty) =
    match prop with
    | ArrowProperty.ArrowType value -> widget.ArrowType <- value
    | ArrowProperty.ShadowType value -> widget.ShadowType <- value
    | ArrowProperty.Xalign value -> widget.Xalign <- value
    | ArrowProperty.Yalign value -> widget.Yalign <- value
    | ArrowProperty.Xpad value -> widget.Xpad <- value
    | ArrowProperty.Ypad value -> widget.Ypad <- value
    | ArrowProperty.Name value -> widget.Name <- value
    | ArrowProperty.Parent value -> widget.Parent <- value
    | ArrowProperty.WidthRequest value -> widget.WidthRequest <- value
    | ArrowProperty.HeightRequest value -> widget.HeightRequest <- value
    | ArrowProperty.Visible value -> widget.Visible <- value
    | ArrowProperty.Sensitive value -> widget.Sensitive <- value
    | ArrowProperty.AppPaintable value -> widget.AppPaintable <- value
    | ArrowProperty.CanFocus value -> widget.CanFocus <- value
    | ArrowProperty.HasFocus value -> widget.HasFocus <- value
    | ArrowProperty.IsFocus value -> widget.IsFocus <- value
    | ArrowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ArrowProperty.CanDefault value -> widget.CanDefault <- value
    | ArrowProperty.HasDefault value -> widget.HasDefault <- value
    | ArrowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ArrowProperty.Style value -> widget.Style <- value
    | ArrowProperty.Events value -> widget.Events <- value
    | ArrowProperty.NoShowAll value -> widget.NoShowAll <- value
    | ArrowProperty.HasTooltip value -> widget.HasTooltip <- value
    | ArrowProperty.TooltipText value -> widget.TooltipText <- value
    | ArrowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ArrowProperty.Window value -> widget.Window <- value
    | ArrowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ArrowProperty.Halign value -> widget.Halign <- value
    | ArrowProperty.Valign value -> widget.Valign <- value
    | ArrowProperty.MarginLeft value -> widget.MarginLeft <- value
    | ArrowProperty.MarginRight value -> widget.MarginRight <- value
    | ArrowProperty.MarginStart value -> widget.MarginStart <- value
    | ArrowProperty.MarginEnd value -> widget.MarginEnd <- value
    | ArrowProperty.MarginTop value -> widget.MarginTop <- value
    | ArrowProperty.MarginBottom value -> widget.MarginBottom <- value
    | ArrowProperty.Margin value -> widget.Margin <- value
    | ArrowProperty.Hexpand value -> widget.Hexpand <- value
    | ArrowProperty.HexpandSet value -> widget.HexpandSet <- value
    | ArrowProperty.Vexpand value -> widget.Vexpand <- value
    | ArrowProperty.VexpandSet value -> widget.VexpandSet <- value
    | ArrowProperty.Expand value -> widget.Expand <- value
    | ArrowProperty.Opacity value -> widget.Opacity <- value
    | ArrowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ArrowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ArrowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ArrowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ArrowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ArrowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ArrowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ArrowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ArrowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ArrowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ArrowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ArrowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ArrowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ArrowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ArrowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ArrowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ArrowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ArrowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ArrowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ArrowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ArrowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ArrowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ArrowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ArrowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ArrowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ArrowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ArrowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ArrowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ArrowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ArrowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ArrowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ArrowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ArrowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ArrowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ArrowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ArrowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ArrowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ArrowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ArrowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ArrowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ArrowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ArrowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ArrowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ArrowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ArrowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ArrowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ArrowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ArrowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ArrowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ArrowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ArrowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ArrowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ArrowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ArrowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ArrowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ArrowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ArrowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ArrowPropertyBuilder() =
    inherit BasePropertyBuilder<ArrowProperty>()
    [<CustomOperation("arrowType")>]
    member this.ArrowType(it: ArrowProperty seq, value: Gtk.ArrowType) =
        seq { yield! it; yield ArrowProperty.ArrowType value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: ArrowProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield ArrowProperty.ShadowType value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: ArrowProperty seq, value: System.Single) =
        seq { yield! it; yield ArrowProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: ArrowProperty seq, value: System.Single) =
        seq { yield! it; yield ArrowProperty.Yalign value } 
    [<CustomOperation("xpad")>]
    member this.Xpad(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.Xpad value } 
    [<CustomOperation("ypad")>]
    member this.Ypad(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.Ypad value } 
    [<CustomOperation("name")>]
    member this.Name(it: ArrowProperty seq, value: System.String) =
        seq { yield! it; yield ArrowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ArrowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ArrowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ArrowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ArrowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ArrowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ArrowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ArrowProperty seq, value: System.String) =
        seq { yield! it; yield ArrowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ArrowProperty seq, value: System.String) =
        seq { yield! it; yield ArrowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ArrowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ArrowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ArrowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ArrowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ArrowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ArrowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ArrowProperty seq, value: System.Int32) =
        seq { yield! it; yield ArrowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ArrowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ArrowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ArrowProperty seq, value: System.Double) =
        seq { yield! it; yield ArrowProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ArrowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ArrowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ArrowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ArrowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ArrowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ArrowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ArrowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ArrowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ArrowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ArrowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ArrowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ArrowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ArrowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ArrowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ArrowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ArrowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ArrowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ArrowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ArrowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ArrowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ArrowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ArrowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ArrowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ArrowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ArrowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ArrowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ArrowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ArrowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ArrowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ArrowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ArrowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ArrowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ArrowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ArrowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ArrowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ArrowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ArrowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ArrowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ArrowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ArrowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ArrowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ArrowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ArrowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ArrowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ArrowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ArrowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ArrowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ArrowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ArrowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ArrowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ArrowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ArrowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ArrowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ArrowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ArrowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ArrowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ArrowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ArrowProperty.OnFocused value } 

let prop = ArrowPropertyBuilder()

