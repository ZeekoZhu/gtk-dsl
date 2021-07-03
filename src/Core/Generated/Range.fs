module Gtk.DSL.Binding.Range
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RangeProperty =
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

let bindProperty (widget: Range) (prop: RangeProperty) =
    match prop with
    | RangeProperty.Adjustment value -> widget.Adjustment <- value
    | RangeProperty.Inverted value -> widget.Inverted <- value
    | RangeProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | RangeProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | RangeProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | RangeProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | RangeProperty.FillLevel value -> widget.FillLevel <- value
    | RangeProperty.RoundDigits value -> widget.RoundDigits <- value
    | RangeProperty.Name value -> widget.Name <- value
    | RangeProperty.Parent value -> widget.Parent <- value
    | RangeProperty.WidthRequest value -> widget.WidthRequest <- value
    | RangeProperty.HeightRequest value -> widget.HeightRequest <- value
    | RangeProperty.Visible value -> widget.Visible <- value
    | RangeProperty.Sensitive value -> widget.Sensitive <- value
    | RangeProperty.AppPaintable value -> widget.AppPaintable <- value
    | RangeProperty.CanFocus value -> widget.CanFocus <- value
    | RangeProperty.HasFocus value -> widget.HasFocus <- value
    | RangeProperty.IsFocus value -> widget.IsFocus <- value
    | RangeProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RangeProperty.CanDefault value -> widget.CanDefault <- value
    | RangeProperty.HasDefault value -> widget.HasDefault <- value
    | RangeProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RangeProperty.Style value -> widget.Style <- value
    | RangeProperty.Events value -> widget.Events <- value
    | RangeProperty.NoShowAll value -> widget.NoShowAll <- value
    | RangeProperty.HasTooltip value -> widget.HasTooltip <- value
    | RangeProperty.TooltipText value -> widget.TooltipText <- value
    | RangeProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RangeProperty.Window value -> widget.Window <- value
    | RangeProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RangeProperty.Halign value -> widget.Halign <- value
    | RangeProperty.Valign value -> widget.Valign <- value
    | RangeProperty.MarginLeft value -> widget.MarginLeft <- value
    | RangeProperty.MarginRight value -> widget.MarginRight <- value
    | RangeProperty.MarginStart value -> widget.MarginStart <- value
    | RangeProperty.MarginEnd value -> widget.MarginEnd <- value
    | RangeProperty.MarginTop value -> widget.MarginTop <- value
    | RangeProperty.MarginBottom value -> widget.MarginBottom <- value
    | RangeProperty.Margin value -> widget.Margin <- value
    | RangeProperty.Hexpand value -> widget.Hexpand <- value
    | RangeProperty.HexpandSet value -> widget.HexpandSet <- value
    | RangeProperty.Vexpand value -> widget.Vexpand <- value
    | RangeProperty.VexpandSet value -> widget.VexpandSet <- value
    | RangeProperty.Expand value -> widget.Expand <- value
    | RangeProperty.Opacity value -> widget.Opacity <- value
    | RangeProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | RangeProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | RangeProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | RangeProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RangeProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RangeProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RangeProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RangeProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RangeProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RangeProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RangeProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RangeProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RangeProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RangeProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RangeProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RangeProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RangeProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RangeProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RangeProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RangeProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RangeProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RangeProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RangeProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RangeProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RangeProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RangeProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RangeProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RangeProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RangeProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RangeProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RangeProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RangeProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RangeProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RangeProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RangeProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RangeProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RangeProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RangeProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RangeProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RangeProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RangeProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RangeProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RangeProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RangeProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RangeProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RangeProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RangeProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RangeProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RangeProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RangeProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RangeProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RangeProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RangeProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RangeProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RangeProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RangeProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RangeProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RangeProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RangeProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RangeProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RangePropertyBuilder() =
    inherit BasePropertyBuilder<RangeProperty>()
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: RangeProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield RangeProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: RangeProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield RangeProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: RangeProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield RangeProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: RangeProperty seq, value: System.Double) =
        seq { yield! it; yield RangeProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: RangeProperty seq, value: System.String) =
        seq { yield! it; yield RangeProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RangeProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RangeProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RangeProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RangeProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RangeProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RangeProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RangeProperty seq, value: System.String) =
        seq { yield! it; yield RangeProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RangeProperty seq, value: System.String) =
        seq { yield! it; yield RangeProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RangeProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RangeProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RangeProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RangeProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RangeProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RangeProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RangeProperty seq, value: System.Int32) =
        seq { yield! it; yield RangeProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RangeProperty seq, value: System.Boolean) =
        seq { yield! it; yield RangeProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RangeProperty seq, value: System.Double) =
        seq { yield! it; yield RangeProperty.Opacity value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: RangeProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: RangeProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: RangeProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RangeProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RangeProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RangeProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RangeProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RangeProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RangeProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RangeProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RangeProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RangeProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RangeProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RangeProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RangeProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RangeProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RangeProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RangeProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RangeProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RangeProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RangeProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RangeProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RangeProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RangeProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RangeProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RangeProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RangeProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RangeProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RangeProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RangeProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RangeProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RangeProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RangeProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RangeProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RangeProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RangeProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RangeProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RangeProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RangeProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RangeProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RangeProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RangeProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RangeProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RangeProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RangeProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RangeProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RangeProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RangeProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RangeProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RangeProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RangeProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RangeProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RangeProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RangeProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RangeProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RangeProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RangeProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RangeProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RangeProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RangeProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RangeProperty.OnFocused value } 

let prop = RangePropertyBuilder()

