module Gtk.DSL.Binding.InfoBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type InfoBarProperty =
    | MessageType of Gtk.MessageType
    | ShowCloseButton of System.Boolean
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
    |  OnRespond of (Gtk.RespondArgs -> unit)
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

let bindProperty (widget: InfoBar) (prop: InfoBarProperty) =
    match prop with
    | InfoBarProperty.MessageType value -> widget.MessageType <- value
    | InfoBarProperty.ShowCloseButton value -> widget.ShowCloseButton <- value
    | InfoBarProperty.Spacing value -> widget.Spacing <- value
    | InfoBarProperty.Homogeneous value -> widget.Homogeneous <- value
    | InfoBarProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | InfoBarProperty.Expand value -> widget.Expand <- value
    | InfoBarProperty.Fill value -> widget.Fill <- value
    | InfoBarProperty.Padding value -> widget.Padding <- value
    | InfoBarProperty.PackType value -> widget.PackType <- value
    | InfoBarProperty.Position value -> widget.Position <- value
    | InfoBarProperty.Orientation value -> widget.Orientation <- value
    | InfoBarProperty.ResizeMode value -> widget.ResizeMode <- value
    | InfoBarProperty.BorderWidth value -> widget.BorderWidth <- value
    | InfoBarProperty.Name value -> widget.Name <- value
    | InfoBarProperty.Parent value -> widget.Parent <- value
    | InfoBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | InfoBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | InfoBarProperty.Visible value -> widget.Visible <- value
    | InfoBarProperty.Sensitive value -> widget.Sensitive <- value
    | InfoBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | InfoBarProperty.CanFocus value -> widget.CanFocus <- value
    | InfoBarProperty.HasFocus value -> widget.HasFocus <- value
    | InfoBarProperty.IsFocus value -> widget.IsFocus <- value
    | InfoBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | InfoBarProperty.CanDefault value -> widget.CanDefault <- value
    | InfoBarProperty.HasDefault value -> widget.HasDefault <- value
    | InfoBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | InfoBarProperty.Style value -> widget.Style <- value
    | InfoBarProperty.Events value -> widget.Events <- value
    | InfoBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | InfoBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | InfoBarProperty.TooltipText value -> widget.TooltipText <- value
    | InfoBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | InfoBarProperty.Window value -> widget.Window <- value
    | InfoBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | InfoBarProperty.Halign value -> widget.Halign <- value
    | InfoBarProperty.Valign value -> widget.Valign <- value
    | InfoBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | InfoBarProperty.MarginRight value -> widget.MarginRight <- value
    | InfoBarProperty.MarginStart value -> widget.MarginStart <- value
    | InfoBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | InfoBarProperty.MarginTop value -> widget.MarginTop <- value
    | InfoBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | InfoBarProperty.Margin value -> widget.Margin <- value
    | InfoBarProperty.Hexpand value -> widget.Hexpand <- value
    | InfoBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | InfoBarProperty.Vexpand value -> widget.Vexpand <- value
    | InfoBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | InfoBarProperty.Opacity value -> widget.Opacity <- value
    | InfoBarProperty.OnRespond handler -> 
        let disposable = widget.Respond.Subscribe(handler)
        registerListener widget "Respond" disposable
    | InfoBarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | InfoBarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | InfoBarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | InfoBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | InfoBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | InfoBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | InfoBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | InfoBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | InfoBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | InfoBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | InfoBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | InfoBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | InfoBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | InfoBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | InfoBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | InfoBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | InfoBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | InfoBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | InfoBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | InfoBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | InfoBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | InfoBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | InfoBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | InfoBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | InfoBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | InfoBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | InfoBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | InfoBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | InfoBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | InfoBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | InfoBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | InfoBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | InfoBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | InfoBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | InfoBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | InfoBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | InfoBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | InfoBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | InfoBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | InfoBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | InfoBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | InfoBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | InfoBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | InfoBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | InfoBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | InfoBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | InfoBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | InfoBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | InfoBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | InfoBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | InfoBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | InfoBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | InfoBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | InfoBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | InfoBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | InfoBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | InfoBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | InfoBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | InfoBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | InfoBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type InfoBarPropertyBuilder() =
    inherit BasePropertyBuilder<InfoBarProperty>()
    [<CustomOperation("messageType")>]
    member this.MessageType(it: InfoBarProperty seq, value: Gtk.MessageType) =
        seq { yield! it; yield InfoBarProperty.MessageType value } 
    [<CustomOperation("showCloseButton")>]
    member this.ShowCloseButton(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.ShowCloseButton value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: InfoBarProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield InfoBarProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: InfoBarProperty seq, value: System.UInt32) =
        seq { yield! it; yield InfoBarProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: InfoBarProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield InfoBarProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: InfoBarProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield InfoBarProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: InfoBarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield InfoBarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: InfoBarProperty seq, value: System.UInt32) =
        seq { yield! it; yield InfoBarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: InfoBarProperty seq, value: System.String) =
        seq { yield! it; yield InfoBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: InfoBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield InfoBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: InfoBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield InfoBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: InfoBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield InfoBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: InfoBarProperty seq, value: System.String) =
        seq { yield! it; yield InfoBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: InfoBarProperty seq, value: System.String) =
        seq { yield! it; yield InfoBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: InfoBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield InfoBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: InfoBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield InfoBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: InfoBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield InfoBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: InfoBarProperty seq, value: System.Int32) =
        seq { yield! it; yield InfoBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: InfoBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield InfoBarProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: InfoBarProperty seq, value: System.Double) =
        seq { yield! it; yield InfoBarProperty.Opacity value } 
    [<CustomOperation("onRespond")>]
    member this.OnRespond(it: InfoBarProperty seq, value: Gtk.RespondArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnRespond value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: InfoBarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: InfoBarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: InfoBarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: InfoBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: InfoBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: InfoBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: InfoBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: InfoBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: InfoBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: InfoBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: InfoBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: InfoBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: InfoBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: InfoBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: InfoBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: InfoBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: InfoBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: InfoBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: InfoBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: InfoBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: InfoBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: InfoBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: InfoBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: InfoBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: InfoBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: InfoBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: InfoBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: InfoBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: InfoBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: InfoBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: InfoBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: InfoBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: InfoBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: InfoBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: InfoBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: InfoBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: InfoBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: InfoBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: InfoBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: InfoBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: InfoBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: InfoBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: InfoBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: InfoBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: InfoBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: InfoBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: InfoBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: InfoBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: InfoBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: InfoBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: InfoBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: InfoBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: InfoBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: InfoBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: InfoBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: InfoBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: InfoBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: InfoBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: InfoBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: InfoBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield InfoBarProperty.OnFocused value } 

let prop = InfoBarPropertyBuilder()

type InfoBarDescriptor(props) =
    inherit BaseWidgetDescriptor<InfoBar, InfoBarProperty>(props, bindProperty)
    override this.CreateTyped() = new InfoBar()

let infoBar props = InfoBarDescriptor(props)

