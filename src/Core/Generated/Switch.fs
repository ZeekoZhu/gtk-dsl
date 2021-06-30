module GtkDsl.Binding.Switch
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SwitchProperty =
    | Active of System.Boolean
    | State of System.Boolean
    | [<Obsolete>] RelatedAction of Gtk.Action
    | [<Obsolete>] UseActionAppearance of System.Boolean
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
    |  OnStateSet of (Gtk.StateSetArgs -> unit)
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

let bindProperty (widget: Switch) (prop: SwitchProperty) =
    match prop with
    | SwitchProperty.Active value -> widget.Active <- value
    | SwitchProperty.State value -> widget.State <- value
    | SwitchProperty.RelatedAction value -> widget.RelatedAction <- value
    | SwitchProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | SwitchProperty.Name value -> widget.Name <- value
    | SwitchProperty.Parent value -> widget.Parent <- value
    | SwitchProperty.WidthRequest value -> widget.WidthRequest <- value
    | SwitchProperty.HeightRequest value -> widget.HeightRequest <- value
    | SwitchProperty.Visible value -> widget.Visible <- value
    | SwitchProperty.Sensitive value -> widget.Sensitive <- value
    | SwitchProperty.AppPaintable value -> widget.AppPaintable <- value
    | SwitchProperty.CanFocus value -> widget.CanFocus <- value
    | SwitchProperty.HasFocus value -> widget.HasFocus <- value
    | SwitchProperty.IsFocus value -> widget.IsFocus <- value
    | SwitchProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SwitchProperty.CanDefault value -> widget.CanDefault <- value
    | SwitchProperty.HasDefault value -> widget.HasDefault <- value
    | SwitchProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SwitchProperty.Style value -> widget.Style <- value
    | SwitchProperty.Events value -> widget.Events <- value
    | SwitchProperty.NoShowAll value -> widget.NoShowAll <- value
    | SwitchProperty.HasTooltip value -> widget.HasTooltip <- value
    | SwitchProperty.TooltipText value -> widget.TooltipText <- value
    | SwitchProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SwitchProperty.Window value -> widget.Window <- value
    | SwitchProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SwitchProperty.Halign value -> widget.Halign <- value
    | SwitchProperty.Valign value -> widget.Valign <- value
    | SwitchProperty.MarginLeft value -> widget.MarginLeft <- value
    | SwitchProperty.MarginRight value -> widget.MarginRight <- value
    | SwitchProperty.MarginStart value -> widget.MarginStart <- value
    | SwitchProperty.MarginEnd value -> widget.MarginEnd <- value
    | SwitchProperty.MarginTop value -> widget.MarginTop <- value
    | SwitchProperty.MarginBottom value -> widget.MarginBottom <- value
    | SwitchProperty.Margin value -> widget.Margin <- value
    | SwitchProperty.Hexpand value -> widget.Hexpand <- value
    | SwitchProperty.HexpandSet value -> widget.HexpandSet <- value
    | SwitchProperty.Vexpand value -> widget.Vexpand <- value
    | SwitchProperty.VexpandSet value -> widget.VexpandSet <- value
    | SwitchProperty.Expand value -> widget.Expand <- value
    | SwitchProperty.Opacity value -> widget.Opacity <- value
    | SwitchProperty.OnStateSet handler -> 
        let disposable = widget.StateSet.Subscribe(handler)
        registerListener widget "StateSet" disposable
    | SwitchProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SwitchProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SwitchProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SwitchProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SwitchProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SwitchProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SwitchProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SwitchProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SwitchProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SwitchProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SwitchProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SwitchProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SwitchProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SwitchProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SwitchProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SwitchProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SwitchProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SwitchProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SwitchProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SwitchProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SwitchProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SwitchProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SwitchProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SwitchProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SwitchProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SwitchProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SwitchProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SwitchProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SwitchProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SwitchProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SwitchProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SwitchProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SwitchProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SwitchProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SwitchProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SwitchProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SwitchProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SwitchProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SwitchProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SwitchProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SwitchProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SwitchProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SwitchProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SwitchProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SwitchProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SwitchProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SwitchProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SwitchProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SwitchProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SwitchProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SwitchProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SwitchProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SwitchProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SwitchProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SwitchProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SwitchProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SwitchProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SwitchPropertyBuilder() =
    inherit BasePropertyBuilder<SwitchProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.Active value } 
    [<CustomOperation("state")>]
    member this.State(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.State value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: SwitchProperty seq, value: Gtk.Action) =
        seq { yield! it; yield SwitchProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.UseActionAppearance value } 
    [<CustomOperation("name")>]
    member this.Name(it: SwitchProperty seq, value: System.String) =
        seq { yield! it; yield SwitchProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SwitchProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SwitchProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SwitchProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SwitchProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SwitchProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SwitchProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SwitchProperty seq, value: System.String) =
        seq { yield! it; yield SwitchProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SwitchProperty seq, value: System.String) =
        seq { yield! it; yield SwitchProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SwitchProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SwitchProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SwitchProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SwitchProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SwitchProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SwitchProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SwitchProperty seq, value: System.Int32) =
        seq { yield! it; yield SwitchProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SwitchProperty seq, value: System.Boolean) =
        seq { yield! it; yield SwitchProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SwitchProperty seq, value: System.Double) =
        seq { yield! it; yield SwitchProperty.Opacity value } 
    [<CustomOperation("onStateSet")>]
    member this.OnStateSet(it: SwitchProperty seq, value: Gtk.StateSetArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnStateSet value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SwitchProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SwitchProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SwitchProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SwitchProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SwitchProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SwitchProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SwitchProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SwitchProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SwitchProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SwitchProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SwitchProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SwitchProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SwitchProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SwitchProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SwitchProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SwitchProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SwitchProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SwitchProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SwitchProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SwitchProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SwitchProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SwitchProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SwitchProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SwitchProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SwitchProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SwitchProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SwitchProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SwitchProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SwitchProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SwitchProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SwitchProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SwitchProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SwitchProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SwitchProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SwitchProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SwitchProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SwitchProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SwitchProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SwitchProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SwitchProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SwitchProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SwitchProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SwitchProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SwitchProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SwitchProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SwitchProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SwitchProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SwitchProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SwitchProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SwitchProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SwitchProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SwitchProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SwitchProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SwitchProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SwitchProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SwitchProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SwitchProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SwitchProperty.OnFocused value } 

let prop = SwitchPropertyBuilder()

type SwitchDescriptor(props) =
    inherit BaseWidgetDescriptor<Switch, SwitchProperty>(props, bindProperty)
    override this.CreateTyped() = new Switch()

let switch props = SwitchDescriptor(props)

