module GtkDsl.Binding.HSeparator
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HSeparatorProperty =
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

let bindProperty (widget: HSeparator) (prop: HSeparatorProperty) =
    match prop with
    | HSeparatorProperty.Orientation value -> widget.Orientation <- value
    | HSeparatorProperty.Name value -> widget.Name <- value
    | HSeparatorProperty.Parent value -> widget.Parent <- value
    | HSeparatorProperty.WidthRequest value -> widget.WidthRequest <- value
    | HSeparatorProperty.HeightRequest value -> widget.HeightRequest <- value
    | HSeparatorProperty.Visible value -> widget.Visible <- value
    | HSeparatorProperty.Sensitive value -> widget.Sensitive <- value
    | HSeparatorProperty.AppPaintable value -> widget.AppPaintable <- value
    | HSeparatorProperty.CanFocus value -> widget.CanFocus <- value
    | HSeparatorProperty.HasFocus value -> widget.HasFocus <- value
    | HSeparatorProperty.IsFocus value -> widget.IsFocus <- value
    | HSeparatorProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HSeparatorProperty.CanDefault value -> widget.CanDefault <- value
    | HSeparatorProperty.HasDefault value -> widget.HasDefault <- value
    | HSeparatorProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HSeparatorProperty.Style value -> widget.Style <- value
    | HSeparatorProperty.Events value -> widget.Events <- value
    | HSeparatorProperty.NoShowAll value -> widget.NoShowAll <- value
    | HSeparatorProperty.HasTooltip value -> widget.HasTooltip <- value
    | HSeparatorProperty.TooltipText value -> widget.TooltipText <- value
    | HSeparatorProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HSeparatorProperty.Window value -> widget.Window <- value
    | HSeparatorProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HSeparatorProperty.Halign value -> widget.Halign <- value
    | HSeparatorProperty.Valign value -> widget.Valign <- value
    | HSeparatorProperty.MarginLeft value -> widget.MarginLeft <- value
    | HSeparatorProperty.MarginRight value -> widget.MarginRight <- value
    | HSeparatorProperty.MarginStart value -> widget.MarginStart <- value
    | HSeparatorProperty.MarginEnd value -> widget.MarginEnd <- value
    | HSeparatorProperty.MarginTop value -> widget.MarginTop <- value
    | HSeparatorProperty.MarginBottom value -> widget.MarginBottom <- value
    | HSeparatorProperty.Margin value -> widget.Margin <- value
    | HSeparatorProperty.Hexpand value -> widget.Hexpand <- value
    | HSeparatorProperty.HexpandSet value -> widget.HexpandSet <- value
    | HSeparatorProperty.Vexpand value -> widget.Vexpand <- value
    | HSeparatorProperty.VexpandSet value -> widget.VexpandSet <- value
    | HSeparatorProperty.Expand value -> widget.Expand <- value
    | HSeparatorProperty.Opacity value -> widget.Opacity <- value
    | HSeparatorProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HSeparatorProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HSeparatorProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HSeparatorProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HSeparatorProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HSeparatorProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HSeparatorProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HSeparatorProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HSeparatorProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HSeparatorProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HSeparatorProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HSeparatorProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HSeparatorProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HSeparatorProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HSeparatorProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HSeparatorProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HSeparatorProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HSeparatorProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HSeparatorProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HSeparatorProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HSeparatorProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HSeparatorProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HSeparatorProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HSeparatorProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HSeparatorProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HSeparatorProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HSeparatorProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HSeparatorProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HSeparatorProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HSeparatorProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HSeparatorProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HSeparatorProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HSeparatorProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HSeparatorProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HSeparatorProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HSeparatorProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HSeparatorProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HSeparatorProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HSeparatorProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HSeparatorProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HSeparatorProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HSeparatorProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HSeparatorProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HSeparatorProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HSeparatorProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HSeparatorProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HSeparatorProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HSeparatorProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HSeparatorProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HSeparatorProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HSeparatorProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HSeparatorProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HSeparatorProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HSeparatorProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HSeparatorProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HSeparatorProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HSeparatorProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HSeparatorPropertyBuilder() =
    inherit BasePropertyBuilder<HSeparatorProperty>()
    [<CustomOperation("orientation")>]
    member this.Orientation(it: HSeparatorProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield HSeparatorProperty.Orientation value } 
    [<CustomOperation("name")>]
    member this.Name(it: HSeparatorProperty seq, value: System.String) =
        seq { yield! it; yield HSeparatorProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HSeparatorProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HSeparatorProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HSeparatorProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HSeparatorProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HSeparatorProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HSeparatorProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HSeparatorProperty seq, value: System.String) =
        seq { yield! it; yield HSeparatorProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HSeparatorProperty seq, value: System.String) =
        seq { yield! it; yield HSeparatorProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HSeparatorProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HSeparatorProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HSeparatorProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HSeparatorProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HSeparatorProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HSeparatorProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HSeparatorProperty seq, value: System.Int32) =
        seq { yield! it; yield HSeparatorProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HSeparatorProperty seq, value: System.Boolean) =
        seq { yield! it; yield HSeparatorProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HSeparatorProperty seq, value: System.Double) =
        seq { yield! it; yield HSeparatorProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HSeparatorProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HSeparatorProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HSeparatorProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HSeparatorProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HSeparatorProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HSeparatorProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HSeparatorProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HSeparatorProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HSeparatorProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HSeparatorProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HSeparatorProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HSeparatorProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HSeparatorProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HSeparatorProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HSeparatorProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HSeparatorProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HSeparatorProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HSeparatorProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HSeparatorProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HSeparatorProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HSeparatorProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HSeparatorProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HSeparatorProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HSeparatorProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HSeparatorProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HSeparatorProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HSeparatorProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HSeparatorProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HSeparatorProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HSeparatorProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HSeparatorProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HSeparatorProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HSeparatorProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HSeparatorProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HSeparatorProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HSeparatorProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HSeparatorProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HSeparatorProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HSeparatorProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HSeparatorProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HSeparatorProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HSeparatorProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HSeparatorProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HSeparatorProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HSeparatorProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HSeparatorProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HSeparatorProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HSeparatorProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HSeparatorProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HSeparatorProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HSeparatorProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HSeparatorProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HSeparatorProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HSeparatorProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HSeparatorProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HSeparatorProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HSeparatorProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HSeparatorProperty.OnFocused value } 

let prop = HSeparatorPropertyBuilder()

type HSeparatorDescriptor(props) =
    inherit BaseWidgetDescriptor<HSeparator, HSeparatorProperty>(props, bindProperty)
    override this.CreateTyped() = new HSeparator()

let hSeparator props = HSeparatorDescriptor(props)

