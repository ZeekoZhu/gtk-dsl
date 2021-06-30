module GtkDsl.Binding.ToolItemGroup
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToolItemGroupProperty =
    | Label of System.String
    | LabelWidget of Gtk.Widget
    | Collapsed of System.Boolean
    | Ellipsize of Pango.EllipsizeMode
    | HeaderRelief of Gtk.ReliefStyle
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

let bindProperty (widget: ToolItemGroup) (prop: ToolItemGroupProperty) =
    match prop with
    | ToolItemGroupProperty.Label value -> widget.Label <- value
    | ToolItemGroupProperty.LabelWidget value -> widget.LabelWidget <- value
    | ToolItemGroupProperty.Collapsed value -> widget.Collapsed <- value
    | ToolItemGroupProperty.Ellipsize value -> widget.Ellipsize <- value
    | ToolItemGroupProperty.HeaderRelief value -> widget.HeaderRelief <- value
    | ToolItemGroupProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToolItemGroupProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToolItemGroupProperty.Name value -> widget.Name <- value
    | ToolItemGroupProperty.Parent value -> widget.Parent <- value
    | ToolItemGroupProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToolItemGroupProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToolItemGroupProperty.Visible value -> widget.Visible <- value
    | ToolItemGroupProperty.Sensitive value -> widget.Sensitive <- value
    | ToolItemGroupProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToolItemGroupProperty.CanFocus value -> widget.CanFocus <- value
    | ToolItemGroupProperty.HasFocus value -> widget.HasFocus <- value
    | ToolItemGroupProperty.IsFocus value -> widget.IsFocus <- value
    | ToolItemGroupProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToolItemGroupProperty.CanDefault value -> widget.CanDefault <- value
    | ToolItemGroupProperty.HasDefault value -> widget.HasDefault <- value
    | ToolItemGroupProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToolItemGroupProperty.Events value -> widget.Events <- value
    | ToolItemGroupProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToolItemGroupProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToolItemGroupProperty.TooltipText value -> widget.TooltipText <- value
    | ToolItemGroupProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToolItemGroupProperty.Window value -> widget.Window <- value
    | ToolItemGroupProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToolItemGroupProperty.Halign value -> widget.Halign <- value
    | ToolItemGroupProperty.Valign value -> widget.Valign <- value
    | ToolItemGroupProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToolItemGroupProperty.MarginRight value -> widget.MarginRight <- value
    | ToolItemGroupProperty.MarginStart value -> widget.MarginStart <- value
    | ToolItemGroupProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToolItemGroupProperty.MarginTop value -> widget.MarginTop <- value
    | ToolItemGroupProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToolItemGroupProperty.Margin value -> widget.Margin <- value
    | ToolItemGroupProperty.Hexpand value -> widget.Hexpand <- value
    | ToolItemGroupProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToolItemGroupProperty.Vexpand value -> widget.Vexpand <- value
    | ToolItemGroupProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToolItemGroupProperty.Expand value -> widget.Expand <- value
    | ToolItemGroupProperty.Opacity value -> widget.Opacity <- value
    | ToolItemGroupProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToolItemGroupProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToolItemGroupProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToolItemGroupProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToolItemGroupProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToolItemGroupProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToolItemGroupProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToolItemGroupProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToolItemGroupProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToolItemGroupProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToolItemGroupProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToolItemGroupProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToolItemGroupProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToolItemGroupProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToolItemGroupProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToolItemGroupProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToolItemGroupProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToolItemGroupProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToolItemGroupProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToolItemGroupProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToolItemGroupProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToolItemGroupProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToolItemGroupProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToolItemGroupProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToolItemGroupProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToolItemGroupProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToolItemGroupProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToolItemGroupProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToolItemGroupProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToolItemGroupProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToolItemGroupProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToolItemGroupProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToolItemGroupProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToolItemGroupProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToolItemGroupProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToolItemGroupProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToolItemGroupProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToolItemGroupProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToolItemGroupProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToolItemGroupProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToolItemGroupProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToolItemGroupProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToolItemGroupProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToolItemGroupProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToolItemGroupProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToolItemGroupProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToolItemGroupProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToolItemGroupProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToolItemGroupProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToolItemGroupProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToolItemGroupProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToolItemGroupProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToolItemGroupProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToolItemGroupProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToolItemGroupProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToolItemGroupProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToolItemGroupProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToolItemGroupProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToolItemGroupProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToolItemGroupProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToolItemGroupPropertyBuilder() =
    inherit BasePropertyBuilder<ToolItemGroupProperty>()
    [<CustomOperation("label")>]
    member this.Label(it: ToolItemGroupProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemGroupProperty.Label value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: ToolItemGroupProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolItemGroupProperty.LabelWidget value } 
    [<CustomOperation("collapsed")>]
    member this.Collapsed(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.Collapsed value } 
    [<CustomOperation("ellipsize")>]
    member this.Ellipsize(it: ToolItemGroupProperty seq, value: Pango.EllipsizeMode) =
        seq { yield! it; yield ToolItemGroupProperty.Ellipsize value } 
    [<CustomOperation("headerRelief")>]
    member this.HeaderRelief(it: ToolItemGroupProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield ToolItemGroupProperty.HeaderRelief value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToolItemGroupProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToolItemGroupProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToolItemGroupProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToolItemGroupProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToolItemGroupProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemGroupProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToolItemGroupProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolItemGroupProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.ReceivesDefault value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToolItemGroupProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToolItemGroupProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToolItemGroupProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemGroupProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToolItemGroupProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemGroupProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToolItemGroupProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToolItemGroupProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToolItemGroupProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolItemGroupProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToolItemGroupProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolItemGroupProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToolItemGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemGroupProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ToolItemGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemGroupProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToolItemGroupProperty seq, value: System.Double) =
        seq { yield! it; yield ToolItemGroupProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToolItemGroupProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToolItemGroupProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToolItemGroupProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToolItemGroupProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToolItemGroupProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToolItemGroupProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToolItemGroupProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToolItemGroupProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToolItemGroupProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToolItemGroupProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToolItemGroupProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToolItemGroupProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToolItemGroupProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToolItemGroupProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToolItemGroupProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToolItemGroupProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToolItemGroupProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToolItemGroupProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToolItemGroupProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToolItemGroupProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToolItemGroupProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToolItemGroupProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToolItemGroupProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToolItemGroupProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToolItemGroupProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToolItemGroupProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToolItemGroupProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToolItemGroupProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToolItemGroupProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToolItemGroupProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToolItemGroupProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToolItemGroupProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToolItemGroupProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToolItemGroupProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToolItemGroupProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToolItemGroupProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToolItemGroupProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToolItemGroupProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToolItemGroupProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToolItemGroupProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToolItemGroupProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToolItemGroupProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToolItemGroupProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToolItemGroupProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToolItemGroupProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToolItemGroupProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToolItemGroupProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToolItemGroupProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToolItemGroupProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToolItemGroupProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToolItemGroupProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToolItemGroupProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToolItemGroupProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToolItemGroupProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToolItemGroupProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToolItemGroupProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToolItemGroupProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToolItemGroupProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToolItemGroupProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToolItemGroupProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToolItemGroupProperty.OnFocused value } 

let prop = ToolItemGroupPropertyBuilder()

