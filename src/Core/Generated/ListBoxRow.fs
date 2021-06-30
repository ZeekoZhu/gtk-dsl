module GtkDsl.Binding.ListBoxRow
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ListBoxRowProperty =
    | Activatable of System.Boolean
    | Selectable of System.Boolean
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

let bindProperty (widget: ListBoxRow) (prop: ListBoxRowProperty) =
    match prop with
    | ListBoxRowProperty.Activatable value -> widget.Activatable <- value
    | ListBoxRowProperty.Selectable value -> widget.Selectable <- value
    | ListBoxRowProperty.ResizeMode value -> widget.ResizeMode <- value
    | ListBoxRowProperty.BorderWidth value -> widget.BorderWidth <- value
    | ListBoxRowProperty.Name value -> widget.Name <- value
    | ListBoxRowProperty.Parent value -> widget.Parent <- value
    | ListBoxRowProperty.WidthRequest value -> widget.WidthRequest <- value
    | ListBoxRowProperty.HeightRequest value -> widget.HeightRequest <- value
    | ListBoxRowProperty.Visible value -> widget.Visible <- value
    | ListBoxRowProperty.Sensitive value -> widget.Sensitive <- value
    | ListBoxRowProperty.AppPaintable value -> widget.AppPaintable <- value
    | ListBoxRowProperty.CanFocus value -> widget.CanFocus <- value
    | ListBoxRowProperty.HasFocus value -> widget.HasFocus <- value
    | ListBoxRowProperty.IsFocus value -> widget.IsFocus <- value
    | ListBoxRowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ListBoxRowProperty.CanDefault value -> widget.CanDefault <- value
    | ListBoxRowProperty.HasDefault value -> widget.HasDefault <- value
    | ListBoxRowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ListBoxRowProperty.Style value -> widget.Style <- value
    | ListBoxRowProperty.Events value -> widget.Events <- value
    | ListBoxRowProperty.NoShowAll value -> widget.NoShowAll <- value
    | ListBoxRowProperty.HasTooltip value -> widget.HasTooltip <- value
    | ListBoxRowProperty.TooltipText value -> widget.TooltipText <- value
    | ListBoxRowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ListBoxRowProperty.Window value -> widget.Window <- value
    | ListBoxRowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ListBoxRowProperty.Halign value -> widget.Halign <- value
    | ListBoxRowProperty.Valign value -> widget.Valign <- value
    | ListBoxRowProperty.MarginLeft value -> widget.MarginLeft <- value
    | ListBoxRowProperty.MarginRight value -> widget.MarginRight <- value
    | ListBoxRowProperty.MarginStart value -> widget.MarginStart <- value
    | ListBoxRowProperty.MarginEnd value -> widget.MarginEnd <- value
    | ListBoxRowProperty.MarginTop value -> widget.MarginTop <- value
    | ListBoxRowProperty.MarginBottom value -> widget.MarginBottom <- value
    | ListBoxRowProperty.Margin value -> widget.Margin <- value
    | ListBoxRowProperty.Hexpand value -> widget.Hexpand <- value
    | ListBoxRowProperty.HexpandSet value -> widget.HexpandSet <- value
    | ListBoxRowProperty.Vexpand value -> widget.Vexpand <- value
    | ListBoxRowProperty.VexpandSet value -> widget.VexpandSet <- value
    | ListBoxRowProperty.Expand value -> widget.Expand <- value
    | ListBoxRowProperty.Opacity value -> widget.Opacity <- value
    | ListBoxRowProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ListBoxRowProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ListBoxRowProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ListBoxRowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ListBoxRowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ListBoxRowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ListBoxRowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ListBoxRowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ListBoxRowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ListBoxRowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ListBoxRowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ListBoxRowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ListBoxRowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ListBoxRowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ListBoxRowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ListBoxRowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ListBoxRowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ListBoxRowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ListBoxRowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ListBoxRowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ListBoxRowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ListBoxRowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ListBoxRowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ListBoxRowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ListBoxRowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ListBoxRowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ListBoxRowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ListBoxRowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ListBoxRowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ListBoxRowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ListBoxRowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ListBoxRowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ListBoxRowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ListBoxRowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ListBoxRowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ListBoxRowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ListBoxRowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ListBoxRowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ListBoxRowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ListBoxRowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ListBoxRowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ListBoxRowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ListBoxRowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ListBoxRowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ListBoxRowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ListBoxRowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ListBoxRowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ListBoxRowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ListBoxRowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ListBoxRowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ListBoxRowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ListBoxRowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ListBoxRowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ListBoxRowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ListBoxRowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ListBoxRowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ListBoxRowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ListBoxRowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ListBoxRowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ListBoxRowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ListBoxRowPropertyBuilder() =
    inherit BasePropertyBuilder<ListBoxRowProperty>()
    [<CustomOperation("activatable")>]
    member this.Activatable(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Activatable value } 
    [<CustomOperation("selectable")>]
    member this.Selectable(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Selectable value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ListBoxRowProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ListBoxRowProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ListBoxRowProperty seq, value: System.UInt32) =
        seq { yield! it; yield ListBoxRowProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ListBoxRowProperty seq, value: System.String) =
        seq { yield! it; yield ListBoxRowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ListBoxRowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ListBoxRowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ListBoxRowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ListBoxRowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ListBoxRowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ListBoxRowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ListBoxRowProperty seq, value: System.String) =
        seq { yield! it; yield ListBoxRowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ListBoxRowProperty seq, value: System.String) =
        seq { yield! it; yield ListBoxRowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ListBoxRowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ListBoxRowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ListBoxRowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ListBoxRowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ListBoxRowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ListBoxRowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ListBoxRowProperty seq, value: System.Int32) =
        seq { yield! it; yield ListBoxRowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ListBoxRowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ListBoxRowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ListBoxRowProperty seq, value: System.Double) =
        seq { yield! it; yield ListBoxRowProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ListBoxRowProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ListBoxRowProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ListBoxRowProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ListBoxRowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ListBoxRowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ListBoxRowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ListBoxRowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ListBoxRowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ListBoxRowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ListBoxRowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ListBoxRowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ListBoxRowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ListBoxRowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ListBoxRowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ListBoxRowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ListBoxRowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ListBoxRowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ListBoxRowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ListBoxRowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ListBoxRowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ListBoxRowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ListBoxRowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ListBoxRowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ListBoxRowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ListBoxRowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ListBoxRowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ListBoxRowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ListBoxRowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ListBoxRowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ListBoxRowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ListBoxRowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ListBoxRowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ListBoxRowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ListBoxRowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ListBoxRowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ListBoxRowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ListBoxRowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ListBoxRowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ListBoxRowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ListBoxRowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ListBoxRowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ListBoxRowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ListBoxRowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ListBoxRowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ListBoxRowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ListBoxRowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ListBoxRowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ListBoxRowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ListBoxRowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ListBoxRowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ListBoxRowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ListBoxRowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ListBoxRowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ListBoxRowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ListBoxRowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ListBoxRowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ListBoxRowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ListBoxRowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ListBoxRowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ListBoxRowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ListBoxRowProperty.OnFocused value } 

let prop = ListBoxRowPropertyBuilder()

type ListBoxRowDescriptor(props) =
    inherit BaseWidgetDescriptor<ListBoxRow, ListBoxRowProperty>(props, bindProperty)
    override this.CreateTyped() = new ListBoxRow()

let listBoxRow props = ListBoxRowDescriptor(props)

