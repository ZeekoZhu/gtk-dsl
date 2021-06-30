module GtkDsl.Binding.HScale
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HScaleProperty =
    | Digits of System.Int32
    | DrawValue of System.Boolean
    | HasOrigin of System.Boolean
    | ValuePos of Gtk.PositionType
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
    |  OnFormatValue of (Gtk.FormatValueArgs -> unit)
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

let bindProperty (widget: HScale) (prop: HScaleProperty) =
    match prop with
    | HScaleProperty.Digits value -> widget.Digits <- value
    | HScaleProperty.DrawValue value -> widget.DrawValue <- value
    | HScaleProperty.HasOrigin value -> widget.HasOrigin <- value
    | HScaleProperty.ValuePos value -> widget.ValuePos <- value
    | HScaleProperty.Adjustment value -> widget.Adjustment <- value
    | HScaleProperty.Inverted value -> widget.Inverted <- value
    | HScaleProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | HScaleProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | HScaleProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | HScaleProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | HScaleProperty.FillLevel value -> widget.FillLevel <- value
    | HScaleProperty.RoundDigits value -> widget.RoundDigits <- value
    | HScaleProperty.Name value -> widget.Name <- value
    | HScaleProperty.Parent value -> widget.Parent <- value
    | HScaleProperty.WidthRequest value -> widget.WidthRequest <- value
    | HScaleProperty.HeightRequest value -> widget.HeightRequest <- value
    | HScaleProperty.Visible value -> widget.Visible <- value
    | HScaleProperty.Sensitive value -> widget.Sensitive <- value
    | HScaleProperty.AppPaintable value -> widget.AppPaintable <- value
    | HScaleProperty.CanFocus value -> widget.CanFocus <- value
    | HScaleProperty.HasFocus value -> widget.HasFocus <- value
    | HScaleProperty.IsFocus value -> widget.IsFocus <- value
    | HScaleProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HScaleProperty.CanDefault value -> widget.CanDefault <- value
    | HScaleProperty.HasDefault value -> widget.HasDefault <- value
    | HScaleProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HScaleProperty.Style value -> widget.Style <- value
    | HScaleProperty.Events value -> widget.Events <- value
    | HScaleProperty.NoShowAll value -> widget.NoShowAll <- value
    | HScaleProperty.HasTooltip value -> widget.HasTooltip <- value
    | HScaleProperty.TooltipText value -> widget.TooltipText <- value
    | HScaleProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HScaleProperty.Window value -> widget.Window <- value
    | HScaleProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HScaleProperty.Halign value -> widget.Halign <- value
    | HScaleProperty.Valign value -> widget.Valign <- value
    | HScaleProperty.MarginLeft value -> widget.MarginLeft <- value
    | HScaleProperty.MarginRight value -> widget.MarginRight <- value
    | HScaleProperty.MarginStart value -> widget.MarginStart <- value
    | HScaleProperty.MarginEnd value -> widget.MarginEnd <- value
    | HScaleProperty.MarginTop value -> widget.MarginTop <- value
    | HScaleProperty.MarginBottom value -> widget.MarginBottom <- value
    | HScaleProperty.Margin value -> widget.Margin <- value
    | HScaleProperty.Hexpand value -> widget.Hexpand <- value
    | HScaleProperty.HexpandSet value -> widget.HexpandSet <- value
    | HScaleProperty.Vexpand value -> widget.Vexpand <- value
    | HScaleProperty.VexpandSet value -> widget.VexpandSet <- value
    | HScaleProperty.Expand value -> widget.Expand <- value
    | HScaleProperty.Opacity value -> widget.Opacity <- value
    | HScaleProperty.OnFormatValue handler -> 
        let disposable = widget.FormatValue.Subscribe(handler)
        registerListener widget "FormatValue" disposable
    | HScaleProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | HScaleProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | HScaleProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | HScaleProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HScaleProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HScaleProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HScaleProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HScaleProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HScaleProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HScaleProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HScaleProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HScaleProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HScaleProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HScaleProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HScaleProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HScaleProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HScaleProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HScaleProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HScaleProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HScaleProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HScaleProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HScaleProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HScaleProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HScaleProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HScaleProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HScaleProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HScaleProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HScaleProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HScaleProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HScaleProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HScaleProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HScaleProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HScaleProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HScaleProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HScaleProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HScaleProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HScaleProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HScaleProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HScaleProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HScaleProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HScaleProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HScaleProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HScaleProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HScaleProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HScaleProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HScaleProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HScaleProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HScaleProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HScaleProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HScaleProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HScaleProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HScaleProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HScaleProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HScaleProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HScaleProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HScaleProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HScaleProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HScaleProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HScaleProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HScaleProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HScalePropertyBuilder() =
    inherit BasePropertyBuilder<HScaleProperty>()
    [<CustomOperation("digits")>]
    member this.Digits(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.Digits value } 
    [<CustomOperation("drawValue")>]
    member this.DrawValue(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.DrawValue value } 
    [<CustomOperation("hasOrigin")>]
    member this.HasOrigin(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.HasOrigin value } 
    [<CustomOperation("valuePos")>]
    member this.ValuePos(it: HScaleProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield HScaleProperty.ValuePos value } 
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: HScaleProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield HScaleProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: HScaleProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield HScaleProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: HScaleProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield HScaleProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: HScaleProperty seq, value: System.Double) =
        seq { yield! it; yield HScaleProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: HScaleProperty seq, value: System.String) =
        seq { yield! it; yield HScaleProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HScaleProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HScaleProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HScaleProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HScaleProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HScaleProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HScaleProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HScaleProperty seq, value: System.String) =
        seq { yield! it; yield HScaleProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HScaleProperty seq, value: System.String) =
        seq { yield! it; yield HScaleProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HScaleProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HScaleProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HScaleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HScaleProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HScaleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HScaleProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield HScaleProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScaleProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HScaleProperty seq, value: System.Double) =
        seq { yield! it; yield HScaleProperty.Opacity value } 
    [<CustomOperation("onFormatValue")>]
    member this.OnFormatValue(it: HScaleProperty seq, value: Gtk.FormatValueArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnFormatValue value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: HScaleProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: HScaleProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: HScaleProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HScaleProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HScaleProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HScaleProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HScaleProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HScaleProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HScaleProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HScaleProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HScaleProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HScaleProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HScaleProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HScaleProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HScaleProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HScaleProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HScaleProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HScaleProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HScaleProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HScaleProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HScaleProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HScaleProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HScaleProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HScaleProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HScaleProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HScaleProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HScaleProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HScaleProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HScaleProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HScaleProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HScaleProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HScaleProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HScaleProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HScaleProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HScaleProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HScaleProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HScaleProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HScaleProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HScaleProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HScaleProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HScaleProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HScaleProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HScaleProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HScaleProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HScaleProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HScaleProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HScaleProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HScaleProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HScaleProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HScaleProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HScaleProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HScaleProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HScaleProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HScaleProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HScaleProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HScaleProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HScaleProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HScaleProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HScaleProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HScaleProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HScaleProperty.OnFocused value } 

let prop = HScalePropertyBuilder()

