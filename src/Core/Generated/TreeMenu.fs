module Gtk.DSL.Binding.TreeMenu
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type TreeMenuProperty =
    | Model of Gtk.ITreeModel
    | Root of Gtk.TreePath
    | Tearoff of System.Boolean
    | WrapWidth of System.Int32
    | RowSpanColumn of System.Int32
    | ColumnSpanColumn of System.Int32
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
    |  OnMenuActivate of (Gtk.MenuActivateArgs -> unit)
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

let bindProperty (widget: TreeMenu) (prop: TreeMenuProperty) =
    match prop with
    | TreeMenuProperty.Model value -> widget.Model <- value
    | TreeMenuProperty.Root value -> widget.Root <- value
    | TreeMenuProperty.Tearoff value -> widget.Tearoff <- value
    | TreeMenuProperty.WrapWidth value -> widget.WrapWidth <- value
    | TreeMenuProperty.RowSpanColumn value -> widget.RowSpanColumn <- value
    | TreeMenuProperty.ColumnSpanColumn value -> widget.ColumnSpanColumn <- value
    | TreeMenuProperty.Active value -> widget.Active <- value
    | TreeMenuProperty.AccelGroup value -> widget.AccelGroup <- value
    | TreeMenuProperty.AccelPath value -> widget.AccelPath <- value
    | TreeMenuProperty.AttachWidget value -> widget.AttachWidget <- value
    | TreeMenuProperty.TearoffTitle value -> widget.TearoffTitle <- value
    | TreeMenuProperty.TearoffState value -> widget.TearoffState <- value
    | TreeMenuProperty.Monitor value -> widget.Monitor <- value
    | TreeMenuProperty.ReserveToggleSize value -> widget.ReserveToggleSize <- value
    | TreeMenuProperty.AnchorHints value -> widget.AnchorHints <- value
    | TreeMenuProperty.RectAnchorDx value -> widget.RectAnchorDx <- value
    | TreeMenuProperty.RectAnchorDy value -> widget.RectAnchorDy <- value
    | TreeMenuProperty.MenuTypeHint value -> widget.MenuTypeHint <- value
    | TreeMenuProperty.TakeFocus value -> widget.TakeFocus <- value
    | TreeMenuProperty.ResizeMode value -> widget.ResizeMode <- value
    | TreeMenuProperty.BorderWidth value -> widget.BorderWidth <- value
    | TreeMenuProperty.Name value -> widget.Name <- value
    | TreeMenuProperty.Parent value -> widget.Parent <- value
    | TreeMenuProperty.WidthRequest value -> widget.WidthRequest <- value
    | TreeMenuProperty.HeightRequest value -> widget.HeightRequest <- value
    | TreeMenuProperty.Visible value -> widget.Visible <- value
    | TreeMenuProperty.Sensitive value -> widget.Sensitive <- value
    | TreeMenuProperty.AppPaintable value -> widget.AppPaintable <- value
    | TreeMenuProperty.CanFocus value -> widget.CanFocus <- value
    | TreeMenuProperty.HasFocus value -> widget.HasFocus <- value
    | TreeMenuProperty.IsFocus value -> widget.IsFocus <- value
    | TreeMenuProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | TreeMenuProperty.CanDefault value -> widget.CanDefault <- value
    | TreeMenuProperty.HasDefault value -> widget.HasDefault <- value
    | TreeMenuProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | TreeMenuProperty.Style value -> widget.Style <- value
    | TreeMenuProperty.Events value -> widget.Events <- value
    | TreeMenuProperty.NoShowAll value -> widget.NoShowAll <- value
    | TreeMenuProperty.HasTooltip value -> widget.HasTooltip <- value
    | TreeMenuProperty.TooltipText value -> widget.TooltipText <- value
    | TreeMenuProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | TreeMenuProperty.Window value -> widget.Window <- value
    | TreeMenuProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | TreeMenuProperty.Halign value -> widget.Halign <- value
    | TreeMenuProperty.Valign value -> widget.Valign <- value
    | TreeMenuProperty.MarginLeft value -> widget.MarginLeft <- value
    | TreeMenuProperty.MarginRight value -> widget.MarginRight <- value
    | TreeMenuProperty.MarginStart value -> widget.MarginStart <- value
    | TreeMenuProperty.MarginEnd value -> widget.MarginEnd <- value
    | TreeMenuProperty.MarginTop value -> widget.MarginTop <- value
    | TreeMenuProperty.MarginBottom value -> widget.MarginBottom <- value
    | TreeMenuProperty.Margin value -> widget.Margin <- value
    | TreeMenuProperty.Hexpand value -> widget.Hexpand <- value
    | TreeMenuProperty.HexpandSet value -> widget.HexpandSet <- value
    | TreeMenuProperty.Vexpand value -> widget.Vexpand <- value
    | TreeMenuProperty.VexpandSet value -> widget.VexpandSet <- value
    | TreeMenuProperty.Expand value -> widget.Expand <- value
    | TreeMenuProperty.Opacity value -> widget.Opacity <- value
    | TreeMenuProperty.OnMenuActivate handler -> 
        let disposable = widget.MenuActivate.Subscribe(handler)
        registerListener widget "MenuActivate" disposable
    | TreeMenuProperty.OnPoppedUp handler -> 
        let disposable = widget.PoppedUp.Subscribe(handler)
        registerListener widget "PoppedUp" disposable
    | TreeMenuProperty.OnMoveScroll handler -> 
        let disposable = widget.MoveScroll.Subscribe(handler)
        registerListener widget "MoveScroll" disposable
    | TreeMenuProperty.OnMoveSelected handler -> 
        let disposable = widget.MoveSelected.Subscribe(handler)
        registerListener widget "MoveSelected" disposable
    | TreeMenuProperty.OnMoveCurrent handler -> 
        let disposable = widget.MoveCurrent.Subscribe(handler)
        registerListener widget "MoveCurrent" disposable
    | TreeMenuProperty.OnInserted handler -> 
        let disposable = widget.Inserted.Subscribe(handler)
        registerListener widget "Inserted" disposable
    | TreeMenuProperty.OnActivateCurrent handler -> 
        let disposable = widget.ActivateCurrent.Subscribe(handler)
        registerListener widget "ActivateCurrent" disposable
    | TreeMenuProperty.OnCycleFocus handler -> 
        let disposable = widget.CycleFocus.Subscribe(handler)
        registerListener widget "CycleFocus" disposable
    | TreeMenuProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | TreeMenuProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | TreeMenuProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | TreeMenuProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | TreeMenuProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | TreeMenuProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | TreeMenuProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | TreeMenuProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | TreeMenuProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | TreeMenuProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | TreeMenuProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | TreeMenuProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | TreeMenuProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | TreeMenuProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | TreeMenuProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | TreeMenuProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | TreeMenuProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | TreeMenuProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | TreeMenuProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | TreeMenuProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | TreeMenuProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | TreeMenuProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | TreeMenuProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | TreeMenuProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | TreeMenuProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | TreeMenuProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | TreeMenuProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | TreeMenuProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | TreeMenuProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | TreeMenuProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | TreeMenuProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | TreeMenuProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | TreeMenuProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | TreeMenuProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | TreeMenuProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | TreeMenuProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | TreeMenuProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | TreeMenuProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | TreeMenuProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | TreeMenuProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | TreeMenuProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | TreeMenuProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | TreeMenuProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | TreeMenuProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | TreeMenuProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | TreeMenuProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | TreeMenuProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | TreeMenuProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | TreeMenuProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | TreeMenuProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | TreeMenuProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | TreeMenuProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | TreeMenuProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | TreeMenuProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | TreeMenuProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | TreeMenuProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | TreeMenuProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | TreeMenuProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | TreeMenuProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | TreeMenuProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type TreeMenuPropertyBuilder() =
    inherit BasePropertyBuilder<TreeMenuProperty>()
    [<CustomOperation("model")>]
    member this.Model(it: TreeMenuProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield TreeMenuProperty.Model value } 
    [<CustomOperation("root")>]
    member this.Root(it: TreeMenuProperty seq, value: Gtk.TreePath) =
        seq { yield! it; yield TreeMenuProperty.Root value } 
    [<CustomOperation("tearoff")>]
    member this.Tearoff(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.Tearoff value } 
    [<CustomOperation("wrapWidth")>]
    member this.WrapWidth(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.WrapWidth value } 
    [<CustomOperation("rowSpanColumn")>]
    member this.RowSpanColumn(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.RowSpanColumn value } 
    [<CustomOperation("columnSpanColumn")>]
    member this.ColumnSpanColumn(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.ColumnSpanColumn value } 
    [<CustomOperation("active")>]
    member this.Active(it: TreeMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TreeMenuProperty.Active value } 
    [<CustomOperation("accelGroup")>]
    member this.AccelGroup(it: TreeMenuProperty seq, value: Gtk.AccelGroup) =
        seq { yield! it; yield TreeMenuProperty.AccelGroup value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: TreeMenuProperty seq, value: System.String) =
        seq { yield! it; yield TreeMenuProperty.AccelPath value } 
    [<CustomOperation("attachWidget")>]
    member this.AttachWidget(it: TreeMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TreeMenuProperty.AttachWidget value } 
    [<CustomOperation("tearoffTitle")>]
    member this.TearoffTitle(it: TreeMenuProperty seq, value: System.String) =
        seq { yield! it; yield TreeMenuProperty.TearoffTitle value } 
    [<Obsolete>]
    [<CustomOperation("tearoffState")>]
    member this.TearoffState(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.TearoffState value } 
    [<CustomOperation("monitor")>]
    member this.Monitor(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.Monitor value } 
    [<CustomOperation("reserveToggleSize")>]
    member this.ReserveToggleSize(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.ReserveToggleSize value } 
    [<CustomOperation("anchorHints")>]
    member this.AnchorHints(it: TreeMenuProperty seq, value: Gdk.AnchorHints) =
        seq { yield! it; yield TreeMenuProperty.AnchorHints value } 
    [<CustomOperation("rectAnchorDx")>]
    member this.RectAnchorDx(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.RectAnchorDx value } 
    [<CustomOperation("rectAnchorDy")>]
    member this.RectAnchorDy(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.RectAnchorDy value } 
    [<CustomOperation("menuTypeHint")>]
    member this.MenuTypeHint(it: TreeMenuProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield TreeMenuProperty.MenuTypeHint value } 
    [<CustomOperation("takeFocus")>]
    member this.TakeFocus(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.TakeFocus value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: TreeMenuProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield TreeMenuProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: TreeMenuProperty seq, value: System.UInt32) =
        seq { yield! it; yield TreeMenuProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: TreeMenuProperty seq, value: System.String) =
        seq { yield! it; yield TreeMenuProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: TreeMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TreeMenuProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: TreeMenuProperty seq, value: Gtk.Style) =
        seq { yield! it; yield TreeMenuProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: TreeMenuProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield TreeMenuProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: TreeMenuProperty seq, value: System.String) =
        seq { yield! it; yield TreeMenuProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: TreeMenuProperty seq, value: System.String) =
        seq { yield! it; yield TreeMenuProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: TreeMenuProperty seq, value: Gdk.Window) =
        seq { yield! it; yield TreeMenuProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: TreeMenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TreeMenuProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: TreeMenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TreeMenuProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: TreeMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeMenuProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: TreeMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeMenuProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: TreeMenuProperty seq, value: System.Double) =
        seq { yield! it; yield TreeMenuProperty.Opacity value } 
    [<CustomOperation("onMenuActivate")>]
    member this.OnMenuActivate(it: TreeMenuProperty seq, value: Gtk.MenuActivateArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMenuActivate value } 
    [<CustomOperation("onPoppedUp")>]
    member this.OnPoppedUp(it: TreeMenuProperty seq, value: Gtk.PoppedUpArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnPoppedUp value } 
    [<CustomOperation("onMoveScroll")>]
    member this.OnMoveScroll(it: TreeMenuProperty seq, value: Gtk.MoveScrollArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMoveScroll value } 
    [<CustomOperation("onMoveSelected")>]
    member this.OnMoveSelected(it: TreeMenuProperty seq, value: Gtk.MoveSelectedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMoveSelected value } 
    [<CustomOperation("onMoveCurrent")>]
    member this.OnMoveCurrent(it: TreeMenuProperty seq, value: Gtk.MoveCurrentArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMoveCurrent value } 
    [<CustomOperation("onInserted")>]
    member this.OnInserted(it: TreeMenuProperty seq, value: Gtk.InsertedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnInserted value } 
    [<CustomOperation("onActivateCurrent")>]
    member this.OnActivateCurrent(it: TreeMenuProperty seq, value: Gtk.ActivateCurrentArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnActivateCurrent value } 
    [<CustomOperation("onCycleFocus")>]
    member this.OnCycleFocus(it: TreeMenuProperty seq, value: Gtk.CycleFocusArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnCycleFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: TreeMenuProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: TreeMenuProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: TreeMenuProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: TreeMenuProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: TreeMenuProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: TreeMenuProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: TreeMenuProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: TreeMenuProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: TreeMenuProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: TreeMenuProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: TreeMenuProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: TreeMenuProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: TreeMenuProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: TreeMenuProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: TreeMenuProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: TreeMenuProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: TreeMenuProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: TreeMenuProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: TreeMenuProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: TreeMenuProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: TreeMenuProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: TreeMenuProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: TreeMenuProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: TreeMenuProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: TreeMenuProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: TreeMenuProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: TreeMenuProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: TreeMenuProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: TreeMenuProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: TreeMenuProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: TreeMenuProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: TreeMenuProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: TreeMenuProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: TreeMenuProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: TreeMenuProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: TreeMenuProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: TreeMenuProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: TreeMenuProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: TreeMenuProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: TreeMenuProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: TreeMenuProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: TreeMenuProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: TreeMenuProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: TreeMenuProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: TreeMenuProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: TreeMenuProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: TreeMenuProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: TreeMenuProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: TreeMenuProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: TreeMenuProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: TreeMenuProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: TreeMenuProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: TreeMenuProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: TreeMenuProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: TreeMenuProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: TreeMenuProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: TreeMenuProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: TreeMenuProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: TreeMenuProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: TreeMenuProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield TreeMenuProperty.OnFocused value } 

let prop = TreeMenuPropertyBuilder()

