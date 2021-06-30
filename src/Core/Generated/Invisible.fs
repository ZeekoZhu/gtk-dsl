module GtkDsl.Binding.Invisible
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type InvisibleProperty =
    | Screen of Gdk.Screen
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

let bindProperty (widget: Invisible) (prop: InvisibleProperty) =
    match prop with
    | InvisibleProperty.Screen value -> widget.Screen <- value
    | InvisibleProperty.Name value -> widget.Name <- value
    | InvisibleProperty.Parent value -> widget.Parent <- value
    | InvisibleProperty.WidthRequest value -> widget.WidthRequest <- value
    | InvisibleProperty.HeightRequest value -> widget.HeightRequest <- value
    | InvisibleProperty.Visible value -> widget.Visible <- value
    | InvisibleProperty.Sensitive value -> widget.Sensitive <- value
    | InvisibleProperty.AppPaintable value -> widget.AppPaintable <- value
    | InvisibleProperty.CanFocus value -> widget.CanFocus <- value
    | InvisibleProperty.HasFocus value -> widget.HasFocus <- value
    | InvisibleProperty.IsFocus value -> widget.IsFocus <- value
    | InvisibleProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | InvisibleProperty.CanDefault value -> widget.CanDefault <- value
    | InvisibleProperty.HasDefault value -> widget.HasDefault <- value
    | InvisibleProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | InvisibleProperty.Style value -> widget.Style <- value
    | InvisibleProperty.Events value -> widget.Events <- value
    | InvisibleProperty.NoShowAll value -> widget.NoShowAll <- value
    | InvisibleProperty.HasTooltip value -> widget.HasTooltip <- value
    | InvisibleProperty.TooltipText value -> widget.TooltipText <- value
    | InvisibleProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | InvisibleProperty.Window value -> widget.Window <- value
    | InvisibleProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | InvisibleProperty.Halign value -> widget.Halign <- value
    | InvisibleProperty.Valign value -> widget.Valign <- value
    | InvisibleProperty.MarginLeft value -> widget.MarginLeft <- value
    | InvisibleProperty.MarginRight value -> widget.MarginRight <- value
    | InvisibleProperty.MarginStart value -> widget.MarginStart <- value
    | InvisibleProperty.MarginEnd value -> widget.MarginEnd <- value
    | InvisibleProperty.MarginTop value -> widget.MarginTop <- value
    | InvisibleProperty.MarginBottom value -> widget.MarginBottom <- value
    | InvisibleProperty.Margin value -> widget.Margin <- value
    | InvisibleProperty.Hexpand value -> widget.Hexpand <- value
    | InvisibleProperty.HexpandSet value -> widget.HexpandSet <- value
    | InvisibleProperty.Vexpand value -> widget.Vexpand <- value
    | InvisibleProperty.VexpandSet value -> widget.VexpandSet <- value
    | InvisibleProperty.Expand value -> widget.Expand <- value
    | InvisibleProperty.Opacity value -> widget.Opacity <- value
    | InvisibleProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | InvisibleProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | InvisibleProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | InvisibleProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | InvisibleProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | InvisibleProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | InvisibleProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | InvisibleProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | InvisibleProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | InvisibleProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | InvisibleProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | InvisibleProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | InvisibleProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | InvisibleProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | InvisibleProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | InvisibleProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | InvisibleProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | InvisibleProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | InvisibleProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | InvisibleProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | InvisibleProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | InvisibleProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | InvisibleProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | InvisibleProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | InvisibleProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | InvisibleProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | InvisibleProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | InvisibleProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | InvisibleProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | InvisibleProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | InvisibleProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | InvisibleProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | InvisibleProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | InvisibleProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | InvisibleProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | InvisibleProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | InvisibleProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | InvisibleProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | InvisibleProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | InvisibleProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | InvisibleProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | InvisibleProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | InvisibleProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | InvisibleProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | InvisibleProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | InvisibleProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | InvisibleProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | InvisibleProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | InvisibleProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | InvisibleProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | InvisibleProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | InvisibleProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | InvisibleProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | InvisibleProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | InvisibleProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | InvisibleProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | InvisibleProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type InvisiblePropertyBuilder() =
    inherit BasePropertyBuilder<InvisibleProperty>()
    [<CustomOperation("screen")>]
    member this.Screen(it: InvisibleProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield InvisibleProperty.Screen value } 
    [<CustomOperation("name")>]
    member this.Name(it: InvisibleProperty seq, value: System.String) =
        seq { yield! it; yield InvisibleProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: InvisibleProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield InvisibleProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: InvisibleProperty seq, value: Gtk.Style) =
        seq { yield! it; yield InvisibleProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: InvisibleProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield InvisibleProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: InvisibleProperty seq, value: System.String) =
        seq { yield! it; yield InvisibleProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: InvisibleProperty seq, value: System.String) =
        seq { yield! it; yield InvisibleProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: InvisibleProperty seq, value: Gdk.Window) =
        seq { yield! it; yield InvisibleProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: InvisibleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield InvisibleProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: InvisibleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield InvisibleProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: InvisibleProperty seq, value: System.Int32) =
        seq { yield! it; yield InvisibleProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: InvisibleProperty seq, value: System.Boolean) =
        seq { yield! it; yield InvisibleProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: InvisibleProperty seq, value: System.Double) =
        seq { yield! it; yield InvisibleProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: InvisibleProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: InvisibleProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: InvisibleProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: InvisibleProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: InvisibleProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: InvisibleProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: InvisibleProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: InvisibleProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: InvisibleProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: InvisibleProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: InvisibleProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: InvisibleProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: InvisibleProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: InvisibleProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: InvisibleProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: InvisibleProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: InvisibleProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: InvisibleProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: InvisibleProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: InvisibleProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: InvisibleProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: InvisibleProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: InvisibleProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: InvisibleProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: InvisibleProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: InvisibleProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: InvisibleProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: InvisibleProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: InvisibleProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: InvisibleProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: InvisibleProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: InvisibleProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: InvisibleProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: InvisibleProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: InvisibleProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: InvisibleProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: InvisibleProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: InvisibleProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: InvisibleProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: InvisibleProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: InvisibleProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: InvisibleProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: InvisibleProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: InvisibleProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: InvisibleProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: InvisibleProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: InvisibleProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: InvisibleProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: InvisibleProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: InvisibleProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: InvisibleProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: InvisibleProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: InvisibleProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: InvisibleProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: InvisibleProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: InvisibleProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: InvisibleProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield InvisibleProperty.OnFocused value } 

let prop = InvisiblePropertyBuilder()

type InvisibleDescriptor(props) =
    inherit BaseWidgetDescriptor<Invisible, InvisibleProperty>(props, bindProperty)
    override this.CreateTyped() = new Invisible()

let invisible props = InvisibleDescriptor(props)

