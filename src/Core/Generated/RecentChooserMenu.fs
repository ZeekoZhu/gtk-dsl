module GtkDsl.Binding.RecentChooserMenu
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RecentChooserMenuProperty =
    | [<Obsolete>] RelatedAction of Gtk.Action
    | [<Obsolete>] UseActionAppearance of System.Boolean
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

let bindProperty (widget: RecentChooserMenu) (prop: RecentChooserMenuProperty) =
    match prop with
    | RecentChooserMenuProperty.RelatedAction value -> widget.RelatedAction <- value
    | RecentChooserMenuProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | RecentChooserMenuProperty.Active value -> widget.Active <- value
    | RecentChooserMenuProperty.AccelGroup value -> widget.AccelGroup <- value
    | RecentChooserMenuProperty.AccelPath value -> widget.AccelPath <- value
    | RecentChooserMenuProperty.AttachWidget value -> widget.AttachWidget <- value
    | RecentChooserMenuProperty.TearoffTitle value -> widget.TearoffTitle <- value
    | RecentChooserMenuProperty.TearoffState value -> widget.TearoffState <- value
    | RecentChooserMenuProperty.Monitor value -> widget.Monitor <- value
    | RecentChooserMenuProperty.ReserveToggleSize value -> widget.ReserveToggleSize <- value
    | RecentChooserMenuProperty.AnchorHints value -> widget.AnchorHints <- value
    | RecentChooserMenuProperty.RectAnchorDx value -> widget.RectAnchorDx <- value
    | RecentChooserMenuProperty.RectAnchorDy value -> widget.RectAnchorDy <- value
    | RecentChooserMenuProperty.MenuTypeHint value -> widget.MenuTypeHint <- value
    | RecentChooserMenuProperty.TakeFocus value -> widget.TakeFocus <- value
    | RecentChooserMenuProperty.ResizeMode value -> widget.ResizeMode <- value
    | RecentChooserMenuProperty.BorderWidth value -> widget.BorderWidth <- value
    | RecentChooserMenuProperty.Name value -> widget.Name <- value
    | RecentChooserMenuProperty.Parent value -> widget.Parent <- value
    | RecentChooserMenuProperty.WidthRequest value -> widget.WidthRequest <- value
    | RecentChooserMenuProperty.HeightRequest value -> widget.HeightRequest <- value
    | RecentChooserMenuProperty.Visible value -> widget.Visible <- value
    | RecentChooserMenuProperty.Sensitive value -> widget.Sensitive <- value
    | RecentChooserMenuProperty.AppPaintable value -> widget.AppPaintable <- value
    | RecentChooserMenuProperty.CanFocus value -> widget.CanFocus <- value
    | RecentChooserMenuProperty.HasFocus value -> widget.HasFocus <- value
    | RecentChooserMenuProperty.IsFocus value -> widget.IsFocus <- value
    | RecentChooserMenuProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RecentChooserMenuProperty.CanDefault value -> widget.CanDefault <- value
    | RecentChooserMenuProperty.HasDefault value -> widget.HasDefault <- value
    | RecentChooserMenuProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RecentChooserMenuProperty.Style value -> widget.Style <- value
    | RecentChooserMenuProperty.Events value -> widget.Events <- value
    | RecentChooserMenuProperty.NoShowAll value -> widget.NoShowAll <- value
    | RecentChooserMenuProperty.HasTooltip value -> widget.HasTooltip <- value
    | RecentChooserMenuProperty.TooltipText value -> widget.TooltipText <- value
    | RecentChooserMenuProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RecentChooserMenuProperty.Window value -> widget.Window <- value
    | RecentChooserMenuProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RecentChooserMenuProperty.Halign value -> widget.Halign <- value
    | RecentChooserMenuProperty.Valign value -> widget.Valign <- value
    | RecentChooserMenuProperty.MarginLeft value -> widget.MarginLeft <- value
    | RecentChooserMenuProperty.MarginRight value -> widget.MarginRight <- value
    | RecentChooserMenuProperty.MarginStart value -> widget.MarginStart <- value
    | RecentChooserMenuProperty.MarginEnd value -> widget.MarginEnd <- value
    | RecentChooserMenuProperty.MarginTop value -> widget.MarginTop <- value
    | RecentChooserMenuProperty.MarginBottom value -> widget.MarginBottom <- value
    | RecentChooserMenuProperty.Margin value -> widget.Margin <- value
    | RecentChooserMenuProperty.Hexpand value -> widget.Hexpand <- value
    | RecentChooserMenuProperty.HexpandSet value -> widget.HexpandSet <- value
    | RecentChooserMenuProperty.Vexpand value -> widget.Vexpand <- value
    | RecentChooserMenuProperty.VexpandSet value -> widget.VexpandSet <- value
    | RecentChooserMenuProperty.Expand value -> widget.Expand <- value
    | RecentChooserMenuProperty.Opacity value -> widget.Opacity <- value
    | RecentChooserMenuProperty.OnPoppedUp handler -> 
        let disposable = widget.PoppedUp.Subscribe(handler)
        registerListener widget "PoppedUp" disposable
    | RecentChooserMenuProperty.OnMoveScroll handler -> 
        let disposable = widget.MoveScroll.Subscribe(handler)
        registerListener widget "MoveScroll" disposable
    | RecentChooserMenuProperty.OnMoveSelected handler -> 
        let disposable = widget.MoveSelected.Subscribe(handler)
        registerListener widget "MoveSelected" disposable
    | RecentChooserMenuProperty.OnMoveCurrent handler -> 
        let disposable = widget.MoveCurrent.Subscribe(handler)
        registerListener widget "MoveCurrent" disposable
    | RecentChooserMenuProperty.OnInserted handler -> 
        let disposable = widget.Inserted.Subscribe(handler)
        registerListener widget "Inserted" disposable
    | RecentChooserMenuProperty.OnActivateCurrent handler -> 
        let disposable = widget.ActivateCurrent.Subscribe(handler)
        registerListener widget "ActivateCurrent" disposable
    | RecentChooserMenuProperty.OnCycleFocus handler -> 
        let disposable = widget.CycleFocus.Subscribe(handler)
        registerListener widget "CycleFocus" disposable
    | RecentChooserMenuProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RecentChooserMenuProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RecentChooserMenuProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RecentChooserMenuProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RecentChooserMenuProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RecentChooserMenuProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RecentChooserMenuProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RecentChooserMenuProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RecentChooserMenuProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RecentChooserMenuProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RecentChooserMenuProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RecentChooserMenuProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RecentChooserMenuProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RecentChooserMenuProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RecentChooserMenuProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RecentChooserMenuProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RecentChooserMenuProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RecentChooserMenuProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RecentChooserMenuProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RecentChooserMenuProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RecentChooserMenuProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RecentChooserMenuProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RecentChooserMenuProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RecentChooserMenuProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RecentChooserMenuProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RecentChooserMenuProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RecentChooserMenuProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RecentChooserMenuProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RecentChooserMenuProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RecentChooserMenuProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RecentChooserMenuProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RecentChooserMenuProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RecentChooserMenuProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RecentChooserMenuProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RecentChooserMenuProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RecentChooserMenuProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RecentChooserMenuProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RecentChooserMenuProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RecentChooserMenuProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RecentChooserMenuProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RecentChooserMenuProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RecentChooserMenuProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RecentChooserMenuProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RecentChooserMenuProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RecentChooserMenuProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RecentChooserMenuProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RecentChooserMenuProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RecentChooserMenuProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RecentChooserMenuProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RecentChooserMenuProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RecentChooserMenuProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RecentChooserMenuProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RecentChooserMenuProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RecentChooserMenuProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RecentChooserMenuProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RecentChooserMenuProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RecentChooserMenuProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RecentChooserMenuProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RecentChooserMenuProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RecentChooserMenuProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RecentChooserMenuPropertyBuilder() =
    inherit BasePropertyBuilder<RecentChooserMenuProperty>()
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: RecentChooserMenuProperty seq, value: Gtk.Action) =
        seq { yield! it; yield RecentChooserMenuProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.UseActionAppearance value } 
    [<CustomOperation("active")>]
    member this.Active(it: RecentChooserMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserMenuProperty.Active value } 
    [<CustomOperation("accelGroup")>]
    member this.AccelGroup(it: RecentChooserMenuProperty seq, value: Gtk.AccelGroup) =
        seq { yield! it; yield RecentChooserMenuProperty.AccelGroup value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: RecentChooserMenuProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserMenuProperty.AccelPath value } 
    [<CustomOperation("attachWidget")>]
    member this.AttachWidget(it: RecentChooserMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserMenuProperty.AttachWidget value } 
    [<CustomOperation("tearoffTitle")>]
    member this.TearoffTitle(it: RecentChooserMenuProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserMenuProperty.TearoffTitle value } 
    [<Obsolete>]
    [<CustomOperation("tearoffState")>]
    member this.TearoffState(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.TearoffState value } 
    [<CustomOperation("monitor")>]
    member this.Monitor(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.Monitor value } 
    [<CustomOperation("reserveToggleSize")>]
    member this.ReserveToggleSize(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.ReserveToggleSize value } 
    [<CustomOperation("anchorHints")>]
    member this.AnchorHints(it: RecentChooserMenuProperty seq, value: Gdk.AnchorHints) =
        seq { yield! it; yield RecentChooserMenuProperty.AnchorHints value } 
    [<CustomOperation("rectAnchorDx")>]
    member this.RectAnchorDx(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.RectAnchorDx value } 
    [<CustomOperation("rectAnchorDy")>]
    member this.RectAnchorDy(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.RectAnchorDy value } 
    [<CustomOperation("menuTypeHint")>]
    member this.MenuTypeHint(it: RecentChooserMenuProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield RecentChooserMenuProperty.MenuTypeHint value } 
    [<CustomOperation("takeFocus")>]
    member this.TakeFocus(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.TakeFocus value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RecentChooserMenuProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RecentChooserMenuProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RecentChooserMenuProperty seq, value: System.UInt32) =
        seq { yield! it; yield RecentChooserMenuProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RecentChooserMenuProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserMenuProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RecentChooserMenuProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserMenuProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RecentChooserMenuProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RecentChooserMenuProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RecentChooserMenuProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RecentChooserMenuProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RecentChooserMenuProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserMenuProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RecentChooserMenuProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserMenuProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RecentChooserMenuProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RecentChooserMenuProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RecentChooserMenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserMenuProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RecentChooserMenuProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserMenuProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RecentChooserMenuProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserMenuProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RecentChooserMenuProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserMenuProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RecentChooserMenuProperty seq, value: System.Double) =
        seq { yield! it; yield RecentChooserMenuProperty.Opacity value } 
    [<CustomOperation("onPoppedUp")>]
    member this.OnPoppedUp(it: RecentChooserMenuProperty seq, value: Gtk.PoppedUpArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnPoppedUp value } 
    [<CustomOperation("onMoveScroll")>]
    member this.OnMoveScroll(it: RecentChooserMenuProperty seq, value: Gtk.MoveScrollArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMoveScroll value } 
    [<CustomOperation("onMoveSelected")>]
    member this.OnMoveSelected(it: RecentChooserMenuProperty seq, value: Gtk.MoveSelectedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMoveSelected value } 
    [<CustomOperation("onMoveCurrent")>]
    member this.OnMoveCurrent(it: RecentChooserMenuProperty seq, value: Gtk.MoveCurrentArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMoveCurrent value } 
    [<CustomOperation("onInserted")>]
    member this.OnInserted(it: RecentChooserMenuProperty seq, value: Gtk.InsertedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnInserted value } 
    [<CustomOperation("onActivateCurrent")>]
    member this.OnActivateCurrent(it: RecentChooserMenuProperty seq, value: Gtk.ActivateCurrentArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnActivateCurrent value } 
    [<CustomOperation("onCycleFocus")>]
    member this.OnCycleFocus(it: RecentChooserMenuProperty seq, value: Gtk.CycleFocusArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnCycleFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RecentChooserMenuProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RecentChooserMenuProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RecentChooserMenuProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RecentChooserMenuProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RecentChooserMenuProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RecentChooserMenuProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RecentChooserMenuProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RecentChooserMenuProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RecentChooserMenuProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RecentChooserMenuProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RecentChooserMenuProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RecentChooserMenuProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RecentChooserMenuProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RecentChooserMenuProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RecentChooserMenuProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RecentChooserMenuProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RecentChooserMenuProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RecentChooserMenuProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RecentChooserMenuProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RecentChooserMenuProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RecentChooserMenuProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RecentChooserMenuProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RecentChooserMenuProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RecentChooserMenuProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RecentChooserMenuProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RecentChooserMenuProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RecentChooserMenuProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RecentChooserMenuProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RecentChooserMenuProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RecentChooserMenuProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RecentChooserMenuProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RecentChooserMenuProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RecentChooserMenuProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RecentChooserMenuProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RecentChooserMenuProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RecentChooserMenuProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RecentChooserMenuProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RecentChooserMenuProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RecentChooserMenuProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RecentChooserMenuProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RecentChooserMenuProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RecentChooserMenuProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RecentChooserMenuProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RecentChooserMenuProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RecentChooserMenuProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RecentChooserMenuProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RecentChooserMenuProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RecentChooserMenuProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RecentChooserMenuProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RecentChooserMenuProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RecentChooserMenuProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RecentChooserMenuProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RecentChooserMenuProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RecentChooserMenuProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RecentChooserMenuProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RecentChooserMenuProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RecentChooserMenuProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RecentChooserMenuProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RecentChooserMenuProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RecentChooserMenuProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RecentChooserMenuProperty.OnFocused value } 

let prop = RecentChooserMenuPropertyBuilder()

type RecentChooserMenuDescriptor(props) =
    inherit BaseWidgetDescriptor<RecentChooserMenu, RecentChooserMenuProperty>(props, bindProperty)
    override this.CreateTyped() = new RecentChooserMenu()

let recentChooserMenu props = RecentChooserMenuDescriptor(props)

