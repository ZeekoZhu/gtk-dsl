module GtkDsl.Binding.ToolPalette
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToolPaletteProperty =
    | IconSize of Gtk.IconSize
    | IconSizeSet of System.Boolean
    | ToolbarStyle of Gtk.ToolbarStyle
    | Orientation of Gtk.Orientation
    | Hadjustment of Gtk.Adjustment
    | Vadjustment of Gtk.Adjustment
    | HscrollPolicy of Gtk.ScrollablePolicy
    | VscrollPolicy of Gtk.ScrollablePolicy
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

let bindProperty (widget: ToolPalette) (prop: ToolPaletteProperty) =
    match prop with
    | ToolPaletteProperty.IconSize value -> widget.IconSize <- value
    | ToolPaletteProperty.IconSizeSet value -> widget.IconSizeSet <- value
    | ToolPaletteProperty.ToolbarStyle value -> widget.ToolbarStyle <- value
    | ToolPaletteProperty.Orientation value -> widget.Orientation <- value
    | ToolPaletteProperty.Hadjustment value -> widget.Hadjustment <- value
    | ToolPaletteProperty.Vadjustment value -> widget.Vadjustment <- value
    | ToolPaletteProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | ToolPaletteProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | ToolPaletteProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToolPaletteProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToolPaletteProperty.Name value -> widget.Name <- value
    | ToolPaletteProperty.Parent value -> widget.Parent <- value
    | ToolPaletteProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToolPaletteProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToolPaletteProperty.Visible value -> widget.Visible <- value
    | ToolPaletteProperty.Sensitive value -> widget.Sensitive <- value
    | ToolPaletteProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToolPaletteProperty.CanFocus value -> widget.CanFocus <- value
    | ToolPaletteProperty.HasFocus value -> widget.HasFocus <- value
    | ToolPaletteProperty.IsFocus value -> widget.IsFocus <- value
    | ToolPaletteProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToolPaletteProperty.CanDefault value -> widget.CanDefault <- value
    | ToolPaletteProperty.HasDefault value -> widget.HasDefault <- value
    | ToolPaletteProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToolPaletteProperty.Events value -> widget.Events <- value
    | ToolPaletteProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToolPaletteProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToolPaletteProperty.TooltipText value -> widget.TooltipText <- value
    | ToolPaletteProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToolPaletteProperty.Window value -> widget.Window <- value
    | ToolPaletteProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToolPaletteProperty.Halign value -> widget.Halign <- value
    | ToolPaletteProperty.Valign value -> widget.Valign <- value
    | ToolPaletteProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToolPaletteProperty.MarginRight value -> widget.MarginRight <- value
    | ToolPaletteProperty.MarginStart value -> widget.MarginStart <- value
    | ToolPaletteProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToolPaletteProperty.MarginTop value -> widget.MarginTop <- value
    | ToolPaletteProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToolPaletteProperty.Margin value -> widget.Margin <- value
    | ToolPaletteProperty.Hexpand value -> widget.Hexpand <- value
    | ToolPaletteProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToolPaletteProperty.Vexpand value -> widget.Vexpand <- value
    | ToolPaletteProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToolPaletteProperty.Expand value -> widget.Expand <- value
    | ToolPaletteProperty.Opacity value -> widget.Opacity <- value
    | ToolPaletteProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToolPaletteProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToolPaletteProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToolPaletteProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToolPaletteProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToolPaletteProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToolPaletteProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToolPaletteProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToolPaletteProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToolPaletteProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToolPaletteProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToolPaletteProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToolPaletteProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToolPaletteProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToolPaletteProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToolPaletteProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToolPaletteProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToolPaletteProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToolPaletteProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToolPaletteProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToolPaletteProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToolPaletteProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToolPaletteProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToolPaletteProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToolPaletteProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToolPaletteProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToolPaletteProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToolPaletteProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToolPaletteProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToolPaletteProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToolPaletteProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToolPaletteProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToolPaletteProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToolPaletteProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToolPaletteProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToolPaletteProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToolPaletteProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToolPaletteProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToolPaletteProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToolPaletteProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToolPaletteProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToolPaletteProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToolPaletteProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToolPaletteProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToolPaletteProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToolPaletteProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToolPaletteProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToolPaletteProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToolPaletteProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToolPaletteProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToolPaletteProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToolPaletteProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToolPaletteProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToolPaletteProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToolPaletteProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToolPaletteProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToolPaletteProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToolPaletteProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToolPaletteProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToolPaletteProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToolPalettePropertyBuilder() =
    inherit BasePropertyBuilder<ToolPaletteProperty>()
    [<CustomOperation("iconSize")>]
    member this.IconSize(it: ToolPaletteProperty seq, value: Gtk.IconSize) =
        seq { yield! it; yield ToolPaletteProperty.IconSize value } 
    [<CustomOperation("iconSizeSet")>]
    member this.IconSizeSet(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.IconSizeSet value } 
    [<CustomOperation("toolbarStyle")>]
    member this.ToolbarStyle(it: ToolPaletteProperty seq, value: Gtk.ToolbarStyle) =
        seq { yield! it; yield ToolPaletteProperty.ToolbarStyle value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ToolPaletteProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ToolPaletteProperty.Orientation value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: ToolPaletteProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ToolPaletteProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: ToolPaletteProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ToolPaletteProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: ToolPaletteProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield ToolPaletteProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: ToolPaletteProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield ToolPaletteProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToolPaletteProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToolPaletteProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToolPaletteProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToolPaletteProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToolPaletteProperty seq, value: System.String) =
        seq { yield! it; yield ToolPaletteProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToolPaletteProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolPaletteProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.ReceivesDefault value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToolPaletteProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToolPaletteProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToolPaletteProperty seq, value: System.String) =
        seq { yield! it; yield ToolPaletteProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToolPaletteProperty seq, value: System.String) =
        seq { yield! it; yield ToolPaletteProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToolPaletteProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToolPaletteProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToolPaletteProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolPaletteProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToolPaletteProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolPaletteProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToolPaletteProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolPaletteProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ToolPaletteProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolPaletteProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToolPaletteProperty seq, value: System.Double) =
        seq { yield! it; yield ToolPaletteProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToolPaletteProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToolPaletteProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToolPaletteProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToolPaletteProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToolPaletteProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToolPaletteProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToolPaletteProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToolPaletteProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToolPaletteProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToolPaletteProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToolPaletteProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToolPaletteProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToolPaletteProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToolPaletteProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToolPaletteProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToolPaletteProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToolPaletteProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToolPaletteProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToolPaletteProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToolPaletteProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToolPaletteProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToolPaletteProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToolPaletteProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToolPaletteProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToolPaletteProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToolPaletteProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToolPaletteProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToolPaletteProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToolPaletteProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToolPaletteProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToolPaletteProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToolPaletteProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToolPaletteProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToolPaletteProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToolPaletteProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToolPaletteProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToolPaletteProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToolPaletteProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToolPaletteProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToolPaletteProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToolPaletteProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToolPaletteProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToolPaletteProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToolPaletteProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToolPaletteProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToolPaletteProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToolPaletteProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToolPaletteProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToolPaletteProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToolPaletteProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToolPaletteProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToolPaletteProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToolPaletteProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToolPaletteProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToolPaletteProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToolPaletteProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToolPaletteProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToolPaletteProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToolPaletteProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToolPaletteProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToolPaletteProperty.OnFocused value } 

let prop = ToolPalettePropertyBuilder()

type ToolPaletteDescriptor(props) =
    inherit BaseWidgetDescriptor<ToolPalette, ToolPaletteProperty>(props, bindProperty)
    override this.CreateTyped() = new ToolPalette()

let toolPalette props = ToolPaletteDescriptor(props)

