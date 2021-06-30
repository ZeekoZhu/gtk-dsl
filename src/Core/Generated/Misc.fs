module GtkDsl.Binding.Misc
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MiscProperty =
    | Xalign of System.Single
    | Yalign of System.Single
    | Xpad of System.Int32
    | Ypad of System.Int32
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

let bindProperty (widget: Misc) (prop: MiscProperty) =
    match prop with
    | MiscProperty.Xalign value -> widget.Xalign <- value
    | MiscProperty.Yalign value -> widget.Yalign <- value
    | MiscProperty.Xpad value -> widget.Xpad <- value
    | MiscProperty.Ypad value -> widget.Ypad <- value
    | MiscProperty.Name value -> widget.Name <- value
    | MiscProperty.Parent value -> widget.Parent <- value
    | MiscProperty.WidthRequest value -> widget.WidthRequest <- value
    | MiscProperty.HeightRequest value -> widget.HeightRequest <- value
    | MiscProperty.Visible value -> widget.Visible <- value
    | MiscProperty.Sensitive value -> widget.Sensitive <- value
    | MiscProperty.AppPaintable value -> widget.AppPaintable <- value
    | MiscProperty.CanFocus value -> widget.CanFocus <- value
    | MiscProperty.HasFocus value -> widget.HasFocus <- value
    | MiscProperty.IsFocus value -> widget.IsFocus <- value
    | MiscProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MiscProperty.CanDefault value -> widget.CanDefault <- value
    | MiscProperty.HasDefault value -> widget.HasDefault <- value
    | MiscProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MiscProperty.Style value -> widget.Style <- value
    | MiscProperty.Events value -> widget.Events <- value
    | MiscProperty.NoShowAll value -> widget.NoShowAll <- value
    | MiscProperty.HasTooltip value -> widget.HasTooltip <- value
    | MiscProperty.TooltipText value -> widget.TooltipText <- value
    | MiscProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MiscProperty.Window value -> widget.Window <- value
    | MiscProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MiscProperty.Halign value -> widget.Halign <- value
    | MiscProperty.Valign value -> widget.Valign <- value
    | MiscProperty.MarginLeft value -> widget.MarginLeft <- value
    | MiscProperty.MarginRight value -> widget.MarginRight <- value
    | MiscProperty.MarginStart value -> widget.MarginStart <- value
    | MiscProperty.MarginEnd value -> widget.MarginEnd <- value
    | MiscProperty.MarginTop value -> widget.MarginTop <- value
    | MiscProperty.MarginBottom value -> widget.MarginBottom <- value
    | MiscProperty.Margin value -> widget.Margin <- value
    | MiscProperty.Hexpand value -> widget.Hexpand <- value
    | MiscProperty.HexpandSet value -> widget.HexpandSet <- value
    | MiscProperty.Vexpand value -> widget.Vexpand <- value
    | MiscProperty.VexpandSet value -> widget.VexpandSet <- value
    | MiscProperty.Expand value -> widget.Expand <- value
    | MiscProperty.Opacity value -> widget.Opacity <- value
    | MiscProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MiscProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MiscProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MiscProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MiscProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MiscProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MiscProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MiscProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MiscProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MiscProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MiscProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MiscProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MiscProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MiscProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MiscProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MiscProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MiscProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MiscProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MiscProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MiscProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MiscProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MiscProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MiscProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MiscProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MiscProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MiscProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MiscProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MiscProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MiscProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MiscProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MiscProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MiscProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MiscProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MiscProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MiscProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MiscProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MiscProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MiscProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MiscProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MiscProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MiscProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MiscProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MiscProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MiscProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MiscProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MiscProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MiscProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MiscProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MiscProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MiscProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MiscProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MiscProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MiscProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MiscProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MiscProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MiscProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MiscProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MiscPropertyBuilder() =
    inherit BasePropertyBuilder<MiscProperty>()
    [<CustomOperation("xalign")>]
    member this.Xalign(it: MiscProperty seq, value: System.Single) =
        seq { yield! it; yield MiscProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: MiscProperty seq, value: System.Single) =
        seq { yield! it; yield MiscProperty.Yalign value } 
    [<CustomOperation("xpad")>]
    member this.Xpad(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.Xpad value } 
    [<CustomOperation("ypad")>]
    member this.Ypad(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.Ypad value } 
    [<CustomOperation("name")>]
    member this.Name(it: MiscProperty seq, value: System.String) =
        seq { yield! it; yield MiscProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MiscProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MiscProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MiscProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MiscProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MiscProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MiscProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MiscProperty seq, value: System.String) =
        seq { yield! it; yield MiscProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MiscProperty seq, value: System.String) =
        seq { yield! it; yield MiscProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MiscProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MiscProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MiscProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MiscProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MiscProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MiscProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MiscProperty seq, value: System.Int32) =
        seq { yield! it; yield MiscProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MiscProperty seq, value: System.Boolean) =
        seq { yield! it; yield MiscProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MiscProperty seq, value: System.Double) =
        seq { yield! it; yield MiscProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MiscProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MiscProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MiscProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MiscProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MiscProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MiscProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MiscProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MiscProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MiscProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MiscProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MiscProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MiscProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MiscProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MiscProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MiscProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MiscProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MiscProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MiscProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MiscProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MiscProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MiscProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MiscProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MiscProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MiscProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MiscProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MiscProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MiscProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MiscProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MiscProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MiscProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MiscProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MiscProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MiscProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MiscProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MiscProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MiscProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MiscProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MiscProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MiscProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MiscProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MiscProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MiscProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MiscProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MiscProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MiscProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MiscProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MiscProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MiscProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MiscProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MiscProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MiscProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MiscProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MiscProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MiscProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MiscProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MiscProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MiscProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MiscProperty.OnFocused value } 

let prop = MiscPropertyBuilder()

