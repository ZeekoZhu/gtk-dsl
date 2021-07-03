module Gtk.DSL.Binding.RecentChooserWidget
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RecentChooserWidgetProperty =
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

let bindProperty (widget: RecentChooserWidget) (prop: RecentChooserWidgetProperty) =
    match prop with
    | RecentChooserWidgetProperty.Spacing value -> widget.Spacing <- value
    | RecentChooserWidgetProperty.Homogeneous value -> widget.Homogeneous <- value
    | RecentChooserWidgetProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | RecentChooserWidgetProperty.Expand value -> widget.Expand <- value
    | RecentChooserWidgetProperty.Fill value -> widget.Fill <- value
    | RecentChooserWidgetProperty.Padding value -> widget.Padding <- value
    | RecentChooserWidgetProperty.PackType value -> widget.PackType <- value
    | RecentChooserWidgetProperty.Position value -> widget.Position <- value
    | RecentChooserWidgetProperty.Orientation value -> widget.Orientation <- value
    | RecentChooserWidgetProperty.ResizeMode value -> widget.ResizeMode <- value
    | RecentChooserWidgetProperty.BorderWidth value -> widget.BorderWidth <- value
    | RecentChooserWidgetProperty.Name value -> widget.Name <- value
    | RecentChooserWidgetProperty.Parent value -> widget.Parent <- value
    | RecentChooserWidgetProperty.WidthRequest value -> widget.WidthRequest <- value
    | RecentChooserWidgetProperty.HeightRequest value -> widget.HeightRequest <- value
    | RecentChooserWidgetProperty.Visible value -> widget.Visible <- value
    | RecentChooserWidgetProperty.Sensitive value -> widget.Sensitive <- value
    | RecentChooserWidgetProperty.AppPaintable value -> widget.AppPaintable <- value
    | RecentChooserWidgetProperty.CanFocus value -> widget.CanFocus <- value
    | RecentChooserWidgetProperty.HasFocus value -> widget.HasFocus <- value
    | RecentChooserWidgetProperty.IsFocus value -> widget.IsFocus <- value
    | RecentChooserWidgetProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RecentChooserWidgetProperty.CanDefault value -> widget.CanDefault <- value
    | RecentChooserWidgetProperty.HasDefault value -> widget.HasDefault <- value
    | RecentChooserWidgetProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RecentChooserWidgetProperty.Style value -> widget.Style <- value
    | RecentChooserWidgetProperty.Events value -> widget.Events <- value
    | RecentChooserWidgetProperty.NoShowAll value -> widget.NoShowAll <- value
    | RecentChooserWidgetProperty.HasTooltip value -> widget.HasTooltip <- value
    | RecentChooserWidgetProperty.TooltipText value -> widget.TooltipText <- value
    | RecentChooserWidgetProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RecentChooserWidgetProperty.Window value -> widget.Window <- value
    | RecentChooserWidgetProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RecentChooserWidgetProperty.Halign value -> widget.Halign <- value
    | RecentChooserWidgetProperty.Valign value -> widget.Valign <- value
    | RecentChooserWidgetProperty.MarginLeft value -> widget.MarginLeft <- value
    | RecentChooserWidgetProperty.MarginRight value -> widget.MarginRight <- value
    | RecentChooserWidgetProperty.MarginStart value -> widget.MarginStart <- value
    | RecentChooserWidgetProperty.MarginEnd value -> widget.MarginEnd <- value
    | RecentChooserWidgetProperty.MarginTop value -> widget.MarginTop <- value
    | RecentChooserWidgetProperty.MarginBottom value -> widget.MarginBottom <- value
    | RecentChooserWidgetProperty.Margin value -> widget.Margin <- value
    | RecentChooserWidgetProperty.Hexpand value -> widget.Hexpand <- value
    | RecentChooserWidgetProperty.HexpandSet value -> widget.HexpandSet <- value
    | RecentChooserWidgetProperty.Vexpand value -> widget.Vexpand <- value
    | RecentChooserWidgetProperty.VexpandSet value -> widget.VexpandSet <- value
    | RecentChooserWidgetProperty.Opacity value -> widget.Opacity <- value
    | RecentChooserWidgetProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RecentChooserWidgetProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RecentChooserWidgetProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RecentChooserWidgetProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RecentChooserWidgetProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RecentChooserWidgetProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RecentChooserWidgetProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RecentChooserWidgetProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RecentChooserWidgetProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RecentChooserWidgetProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RecentChooserWidgetProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RecentChooserWidgetProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RecentChooserWidgetProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RecentChooserWidgetProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RecentChooserWidgetProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RecentChooserWidgetProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RecentChooserWidgetProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RecentChooserWidgetProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RecentChooserWidgetProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RecentChooserWidgetProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RecentChooserWidgetProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RecentChooserWidgetProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RecentChooserWidgetProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RecentChooserWidgetProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RecentChooserWidgetProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RecentChooserWidgetProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RecentChooserWidgetProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RecentChooserWidgetProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RecentChooserWidgetProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RecentChooserWidgetProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RecentChooserWidgetProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RecentChooserWidgetProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RecentChooserWidgetProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RecentChooserWidgetProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RecentChooserWidgetProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RecentChooserWidgetProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RecentChooserWidgetProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RecentChooserWidgetProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RecentChooserWidgetProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RecentChooserWidgetProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RecentChooserWidgetProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RecentChooserWidgetProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RecentChooserWidgetProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RecentChooserWidgetProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RecentChooserWidgetProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RecentChooserWidgetProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RecentChooserWidgetProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RecentChooserWidgetProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RecentChooserWidgetProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RecentChooserWidgetProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RecentChooserWidgetProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RecentChooserWidgetProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RecentChooserWidgetProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RecentChooserWidgetProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RecentChooserWidgetProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RecentChooserWidgetProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RecentChooserWidgetProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RecentChooserWidgetProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RecentChooserWidgetProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RecentChooserWidgetProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RecentChooserWidgetPropertyBuilder() =
    inherit BasePropertyBuilder<RecentChooserWidgetProperty>()
    [<CustomOperation("spacing")>]
    member this.Spacing(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: RecentChooserWidgetProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield RecentChooserWidgetProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: RecentChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield RecentChooserWidgetProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: RecentChooserWidgetProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield RecentChooserWidgetProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: RecentChooserWidgetProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield RecentChooserWidgetProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RecentChooserWidgetProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RecentChooserWidgetProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RecentChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield RecentChooserWidgetProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RecentChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserWidgetProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RecentChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserWidgetProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RecentChooserWidgetProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RecentChooserWidgetProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RecentChooserWidgetProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RecentChooserWidgetProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RecentChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserWidgetProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RecentChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserWidgetProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RecentChooserWidgetProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RecentChooserWidgetProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RecentChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserWidgetProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RecentChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserWidgetProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RecentChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserWidgetProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RecentChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserWidgetProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RecentChooserWidgetProperty seq, value: System.Double) =
        seq { yield! it; yield RecentChooserWidgetProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RecentChooserWidgetProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RecentChooserWidgetProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RecentChooserWidgetProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RecentChooserWidgetProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RecentChooserWidgetProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RecentChooserWidgetProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RecentChooserWidgetProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RecentChooserWidgetProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RecentChooserWidgetProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RecentChooserWidgetProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RecentChooserWidgetProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RecentChooserWidgetProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RecentChooserWidgetProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RecentChooserWidgetProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RecentChooserWidgetProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RecentChooserWidgetProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RecentChooserWidgetProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RecentChooserWidgetProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RecentChooserWidgetProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RecentChooserWidgetProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RecentChooserWidgetProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RecentChooserWidgetProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RecentChooserWidgetProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RecentChooserWidgetProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RecentChooserWidgetProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RecentChooserWidgetProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RecentChooserWidgetProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RecentChooserWidgetProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RecentChooserWidgetProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RecentChooserWidgetProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RecentChooserWidgetProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RecentChooserWidgetProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RecentChooserWidgetProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RecentChooserWidgetProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RecentChooserWidgetProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RecentChooserWidgetProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RecentChooserWidgetProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RecentChooserWidgetProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RecentChooserWidgetProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RecentChooserWidgetProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RecentChooserWidgetProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RecentChooserWidgetProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RecentChooserWidgetProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RecentChooserWidgetProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RecentChooserWidgetProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RecentChooserWidgetProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RecentChooserWidgetProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RecentChooserWidgetProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RecentChooserWidgetProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RecentChooserWidgetProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RecentChooserWidgetProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RecentChooserWidgetProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RecentChooserWidgetProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RecentChooserWidgetProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RecentChooserWidgetProperty.OnFocused value } 

let prop = RecentChooserWidgetPropertyBuilder()

type RecentChooserWidgetDescriptor(props) =
    inherit BaseWidgetDescriptor<RecentChooserWidget, RecentChooserWidgetProperty>(props, bindProperty)
    override this.CreateTyped() = new RecentChooserWidget()

let recentChooserWidget props = RecentChooserWidgetDescriptor(props)

