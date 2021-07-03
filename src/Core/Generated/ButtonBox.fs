module Gtk.DSL.Binding.ButtonBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ButtonBoxProperty =
    | LayoutStyle of Gtk.ButtonBoxStyle
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

let bindProperty (widget: ButtonBox) (prop: ButtonBoxProperty) =
    match prop with
    | ButtonBoxProperty.LayoutStyle value -> widget.LayoutStyle <- value
    | ButtonBoxProperty.Spacing value -> widget.Spacing <- value
    | ButtonBoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | ButtonBoxProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ButtonBoxProperty.Expand value -> widget.Expand <- value
    | ButtonBoxProperty.Fill value -> widget.Fill <- value
    | ButtonBoxProperty.Padding value -> widget.Padding <- value
    | ButtonBoxProperty.PackType value -> widget.PackType <- value
    | ButtonBoxProperty.Position value -> widget.Position <- value
    | ButtonBoxProperty.Orientation value -> widget.Orientation <- value
    | ButtonBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | ButtonBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | ButtonBoxProperty.Name value -> widget.Name <- value
    | ButtonBoxProperty.Parent value -> widget.Parent <- value
    | ButtonBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | ButtonBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | ButtonBoxProperty.Visible value -> widget.Visible <- value
    | ButtonBoxProperty.Sensitive value -> widget.Sensitive <- value
    | ButtonBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | ButtonBoxProperty.CanFocus value -> widget.CanFocus <- value
    | ButtonBoxProperty.HasFocus value -> widget.HasFocus <- value
    | ButtonBoxProperty.IsFocus value -> widget.IsFocus <- value
    | ButtonBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ButtonBoxProperty.CanDefault value -> widget.CanDefault <- value
    | ButtonBoxProperty.HasDefault value -> widget.HasDefault <- value
    | ButtonBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ButtonBoxProperty.Style value -> widget.Style <- value
    | ButtonBoxProperty.Events value -> widget.Events <- value
    | ButtonBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | ButtonBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | ButtonBoxProperty.TooltipText value -> widget.TooltipText <- value
    | ButtonBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ButtonBoxProperty.Window value -> widget.Window <- value
    | ButtonBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ButtonBoxProperty.Halign value -> widget.Halign <- value
    | ButtonBoxProperty.Valign value -> widget.Valign <- value
    | ButtonBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | ButtonBoxProperty.MarginRight value -> widget.MarginRight <- value
    | ButtonBoxProperty.MarginStart value -> widget.MarginStart <- value
    | ButtonBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | ButtonBoxProperty.MarginTop value -> widget.MarginTop <- value
    | ButtonBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | ButtonBoxProperty.Margin value -> widget.Margin <- value
    | ButtonBoxProperty.Hexpand value -> widget.Hexpand <- value
    | ButtonBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | ButtonBoxProperty.Vexpand value -> widget.Vexpand <- value
    | ButtonBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | ButtonBoxProperty.Opacity value -> widget.Opacity <- value
    | ButtonBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ButtonBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ButtonBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ButtonBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ButtonBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ButtonBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ButtonBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ButtonBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ButtonBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ButtonBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ButtonBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ButtonBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ButtonBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ButtonBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ButtonBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ButtonBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ButtonBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ButtonBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ButtonBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ButtonBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ButtonBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ButtonBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ButtonBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ButtonBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ButtonBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ButtonBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ButtonBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ButtonBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ButtonBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ButtonBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ButtonBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ButtonBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ButtonBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ButtonBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ButtonBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ButtonBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ButtonBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ButtonBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ButtonBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ButtonBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ButtonBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ButtonBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ButtonBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ButtonBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ButtonBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ButtonBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ButtonBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ButtonBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ButtonBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ButtonBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ButtonBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ButtonBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ButtonBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ButtonBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ButtonBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ButtonBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ButtonBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ButtonBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ButtonBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ButtonBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ButtonBoxPropertyBuilder() =
    inherit BasePropertyBuilder<ButtonBoxProperty>()
    [<CustomOperation("layoutStyle")>]
    member this.LayoutStyle(it: ButtonBoxProperty seq, value: Gtk.ButtonBoxStyle) =
        seq { yield! it; yield ButtonBoxProperty.LayoutStyle value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ButtonBoxProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ButtonBoxProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ButtonBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield ButtonBoxProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ButtonBoxProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ButtonBoxProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ButtonBoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ButtonBoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ButtonBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ButtonBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ButtonBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield ButtonBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield ButtonBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ButtonBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ButtonBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ButtonBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ButtonBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ButtonBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ButtonBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield ButtonBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield ButtonBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ButtonBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ButtonBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ButtonBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ButtonBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ButtonBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ButtonBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield ButtonBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield ButtonBoxProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ButtonBoxProperty seq, value: System.Double) =
        seq { yield! it; yield ButtonBoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ButtonBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ButtonBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ButtonBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ButtonBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ButtonBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ButtonBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ButtonBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ButtonBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ButtonBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ButtonBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ButtonBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ButtonBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ButtonBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ButtonBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ButtonBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ButtonBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ButtonBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ButtonBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ButtonBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ButtonBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ButtonBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ButtonBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ButtonBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ButtonBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ButtonBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ButtonBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ButtonBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ButtonBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ButtonBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ButtonBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ButtonBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ButtonBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ButtonBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ButtonBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ButtonBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ButtonBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ButtonBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ButtonBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ButtonBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ButtonBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ButtonBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ButtonBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ButtonBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ButtonBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ButtonBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ButtonBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ButtonBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ButtonBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ButtonBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ButtonBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ButtonBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ButtonBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ButtonBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ButtonBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ButtonBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ButtonBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ButtonBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ButtonBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ButtonBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ButtonBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ButtonBoxProperty.OnFocused value } 

let prop = ButtonBoxPropertyBuilder()

