module GtkDsl.Binding.StackSidebar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type StackSidebarProperty =
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

let bindProperty (widget: StackSidebar) (prop: StackSidebarProperty) =
    match prop with
    | StackSidebarProperty.ResizeMode value -> widget.ResizeMode <- value
    | StackSidebarProperty.BorderWidth value -> widget.BorderWidth <- value
    | StackSidebarProperty.Name value -> widget.Name <- value
    | StackSidebarProperty.Parent value -> widget.Parent <- value
    | StackSidebarProperty.WidthRequest value -> widget.WidthRequest <- value
    | StackSidebarProperty.HeightRequest value -> widget.HeightRequest <- value
    | StackSidebarProperty.Visible value -> widget.Visible <- value
    | StackSidebarProperty.Sensitive value -> widget.Sensitive <- value
    | StackSidebarProperty.AppPaintable value -> widget.AppPaintable <- value
    | StackSidebarProperty.CanFocus value -> widget.CanFocus <- value
    | StackSidebarProperty.HasFocus value -> widget.HasFocus <- value
    | StackSidebarProperty.IsFocus value -> widget.IsFocus <- value
    | StackSidebarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | StackSidebarProperty.CanDefault value -> widget.CanDefault <- value
    | StackSidebarProperty.HasDefault value -> widget.HasDefault <- value
    | StackSidebarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | StackSidebarProperty.Style value -> widget.Style <- value
    | StackSidebarProperty.Events value -> widget.Events <- value
    | StackSidebarProperty.NoShowAll value -> widget.NoShowAll <- value
    | StackSidebarProperty.HasTooltip value -> widget.HasTooltip <- value
    | StackSidebarProperty.TooltipText value -> widget.TooltipText <- value
    | StackSidebarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | StackSidebarProperty.Window value -> widget.Window <- value
    | StackSidebarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | StackSidebarProperty.Halign value -> widget.Halign <- value
    | StackSidebarProperty.Valign value -> widget.Valign <- value
    | StackSidebarProperty.MarginLeft value -> widget.MarginLeft <- value
    | StackSidebarProperty.MarginRight value -> widget.MarginRight <- value
    | StackSidebarProperty.MarginStart value -> widget.MarginStart <- value
    | StackSidebarProperty.MarginEnd value -> widget.MarginEnd <- value
    | StackSidebarProperty.MarginTop value -> widget.MarginTop <- value
    | StackSidebarProperty.MarginBottom value -> widget.MarginBottom <- value
    | StackSidebarProperty.Margin value -> widget.Margin <- value
    | StackSidebarProperty.Hexpand value -> widget.Hexpand <- value
    | StackSidebarProperty.HexpandSet value -> widget.HexpandSet <- value
    | StackSidebarProperty.Vexpand value -> widget.Vexpand <- value
    | StackSidebarProperty.VexpandSet value -> widget.VexpandSet <- value
    | StackSidebarProperty.Expand value -> widget.Expand <- value
    | StackSidebarProperty.Opacity value -> widget.Opacity <- value
    | StackSidebarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | StackSidebarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | StackSidebarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | StackSidebarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | StackSidebarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | StackSidebarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | StackSidebarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | StackSidebarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | StackSidebarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | StackSidebarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | StackSidebarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | StackSidebarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | StackSidebarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | StackSidebarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | StackSidebarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | StackSidebarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | StackSidebarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | StackSidebarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | StackSidebarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | StackSidebarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | StackSidebarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | StackSidebarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | StackSidebarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | StackSidebarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | StackSidebarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | StackSidebarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | StackSidebarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | StackSidebarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | StackSidebarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | StackSidebarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | StackSidebarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | StackSidebarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | StackSidebarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | StackSidebarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | StackSidebarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | StackSidebarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | StackSidebarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | StackSidebarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | StackSidebarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | StackSidebarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | StackSidebarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | StackSidebarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | StackSidebarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | StackSidebarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | StackSidebarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | StackSidebarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | StackSidebarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | StackSidebarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | StackSidebarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | StackSidebarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | StackSidebarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | StackSidebarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | StackSidebarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | StackSidebarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | StackSidebarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | StackSidebarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | StackSidebarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | StackSidebarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | StackSidebarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | StackSidebarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type StackSidebarPropertyBuilder() =
    inherit BasePropertyBuilder<StackSidebarProperty>()
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: StackSidebarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield StackSidebarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: StackSidebarProperty seq, value: System.UInt32) =
        seq { yield! it; yield StackSidebarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: StackSidebarProperty seq, value: System.String) =
        seq { yield! it; yield StackSidebarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: StackSidebarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield StackSidebarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: StackSidebarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield StackSidebarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: StackSidebarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield StackSidebarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: StackSidebarProperty seq, value: System.String) =
        seq { yield! it; yield StackSidebarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: StackSidebarProperty seq, value: System.String) =
        seq { yield! it; yield StackSidebarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: StackSidebarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield StackSidebarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: StackSidebarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StackSidebarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: StackSidebarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StackSidebarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: StackSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSidebarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: StackSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSidebarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: StackSidebarProperty seq, value: System.Double) =
        seq { yield! it; yield StackSidebarProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: StackSidebarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: StackSidebarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: StackSidebarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: StackSidebarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: StackSidebarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: StackSidebarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: StackSidebarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: StackSidebarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: StackSidebarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: StackSidebarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: StackSidebarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: StackSidebarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: StackSidebarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: StackSidebarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: StackSidebarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: StackSidebarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: StackSidebarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: StackSidebarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: StackSidebarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: StackSidebarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: StackSidebarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: StackSidebarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: StackSidebarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: StackSidebarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: StackSidebarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: StackSidebarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: StackSidebarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: StackSidebarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: StackSidebarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: StackSidebarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: StackSidebarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: StackSidebarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: StackSidebarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: StackSidebarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: StackSidebarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: StackSidebarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: StackSidebarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: StackSidebarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: StackSidebarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: StackSidebarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: StackSidebarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: StackSidebarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: StackSidebarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: StackSidebarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: StackSidebarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: StackSidebarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: StackSidebarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: StackSidebarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: StackSidebarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: StackSidebarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: StackSidebarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: StackSidebarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: StackSidebarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: StackSidebarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: StackSidebarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: StackSidebarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: StackSidebarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: StackSidebarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: StackSidebarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: StackSidebarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield StackSidebarProperty.OnFocused value } 

let prop = StackSidebarPropertyBuilder()

type StackSidebarDescriptor(props) =
    inherit BaseWidgetDescriptor<StackSidebar, StackSidebarProperty>(props, bindProperty)
    override this.CreateTyped() = new StackSidebar()

let stackSidebar props = StackSidebarDescriptor(props)

