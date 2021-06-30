module GtkDsl.Binding.Scale
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ScaleProperty =
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

let bindProperty (widget: Scale) (prop: ScaleProperty) =
    match prop with
    | ScaleProperty.Digits value -> widget.Digits <- value
    | ScaleProperty.DrawValue value -> widget.DrawValue <- value
    | ScaleProperty.HasOrigin value -> widget.HasOrigin <- value
    | ScaleProperty.ValuePos value -> widget.ValuePos <- value
    | ScaleProperty.Adjustment value -> widget.Adjustment <- value
    | ScaleProperty.Inverted value -> widget.Inverted <- value
    | ScaleProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | ScaleProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | ScaleProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | ScaleProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | ScaleProperty.FillLevel value -> widget.FillLevel <- value
    | ScaleProperty.RoundDigits value -> widget.RoundDigits <- value
    | ScaleProperty.Name value -> widget.Name <- value
    | ScaleProperty.Parent value -> widget.Parent <- value
    | ScaleProperty.WidthRequest value -> widget.WidthRequest <- value
    | ScaleProperty.HeightRequest value -> widget.HeightRequest <- value
    | ScaleProperty.Visible value -> widget.Visible <- value
    | ScaleProperty.Sensitive value -> widget.Sensitive <- value
    | ScaleProperty.AppPaintable value -> widget.AppPaintable <- value
    | ScaleProperty.CanFocus value -> widget.CanFocus <- value
    | ScaleProperty.HasFocus value -> widget.HasFocus <- value
    | ScaleProperty.IsFocus value -> widget.IsFocus <- value
    | ScaleProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ScaleProperty.CanDefault value -> widget.CanDefault <- value
    | ScaleProperty.HasDefault value -> widget.HasDefault <- value
    | ScaleProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ScaleProperty.Style value -> widget.Style <- value
    | ScaleProperty.Events value -> widget.Events <- value
    | ScaleProperty.NoShowAll value -> widget.NoShowAll <- value
    | ScaleProperty.HasTooltip value -> widget.HasTooltip <- value
    | ScaleProperty.TooltipText value -> widget.TooltipText <- value
    | ScaleProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ScaleProperty.Window value -> widget.Window <- value
    | ScaleProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ScaleProperty.Halign value -> widget.Halign <- value
    | ScaleProperty.Valign value -> widget.Valign <- value
    | ScaleProperty.MarginLeft value -> widget.MarginLeft <- value
    | ScaleProperty.MarginRight value -> widget.MarginRight <- value
    | ScaleProperty.MarginStart value -> widget.MarginStart <- value
    | ScaleProperty.MarginEnd value -> widget.MarginEnd <- value
    | ScaleProperty.MarginTop value -> widget.MarginTop <- value
    | ScaleProperty.MarginBottom value -> widget.MarginBottom <- value
    | ScaleProperty.Margin value -> widget.Margin <- value
    | ScaleProperty.Hexpand value -> widget.Hexpand <- value
    | ScaleProperty.HexpandSet value -> widget.HexpandSet <- value
    | ScaleProperty.Vexpand value -> widget.Vexpand <- value
    | ScaleProperty.VexpandSet value -> widget.VexpandSet <- value
    | ScaleProperty.Expand value -> widget.Expand <- value
    | ScaleProperty.Opacity value -> widget.Opacity <- value
    | ScaleProperty.OnFormatValue handler -> 
        let disposable = widget.FormatValue.Subscribe(handler)
        registerListener widget "FormatValue" disposable
    | ScaleProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | ScaleProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | ScaleProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | ScaleProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ScaleProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ScaleProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ScaleProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ScaleProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ScaleProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ScaleProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ScaleProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ScaleProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ScaleProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ScaleProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ScaleProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ScaleProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ScaleProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ScaleProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ScaleProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ScaleProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ScaleProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ScaleProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ScaleProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ScaleProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ScaleProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ScaleProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ScaleProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ScaleProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ScaleProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ScaleProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ScaleProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ScaleProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ScaleProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ScaleProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ScaleProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ScaleProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ScaleProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ScaleProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ScaleProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ScaleProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ScaleProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ScaleProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ScaleProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ScaleProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ScaleProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ScaleProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ScaleProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ScaleProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ScaleProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ScaleProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ScaleProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ScaleProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ScaleProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ScaleProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ScaleProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ScaleProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ScaleProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ScaleProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ScaleProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ScaleProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ScalePropertyBuilder() =
    inherit BasePropertyBuilder<ScaleProperty>()
    [<CustomOperation("digits")>]
    member this.Digits(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.Digits value } 
    [<CustomOperation("drawValue")>]
    member this.DrawValue(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.DrawValue value } 
    [<CustomOperation("hasOrigin")>]
    member this.HasOrigin(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.HasOrigin value } 
    [<CustomOperation("valuePos")>]
    member this.ValuePos(it: ScaleProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield ScaleProperty.ValuePos value } 
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: ScaleProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ScaleProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: ScaleProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield ScaleProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: ScaleProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield ScaleProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: ScaleProperty seq, value: System.Double) =
        seq { yield! it; yield ScaleProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: ScaleProperty seq, value: System.String) =
        seq { yield! it; yield ScaleProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ScaleProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ScaleProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ScaleProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ScaleProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ScaleProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ScaleProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ScaleProperty seq, value: System.String) =
        seq { yield! it; yield ScaleProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ScaleProperty seq, value: System.String) =
        seq { yield! it; yield ScaleProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ScaleProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ScaleProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ScaleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScaleProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ScaleProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScaleProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ScaleProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ScaleProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ScaleProperty seq, value: System.Double) =
        seq { yield! it; yield ScaleProperty.Opacity value } 
    [<CustomOperation("onFormatValue")>]
    member this.OnFormatValue(it: ScaleProperty seq, value: Gtk.FormatValueArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnFormatValue value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: ScaleProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: ScaleProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: ScaleProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ScaleProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ScaleProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ScaleProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ScaleProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ScaleProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ScaleProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ScaleProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ScaleProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ScaleProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ScaleProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ScaleProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ScaleProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ScaleProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ScaleProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ScaleProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ScaleProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ScaleProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ScaleProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ScaleProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ScaleProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ScaleProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ScaleProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ScaleProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ScaleProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ScaleProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ScaleProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ScaleProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ScaleProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ScaleProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ScaleProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ScaleProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ScaleProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ScaleProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ScaleProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ScaleProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ScaleProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ScaleProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ScaleProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ScaleProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ScaleProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ScaleProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ScaleProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ScaleProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ScaleProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ScaleProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ScaleProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ScaleProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ScaleProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ScaleProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ScaleProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ScaleProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ScaleProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ScaleProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ScaleProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ScaleProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ScaleProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ScaleProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ScaleProperty.OnFocused value } 

let prop = ScalePropertyBuilder()

