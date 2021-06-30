module GtkDsl.Binding.Separator
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SeparatorProperty =
    | Orientation of Gtk.Orientation
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

let bindProperty (widget: Separator) (prop: SeparatorProperty) =
    match prop with
    | SeparatorProperty.Orientation value -> widget.Orientation <- value
    | SeparatorProperty.Name value -> widget.Name <- value
    | SeparatorProperty.Parent value -> widget.Parent <- value
    | SeparatorProperty.WidthRequest value -> widget.WidthRequest <- value
    | SeparatorProperty.HeightRequest value -> widget.HeightRequest <- value
    | SeparatorProperty.Visible value -> widget.Visible <- value
    | SeparatorProperty.Sensitive value -> widget.Sensitive <- value
    | SeparatorProperty.AppPaintable value -> widget.AppPaintable <- value
    | SeparatorProperty.CanFocus value -> widget.CanFocus <- value
    | SeparatorProperty.HasFocus value -> widget.HasFocus <- value
    | SeparatorProperty.IsFocus value -> widget.IsFocus <- value
    | SeparatorProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SeparatorProperty.CanDefault value -> widget.CanDefault <- value
    | SeparatorProperty.HasDefault value -> widget.HasDefault <- value
    | SeparatorProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SeparatorProperty.Style value -> widget.Style <- value
    | SeparatorProperty.Events value -> widget.Events <- value
    | SeparatorProperty.NoShowAll value -> widget.NoShowAll <- value
    | SeparatorProperty.HasTooltip value -> widget.HasTooltip <- value
    | SeparatorProperty.TooltipText value -> widget.TooltipText <- value
    | SeparatorProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SeparatorProperty.Window value -> widget.Window <- value
    | SeparatorProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SeparatorProperty.Halign value -> widget.Halign <- value
    | SeparatorProperty.Valign value -> widget.Valign <- value
    | SeparatorProperty.MarginLeft value -> widget.MarginLeft <- value
    | SeparatorProperty.MarginRight value -> widget.MarginRight <- value
    | SeparatorProperty.MarginStart value -> widget.MarginStart <- value
    | SeparatorProperty.MarginEnd value -> widget.MarginEnd <- value
    | SeparatorProperty.MarginTop value -> widget.MarginTop <- value
    | SeparatorProperty.MarginBottom value -> widget.MarginBottom <- value
    | SeparatorProperty.Margin value -> widget.Margin <- value
    | SeparatorProperty.Hexpand value -> widget.Hexpand <- value
    | SeparatorProperty.HexpandSet value -> widget.HexpandSet <- value
    | SeparatorProperty.Vexpand value -> widget.Vexpand <- value
    | SeparatorProperty.VexpandSet value -> widget.VexpandSet <- value
    | SeparatorProperty.Expand value -> widget.Expand <- value
    | SeparatorProperty.Opacity value -> widget.Opacity <- value
    | SeparatorProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SeparatorProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SeparatorProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SeparatorProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SeparatorProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SeparatorProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SeparatorProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SeparatorProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SeparatorProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SeparatorProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SeparatorProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SeparatorProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SeparatorProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SeparatorProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SeparatorProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SeparatorProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SeparatorProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SeparatorProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SeparatorProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SeparatorProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SeparatorProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SeparatorProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SeparatorProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SeparatorProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SeparatorProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SeparatorProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SeparatorProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SeparatorProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SeparatorProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SeparatorProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SeparatorProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SeparatorProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SeparatorProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SeparatorProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SeparatorProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SeparatorProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SeparatorProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SeparatorProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SeparatorProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SeparatorProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SeparatorProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SeparatorProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SeparatorProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SeparatorProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SeparatorProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SeparatorProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SeparatorProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SeparatorProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SeparatorProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SeparatorProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SeparatorProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SeparatorProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SeparatorProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SeparatorProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SeparatorProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SeparatorProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SeparatorProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SeparatorPropertyBuilder() =
    inherit BasePropertyBuilder<SeparatorProperty>()
    [<CustomOperation("orientation")>]
    member this.Orientation(it: SeparatorProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield SeparatorProperty.Orientation value } 
    [<CustomOperation("name")>]
    member this.Name(it: SeparatorProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SeparatorProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SeparatorProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SeparatorProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SeparatorProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SeparatorProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SeparatorProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SeparatorProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SeparatorProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SeparatorProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SeparatorProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SeparatorProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SeparatorProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SeparatorProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SeparatorProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SeparatorProperty seq, value: System.Double) =
        seq { yield! it; yield SeparatorProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SeparatorProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SeparatorProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SeparatorProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SeparatorProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SeparatorProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SeparatorProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SeparatorProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SeparatorProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SeparatorProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SeparatorProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SeparatorProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SeparatorProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SeparatorProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SeparatorProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SeparatorProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SeparatorProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SeparatorProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SeparatorProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SeparatorProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SeparatorProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SeparatorProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SeparatorProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SeparatorProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SeparatorProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SeparatorProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SeparatorProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SeparatorProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SeparatorProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SeparatorProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SeparatorProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SeparatorProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SeparatorProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SeparatorProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SeparatorProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SeparatorProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SeparatorProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SeparatorProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SeparatorProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SeparatorProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SeparatorProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SeparatorProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SeparatorProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SeparatorProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SeparatorProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SeparatorProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SeparatorProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SeparatorProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SeparatorProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SeparatorProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SeparatorProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SeparatorProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SeparatorProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SeparatorProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SeparatorProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SeparatorProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SeparatorProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SeparatorProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SeparatorProperty.OnFocused value } 

let prop = SeparatorPropertyBuilder()

