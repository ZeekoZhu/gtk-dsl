module Gtk.DSL.Binding.ComboBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ComboBoxProperty =
    | Model of Gtk.ITreeModel
    | WrapWidth of System.Int32
    | RowSpanColumn of System.Int32
    | ColumnSpanColumn of System.Int32
    | Active of System.Int32
    | [<Obsolete>] AddTearoffs of System.Boolean
    | HasFrame of System.Boolean
    | [<Obsolete>] TearoffTitle of System.String
    | ButtonSensitivity of Gtk.SensitivityType
    | EntryTextColumn of System.Int32
    | IdColumn of System.Int32
    | ActiveId of System.String
    | PopupFixedWidth of System.Boolean
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
    |  OnPoppedDown of (Gtk.PoppedDownArgs -> unit)
    |  OnMoveActive of (Gtk.MoveActiveArgs -> unit)
    |  OnFormatEntryText of (Gtk.FormatEntryTextArgs -> unit)
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

let bindProperty (widget: ComboBox) (prop: ComboBoxProperty) =
    match prop with
    | ComboBoxProperty.Model value -> widget.Model <- value
    | ComboBoxProperty.WrapWidth value -> widget.WrapWidth <- value
    | ComboBoxProperty.RowSpanColumn value -> widget.RowSpanColumn <- value
    | ComboBoxProperty.ColumnSpanColumn value -> widget.ColumnSpanColumn <- value
    | ComboBoxProperty.Active value -> widget.Active <- value
    | ComboBoxProperty.AddTearoffs value -> widget.AddTearoffs <- value
    | ComboBoxProperty.HasFrame value -> widget.HasFrame <- value
    | ComboBoxProperty.TearoffTitle value -> widget.TearoffTitle <- value
    | ComboBoxProperty.ButtonSensitivity value -> widget.ButtonSensitivity <- value
    | ComboBoxProperty.EntryTextColumn value -> widget.EntryTextColumn <- value
    | ComboBoxProperty.IdColumn value -> widget.IdColumn <- value
    | ComboBoxProperty.ActiveId value -> widget.ActiveId <- value
    | ComboBoxProperty.PopupFixedWidth value -> widget.PopupFixedWidth <- value
    | ComboBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | ComboBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | ComboBoxProperty.Name value -> widget.Name <- value
    | ComboBoxProperty.Parent value -> widget.Parent <- value
    | ComboBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | ComboBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | ComboBoxProperty.Visible value -> widget.Visible <- value
    | ComboBoxProperty.Sensitive value -> widget.Sensitive <- value
    | ComboBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | ComboBoxProperty.CanFocus value -> widget.CanFocus <- value
    | ComboBoxProperty.HasFocus value -> widget.HasFocus <- value
    | ComboBoxProperty.IsFocus value -> widget.IsFocus <- value
    | ComboBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ComboBoxProperty.CanDefault value -> widget.CanDefault <- value
    | ComboBoxProperty.HasDefault value -> widget.HasDefault <- value
    | ComboBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ComboBoxProperty.Style value -> widget.Style <- value
    | ComboBoxProperty.Events value -> widget.Events <- value
    | ComboBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | ComboBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | ComboBoxProperty.TooltipText value -> widget.TooltipText <- value
    | ComboBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ComboBoxProperty.Window value -> widget.Window <- value
    | ComboBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ComboBoxProperty.Halign value -> widget.Halign <- value
    | ComboBoxProperty.Valign value -> widget.Valign <- value
    | ComboBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | ComboBoxProperty.MarginRight value -> widget.MarginRight <- value
    | ComboBoxProperty.MarginStart value -> widget.MarginStart <- value
    | ComboBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | ComboBoxProperty.MarginTop value -> widget.MarginTop <- value
    | ComboBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | ComboBoxProperty.Margin value -> widget.Margin <- value
    | ComboBoxProperty.Hexpand value -> widget.Hexpand <- value
    | ComboBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | ComboBoxProperty.Vexpand value -> widget.Vexpand <- value
    | ComboBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | ComboBoxProperty.Expand value -> widget.Expand <- value
    | ComboBoxProperty.Opacity value -> widget.Opacity <- value
    | ComboBoxProperty.OnPoppedDown handler -> 
        let disposable = widget.PoppedDown.Subscribe(handler)
        registerListener widget "PoppedDown" disposable
    | ComboBoxProperty.OnMoveActive handler -> 
        let disposable = widget.MoveActive.Subscribe(handler)
        registerListener widget "MoveActive" disposable
    | ComboBoxProperty.OnFormatEntryText handler -> 
        let disposable = widget.FormatEntryText.Subscribe(handler)
        registerListener widget "FormatEntryText" disposable
    | ComboBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ComboBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ComboBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ComboBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ComboBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ComboBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ComboBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ComboBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ComboBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ComboBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ComboBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ComboBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ComboBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ComboBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ComboBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ComboBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ComboBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ComboBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ComboBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ComboBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ComboBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ComboBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ComboBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ComboBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ComboBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ComboBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ComboBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ComboBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ComboBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ComboBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ComboBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ComboBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ComboBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ComboBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ComboBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ComboBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ComboBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ComboBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ComboBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ComboBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ComboBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ComboBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ComboBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ComboBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ComboBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ComboBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ComboBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ComboBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ComboBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ComboBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ComboBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ComboBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ComboBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ComboBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ComboBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ComboBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ComboBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ComboBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ComboBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ComboBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ComboBoxPropertyBuilder() =
    inherit BasePropertyBuilder<ComboBoxProperty>()
    [<CustomOperation("model")>]
    member this.Model(it: ComboBoxProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield ComboBoxProperty.Model value } 
    [<CustomOperation("wrapWidth")>]
    member this.WrapWidth(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.WrapWidth value } 
    [<CustomOperation("rowSpanColumn")>]
    member this.RowSpanColumn(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.RowSpanColumn value } 
    [<CustomOperation("columnSpanColumn")>]
    member this.ColumnSpanColumn(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.ColumnSpanColumn value } 
    [<CustomOperation("active")>]
    member this.Active(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.Active value } 
    [<Obsolete>]
    [<CustomOperation("addTearoffs")>]
    member this.AddTearoffs(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.AddTearoffs value } 
    [<CustomOperation("hasFrame")>]
    member this.HasFrame(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.HasFrame value } 
    [<Obsolete>]
    [<CustomOperation("tearoffTitle")>]
    member this.TearoffTitle(it: ComboBoxProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxProperty.TearoffTitle value } 
    [<CustomOperation("buttonSensitivity")>]
    member this.ButtonSensitivity(it: ComboBoxProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield ComboBoxProperty.ButtonSensitivity value } 
    [<CustomOperation("entryTextColumn")>]
    member this.EntryTextColumn(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.EntryTextColumn value } 
    [<CustomOperation("idColumn")>]
    member this.IdColumn(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.IdColumn value } 
    [<CustomOperation("activeId")>]
    member this.ActiveId(it: ComboBoxProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxProperty.ActiveId value } 
    [<CustomOperation("popupFixedWidth")>]
    member this.PopupFixedWidth(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.PopupFixedWidth value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ComboBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ComboBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ComboBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield ComboBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ComboBoxProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ComboBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ComboBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ComboBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ComboBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ComboBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ComboBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ComboBoxProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ComboBoxProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ComboBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ComboBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ComboBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ComboBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ComboBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ComboBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ComboBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ComboBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ComboBoxProperty seq, value: System.Double) =
        seq { yield! it; yield ComboBoxProperty.Opacity value } 
    [<CustomOperation("onPoppedDown")>]
    member this.OnPoppedDown(it: ComboBoxProperty seq, value: Gtk.PoppedDownArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnPoppedDown value } 
    [<CustomOperation("onMoveActive")>]
    member this.OnMoveActive(it: ComboBoxProperty seq, value: Gtk.MoveActiveArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnMoveActive value } 
    [<CustomOperation("onFormatEntryText")>]
    member this.OnFormatEntryText(it: ComboBoxProperty seq, value: Gtk.FormatEntryTextArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnFormatEntryText value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ComboBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ComboBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ComboBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ComboBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ComboBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ComboBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ComboBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ComboBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ComboBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ComboBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ComboBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ComboBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ComboBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ComboBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ComboBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ComboBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ComboBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ComboBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ComboBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ComboBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ComboBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ComboBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ComboBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ComboBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ComboBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ComboBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ComboBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ComboBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ComboBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ComboBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ComboBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ComboBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ComboBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ComboBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ComboBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ComboBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ComboBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ComboBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ComboBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ComboBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ComboBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ComboBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ComboBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ComboBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ComboBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ComboBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ComboBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ComboBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ComboBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ComboBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ComboBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ComboBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ComboBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ComboBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ComboBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ComboBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ComboBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ComboBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ComboBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ComboBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ComboBoxProperty.OnFocused value } 

let prop = ComboBoxPropertyBuilder()

type ComboBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<ComboBox, ComboBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new ComboBox()

let comboBox props = ComboBoxDescriptor(props)

