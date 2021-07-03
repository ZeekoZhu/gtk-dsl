module Gtk.DSL.Binding.Popover
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PopoverProperty =
    | RelativeTo of Gtk.Widget
    | PointingTo of Gdk.Rectangle
    | Position of Gtk.PositionType
    | Modal of System.Boolean
    | [<Obsolete>] TransitionsEnabled of System.Boolean
    | ConstrainTo of Gtk.PopoverConstraint
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

let bindProperty (widget: Popover) (prop: PopoverProperty) =
    match prop with
    | PopoverProperty.RelativeTo value -> widget.RelativeTo <- value
    | PopoverProperty.PointingTo value -> widget.PointingTo <- value
    | PopoverProperty.Position value -> widget.Position <- value
    | PopoverProperty.Modal value -> widget.Modal <- value
    | PopoverProperty.TransitionsEnabled value -> widget.TransitionsEnabled <- value
    | PopoverProperty.ConstrainTo value -> widget.ConstrainTo <- value
    | PopoverProperty.ResizeMode value -> widget.ResizeMode <- value
    | PopoverProperty.BorderWidth value -> widget.BorderWidth <- value
    | PopoverProperty.Name value -> widget.Name <- value
    | PopoverProperty.Parent value -> widget.Parent <- value
    | PopoverProperty.WidthRequest value -> widget.WidthRequest <- value
    | PopoverProperty.HeightRequest value -> widget.HeightRequest <- value
    | PopoverProperty.Visible value -> widget.Visible <- value
    | PopoverProperty.Sensitive value -> widget.Sensitive <- value
    | PopoverProperty.AppPaintable value -> widget.AppPaintable <- value
    | PopoverProperty.CanFocus value -> widget.CanFocus <- value
    | PopoverProperty.HasFocus value -> widget.HasFocus <- value
    | PopoverProperty.IsFocus value -> widget.IsFocus <- value
    | PopoverProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PopoverProperty.CanDefault value -> widget.CanDefault <- value
    | PopoverProperty.HasDefault value -> widget.HasDefault <- value
    | PopoverProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PopoverProperty.Style value -> widget.Style <- value
    | PopoverProperty.Events value -> widget.Events <- value
    | PopoverProperty.NoShowAll value -> widget.NoShowAll <- value
    | PopoverProperty.HasTooltip value -> widget.HasTooltip <- value
    | PopoverProperty.TooltipText value -> widget.TooltipText <- value
    | PopoverProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PopoverProperty.Window value -> widget.Window <- value
    | PopoverProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PopoverProperty.Halign value -> widget.Halign <- value
    | PopoverProperty.Valign value -> widget.Valign <- value
    | PopoverProperty.MarginLeft value -> widget.MarginLeft <- value
    | PopoverProperty.MarginRight value -> widget.MarginRight <- value
    | PopoverProperty.MarginStart value -> widget.MarginStart <- value
    | PopoverProperty.MarginEnd value -> widget.MarginEnd <- value
    | PopoverProperty.MarginTop value -> widget.MarginTop <- value
    | PopoverProperty.MarginBottom value -> widget.MarginBottom <- value
    | PopoverProperty.Margin value -> widget.Margin <- value
    | PopoverProperty.Hexpand value -> widget.Hexpand <- value
    | PopoverProperty.HexpandSet value -> widget.HexpandSet <- value
    | PopoverProperty.Vexpand value -> widget.Vexpand <- value
    | PopoverProperty.VexpandSet value -> widget.VexpandSet <- value
    | PopoverProperty.Expand value -> widget.Expand <- value
    | PopoverProperty.Opacity value -> widget.Opacity <- value
    | PopoverProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PopoverProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PopoverProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PopoverProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PopoverProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PopoverProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PopoverProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PopoverProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PopoverProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PopoverProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PopoverProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PopoverProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PopoverProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PopoverProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PopoverProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PopoverProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PopoverProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PopoverProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PopoverProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PopoverProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PopoverProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PopoverProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PopoverProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PopoverProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PopoverProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PopoverProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PopoverProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PopoverProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PopoverProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PopoverProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PopoverProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PopoverProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PopoverProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PopoverProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PopoverProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PopoverProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PopoverProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PopoverProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PopoverProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PopoverProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PopoverProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PopoverProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PopoverProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PopoverProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PopoverProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PopoverProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PopoverProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PopoverProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PopoverProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PopoverProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PopoverProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PopoverProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PopoverProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PopoverProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PopoverProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PopoverProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PopoverProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PopoverProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PopoverProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PopoverProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PopoverPropertyBuilder() =
    inherit BasePropertyBuilder<PopoverProperty>()
    [<CustomOperation("relativeTo")>]
    member this.RelativeTo(it: PopoverProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PopoverProperty.RelativeTo value } 
    [<CustomOperation("pointingTo")>]
    member this.PointingTo(it: PopoverProperty seq, value: Gdk.Rectangle) =
        seq { yield! it; yield PopoverProperty.PointingTo value } 
    [<CustomOperation("position")>]
    member this.Position(it: PopoverProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield PopoverProperty.Position value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.Modal value } 
    [<Obsolete>]
    [<CustomOperation("transitionsEnabled")>]
    member this.TransitionsEnabled(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.TransitionsEnabled value } 
    [<CustomOperation("constrainTo")>]
    member this.ConstrainTo(it: PopoverProperty seq, value: Gtk.PopoverConstraint) =
        seq { yield! it; yield PopoverProperty.ConstrainTo value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PopoverProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PopoverProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PopoverProperty seq, value: System.UInt32) =
        seq { yield! it; yield PopoverProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PopoverProperty seq, value: System.String) =
        seq { yield! it; yield PopoverProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PopoverProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PopoverProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PopoverProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PopoverProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PopoverProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PopoverProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PopoverProperty seq, value: System.String) =
        seq { yield! it; yield PopoverProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PopoverProperty seq, value: System.String) =
        seq { yield! it; yield PopoverProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PopoverProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PopoverProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PopoverProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PopoverProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PopoverProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PopoverProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PopoverProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PopoverProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PopoverProperty seq, value: System.Double) =
        seq { yield! it; yield PopoverProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PopoverProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PopoverProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PopoverProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PopoverProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PopoverProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PopoverProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PopoverProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PopoverProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PopoverProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PopoverProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PopoverProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PopoverProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PopoverProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PopoverProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PopoverProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PopoverProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PopoverProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PopoverProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PopoverProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PopoverProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PopoverProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PopoverProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PopoverProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PopoverProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PopoverProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PopoverProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PopoverProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PopoverProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PopoverProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PopoverProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PopoverProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PopoverProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PopoverProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PopoverProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PopoverProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PopoverProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PopoverProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PopoverProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PopoverProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PopoverProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PopoverProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PopoverProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PopoverProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PopoverProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PopoverProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PopoverProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PopoverProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PopoverProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PopoverProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PopoverProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PopoverProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PopoverProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PopoverProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PopoverProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PopoverProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PopoverProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PopoverProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PopoverProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PopoverProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PopoverProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PopoverProperty.OnFocused value } 

let prop = PopoverPropertyBuilder()

