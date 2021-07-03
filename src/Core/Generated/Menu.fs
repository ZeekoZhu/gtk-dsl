module Gtk.DSL.Binding.Menu
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuProperty =
    | Active of Gtk.Widget
    | AccelGroup of Gtk.AccelGroup
    | AccelPath of System.String
    | AttachWidget of Gtk.Widget
    | TearoffTitle of System.String
    | [<Obsolete>] TearoffState of System.Boolean
    | Monitor of System.Int32
    | ReserveToggleSize of System.Boolean
    | AnchorHints of Gdk.AnchorHints
    | RectAnchorDx of System.Int32
    | RectAnchorDy of System.Int32
    | MenuTypeHint of Gdk.WindowTypeHint
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
    |  OnPoppedUp of (Gtk.PoppedUpArgs -> unit)
    |  OnMoveScroll of (Gtk.MoveScrollArgs -> unit)
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

let bindProperty (widget: Menu) (prop: MenuProperty) =
    match prop with
    | MenuProperty.Active value -> widget.Active <- value
    | MenuProperty.AccelGroup value -> widget.AccelGroup <- value
    | MenuProperty.AccelPath value -> widget.AccelPath <- value
    | MenuProperty.AttachWidget value -> widget.AttachWidget <- value
    | MenuProperty.TearoffTitle value -> widget.TearoffTitle <- value
    | MenuProperty.TearoffState value -> widget.TearoffState <- value
    | MenuProperty.Monitor value -> widget.Monitor <- value
    | MenuProperty.ReserveToggleSize value -> widget.ReserveToggleSize <- value
    | MenuProperty.AnchorHints value -> widget.AnchorHints <- value
    | MenuProperty.RectAnchorDx value -> widget.RectAnchorDx <- value
    | MenuProperty.RectAnchorDy value -> widget.RectAnchorDy <- value
    | MenuProperty.MenuTypeHint value -> widget.MenuTypeHint <- value
    | MenuProperty.TakeFocus value -> widget.TakeFocus <- value
    | MenuProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuProperty.Name value -> widget.Name <- value
    | MenuProperty.Parent value -> widget.Parent <- value
    | MenuProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuProperty.Visible value -> widget.Visible <- value
    | MenuProperty.Sensitive value -> widget.Sensitive <- value
    | MenuProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuProperty.CanFocus value -> widget.CanFocus <- value
    | MenuProperty.HasFocus value -> widget.HasFocus <- value
    | MenuProperty.IsFocus value -> widget.IsFocus <- value
    | MenuProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuProperty.CanDefault value -> widget.CanDefault <- value
    | MenuProperty.HasDefault value -> widget.HasDefault <- value
    | MenuProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuProperty.Style value -> widget.Style <- value
    | MenuProperty.Events value -> widget.Events <- value
    | MenuProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuProperty.TooltipText value -> widget.TooltipText <- value
    | MenuProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuProperty.Window value -> widget.Window <- value
    | MenuProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuProperty.Halign value -> widget.Halign <- value
    | MenuProperty.Valign value -> widget.Valign <- value
    | MenuProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuProperty.MarginRight value -> widget.MarginRight <- value
    | MenuProperty.MarginStart value -> widget.MarginStart <- value
    | MenuProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuProperty.MarginTop value -> widget.MarginTop <- value
    | MenuProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuProperty.Margin value -> widget.Margin <- value
    | MenuProperty.Hexpand value -> widget.Hexpand <- value
    | MenuProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuProperty.Vexpand value -> widget.Vexpand <- value
    | MenuProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuProperty.Expand value -> widget.Expand <- value
    | MenuProperty.Opacity value -> widget.Opacity <- value
    | MenuProperty.OnPoppedUp handler -> 
        let disposable = widget.PoppedUp.Subscribe(handler)
        registerListener widget "PoppedUp" disposable
    | MenuProperty.OnMoveScroll handler -> 
        let disposable = widget.MoveScroll.Subscribe(handler)
        registerListener widget "MoveScroll" disposable
    | MenuProperty.OnMoveSelected handler -> 
        let disposable = widget.MoveSelected.Subscribe(handler)
        registerListener widget "MoveSelected" disposable
    | MenuProperty.OnMoveCurrent handler -> 
        let disposable = widget.MoveCurrent.Subscribe(handler)
        registerListener widget "MoveCurrent" disposable
    | MenuProperty.OnInserted handler -> 
        let disposable = widget.Inserted.Subscribe(handler)
        registerListener widget "Inserted" disposable
    | MenuProperty.OnActivateCurrent handler -> 
        let disposable = widget.ActivateCurrent.Subscribe(handler)
        registerListener widget "ActivateCurrent" disposable
    | MenuProperty.OnCycleFocus handler -> 
        let disposable = widget.CycleFocus.Subscribe(handler)
        registerListener widget "CycleFocus" disposable
    | MenuProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuPropertyBuilder() =
    inherit BasePropertyBuilder<MenuProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: MenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuProperty.Active value } 
    [<CustomOperation("accelGroup")>]
    member this.AccelGroup(it: MenuProperty seq, value: Gtk.AccelGroup) =
        seq { yield! it; yield MenuProperty.AccelGroup value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: MenuProperty seq, value: System.String) =
        seq { yield! it; yield MenuProperty.AccelPath value } 
    [<CustomOperation("attachWidget")>]
    member this.AttachWidget(it: MenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuProperty.AttachWidget value } 
    [<CustomOperation("tearoffTitle")>]
    member this.TearoffTitle(it: MenuProperty seq, value: System.String) =
        seq { yield! it; yield MenuProperty.TearoffTitle value } 
    [<Obsolete>]
    [<CustomOperation("tearoffState")>]
    member this.TearoffState(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.TearoffState value } 
    [<CustomOperation("monitor")>]
    member this.Monitor(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.Monitor value } 
    [<CustomOperation("reserveToggleSize")>]
    member this.ReserveToggleSize(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.ReserveToggleSize value } 
    [<CustomOperation("anchorHints")>]
    member this.AnchorHints(it: MenuProperty seq, value: Gdk.AnchorHints) =
        seq { yield! it; yield MenuProperty.AnchorHints value } 
    [<CustomOperation("rectAnchorDx")>]
    member this.RectAnchorDx(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.RectAnchorDx value } 
    [<CustomOperation("rectAnchorDy")>]
    member this.RectAnchorDy(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.RectAnchorDy value } 
    [<CustomOperation("menuTypeHint")>]
    member this.MenuTypeHint(it: MenuProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield MenuProperty.MenuTypeHint value } 
    [<CustomOperation("takeFocus")>]
    member this.TakeFocus(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.TakeFocus value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuProperty seq, value: System.String) =
        seq { yield! it; yield MenuProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuProperty seq, value: System.String) =
        seq { yield! it; yield MenuProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuProperty seq, value: System.String) =
        seq { yield! it; yield MenuProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuProperty seq, value: System.Double) =
        seq { yield! it; yield MenuProperty.Opacity value } 
    [<CustomOperation("onPoppedUp")>]
    member this.OnPoppedUp(it: MenuProperty seq, value: Gtk.PoppedUpArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnPoppedUp value } 
    [<CustomOperation("onMoveScroll")>]
    member this.OnMoveScroll(it: MenuProperty seq, value: Gtk.MoveScrollArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMoveScroll value } 
    [<CustomOperation("onMoveSelected")>]
    member this.OnMoveSelected(it: MenuProperty seq, value: Gtk.MoveSelectedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMoveSelected value } 
    [<CustomOperation("onMoveCurrent")>]
    member this.OnMoveCurrent(it: MenuProperty seq, value: Gtk.MoveCurrentArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMoveCurrent value } 
    [<CustomOperation("onInserted")>]
    member this.OnInserted(it: MenuProperty seq, value: Gtk.InsertedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnInserted value } 
    [<CustomOperation("onActivateCurrent")>]
    member this.OnActivateCurrent(it: MenuProperty seq, value: Gtk.ActivateCurrentArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnActivateCurrent value } 
    [<CustomOperation("onCycleFocus")>]
    member this.OnCycleFocus(it: MenuProperty seq, value: Gtk.CycleFocusArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnCycleFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuProperty.OnFocused value } 

let prop = MenuPropertyBuilder()

type MenuDescriptor(props) =
    inherit BaseWidgetDescriptor<Menu, MenuProperty>(props, bindProperty)
    override this.CreateTyped() = new Menu()

let menu props = MenuDescriptor(props)

