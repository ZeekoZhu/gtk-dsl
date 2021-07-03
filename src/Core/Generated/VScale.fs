module Gtk.DSL.Binding.VScale
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VScaleProperty =
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

let bindProperty (widget: VScale) (prop: VScaleProperty) =
    match prop with
    | VScaleProperty.Digits value -> widget.Digits <- value
    | VScaleProperty.DrawValue value -> widget.DrawValue <- value
    | VScaleProperty.HasOrigin value -> widget.HasOrigin <- value
    | VScaleProperty.ValuePos value -> widget.ValuePos <- value
    | VScaleProperty.Adjustment value -> widget.Adjustment <- value
    | VScaleProperty.Inverted value -> widget.Inverted <- value
    | VScaleProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | VScaleProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | VScaleProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | VScaleProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | VScaleProperty.FillLevel value -> widget.FillLevel <- value
    | VScaleProperty.RoundDigits value -> widget.RoundDigits <- value
    | VScaleProperty.Name value -> widget.Name <- value
    | VScaleProperty.Parent value -> widget.Parent <- value
    | VScaleProperty.WidthRequest value -> widget.WidthRequest <- value
    | VScaleProperty.HeightRequest value -> widget.HeightRequest <- value
    | VScaleProperty.Visible value -> widget.Visible <- value
    | VScaleProperty.Sensitive value -> widget.Sensitive <- value
    | VScaleProperty.AppPaintable value -> widget.AppPaintable <- value
    | VScaleProperty.CanFocus value -> widget.CanFocus <- value
    | VScaleProperty.HasFocus value -> widget.HasFocus <- value
    | VScaleProperty.IsFocus value -> widget.IsFocus <- value
    | VScaleProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VScaleProperty.CanDefault value -> widget.CanDefault <- value
    | VScaleProperty.HasDefault value -> widget.HasDefault <- value
    | VScaleProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VScaleProperty.Style value -> widget.Style <- value
    | VScaleProperty.Events value -> widget.Events <- value
    | VScaleProperty.NoShowAll value -> widget.NoShowAll <- value
    | VScaleProperty.HasTooltip value -> widget.HasTooltip <- value
    | VScaleProperty.TooltipText value -> widget.TooltipText <- value
    | VScaleProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VScaleProperty.Window value -> widget.Window <- value
    | VScaleProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VScaleProperty.Halign value -> widget.Halign <- value
    | VScaleProperty.Valign value -> widget.Valign <- value
    | VScaleProperty.MarginLeft value -> widget.MarginLeft <- value
    | VScaleProperty.MarginRight value -> widget.MarginRight <- value
    | VScaleProperty.MarginStart value -> widget.MarginStart <- value
    | VScaleProperty.MarginEnd value -> widget.MarginEnd <- value
    | VScaleProperty.MarginTop value -> widget.MarginTop <- value
    | VScaleProperty.MarginBottom value -> widget.MarginBottom <- value
    | VScaleProperty.Margin value -> widget.Margin <- value
    | VScaleProperty.Hexpand value -> widget.Hexpand <- value
    | VScaleProperty.HexpandSet value -> widget.HexpandSet <- value
    | VScaleProperty.Vexpand value -> widget.Vexpand <- value
    | VScaleProperty.VexpandSet value -> widget.VexpandSet <- value
    | VScaleProperty.Expand value -> widget.Expand <- value
    | VScaleProperty.Opacity value -> widget.Opacity <- value
    | VScaleProperty.OnFormatValue handler -> 
        let disposable = widget.FormatValue.Subscribe(handler)
        registerListener widget "FormatValue" disposable
    | VScaleProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | VScaleProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | VScaleProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | VScaleProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VScaleProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VScaleProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VScaleProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VScaleProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VScaleProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VScaleProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VScaleProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VScaleProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VScaleProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VScaleProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VScaleProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VScaleProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VScaleProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VScaleProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VScaleProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VScaleProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VScaleProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VScaleProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VScaleProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VScaleProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VScaleProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VScaleProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VScaleProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VScaleProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VScaleProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VScaleProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VScaleProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VScaleProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VScaleProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VScaleProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VScaleProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VScaleProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VScaleProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VScaleProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VScaleProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VScaleProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VScaleProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VScaleProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VScaleProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VScaleProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VScaleProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VScaleProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VScaleProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VScaleProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VScaleProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VScaleProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VScaleProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VScaleProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VScaleProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VScaleProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VScaleProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VScaleProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VScaleProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VScaleProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VScaleProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VScaleProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VScalePropertyBuilder() =
    inherit BasePropertyBuilder<VScaleProperty>()
    [<CustomOperation("digits")>]
    member this.Digits(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.Digits value } 
    [<CustomOperation("drawValue")>]
    member this.DrawValue(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.DrawValue value } 
    [<CustomOperation("hasOrigin")>]
    member this.HasOrigin(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.HasOrigin value } 
    [<CustomOperation("valuePos")>]
    member this.ValuePos(it: VScaleProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield VScaleProperty.ValuePos value } 
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: VScaleProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield VScaleProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: VScaleProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield VScaleProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: VScaleProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield VScaleProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: VScaleProperty seq, value: System.Double) =
        seq { yield! it; yield VScaleProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: VScaleProperty seq, value: System.String) =
        seq { yield! it; yield VScaleProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VScaleProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VScaleProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VScaleProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VScaleProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VScaleProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VScaleProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VScaleProperty seq, value: System.String) =
        seq { yield! it; yield VScaleProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VScaleProperty seq, value: System.String) =
        seq { yield! it; yield VScaleProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VScaleProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VScaleProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VScaleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VScaleProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VScaleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VScaleProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield VScaleProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScaleProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VScaleProperty seq, value: System.Double) =
        seq { yield! it; yield VScaleProperty.Opacity value } 
    [<CustomOperation("onFormatValue")>]
    member this.OnFormatValue(it: VScaleProperty seq, value: Gtk.FormatValueArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnFormatValue value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: VScaleProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: VScaleProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: VScaleProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VScaleProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VScaleProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VScaleProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VScaleProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VScaleProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VScaleProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VScaleProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VScaleProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VScaleProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VScaleProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VScaleProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VScaleProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VScaleProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VScaleProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VScaleProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VScaleProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VScaleProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VScaleProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VScaleProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VScaleProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VScaleProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VScaleProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VScaleProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VScaleProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VScaleProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VScaleProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VScaleProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VScaleProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VScaleProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VScaleProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VScaleProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VScaleProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VScaleProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VScaleProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VScaleProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VScaleProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VScaleProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VScaleProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VScaleProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VScaleProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VScaleProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VScaleProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VScaleProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VScaleProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VScaleProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VScaleProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VScaleProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VScaleProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VScaleProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VScaleProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VScaleProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VScaleProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VScaleProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VScaleProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VScaleProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VScaleProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VScaleProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VScaleProperty.OnFocused value } 

let prop = VScalePropertyBuilder()

