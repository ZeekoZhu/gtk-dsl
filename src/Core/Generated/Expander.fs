module Gtk.DSL.Binding.Expander
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ExpanderProperty =
    | Expanded of System.Boolean
    | Label of System.String
    | UseUnderline of System.Boolean
    | UseMarkup of System.Boolean
    | Spacing of System.Int32
    | LabelWidget of Gtk.Widget
    | LabelFill of System.Boolean
    | ResizeToplevel of System.Boolean
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

let bindProperty (widget: Expander) (prop: ExpanderProperty) =
    match prop with
    | ExpanderProperty.Expanded value -> widget.Expanded <- value
    | ExpanderProperty.Label value -> widget.Label <- value
    | ExpanderProperty.UseUnderline value -> widget.UseUnderline <- value
    | ExpanderProperty.UseMarkup value -> widget.UseMarkup <- value
    | ExpanderProperty.Spacing value -> widget.Spacing <- value
    | ExpanderProperty.LabelWidget value -> widget.LabelWidget <- value
    | ExpanderProperty.LabelFill value -> widget.LabelFill <- value
    | ExpanderProperty.ResizeToplevel value -> widget.ResizeToplevel <- value
    | ExpanderProperty.ResizeMode value -> widget.ResizeMode <- value
    | ExpanderProperty.BorderWidth value -> widget.BorderWidth <- value
    | ExpanderProperty.Name value -> widget.Name <- value
    | ExpanderProperty.Parent value -> widget.Parent <- value
    | ExpanderProperty.WidthRequest value -> widget.WidthRequest <- value
    | ExpanderProperty.HeightRequest value -> widget.HeightRequest <- value
    | ExpanderProperty.Visible value -> widget.Visible <- value
    | ExpanderProperty.Sensitive value -> widget.Sensitive <- value
    | ExpanderProperty.AppPaintable value -> widget.AppPaintable <- value
    | ExpanderProperty.CanFocus value -> widget.CanFocus <- value
    | ExpanderProperty.HasFocus value -> widget.HasFocus <- value
    | ExpanderProperty.IsFocus value -> widget.IsFocus <- value
    | ExpanderProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ExpanderProperty.CanDefault value -> widget.CanDefault <- value
    | ExpanderProperty.HasDefault value -> widget.HasDefault <- value
    | ExpanderProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ExpanderProperty.Style value -> widget.Style <- value
    | ExpanderProperty.Events value -> widget.Events <- value
    | ExpanderProperty.NoShowAll value -> widget.NoShowAll <- value
    | ExpanderProperty.HasTooltip value -> widget.HasTooltip <- value
    | ExpanderProperty.TooltipText value -> widget.TooltipText <- value
    | ExpanderProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ExpanderProperty.Window value -> widget.Window <- value
    | ExpanderProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ExpanderProperty.Halign value -> widget.Halign <- value
    | ExpanderProperty.Valign value -> widget.Valign <- value
    | ExpanderProperty.MarginLeft value -> widget.MarginLeft <- value
    | ExpanderProperty.MarginRight value -> widget.MarginRight <- value
    | ExpanderProperty.MarginStart value -> widget.MarginStart <- value
    | ExpanderProperty.MarginEnd value -> widget.MarginEnd <- value
    | ExpanderProperty.MarginTop value -> widget.MarginTop <- value
    | ExpanderProperty.MarginBottom value -> widget.MarginBottom <- value
    | ExpanderProperty.Margin value -> widget.Margin <- value
    | ExpanderProperty.Hexpand value -> widget.Hexpand <- value
    | ExpanderProperty.HexpandSet value -> widget.HexpandSet <- value
    | ExpanderProperty.Vexpand value -> widget.Vexpand <- value
    | ExpanderProperty.VexpandSet value -> widget.VexpandSet <- value
    | ExpanderProperty.Expand value -> widget.Expand <- value
    | ExpanderProperty.Opacity value -> widget.Opacity <- value
    | ExpanderProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ExpanderProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ExpanderProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ExpanderProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ExpanderProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ExpanderProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ExpanderProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ExpanderProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ExpanderProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ExpanderProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ExpanderProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ExpanderProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ExpanderProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ExpanderProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ExpanderProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ExpanderProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ExpanderProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ExpanderProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ExpanderProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ExpanderProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ExpanderProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ExpanderProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ExpanderProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ExpanderProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ExpanderProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ExpanderProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ExpanderProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ExpanderProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ExpanderProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ExpanderProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ExpanderProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ExpanderProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ExpanderProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ExpanderProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ExpanderProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ExpanderProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ExpanderProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ExpanderProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ExpanderProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ExpanderProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ExpanderProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ExpanderProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ExpanderProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ExpanderProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ExpanderProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ExpanderProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ExpanderProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ExpanderProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ExpanderProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ExpanderProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ExpanderProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ExpanderProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ExpanderProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ExpanderProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ExpanderProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ExpanderProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ExpanderProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ExpanderProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ExpanderProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ExpanderProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ExpanderPropertyBuilder() =
    inherit BasePropertyBuilder<ExpanderProperty>()
    [<CustomOperation("expanded")>]
    member this.Expanded(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.Expanded value } 
    [<CustomOperation("label")>]
    member this.Label(it: ExpanderProperty seq, value: System.String) =
        seq { yield! it; yield ExpanderProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.UseUnderline value } 
    [<CustomOperation("useMarkup")>]
    member this.UseMarkup(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.UseMarkup value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.Spacing value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: ExpanderProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ExpanderProperty.LabelWidget value } 
    [<CustomOperation("labelFill")>]
    member this.LabelFill(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.LabelFill value } 
    [<CustomOperation("resizeToplevel")>]
    member this.ResizeToplevel(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.ResizeToplevel value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ExpanderProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ExpanderProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ExpanderProperty seq, value: System.UInt32) =
        seq { yield! it; yield ExpanderProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ExpanderProperty seq, value: System.String) =
        seq { yield! it; yield ExpanderProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ExpanderProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ExpanderProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ExpanderProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ExpanderProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ExpanderProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ExpanderProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ExpanderProperty seq, value: System.String) =
        seq { yield! it; yield ExpanderProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ExpanderProperty seq, value: System.String) =
        seq { yield! it; yield ExpanderProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ExpanderProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ExpanderProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ExpanderProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ExpanderProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ExpanderProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ExpanderProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ExpanderProperty seq, value: System.Int32) =
        seq { yield! it; yield ExpanderProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ExpanderProperty seq, value: System.Boolean) =
        seq { yield! it; yield ExpanderProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ExpanderProperty seq, value: System.Double) =
        seq { yield! it; yield ExpanderProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ExpanderProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ExpanderProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ExpanderProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ExpanderProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ExpanderProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ExpanderProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ExpanderProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ExpanderProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ExpanderProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ExpanderProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ExpanderProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ExpanderProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ExpanderProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ExpanderProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ExpanderProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ExpanderProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ExpanderProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ExpanderProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ExpanderProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ExpanderProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ExpanderProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ExpanderProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ExpanderProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ExpanderProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ExpanderProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ExpanderProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ExpanderProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ExpanderProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ExpanderProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ExpanderProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ExpanderProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ExpanderProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ExpanderProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ExpanderProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ExpanderProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ExpanderProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ExpanderProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ExpanderProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ExpanderProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ExpanderProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ExpanderProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ExpanderProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ExpanderProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ExpanderProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ExpanderProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ExpanderProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ExpanderProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ExpanderProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ExpanderProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ExpanderProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ExpanderProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ExpanderProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ExpanderProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ExpanderProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ExpanderProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ExpanderProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ExpanderProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ExpanderProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ExpanderProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ExpanderProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ExpanderProperty.OnFocused value } 

let prop = ExpanderPropertyBuilder()

