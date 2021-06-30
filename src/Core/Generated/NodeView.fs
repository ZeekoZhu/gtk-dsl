module GtkDsl.Binding.NodeView
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type NodeViewProperty =
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

let bindProperty (widget: NodeView) (prop: NodeViewProperty) =
    match prop with
    | NodeViewProperty.Model value -> widget.Model <- value
    | NodeViewProperty.HeadersVisible value -> widget.HeadersVisible <- value
    | NodeViewProperty.HeadersClickable value -> widget.HeadersClickable <- value
    | NodeViewProperty.ExpanderColumn value -> widget.ExpanderColumn <- value
    | NodeViewProperty.Reorderable value -> widget.Reorderable <- value
    | NodeViewProperty.RulesHint value -> widget.RulesHint <- value
    | NodeViewProperty.EnableSearch value -> widget.EnableSearch <- value
    | NodeViewProperty.SearchColumn value -> widget.SearchColumn <- value
    | NodeViewProperty.FixedHeightMode value -> widget.FixedHeightMode <- value
    | NodeViewProperty.HoverSelection value -> widget.HoverSelection <- value
    | NodeViewProperty.HoverExpand value -> widget.HoverExpand <- value
    | NodeViewProperty.ShowExpanders value -> widget.ShowExpanders <- value
    | NodeViewProperty.LevelIndentation value -> widget.LevelIndentation <- value
    | NodeViewProperty.RubberBanding value -> widget.RubberBanding <- value
    | NodeViewProperty.EnableGridLines value -> widget.EnableGridLines <- value
    | NodeViewProperty.EnableTreeLines value -> widget.EnableTreeLines <- value
    | NodeViewProperty.TooltipColumn value -> widget.TooltipColumn <- value
    | NodeViewProperty.ActivateOnSingleClick value -> widget.ActivateOnSingleClick <- value
    | NodeViewProperty.Hadjustment value -> widget.Hadjustment <- value
    | NodeViewProperty.Vadjustment value -> widget.Vadjustment <- value
    | NodeViewProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | NodeViewProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | NodeViewProperty.ResizeMode value -> widget.ResizeMode <- value
    | NodeViewProperty.BorderWidth value -> widget.BorderWidth <- value
    | NodeViewProperty.Name value -> widget.Name <- value
    | NodeViewProperty.Parent value -> widget.Parent <- value
    | NodeViewProperty.WidthRequest value -> widget.WidthRequest <- value
    | NodeViewProperty.HeightRequest value -> widget.HeightRequest <- value
    | NodeViewProperty.Visible value -> widget.Visible <- value
    | NodeViewProperty.Sensitive value -> widget.Sensitive <- value
    | NodeViewProperty.AppPaintable value -> widget.AppPaintable <- value
    | NodeViewProperty.CanFocus value -> widget.CanFocus <- value
    | NodeViewProperty.HasFocus value -> widget.HasFocus <- value
    | NodeViewProperty.IsFocus value -> widget.IsFocus <- value
    | NodeViewProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | NodeViewProperty.CanDefault value -> widget.CanDefault <- value
    | NodeViewProperty.HasDefault value -> widget.HasDefault <- value
    | NodeViewProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | NodeViewProperty.Style value -> widget.Style <- value
    | NodeViewProperty.Events value -> widget.Events <- value
    | NodeViewProperty.NoShowAll value -> widget.NoShowAll <- value
    | NodeViewProperty.HasTooltip value -> widget.HasTooltip <- value
    | NodeViewProperty.TooltipText value -> widget.TooltipText <- value
    | NodeViewProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | NodeViewProperty.Window value -> widget.Window <- value
    | NodeViewProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | NodeViewProperty.Halign value -> widget.Halign <- value
    | NodeViewProperty.Valign value -> widget.Valign <- value
    | NodeViewProperty.MarginLeft value -> widget.MarginLeft <- value
    | NodeViewProperty.MarginRight value -> widget.MarginRight <- value
    | NodeViewProperty.MarginStart value -> widget.MarginStart <- value
    | NodeViewProperty.MarginEnd value -> widget.MarginEnd <- value
    | NodeViewProperty.MarginTop value -> widget.MarginTop <- value
    | NodeViewProperty.MarginBottom value -> widget.MarginBottom <- value
    | NodeViewProperty.Margin value -> widget.Margin <- value
    | NodeViewProperty.Hexpand value -> widget.Hexpand <- value
    | NodeViewProperty.HexpandSet value -> widget.HexpandSet <- value
    | NodeViewProperty.Vexpand value -> widget.Vexpand <- value
    | NodeViewProperty.VexpandSet value -> widget.VexpandSet <- value
    | NodeViewProperty.Expand value -> widget.Expand <- value
    | NodeViewProperty.Opacity value -> widget.Opacity <- value
    | NodeViewProperty.OnRowExpanded handler -> 
        let disposable = widget.RowExpanded.Subscribe(handler)
        registerListener widget "RowExpanded" disposable
    | NodeViewProperty.OnRowActivated handler -> 
        let disposable = widget.RowActivated.Subscribe(handler)
        registerListener widget "RowActivated" disposable
    | NodeViewProperty.OnSelectAll handler -> 
        let disposable = widget.SelectAll.Subscribe(handler)
        registerListener widget "SelectAll" disposable
    | NodeViewProperty.OnSelectCursorParent handler -> 
        let disposable = widget.SelectCursorParent.Subscribe(handler)
        registerListener widget "SelectCursorParent" disposable
    | NodeViewProperty.OnRowCollapsed handler -> 
        let disposable = widget.RowCollapsed.Subscribe(handler)
        registerListener widget "RowCollapsed" disposable
    | NodeViewProperty.OnToggleCursorRow handler -> 
        let disposable = widget.ToggleCursorRow.Subscribe(handler)
        registerListener widget "ToggleCursorRow" disposable
    | NodeViewProperty.OnStartInteractiveSearch handler -> 
        let disposable = widget.StartInteractiveSearch.Subscribe(handler)
        registerListener widget "StartInteractiveSearch" disposable
    | NodeViewProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | NodeViewProperty.OnUnselectAll handler -> 
        let disposable = widget.UnselectAll.Subscribe(handler)
        registerListener widget "UnselectAll" disposable
    | NodeViewProperty.OnTestExpandRow handler -> 
        let disposable = widget.TestExpandRow.Subscribe(handler)
        registerListener widget "TestExpandRow" disposable
    | NodeViewProperty.OnExpandCollapseCursorRow handler -> 
        let disposable = widget.ExpandCollapseCursorRow.Subscribe(handler)
        registerListener widget "ExpandCollapseCursorRow" disposable
    | NodeViewProperty.OnSelectCursorRow handler -> 
        let disposable = widget.SelectCursorRow.Subscribe(handler)
        registerListener widget "SelectCursorRow" disposable
    | NodeViewProperty.OnTestCollapseRow handler -> 
        let disposable = widget.TestCollapseRow.Subscribe(handler)
        registerListener widget "TestCollapseRow" disposable
    | NodeViewProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | NodeViewProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | NodeViewProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | NodeViewProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | NodeViewProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | NodeViewProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | NodeViewProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | NodeViewProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | NodeViewProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | NodeViewProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | NodeViewProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | NodeViewProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | NodeViewProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | NodeViewProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | NodeViewProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | NodeViewProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | NodeViewProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | NodeViewProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | NodeViewProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | NodeViewProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | NodeViewProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | NodeViewProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | NodeViewProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | NodeViewProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | NodeViewProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | NodeViewProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | NodeViewProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | NodeViewProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | NodeViewProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | NodeViewProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | NodeViewProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | NodeViewProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | NodeViewProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | NodeViewProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | NodeViewProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | NodeViewProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | NodeViewProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | NodeViewProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | NodeViewProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | NodeViewProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | NodeViewProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | NodeViewProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | NodeViewProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | NodeViewProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | NodeViewProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | NodeViewProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | NodeViewProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | NodeViewProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | NodeViewProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | NodeViewProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | NodeViewProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | NodeViewProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | NodeViewProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | NodeViewProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | NodeViewProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | NodeViewProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | NodeViewProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | NodeViewProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | NodeViewProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | NodeViewProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type NodeViewPropertyBuilder() =
    inherit BasePropertyBuilder<NodeViewProperty>()
    [<CustomOperation("model")>]
    member this.Model(it: NodeViewProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield NodeViewProperty.Model value } 
    [<CustomOperation("headersVisible")>]
    member this.HeadersVisible(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HeadersVisible value } 
    [<CustomOperation("headersClickable")>]
    member this.HeadersClickable(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HeadersClickable value } 
    [<CustomOperation("expanderColumn")>]
    member this.ExpanderColumn(it: NodeViewProperty seq, value: Gtk.TreeViewColumn) =
        seq { yield! it; yield NodeViewProperty.ExpanderColumn value } 
    [<CustomOperation("reorderable")>]
    member this.Reorderable(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.Reorderable value } 
    [<Obsolete>]
    [<CustomOperation("rulesHint")>]
    member this.RulesHint(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.RulesHint value } 
    [<CustomOperation("enableSearch")>]
    member this.EnableSearch(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.EnableSearch value } 
    [<CustomOperation("searchColumn")>]
    member this.SearchColumn(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.SearchColumn value } 
    [<CustomOperation("fixedHeightMode")>]
    member this.FixedHeightMode(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.FixedHeightMode value } 
    [<CustomOperation("hoverSelection")>]
    member this.HoverSelection(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HoverSelection value } 
    [<CustomOperation("hoverExpand")>]
    member this.HoverExpand(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HoverExpand value } 
    [<CustomOperation("showExpanders")>]
    member this.ShowExpanders(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.ShowExpanders value } 
    [<CustomOperation("levelIndentation")>]
    member this.LevelIndentation(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.LevelIndentation value } 
    [<CustomOperation("rubberBanding")>]
    member this.RubberBanding(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.RubberBanding value } 
    [<CustomOperation("enableGridLines")>]
    member this.EnableGridLines(it: NodeViewProperty seq, value: Gtk.TreeViewGridLines) =
        seq { yield! it; yield NodeViewProperty.EnableGridLines value } 
    [<CustomOperation("enableTreeLines")>]
    member this.EnableTreeLines(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.EnableTreeLines value } 
    [<CustomOperation("tooltipColumn")>]
    member this.TooltipColumn(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.TooltipColumn value } 
    [<CustomOperation("activateOnSingleClick")>]
    member this.ActivateOnSingleClick(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.ActivateOnSingleClick value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: NodeViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield NodeViewProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: NodeViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield NodeViewProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: NodeViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield NodeViewProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: NodeViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield NodeViewProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: NodeViewProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield NodeViewProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: NodeViewProperty seq, value: System.UInt32) =
        seq { yield! it; yield NodeViewProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: NodeViewProperty seq, value: System.String) =
        seq { yield! it; yield NodeViewProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: NodeViewProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield NodeViewProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: NodeViewProperty seq, value: Gtk.Style) =
        seq { yield! it; yield NodeViewProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: NodeViewProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield NodeViewProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: NodeViewProperty seq, value: System.String) =
        seq { yield! it; yield NodeViewProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: NodeViewProperty seq, value: System.String) =
        seq { yield! it; yield NodeViewProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: NodeViewProperty seq, value: Gdk.Window) =
        seq { yield! it; yield NodeViewProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: NodeViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield NodeViewProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: NodeViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield NodeViewProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: NodeViewProperty seq, value: System.Int32) =
        seq { yield! it; yield NodeViewProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: NodeViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield NodeViewProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: NodeViewProperty seq, value: System.Double) =
        seq { yield! it; yield NodeViewProperty.Opacity value } 
    [<CustomOperation("onRowExpanded")>]
    member this.OnRowExpanded(it: NodeViewProperty seq, value: Gtk.RowExpandedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnRowExpanded value } 
    [<CustomOperation("onRowActivated")>]
    member this.OnRowActivated(it: NodeViewProperty seq, value: Gtk.RowActivatedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnRowActivated value } 
    [<CustomOperation("onSelectAll")>]
    member this.OnSelectAll(it: NodeViewProperty seq, value: Gtk.SelectAllArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectAll value } 
    [<CustomOperation("onSelectCursorParent")>]
    member this.OnSelectCursorParent(it: NodeViewProperty seq, value: Gtk.SelectCursorParentArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectCursorParent value } 
    [<CustomOperation("onRowCollapsed")>]
    member this.OnRowCollapsed(it: NodeViewProperty seq, value: Gtk.RowCollapsedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnRowCollapsed value } 
    [<CustomOperation("onToggleCursorRow")>]
    member this.OnToggleCursorRow(it: NodeViewProperty seq, value: Gtk.ToggleCursorRowArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnToggleCursorRow value } 
    [<CustomOperation("onStartInteractiveSearch")>]
    member this.OnStartInteractiveSearch(it: NodeViewProperty seq, value: Gtk.StartInteractiveSearchArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnStartInteractiveSearch value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: NodeViewProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnMoveCursor value } 
    [<CustomOperation("onUnselectAll")>]
    member this.OnUnselectAll(it: NodeViewProperty seq, value: Gtk.UnselectAllArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnUnselectAll value } 
    [<CustomOperation("onTestExpandRow")>]
    member this.OnTestExpandRow(it: NodeViewProperty seq, value: Gtk.TestExpandRowArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnTestExpandRow value } 
    [<CustomOperation("onExpandCollapseCursorRow")>]
    member this.OnExpandCollapseCursorRow(it: NodeViewProperty seq, value: Gtk.ExpandCollapseCursorRowArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnExpandCollapseCursorRow value } 
    [<CustomOperation("onSelectCursorRow")>]
    member this.OnSelectCursorRow(it: NodeViewProperty seq, value: Gtk.SelectCursorRowArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectCursorRow value } 
    [<CustomOperation("onTestCollapseRow")>]
    member this.OnTestCollapseRow(it: NodeViewProperty seq, value: Gtk.TestCollapseRowArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnTestCollapseRow value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: NodeViewProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: NodeViewProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: NodeViewProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: NodeViewProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: NodeViewProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: NodeViewProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: NodeViewProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: NodeViewProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: NodeViewProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: NodeViewProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: NodeViewProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: NodeViewProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: NodeViewProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: NodeViewProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: NodeViewProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: NodeViewProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: NodeViewProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: NodeViewProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: NodeViewProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: NodeViewProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: NodeViewProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: NodeViewProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: NodeViewProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: NodeViewProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: NodeViewProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: NodeViewProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: NodeViewProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: NodeViewProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: NodeViewProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: NodeViewProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: NodeViewProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: NodeViewProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: NodeViewProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: NodeViewProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: NodeViewProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: NodeViewProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: NodeViewProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: NodeViewProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: NodeViewProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: NodeViewProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: NodeViewProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: NodeViewProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: NodeViewProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: NodeViewProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: NodeViewProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: NodeViewProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: NodeViewProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: NodeViewProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: NodeViewProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: NodeViewProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: NodeViewProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: NodeViewProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: NodeViewProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: NodeViewProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: NodeViewProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: NodeViewProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: NodeViewProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: NodeViewProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: NodeViewProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: NodeViewProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield NodeViewProperty.OnFocused value } 

let prop = NodeViewPropertyBuilder()

type NodeViewDescriptor(props) =
    inherit BaseWidgetDescriptor<NodeView, NodeViewProperty>(props, bindProperty)
    override this.CreateTyped() = new NodeView()

let nodeView props = NodeViewDescriptor(props)

