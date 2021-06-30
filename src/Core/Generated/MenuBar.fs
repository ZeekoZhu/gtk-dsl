module GtkDsl.Binding.MenuBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuBarProperty =
    | PackDirection of Gtk.PackDirection
    | ChildPackDirection of Gtk.PackDirection
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

let bindProperty (widget: MenuBar) (prop: MenuBarProperty) =
    match prop with
    | MenuBarProperty.PackDirection value -> widget.PackDirection <- value
    | MenuBarProperty.ChildPackDirection value -> widget.ChildPackDirection <- value
    | MenuBarProperty.TakeFocus value -> widget.TakeFocus <- value
    | MenuBarProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuBarProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuBarProperty.Name value -> widget.Name <- value
    | MenuBarProperty.Parent value -> widget.Parent <- value
    | MenuBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuBarProperty.Visible value -> widget.Visible <- value
    | MenuBarProperty.Sensitive value -> widget.Sensitive <- value
    | MenuBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuBarProperty.CanFocus value -> widget.CanFocus <- value
    | MenuBarProperty.HasFocus value -> widget.HasFocus <- value
    | MenuBarProperty.IsFocus value -> widget.IsFocus <- value
    | MenuBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuBarProperty.CanDefault value -> widget.CanDefault <- value
    | MenuBarProperty.HasDefault value -> widget.HasDefault <- value
    | MenuBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuBarProperty.Style value -> widget.Style <- value
    | MenuBarProperty.Events value -> widget.Events <- value
    | MenuBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuBarProperty.TooltipText value -> widget.TooltipText <- value
    | MenuBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuBarProperty.Window value -> widget.Window <- value
    | MenuBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuBarProperty.Halign value -> widget.Halign <- value
    | MenuBarProperty.Valign value -> widget.Valign <- value
    | MenuBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuBarProperty.MarginRight value -> widget.MarginRight <- value
    | MenuBarProperty.MarginStart value -> widget.MarginStart <- value
    | MenuBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuBarProperty.MarginTop value -> widget.MarginTop <- value
    | MenuBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuBarProperty.Margin value -> widget.Margin <- value
    | MenuBarProperty.Hexpand value -> widget.Hexpand <- value
    | MenuBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuBarProperty.Vexpand value -> widget.Vexpand <- value
    | MenuBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuBarProperty.Expand value -> widget.Expand <- value
    | MenuBarProperty.Opacity value -> widget.Opacity <- value
    | MenuBarProperty.OnMoveSelected handler -> 
        let disposable = widget.MoveSelected.Subscribe(handler)
        registerListener widget "MoveSelected" disposable
    | MenuBarProperty.OnMoveCurrent handler -> 
        let disposable = widget.MoveCurrent.Subscribe(handler)
        registerListener widget "MoveCurrent" disposable
    | MenuBarProperty.OnInserted handler -> 
        let disposable = widget.Inserted.Subscribe(handler)
        registerListener widget "Inserted" disposable
    | MenuBarProperty.OnActivateCurrent handler -> 
        let disposable = widget.ActivateCurrent.Subscribe(handler)
        registerListener widget "ActivateCurrent" disposable
    | MenuBarProperty.OnCycleFocus handler -> 
        let disposable = widget.CycleFocus.Subscribe(handler)
        registerListener widget "CycleFocus" disposable
    | MenuBarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuBarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuBarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuBarPropertyBuilder() =
    inherit BasePropertyBuilder<MenuBarProperty>()
    [<CustomOperation("packDirection")>]
    member this.PackDirection(it: MenuBarProperty seq, value: Gtk.PackDirection) =
        seq { yield! it; yield MenuBarProperty.PackDirection value } 
    [<CustomOperation("childPackDirection")>]
    member this.ChildPackDirection(it: MenuBarProperty seq, value: Gtk.PackDirection) =
        seq { yield! it; yield MenuBarProperty.ChildPackDirection value } 
    [<CustomOperation("takeFocus")>]
    member this.TakeFocus(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.TakeFocus value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuBarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuBarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuBarProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuBarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuBarProperty seq, value: System.String) =
        seq { yield! it; yield MenuBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuBarProperty seq, value: System.String) =
        seq { yield! it; yield MenuBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuBarProperty seq, value: System.String) =
        seq { yield! it; yield MenuBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuBarProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MenuBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuBarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuBarProperty seq, value: System.Double) =
        seq { yield! it; yield MenuBarProperty.Opacity value } 
    [<CustomOperation("onMoveSelected")>]
    member this.OnMoveSelected(it: MenuBarProperty seq, value: Gtk.MoveSelectedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnMoveSelected value } 
    [<CustomOperation("onMoveCurrent")>]
    member this.OnMoveCurrent(it: MenuBarProperty seq, value: Gtk.MoveCurrentArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnMoveCurrent value } 
    [<CustomOperation("onInserted")>]
    member this.OnInserted(it: MenuBarProperty seq, value: Gtk.InsertedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnInserted value } 
    [<CustomOperation("onActivateCurrent")>]
    member this.OnActivateCurrent(it: MenuBarProperty seq, value: Gtk.ActivateCurrentArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnActivateCurrent value } 
    [<CustomOperation("onCycleFocus")>]
    member this.OnCycleFocus(it: MenuBarProperty seq, value: Gtk.CycleFocusArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnCycleFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuBarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuBarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuBarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuBarProperty.OnFocused value } 

let prop = MenuBarPropertyBuilder()

type MenuBarDescriptor(props) =
    inherit BaseWidgetDescriptor<MenuBar, MenuBarProperty>(props, bindProperty)
    override this.CreateTyped() = new MenuBar()

let menuBar props = MenuBarDescriptor(props)

