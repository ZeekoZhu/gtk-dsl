module GtkDsl.Binding.FlowBoxChild
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FlowBoxChildProperty =
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

let bindProperty (widget: FlowBoxChild) (prop: FlowBoxChildProperty) =
    match prop with
    | FlowBoxChildProperty.ResizeMode value -> widget.ResizeMode <- value
    | FlowBoxChildProperty.BorderWidth value -> widget.BorderWidth <- value
    | FlowBoxChildProperty.Name value -> widget.Name <- value
    | FlowBoxChildProperty.Parent value -> widget.Parent <- value
    | FlowBoxChildProperty.WidthRequest value -> widget.WidthRequest <- value
    | FlowBoxChildProperty.HeightRequest value -> widget.HeightRequest <- value
    | FlowBoxChildProperty.Visible value -> widget.Visible <- value
    | FlowBoxChildProperty.Sensitive value -> widget.Sensitive <- value
    | FlowBoxChildProperty.AppPaintable value -> widget.AppPaintable <- value
    | FlowBoxChildProperty.CanFocus value -> widget.CanFocus <- value
    | FlowBoxChildProperty.HasFocus value -> widget.HasFocus <- value
    | FlowBoxChildProperty.IsFocus value -> widget.IsFocus <- value
    | FlowBoxChildProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FlowBoxChildProperty.CanDefault value -> widget.CanDefault <- value
    | FlowBoxChildProperty.HasDefault value -> widget.HasDefault <- value
    | FlowBoxChildProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FlowBoxChildProperty.Style value -> widget.Style <- value
    | FlowBoxChildProperty.Events value -> widget.Events <- value
    | FlowBoxChildProperty.NoShowAll value -> widget.NoShowAll <- value
    | FlowBoxChildProperty.HasTooltip value -> widget.HasTooltip <- value
    | FlowBoxChildProperty.TooltipText value -> widget.TooltipText <- value
    | FlowBoxChildProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FlowBoxChildProperty.Window value -> widget.Window <- value
    | FlowBoxChildProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FlowBoxChildProperty.Halign value -> widget.Halign <- value
    | FlowBoxChildProperty.Valign value -> widget.Valign <- value
    | FlowBoxChildProperty.MarginLeft value -> widget.MarginLeft <- value
    | FlowBoxChildProperty.MarginRight value -> widget.MarginRight <- value
    | FlowBoxChildProperty.MarginStart value -> widget.MarginStart <- value
    | FlowBoxChildProperty.MarginEnd value -> widget.MarginEnd <- value
    | FlowBoxChildProperty.MarginTop value -> widget.MarginTop <- value
    | FlowBoxChildProperty.MarginBottom value -> widget.MarginBottom <- value
    | FlowBoxChildProperty.Margin value -> widget.Margin <- value
    | FlowBoxChildProperty.Hexpand value -> widget.Hexpand <- value
    | FlowBoxChildProperty.HexpandSet value -> widget.HexpandSet <- value
    | FlowBoxChildProperty.Vexpand value -> widget.Vexpand <- value
    | FlowBoxChildProperty.VexpandSet value -> widget.VexpandSet <- value
    | FlowBoxChildProperty.Expand value -> widget.Expand <- value
    | FlowBoxChildProperty.Opacity value -> widget.Opacity <- value
    | FlowBoxChildProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FlowBoxChildProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FlowBoxChildProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FlowBoxChildProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FlowBoxChildProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FlowBoxChildProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FlowBoxChildProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FlowBoxChildProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FlowBoxChildProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FlowBoxChildProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FlowBoxChildProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FlowBoxChildProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FlowBoxChildProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FlowBoxChildProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FlowBoxChildProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FlowBoxChildProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FlowBoxChildProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FlowBoxChildProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FlowBoxChildProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FlowBoxChildProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FlowBoxChildProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FlowBoxChildProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FlowBoxChildProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FlowBoxChildProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FlowBoxChildProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FlowBoxChildProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FlowBoxChildProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FlowBoxChildProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FlowBoxChildProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FlowBoxChildProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FlowBoxChildProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FlowBoxChildProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FlowBoxChildProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FlowBoxChildProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FlowBoxChildProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FlowBoxChildProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FlowBoxChildProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FlowBoxChildProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FlowBoxChildProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FlowBoxChildProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FlowBoxChildProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FlowBoxChildProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FlowBoxChildProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FlowBoxChildProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FlowBoxChildProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FlowBoxChildProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FlowBoxChildProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FlowBoxChildProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FlowBoxChildProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FlowBoxChildProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FlowBoxChildProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FlowBoxChildProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FlowBoxChildProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FlowBoxChildProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FlowBoxChildProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FlowBoxChildProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FlowBoxChildProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FlowBoxChildProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FlowBoxChildProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FlowBoxChildProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FlowBoxChildPropertyBuilder() =
    inherit BasePropertyBuilder<FlowBoxChildProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FlowBoxChildProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FlowBoxChildProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FlowBoxChildProperty seq, value: System.UInt32) =
        seq { yield! it; yield FlowBoxChildProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FlowBoxChildProperty seq, value: System.String) =
        seq { yield! it; yield FlowBoxChildProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FlowBoxChildProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FlowBoxChildProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FlowBoxChildProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FlowBoxChildProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FlowBoxChildProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FlowBoxChildProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FlowBoxChildProperty seq, value: System.String) =
        seq { yield! it; yield FlowBoxChildProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FlowBoxChildProperty seq, value: System.String) =
        seq { yield! it; yield FlowBoxChildProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FlowBoxChildProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FlowBoxChildProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FlowBoxChildProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FlowBoxChildProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FlowBoxChildProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FlowBoxChildProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FlowBoxChildProperty seq, value: System.Int32) =
        seq { yield! it; yield FlowBoxChildProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FlowBoxChildProperty seq, value: System.Boolean) =
        seq { yield! it; yield FlowBoxChildProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FlowBoxChildProperty seq, value: System.Double) =
        seq { yield! it; yield FlowBoxChildProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FlowBoxChildProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FlowBoxChildProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FlowBoxChildProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FlowBoxChildProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FlowBoxChildProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FlowBoxChildProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FlowBoxChildProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FlowBoxChildProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FlowBoxChildProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FlowBoxChildProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FlowBoxChildProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FlowBoxChildProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FlowBoxChildProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FlowBoxChildProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FlowBoxChildProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FlowBoxChildProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FlowBoxChildProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FlowBoxChildProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FlowBoxChildProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FlowBoxChildProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FlowBoxChildProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FlowBoxChildProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FlowBoxChildProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FlowBoxChildProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FlowBoxChildProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FlowBoxChildProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FlowBoxChildProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FlowBoxChildProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FlowBoxChildProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FlowBoxChildProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FlowBoxChildProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FlowBoxChildProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FlowBoxChildProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FlowBoxChildProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FlowBoxChildProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FlowBoxChildProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FlowBoxChildProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FlowBoxChildProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FlowBoxChildProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FlowBoxChildProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FlowBoxChildProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FlowBoxChildProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FlowBoxChildProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FlowBoxChildProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FlowBoxChildProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FlowBoxChildProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FlowBoxChildProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FlowBoxChildProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FlowBoxChildProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FlowBoxChildProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FlowBoxChildProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FlowBoxChildProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FlowBoxChildProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FlowBoxChildProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FlowBoxChildProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FlowBoxChildProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FlowBoxChildProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FlowBoxChildProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FlowBoxChildProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FlowBoxChildProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FlowBoxChildProperty.OnFocused value } 

let prop = FlowBoxChildPropertyBuilder()

type FlowBoxChildDescriptor(props) =
    inherit BaseWidgetDescriptor<FlowBoxChild, FlowBoxChildProperty>(props, bindProperty)
    override this.CreateTyped() = new FlowBoxChild()

let flowBoxChild props = FlowBoxChildDescriptor(props)
