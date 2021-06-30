module GtkDsl.Binding.StackSwitcher
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type StackSwitcherProperty =
    | IconSize of System.Int32
    | Stack of Gtk.Stack
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

let bindProperty (widget: StackSwitcher) (prop: StackSwitcherProperty) =
    match prop with
    | StackSwitcherProperty.IconSize value -> widget.IconSize <- value
    | StackSwitcherProperty.Stack value -> widget.Stack <- value
    | StackSwitcherProperty.Spacing value -> widget.Spacing <- value
    | StackSwitcherProperty.Homogeneous value -> widget.Homogeneous <- value
    | StackSwitcherProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | StackSwitcherProperty.Expand value -> widget.Expand <- value
    | StackSwitcherProperty.Fill value -> widget.Fill <- value
    | StackSwitcherProperty.Padding value -> widget.Padding <- value
    | StackSwitcherProperty.PackType value -> widget.PackType <- value
    | StackSwitcherProperty.Position value -> widget.Position <- value
    | StackSwitcherProperty.Orientation value -> widget.Orientation <- value
    | StackSwitcherProperty.ResizeMode value -> widget.ResizeMode <- value
    | StackSwitcherProperty.BorderWidth value -> widget.BorderWidth <- value
    | StackSwitcherProperty.Name value -> widget.Name <- value
    | StackSwitcherProperty.Parent value -> widget.Parent <- value
    | StackSwitcherProperty.WidthRequest value -> widget.WidthRequest <- value
    | StackSwitcherProperty.HeightRequest value -> widget.HeightRequest <- value
    | StackSwitcherProperty.Visible value -> widget.Visible <- value
    | StackSwitcherProperty.Sensitive value -> widget.Sensitive <- value
    | StackSwitcherProperty.AppPaintable value -> widget.AppPaintable <- value
    | StackSwitcherProperty.CanFocus value -> widget.CanFocus <- value
    | StackSwitcherProperty.HasFocus value -> widget.HasFocus <- value
    | StackSwitcherProperty.IsFocus value -> widget.IsFocus <- value
    | StackSwitcherProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | StackSwitcherProperty.CanDefault value -> widget.CanDefault <- value
    | StackSwitcherProperty.HasDefault value -> widget.HasDefault <- value
    | StackSwitcherProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | StackSwitcherProperty.Style value -> widget.Style <- value
    | StackSwitcherProperty.Events value -> widget.Events <- value
    | StackSwitcherProperty.NoShowAll value -> widget.NoShowAll <- value
    | StackSwitcherProperty.HasTooltip value -> widget.HasTooltip <- value
    | StackSwitcherProperty.TooltipText value -> widget.TooltipText <- value
    | StackSwitcherProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | StackSwitcherProperty.Window value -> widget.Window <- value
    | StackSwitcherProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | StackSwitcherProperty.Halign value -> widget.Halign <- value
    | StackSwitcherProperty.Valign value -> widget.Valign <- value
    | StackSwitcherProperty.MarginLeft value -> widget.MarginLeft <- value
    | StackSwitcherProperty.MarginRight value -> widget.MarginRight <- value
    | StackSwitcherProperty.MarginStart value -> widget.MarginStart <- value
    | StackSwitcherProperty.MarginEnd value -> widget.MarginEnd <- value
    | StackSwitcherProperty.MarginTop value -> widget.MarginTop <- value
    | StackSwitcherProperty.MarginBottom value -> widget.MarginBottom <- value
    | StackSwitcherProperty.Margin value -> widget.Margin <- value
    | StackSwitcherProperty.Hexpand value -> widget.Hexpand <- value
    | StackSwitcherProperty.HexpandSet value -> widget.HexpandSet <- value
    | StackSwitcherProperty.Vexpand value -> widget.Vexpand <- value
    | StackSwitcherProperty.VexpandSet value -> widget.VexpandSet <- value
    | StackSwitcherProperty.Opacity value -> widget.Opacity <- value
    | StackSwitcherProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | StackSwitcherProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | StackSwitcherProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | StackSwitcherProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | StackSwitcherProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | StackSwitcherProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | StackSwitcherProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | StackSwitcherProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | StackSwitcherProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | StackSwitcherProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | StackSwitcherProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | StackSwitcherProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | StackSwitcherProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | StackSwitcherProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | StackSwitcherProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | StackSwitcherProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | StackSwitcherProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | StackSwitcherProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | StackSwitcherProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | StackSwitcherProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | StackSwitcherProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | StackSwitcherProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | StackSwitcherProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | StackSwitcherProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | StackSwitcherProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | StackSwitcherProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | StackSwitcherProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | StackSwitcherProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | StackSwitcherProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | StackSwitcherProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | StackSwitcherProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | StackSwitcherProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | StackSwitcherProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | StackSwitcherProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | StackSwitcherProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | StackSwitcherProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | StackSwitcherProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | StackSwitcherProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | StackSwitcherProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | StackSwitcherProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | StackSwitcherProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | StackSwitcherProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | StackSwitcherProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | StackSwitcherProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | StackSwitcherProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | StackSwitcherProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | StackSwitcherProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | StackSwitcherProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | StackSwitcherProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | StackSwitcherProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | StackSwitcherProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | StackSwitcherProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | StackSwitcherProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | StackSwitcherProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | StackSwitcherProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | StackSwitcherProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | StackSwitcherProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | StackSwitcherProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | StackSwitcherProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | StackSwitcherProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type StackSwitcherPropertyBuilder() =
    inherit BasePropertyBuilder<StackSwitcherProperty>()
    [<CustomOperation("iconSize")>]
    member this.IconSize(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.IconSize value } 
    [<CustomOperation("stack")>]
    member this.Stack(it: StackSwitcherProperty seq, value: Gtk.Stack) =
        seq { yield! it; yield StackSwitcherProperty.Stack value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: StackSwitcherProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield StackSwitcherProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: StackSwitcherProperty seq, value: System.UInt32) =
        seq { yield! it; yield StackSwitcherProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: StackSwitcherProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield StackSwitcherProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: StackSwitcherProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield StackSwitcherProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: StackSwitcherProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield StackSwitcherProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: StackSwitcherProperty seq, value: System.UInt32) =
        seq { yield! it; yield StackSwitcherProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: StackSwitcherProperty seq, value: System.String) =
        seq { yield! it; yield StackSwitcherProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: StackSwitcherProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield StackSwitcherProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: StackSwitcherProperty seq, value: Gtk.Style) =
        seq { yield! it; yield StackSwitcherProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: StackSwitcherProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield StackSwitcherProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: StackSwitcherProperty seq, value: System.String) =
        seq { yield! it; yield StackSwitcherProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: StackSwitcherProperty seq, value: System.String) =
        seq { yield! it; yield StackSwitcherProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: StackSwitcherProperty seq, value: Gdk.Window) =
        seq { yield! it; yield StackSwitcherProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: StackSwitcherProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StackSwitcherProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: StackSwitcherProperty seq, value: Gtk.Align) =
        seq { yield! it; yield StackSwitcherProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: StackSwitcherProperty seq, value: System.Int32) =
        seq { yield! it; yield StackSwitcherProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: StackSwitcherProperty seq, value: System.Boolean) =
        seq { yield! it; yield StackSwitcherProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: StackSwitcherProperty seq, value: System.Double) =
        seq { yield! it; yield StackSwitcherProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: StackSwitcherProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: StackSwitcherProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: StackSwitcherProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: StackSwitcherProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: StackSwitcherProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: StackSwitcherProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: StackSwitcherProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: StackSwitcherProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: StackSwitcherProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: StackSwitcherProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: StackSwitcherProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: StackSwitcherProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: StackSwitcherProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: StackSwitcherProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: StackSwitcherProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: StackSwitcherProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: StackSwitcherProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: StackSwitcherProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: StackSwitcherProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: StackSwitcherProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: StackSwitcherProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: StackSwitcherProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: StackSwitcherProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: StackSwitcherProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: StackSwitcherProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: StackSwitcherProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: StackSwitcherProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: StackSwitcherProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: StackSwitcherProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: StackSwitcherProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: StackSwitcherProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: StackSwitcherProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: StackSwitcherProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: StackSwitcherProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: StackSwitcherProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: StackSwitcherProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: StackSwitcherProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: StackSwitcherProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: StackSwitcherProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: StackSwitcherProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: StackSwitcherProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: StackSwitcherProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: StackSwitcherProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: StackSwitcherProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: StackSwitcherProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: StackSwitcherProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: StackSwitcherProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: StackSwitcherProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: StackSwitcherProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: StackSwitcherProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: StackSwitcherProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: StackSwitcherProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: StackSwitcherProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: StackSwitcherProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: StackSwitcherProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: StackSwitcherProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: StackSwitcherProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: StackSwitcherProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: StackSwitcherProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: StackSwitcherProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield StackSwitcherProperty.OnFocused value } 

let prop = StackSwitcherPropertyBuilder()

type StackSwitcherDescriptor(props) =
    inherit BaseWidgetDescriptor<StackSwitcher, StackSwitcherProperty>(props, bindProperty)
    override this.CreateTyped() = new StackSwitcher()

let stackSwitcher props = StackSwitcherDescriptor(props)

