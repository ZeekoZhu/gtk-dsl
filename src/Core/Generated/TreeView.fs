module Gtk.DSL.Binding.TreeView
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type TreeViewProperty =
    | Model of Gtk.ITreeModel
    | HeadersVisible of System.Boolean
    | HeadersClickable of System.Boolean
    | ExpanderColumn of Gtk.TreeViewColumn
    | Reorderable of System.Boolean
    | [<Obsolete>] RulesHint of System.Boolean
    | EnableSearch of System.Boolean
    | SearchColumn of System.Int32
    | FixedHeightMode of System.Boolean
    | HoverSelection of System.Boolean
    | HoverExpand of System.Boolean
    | ShowExpanders of System.Boolean
    | LevelIndentation of System.Int32
    | RubberBanding of System.Boolean
    | EnableGridLines of Gtk.TreeViewGridLines
    | EnableTreeLines of System.Boolean
    | TooltipColumn of System.Int32
    | ActivateOnSingleClick of System.Boolean
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
    |  OnRowExpanded of (Gtk.RowExpandedArgs -> unit)
    |  OnRowActivated of (Gtk.RowActivatedArgs -> unit)
    |  OnSelectAll of (Gtk.SelectAllArgs -> unit)
    |  OnSelectCursorParent of (Gtk.SelectCursorParentArgs -> unit)
    |  OnRowCollapsed of (Gtk.RowCollapsedArgs -> unit)
    |  OnToggleCursorRow of (Gtk.ToggleCursorRowArgs -> unit)
    |  OnStartInteractiveSearch of (Gtk.StartInteractiveSearchArgs -> unit)
    |  OnMoveCursor of (Gtk.MoveCursorArgs -> unit)
    |  OnUnselectAll of (Gtk.UnselectAllArgs -> unit)
    |  OnTestExpandRow of (Gtk.TestExpandRowArgs -> unit)
    |  OnExpandCollapseCursorRow of (Gtk.ExpandCollapseCursorRowArgs -> unit)
    |  OnSelectCursorRow of (Gtk.SelectCursorRowArgs -> unit)
    |  OnTestCollapseRow of (Gtk.TestCollapseRowArgs -> unit)
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

let bindProperty (widget: TreeView) (prop: TreeViewProperty) =
    match prop with
    | TreeViewProperty.Model value -> widget.Model <- value
    | TreeViewProperty.HeadersVisible value -> widget.HeadersVisible <- value
    | TreeViewProperty.HeadersClickable value -> widget.HeadersClickable <- value
    | TreeViewProperty.ExpanderColumn value -> widget.ExpanderColumn <- value
    | TreeViewProperty.Reorderable value -> widget.Reorderable <- value
    | TreeViewProperty.RulesHint value -> widget.RulesHint <- value
    | TreeViewProperty.EnableSearch value -> widget.EnableSearch <- value
    | TreeViewProperty.SearchColumn value -> widget.SearchColumn <- value
    | TreeViewProperty.FixedHeightMode value -> widget.FixedHeightMode <- value
    | TreeViewProperty.HoverSelection value -> widget.HoverSelection <- value
    | TreeViewProperty.HoverExpand value -> widget.HoverExpand <- value
    | TreeViewProperty.ShowExpanders value -> widget.ShowExpanders <- value
    | TreeViewProperty.LevelIndentation value -> widget.LevelIndentation <- value
    | TreeViewProperty.RubberBanding value -> widget.RubberBanding <- value
    | TreeViewProperty.EnableGridLines value -> widget.EnableGridLines <- value
    | TreeViewProperty.EnableTreeLines value -> widget.EnableTreeLines <- value
    | TreeViewProperty.TooltipColumn value -> widget.TooltipColumn <- value
    | TreeViewProperty.ActivateOnSingleClick value -> widget.ActivateOnSingleClick <- value
    | TreeViewProperty.Hadjustment value -> widget.Hadjustment <- value
    | TreeViewProperty.Vadjustment value -> widget.Vadjustment <- value
    | TreeViewProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | TreeViewProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | TreeViewProperty.ResizeMode value -> widget.ResizeMode <- value
    | TreeViewProperty.BorderWidth value -> widget.BorderWidth <- value
    | TreeViewProperty.Name value -> widget.Name <- value
    | TreeViewProperty.Parent value -> widget.Parent <- value
    | TreeViewProperty.WidthRequest value -> widget.WidthRequest <- value
    | TreeViewProperty.HeightRequest value -> widget.HeightRequest <- value
    | TreeViewProperty.Visible value -> widget.Visible <- value
    | TreeViewProperty.Sensitive value -> widget.Sensitive <- value
    | TreeViewProperty.AppPaintable value -> widget.AppPaintable <- value
    | TreeViewProperty.CanFocus value -> widget.CanFocus <- value
    | TreeViewProperty.HasFocus value -> widget.HasFocus <- value
    | TreeViewProperty.IsFocus value -> widget.IsFocus <- value
    | TreeViewProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | TreeViewProperty.CanDefault value -> widget.CanDefault <- value
    | TreeViewProperty.HasDefault value -> widget.HasDefault <- value
    | TreeViewProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | TreeViewProperty.Style value -> widget.Style <- value
    | TreeViewProperty.Events value -> widget.Events <- value
    | TreeViewProperty.NoShowAll value -> widget.NoShowAll <- value
    | TreeViewProperty.HasTooltip value -> widget.HasTooltip <- value
    | TreeViewProperty.TooltipText value -> widget.TooltipText <- value
    | TreeViewProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | TreeViewProperty.Window value -> widget.Window <- value
    | TreeViewProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | TreeViewProperty.Halign value -> widget.Halign <- value
    | TreeViewProperty.Valign value -> widget.Valign <- value
    | TreeViewProperty.MarginLeft value -> widget.MarginLeft <- value
    | TreeViewProperty.MarginRight value -> widget.MarginRight <- value
    | TreeViewProperty.MarginStart value -> widget.MarginStart <- value
    | TreeViewProperty.MarginEnd value -> widget.MarginEnd <- value
    | TreeViewProperty.MarginTop value -> widget.MarginTop <- value
    | TreeViewProperty.MarginBottom value -> widget.MarginBottom <- value
    | TreeViewProperty.Margin value -> widget.Margin <- value
    | TreeViewProperty.Hexpand value -> widget.Hexpand <- value
    | TreeViewProperty.HexpandSet value -> widget.HexpandSet <- value
    | TreeViewProperty.Vexpand value -> widget.Vexpand <- value
    | TreeViewProperty.VexpandSet value -> widget.VexpandSet <- value
    | TreeViewProperty.Expand value -> widget.Expand <- value
    | TreeViewProperty.Opacity value -> widget.Opacity <- value
    | TreeViewProperty.OnRowExpanded handler -> 
        let disposable = widget.RowExpanded.Subscribe(handler)
        registerListener widget "RowExpanded" disposable
    | TreeViewProperty.OnRowActivated handler -> 
        let disposable = widget.RowActivated.Subscribe(handler)
        registerListener widget "RowActivated" disposable
    | TreeViewProperty.OnSelectAll handler -> 
        let disposable = widget.SelectAll.Subscribe(handler)
        registerListener widget "SelectAll" disposable
    | TreeViewProperty.OnSelectCursorParent handler -> 
        let disposable = widget.SelectCursorParent.Subscribe(handler)
        registerListener widget "SelectCursorParent" disposable
    | TreeViewProperty.OnRowCollapsed handler -> 
        let disposable = widget.RowCollapsed.Subscribe(handler)
        registerListener widget "RowCollapsed" disposable
    | TreeViewProperty.OnToggleCursorRow handler -> 
        let disposable = widget.ToggleCursorRow.Subscribe(handler)
        registerListener widget "ToggleCursorRow" disposable
    | TreeViewProperty.OnStartInteractiveSearch handler -> 
        let disposable = widget.StartInteractiveSearch.Subscribe(handler)
        registerListener widget "StartInteractiveSearch" disposable
    | TreeViewProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | TreeViewProperty.OnUnselectAll handler -> 
        let disposable = widget.UnselectAll.Subscribe(handler)
        registerListener widget "UnselectAll" disposable
    | TreeViewProperty.OnTestExpandRow handler -> 
        let disposable = widget.TestExpandRow.Subscribe(handler)
        registerListener widget "TestExpandRow" disposable
    | TreeViewProperty.OnExpandCollapseCursorRow handler -> 
        let disposable = widget.ExpandCollapseCursorRow.Subscribe(handler)
        registerListener widget "ExpandCollapseCursorRow" disposable
    | TreeViewProperty.OnSelectCursorRow handler -> 
        let disposable = widget.SelectCursorRow.Subscribe(handler)
        registerListener widget "SelectCursorRow" disposable
    | TreeViewProperty.OnTestCollapseRow handler -> 
        let disposable = widget.TestCollapseRow.Subscribe(handler)
        registerListener widget "TestCollapseRow" disposable
    | TreeViewProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | TreeViewProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | TreeViewProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | TreeViewProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | TreeViewProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | TreeViewProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | TreeViewProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | TreeViewProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | TreeViewProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | TreeViewProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | TreeViewProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | TreeViewProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | TreeViewProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | TreeViewProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | TreeViewProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | TreeViewProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | TreeViewProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | TreeViewProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | TreeViewProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | TreeViewProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | TreeViewProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | TreeViewProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | TreeViewProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | TreeViewProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | TreeViewProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | TreeViewProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | TreeViewProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | TreeViewProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | TreeViewProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | TreeViewProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | TreeViewProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | TreeViewProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | TreeViewProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | TreeViewProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | TreeViewProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | TreeViewProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | TreeViewProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | TreeViewProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | TreeViewProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | TreeViewProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | TreeViewProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | TreeViewProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | TreeViewProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | TreeViewProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | TreeViewProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | TreeViewProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | TreeViewProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | TreeViewProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | TreeViewProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | TreeViewProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | TreeViewProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | TreeViewProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | TreeViewProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | TreeViewProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | TreeViewProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | TreeViewProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | TreeViewProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | TreeViewProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | TreeViewProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | TreeViewProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type TreeViewPropertyBuilder() =
    inherit BasePropertyBuilder<TreeViewProperty>()
    [<CustomOperation("model")>]
    member this.Model(it: TreeViewProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield TreeViewProperty.Model value } 
    [<CustomOperation("headersVisible")>]
    member this.HeadersVisible(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HeadersVisible value } 
    [<CustomOperation("headersClickable")>]
    member this.HeadersClickable(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HeadersClickable value } 
    [<CustomOperation("expanderColumn")>]
    member this.ExpanderColumn(it: TreeViewProperty seq, value: Gtk.TreeViewColumn) =
        seq { yield! it; yield TreeViewProperty.ExpanderColumn value } 
    [<CustomOperation("reorderable")>]
    member this.Reorderable(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.Reorderable value } 
    [<Obsolete>]
    [<CustomOperation("rulesHint")>]
    member this.RulesHint(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.RulesHint value } 
    [<CustomOperation("enableSearch")>]
    member this.EnableSearch(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.EnableSearch value } 
    [<CustomOperation("searchColumn")>]
    member this.SearchColumn(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.SearchColumn value } 
    [<CustomOperation("fixedHeightMode")>]
    member this.FixedHeightMode(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.FixedHeightMode value } 
    [<CustomOperation("hoverSelection")>]
    member this.HoverSelection(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HoverSelection value } 
    [<CustomOperation("hoverExpand")>]
    member this.HoverExpand(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HoverExpand value } 
    [<CustomOperation("showExpanders")>]
    member this.ShowExpanders(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.ShowExpanders value } 
    [<CustomOperation("levelIndentation")>]
    member this.LevelIndentation(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.LevelIndentation value } 
    [<CustomOperation("rubberBanding")>]
    member this.RubberBanding(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.RubberBanding value } 
    [<CustomOperation("enableGridLines")>]
    member this.EnableGridLines(it: TreeViewProperty seq, value: Gtk.TreeViewGridLines) =
        seq { yield! it; yield TreeViewProperty.EnableGridLines value } 
    [<CustomOperation("enableTreeLines")>]
    member this.EnableTreeLines(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.EnableTreeLines value } 
    [<CustomOperation("tooltipColumn")>]
    member this.TooltipColumn(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.TooltipColumn value } 
    [<CustomOperation("activateOnSingleClick")>]
    member this.ActivateOnSingleClick(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.ActivateOnSingleClick value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: TreeViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield TreeViewProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: TreeViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield TreeViewProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: TreeViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield TreeViewProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: TreeViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield TreeViewProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: TreeViewProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield TreeViewProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: TreeViewProperty seq, value: System.UInt32) =
        seq { yield! it; yield TreeViewProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: TreeViewProperty seq, value: System.String) =
        seq { yield! it; yield TreeViewProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: TreeViewProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TreeViewProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: TreeViewProperty seq, value: Gtk.Style) =
        seq { yield! it; yield TreeViewProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: TreeViewProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield TreeViewProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: TreeViewProperty seq, value: System.String) =
        seq { yield! it; yield TreeViewProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: TreeViewProperty seq, value: System.String) =
        seq { yield! it; yield TreeViewProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: TreeViewProperty seq, value: Gdk.Window) =
        seq { yield! it; yield TreeViewProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: TreeViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TreeViewProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: TreeViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TreeViewProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: TreeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TreeViewProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: TreeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TreeViewProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: TreeViewProperty seq, value: System.Double) =
        seq { yield! it; yield TreeViewProperty.Opacity value } 
    [<CustomOperation("onRowExpanded")>]
    member this.OnRowExpanded(it: TreeViewProperty seq, value: Gtk.RowExpandedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnRowExpanded value } 
    [<CustomOperation("onRowActivated")>]
    member this.OnRowActivated(it: TreeViewProperty seq, value: Gtk.RowActivatedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnRowActivated value } 
    [<CustomOperation("onSelectAll")>]
    member this.OnSelectAll(it: TreeViewProperty seq, value: Gtk.SelectAllArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectAll value } 
    [<CustomOperation("onSelectCursorParent")>]
    member this.OnSelectCursorParent(it: TreeViewProperty seq, value: Gtk.SelectCursorParentArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectCursorParent value } 
    [<CustomOperation("onRowCollapsed")>]
    member this.OnRowCollapsed(it: TreeViewProperty seq, value: Gtk.RowCollapsedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnRowCollapsed value } 
    [<CustomOperation("onToggleCursorRow")>]
    member this.OnToggleCursorRow(it: TreeViewProperty seq, value: Gtk.ToggleCursorRowArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnToggleCursorRow value } 
    [<CustomOperation("onStartInteractiveSearch")>]
    member this.OnStartInteractiveSearch(it: TreeViewProperty seq, value: Gtk.StartInteractiveSearchArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnStartInteractiveSearch value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: TreeViewProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnMoveCursor value } 
    [<CustomOperation("onUnselectAll")>]
    member this.OnUnselectAll(it: TreeViewProperty seq, value: Gtk.UnselectAllArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnUnselectAll value } 
    [<CustomOperation("onTestExpandRow")>]
    member this.OnTestExpandRow(it: TreeViewProperty seq, value: Gtk.TestExpandRowArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnTestExpandRow value } 
    [<CustomOperation("onExpandCollapseCursorRow")>]
    member this.OnExpandCollapseCursorRow(it: TreeViewProperty seq, value: Gtk.ExpandCollapseCursorRowArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnExpandCollapseCursorRow value } 
    [<CustomOperation("onSelectCursorRow")>]
    member this.OnSelectCursorRow(it: TreeViewProperty seq, value: Gtk.SelectCursorRowArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectCursorRow value } 
    [<CustomOperation("onTestCollapseRow")>]
    member this.OnTestCollapseRow(it: TreeViewProperty seq, value: Gtk.TestCollapseRowArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnTestCollapseRow value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: TreeViewProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: TreeViewProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: TreeViewProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: TreeViewProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: TreeViewProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: TreeViewProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: TreeViewProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: TreeViewProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: TreeViewProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: TreeViewProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: TreeViewProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: TreeViewProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: TreeViewProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: TreeViewProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: TreeViewProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: TreeViewProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: TreeViewProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: TreeViewProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: TreeViewProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: TreeViewProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: TreeViewProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: TreeViewProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: TreeViewProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: TreeViewProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: TreeViewProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: TreeViewProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: TreeViewProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: TreeViewProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: TreeViewProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: TreeViewProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: TreeViewProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: TreeViewProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: TreeViewProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: TreeViewProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: TreeViewProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: TreeViewProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: TreeViewProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: TreeViewProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: TreeViewProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: TreeViewProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: TreeViewProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: TreeViewProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: TreeViewProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: TreeViewProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: TreeViewProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: TreeViewProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: TreeViewProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: TreeViewProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: TreeViewProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: TreeViewProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: TreeViewProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: TreeViewProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: TreeViewProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: TreeViewProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: TreeViewProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: TreeViewProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: TreeViewProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: TreeViewProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: TreeViewProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: TreeViewProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield TreeViewProperty.OnFocused value } 

let prop = TreeViewPropertyBuilder()

type TreeViewDescriptor(props) =
    inherit BaseWidgetDescriptor<TreeView, TreeViewProperty>(props, bindProperty)
    override this.CreateTyped() = new TreeView()

let treeView props = TreeViewDescriptor(props)

