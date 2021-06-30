module GtkDsl.Binding.IconView
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type IconViewProperty =
    | SelectionMode of Gtk.SelectionMode
    | PixbufColumn of System.Int32
    | TextColumn of System.Int32
    | MarkupColumn of System.Int32
    | Model of Gtk.ITreeModel
    | Columns of System.Int32
    | ItemWidth of System.Int32
    | Spacing of System.Int32
    | RowSpacing of System.Int32
    | ColumnSpacing of System.Int32
    | Margin of System.Int32
    | ItemOrientation of Gtk.Orientation
    | Reorderable of System.Boolean
    | TooltipColumn of System.Int32
    | ItemPadding of System.Int32
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
    | Hexpand of System.Boolean
    | HexpandSet of System.Boolean
    | Vexpand of System.Boolean
    | VexpandSet of System.Boolean
    | Expand of System.Boolean
    | Opacity of System.Double
    |  OnItemActivated of (Gtk.ItemActivatedArgs -> unit)
    |  OnMoveCursor of (Gtk.MoveCursorArgs -> unit)
    |  OnActivateCursorItem of (Gtk.ActivateCursorItemArgs -> unit)
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

let bindProperty (widget: IconView) (prop: IconViewProperty) =
    match prop with
    | IconViewProperty.SelectionMode value -> widget.SelectionMode <- value
    | IconViewProperty.PixbufColumn value -> widget.PixbufColumn <- value
    | IconViewProperty.TextColumn value -> widget.TextColumn <- value
    | IconViewProperty.MarkupColumn value -> widget.MarkupColumn <- value
    | IconViewProperty.Model value -> widget.Model <- value
    | IconViewProperty.Columns value -> widget.Columns <- value
    | IconViewProperty.ItemWidth value -> widget.ItemWidth <- value
    | IconViewProperty.Spacing value -> widget.Spacing <- value
    | IconViewProperty.RowSpacing value -> widget.RowSpacing <- value
    | IconViewProperty.ColumnSpacing value -> widget.ColumnSpacing <- value
    | IconViewProperty.Margin value -> widget.Margin <- value
    | IconViewProperty.ItemOrientation value -> widget.ItemOrientation <- value
    | IconViewProperty.Reorderable value -> widget.Reorderable <- value
    | IconViewProperty.TooltipColumn value -> widget.TooltipColumn <- value
    | IconViewProperty.ItemPadding value -> widget.ItemPadding <- value
    | IconViewProperty.ActivateOnSingleClick value -> widget.ActivateOnSingleClick <- value
    | IconViewProperty.Hadjustment value -> widget.Hadjustment <- value
    | IconViewProperty.Vadjustment value -> widget.Vadjustment <- value
    | IconViewProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | IconViewProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | IconViewProperty.ResizeMode value -> widget.ResizeMode <- value
    | IconViewProperty.BorderWidth value -> widget.BorderWidth <- value
    | IconViewProperty.Name value -> widget.Name <- value
    | IconViewProperty.Parent value -> widget.Parent <- value
    | IconViewProperty.WidthRequest value -> widget.WidthRequest <- value
    | IconViewProperty.HeightRequest value -> widget.HeightRequest <- value
    | IconViewProperty.Visible value -> widget.Visible <- value
    | IconViewProperty.Sensitive value -> widget.Sensitive <- value
    | IconViewProperty.AppPaintable value -> widget.AppPaintable <- value
    | IconViewProperty.CanFocus value -> widget.CanFocus <- value
    | IconViewProperty.HasFocus value -> widget.HasFocus <- value
    | IconViewProperty.IsFocus value -> widget.IsFocus <- value
    | IconViewProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | IconViewProperty.CanDefault value -> widget.CanDefault <- value
    | IconViewProperty.HasDefault value -> widget.HasDefault <- value
    | IconViewProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | IconViewProperty.Style value -> widget.Style <- value
    | IconViewProperty.Events value -> widget.Events <- value
    | IconViewProperty.NoShowAll value -> widget.NoShowAll <- value
    | IconViewProperty.HasTooltip value -> widget.HasTooltip <- value
    | IconViewProperty.TooltipText value -> widget.TooltipText <- value
    | IconViewProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | IconViewProperty.Window value -> widget.Window <- value
    | IconViewProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | IconViewProperty.Halign value -> widget.Halign <- value
    | IconViewProperty.Valign value -> widget.Valign <- value
    | IconViewProperty.MarginLeft value -> widget.MarginLeft <- value
    | IconViewProperty.MarginRight value -> widget.MarginRight <- value
    | IconViewProperty.MarginStart value -> widget.MarginStart <- value
    | IconViewProperty.MarginEnd value -> widget.MarginEnd <- value
    | IconViewProperty.MarginTop value -> widget.MarginTop <- value
    | IconViewProperty.MarginBottom value -> widget.MarginBottom <- value
    | IconViewProperty.Hexpand value -> widget.Hexpand <- value
    | IconViewProperty.HexpandSet value -> widget.HexpandSet <- value
    | IconViewProperty.Vexpand value -> widget.Vexpand <- value
    | IconViewProperty.VexpandSet value -> widget.VexpandSet <- value
    | IconViewProperty.Expand value -> widget.Expand <- value
    | IconViewProperty.Opacity value -> widget.Opacity <- value
    | IconViewProperty.OnItemActivated handler -> 
        let disposable = widget.ItemActivated.Subscribe(handler)
        registerListener widget "ItemActivated" disposable
    | IconViewProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | IconViewProperty.OnActivateCursorItem handler -> 
        let disposable = widget.ActivateCursorItem.Subscribe(handler)
        registerListener widget "ActivateCursorItem" disposable
    | IconViewProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | IconViewProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | IconViewProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | IconViewProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | IconViewProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | IconViewProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | IconViewProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | IconViewProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | IconViewProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | IconViewProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | IconViewProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | IconViewProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | IconViewProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | IconViewProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | IconViewProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | IconViewProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | IconViewProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | IconViewProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | IconViewProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | IconViewProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | IconViewProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | IconViewProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | IconViewProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | IconViewProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | IconViewProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | IconViewProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | IconViewProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | IconViewProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | IconViewProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | IconViewProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | IconViewProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | IconViewProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | IconViewProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | IconViewProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | IconViewProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | IconViewProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | IconViewProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | IconViewProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | IconViewProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | IconViewProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | IconViewProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | IconViewProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | IconViewProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | IconViewProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | IconViewProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | IconViewProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | IconViewProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | IconViewProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | IconViewProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | IconViewProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | IconViewProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | IconViewProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | IconViewProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | IconViewProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | IconViewProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | IconViewProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | IconViewProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | IconViewProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | IconViewProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | IconViewProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type IconViewPropertyBuilder() =
    inherit BasePropertyBuilder<IconViewProperty>()
    [<CustomOperation("selectionMode")>]
    member this.SelectionMode(it: IconViewProperty seq, value: Gtk.SelectionMode) =
        seq { yield! it; yield IconViewProperty.SelectionMode value } 
    [<CustomOperation("pixbufColumn")>]
    member this.PixbufColumn(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.PixbufColumn value } 
    [<CustomOperation("textColumn")>]
    member this.TextColumn(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.TextColumn value } 
    [<CustomOperation("markupColumn")>]
    member this.MarkupColumn(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarkupColumn value } 
    [<CustomOperation("model")>]
    member this.Model(it: IconViewProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield IconViewProperty.Model value } 
    [<CustomOperation("columns")>]
    member this.Columns(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.Columns value } 
    [<CustomOperation("itemWidth")>]
    member this.ItemWidth(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.ItemWidth value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.Spacing value } 
    [<CustomOperation("rowSpacing")>]
    member this.RowSpacing(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.RowSpacing value } 
    [<CustomOperation("columnSpacing")>]
    member this.ColumnSpacing(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.ColumnSpacing value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.Margin value } 
    [<CustomOperation("itemOrientation")>]
    member this.ItemOrientation(it: IconViewProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield IconViewProperty.ItemOrientation value } 
    [<CustomOperation("reorderable")>]
    member this.Reorderable(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.Reorderable value } 
    [<CustomOperation("tooltipColumn")>]
    member this.TooltipColumn(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.TooltipColumn value } 
    [<CustomOperation("itemPadding")>]
    member this.ItemPadding(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.ItemPadding value } 
    [<CustomOperation("activateOnSingleClick")>]
    member this.ActivateOnSingleClick(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.ActivateOnSingleClick value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: IconViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield IconViewProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: IconViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield IconViewProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: IconViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield IconViewProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: IconViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield IconViewProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: IconViewProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield IconViewProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: IconViewProperty seq, value: System.UInt32) =
        seq { yield! it; yield IconViewProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: IconViewProperty seq, value: System.String) =
        seq { yield! it; yield IconViewProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: IconViewProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield IconViewProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: IconViewProperty seq, value: Gtk.Style) =
        seq { yield! it; yield IconViewProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: IconViewProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield IconViewProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: IconViewProperty seq, value: System.String) =
        seq { yield! it; yield IconViewProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: IconViewProperty seq, value: System.String) =
        seq { yield! it; yield IconViewProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: IconViewProperty seq, value: Gdk.Window) =
        seq { yield! it; yield IconViewProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: IconViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield IconViewProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: IconViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield IconViewProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: IconViewProperty seq, value: System.Int32) =
        seq { yield! it; yield IconViewProperty.MarginBottom value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: IconViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield IconViewProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: IconViewProperty seq, value: System.Double) =
        seq { yield! it; yield IconViewProperty.Opacity value } 
    [<CustomOperation("onItemActivated")>]
    member this.OnItemActivated(it: IconViewProperty seq, value: Gtk.ItemActivatedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnItemActivated value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: IconViewProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnMoveCursor value } 
    [<CustomOperation("onActivateCursorItem")>]
    member this.OnActivateCursorItem(it: IconViewProperty seq, value: Gtk.ActivateCursorItemArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnActivateCursorItem value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: IconViewProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: IconViewProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: IconViewProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: IconViewProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: IconViewProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: IconViewProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: IconViewProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: IconViewProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: IconViewProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: IconViewProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: IconViewProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: IconViewProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: IconViewProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: IconViewProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: IconViewProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: IconViewProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: IconViewProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: IconViewProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: IconViewProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: IconViewProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: IconViewProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: IconViewProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: IconViewProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: IconViewProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: IconViewProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: IconViewProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: IconViewProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: IconViewProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: IconViewProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: IconViewProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: IconViewProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: IconViewProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: IconViewProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: IconViewProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: IconViewProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: IconViewProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: IconViewProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: IconViewProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: IconViewProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: IconViewProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: IconViewProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: IconViewProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: IconViewProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: IconViewProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: IconViewProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: IconViewProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: IconViewProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: IconViewProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: IconViewProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: IconViewProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: IconViewProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: IconViewProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: IconViewProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: IconViewProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: IconViewProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: IconViewProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: IconViewProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: IconViewProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: IconViewProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: IconViewProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield IconViewProperty.OnFocused value } 

let prop = IconViewPropertyBuilder()

type IconViewDescriptor(props) =
    inherit BaseWidgetDescriptor<IconView, IconViewProperty>(props, bindProperty)
    override this.CreateTyped() = new IconView()

let iconView props = IconViewDescriptor(props)

