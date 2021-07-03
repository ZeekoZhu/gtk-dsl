module Gtk.DSL.Binding.ShortcutLabel
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ShortcutLabelProperty =
    | Accelerator of System.String
    | DisabledText of System.String
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

let bindProperty (widget: ShortcutLabel) (prop: ShortcutLabelProperty) =
    match prop with
    | ShortcutLabelProperty.Accelerator value -> widget.Accelerator <- value
    | ShortcutLabelProperty.DisabledText value -> widget.DisabledText <- value
    | ShortcutLabelProperty.Spacing value -> widget.Spacing <- value
    | ShortcutLabelProperty.Homogeneous value -> widget.Homogeneous <- value
    | ShortcutLabelProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ShortcutLabelProperty.Expand value -> widget.Expand <- value
    | ShortcutLabelProperty.Fill value -> widget.Fill <- value
    | ShortcutLabelProperty.Padding value -> widget.Padding <- value
    | ShortcutLabelProperty.PackType value -> widget.PackType <- value
    | ShortcutLabelProperty.Position value -> widget.Position <- value
    | ShortcutLabelProperty.Orientation value -> widget.Orientation <- value
    | ShortcutLabelProperty.ResizeMode value -> widget.ResizeMode <- value
    | ShortcutLabelProperty.BorderWidth value -> widget.BorderWidth <- value
    | ShortcutLabelProperty.Name value -> widget.Name <- value
    | ShortcutLabelProperty.Parent value -> widget.Parent <- value
    | ShortcutLabelProperty.WidthRequest value -> widget.WidthRequest <- value
    | ShortcutLabelProperty.HeightRequest value -> widget.HeightRequest <- value
    | ShortcutLabelProperty.Visible value -> widget.Visible <- value
    | ShortcutLabelProperty.Sensitive value -> widget.Sensitive <- value
    | ShortcutLabelProperty.AppPaintable value -> widget.AppPaintable <- value
    | ShortcutLabelProperty.CanFocus value -> widget.CanFocus <- value
    | ShortcutLabelProperty.HasFocus value -> widget.HasFocus <- value
    | ShortcutLabelProperty.IsFocus value -> widget.IsFocus <- value
    | ShortcutLabelProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ShortcutLabelProperty.CanDefault value -> widget.CanDefault <- value
    | ShortcutLabelProperty.HasDefault value -> widget.HasDefault <- value
    | ShortcutLabelProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ShortcutLabelProperty.Style value -> widget.Style <- value
    | ShortcutLabelProperty.Events value -> widget.Events <- value
    | ShortcutLabelProperty.NoShowAll value -> widget.NoShowAll <- value
    | ShortcutLabelProperty.HasTooltip value -> widget.HasTooltip <- value
    | ShortcutLabelProperty.TooltipText value -> widget.TooltipText <- value
    | ShortcutLabelProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ShortcutLabelProperty.Window value -> widget.Window <- value
    | ShortcutLabelProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ShortcutLabelProperty.Halign value -> widget.Halign <- value
    | ShortcutLabelProperty.Valign value -> widget.Valign <- value
    | ShortcutLabelProperty.MarginLeft value -> widget.MarginLeft <- value
    | ShortcutLabelProperty.MarginRight value -> widget.MarginRight <- value
    | ShortcutLabelProperty.MarginStart value -> widget.MarginStart <- value
    | ShortcutLabelProperty.MarginEnd value -> widget.MarginEnd <- value
    | ShortcutLabelProperty.MarginTop value -> widget.MarginTop <- value
    | ShortcutLabelProperty.MarginBottom value -> widget.MarginBottom <- value
    | ShortcutLabelProperty.Margin value -> widget.Margin <- value
    | ShortcutLabelProperty.Hexpand value -> widget.Hexpand <- value
    | ShortcutLabelProperty.HexpandSet value -> widget.HexpandSet <- value
    | ShortcutLabelProperty.Vexpand value -> widget.Vexpand <- value
    | ShortcutLabelProperty.VexpandSet value -> widget.VexpandSet <- value
    | ShortcutLabelProperty.Opacity value -> widget.Opacity <- value
    | ShortcutLabelProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ShortcutLabelProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ShortcutLabelProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ShortcutLabelProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ShortcutLabelProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ShortcutLabelProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ShortcutLabelProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ShortcutLabelProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ShortcutLabelProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ShortcutLabelProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ShortcutLabelProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ShortcutLabelProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ShortcutLabelProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ShortcutLabelProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ShortcutLabelProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ShortcutLabelProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ShortcutLabelProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ShortcutLabelProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ShortcutLabelProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ShortcutLabelProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ShortcutLabelProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ShortcutLabelProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ShortcutLabelProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ShortcutLabelProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ShortcutLabelProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ShortcutLabelProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ShortcutLabelProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ShortcutLabelProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ShortcutLabelProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ShortcutLabelProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ShortcutLabelProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ShortcutLabelProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ShortcutLabelProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ShortcutLabelProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ShortcutLabelProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ShortcutLabelProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ShortcutLabelProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ShortcutLabelProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ShortcutLabelProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ShortcutLabelProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ShortcutLabelProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ShortcutLabelProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ShortcutLabelProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ShortcutLabelProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ShortcutLabelProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ShortcutLabelProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ShortcutLabelProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ShortcutLabelProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ShortcutLabelProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ShortcutLabelProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ShortcutLabelProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ShortcutLabelProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ShortcutLabelProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ShortcutLabelProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ShortcutLabelProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ShortcutLabelProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ShortcutLabelProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ShortcutLabelProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ShortcutLabelProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ShortcutLabelProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ShortcutLabelPropertyBuilder() =
    inherit BasePropertyBuilder<ShortcutLabelProperty>()
    [<CustomOperation("accelerator")>]
    member this.Accelerator(it: ShortcutLabelProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutLabelProperty.Accelerator value } 
    [<CustomOperation("disabledText")>]
    member this.DisabledText(it: ShortcutLabelProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutLabelProperty.DisabledText value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ShortcutLabelProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ShortcutLabelProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ShortcutLabelProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutLabelProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ShortcutLabelProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ShortcutLabelProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ShortcutLabelProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ShortcutLabelProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ShortcutLabelProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ShortcutLabelProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ShortcutLabelProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutLabelProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ShortcutLabelProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutLabelProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ShortcutLabelProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ShortcutLabelProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ShortcutLabelProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ShortcutLabelProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ShortcutLabelProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ShortcutLabelProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ShortcutLabelProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutLabelProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ShortcutLabelProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutLabelProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ShortcutLabelProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ShortcutLabelProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ShortcutLabelProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutLabelProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ShortcutLabelProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutLabelProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ShortcutLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutLabelProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ShortcutLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutLabelProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ShortcutLabelProperty seq, value: System.Double) =
        seq { yield! it; yield ShortcutLabelProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ShortcutLabelProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ShortcutLabelProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ShortcutLabelProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ShortcutLabelProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ShortcutLabelProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ShortcutLabelProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ShortcutLabelProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ShortcutLabelProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ShortcutLabelProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ShortcutLabelProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ShortcutLabelProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ShortcutLabelProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ShortcutLabelProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ShortcutLabelProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ShortcutLabelProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ShortcutLabelProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ShortcutLabelProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ShortcutLabelProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ShortcutLabelProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ShortcutLabelProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ShortcutLabelProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ShortcutLabelProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ShortcutLabelProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ShortcutLabelProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ShortcutLabelProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ShortcutLabelProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ShortcutLabelProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ShortcutLabelProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ShortcutLabelProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ShortcutLabelProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ShortcutLabelProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ShortcutLabelProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ShortcutLabelProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ShortcutLabelProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ShortcutLabelProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ShortcutLabelProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ShortcutLabelProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ShortcutLabelProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ShortcutLabelProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ShortcutLabelProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ShortcutLabelProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ShortcutLabelProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ShortcutLabelProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ShortcutLabelProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ShortcutLabelProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ShortcutLabelProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ShortcutLabelProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ShortcutLabelProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ShortcutLabelProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ShortcutLabelProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ShortcutLabelProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ShortcutLabelProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ShortcutLabelProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ShortcutLabelProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ShortcutLabelProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ShortcutLabelProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ShortcutLabelProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ShortcutLabelProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ShortcutLabelProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ShortcutLabelProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ShortcutLabelProperty.OnFocused value } 

let prop = ShortcutLabelPropertyBuilder()

