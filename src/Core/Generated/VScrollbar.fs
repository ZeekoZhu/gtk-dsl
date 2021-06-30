module GtkDsl.Binding.VScrollbar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VScrollbarProperty =
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

let bindProperty (widget: VScrollbar) (prop: VScrollbarProperty) =
    match prop with
    | VScrollbarProperty.Adjustment value -> widget.Adjustment <- value
    | VScrollbarProperty.Inverted value -> widget.Inverted <- value
    | VScrollbarProperty.LowerStepperSensitivity value -> widget.LowerStepperSensitivity <- value
    | VScrollbarProperty.UpperStepperSensitivity value -> widget.UpperStepperSensitivity <- value
    | VScrollbarProperty.ShowFillLevel value -> widget.ShowFillLevel <- value
    | VScrollbarProperty.RestrictToFillLevel value -> widget.RestrictToFillLevel <- value
    | VScrollbarProperty.FillLevel value -> widget.FillLevel <- value
    | VScrollbarProperty.RoundDigits value -> widget.RoundDigits <- value
    | VScrollbarProperty.Name value -> widget.Name <- value
    | VScrollbarProperty.Parent value -> widget.Parent <- value
    | VScrollbarProperty.WidthRequest value -> widget.WidthRequest <- value
    | VScrollbarProperty.HeightRequest value -> widget.HeightRequest <- value
    | VScrollbarProperty.Visible value -> widget.Visible <- value
    | VScrollbarProperty.Sensitive value -> widget.Sensitive <- value
    | VScrollbarProperty.AppPaintable value -> widget.AppPaintable <- value
    | VScrollbarProperty.CanFocus value -> widget.CanFocus <- value
    | VScrollbarProperty.HasFocus value -> widget.HasFocus <- value
    | VScrollbarProperty.IsFocus value -> widget.IsFocus <- value
    | VScrollbarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VScrollbarProperty.CanDefault value -> widget.CanDefault <- value
    | VScrollbarProperty.HasDefault value -> widget.HasDefault <- value
    | VScrollbarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VScrollbarProperty.Style value -> widget.Style <- value
    | VScrollbarProperty.Events value -> widget.Events <- value
    | VScrollbarProperty.NoShowAll value -> widget.NoShowAll <- value
    | VScrollbarProperty.HasTooltip value -> widget.HasTooltip <- value
    | VScrollbarProperty.TooltipText value -> widget.TooltipText <- value
    | VScrollbarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VScrollbarProperty.Window value -> widget.Window <- value
    | VScrollbarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VScrollbarProperty.Halign value -> widget.Halign <- value
    | VScrollbarProperty.Valign value -> widget.Valign <- value
    | VScrollbarProperty.MarginLeft value -> widget.MarginLeft <- value
    | VScrollbarProperty.MarginRight value -> widget.MarginRight <- value
    | VScrollbarProperty.MarginStart value -> widget.MarginStart <- value
    | VScrollbarProperty.MarginEnd value -> widget.MarginEnd <- value
    | VScrollbarProperty.MarginTop value -> widget.MarginTop <- value
    | VScrollbarProperty.MarginBottom value -> widget.MarginBottom <- value
    | VScrollbarProperty.Margin value -> widget.Margin <- value
    | VScrollbarProperty.Hexpand value -> widget.Hexpand <- value
    | VScrollbarProperty.HexpandSet value -> widget.HexpandSet <- value
    | VScrollbarProperty.Vexpand value -> widget.Vexpand <- value
    | VScrollbarProperty.VexpandSet value -> widget.VexpandSet <- value
    | VScrollbarProperty.Expand value -> widget.Expand <- value
    | VScrollbarProperty.Opacity value -> widget.Opacity <- value
    | VScrollbarProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | VScrollbarProperty.OnMoveSlider handler -> 
        let disposable = widget.MoveSlider.Subscribe(handler)
        registerListener widget "MoveSlider" disposable
    | VScrollbarProperty.OnAdjustBounds handler -> 
        let disposable = widget.AdjustBounds.Subscribe(handler)
        registerListener widget "AdjustBounds" disposable
    | VScrollbarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VScrollbarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VScrollbarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VScrollbarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VScrollbarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VScrollbarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VScrollbarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VScrollbarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VScrollbarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VScrollbarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VScrollbarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VScrollbarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VScrollbarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VScrollbarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VScrollbarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VScrollbarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VScrollbarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VScrollbarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VScrollbarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VScrollbarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VScrollbarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VScrollbarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VScrollbarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VScrollbarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VScrollbarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VScrollbarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VScrollbarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VScrollbarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VScrollbarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VScrollbarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VScrollbarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VScrollbarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VScrollbarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VScrollbarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VScrollbarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VScrollbarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VScrollbarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VScrollbarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VScrollbarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VScrollbarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VScrollbarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VScrollbarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VScrollbarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VScrollbarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VScrollbarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VScrollbarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VScrollbarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VScrollbarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VScrollbarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VScrollbarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VScrollbarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VScrollbarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VScrollbarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VScrollbarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VScrollbarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VScrollbarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VScrollbarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VScrollbarPropertyBuilder() =
    inherit BasePropertyBuilder<VScrollbarProperty>()
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: VScrollbarProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield VScrollbarProperty.Adjustment value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.Inverted value } 
    [<CustomOperation("lowerStepperSensitivity")>]
    member this.LowerStepperSensitivity(it: VScrollbarProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield VScrollbarProperty.LowerStepperSensitivity value } 
    [<CustomOperation("upperStepperSensitivity")>]
    member this.UpperStepperSensitivity(it: VScrollbarProperty seq, value: Gtk.SensitivityType) =
        seq { yield! it; yield VScrollbarProperty.UpperStepperSensitivity value } 
    [<CustomOperation("showFillLevel")>]
    member this.ShowFillLevel(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.ShowFillLevel value } 
    [<CustomOperation("restrictToFillLevel")>]
    member this.RestrictToFillLevel(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.RestrictToFillLevel value } 
    [<CustomOperation("fillLevel")>]
    member this.FillLevel(it: VScrollbarProperty seq, value: System.Double) =
        seq { yield! it; yield VScrollbarProperty.FillLevel value } 
    [<CustomOperation("roundDigits")>]
    member this.RoundDigits(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.RoundDigits value } 
    [<CustomOperation("name")>]
    member this.Name(it: VScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield VScrollbarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VScrollbarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VScrollbarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VScrollbarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VScrollbarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VScrollbarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VScrollbarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield VScrollbarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VScrollbarProperty seq, value: System.String) =
        seq { yield! it; yield VScrollbarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VScrollbarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VScrollbarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VScrollbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VScrollbarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VScrollbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VScrollbarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VScrollbarProperty seq, value: System.Int32) =
        seq { yield! it; yield VScrollbarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VScrollbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield VScrollbarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VScrollbarProperty seq, value: System.Double) =
        seq { yield! it; yield VScrollbarProperty.Opacity value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: VScrollbarProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnChangeValue value } 
    [<CustomOperation("onMoveSlider")>]
    member this.OnMoveSlider(it: VScrollbarProperty seq, value: Gtk.MoveSliderArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnMoveSlider value } 
    [<CustomOperation("onAdjustBounds")>]
    member this.OnAdjustBounds(it: VScrollbarProperty seq, value: Gtk.AdjustBoundsArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnAdjustBounds value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VScrollbarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VScrollbarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VScrollbarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VScrollbarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VScrollbarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VScrollbarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VScrollbarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VScrollbarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VScrollbarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VScrollbarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VScrollbarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VScrollbarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VScrollbarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VScrollbarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VScrollbarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VScrollbarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VScrollbarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VScrollbarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VScrollbarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VScrollbarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VScrollbarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VScrollbarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VScrollbarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VScrollbarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VScrollbarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VScrollbarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VScrollbarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VScrollbarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VScrollbarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VScrollbarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VScrollbarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VScrollbarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VScrollbarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VScrollbarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VScrollbarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VScrollbarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VScrollbarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VScrollbarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VScrollbarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VScrollbarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VScrollbarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VScrollbarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VScrollbarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VScrollbarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VScrollbarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VScrollbarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VScrollbarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VScrollbarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VScrollbarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VScrollbarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VScrollbarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VScrollbarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VScrollbarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VScrollbarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VScrollbarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VScrollbarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VScrollbarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VScrollbarProperty.OnFocused value } 

let prop = VScrollbarPropertyBuilder()

