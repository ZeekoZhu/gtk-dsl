module GtkDsl.Binding.TextView
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type TextViewProperty =
    | PixelsAboveLines of System.Int32
    | PixelsBelowLines of System.Int32
    | PixelsInsideWrap of System.Int32
    | Editable of System.Boolean
    | WrapMode of Gtk.WrapMode
    | Justification of Gtk.Justification
    | LeftMargin of System.Int32
    | RightMargin of System.Int32
    | TopMargin of System.Int32
    | BottomMargin of System.Int32
    | Indent of System.Int32
    | Tabs of Pango.TabArray
    | CursorVisible of System.Boolean
    | Buffer of Gtk.TextBuffer
    | Overwrite of System.Boolean
    | AcceptsTab of System.Boolean
    | ImModule of System.String
    | InputPurpose of Gtk.InputPurpose
    | InputHints of Gtk.InputHints
    | PopulateAll of System.Boolean
    | Monospace of System.Boolean
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
    |  OnSelectAll of (Gtk.SelectAllArgs -> unit)
    |  OnDeleteFromCursor of (Gtk.DeleteFromCursorArgs -> unit)
    |  OnMoveCursor of (Gtk.MoveCursorArgs -> unit)
    |  OnPreeditChanged of (Gtk.PreeditChangedArgs -> unit)
    |  OnMoveViewport of (Gtk.MoveViewportArgs -> unit)
    |  OnInsertAtCursor of (Gtk.InsertAtCursorArgs -> unit)
    |  OnPopulatePopup of (Gtk.PopulatePopupArgs -> unit)
    |  OnExtendSelection of (Gtk.ExtendSelectionArgs -> unit)
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

let bindProperty (widget: TextView) (prop: TextViewProperty) =
    match prop with
    | TextViewProperty.PixelsAboveLines value -> widget.PixelsAboveLines <- value
    | TextViewProperty.PixelsBelowLines value -> widget.PixelsBelowLines <- value
    | TextViewProperty.PixelsInsideWrap value -> widget.PixelsInsideWrap <- value
    | TextViewProperty.Editable value -> widget.Editable <- value
    | TextViewProperty.WrapMode value -> widget.WrapMode <- value
    | TextViewProperty.Justification value -> widget.Justification <- value
    | TextViewProperty.LeftMargin value -> widget.LeftMargin <- value
    | TextViewProperty.RightMargin value -> widget.RightMargin <- value
    | TextViewProperty.TopMargin value -> widget.TopMargin <- value
    | TextViewProperty.BottomMargin value -> widget.BottomMargin <- value
    | TextViewProperty.Indent value -> widget.Indent <- value
    | TextViewProperty.Tabs value -> widget.Tabs <- value
    | TextViewProperty.CursorVisible value -> widget.CursorVisible <- value
    | TextViewProperty.Buffer value -> widget.Buffer <- value
    | TextViewProperty.Overwrite value -> widget.Overwrite <- value
    | TextViewProperty.AcceptsTab value -> widget.AcceptsTab <- value
    | TextViewProperty.ImModule value -> widget.ImModule <- value
    | TextViewProperty.InputPurpose value -> widget.InputPurpose <- value
    | TextViewProperty.InputHints value -> widget.InputHints <- value
    | TextViewProperty.PopulateAll value -> widget.PopulateAll <- value
    | TextViewProperty.Monospace value -> widget.Monospace <- value
    | TextViewProperty.Hadjustment value -> widget.Hadjustment <- value
    | TextViewProperty.Vadjustment value -> widget.Vadjustment <- value
    | TextViewProperty.HscrollPolicy value -> widget.HscrollPolicy <- value
    | TextViewProperty.VscrollPolicy value -> widget.VscrollPolicy <- value
    | TextViewProperty.ResizeMode value -> widget.ResizeMode <- value
    | TextViewProperty.BorderWidth value -> widget.BorderWidth <- value
    | TextViewProperty.Name value -> widget.Name <- value
    | TextViewProperty.Parent value -> widget.Parent <- value
    | TextViewProperty.WidthRequest value -> widget.WidthRequest <- value
    | TextViewProperty.HeightRequest value -> widget.HeightRequest <- value
    | TextViewProperty.Visible value -> widget.Visible <- value
    | TextViewProperty.Sensitive value -> widget.Sensitive <- value
    | TextViewProperty.AppPaintable value -> widget.AppPaintable <- value
    | TextViewProperty.CanFocus value -> widget.CanFocus <- value
    | TextViewProperty.HasFocus value -> widget.HasFocus <- value
    | TextViewProperty.IsFocus value -> widget.IsFocus <- value
    | TextViewProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | TextViewProperty.CanDefault value -> widget.CanDefault <- value
    | TextViewProperty.HasDefault value -> widget.HasDefault <- value
    | TextViewProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | TextViewProperty.Style value -> widget.Style <- value
    | TextViewProperty.Events value -> widget.Events <- value
    | TextViewProperty.NoShowAll value -> widget.NoShowAll <- value
    | TextViewProperty.HasTooltip value -> widget.HasTooltip <- value
    | TextViewProperty.TooltipText value -> widget.TooltipText <- value
    | TextViewProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | TextViewProperty.Window value -> widget.Window <- value
    | TextViewProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | TextViewProperty.Halign value -> widget.Halign <- value
    | TextViewProperty.Valign value -> widget.Valign <- value
    | TextViewProperty.MarginLeft value -> widget.MarginLeft <- value
    | TextViewProperty.MarginRight value -> widget.MarginRight <- value
    | TextViewProperty.MarginStart value -> widget.MarginStart <- value
    | TextViewProperty.MarginEnd value -> widget.MarginEnd <- value
    | TextViewProperty.MarginTop value -> widget.MarginTop <- value
    | TextViewProperty.MarginBottom value -> widget.MarginBottom <- value
    | TextViewProperty.Margin value -> widget.Margin <- value
    | TextViewProperty.Hexpand value -> widget.Hexpand <- value
    | TextViewProperty.HexpandSet value -> widget.HexpandSet <- value
    | TextViewProperty.Vexpand value -> widget.Vexpand <- value
    | TextViewProperty.VexpandSet value -> widget.VexpandSet <- value
    | TextViewProperty.Expand value -> widget.Expand <- value
    | TextViewProperty.Opacity value -> widget.Opacity <- value
    | TextViewProperty.OnSelectAll handler -> 
        let disposable = widget.SelectAll.Subscribe(handler)
        registerListener widget "SelectAll" disposable
    | TextViewProperty.OnDeleteFromCursor handler -> 
        let disposable = widget.DeleteFromCursor.Subscribe(handler)
        registerListener widget "DeleteFromCursor" disposable
    | TextViewProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | TextViewProperty.OnPreeditChanged handler -> 
        let disposable = widget.PreeditChanged.Subscribe(handler)
        registerListener widget "PreeditChanged" disposable
    | TextViewProperty.OnMoveViewport handler -> 
        let disposable = widget.MoveViewport.Subscribe(handler)
        registerListener widget "MoveViewport" disposable
    | TextViewProperty.OnInsertAtCursor handler -> 
        let disposable = widget.InsertAtCursor.Subscribe(handler)
        registerListener widget "InsertAtCursor" disposable
    | TextViewProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | TextViewProperty.OnExtendSelection handler -> 
        let disposable = widget.ExtendSelection.Subscribe(handler)
        registerListener widget "ExtendSelection" disposable
    | TextViewProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | TextViewProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | TextViewProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | TextViewProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | TextViewProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | TextViewProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | TextViewProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | TextViewProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | TextViewProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | TextViewProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | TextViewProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | TextViewProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | TextViewProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | TextViewProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | TextViewProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | TextViewProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | TextViewProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | TextViewProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | TextViewProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | TextViewProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | TextViewProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | TextViewProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | TextViewProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | TextViewProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | TextViewProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | TextViewProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | TextViewProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | TextViewProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | TextViewProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | TextViewProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | TextViewProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | TextViewProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | TextViewProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | TextViewProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | TextViewProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | TextViewProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | TextViewProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | TextViewProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | TextViewProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | TextViewProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | TextViewProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | TextViewProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | TextViewProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | TextViewProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | TextViewProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | TextViewProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | TextViewProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | TextViewProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | TextViewProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | TextViewProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | TextViewProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | TextViewProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | TextViewProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | TextViewProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | TextViewProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | TextViewProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | TextViewProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | TextViewProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | TextViewProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | TextViewProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type TextViewPropertyBuilder() =
    inherit BasePropertyBuilder<TextViewProperty>()
    [<CustomOperation("pixelsAboveLines")>]
    member this.PixelsAboveLines(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.PixelsAboveLines value } 
    [<CustomOperation("pixelsBelowLines")>]
    member this.PixelsBelowLines(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.PixelsBelowLines value } 
    [<CustomOperation("pixelsInsideWrap")>]
    member this.PixelsInsideWrap(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.PixelsInsideWrap value } 
    [<CustomOperation("editable")>]
    member this.Editable(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Editable value } 
    [<CustomOperation("wrapMode")>]
    member this.WrapMode(it: TextViewProperty seq, value: Gtk.WrapMode) =
        seq { yield! it; yield TextViewProperty.WrapMode value } 
    [<CustomOperation("justification")>]
    member this.Justification(it: TextViewProperty seq, value: Gtk.Justification) =
        seq { yield! it; yield TextViewProperty.Justification value } 
    [<CustomOperation("leftMargin")>]
    member this.LeftMargin(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.LeftMargin value } 
    [<CustomOperation("rightMargin")>]
    member this.RightMargin(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.RightMargin value } 
    [<CustomOperation("topMargin")>]
    member this.TopMargin(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.TopMargin value } 
    [<CustomOperation("bottomMargin")>]
    member this.BottomMargin(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.BottomMargin value } 
    [<CustomOperation("indent")>]
    member this.Indent(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.Indent value } 
    [<CustomOperation("tabs")>]
    member this.Tabs(it: TextViewProperty seq, value: Pango.TabArray) =
        seq { yield! it; yield TextViewProperty.Tabs value } 
    [<CustomOperation("cursorVisible")>]
    member this.CursorVisible(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.CursorVisible value } 
    [<CustomOperation("buffer")>]
    member this.Buffer(it: TextViewProperty seq, value: Gtk.TextBuffer) =
        seq { yield! it; yield TextViewProperty.Buffer value } 
    [<CustomOperation("overwrite")>]
    member this.Overwrite(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Overwrite value } 
    [<CustomOperation("acceptsTab")>]
    member this.AcceptsTab(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.AcceptsTab value } 
    [<CustomOperation("imModule")>]
    member this.ImModule(it: TextViewProperty seq, value: System.String) =
        seq { yield! it; yield TextViewProperty.ImModule value } 
    [<CustomOperation("inputPurpose")>]
    member this.InputPurpose(it: TextViewProperty seq, value: Gtk.InputPurpose) =
        seq { yield! it; yield TextViewProperty.InputPurpose value } 
    [<CustomOperation("inputHints")>]
    member this.InputHints(it: TextViewProperty seq, value: Gtk.InputHints) =
        seq { yield! it; yield TextViewProperty.InputHints value } 
    [<CustomOperation("populateAll")>]
    member this.PopulateAll(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.PopulateAll value } 
    [<CustomOperation("monospace")>]
    member this.Monospace(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Monospace value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: TextViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield TextViewProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: TextViewProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield TextViewProperty.Vadjustment value } 
    [<CustomOperation("hscrollPolicy")>]
    member this.HscrollPolicy(it: TextViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield TextViewProperty.HscrollPolicy value } 
    [<CustomOperation("vscrollPolicy")>]
    member this.VscrollPolicy(it: TextViewProperty seq, value: Gtk.ScrollablePolicy) =
        seq { yield! it; yield TextViewProperty.VscrollPolicy value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: TextViewProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield TextViewProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: TextViewProperty seq, value: System.UInt32) =
        seq { yield! it; yield TextViewProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: TextViewProperty seq, value: System.String) =
        seq { yield! it; yield TextViewProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: TextViewProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TextViewProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: TextViewProperty seq, value: Gtk.Style) =
        seq { yield! it; yield TextViewProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: TextViewProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield TextViewProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: TextViewProperty seq, value: System.String) =
        seq { yield! it; yield TextViewProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: TextViewProperty seq, value: System.String) =
        seq { yield! it; yield TextViewProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: TextViewProperty seq, value: Gdk.Window) =
        seq { yield! it; yield TextViewProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: TextViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TextViewProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: TextViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TextViewProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: TextViewProperty seq, value: System.Int32) =
        seq { yield! it; yield TextViewProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: TextViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield TextViewProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: TextViewProperty seq, value: System.Double) =
        seq { yield! it; yield TextViewProperty.Opacity value } 
    [<CustomOperation("onSelectAll")>]
    member this.OnSelectAll(it: TextViewProperty seq, value: Gtk.SelectAllArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSelectAll value } 
    [<CustomOperation("onDeleteFromCursor")>]
    member this.OnDeleteFromCursor(it: TextViewProperty seq, value: Gtk.DeleteFromCursorArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDeleteFromCursor value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: TextViewProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnMoveCursor value } 
    [<CustomOperation("onPreeditChanged")>]
    member this.OnPreeditChanged(it: TextViewProperty seq, value: Gtk.PreeditChangedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnPreeditChanged value } 
    [<CustomOperation("onMoveViewport")>]
    member this.OnMoveViewport(it: TextViewProperty seq, value: Gtk.MoveViewportArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnMoveViewport value } 
    [<CustomOperation("onInsertAtCursor")>]
    member this.OnInsertAtCursor(it: TextViewProperty seq, value: Gtk.InsertAtCursorArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnInsertAtCursor value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: TextViewProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnPopulatePopup value } 
    [<CustomOperation("onExtendSelection")>]
    member this.OnExtendSelection(it: TextViewProperty seq, value: Gtk.ExtendSelectionArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnExtendSelection value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: TextViewProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: TextViewProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: TextViewProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: TextViewProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: TextViewProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: TextViewProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: TextViewProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: TextViewProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: TextViewProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: TextViewProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: TextViewProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: TextViewProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: TextViewProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: TextViewProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: TextViewProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: TextViewProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: TextViewProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: TextViewProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: TextViewProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: TextViewProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: TextViewProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: TextViewProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: TextViewProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: TextViewProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: TextViewProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: TextViewProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: TextViewProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: TextViewProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: TextViewProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: TextViewProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: TextViewProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: TextViewProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: TextViewProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: TextViewProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: TextViewProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: TextViewProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: TextViewProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: TextViewProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: TextViewProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: TextViewProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: TextViewProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: TextViewProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: TextViewProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: TextViewProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: TextViewProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: TextViewProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: TextViewProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: TextViewProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: TextViewProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: TextViewProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: TextViewProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: TextViewProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: TextViewProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: TextViewProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: TextViewProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: TextViewProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: TextViewProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: TextViewProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: TextViewProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: TextViewProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield TextViewProperty.OnFocused value } 

let prop = TextViewPropertyBuilder()

type TextViewDescriptor(props) =
    inherit BaseWidgetDescriptor<TextView, TextViewProperty>(props, bindProperty)
    override this.CreateTyped() = new TextView()

let textView props = TextViewDescriptor(props)

