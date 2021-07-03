module Gtk.DSL.Binding.VBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VBoxProperty =
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

let bindProperty (widget: VBox) (prop: VBoxProperty) =
    match prop with
    | VBoxProperty.Spacing value -> widget.Spacing <- value
    | VBoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | VBoxProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | VBoxProperty.Expand value -> widget.Expand <- value
    | VBoxProperty.Fill value -> widget.Fill <- value
    | VBoxProperty.Padding value -> widget.Padding <- value
    | VBoxProperty.PackType value -> widget.PackType <- value
    | VBoxProperty.Position value -> widget.Position <- value
    | VBoxProperty.Orientation value -> widget.Orientation <- value
    | VBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | VBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | VBoxProperty.Name value -> widget.Name <- value
    | VBoxProperty.Parent value -> widget.Parent <- value
    | VBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | VBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | VBoxProperty.Visible value -> widget.Visible <- value
    | VBoxProperty.Sensitive value -> widget.Sensitive <- value
    | VBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | VBoxProperty.CanFocus value -> widget.CanFocus <- value
    | VBoxProperty.HasFocus value -> widget.HasFocus <- value
    | VBoxProperty.IsFocus value -> widget.IsFocus <- value
    | VBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VBoxProperty.CanDefault value -> widget.CanDefault <- value
    | VBoxProperty.HasDefault value -> widget.HasDefault <- value
    | VBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VBoxProperty.Style value -> widget.Style <- value
    | VBoxProperty.Events value -> widget.Events <- value
    | VBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | VBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | VBoxProperty.TooltipText value -> widget.TooltipText <- value
    | VBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VBoxProperty.Window value -> widget.Window <- value
    | VBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VBoxProperty.Halign value -> widget.Halign <- value
    | VBoxProperty.Valign value -> widget.Valign <- value
    | VBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | VBoxProperty.MarginRight value -> widget.MarginRight <- value
    | VBoxProperty.MarginStart value -> widget.MarginStart <- value
    | VBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | VBoxProperty.MarginTop value -> widget.MarginTop <- value
    | VBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | VBoxProperty.Margin value -> widget.Margin <- value
    | VBoxProperty.Hexpand value -> widget.Hexpand <- value
    | VBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | VBoxProperty.Vexpand value -> widget.Vexpand <- value
    | VBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | VBoxProperty.Opacity value -> widget.Opacity <- value
    | VBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | VBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | VBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | VBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VBoxPropertyBuilder() =
    inherit BasePropertyBuilder<VBoxProperty>()
    [<CustomOperation("spacing")>]
    member this.Spacing(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: VBoxProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield VBoxProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: VBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield VBoxProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: VBoxProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield VBoxProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: VBoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield VBoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: VBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield VBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: VBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield VBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: VBoxProperty seq, value: System.String) =
        seq { yield! it; yield VBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VBoxProperty seq, value: System.String) =
        seq { yield! it; yield VBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VBoxProperty seq, value: System.String) =
        seq { yield! it; yield VBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VBoxProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VBoxProperty seq, value: System.Double) =
        seq { yield! it; yield VBoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: VBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: VBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: VBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VBoxProperty.OnFocused value } 

let prop = VBoxPropertyBuilder()

type VBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<VBox, VBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new VBox()

let vBox props = VBoxDescriptor(props)

