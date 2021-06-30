module GtkDsl.Binding.Box
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type BoxProperty =
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

let bindProperty (widget: Box) (prop: BoxProperty) =
    match prop with
    | BoxProperty.Spacing value -> widget.Spacing <- value
    | BoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | BoxProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | BoxProperty.Expand value -> widget.Expand <- value
    | BoxProperty.Fill value -> widget.Fill <- value
    | BoxProperty.Padding value -> widget.Padding <- value
    | BoxProperty.PackType value -> widget.PackType <- value
    | BoxProperty.Position value -> widget.Position <- value
    | BoxProperty.Orientation value -> widget.Orientation <- value
    | BoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | BoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | BoxProperty.Name value -> widget.Name <- value
    | BoxProperty.Parent value -> widget.Parent <- value
    | BoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | BoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | BoxProperty.Visible value -> widget.Visible <- value
    | BoxProperty.Sensitive value -> widget.Sensitive <- value
    | BoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | BoxProperty.CanFocus value -> widget.CanFocus <- value
    | BoxProperty.HasFocus value -> widget.HasFocus <- value
    | BoxProperty.IsFocus value -> widget.IsFocus <- value
    | BoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | BoxProperty.CanDefault value -> widget.CanDefault <- value
    | BoxProperty.HasDefault value -> widget.HasDefault <- value
    | BoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | BoxProperty.Style value -> widget.Style <- value
    | BoxProperty.Events value -> widget.Events <- value
    | BoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | BoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | BoxProperty.TooltipText value -> widget.TooltipText <- value
    | BoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | BoxProperty.Window value -> widget.Window <- value
    | BoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | BoxProperty.Halign value -> widget.Halign <- value
    | BoxProperty.Valign value -> widget.Valign <- value
    | BoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | BoxProperty.MarginRight value -> widget.MarginRight <- value
    | BoxProperty.MarginStart value -> widget.MarginStart <- value
    | BoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | BoxProperty.MarginTop value -> widget.MarginTop <- value
    | BoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | BoxProperty.Margin value -> widget.Margin <- value
    | BoxProperty.Hexpand value -> widget.Hexpand <- value
    | BoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | BoxProperty.Vexpand value -> widget.Vexpand <- value
    | BoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | BoxProperty.Opacity value -> widget.Opacity <- value
    | BoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | BoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | BoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | BoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | BoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | BoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | BoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | BoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | BoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | BoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | BoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | BoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | BoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | BoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | BoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | BoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | BoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | BoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | BoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | BoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | BoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | BoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | BoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | BoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | BoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | BoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | BoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | BoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | BoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | BoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | BoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | BoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | BoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | BoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | BoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | BoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | BoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | BoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | BoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | BoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | BoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | BoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | BoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | BoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | BoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | BoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | BoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | BoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | BoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | BoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | BoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | BoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | BoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | BoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | BoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | BoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | BoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | BoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | BoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | BoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type BoxPropertyBuilder() =
    inherit BasePropertyBuilder<BoxProperty>()
    [<CustomOperation("spacing")>]
    member this.Spacing(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: BoxProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield BoxProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: BoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield BoxProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: BoxProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield BoxProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: BoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield BoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: BoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield BoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: BoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield BoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: BoxProperty seq, value: System.String) =
        seq { yield! it; yield BoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: BoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield BoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: BoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield BoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: BoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield BoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: BoxProperty seq, value: System.String) =
        seq { yield! it; yield BoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: BoxProperty seq, value: System.String) =
        seq { yield! it; yield BoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: BoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield BoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: BoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield BoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: BoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield BoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: BoxProperty seq, value: System.Int32) =
        seq { yield! it; yield BoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: BoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield BoxProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: BoxProperty seq, value: System.Double) =
        seq { yield! it; yield BoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: BoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: BoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: BoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: BoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: BoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: BoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: BoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: BoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: BoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: BoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: BoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: BoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: BoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: BoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: BoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: BoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: BoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: BoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: BoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: BoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: BoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: BoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: BoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: BoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: BoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: BoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: BoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: BoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: BoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: BoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: BoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: BoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: BoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: BoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: BoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: BoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: BoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: BoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: BoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: BoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: BoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: BoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: BoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: BoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: BoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: BoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: BoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: BoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: BoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: BoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: BoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: BoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: BoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: BoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: BoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: BoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: BoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: BoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: BoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: BoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield BoxProperty.OnFocused value } 

let prop = BoxPropertyBuilder()

