module GtkDsl.Binding.Toolbar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToolbarProperty =
    | ToolbarStyle of Gtk.ToolbarStyle
    | ShowArrow of System.Boolean
    | IconSize of Gtk.IconSize
    | IconSizeSet of System.Boolean
    | Orientation of Gtk.Orientation
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
    |  OnStyleChanged of (Gtk.StyleChangedArgs -> unit)
    |  OnOrientationChanged of (Gtk.OrientationChangedArgs -> unit)
    |  OnPopupContextMenu of (Gtk.PopupContextMenuArgs -> unit)
    |  OnFocusHomeOrEnd of (Gtk.FocusHomeOrEndArgs -> unit)
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

let bindProperty (widget: Toolbar) (prop: ToolbarProperty) =
    match prop with
    | ToolbarProperty.ToolbarStyle value -> widget.ToolbarStyle <- value
    | ToolbarProperty.ShowArrow value -> widget.ShowArrow <- value
    | ToolbarProperty.IconSize value -> widget.IconSize <- value
    | ToolbarProperty.IconSizeSet value -> widget.IconSizeSet <- value
    | ToolbarProperty.Orientation value -> widget.Orientation <- value
    | ToolbarProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToolbarProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToolbarProperty.Name value -> widget.Name <- value
    | ToolbarProperty.Parent value -> widget.Parent <- value
    | ToolbarProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToolbarProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToolbarProperty.Visible value -> widget.Visible <- value
    | ToolbarProperty.Sensitive value -> widget.Sensitive <- value
    | ToolbarProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToolbarProperty.CanFocus value -> widget.CanFocus <- value
    | ToolbarProperty.HasFocus value -> widget.HasFocus <- value
    | ToolbarProperty.IsFocus value -> widget.IsFocus <- value
    | ToolbarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToolbarProperty.CanDefault value -> widget.CanDefault <- value
    | ToolbarProperty.HasDefault value -> widget.HasDefault <- value
    | ToolbarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToolbarProperty.Events value -> widget.Events <- value
    | ToolbarProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToolbarProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToolbarProperty.TooltipText value -> widget.TooltipText <- value
    | ToolbarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToolbarProperty.Window value -> widget.Window <- value
    | ToolbarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToolbarProperty.Halign value -> widget.Halign <- value
    | ToolbarProperty.Valign value -> widget.Valign <- value
    | ToolbarProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToolbarProperty.MarginRight value -> widget.MarginRight <- value
    | ToolbarProperty.MarginStart value -> widget.MarginStart <- value
    | ToolbarProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToolbarProperty.MarginTop value -> widget.MarginTop <- value
    | ToolbarProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToolbarProperty.Margin value -> widget.Margin <- value
    | ToolbarProperty.Hexpand value -> widget.Hexpand <- value
    | ToolbarProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToolbarProperty.Vexpand value -> widget.Vexpand <- value
    | ToolbarProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToolbarProperty.Expand value -> widget.Expand <- value
    | ToolbarProperty.Opacity value -> widget.Opacity <- value
    | ToolbarProperty.OnStyleChanged handler -> 
        let disposable = widget.StyleChanged.Subscribe(handler)
        registerListener widget "StyleChanged" disposable
    | ToolbarProperty.OnOrientationChanged handler -> 
        let disposable = widget.OrientationChanged.Subscribe(handler)
        registerListener widget "OrientationChanged" disposable
    | ToolbarProperty.OnPopupContextMenu handler -> 
        let disposable = widget.PopupContextMenu.Subscribe(handler)
        registerListener widget "PopupContextMenu" disposable
    | ToolbarProperty.OnFocusHomeOrEnd handler -> 
        let disposable = widget.FocusHomeOrEnd.Subscribe(handler)
        registerListener widget "FocusHomeOrEnd" disposable
    | ToolbarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToolbarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToolbarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToolbarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToolbarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToolbarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToolbarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToolbarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToolbarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToolbarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToolbarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToolbarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToolbarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToolbarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToolbarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToolbarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToolbarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToolbarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToolbarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToolbarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToolbarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToolbarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToolbarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToolbarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToolbarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToolbarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToolbarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToolbarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToolbarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToolbarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToolbarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToolbarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToolbarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToolbarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToolbarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToolbarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToolbarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToolbarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToolbarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToolbarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToolbarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToolbarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToolbarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToolbarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToolbarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToolbarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToolbarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToolbarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToolbarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToolbarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToolbarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToolbarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToolbarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToolbarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToolbarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToolbarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToolbarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToolbarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToolbarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToolbarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToolbarPropertyBuilder() =
    inherit BasePropertyBuilder<ToolbarProperty>()
    [<CustomOperation("toolbarStyle")>]
    member this.ToolbarStyle(it: ToolbarProperty seq, value: Gtk.ToolbarStyle) =
        seq { yield! it; yield ToolbarProperty.ToolbarStyle value } 
    [<CustomOperation("showArrow")>]
    member this.ShowArrow(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.ShowArrow value } 
    [<CustomOperation("iconSize")>]
    member this.IconSize(it: ToolbarProperty seq, value: Gtk.IconSize) =
        seq { yield! it; yield ToolbarProperty.IconSize value } 
    [<CustomOperation("iconSizeSet")>]
    member this.IconSizeSet(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.IconSizeSet value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ToolbarProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ToolbarProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToolbarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToolbarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToolbarProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToolbarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToolbarProperty seq, value: System.String) =
        seq { yield! it; yield ToolbarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToolbarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolbarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.ReceivesDefault value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToolbarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToolbarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToolbarProperty seq, value: System.String) =
        seq { yield! it; yield ToolbarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToolbarProperty seq, value: System.String) =
        seq { yield! it; yield ToolbarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToolbarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToolbarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToolbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolbarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToolbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolbarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToolbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolbarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ToolbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolbarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToolbarProperty seq, value: System.Double) =
        seq { yield! it; yield ToolbarProperty.Opacity value } 
    [<CustomOperation("onStyleChanged")>]
    member this.OnStyleChanged(it: ToolbarProperty seq, value: Gtk.StyleChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnStyleChanged value } 
    [<CustomOperation("onOrientationChanged")>]
    member this.OnOrientationChanged(it: ToolbarProperty seq, value: Gtk.OrientationChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnOrientationChanged value } 
    [<CustomOperation("onPopupContextMenu")>]
    member this.OnPopupContextMenu(it: ToolbarProperty seq, value: Gtk.PopupContextMenuArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnPopupContextMenu value } 
    [<CustomOperation("onFocusHomeOrEnd")>]
    member this.OnFocusHomeOrEnd(it: ToolbarProperty seq, value: Gtk.FocusHomeOrEndArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnFocusHomeOrEnd value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToolbarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToolbarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToolbarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToolbarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToolbarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToolbarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToolbarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToolbarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToolbarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToolbarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToolbarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToolbarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToolbarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToolbarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToolbarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToolbarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToolbarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToolbarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToolbarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToolbarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToolbarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToolbarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToolbarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToolbarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToolbarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToolbarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToolbarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToolbarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToolbarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToolbarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToolbarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToolbarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToolbarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToolbarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToolbarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToolbarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToolbarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToolbarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToolbarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToolbarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToolbarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToolbarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToolbarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToolbarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToolbarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToolbarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToolbarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToolbarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToolbarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToolbarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToolbarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToolbarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToolbarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToolbarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToolbarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToolbarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToolbarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToolbarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToolbarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToolbarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToolbarProperty.OnFocused value } 

let prop = ToolbarPropertyBuilder()

type ToolbarDescriptor(props) =
    inherit BaseWidgetDescriptor<Toolbar, ToolbarProperty>(props, bindProperty)
    override this.CreateTyped() = new Toolbar()

let toolbar props = ToolbarDescriptor(props)

