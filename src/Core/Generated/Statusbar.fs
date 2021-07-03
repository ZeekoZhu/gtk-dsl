module Gtk.DSL.Binding.Statusbar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type StatusbarProperty =
    | Spacing of System.Int32
    | Homogeneous of System.Boolean
    | BaselinePosition of Gtk.BaselinePosition
    | Expand of System.Boolean
    | Fill of System.Boolean
    | Padding of System.UInt32
    | PackType of Gtk.PackType
    | Position of System.Int32
    | Orientation of Gtk.Orientation
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
    | Opacity of System.Double
    |  OnTextPopped of (Gtk.TextPoppedArgs -> unit)
    |  OnTextPushed of (Gtk.TextPushedArgs -> unit)
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

let bindProperty (widget: Statusbar) (prop: StatusbarProperty) =
    match prop with
    | StatusbarProperty.Spacing value -> widget.Spacing <- value
    | StatusbarProperty.Homogeneous value -> widget.Homogeneous <- value
    | StatusbarProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | StatusbarProperty.Expand value -> widget.Expand <- value
    | StatusbarProperty.Fill value -> widget.Fill <- value
    | StatusbarProperty.Padding value -> widget.Padding <- value
    | StatusbarProperty.PackType value -> widget.PackType <- value
    | StatusbarProperty.Position value -> widget.Position <- value
    | StatusbarProperty.Orientation value -> widget.Orientation <- value
    | StatusbarProperty.ResizeMode value -> widget.ResizeMode <- value
    | StatusbarProperty.BorderWidth value -> widget.BorderWidth <- value
    | StatusbarProperty.Name value -> widget.Name <- value
    | StatusbarProperty.Parent value -> widget.Parent <- value
    | StatusbarProperty.WidthRequest value -> widget.WidthRequest <- value
    | StatusbarProperty.HeightRequest value -> widget.HeightRequest <- value
    | StatusbarProperty.Visible value -> widget.Visible <- value
    | StatusbarProperty.Sensitive value -> widget.Sensitive <- value
    | StatusbarProperty.AppPaintable value -> widget.AppPaintable <- value
    | StatusbarProperty.CanFocus value -> widget.CanFocus <- value
    | StatusbarProperty.HasFocus value -> widget.HasFocus <- value
    | StatusbarProperty.IsFocus value -> widget.IsFocus <- value
    | StatusbarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | StatusbarProperty.CanDefault value -> widget.CanDefault <- value
    | StatusbarProperty.HasDefault value -> widget.HasDefault <- value
    | StatusbarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | StatusbarProperty.Style value -> widget.Style <- value
    | StatusbarProperty.Events value -> widget.Events <- value
    | StatusbarProperty.NoShowAll value -> widget.NoShowAll <- value
    | StatusbarProperty.HasTooltip value -> widget.HasTooltip <- value
    | StatusbarProperty.TooltipText value -> widget.TooltipText <- value
    | StatusbarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | StatusbarProperty.Window value -> widget.Window <- value
    | StatusbarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | StatusbarProperty.Halign value -> widget.Halign <- value
    | StatusbarProperty.Valign value -> widget.Valign <- value
    | StatusbarProperty.MarginLeft value -> widget.MarginLeft <- value
    | StatusbarProperty.MarginRight value -> widget.MarginRight <- value
    | StatusbarProperty.MarginStart value -> widget.MarginStart <- value
    | StatusbarProperty.MarginEnd value -> widget.MarginEnd <- value
    | StatusbarProperty.MarginTop value -> widget.MarginTop <- value
    | StatusbarProperty.MarginBottom value -> widget.MarginBottom <- value
    | StatusbarProperty.Margin value -> widget.Margin <- value
    | StatusbarProperty.Hexpand value -> widget.Hexpand <- value
    | StatusbarProperty.HexpandSet value -> widget.HexpandSet <- value
    | StatusbarProperty.Vexpand value -> widget.Vexpand <- value
    | StatusbarProperty.VexpandSet value -> widget.VexpandSet <- value
    | StatusbarProperty.Opacity value -> widget.Opacity <- value
    | StatusbarProperty.OnTextPopped handler -> 
        let disposable = widget.TextPopped.Subscribe(handler)
        registerListener widget "TextPopped" disposable
    | StatusbarProperty.OnTextPushed handler -> 
        let disposable = widget.TextPushed.Subscribe(handler)
        registerListener widget "TextPushed" disposable
    | StatusbarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | StatusbarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | StatusbarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | StatusbarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | StatusbarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | StatusbarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | StatusbarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | StatusbarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | StatusbarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | StatusbarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | StatusbarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | StatusbarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | StatusbarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | StatusbarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | StatusbarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | StatusbarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | StatusbarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | StatusbarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | StatusbarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | StatusbarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | StatusbarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | StatusbarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | StatusbarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | StatusbarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | StatusbarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | StatusbarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | StatusbarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | StatusbarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | StatusbarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | StatusbarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | StatusbarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | StatusbarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | StatusbarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | StatusbarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | StatusbarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | StatusbarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | StatusbarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | StatusbarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | StatusbarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | StatusbarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | StatusbarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | StatusbarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | StatusbarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | StatusbarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | StatusbarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | StatusbarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | StatusbarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | StatusbarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | StatusbarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | StatusbarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | StatusbarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | StatusbarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | StatusbarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | StatusbarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | StatusbarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | StatusbarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | StatusbarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | StatusbarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | StatusbarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | StatusbarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type StatusbarPropertyBuilder() =
    inherit BasePropertyBuilder<StatusbarProperty>()
    [<CustomOperation("spacing")>]
    member this.Spacing(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: StatusbarProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield StatusbarProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: StatusbarProperty seq, value: System.UInt32) =
        seq { yield! it; yield StatusbarProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: StatusbarProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield StatusbarProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: StatusbarProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield StatusbarProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: StatusbarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield StatusbarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: StatusbarProperty seq, value: System.UInt32) =
        seq { yield! it; yield StatusbarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: StatusbarProperty seq, value: System.String) =
        seq { yield! it; yield StatusbarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: StatusbarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield StatusbarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: StatusbarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield StatusbarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: StatusbarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield StatusbarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: StatusbarProperty seq, value: System.String) =
        seq { yield! it; yield StatusbarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: StatusbarProperty seq, value: System.String) =
        seq { yield! it; yield StatusbarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: StatusbarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield StatusbarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: StatusbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StatusbarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: StatusbarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StatusbarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: StatusbarProperty seq, value: System.Int32) =
        seq { yield! it; yield StatusbarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: StatusbarProperty seq, value: System.Boolean) =
        seq { yield! it; yield StatusbarProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: StatusbarProperty seq, value: System.Double) =
        seq { yield! it; yield StatusbarProperty.Opacity value } 
    [<CustomOperation("onTextPopped")>]
    member this.OnTextPopped(it: StatusbarProperty seq, value: Gtk.TextPoppedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnTextPopped value } 
    [<CustomOperation("onTextPushed")>]
    member this.OnTextPushed(it: StatusbarProperty seq, value: Gtk.TextPushedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnTextPushed value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: StatusbarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: StatusbarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: StatusbarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: StatusbarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: StatusbarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: StatusbarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: StatusbarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: StatusbarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: StatusbarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: StatusbarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: StatusbarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: StatusbarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: StatusbarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: StatusbarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: StatusbarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: StatusbarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: StatusbarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: StatusbarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: StatusbarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: StatusbarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: StatusbarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: StatusbarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: StatusbarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: StatusbarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: StatusbarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: StatusbarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: StatusbarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: StatusbarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: StatusbarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: StatusbarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: StatusbarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: StatusbarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: StatusbarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: StatusbarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: StatusbarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: StatusbarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: StatusbarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: StatusbarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: StatusbarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: StatusbarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: StatusbarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: StatusbarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: StatusbarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: StatusbarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: StatusbarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: StatusbarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: StatusbarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: StatusbarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: StatusbarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: StatusbarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: StatusbarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: StatusbarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: StatusbarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: StatusbarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: StatusbarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: StatusbarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: StatusbarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: StatusbarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: StatusbarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: StatusbarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield StatusbarProperty.OnFocused value } 

let prop = StatusbarPropertyBuilder()

type StatusbarDescriptor(props) =
    inherit BaseWidgetDescriptor<Statusbar, StatusbarProperty>(props, bindProperty)
    override this.CreateTyped() = new Statusbar()

let statusbar props = StatusbarDescriptor(props)

