module Gtk.DSL.Binding.AppChooserButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AppChooserButtonProperty =
    | ShowDialogItem of System.Boolean
    | ShowDefaultItem of System.Boolean
    | Heading of System.String
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
    |  OnCustomItemActivated of (Gtk.CustomItemActivatedArgs -> unit)
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

let bindProperty (widget: AppChooserButton) (prop: AppChooserButtonProperty) =
    match prop with
    | AppChooserButtonProperty.ShowDialogItem value -> widget.ShowDialogItem <- value
    | AppChooserButtonProperty.ShowDefaultItem value -> widget.ShowDefaultItem <- value
    | AppChooserButtonProperty.Heading value -> widget.Heading <- value
    | AppChooserButtonProperty.Model value -> widget.Model <- value
    | AppChooserButtonProperty.WrapWidth value -> widget.WrapWidth <- value
    | AppChooserButtonProperty.RowSpanColumn value -> widget.RowSpanColumn <- value
    | AppChooserButtonProperty.ColumnSpanColumn value -> widget.ColumnSpanColumn <- value
    | AppChooserButtonProperty.Active value -> widget.Active <- value
    | AppChooserButtonProperty.AddTearoffs value -> widget.AddTearoffs <- value
    | AppChooserButtonProperty.HasFrame value -> widget.HasFrame <- value
    | AppChooserButtonProperty.TearoffTitle value -> widget.TearoffTitle <- value
    | AppChooserButtonProperty.ButtonSensitivity value -> widget.ButtonSensitivity <- value
    | AppChooserButtonProperty.EntryTextColumn value -> widget.EntryTextColumn <- value
    | AppChooserButtonProperty.IdColumn value -> widget.IdColumn <- value
    | AppChooserButtonProperty.ActiveId value -> widget.ActiveId <- value
    | AppChooserButtonProperty.PopupFixedWidth value -> widget.PopupFixedWidth <- value
    | AppChooserButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | AppChooserButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | AppChooserButtonProperty.Name value -> widget.Name <- value
    | AppChooserButtonProperty.Parent value -> widget.Parent <- value
    | AppChooserButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | AppChooserButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | AppChooserButtonProperty.Visible value -> widget.Visible <- value
    | AppChooserButtonProperty.Sensitive value -> widget.Sensitive <- value
    | AppChooserButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | AppChooserButtonProperty.CanFocus value -> widget.CanFocus <- value
    | AppChooserButtonProperty.HasFocus value -> widget.HasFocus <- value
    | AppChooserButtonProperty.IsFocus value -> widget.IsFocus <- value
    | AppChooserButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AppChooserButtonProperty.CanDefault value -> widget.CanDefault <- value
    | AppChooserButtonProperty.HasDefault value -> widget.HasDefault <- value
    | AppChooserButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AppChooserButtonProperty.Style value -> widget.Style <- value
    | AppChooserButtonProperty.Events value -> widget.Events <- value
    | AppChooserButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | AppChooserButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | AppChooserButtonProperty.TooltipText value -> widget.TooltipText <- value
    | AppChooserButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AppChooserButtonProperty.Window value -> widget.Window <- value
    | AppChooserButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AppChooserButtonProperty.Halign value -> widget.Halign <- value
    | AppChooserButtonProperty.Valign value -> widget.Valign <- value
    | AppChooserButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | AppChooserButtonProperty.MarginRight value -> widget.MarginRight <- value
    | AppChooserButtonProperty.MarginStart value -> widget.MarginStart <- value
    | AppChooserButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | AppChooserButtonProperty.MarginTop value -> widget.MarginTop <- value
    | AppChooserButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | AppChooserButtonProperty.Margin value -> widget.Margin <- value
    | AppChooserButtonProperty.Hexpand value -> widget.Hexpand <- value
    | AppChooserButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | AppChooserButtonProperty.Vexpand value -> widget.Vexpand <- value
    | AppChooserButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | AppChooserButtonProperty.Expand value -> widget.Expand <- value
    | AppChooserButtonProperty.Opacity value -> widget.Opacity <- value
    | AppChooserButtonProperty.OnCustomItemActivated handler -> 
        let disposable = widget.CustomItemActivated.Subscribe(handler)
        registerListener widget "CustomItemActivated" disposable
    | AppChooserButtonProperty.OnPoppedDown handler -> 
        let disposable = widget.PoppedDown.Subscribe(handler)
        registerListener widget "PoppedDown" disposable
    | AppChooserButtonProperty.OnMoveActive handler -> 
        let disposable = widget.MoveActive.Subscribe(handler)
        registerListener widget "MoveActive" disposable
    | AppChooserButtonProperty.OnFormatEntryText handler -> 
        let disposable = widget.FormatEntryText.Subscribe(handler)
        registerListener widget "FormatEntryText" disposable
    | AppChooserButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | AppChooserButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | AppChooserButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | AppChooserButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AppChooserButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AppChooserButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AppChooserButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AppChooserButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AppChooserButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AppChooserButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AppChooserButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AppChooserButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AppChooserButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AppChooserButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AppChooserButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AppChooserButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AppChooserButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AppChooserButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AppChooserButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AppChooserButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AppChooserButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AppChooserButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AppChooserButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AppChooserButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AppChooserButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AppChooserButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AppChooserButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AppChooserButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AppChooserButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AppChooserButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AppChooserButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AppChooserButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AppChooserButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AppChooserButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AppChooserButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AppChooserButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AppChooserButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AppChooserButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AppChooserButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AppChooserButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AppChooserButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AppChooserButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AppChooserButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AppChooserButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AppChooserButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AppChooserButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AppChooserButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AppChooserButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AppChooserButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AppChooserButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AppChooserButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AppChooserButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AppChooserButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AppChooserButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AppChooserButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AppChooserButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AppChooserButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AppChooserButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AppChooserButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AppChooserButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AppChooserButtonPropertyBuilder() =
    inherit BasePropertyBuilder<AppChooserButtonProperty>()
    [<CustomOperation("showDialogItem")>]
    member this.ShowDialogItem(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.ShowDialogItem value } 
    [<CustomOperation("showDefaultItem")>]
    member this.ShowDefaultItem(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.ShowDefaultItem value } 
    [<CustomOperation("heading")>]
    member this.Heading(it: AppChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserButtonProperty.Heading value } 
    [<CustomOperation("model")>]
    member this.Model(it: AppChooserButtonProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield AppChooserButtonProperty.Model value } 
    [<CustomOperation("wrapWidth")>]
    member this.WrapWidth(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.WrapWidth value } 
    [<CustomOperation("rowSpanColumn")>]
    member this.RowSpanColumn(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.RowSpanColumn value } 
    [<CustomOperation("columnSpanColumn")>]
    member this.ColumnSpanColumn(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.ColumnSpanColumn value } 
    [<CustomOperation("active")>]
    member this.Active(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.Active value } 
    [<Obsolete>]
    [<CustomOperation("addTearoffs")>]
    member this.AddTearoffs(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.AddTearoffs value } 
    [<CustomOperation("hasFrame")>]
    member this.HasFrame(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.HasFrame value } 
    [<Obsolete>]
    [<CustomOperation("tearoffTitle")>]
    member this.TearoffTitle(it: AppChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserButtonProperty.TearoffTitle value } 
    [<CustomOperation("buttonSensitivity")>]
    member this.ButtonSensitivity(it: AppChooserButtonProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield AppChooserButtonProperty.ButtonSensitivity value } 
    [<CustomOperation("entryTextColumn")>]
    member this.EntryTextColumn(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.EntryTextColumn value } 
    [<CustomOperation("idColumn")>]
    member this.IdColumn(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.IdColumn value } 
    [<CustomOperation("activeId")>]
    member this.ActiveId(it: AppChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserButtonProperty.ActiveId value } 
    [<CustomOperation("popupFixedWidth")>]
    member this.PopupFixedWidth(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.PopupFixedWidth value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: AppChooserButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield AppChooserButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: AppChooserButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield AppChooserButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: AppChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AppChooserButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AppChooserButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AppChooserButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AppChooserButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AppChooserButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AppChooserButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AppChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AppChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AppChooserButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AppChooserButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AppChooserButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AppChooserButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AppChooserButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AppChooserButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AppChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AppChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AppChooserButtonProperty seq, value: System.Double) =
        seq { yield! it; yield AppChooserButtonProperty.Opacity value } 
    [<CustomOperation("onCustomItemActivated")>]
    member this.OnCustomItemActivated(it: AppChooserButtonProperty seq, value: Gtk.CustomItemActivatedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnCustomItemActivated value } 
    [<CustomOperation("onPoppedDown")>]
    member this.OnPoppedDown(it: AppChooserButtonProperty seq, value: Gtk.PoppedDownArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnPoppedDown value } 
    [<CustomOperation("onMoveActive")>]
    member this.OnMoveActive(it: AppChooserButtonProperty seq, value: Gtk.MoveActiveArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnMoveActive value } 
    [<CustomOperation("onFormatEntryText")>]
    member this.OnFormatEntryText(it: AppChooserButtonProperty seq, value: Gtk.FormatEntryTextArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnFormatEntryText value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: AppChooserButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: AppChooserButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: AppChooserButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AppChooserButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AppChooserButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AppChooserButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AppChooserButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AppChooserButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AppChooserButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AppChooserButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AppChooserButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AppChooserButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AppChooserButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AppChooserButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AppChooserButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AppChooserButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AppChooserButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AppChooserButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AppChooserButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AppChooserButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AppChooserButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AppChooserButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AppChooserButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AppChooserButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AppChooserButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AppChooserButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AppChooserButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AppChooserButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AppChooserButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AppChooserButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AppChooserButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AppChooserButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AppChooserButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AppChooserButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AppChooserButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AppChooserButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AppChooserButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AppChooserButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AppChooserButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AppChooserButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AppChooserButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AppChooserButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AppChooserButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AppChooserButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AppChooserButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AppChooserButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AppChooserButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AppChooserButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AppChooserButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AppChooserButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AppChooserButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AppChooserButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AppChooserButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AppChooserButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AppChooserButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AppChooserButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AppChooserButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AppChooserButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AppChooserButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AppChooserButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AppChooserButtonProperty.OnFocused value } 

let prop = AppChooserButtonPropertyBuilder()

