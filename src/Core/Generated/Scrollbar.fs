module GtkDsl.Binding.Scrollbar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ScrollbarProperty =
    | Adjustment of Gtk.Adjustment
    | Inverted of System.Boolean
    | LowerStepperSensitivity of Gtk.SensitivityType
    | UpperStepperSensitivity of Gtk.SensitivityType
    | ShowFillLevel of System.Boolean
    | RestrictToFillLevel of System.Boolean
    | FillLevel of System.Double
    | RoundDigits of System.Int32
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
    |  OnChangeValue of (Gtk.ChangeValueArgs -> unit)
    |  OnMoveSlider of (Gtk.MoveSliderArgs -> unit)
    |  OnAdjustBounds of (Gtk.AdjustBoundsArgs -> unit)
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

let bindProperty (widget: Scrollbar) (prop: ScrollbarProperty) =
    match prop with
    | ScrollbarProperty.Adjustment value -> widget.Adjustment <- value
    | ScrollbarProperty.Inverted value -> widget.Inverted <- value
    | ScrollbarProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | ScrollbarProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | ScrollbarProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | ScrollbarProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | ScrollbarProperty.FillLevel value -> widget.FillLevel <- value
    | ScrollbarProperty.RoundDigits value -> widget.RoundDigits <- value
    | ScrollbarProperty.Name value -> widget.Name <- value
    | ScrollbarProperty.Parent value -> widget.Parent <- value
    | ScrollbarProperty.WidthRequest value -> widget.WidthRequest <- value
    | ScrollbarProperty.HeightRequest value -> widget.HeightRequest <- value
    | ScrollbarProperty.Visible value -> widget.Visible <- value
    | ScrollbarProperty.Sensitive value -> widget.Sensitive <- value
    | ScrollbarProperty.AppPaintable value -> widget.AppPaintable <- value
    | ScrollbarProperty.CanFocus value -> widget.CanFocus <- value
    | ScrollbarProperty.HasFocus value -> widget.HasFocus <- value
    | ScrollbarProperty.IsFocus value -> widget.IsFocus <- value
    | ScrollbarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ScrollbarProperty.CanDefault value -> widget.CanDefault <- value
    | ScrollbarProperty.HasDefault value -> widget.HasDefault <- value
    | ScrollbarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ScrollbarProperty.Style value -> widget.Style <- value
    | ScrollbarProperty.Events value -> widget.Events <- value
    | ScrollbarProperty.NoShowAll value -> widget.NoShowAll <- value
    | ScrollbarProperty.HasTooltip value -> widget.HasTooltip <- value
    | ScrollbarProperty.TooltipText value -> widget.TooltipText <- value
    | ScrollbarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ScrollbarProperty.Window value -> widget.Window <- value
    | ScrollbarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ScrollbarProperty.Halign value -> widget.Halign <- value
    | ScrollbarProperty.Valign value -> widget.Valign <- value
    | ScrollbarProperty.MarginLeft value -> widget.MarginLeft <- value
    | ScrollbarProperty.MarginRight value -> widget.MarginRight <- value
    | ScrollbarProperty.MarginStart value -> widget.MarginStart <- value
    | ScrollbarProperty.MarginEnd value -> widget.MarginEnd <- value
    | ScrollbarProperty.MarginTop value -> widget.MarginTop <- value
    | ScrollbarProperty.MarginBottom value -> widget.MarginBottom <- value
    | ScrollbarProperty.Margin value -> widget.Margin <- value
    | ScrollbarProperty.Hexpand value -> widget.Hexpand <- value
    | ScrollbarProperty.HexpandSet value -> widget.HexpandSet <- value
    | ScrollbarProperty.Vexpand value -> widget.Vexpand <- value
    | ScrollbarProperty.VexpandSet value -> widget.VexpandSet <- value
    | ScrollbarProperty.Expand value -> widget.Expand <- value
    | ScrollbarProperty.Opacity value -> widget.Opacity <- value
    | ScrollbarProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | ScrollbarProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | ScrollbarProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | ScrollbarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ScrollbarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ScrollbarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ScrollbarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ScrollbarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ScrollbarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ScrollbarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ScrollbarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ScrollbarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ScrollbarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ScrollbarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ScrollbarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ScrollbarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ScrollbarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ScrollbarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ScrollbarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ScrollbarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ScrollbarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ScrollbarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ScrollbarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ScrollbarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ScrollbarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ScrollbarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ScrollbarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ScrollbarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ScrollbarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ScrollbarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ScrollbarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ScrollbarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ScrollbarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ScrollbarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ScrollbarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ScrollbarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ScrollbarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ScrollbarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ScrollbarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ScrollbarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ScrollbarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ScrollbarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ScrollbarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ScrollbarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ScrollbarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ScrollbarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ScrollbarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ScrollbarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ScrollbarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ScrollbarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ScrollbarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ScrollbarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ScrollbarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ScrollbarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ScrollbarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ScrollbarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ScrollbarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ScrollbarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ScrollbarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ScrollbarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ScrollbarPropertyBuilder() =
    inherit BasePropertyBuilder<ScrollbarProperty>()
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: ScrollbarProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ScrollbarProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: ScrollbarProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield ScrollbarProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: ScrollbarProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield ScrollbarProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: ScrollbarProperty seq, value: System.Double) =
        seq { yield! it; yield ScrollbarProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: ScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield ScrollbarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ScrollbarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ScrollbarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ScrollbarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ScrollbarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ScrollbarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ScrollbarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield ScrollbarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield ScrollbarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ScrollbarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ScrollbarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ScrollbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScrollbarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ScrollbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScrollbarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield ScrollbarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScrollbarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ScrollbarProperty seq, value: System.Double) =
        seq { yield! it; yield ScrollbarProperty.Opacity value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: ScrollbarProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: ScrollbarProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: ScrollbarProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ScrollbarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ScrollbarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ScrollbarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ScrollbarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ScrollbarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ScrollbarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ScrollbarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ScrollbarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ScrollbarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ScrollbarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ScrollbarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ScrollbarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ScrollbarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ScrollbarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ScrollbarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ScrollbarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ScrollbarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ScrollbarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ScrollbarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ScrollbarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ScrollbarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ScrollbarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ScrollbarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ScrollbarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ScrollbarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ScrollbarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ScrollbarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ScrollbarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ScrollbarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ScrollbarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ScrollbarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ScrollbarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ScrollbarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ScrollbarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ScrollbarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ScrollbarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ScrollbarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ScrollbarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ScrollbarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ScrollbarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ScrollbarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ScrollbarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ScrollbarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ScrollbarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ScrollbarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ScrollbarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ScrollbarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ScrollbarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ScrollbarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ScrollbarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ScrollbarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ScrollbarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ScrollbarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ScrollbarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ScrollbarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ScrollbarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ScrollbarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ScrollbarProperty.OnFocused value } 

let prop = ScrollbarPropertyBuilder()

