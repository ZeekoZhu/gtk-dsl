module GtkDsl.Binding.Socket
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SocketProperty =
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
    |  OnPlugRemoved of (Gtk.PlugRemovedArgs -> unit)
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

let bindProperty (widget: Socket) (prop: SocketProperty) =
    match prop with
    | SocketProperty.ResizeMode value -> widget.ResizeMode <- value
    | SocketProperty.BorderWidth value -> widget.BorderWidth <- value
    | SocketProperty.Name value -> widget.Name <- value
    | SocketProperty.Parent value -> widget.Parent <- value
    | SocketProperty.WidthRequest value -> widget.WidthRequest <- value
    | SocketProperty.HeightRequest value -> widget.HeightRequest <- value
    | SocketProperty.Visible value -> widget.Visible <- value
    | SocketProperty.Sensitive value -> widget.Sensitive <- value
    | SocketProperty.AppPaintable value -> widget.AppPaintable <- value
    | SocketProperty.CanFocus value -> widget.CanFocus <- value
    | SocketProperty.HasFocus value -> widget.HasFocus <- value
    | SocketProperty.IsFocus value -> widget.IsFocus <- value
    | SocketProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SocketProperty.CanDefault value -> widget.CanDefault <- value
    | SocketProperty.HasDefault value -> widget.HasDefault <- value
    | SocketProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SocketProperty.Style value -> widget.Style <- value
    | SocketProperty.Events value -> widget.Events <- value
    | SocketProperty.NoShowAll value -> widget.NoShowAll <- value
    | SocketProperty.HasTooltip value -> widget.HasTooltip <- value
    | SocketProperty.TooltipText value -> widget.TooltipText <- value
    | SocketProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SocketProperty.Window value -> widget.Window <- value
    | SocketProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SocketProperty.Halign value -> widget.Halign <- value
    | SocketProperty.Valign value -> widget.Valign <- value
    | SocketProperty.MarginLeft value -> widget.MarginLeft <- value
    | SocketProperty.MarginRight value -> widget.MarginRight <- value
    | SocketProperty.MarginStart value -> widget.MarginStart <- value
    | SocketProperty.MarginEnd value -> widget.MarginEnd <- value
    | SocketProperty.MarginTop value -> widget.MarginTop <- value
    | SocketProperty.MarginBottom value -> widget.MarginBottom <- value
    | SocketProperty.Margin value -> widget.Margin <- value
    | SocketProperty.Hexpand value -> widget.Hexpand <- value
    | SocketProperty.HexpandSet value -> widget.HexpandSet <- value
    | SocketProperty.Vexpand value -> widget.Vexpand <- value
    | SocketProperty.VexpandSet value -> widget.VexpandSet <- value
    | SocketProperty.Expand value -> widget.Expand <- value
    | SocketProperty.Opacity value -> widget.Opacity <- value
    | SocketProperty.OnPlugRemoved handler -> 
        let disposable = widget.PlugRemoved.Subscribe(handler)
        registerListener widget "PlugRemoved" disposable
    | SocketProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | SocketProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | SocketProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | SocketProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SocketProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SocketProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SocketProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SocketProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SocketProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SocketProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SocketProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SocketProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SocketProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SocketProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SocketProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SocketProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SocketProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SocketProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SocketProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SocketProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SocketProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SocketProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SocketProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SocketProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SocketProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SocketProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SocketProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SocketProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SocketProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SocketProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SocketProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SocketProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SocketProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SocketProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SocketProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SocketProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SocketProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SocketProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SocketProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SocketProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SocketProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SocketProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SocketProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SocketProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SocketProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SocketProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SocketProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SocketProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SocketProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SocketProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SocketProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SocketProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SocketProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SocketProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SocketProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SocketProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SocketProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SocketProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SocketProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SocketProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SocketPropertyBuilder() =
    inherit BasePropertyBuilder<SocketProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: SocketProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield SocketProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: SocketProperty seq, value: System.UInt32) =
        seq { yield! it; yield SocketProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: SocketProperty seq, value: System.String) =
        seq { yield! it; yield SocketProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SocketProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SocketProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SocketProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SocketProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SocketProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SocketProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SocketProperty seq, value: System.String) =
        seq { yield! it; yield SocketProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SocketProperty seq, value: System.String) =
        seq { yield! it; yield SocketProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SocketProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SocketProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SocketProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SocketProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SocketProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SocketProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SocketProperty seq, value: System.Int32) =
        seq { yield! it; yield SocketProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SocketProperty seq, value: System.Boolean) =
        seq { yield! it; yield SocketProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SocketProperty seq, value: System.Double) =
        seq { yield! it; yield SocketProperty.Opacity value } 
    [<CustomOperation("onPlugRemoved")>]
    member this.OnPlugRemoved(it: SocketProperty seq, value: Gtk.PlugRemovedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnPlugRemoved value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: SocketProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: SocketProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: SocketProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SocketProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SocketProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SocketProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SocketProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SocketProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SocketProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SocketProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SocketProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SocketProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SocketProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SocketProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SocketProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SocketProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SocketProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SocketProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SocketProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SocketProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SocketProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SocketProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SocketProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SocketProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SocketProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SocketProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SocketProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SocketProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SocketProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SocketProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SocketProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SocketProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SocketProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SocketProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SocketProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SocketProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SocketProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SocketProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SocketProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SocketProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SocketProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SocketProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SocketProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SocketProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SocketProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SocketProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SocketProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SocketProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SocketProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SocketProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SocketProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SocketProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SocketProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SocketProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SocketProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SocketProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SocketProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SocketProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SocketProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SocketProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SocketProperty.OnFocused value } 

let prop = SocketPropertyBuilder()

type SocketDescriptor(props) =
    inherit BaseWidgetDescriptor<Socket, SocketProperty>(props, bindProperty)
    override this.CreateTyped() = new Socket()

let socket props = SocketDescriptor(props)

