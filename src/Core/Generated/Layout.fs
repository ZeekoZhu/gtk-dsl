module Gtk.DSL.Binding.Layout
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type LayoutProperty =
    | Width of System.UInt32
    | Height of System.UInt32
    | Hadjustment of Gtk.Adjustment
    | Vadjustment of Gtk.Adjustment
    | HscrollPolicy of Gtk.ScrollablePolicy
    | VscrollPolicy of Gtk.ScrollablePolicy
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

let bindProperty (widget: Layout) (prop: LayoutProperty) =
    match prop with
    | LayoutProperty.Width value -> widget.Width <- value
    | LayoutProperty.Height value -> widget.Height <- value
    | LayoutProperty.Hadjustment value -> widget.Hadjustment <- value
    | LayoutProperty.Vadjustment value -> widget.Vadjustment <- value
    | LayoutProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | LayoutProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | LayoutProperty.ResizeMode value -> widget.ResizeMode <- value
    | LayoutProperty.BorderWidth value -> widget.BorderWidth <- value
    | LayoutProperty.Name value -> widget.Name <- value
    | LayoutProperty.Parent value -> widget.Parent <- value
    | LayoutProperty.WidthRequest value -> widget.WidthRequest <- value
    | LayoutProperty.HeightRequest value -> widget.HeightRequest <- value
    | LayoutProperty.Visible value -> widget.Visible <- value
    | LayoutProperty.Sensitive value -> widget.Sensitive <- value
    | LayoutProperty.AppPaintable value -> widget.AppPaintable <- value
    | LayoutProperty.CanFocus value -> widget.CanFocus <- value
    | LayoutProperty.HasFocus value -> widget.HasFocus <- value
    | LayoutProperty.IsFocus value -> widget.IsFocus <- value
    | LayoutProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | LayoutProperty.CanDefault value -> widget.CanDefault <- value
    | LayoutProperty.HasDefault value -> widget.HasDefault <- value
    | LayoutProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | LayoutProperty.Style value -> widget.Style <- value
    | LayoutProperty.Events value -> widget.Events <- value
    | LayoutProperty.NoShowAll value -> widget.NoShowAll <- value
    | LayoutProperty.HasTooltip value -> widget.HasTooltip <- value
    | LayoutProperty.TooltipText value -> widget.TooltipText <- value
    | LayoutProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | LayoutProperty.Window value -> widget.Window <- value
    | LayoutProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | LayoutProperty.Halign value -> widget.Halign <- value
    | LayoutProperty.Valign value -> widget.Valign <- value
    | LayoutProperty.MarginLeft value -> widget.MarginLeft <- value
    | LayoutProperty.MarginRight value -> widget.MarginRight <- value
    | LayoutProperty.MarginStart value -> widget.MarginStart <- value
    | LayoutProperty.MarginEnd value -> widget.MarginEnd <- value
    | LayoutProperty.MarginTop value -> widget.MarginTop <- value
    | LayoutProperty.MarginBottom value -> widget.MarginBottom <- value
    | LayoutProperty.Margin value -> widget.Margin <- value
    | LayoutProperty.Hexpand value -> widget.Hexpand <- value
    | LayoutProperty.HexpandSet value -> widget.HexpandSet <- value
    | LayoutProperty.Vexpand value -> widget.Vexpand <- value
    | LayoutProperty.VexpandSet value -> widget.VexpandSet <- value
    | LayoutProperty.Expand value -> widget.Expand <- value
    | LayoutProperty.Opacity value -> widget.Opacity <- value
    | LayoutProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | LayoutProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | LayoutProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | LayoutProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | LayoutProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | LayoutProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | LayoutProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | LayoutProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | LayoutProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | LayoutProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | LayoutProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | LayoutProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | LayoutProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | LayoutProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | LayoutProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | LayoutProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | LayoutProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | LayoutProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | LayoutProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | LayoutProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | LayoutProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | LayoutProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | LayoutProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | LayoutProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | LayoutProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | LayoutProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | LayoutProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | LayoutProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | LayoutProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | LayoutProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | LayoutProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | LayoutProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | LayoutProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | LayoutProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | LayoutProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | LayoutProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | LayoutProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | LayoutProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | LayoutProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | LayoutProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | LayoutProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | LayoutProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | LayoutProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | LayoutProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | LayoutProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | LayoutProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | LayoutProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | LayoutProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | LayoutProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | LayoutProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | LayoutProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | LayoutProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | LayoutProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | LayoutProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | LayoutProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | LayoutProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | LayoutProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | LayoutProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | LayoutProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | LayoutProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type LayoutPropertyBuilder() =
    inherit BasePropertyBuilder<LayoutProperty>()
    [<CustomOperation("width")>]
    member this.Width(it: LayoutProperty seq, value: System.UInt32) =
        seq { yield! it; yield LayoutProperty.Width value } 
    [<CustomOperation("height")>]
    member this.Height(it: LayoutProperty seq, value: System.UInt32) =
        seq { yield! it; yield LayoutProperty.Height value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: LayoutProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield LayoutProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: LayoutProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield LayoutProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: LayoutProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield LayoutProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: LayoutProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield LayoutProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: LayoutProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield LayoutProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: LayoutProperty seq, value: System.UInt32) =
        seq { yield! it; yield LayoutProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: LayoutProperty seq, value: System.String) =
        seq { yield! it; yield LayoutProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: LayoutProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield LayoutProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: LayoutProperty seq, value: Gtk.Style) =
        seq { yield! it; yield LayoutProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: LayoutProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield LayoutProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: LayoutProperty seq, value: System.String) =
        seq { yield! it; yield LayoutProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: LayoutProperty seq, value: System.String) =
        seq { yield! it; yield LayoutProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: LayoutProperty seq, value: Gdk.Window) =
        seq { yield! it; yield LayoutProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: LayoutProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LayoutProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: LayoutProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LayoutProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: LayoutProperty seq, value: System.Int32) =
        seq { yield! it; yield LayoutProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: LayoutProperty seq, value: System.Boolean) =
        seq { yield! it; yield LayoutProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: LayoutProperty seq, value: System.Double) =
        seq { yield! it; yield LayoutProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: LayoutProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: LayoutProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: LayoutProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: LayoutProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: LayoutProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: LayoutProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: LayoutProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: LayoutProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: LayoutProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: LayoutProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: LayoutProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: LayoutProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: LayoutProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: LayoutProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: LayoutProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: LayoutProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: LayoutProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: LayoutProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: LayoutProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: LayoutProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: LayoutProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: LayoutProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: LayoutProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: LayoutProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: LayoutProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: LayoutProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: LayoutProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: LayoutProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: LayoutProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: LayoutProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: LayoutProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: LayoutProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: LayoutProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: LayoutProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: LayoutProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: LayoutProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: LayoutProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: LayoutProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: LayoutProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: LayoutProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: LayoutProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: LayoutProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: LayoutProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: LayoutProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: LayoutProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: LayoutProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: LayoutProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: LayoutProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: LayoutProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: LayoutProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: LayoutProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: LayoutProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: LayoutProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: LayoutProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: LayoutProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: LayoutProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: LayoutProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: LayoutProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: LayoutProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: LayoutProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield LayoutProperty.OnFocused value } 

let prop = LayoutPropertyBuilder()

