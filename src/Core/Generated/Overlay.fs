module GtkDsl.Binding.Overlay
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type OverlayProperty =
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
    |  OnGetChildPosition of (Gtk.GetChildPositionArgs -> unit)
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

let bindProperty (widget: Overlay) (prop: OverlayProperty) =
    match prop with
    | OverlayProperty.ResizeMode value -> widget.ResizeMode <- value
    | OverlayProperty.BorderWidth value -> widget.BorderWidth <- value
    | OverlayProperty.Name value -> widget.Name <- value
    | OverlayProperty.Parent value -> widget.Parent <- value
    | OverlayProperty.WidthRequest value -> widget.WidthRequest <- value
    | OverlayProperty.HeightRequest value -> widget.HeightRequest <- value
    | OverlayProperty.Visible value -> widget.Visible <- value
    | OverlayProperty.Sensitive value -> widget.Sensitive <- value
    | OverlayProperty.AppPaintable value -> widget.AppPaintable <- value
    | OverlayProperty.CanFocus value -> widget.CanFocus <- value
    | OverlayProperty.HasFocus value -> widget.HasFocus <- value
    | OverlayProperty.IsFocus value -> widget.IsFocus <- value
    | OverlayProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | OverlayProperty.CanDefault value -> widget.CanDefault <- value
    | OverlayProperty.HasDefault value -> widget.HasDefault <- value
    | OverlayProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | OverlayProperty.Style value -> widget.Style <- value
    | OverlayProperty.Events value -> widget.Events <- value
    | OverlayProperty.NoShowAll value -> widget.NoShowAll <- value
    | OverlayProperty.HasTooltip value -> widget.HasTooltip <- value
    | OverlayProperty.TooltipText value -> widget.TooltipText <- value
    | OverlayProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | OverlayProperty.Window value -> widget.Window <- value
    | OverlayProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | OverlayProperty.Halign value -> widget.Halign <- value
    | OverlayProperty.Valign value -> widget.Valign <- value
    | OverlayProperty.MarginLeft value -> widget.MarginLeft <- value
    | OverlayProperty.MarginRight value -> widget.MarginRight <- value
    | OverlayProperty.MarginStart value -> widget.MarginStart <- value
    | OverlayProperty.MarginEnd value -> widget.MarginEnd <- value
    | OverlayProperty.MarginTop value -> widget.MarginTop <- value
    | OverlayProperty.MarginBottom value -> widget.MarginBottom <- value
    | OverlayProperty.Margin value -> widget.Margin <- value
    | OverlayProperty.Hexpand value -> widget.Hexpand <- value
    | OverlayProperty.HexpandSet value -> widget.HexpandSet <- value
    | OverlayProperty.Vexpand value -> widget.Vexpand <- value
    | OverlayProperty.VexpandSet value -> widget.VexpandSet <- value
    | OverlayProperty.Expand value -> widget.Expand <- value
    | OverlayProperty.Opacity value -> widget.Opacity <- value
    | OverlayProperty.OnGetChildPosition handler -> 
        let disposable = widget.GetChildPosition.Subscribe(handler)
        registerListener widget "GetChildPosition" disposable
    | OverlayProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | OverlayProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | OverlayProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | OverlayProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | OverlayProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | OverlayProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | OverlayProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | OverlayProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | OverlayProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | OverlayProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | OverlayProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | OverlayProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | OverlayProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | OverlayProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | OverlayProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | OverlayProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | OverlayProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | OverlayProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | OverlayProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | OverlayProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | OverlayProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | OverlayProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | OverlayProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | OverlayProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | OverlayProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | OverlayProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | OverlayProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | OverlayProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | OverlayProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | OverlayProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | OverlayProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | OverlayProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | OverlayProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | OverlayProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | OverlayProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | OverlayProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | OverlayProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | OverlayProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | OverlayProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | OverlayProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | OverlayProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | OverlayProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | OverlayProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | OverlayProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | OverlayProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | OverlayProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | OverlayProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | OverlayProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | OverlayProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | OverlayProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | OverlayProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | OverlayProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | OverlayProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | OverlayProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | OverlayProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | OverlayProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | OverlayProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | OverlayProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | OverlayProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | OverlayProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type OverlayPropertyBuilder() =
    inherit BasePropertyBuilder<OverlayProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: OverlayProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield OverlayProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: OverlayProperty seq, value: System.UInt32) =
        seq { yield! it; yield OverlayProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: OverlayProperty seq, value: System.String) =
        seq { yield! it; yield OverlayProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: OverlayProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield OverlayProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: OverlayProperty seq, value: Gtk.Style) =
        seq { yield! it; yield OverlayProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: OverlayProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield OverlayProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: OverlayProperty seq, value: System.String) =
        seq { yield! it; yield OverlayProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: OverlayProperty seq, value: System.String) =
        seq { yield! it; yield OverlayProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: OverlayProperty seq, value: Gdk.Window) =
        seq { yield! it; yield OverlayProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: OverlayProperty seq, value: Gtk.Align) =
        seq { yield! it; yield OverlayProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: OverlayProperty seq, value: Gtk.Align) =
        seq { yield! it; yield OverlayProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: OverlayProperty seq, value: System.Int32) =
        seq { yield! it; yield OverlayProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: OverlayProperty seq, value: System.Boolean) =
        seq { yield! it; yield OverlayProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: OverlayProperty seq, value: System.Double) =
        seq { yield! it; yield OverlayProperty.Opacity value } 
    [<CustomOperation("onGetChildPosition")>]
    member this.OnGetChildPosition(it: OverlayProperty seq, value: Gtk.GetChildPositionArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnGetChildPosition value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: OverlayProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: OverlayProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: OverlayProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: OverlayProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: OverlayProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: OverlayProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: OverlayProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: OverlayProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: OverlayProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: OverlayProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: OverlayProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: OverlayProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: OverlayProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: OverlayProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: OverlayProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: OverlayProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: OverlayProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: OverlayProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: OverlayProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: OverlayProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: OverlayProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: OverlayProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: OverlayProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: OverlayProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: OverlayProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: OverlayProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: OverlayProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: OverlayProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: OverlayProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: OverlayProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: OverlayProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: OverlayProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: OverlayProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: OverlayProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: OverlayProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: OverlayProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: OverlayProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: OverlayProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: OverlayProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: OverlayProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: OverlayProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: OverlayProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: OverlayProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: OverlayProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: OverlayProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: OverlayProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: OverlayProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: OverlayProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: OverlayProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: OverlayProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: OverlayProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: OverlayProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: OverlayProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: OverlayProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: OverlayProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: OverlayProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: OverlayProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: OverlayProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: OverlayProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: OverlayProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield OverlayProperty.OnFocused value } 

let prop = OverlayPropertyBuilder()

type OverlayDescriptor(props) =
    inherit BaseWidgetDescriptor<Overlay, OverlayProperty>(props, bindProperty)
    override this.CreateTyped() = new Overlay()

let overlay props = OverlayDescriptor(props)

