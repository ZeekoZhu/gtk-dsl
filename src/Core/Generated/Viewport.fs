module GtkDsl.Binding.Viewport
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ViewportProperty =
    | ShadowType of Gtk.ShadowType
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

let bindProperty (widget: Viewport) (prop: ViewportProperty) =
    match prop with
    | ViewportProperty.ShadowType value -> widget.ShadowType <- value
    | ViewportProperty.Hadjustment value -> widget.Hadjustment <- value
    | ViewportProperty.Vadjustment value -> widget.Vadjustment <- value
    | ViewportProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | ViewportProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | ViewportProperty.ResizeMode value -> widget.ResizeMode <- value
    | ViewportProperty.BorderWidth value -> widget.BorderWidth <- value
    | ViewportProperty.Name value -> widget.Name <- value
    | ViewportProperty.Parent value -> widget.Parent <- value
    | ViewportProperty.WidthRequest value -> widget.WidthRequest <- value
    | ViewportProperty.HeightRequest value -> widget.HeightRequest <- value
    | ViewportProperty.Visible value -> widget.Visible <- value
    | ViewportProperty.Sensitive value -> widget.Sensitive <- value
    | ViewportProperty.AppPaintable value -> widget.AppPaintable <- value
    | ViewportProperty.CanFocus value -> widget.CanFocus <- value
    | ViewportProperty.HasFocus value -> widget.HasFocus <- value
    | ViewportProperty.IsFocus value -> widget.IsFocus <- value
    | ViewportProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ViewportProperty.CanDefault value -> widget.CanDefault <- value
    | ViewportProperty.HasDefault value -> widget.HasDefault <- value
    | ViewportProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ViewportProperty.Style value -> widget.Style <- value
    | ViewportProperty.Events value -> widget.Events <- value
    | ViewportProperty.NoShowAll value -> widget.NoShowAll <- value
    | ViewportProperty.HasTooltip value -> widget.HasTooltip <- value
    | ViewportProperty.TooltipText value -> widget.TooltipText <- value
    | ViewportProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ViewportProperty.Window value -> widget.Window <- value
    | ViewportProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ViewportProperty.Halign value -> widget.Halign <- value
    | ViewportProperty.Valign value -> widget.Valign <- value
    | ViewportProperty.MarginLeft value -> widget.MarginLeft <- value
    | ViewportProperty.MarginRight value -> widget.MarginRight <- value
    | ViewportProperty.MarginStart value -> widget.MarginStart <- value
    | ViewportProperty.MarginEnd value -> widget.MarginEnd <- value
    | ViewportProperty.MarginTop value -> widget.MarginTop <- value
    | ViewportProperty.MarginBottom value -> widget.MarginBottom <- value
    | ViewportProperty.Margin value -> widget.Margin <- value
    | ViewportProperty.Hexpand value -> widget.Hexpand <- value
    | ViewportProperty.HexpandSet value -> widget.HexpandSet <- value
    | ViewportProperty.Vexpand value -> widget.Vexpand <- value
    | ViewportProperty.VexpandSet value -> widget.VexpandSet <- value
    | ViewportProperty.Expand value -> widget.Expand <- value
    | ViewportProperty.Opacity value -> widget.Opacity <- value
    | ViewportProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ViewportProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ViewportProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ViewportProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ViewportProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ViewportProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ViewportProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ViewportProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ViewportProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ViewportProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ViewportProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ViewportProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ViewportProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ViewportProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ViewportProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ViewportProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ViewportProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ViewportProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ViewportProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ViewportProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ViewportProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ViewportProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ViewportProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ViewportProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ViewportProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ViewportProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ViewportProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ViewportProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ViewportProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ViewportProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ViewportProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ViewportProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ViewportProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ViewportProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ViewportProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ViewportProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ViewportProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ViewportProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ViewportProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ViewportProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ViewportProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ViewportProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ViewportProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ViewportProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ViewportProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ViewportProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ViewportProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ViewportProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ViewportProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ViewportProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ViewportProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ViewportProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ViewportProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ViewportProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ViewportProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ViewportProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ViewportProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ViewportProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ViewportProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ViewportProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ViewportPropertyBuilder() =
    inherit BasePropertyBuilder<ViewportProperty>()
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: ViewportProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield ViewportProperty.ShadowType value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: ViewportProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ViewportProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: ViewportProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ViewportProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: ViewportProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield ViewportProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: ViewportProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield ViewportProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ViewportProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ViewportProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ViewportProperty seq, value: System.UInt32) =
        seq { yield! it; yield ViewportProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ViewportProperty seq, value: System.String) =
        seq { yield! it; yield ViewportProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ViewportProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ViewportProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ViewportProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ViewportProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ViewportProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ViewportProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ViewportProperty seq, value: System.String) =
        seq { yield! it; yield ViewportProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ViewportProperty seq, value: System.String) =
        seq { yield! it; yield ViewportProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ViewportProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ViewportProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ViewportProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ViewportProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ViewportProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ViewportProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ViewportProperty seq, value: System.Int32) =
        seq { yield! it; yield ViewportProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ViewportProperty seq, value: System.Boolean) =
        seq { yield! it; yield ViewportProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ViewportProperty seq, value: System.Double) =
        seq { yield! it; yield ViewportProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ViewportProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ViewportProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ViewportProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ViewportProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ViewportProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ViewportProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ViewportProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ViewportProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ViewportProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ViewportProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ViewportProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ViewportProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ViewportProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ViewportProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ViewportProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ViewportProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ViewportProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ViewportProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ViewportProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ViewportProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ViewportProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ViewportProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ViewportProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ViewportProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ViewportProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ViewportProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ViewportProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ViewportProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ViewportProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ViewportProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ViewportProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ViewportProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ViewportProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ViewportProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ViewportProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ViewportProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ViewportProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ViewportProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ViewportProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ViewportProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ViewportProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ViewportProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ViewportProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ViewportProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ViewportProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ViewportProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ViewportProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ViewportProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ViewportProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ViewportProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ViewportProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ViewportProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ViewportProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ViewportProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ViewportProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ViewportProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ViewportProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ViewportProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ViewportProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ViewportProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ViewportProperty.OnFocused value } 

let prop = ViewportPropertyBuilder()

type ViewportDescriptor(props) =
    inherit BaseWidgetDescriptor<Viewport, ViewportProperty>(props, bindProperty)
    override this.CreateTyped() = new Viewport()

let viewport props = ViewportDescriptor(props)

