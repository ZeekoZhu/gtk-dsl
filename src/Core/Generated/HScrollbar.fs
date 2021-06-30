module GtkDsl.Binding.HScrollbar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HScrollbarProperty =
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

let bindProperty (widget: HScrollbar) (prop: HScrollbarProperty) =
    match prop with
    | HScrollbarProperty.Adjustment value -> widget.Adjustment <- value
    | HScrollbarProperty.Inverted value -> widget.Inverted <- value
    | HScrollbarProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | HScrollbarProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | HScrollbarProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | HScrollbarProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | HScrollbarProperty.FillLevel value -> widget.FillLevel <- value
    | HScrollbarProperty.RoundDigits value -> widget.RoundDigits <- value
    | HScrollbarProperty.Name value -> widget.Name <- value
    | HScrollbarProperty.Parent value -> widget.Parent <- value
    | HScrollbarProperty.WidthRequest value -> widget.WidthRequest <- value
    | HScrollbarProperty.HeightRequest value -> widget.HeightRequest <- value
    | HScrollbarProperty.Visible value -> widget.Visible <- value
    | HScrollbarProperty.Sensitive value -> widget.Sensitive <- value
    | HScrollbarProperty.AppPaintable value -> widget.AppPaintable <- value
    | HScrollbarProperty.CanFocus value -> widget.CanFocus <- value
    | HScrollbarProperty.HasFocus value -> widget.HasFocus <- value
    | HScrollbarProperty.IsFocus value -> widget.IsFocus <- value
    | HScrollbarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HScrollbarProperty.CanDefault value -> widget.CanDefault <- value
    | HScrollbarProperty.HasDefault value -> widget.HasDefault <- value
    | HScrollbarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HScrollbarProperty.Style value -> widget.Style <- value
    | HScrollbarProperty.Events value -> widget.Events <- value
    | HScrollbarProperty.NoShowAll value -> widget.NoShowAll <- value
    | HScrollbarProperty.HasTooltip value -> widget.HasTooltip <- value
    | HScrollbarProperty.TooltipText value -> widget.TooltipText <- value
    | HScrollbarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HScrollbarProperty.Window value -> widget.Window <- value
    | HScrollbarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HScrollbarProperty.Halign value -> widget.Halign <- value
    | HScrollbarProperty.Valign value -> widget.Valign <- value
    | HScrollbarProperty.MarginLeft value -> widget.MarginLeft <- value
    | HScrollbarProperty.MarginRight value -> widget.MarginRight <- value
    | HScrollbarProperty.MarginStart value -> widget.MarginStart <- value
    | HScrollbarProperty.MarginEnd value -> widget.MarginEnd <- value
    | HScrollbarProperty.MarginTop value -> widget.MarginTop <- value
    | HScrollbarProperty.MarginBottom value -> widget.MarginBottom <- value
    | HScrollbarProperty.Margin value -> widget.Margin <- value
    | HScrollbarProperty.Hexpand value -> widget.Hexpand <- value
    | HScrollbarProperty.HexpandSet value -> widget.HexpandSet <- value
    | HScrollbarProperty.Vexpand value -> widget.Vexpand <- value
    | HScrollbarProperty.VexpandSet value -> widget.VexpandSet <- value
    | HScrollbarProperty.Expand value -> widget.Expand <- value
    | HScrollbarProperty.Opacity value -> widget.Opacity <- value
    | HScrollbarProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | HScrollbarProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | HScrollbarProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | HScrollbarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HScrollbarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HScrollbarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HScrollbarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HScrollbarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HScrollbarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HScrollbarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HScrollbarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HScrollbarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HScrollbarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HScrollbarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HScrollbarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HScrollbarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HScrollbarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HScrollbarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HScrollbarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HScrollbarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HScrollbarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HScrollbarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HScrollbarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HScrollbarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HScrollbarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HScrollbarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HScrollbarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HScrollbarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HScrollbarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HScrollbarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HScrollbarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HScrollbarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HScrollbarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HScrollbarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HScrollbarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HScrollbarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HScrollbarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HScrollbarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HScrollbarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HScrollbarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HScrollbarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HScrollbarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HScrollbarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HScrollbarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HScrollbarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HScrollbarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HScrollbarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HScrollbarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HScrollbarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HScrollbarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HScrollbarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HScrollbarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HScrollbarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HScrollbarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HScrollbarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HScrollbarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HScrollbarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HScrollbarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HScrollbarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HScrollbarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HScrollbarPropertyBuilder() =
    inherit BasePropertyBuilder<HScrollbarProperty>()
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: HScrollbarProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield HScrollbarProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: HScrollbarProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield HScrollbarProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: HScrollbarProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield HScrollbarProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: HScrollbarProperty seq, value: System.Double) =
        seq { yield! it; yield HScrollbarProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: HScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield HScrollbarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HScrollbarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HScrollbarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HScrollbarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HScrollbarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HScrollbarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HScrollbarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield HScrollbarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield HScrollbarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HScrollbarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HScrollbarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HScrollbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HScrollbarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HScrollbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HScrollbarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield HScrollbarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HScrollbarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HScrollbarProperty seq, value: System.Double) =
        seq { yield! it; yield HScrollbarProperty.Opacity value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: HScrollbarProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: HScrollbarProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: HScrollbarProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HScrollbarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HScrollbarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HScrollbarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HScrollbarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HScrollbarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HScrollbarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HScrollbarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HScrollbarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HScrollbarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HScrollbarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HScrollbarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HScrollbarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HScrollbarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HScrollbarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HScrollbarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HScrollbarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HScrollbarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HScrollbarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HScrollbarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HScrollbarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HScrollbarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HScrollbarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HScrollbarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HScrollbarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HScrollbarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HScrollbarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HScrollbarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HScrollbarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HScrollbarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HScrollbarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HScrollbarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HScrollbarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HScrollbarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HScrollbarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HScrollbarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HScrollbarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HScrollbarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HScrollbarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HScrollbarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HScrollbarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HScrollbarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HScrollbarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HScrollbarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HScrollbarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HScrollbarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HScrollbarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HScrollbarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HScrollbarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HScrollbarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HScrollbarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HScrollbarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HScrollbarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HScrollbarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HScrollbarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HScrollbarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HScrollbarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HScrollbarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HScrollbarProperty.OnFocused value } 

let prop = HScrollbarPropertyBuilder()

