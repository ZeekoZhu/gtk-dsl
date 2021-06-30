module GtkDsl.Binding.ComboBoxText
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ComboBoxTextProperty =
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

let bindProperty (widget: ComboBoxText) (prop: ComboBoxTextProperty) =
    match prop with
    | ComboBoxTextProperty.Model value -> widget.Model <- value
    | ComboBoxTextProperty.WrapWidth value -> widget.WrapWidth <- value
    | ComboBoxTextProperty.RowSpanColumn value -> widget.RowSpanColumn <- value
    | ComboBoxTextProperty.ColumnSpanColumn value -> widget.ColumnSpanColumn <- value
    | ComboBoxTextProperty.Active value -> widget.Active <- value
    | ComboBoxTextProperty.AddTearoffs value -> widget.AddTearoffs <- value
    | ComboBoxTextProperty.HasFrame value -> widget.HasFrame <- value
    | ComboBoxTextProperty.TearoffTitle value -> widget.TearoffTitle <- value
    | ComboBoxTextProperty.ButtonSensitivity value -> widget.ButtonSensitivity <- value
    | ComboBoxTextProperty.EntryTextColumn value -> widget.EntryTextColumn <- value
    | ComboBoxTextProperty.IdColumn value -> widget.IdColumn <- value
    | ComboBoxTextProperty.ActiveId value -> widget.ActiveId <- value
    | ComboBoxTextProperty.PopupFixedWidth value -> widget.PopupFixedWidth <- value
    | ComboBoxTextProperty.ResizeMode value -> widget.ResizeMode <- value
    | ComboBoxTextProperty.BorderWidth value -> widget.BorderWidth <- value
    | ComboBoxTextProperty.Name value -> widget.Name <- value
    | ComboBoxTextProperty.Parent value -> widget.Parent <- value
    | ComboBoxTextProperty.WidthRequest value -> widget.WidthRequest <- value
    | ComboBoxTextProperty.HeightRequest value -> widget.HeightRequest <- value
    | ComboBoxTextProperty.Visible value -> widget.Visible <- value
    | ComboBoxTextProperty.Sensitive value -> widget.Sensitive <- value
    | ComboBoxTextProperty.AppPaintable value -> widget.AppPaintable <- value
    | ComboBoxTextProperty.CanFocus value -> widget.CanFocus <- value
    | ComboBoxTextProperty.HasFocus value -> widget.HasFocus <- value
    | ComboBoxTextProperty.IsFocus value -> widget.IsFocus <- value
    | ComboBoxTextProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ComboBoxTextProperty.CanDefault value -> widget.CanDefault <- value
    | ComboBoxTextProperty.HasDefault value -> widget.HasDefault <- value
    | ComboBoxTextProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ComboBoxTextProperty.Style value -> widget.Style <- value
    | ComboBoxTextProperty.Events value -> widget.Events <- value
    | ComboBoxTextProperty.NoShowAll value -> widget.NoShowAll <- value
    | ComboBoxTextProperty.HasTooltip value -> widget.HasTooltip <- value
    | ComboBoxTextProperty.TooltipText value -> widget.TooltipText <- value
    | ComboBoxTextProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ComboBoxTextProperty.Window value -> widget.Window <- value
    | ComboBoxTextProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ComboBoxTextProperty.Halign value -> widget.Halign <- value
    | ComboBoxTextProperty.Valign value -> widget.Valign <- value
    | ComboBoxTextProperty.MarginLeft value -> widget.MarginLeft <- value
    | ComboBoxTextProperty.MarginRight value -> widget.MarginRight <- value
    | ComboBoxTextProperty.MarginStart value -> widget.MarginStart <- value
    | ComboBoxTextProperty.MarginEnd value -> widget.MarginEnd <- value
    | ComboBoxTextProperty.MarginTop value -> widget.MarginTop <- value
    | ComboBoxTextProperty.MarginBottom value -> widget.MarginBottom <- value
    | ComboBoxTextProperty.Margin value -> widget.Margin <- value
    | ComboBoxTextProperty.Hexpand value -> widget.Hexpand <- value
    | ComboBoxTextProperty.HexpandSet value -> widget.HexpandSet <- value
    | ComboBoxTextProperty.Vexpand value -> widget.Vexpand <- value
    | ComboBoxTextProperty.VexpandSet value -> widget.VexpandSet <- value
    | ComboBoxTextProperty.Expand value -> widget.Expand <- value
    | ComboBoxTextProperty.Opacity value -> widget.Opacity <- value
    | ComboBoxTextProperty.OnPoppedDown handler -> 
        let disposable = widget.PoppedDown.Subscribe(handler)
        registerListener widget "PoppedDown" disposable
    | ComboBoxTextProperty.OnMoveActive handler -> 
        let disposable = widget.MoveActive.Subscribe(handler)
        registerListener widget "MoveActive" disposable
    | ComboBoxTextProperty.OnFormatEntryText handler -> 
        let disposable = widget.FormatEntryText.Subscribe(handler)
        registerListener widget "FormatEntryText" disposable
    | ComboBoxTextProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ComboBoxTextProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ComboBoxTextProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ComboBoxTextProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ComboBoxTextProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ComboBoxTextProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ComboBoxTextProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ComboBoxTextProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ComboBoxTextProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ComboBoxTextProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ComboBoxTextProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ComboBoxTextProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ComboBoxTextProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ComboBoxTextProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ComboBoxTextProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ComboBoxTextProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ComboBoxTextProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ComboBoxTextProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ComboBoxTextProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ComboBoxTextProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ComboBoxTextProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ComboBoxTextProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ComboBoxTextProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ComboBoxTextProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ComboBoxTextProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ComboBoxTextProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ComboBoxTextProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ComboBoxTextProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ComboBoxTextProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ComboBoxTextProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ComboBoxTextProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ComboBoxTextProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ComboBoxTextProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ComboBoxTextProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ComboBoxTextProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ComboBoxTextProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ComboBoxTextProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ComboBoxTextProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ComboBoxTextProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ComboBoxTextProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ComboBoxTextProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ComboBoxTextProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ComboBoxTextProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ComboBoxTextProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ComboBoxTextProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ComboBoxTextProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ComboBoxTextProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ComboBoxTextProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ComboBoxTextProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ComboBoxTextProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ComboBoxTextProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ComboBoxTextProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ComboBoxTextProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ComboBoxTextProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ComboBoxTextProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ComboBoxTextProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ComboBoxTextProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ComboBoxTextProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ComboBoxTextProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ComboBoxTextProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ComboBoxTextPropertyBuilder() =
    inherit BasePropertyBuilder<ComboBoxTextProperty>()
    [<CustomOperation("model")>]
    member this.Model(it: ComboBoxTextProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield ComboBoxTextProperty.Model value } 
    [<CustomOperation("wrapWidth")>]
    member this.WrapWidth(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.WrapWidth value } 
    [<CustomOperation("rowSpanColumn")>]
    member this.RowSpanColumn(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.RowSpanColumn value } 
    [<CustomOperation("columnSpanColumn")>]
    member this.ColumnSpanColumn(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.ColumnSpanColumn value } 
    [<CustomOperation("active")>]
    member this.Active(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.Active value } 
    [<Obsolete>]
    [<CustomOperation("addTearoffs")>]
    member this.AddTearoffs(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.AddTearoffs value } 
    [<CustomOperation("hasFrame")>]
    member this.HasFrame(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.HasFrame value } 
    [<Obsolete>]
    [<CustomOperation("tearoffTitle")>]
    member this.TearoffTitle(it: ComboBoxTextProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxTextProperty.TearoffTitle value } 
    [<CustomOperation("buttonSensitivity")>]
    member this.ButtonSensitivity(it: ComboBoxTextProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield ComboBoxTextProperty.ButtonSensitivity value } 
    [<CustomOperation("entryTextColumn")>]
    member this.EntryTextColumn(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.EntryTextColumn value } 
    [<CustomOperation("idColumn")>]
    member this.IdColumn(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.IdColumn value } 
    [<CustomOperation("activeId")>]
    member this.ActiveId(it: ComboBoxTextProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxTextProperty.ActiveId value } 
    [<CustomOperation("popupFixedWidth")>]
    member this.PopupFixedWidth(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.PopupFixedWidth value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ComboBoxTextProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ComboBoxTextProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ComboBoxTextProperty seq, value: System.UInt32) =
        seq { yield! it; yield ComboBoxTextProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ComboBoxTextProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxTextProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ComboBoxTextProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ComboBoxTextProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ComboBoxTextProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ComboBoxTextProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ComboBoxTextProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ComboBoxTextProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ComboBoxTextProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxTextProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ComboBoxTextProperty seq, value: System.String) =
        seq { yield! it; yield ComboBoxTextProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ComboBoxTextProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ComboBoxTextProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ComboBoxTextProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ComboBoxTextProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ComboBoxTextProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ComboBoxTextProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ComboBoxTextProperty seq, value: System.Int32) =
        seq { yield! it; yield ComboBoxTextProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ComboBoxTextProperty seq, value: System.Boolean) =
        seq { yield! it; yield ComboBoxTextProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ComboBoxTextProperty seq, value: System.Double) =
        seq { yield! it; yield ComboBoxTextProperty.Opacity value } 
    [<CustomOperation("onPoppedDown")>]
    member this.OnPoppedDown(it: ComboBoxTextProperty seq, value: Gtk.PoppedDownArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnPoppedDown value } 
    [<CustomOperation("onMoveActive")>]
    member this.OnMoveActive(it: ComboBoxTextProperty seq, value: Gtk.MoveActiveArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnMoveActive value } 
    [<CustomOperation("onFormatEntryText")>]
    member this.OnFormatEntryText(it: ComboBoxTextProperty seq, value: Gtk.FormatEntryTextArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnFormatEntryText value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ComboBoxTextProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ComboBoxTextProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ComboBoxTextProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ComboBoxTextProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ComboBoxTextProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ComboBoxTextProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ComboBoxTextProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ComboBoxTextProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ComboBoxTextProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ComboBoxTextProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ComboBoxTextProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ComboBoxTextProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ComboBoxTextProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ComboBoxTextProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ComboBoxTextProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ComboBoxTextProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ComboBoxTextProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ComboBoxTextProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ComboBoxTextProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ComboBoxTextProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ComboBoxTextProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ComboBoxTextProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ComboBoxTextProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ComboBoxTextProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ComboBoxTextProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ComboBoxTextProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ComboBoxTextProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ComboBoxTextProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ComboBoxTextProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ComboBoxTextProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ComboBoxTextProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ComboBoxTextProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ComboBoxTextProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ComboBoxTextProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ComboBoxTextProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ComboBoxTextProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ComboBoxTextProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ComboBoxTextProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ComboBoxTextProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ComboBoxTextProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ComboBoxTextProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ComboBoxTextProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ComboBoxTextProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ComboBoxTextProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ComboBoxTextProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ComboBoxTextProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ComboBoxTextProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ComboBoxTextProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ComboBoxTextProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ComboBoxTextProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ComboBoxTextProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ComboBoxTextProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ComboBoxTextProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ComboBoxTextProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ComboBoxTextProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ComboBoxTextProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ComboBoxTextProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ComboBoxTextProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ComboBoxTextProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ComboBoxTextProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ComboBoxTextProperty.OnFocused value } 

let prop = ComboBoxTextPropertyBuilder()

type ComboBoxTextDescriptor(props) =
    inherit BaseWidgetDescriptor<ComboBoxText, ComboBoxTextProperty>(props, bindProperty)
    override this.CreateTyped() = new ComboBoxText()

let comboBoxText props = ComboBoxTextDescriptor(props)

