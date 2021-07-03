module Gtk.DSL.Binding.ProgressBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ProgressBarProperty =
    | Inverted of System.Boolean
    | Fraction of System.Double
    | PulseStep of System.Double
    | Text of System.String
    | ShowText of System.Boolean
    | Ellipsize of Pango.EllipsizeMode
    | Xspacing of System.Int32
    | Yspacing of System.Int32
    | MinHorizontalBarWidth of System.Int32
    | MinHorizontalBarHeight of System.Int32
    | MinVerticalBarWidth of System.Int32
    | MinVerticalBarHeight of System.Int32
    | Orientation of Gtk.Orientation
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

let bindProperty (widget: ProgressBar) (prop: ProgressBarProperty) =
    match prop with
    | ProgressBarProperty.Inverted value -> widget.Inverted <- value
    | ProgressBarProperty.Fraction value -> widget.Fraction <- value
    | ProgressBarProperty.PulseStep value -> widget.PulseStep <- value
    | ProgressBarProperty.Text value -> widget.Text <- value
    | ProgressBarProperty.ShowText value -> widget.ShowText <- value
    | ProgressBarProperty.Ellipsize value -> widget.Ellipsize <- value
    | ProgressBarProperty.Xspacing value -> widget.Xspacing <- value
    | ProgressBarProperty.Yspacing value -> widget.Yspacing <- value
    | ProgressBarProperty.MinHorizontalBarWidth value -> widget.MinHorizontalBarWidth <- value
    | ProgressBarProperty.MinHorizontalBarHeight value -> widget.MinHorizontalBarHeight <- value
    | ProgressBarProperty.MinVerticalBarWidth value -> widget.MinVerticalBarWidth <- value
    | ProgressBarProperty.MinVerticalBarHeight value -> widget.MinVerticalBarHeight <- value
    | ProgressBarProperty.Orientation value -> widget.Orientation <- value
    | ProgressBarProperty.Name value -> widget.Name <- value
    | ProgressBarProperty.Parent value -> widget.Parent <- value
    | ProgressBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | ProgressBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | ProgressBarProperty.Visible value -> widget.Visible <- value
    | ProgressBarProperty.Sensitive value -> widget.Sensitive <- value
    | ProgressBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | ProgressBarProperty.CanFocus value -> widget.CanFocus <- value
    | ProgressBarProperty.HasFocus value -> widget.HasFocus <- value
    | ProgressBarProperty.IsFocus value -> widget.IsFocus <- value
    | ProgressBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ProgressBarProperty.CanDefault value -> widget.CanDefault <- value
    | ProgressBarProperty.HasDefault value -> widget.HasDefault <- value
    | ProgressBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ProgressBarProperty.Style value -> widget.Style <- value
    | ProgressBarProperty.Events value -> widget.Events <- value
    | ProgressBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | ProgressBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | ProgressBarProperty.TooltipText value -> widget.TooltipText <- value
    | ProgressBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ProgressBarProperty.Window value -> widget.Window <- value
    | ProgressBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ProgressBarProperty.Halign value -> widget.Halign <- value
    | ProgressBarProperty.Valign value -> widget.Valign <- value
    | ProgressBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | ProgressBarProperty.MarginRight value -> widget.MarginRight <- value
    | ProgressBarProperty.MarginStart value -> widget.MarginStart <- value
    | ProgressBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | ProgressBarProperty.MarginTop value -> widget.MarginTop <- value
    | ProgressBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | ProgressBarProperty.Margin value -> widget.Margin <- value
    | ProgressBarProperty.Hexpand value -> widget.Hexpand <- value
    | ProgressBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | ProgressBarProperty.Vexpand value -> widget.Vexpand <- value
    | ProgressBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | ProgressBarProperty.Expand value -> widget.Expand <- value
    | ProgressBarProperty.Opacity value -> widget.Opacity <- value
    | ProgressBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ProgressBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ProgressBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ProgressBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ProgressBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ProgressBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ProgressBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ProgressBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ProgressBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ProgressBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ProgressBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ProgressBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ProgressBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ProgressBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ProgressBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ProgressBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ProgressBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ProgressBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ProgressBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ProgressBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ProgressBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ProgressBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ProgressBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ProgressBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ProgressBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ProgressBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ProgressBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ProgressBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ProgressBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ProgressBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ProgressBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ProgressBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ProgressBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ProgressBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ProgressBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ProgressBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ProgressBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ProgressBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ProgressBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ProgressBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ProgressBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ProgressBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ProgressBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ProgressBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ProgressBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ProgressBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ProgressBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ProgressBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ProgressBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ProgressBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ProgressBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ProgressBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ProgressBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ProgressBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ProgressBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ProgressBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ProgressBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ProgressBarPropertyBuilder() =
    inherit BasePropertyBuilder<ProgressBarProperty>()
    [<CustomOperation("inverted")>]
    member this.Inverted(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.Inverted value } 
    [<CustomOperation("fraction")>]
    member this.Fraction(it: ProgressBarProperty seq, value: System.Double) =
        seq { yield! it; yield ProgressBarProperty.Fraction value } 
    [<CustomOperation("pulseStep")>]
    member this.PulseStep(it: ProgressBarProperty seq, value: System.Double) =
        seq { yield! it; yield ProgressBarProperty.PulseStep value } 
    [<CustomOperation("text")>]
    member this.Text(it: ProgressBarProperty seq, value: System.String) =
        seq { yield! it; yield ProgressBarProperty.Text value } 
    [<CustomOperation("showText")>]
    member this.ShowText(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.ShowText value } 
    [<CustomOperation("ellipsize")>]
    member this.Ellipsize(it: ProgressBarProperty seq, value: Pango.EllipsizeMode) =
        seq { yield! it; yield ProgressBarProperty.Ellipsize value } 
    [<CustomOperation("xspacing")>]
    member this.Xspacing(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.Xspacing value } 
    [<CustomOperation("yspacing")>]
    member this.Yspacing(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.Yspacing value } 
    [<CustomOperation("minHorizontalBarWidth")>]
    member this.MinHorizontalBarWidth(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MinHorizontalBarWidth value } 
    [<CustomOperation("minHorizontalBarHeight")>]
    member this.MinHorizontalBarHeight(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MinHorizontalBarHeight value } 
    [<CustomOperation("minVerticalBarWidth")>]
    member this.MinVerticalBarWidth(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MinVerticalBarWidth value } 
    [<CustomOperation("minVerticalBarHeight")>]
    member this.MinVerticalBarHeight(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MinVerticalBarHeight value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ProgressBarProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ProgressBarProperty.Orientation value } 
    [<CustomOperation("name")>]
    member this.Name(it: ProgressBarProperty seq, value: System.String) =
        seq { yield! it; yield ProgressBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ProgressBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ProgressBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ProgressBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ProgressBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ProgressBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ProgressBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ProgressBarProperty seq, value: System.String) =
        seq { yield! it; yield ProgressBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ProgressBarProperty seq, value: System.String) =
        seq { yield! it; yield ProgressBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ProgressBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ProgressBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ProgressBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ProgressBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ProgressBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ProgressBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ProgressBarProperty seq, value: System.Int32) =
        seq { yield! it; yield ProgressBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ProgressBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield ProgressBarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ProgressBarProperty seq, value: System.Double) =
        seq { yield! it; yield ProgressBarProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ProgressBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ProgressBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ProgressBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ProgressBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ProgressBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ProgressBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ProgressBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ProgressBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ProgressBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ProgressBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ProgressBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ProgressBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ProgressBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ProgressBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ProgressBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ProgressBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ProgressBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ProgressBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ProgressBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ProgressBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ProgressBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ProgressBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ProgressBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ProgressBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ProgressBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ProgressBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ProgressBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ProgressBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ProgressBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ProgressBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ProgressBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ProgressBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ProgressBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ProgressBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ProgressBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ProgressBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ProgressBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ProgressBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ProgressBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ProgressBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ProgressBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ProgressBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ProgressBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ProgressBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ProgressBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ProgressBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ProgressBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ProgressBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ProgressBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ProgressBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ProgressBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ProgressBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ProgressBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ProgressBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ProgressBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ProgressBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ProgressBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ProgressBarProperty.OnFocused value } 

let prop = ProgressBarPropertyBuilder()

type ProgressBarDescriptor(props) =
    inherit BaseWidgetDescriptor<ProgressBar, ProgressBarProperty>(props, bindProperty)
    override this.CreateTyped() = new ProgressBar()

let progressBar props = ProgressBarDescriptor(props)

