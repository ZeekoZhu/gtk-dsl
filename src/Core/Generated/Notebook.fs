module GtkDsl.Binding.Notebook
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type NotebookProperty =
    | Page of System.Int32
    | TabPos of Gtk.PositionType
    | ShowTabs of System.Boolean
    | ShowBorder of System.Boolean
    | Scrollable of System.Boolean
    | EnablePopup of System.Boolean
    | GroupName of System.String
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
    |  OnReorderTab of (Gtk.ReorderTabArgs -> unit)
    |  OnChangeCurrentPage of (Gtk.ChangeCurrentPageArgs -> unit)
    |  OnSelectPage of (Gtk.SelectPageArgs -> unit)
    |  OnSwitchPage of (Gtk.SwitchPageArgs -> unit)
    |  OnFocusTab of (Gtk.FocusTabArgs -> unit)
    |  OnMoveFocusOut of (Gtk.MoveFocusOutArgs -> unit)
    |  OnPageAdded of (Gtk.PageAddedArgs -> unit)
    |  OnPageReordered of (Gtk.PageReorderedArgs -> unit)
    |  OnCreateWindow of (Gtk.CreateWindowArgs -> unit)
    |  OnPageRemoved of (Gtk.PageRemovedArgs -> unit)
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

let bindProperty (widget: Notebook) (prop: NotebookProperty) =
    match prop with
    | NotebookProperty.Page value -> widget.Page <- value
    | NotebookProperty.TabPos value -> widget.TabPos <- value
    | NotebookProperty.ShowTabs value -> widget.ShowTabs <- value
    | NotebookProperty.ShowBorder value -> widget.ShowBorder <- value
    | NotebookProperty.Scrollable value -> widget.Scrollable <- value
    | NotebookProperty.EnablePopup value -> widget.EnablePopup <- value
    | NotebookProperty.GroupName value -> widget.GroupName <- value
    | NotebookProperty.ResizeMode value -> widget.ResizeMode <- value
    | NotebookProperty.BorderWidth value -> widget.BorderWidth <- value
    | NotebookProperty.Name value -> widget.Name <- value
    | NotebookProperty.Parent value -> widget.Parent <- value
    | NotebookProperty.WidthRequest value -> widget.WidthRequest <- value
    | NotebookProperty.HeightRequest value -> widget.HeightRequest <- value
    | NotebookProperty.Visible value -> widget.Visible <- value
    | NotebookProperty.Sensitive value -> widget.Sensitive <- value
    | NotebookProperty.AppPaintable value -> widget.AppPaintable <- value
    | NotebookProperty.CanFocus value -> widget.CanFocus <- value
    | NotebookProperty.HasFocus value -> widget.HasFocus <- value
    | NotebookProperty.IsFocus value -> widget.IsFocus <- value
    | NotebookProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | NotebookProperty.CanDefault value -> widget.CanDefault <- value
    | NotebookProperty.HasDefault value -> widget.HasDefault <- value
    | NotebookProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | NotebookProperty.Style value -> widget.Style <- value
    | NotebookProperty.Events value -> widget.Events <- value
    | NotebookProperty.NoShowAll value -> widget.NoShowAll <- value
    | NotebookProperty.HasTooltip value -> widget.HasTooltip <- value
    | NotebookProperty.TooltipText value -> widget.TooltipText <- value
    | NotebookProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | NotebookProperty.Window value -> widget.Window <- value
    | NotebookProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | NotebookProperty.Halign value -> widget.Halign <- value
    | NotebookProperty.Valign value -> widget.Valign <- value
    | NotebookProperty.MarginLeft value -> widget.MarginLeft <- value
    | NotebookProperty.MarginRight value -> widget.MarginRight <- value
    | NotebookProperty.MarginStart value -> widget.MarginStart <- value
    | NotebookProperty.MarginEnd value -> widget.MarginEnd <- value
    | NotebookProperty.MarginTop value -> widget.MarginTop <- value
    | NotebookProperty.MarginBottom value -> widget.MarginBottom <- value
    | NotebookProperty.Margin value -> widget.Margin <- value
    | NotebookProperty.Hexpand value -> widget.Hexpand <- value
    | NotebookProperty.HexpandSet value -> widget.HexpandSet <- value
    | NotebookProperty.Vexpand value -> widget.Vexpand <- value
    | NotebookProperty.VexpandSet value -> widget.VexpandSet <- value
    | NotebookProperty.Expand value -> widget.Expand <- value
    | NotebookProperty.Opacity value -> widget.Opacity <- value
    | NotebookProperty.OnReorderTab handler -> 
        let disposable = widget.ReorderTab.Subscribe(handler)
        registerListener widget "ReorderTab" disposable
    | NotebookProperty.OnChangeCurrentPage handler -> 
        let disposable = widget.ChangeCurrentPage.Subscribe(handler)
        registerListener widget "ChangeCurrentPage" disposable
    | NotebookProperty.OnSelectPage handler -> 
        let disposable = widget.SelectPage.Subscribe(handler)
        registerListener widget "SelectPage" disposable
    | NotebookProperty.OnSwitchPage handler -> 
        let disposable = widget.SwitchPage.Subscribe(handler)
        registerListener widget "SwitchPage" disposable
    | NotebookProperty.OnFocusTab handler -> 
        let disposable = widget.FocusTab.Subscribe(handler)
        registerListener widget "FocusTab" disposable
    | NotebookProperty.OnMoveFocusOut handler -> 
        let disposable = widget.MoveFocusOut.Subscribe(handler)
        registerListener widget "MoveFocusOut" disposable
    | NotebookProperty.OnPageAdded handler -> 
        let disposable = widget.PageAdded.Subscribe(handler)
        registerListener widget "PageAdded" disposable
    | NotebookProperty.OnPageReordered handler -> 
        let disposable = widget.PageReordered.Subscribe(handler)
        registerListener widget "PageReordered" disposable
    | NotebookProperty.OnCreateWindow handler -> 
        let disposable = widget.CreateWindow.Subscribe(handler)
        registerListener widget "CreateWindow" disposable
    | NotebookProperty.OnPageRemoved handler -> 
        let disposable = widget.PageRemoved.Subscribe(handler)
        registerListener widget "PageRemoved" disposable
    | NotebookProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | NotebookProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | NotebookProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | NotebookProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | NotebookProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | NotebookProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | NotebookProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | NotebookProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | NotebookProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | NotebookProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | NotebookProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | NotebookProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | NotebookProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | NotebookProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | NotebookProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | NotebookProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | NotebookProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | NotebookProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | NotebookProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | NotebookProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | NotebookProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | NotebookProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | NotebookProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | NotebookProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | NotebookProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | NotebookProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | NotebookProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | NotebookProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | NotebookProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | NotebookProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | NotebookProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | NotebookProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | NotebookProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | NotebookProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | NotebookProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | NotebookProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | NotebookProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | NotebookProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | NotebookProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | NotebookProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | NotebookProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | NotebookProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | NotebookProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | NotebookProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | NotebookProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | NotebookProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | NotebookProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | NotebookProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | NotebookProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | NotebookProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | NotebookProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | NotebookProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | NotebookProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | NotebookProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | NotebookProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | NotebookProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | NotebookProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | NotebookProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | NotebookProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | NotebookProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type NotebookPropertyBuilder() =
    inherit BasePropertyBuilder<NotebookProperty>()
    [<CustomOperation("page")>]
    member this.Page(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.Page value } 
    [<CustomOperation("tabPos")>]
    member this.TabPos(it: NotebookProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield NotebookProperty.TabPos value } 
    [<CustomOperation("showTabs")>]
    member this.ShowTabs(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.ShowTabs value } 
    [<CustomOperation("showBorder")>]
    member this.ShowBorder(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.ShowBorder value } 
    [<CustomOperation("scrollable")>]
    member this.Scrollable(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.Scrollable value } 
    [<CustomOperation("enablePopup")>]
    member this.EnablePopup(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.EnablePopup value } 
    [<CustomOperation("groupName")>]
    member this.GroupName(it: NotebookProperty seq, value: System.String) =
        seq { yield! it; yield NotebookProperty.GroupName value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: NotebookProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield NotebookProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: NotebookProperty seq, value: System.UInt32) =
        seq { yield! it; yield NotebookProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: NotebookProperty seq, value: System.String) =
        seq { yield! it; yield NotebookProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: NotebookProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield NotebookProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: NotebookProperty seq, value: Gtk.Style) =
        seq { yield! it; yield NotebookProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: NotebookProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield NotebookProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: NotebookProperty seq, value: System.String) =
        seq { yield! it; yield NotebookProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: NotebookProperty seq, value: System.String) =
        seq { yield! it; yield NotebookProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: NotebookProperty seq, value: Gdk.Window) =
        seq { yield! it; yield NotebookProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: NotebookProperty seq, value: Gtk.Align) =
        seq { yield! it; yield NotebookProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: NotebookProperty seq, value: Gtk.Align) =
        seq { yield! it; yield NotebookProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: NotebookProperty seq, value: System.Int32) =
        seq { yield! it; yield NotebookProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: NotebookProperty seq, value: System.Boolean) =
        seq { yield! it; yield NotebookProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: NotebookProperty seq, value: System.Double) =
        seq { yield! it; yield NotebookProperty.Opacity value } 
    [<CustomOperation("onReorderTab")>]
    member this.OnReorderTab(it: NotebookProperty seq, value: Gtk.ReorderTabArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnReorderTab value } 
    [<CustomOperation("onChangeCurrentPage")>]
    member this.OnChangeCurrentPage(it: NotebookProperty seq, value: Gtk.ChangeCurrentPageArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnChangeCurrentPage value } 
    [<CustomOperation("onSelectPage")>]
    member this.OnSelectPage(it: NotebookProperty seq, value: Gtk.SelectPageArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSelectPage value } 
    [<CustomOperation("onSwitchPage")>]
    member this.OnSwitchPage(it: NotebookProperty seq, value: Gtk.SwitchPageArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSwitchPage value } 
    [<CustomOperation("onFocusTab")>]
    member this.OnFocusTab(it: NotebookProperty seq, value: Gtk.FocusTabArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnFocusTab value } 
    [<CustomOperation("onMoveFocusOut")>]
    member this.OnMoveFocusOut(it: NotebookProperty seq, value: Gtk.MoveFocusOutArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnMoveFocusOut value } 
    [<CustomOperation("onPageAdded")>]
    member this.OnPageAdded(it: NotebookProperty seq, value: Gtk.PageAddedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnPageAdded value } 
    [<CustomOperation("onPageReordered")>]
    member this.OnPageReordered(it: NotebookProperty seq, value: Gtk.PageReorderedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnPageReordered value } 
    [<CustomOperation("onCreateWindow")>]
    member this.OnCreateWindow(it: NotebookProperty seq, value: Gtk.CreateWindowArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnCreateWindow value } 
    [<CustomOperation("onPageRemoved")>]
    member this.OnPageRemoved(it: NotebookProperty seq, value: Gtk.PageRemovedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnPageRemoved value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: NotebookProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: NotebookProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: NotebookProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: NotebookProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: NotebookProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: NotebookProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: NotebookProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: NotebookProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: NotebookProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: NotebookProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: NotebookProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: NotebookProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: NotebookProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: NotebookProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: NotebookProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: NotebookProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: NotebookProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: NotebookProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: NotebookProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: NotebookProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: NotebookProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: NotebookProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: NotebookProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: NotebookProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: NotebookProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: NotebookProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: NotebookProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: NotebookProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: NotebookProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: NotebookProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: NotebookProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: NotebookProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: NotebookProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: NotebookProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: NotebookProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: NotebookProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: NotebookProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: NotebookProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: NotebookProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: NotebookProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: NotebookProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: NotebookProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: NotebookProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: NotebookProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: NotebookProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: NotebookProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: NotebookProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: NotebookProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: NotebookProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: NotebookProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: NotebookProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: NotebookProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: NotebookProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: NotebookProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: NotebookProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: NotebookProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: NotebookProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: NotebookProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: NotebookProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: NotebookProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield NotebookProperty.OnFocused value } 

let prop = NotebookPropertyBuilder()

type NotebookDescriptor(props) =
    inherit BaseWidgetDescriptor<Notebook, NotebookProperty>(props, bindProperty)
    override this.CreateTyped() = new Notebook()

let notebook props = NotebookDescriptor(props)

