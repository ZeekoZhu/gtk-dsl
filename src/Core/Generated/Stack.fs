module Gtk.DSL.Binding.Stack
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type StackProperty =
    | Homogeneous of System.Boolean
    | Hhomogeneous of System.Boolean
    | Vhomogeneous of System.Boolean
    | VisibleChild of Gtk.Widget
    | VisibleChildName of System.String
    | TransitionDuration of System.UInt32
    | TransitionType of Gtk.StackTransitionType
    | InterpolateSize of System.Boolean
    | Name of System.String
    | Title of System.String
    | IconName of System.String
    | Position of System.Int32
    | NeedsAttention of System.Boolean
    | [<Obsolete>] ResizeMode of Gtk.ResizeMode
    | BorderWidth of System.UInt32
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

let bindProperty (widget: Stack) (prop: StackProperty) =
    match prop with
    | StackProperty.Homogeneous value -> widget.Homogeneous <- value
    | StackProperty.Hhomogeneous value -> widget.Hhomogeneous <- value
    | StackProperty.Vhomogeneous value -> widget.Vhomogeneous <- value
    | StackProperty.VisibleChild value -> widget.VisibleChild <- value
    | StackProperty.VisibleChildName value -> widget.VisibleChildName <- value
    | StackProperty.TransitionDuration value -> widget.TransitionDuration <- value
    | StackProperty.TransitionType value -> widget.TransitionType <- value
    | StackProperty.InterpolateSize value -> widget.InterpolateSize <- value
    | StackProperty.Name value -> widget.Name <- value
    | StackProperty.Title value -> widget.Title <- value
    | StackProperty.IconName value -> widget.IconName <- value
    | StackProperty.Position value -> widget.Position <- value
    | StackProperty.NeedsAttention value -> widget.NeedsAttention <- value
    | StackProperty.ResizeMode value -> widget.ResizeMode <- value
    | StackProperty.BorderWidth value -> widget.BorderWidth <- value
    | StackProperty.Parent value -> widget.Parent <- value
    | StackProperty.WidthRequest value -> widget.WidthRequest <- value
    | StackProperty.HeightRequest value -> widget.HeightRequest <- value
    | StackProperty.Visible value -> widget.Visible <- value
    | StackProperty.Sensitive value -> widget.Sensitive <- value
    | StackProperty.AppPaintable value -> widget.AppPaintable <- value
    | StackProperty.CanFocus value -> widget.CanFocus <- value
    | StackProperty.HasFocus value -> widget.HasFocus <- value
    | StackProperty.IsFocus value -> widget.IsFocus <- value
    | StackProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | StackProperty.CanDefault value -> widget.CanDefault <- value
    | StackProperty.HasDefault value -> widget.HasDefault <- value
    | StackProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | StackProperty.Style value -> widget.Style <- value
    | StackProperty.Events value -> widget.Events <- value
    | StackProperty.NoShowAll value -> widget.NoShowAll <- value
    | StackProperty.HasTooltip value -> widget.HasTooltip <- value
    | StackProperty.TooltipText value -> widget.TooltipText <- value
    | StackProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | StackProperty.Window value -> widget.Window <- value
    | StackProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | StackProperty.Halign value -> widget.Halign <- value
    | StackProperty.Valign value -> widget.Valign <- value
    | StackProperty.MarginLeft value -> widget.MarginLeft <- value
    | StackProperty.MarginRight value -> widget.MarginRight <- value
    | StackProperty.MarginStart value -> widget.MarginStart <- value
    | StackProperty.MarginEnd value -> widget.MarginEnd <- value
    | StackProperty.MarginTop value -> widget.MarginTop <- value
    | StackProperty.MarginBottom value -> widget.MarginBottom <- value
    | StackProperty.Margin value -> widget.Margin <- value
    | StackProperty.Hexpand value -> widget.Hexpand <- value
    | StackProperty.HexpandSet value -> widget.HexpandSet <- value
    | StackProperty.Vexpand value -> widget.Vexpand <- value
    | StackProperty.VexpandSet value -> widget.VexpandSet <- value
    | StackProperty.Expand value -> widget.Expand <- value
    | StackProperty.Opacity value -> widget.Opacity <- value
    | StackProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | StackProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | StackProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | StackProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | StackProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | StackProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | StackProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | StackProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | StackProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | StackProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | StackProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | StackProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | StackProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | StackProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | StackProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | StackProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | StackProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | StackProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | StackProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | StackProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | StackProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | StackProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | StackProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | StackProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | StackProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | StackProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | StackProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | StackProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | StackProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | StackProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | StackProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | StackProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | StackProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | StackProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | StackProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | StackProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | StackProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | StackProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | StackProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | StackProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | StackProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | StackProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | StackProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | StackProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | StackProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | StackProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | StackProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | StackProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | StackProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | StackProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | StackProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | StackProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | StackProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | StackProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | StackProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | StackProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | StackProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | StackProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | StackProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | StackProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type StackPropertyBuilder() =
    inherit BasePropertyBuilder<StackProperty>()
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Homogeneous value } 
    [<CustomOperation("hhomogeneous")>]
    member this.Hhomogeneous(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Hhomogeneous value } 
    [<CustomOperation("vhomogeneous")>]
    member this.Vhomogeneous(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Vhomogeneous value } 
    [<CustomOperation("visibleChild")>]
    member this.VisibleChild(it: StackProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield StackProperty.VisibleChild value } 
    [<CustomOperation("visibleChildName")>]
    member this.VisibleChildName(it: StackProperty seq, value: System.String) =
        seq { yield! it; yield StackProperty.VisibleChildName value } 
    [<CustomOperation("transitionDuration")>]
    member this.TransitionDuration(it: StackProperty seq, value: System.UInt32) =
        seq { yield! it; yield StackProperty.TransitionDuration value } 
    [<CustomOperation("transitionType")>]
    member this.TransitionType(it: StackProperty seq, value: Gtk.StackTransitionType) =
        seq { yield! it; yield StackProperty.TransitionType value } 
    [<CustomOperation("interpolateSize")>]
    member this.InterpolateSize(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.InterpolateSize value } 
    [<CustomOperation("name")>]
    member this.Name(it: StackProperty seq, value: System.String) =
        seq { yield! it; yield StackProperty.Name value } 
    [<CustomOperation("title")>]
    member this.Title(it: StackProperty seq, value: System.String) =
        seq { yield! it; yield StackProperty.Title value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: StackProperty seq, value: System.String) =
        seq { yield! it; yield StackProperty.IconName value } 
    [<CustomOperation("position")>]
    member this.Position(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.Position value } 
    [<CustomOperation("needsAttention")>]
    member this.NeedsAttention(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.NeedsAttention value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: StackProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield StackProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: StackProperty seq, value: System.UInt32) =
        seq { yield! it; yield StackProperty.BorderWidth value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: StackProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield StackProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: StackProperty seq, value: Gtk.Style) =
        seq { yield! it; yield StackProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: StackProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield StackProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: StackProperty seq, value: System.String) =
        seq { yield! it; yield StackProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: StackProperty seq, value: System.String) =
        seq { yield! it; yield StackProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: StackProperty seq, value: Gdk.Window) =
        seq { yield! it; yield StackProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: StackProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StackProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: StackProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StackProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: StackProperty seq, value: System.Int32) =
        seq { yield! it; yield StackProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: StackProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: StackProperty seq, value: System.Double) =
        seq { yield! it; yield StackProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: StackProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield StackProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: StackProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: StackProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: StackProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: StackProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: StackProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: StackProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: StackProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: StackProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: StackProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield StackProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: StackProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: StackProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: StackProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: StackProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: StackProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield StackProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: StackProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield StackProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: StackProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: StackProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: StackProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: StackProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: StackProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: StackProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield StackProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: StackProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield StackProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: StackProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: StackProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: StackProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: StackProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: StackProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: StackProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: StackProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: StackProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: StackProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: StackProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: StackProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: StackProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: StackProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield StackProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: StackProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: StackProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: StackProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: StackProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: StackProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: StackProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield StackProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: StackProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: StackProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: StackProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: StackProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: StackProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: StackProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield StackProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: StackProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield StackProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: StackProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: StackProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: StackProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: StackProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: StackProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: StackProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield StackProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: StackProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: StackProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: StackProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: StackProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield StackProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: StackProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield StackProperty.OnFocused value } 

let prop = StackPropertyBuilder()

type StackDescriptor(props) =
    inherit BaseWidgetDescriptor<Stack, StackProperty>(props, bindProperty)
    override this.CreateTyped() = new Stack()

let stack props = StackDescriptor(props)

