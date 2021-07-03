module Gtk.DSL.Binding.MenuShell
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuShellProperty =
    | TakeFocus of System.Boolean
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
    |  OnMoveSelected of (Gtk.MoveSelectedArgs -> unit)
    |  OnMoveCurrent of (Gtk.MoveCurrentArgs -> unit)
    |  OnInserted of (Gtk.InsertedArgs -> unit)
    |  OnActivateCurrent of (Gtk.ActivateCurrentArgs -> unit)
    |  OnCycleFocus of (Gtk.CycleFocusArgs -> unit)
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

let bindProperty (widget: MenuShell) (prop: MenuShellProperty) =
    match prop with
    | MenuShellProperty.TakeFocus value -> widget.TakeFocus <- value
    | MenuShellProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuShellProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuShellProperty.Name value -> widget.Name <- value
    | MenuShellProperty.Parent value -> widget.Parent <- value
    | MenuShellProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuShellProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuShellProperty.Visible value -> widget.Visible <- value
    | MenuShellProperty.Sensitive value -> widget.Sensitive <- value
    | MenuShellProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuShellProperty.CanFocus value -> widget.CanFocus <- value
    | MenuShellProperty.HasFocus value -> widget.HasFocus <- value
    | MenuShellProperty.IsFocus value -> widget.IsFocus <- value
    | MenuShellProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuShellProperty.CanDefault value -> widget.CanDefault <- value
    | MenuShellProperty.HasDefault value -> widget.HasDefault <- value
    | MenuShellProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuShellProperty.Style value -> widget.Style <- value
    | MenuShellProperty.Events value -> widget.Events <- value
    | MenuShellProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuShellProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuShellProperty.TooltipText value -> widget.TooltipText <- value
    | MenuShellProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuShellProperty.Window value -> widget.Window <- value
    | MenuShellProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuShellProperty.Halign value -> widget.Halign <- value
    | MenuShellProperty.Valign value -> widget.Valign <- value
    | MenuShellProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuShellProperty.MarginRight value -> widget.MarginRight <- value
    | MenuShellProperty.MarginStart value -> widget.MarginStart <- value
    | MenuShellProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuShellProperty.MarginTop value -> widget.MarginTop <- value
    | MenuShellProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuShellProperty.Margin value -> widget.Margin <- value
    | MenuShellProperty.Hexpand value -> widget.Hexpand <- value
    | MenuShellProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuShellProperty.Vexpand value -> widget.Vexpand <- value
    | MenuShellProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuShellProperty.Expand value -> widget.Expand <- value
    | MenuShellProperty.Opacity value -> widget.Opacity <- value
    | MenuShellProperty.OnMoveSelected handler -> 
        let disposable = widget.MoveSelected.Subscribe(handler)
        registerListener widget "MoveSelected" disposable
    | MenuShellProperty.OnMoveCurrent handler -> 
        let disposable = widget.MoveCurrent.Subscribe(handler)
        registerListener widget "MoveCurrent" disposable
    | MenuShellProperty.OnInserted handler -> 
        let disposable = widget.Inserted.Subscribe(handler)
        registerListener widget "Inserted" disposable
    | MenuShellProperty.OnActivateCurrent handler -> 
        let disposable = widget.ActivateCurrent.Subscribe(handler)
        registerListener widget "ActivateCurrent" disposable
    | MenuShellProperty.OnCycleFocus handler -> 
        let disposable = widget.CycleFocus.Subscribe(handler)
        registerListener widget "CycleFocus" disposable
    | MenuShellProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuShellProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuShellProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuShellProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuShellProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuShellProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuShellProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuShellProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuShellProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuShellProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuShellProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuShellProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuShellProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuShellProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuShellProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuShellProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuShellProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuShellProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuShellProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuShellProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuShellProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuShellProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuShellProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuShellProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuShellProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuShellProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuShellProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuShellProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuShellProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuShellProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuShellProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuShellProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuShellProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuShellProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuShellProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuShellProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuShellProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuShellProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuShellProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuShellProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuShellProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuShellProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuShellProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuShellProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuShellProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuShellProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuShellProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuShellProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuShellProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuShellProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuShellProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuShellProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuShellProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuShellProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuShellProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuShellProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuShellProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuShellProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuShellProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuShellProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuShellPropertyBuilder() =
    inherit BasePropertyBuilder<MenuShellProperty>()
    [<CustomOperation("takeFocus")>]
    member this.TakeFocus(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.TakeFocus value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuShellProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuShellProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuShellProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuShellProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuShellProperty seq, value: System.String) =
        seq { yield! it; yield MenuShellProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuShellProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuShellProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuShellProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuShellProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuShellProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuShellProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuShellProperty seq, value: System.String) =
        seq { yield! it; yield MenuShellProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuShellProperty seq, value: System.String) =
        seq { yield! it; yield MenuShellProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuShellProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuShellProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuShellProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuShellProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuShellProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuShellProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuShellProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuShellProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MenuShellProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuShellProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuShellProperty seq, value: System.Double) =
        seq { yield! it; yield MenuShellProperty.Opacity value } 
    [<CustomOperation("onMoveSelected")>]
    member this.OnMoveSelected(it: MenuShellProperty seq, value: Gtk.MoveSelectedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnMoveSelected value } 
    [<CustomOperation("onMoveCurrent")>]
    member this.OnMoveCurrent(it: MenuShellProperty seq, value: Gtk.MoveCurrentArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnMoveCurrent value } 
    [<CustomOperation("onInserted")>]
    member this.OnInserted(it: MenuShellProperty seq, value: Gtk.InsertedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnInserted value } 
    [<CustomOperation("onActivateCurrent")>]
    member this.OnActivateCurrent(it: MenuShellProperty seq, value: Gtk.ActivateCurrentArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnActivateCurrent value } 
    [<CustomOperation("onCycleFocus")>]
    member this.OnCycleFocus(it: MenuShellProperty seq, value: Gtk.CycleFocusArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnCycleFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuShellProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuShellProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuShellProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuShellProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuShellProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuShellProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuShellProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuShellProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuShellProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuShellProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuShellProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuShellProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuShellProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuShellProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuShellProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuShellProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuShellProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuShellProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuShellProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuShellProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuShellProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuShellProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuShellProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuShellProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuShellProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuShellProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuShellProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuShellProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuShellProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuShellProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuShellProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuShellProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuShellProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuShellProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuShellProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuShellProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuShellProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuShellProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuShellProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuShellProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuShellProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuShellProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuShellProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuShellProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuShellProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuShellProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuShellProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuShellProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuShellProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuShellProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuShellProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuShellProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuShellProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuShellProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuShellProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuShellProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuShellProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuShellProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuShellProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuShellProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuShellProperty.OnFocused value } 

let prop = MenuShellPropertyBuilder()

