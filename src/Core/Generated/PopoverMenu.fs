module Gtk.DSL.Binding.PopoverMenu
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PopoverMenuProperty =
    | VisibleSubmenu of System.String
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

let bindProperty (widget: PopoverMenu) (prop: PopoverMenuProperty) =
    match prop with
    | PopoverMenuProperty.VisibleSubmenu value -> widget.VisibleSubmenu <- value
    | PopoverMenuProperty.RelativeTo value -> widget.RelativeTo <- value
    | PopoverMenuProperty.PointingTo value -> widget.PointingTo <- value
    | PopoverMenuProperty.Position value -> widget.Position <- value
    | PopoverMenuProperty.Modal value -> widget.Modal <- value
    | PopoverMenuProperty.TransitionsEnabled value -> widget.TransitionsEnabled <- value
    | PopoverMenuProperty.ConstrainTo value -> widget.ConstrainTo <- value
    | PopoverMenuProperty.ResizeMode value -> widget.ResizeMode <- value
    | PopoverMenuProperty.BorderWidth value -> widget.BorderWidth <- value
    | PopoverMenuProperty.Name value -> widget.Name <- value
    | PopoverMenuProperty.Parent value -> widget.Parent <- value
    | PopoverMenuProperty.WidthRequest value -> widget.WidthRequest <- value
    | PopoverMenuProperty.HeightRequest value -> widget.HeightRequest <- value
    | PopoverMenuProperty.Visible value -> widget.Visible <- value
    | PopoverMenuProperty.Sensitive value -> widget.Sensitive <- value
    | PopoverMenuProperty.AppPaintable value -> widget.AppPaintable <- value
    | PopoverMenuProperty.CanFocus value -> widget.CanFocus <- value
    | PopoverMenuProperty.HasFocus value -> widget.HasFocus <- value
    | PopoverMenuProperty.IsFocus value -> widget.IsFocus <- value
    | PopoverMenuProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PopoverMenuProperty.CanDefault value -> widget.CanDefault <- value
    | PopoverMenuProperty.HasDefault value -> widget.HasDefault <- value
    | PopoverMenuProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PopoverMenuProperty.Style value -> widget.Style <- value
    | PopoverMenuProperty.Events value -> widget.Events <- value
    | PopoverMenuProperty.NoShowAll value -> widget.NoShowAll <- value
    | PopoverMenuProperty.HasTooltip value -> widget.HasTooltip <- value
    | PopoverMenuProperty.TooltipText value -> widget.TooltipText <- value
    | PopoverMenuProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PopoverMenuProperty.Window value -> widget.Window <- value
    | PopoverMenuProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PopoverMenuProperty.Halign value -> widget.Halign <- value
    | PopoverMenuProperty.Valign value -> widget.Valign <- value
    | PopoverMenuProperty.MarginLeft value -> widget.MarginLeft <- value
    | PopoverMenuProperty.MarginRight value -> widget.MarginRight <- value
    | PopoverMenuProperty.MarginStart value -> widget.MarginStart <- value
    | PopoverMenuProperty.MarginEnd value -> widget.MarginEnd <- value
    | PopoverMenuProperty.MarginTop value -> widget.MarginTop <- value
    | PopoverMenuProperty.MarginBottom value -> widget.MarginBottom <- value
    | PopoverMenuProperty.Margin value -> widget.Margin <- value
    | PopoverMenuProperty.Hexpand value -> widget.Hexpand <- value
    | PopoverMenuProperty.HexpandSet value -> widget.HexpandSet <- value
    | PopoverMenuProperty.Vexpand value -> widget.Vexpand <- value
    | PopoverMenuProperty.VexpandSet value -> widget.VexpandSet <- value
    | PopoverMenuProperty.Expand value -> widget.Expand <- value
    | PopoverMenuProperty.Opacity value -> widget.Opacity <- value
    | PopoverMenuProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PopoverMenuProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PopoverMenuProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PopoverMenuProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PopoverMenuProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PopoverMenuProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PopoverMenuProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PopoverMenuProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PopoverMenuProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PopoverMenuProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PopoverMenuProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PopoverMenuProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PopoverMenuProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PopoverMenuProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PopoverMenuProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PopoverMenuProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PopoverMenuProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PopoverMenuProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PopoverMenuProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PopoverMenuProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PopoverMenuProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PopoverMenuProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PopoverMenuProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PopoverMenuProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PopoverMenuProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PopoverMenuProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PopoverMenuProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PopoverMenuProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PopoverMenuProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PopoverMenuProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PopoverMenuProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PopoverMenuProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PopoverMenuProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PopoverMenuProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PopoverMenuProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PopoverMenuProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PopoverMenuProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PopoverMenuProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PopoverMenuProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PopoverMenuProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PopoverMenuProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PopoverMenuProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PopoverMenuProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PopoverMenuProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PopoverMenuProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PopoverMenuProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PopoverMenuProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PopoverMenuProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PopoverMenuProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PopoverMenuProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PopoverMenuProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PopoverMenuProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PopoverMenuProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PopoverMenuProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PopoverMenuProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PopoverMenuProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PopoverMenuProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PopoverMenuProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PopoverMenuProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PopoverMenuProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PopoverMenuPropertyBuilder() =
    inherit BasePropertyBuilder<PopoverMenuProperty>()
    [<CustomOperation("visibleSubmenu")>]
    member this.VisibleSubmenu(it: PopoverMenuProperty seq, value: System.String) =
        seq { yield! it; yield PopoverMenuProperty.VisibleSubmenu value } 
    [<CustomOperation("relativeTo")>]
    member this.RelativeTo(it: PopoverMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PopoverMenuProperty.RelativeTo value } 
    [<CustomOperation("pointingTo")>]
    member this.PointingTo(it: PopoverMenuProperty seq, value: Gdk.Rectangle) =
        seq { yield! it; yield PopoverMenuProperty.PointingTo value } 
    [<CustomOperation("position")>]
    member this.Position(it: PopoverMenuProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield PopoverMenuProperty.Position value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.Modal value } 
    [<Obsolete>]
    [<CustomOperation("transitionsEnabled")>]
    member this.TransitionsEnabled(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.TransitionsEnabled value } 
    [<CustomOperation("constrainTo")>]
    member this.ConstrainTo(it: PopoverMenuProperty seq, value: Gtk.PopoverConstraint) =
        seq { yield! it; yield PopoverMenuProperty.ConstrainTo value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PopoverMenuProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PopoverMenuProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PopoverMenuProperty seq, value: System.UInt32) =
        seq { yield! it; yield PopoverMenuProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PopoverMenuProperty seq, value: System.String) =
        seq { yield! it; yield PopoverMenuProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PopoverMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PopoverMenuProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PopoverMenuProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PopoverMenuProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PopoverMenuProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PopoverMenuProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PopoverMenuProperty seq, value: System.String) =
        seq { yield! it; yield PopoverMenuProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PopoverMenuProperty seq, value: System.String) =
        seq { yield! it; yield PopoverMenuProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PopoverMenuProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PopoverMenuProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PopoverMenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PopoverMenuProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PopoverMenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PopoverMenuProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PopoverMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield PopoverMenuProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PopoverMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield PopoverMenuProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PopoverMenuProperty seq, value: System.Double) =
        seq { yield! it; yield PopoverMenuProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PopoverMenuProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PopoverMenuProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PopoverMenuProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PopoverMenuProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PopoverMenuProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PopoverMenuProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PopoverMenuProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PopoverMenuProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PopoverMenuProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PopoverMenuProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PopoverMenuProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PopoverMenuProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PopoverMenuProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PopoverMenuProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PopoverMenuProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PopoverMenuProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PopoverMenuProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PopoverMenuProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PopoverMenuProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PopoverMenuProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PopoverMenuProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PopoverMenuProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PopoverMenuProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PopoverMenuProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PopoverMenuProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PopoverMenuProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PopoverMenuProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PopoverMenuProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PopoverMenuProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PopoverMenuProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PopoverMenuProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PopoverMenuProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PopoverMenuProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PopoverMenuProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PopoverMenuProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PopoverMenuProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PopoverMenuProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PopoverMenuProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PopoverMenuProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PopoverMenuProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PopoverMenuProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PopoverMenuProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PopoverMenuProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PopoverMenuProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PopoverMenuProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PopoverMenuProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PopoverMenuProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PopoverMenuProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PopoverMenuProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PopoverMenuProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PopoverMenuProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PopoverMenuProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PopoverMenuProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PopoverMenuProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PopoverMenuProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PopoverMenuProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PopoverMenuProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PopoverMenuProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PopoverMenuProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PopoverMenuProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PopoverMenuProperty.OnFocused value } 

let prop = PopoverMenuPropertyBuilder()

type PopoverMenuDescriptor(props) =
    inherit BaseWidgetDescriptor<PopoverMenu, PopoverMenuProperty>(props, bindProperty)
    override this.CreateTyped() = new PopoverMenu()

let popoverMenu props = PopoverMenuDescriptor(props)

