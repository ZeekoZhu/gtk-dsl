module GtkDsl.Binding.Container
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ContainerProperty =
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

let bindProperty (widget: Container) (prop: ContainerProperty) =
    match prop with
    | ContainerProperty.ResizeMode value -> widget.ResizeMode <- value
    | ContainerProperty.BorderWidth value -> widget.BorderWidth <- value
    | ContainerProperty.Name value -> widget.Name <- value
    | ContainerProperty.Parent value -> widget.Parent <- value
    | ContainerProperty.WidthRequest value -> widget.WidthRequest <- value
    | ContainerProperty.HeightRequest value -> widget.HeightRequest <- value
    | ContainerProperty.Visible value -> widget.Visible <- value
    | ContainerProperty.Sensitive value -> widget.Sensitive <- value
    | ContainerProperty.AppPaintable value -> widget.AppPaintable <- value
    | ContainerProperty.CanFocus value -> widget.CanFocus <- value
    | ContainerProperty.HasFocus value -> widget.HasFocus <- value
    | ContainerProperty.IsFocus value -> widget.IsFocus <- value
    | ContainerProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ContainerProperty.CanDefault value -> widget.CanDefault <- value
    | ContainerProperty.HasDefault value -> widget.HasDefault <- value
    | ContainerProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ContainerProperty.Style value -> widget.Style <- value
    | ContainerProperty.Events value -> widget.Events <- value
    | ContainerProperty.NoShowAll value -> widget.NoShowAll <- value
    | ContainerProperty.HasTooltip value -> widget.HasTooltip <- value
    | ContainerProperty.TooltipText value -> widget.TooltipText <- value
    | ContainerProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ContainerProperty.Window value -> widget.Window <- value
    | ContainerProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ContainerProperty.Halign value -> widget.Halign <- value
    | ContainerProperty.Valign value -> widget.Valign <- value
    | ContainerProperty.MarginLeft value -> widget.MarginLeft <- value
    | ContainerProperty.MarginRight value -> widget.MarginRight <- value
    | ContainerProperty.MarginStart value -> widget.MarginStart <- value
    | ContainerProperty.MarginEnd value -> widget.MarginEnd <- value
    | ContainerProperty.MarginTop value -> widget.MarginTop <- value
    | ContainerProperty.MarginBottom value -> widget.MarginBottom <- value
    | ContainerProperty.Margin value -> widget.Margin <- value
    | ContainerProperty.Hexpand value -> widget.Hexpand <- value
    | ContainerProperty.HexpandSet value -> widget.HexpandSet <- value
    | ContainerProperty.Vexpand value -> widget.Vexpand <- value
    | ContainerProperty.VexpandSet value -> widget.VexpandSet <- value
    | ContainerProperty.Expand value -> widget.Expand <- value
    | ContainerProperty.Opacity value -> widget.Opacity <- value
    | ContainerProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ContainerProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ContainerProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ContainerProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ContainerProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ContainerProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ContainerProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ContainerProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ContainerProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ContainerProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ContainerProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ContainerProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ContainerProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ContainerProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ContainerProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ContainerProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ContainerProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ContainerProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ContainerProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ContainerProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ContainerProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ContainerProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ContainerProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ContainerProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ContainerProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ContainerProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ContainerProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ContainerProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ContainerProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ContainerProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ContainerProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ContainerProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ContainerProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ContainerProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ContainerProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ContainerProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ContainerProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ContainerProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ContainerProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ContainerProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ContainerProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ContainerProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ContainerProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ContainerProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ContainerProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ContainerProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ContainerProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ContainerProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ContainerProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ContainerProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ContainerProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ContainerProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ContainerProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ContainerProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ContainerProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ContainerProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ContainerProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ContainerProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ContainerProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ContainerProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ContainerPropertyBuilder() =
    inherit BasePropertyBuilder<ContainerProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ContainerProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ContainerProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ContainerProperty seq, value: System.UInt32) =
        seq { yield! it; yield ContainerProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ContainerProperty seq, value: System.String) =
        seq { yield! it; yield ContainerProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ContainerProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ContainerProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ContainerProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ContainerProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ContainerProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ContainerProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ContainerProperty seq, value: System.String) =
        seq { yield! it; yield ContainerProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ContainerProperty seq, value: System.String) =
        seq { yield! it; yield ContainerProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ContainerProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ContainerProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ContainerProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ContainerProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ContainerProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ContainerProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ContainerProperty seq, value: System.Int32) =
        seq { yield! it; yield ContainerProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ContainerProperty seq, value: System.Boolean) =
        seq { yield! it; yield ContainerProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ContainerProperty seq, value: System.Double) =
        seq { yield! it; yield ContainerProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ContainerProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ContainerProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ContainerProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ContainerProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ContainerProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ContainerProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ContainerProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ContainerProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ContainerProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ContainerProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ContainerProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ContainerProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ContainerProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ContainerProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ContainerProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ContainerProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ContainerProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ContainerProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ContainerProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ContainerProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ContainerProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ContainerProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ContainerProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ContainerProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ContainerProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ContainerProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ContainerProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ContainerProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ContainerProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ContainerProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ContainerProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ContainerProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ContainerProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ContainerProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ContainerProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ContainerProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ContainerProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ContainerProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ContainerProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ContainerProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ContainerProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ContainerProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ContainerProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ContainerProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ContainerProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ContainerProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ContainerProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ContainerProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ContainerProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ContainerProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ContainerProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ContainerProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ContainerProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ContainerProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ContainerProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ContainerProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ContainerProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ContainerProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ContainerProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ContainerProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ContainerProperty.OnFocused value } 

let prop = ContainerPropertyBuilder()

