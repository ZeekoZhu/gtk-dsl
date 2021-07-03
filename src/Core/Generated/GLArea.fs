module Gtk.DSL.Binding.GLArea
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type GLAreaProperty =
    | AutoRender of System.Boolean
    | HasAlpha of System.Boolean
    | HasDepthBuffer of System.Boolean
    | HasStencilBuffer of System.Boolean
    | UseEs of System.Boolean
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
    |  OnCreateContext of (Gtk.CreateContextArgs -> unit)
    |  OnResize of (Gtk.ResizeArgs -> unit)
    |  OnRender of (Gtk.RenderArgs -> unit)
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

let bindProperty (widget: GLArea) (prop: GLAreaProperty) =
    match prop with
    | GLAreaProperty.AutoRender value -> widget.AutoRender <- value
    | GLAreaProperty.HasAlpha value -> widget.HasAlpha <- value
    | GLAreaProperty.HasDepthBuffer value -> widget.HasDepthBuffer <- value
    | GLAreaProperty.HasStencilBuffer value -> widget.HasStencilBuffer <- value
    | GLAreaProperty.UseEs value -> widget.UseEs <- value
    | GLAreaProperty.Name value -> widget.Name <- value
    | GLAreaProperty.Parent value -> widget.Parent <- value
    | GLAreaProperty.WidthRequest value -> widget.WidthRequest <- value
    | GLAreaProperty.HeightRequest value -> widget.HeightRequest <- value
    | GLAreaProperty.Visible value -> widget.Visible <- value
    | GLAreaProperty.Sensitive value -> widget.Sensitive <- value
    | GLAreaProperty.AppPaintable value -> widget.AppPaintable <- value
    | GLAreaProperty.CanFocus value -> widget.CanFocus <- value
    | GLAreaProperty.HasFocus value -> widget.HasFocus <- value
    | GLAreaProperty.IsFocus value -> widget.IsFocus <- value
    | GLAreaProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | GLAreaProperty.CanDefault value -> widget.CanDefault <- value
    | GLAreaProperty.HasDefault value -> widget.HasDefault <- value
    | GLAreaProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | GLAreaProperty.Style value -> widget.Style <- value
    | GLAreaProperty.Events value -> widget.Events <- value
    | GLAreaProperty.NoShowAll value -> widget.NoShowAll <- value
    | GLAreaProperty.HasTooltip value -> widget.HasTooltip <- value
    | GLAreaProperty.TooltipText value -> widget.TooltipText <- value
    | GLAreaProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | GLAreaProperty.Window value -> widget.Window <- value
    | GLAreaProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | GLAreaProperty.Halign value -> widget.Halign <- value
    | GLAreaProperty.Valign value -> widget.Valign <- value
    | GLAreaProperty.MarginLeft value -> widget.MarginLeft <- value
    | GLAreaProperty.MarginRight value -> widget.MarginRight <- value
    | GLAreaProperty.MarginStart value -> widget.MarginStart <- value
    | GLAreaProperty.MarginEnd value -> widget.MarginEnd <- value
    | GLAreaProperty.MarginTop value -> widget.MarginTop <- value
    | GLAreaProperty.MarginBottom value -> widget.MarginBottom <- value
    | GLAreaProperty.Margin value -> widget.Margin <- value
    | GLAreaProperty.Hexpand value -> widget.Hexpand <- value
    | GLAreaProperty.HexpandSet value -> widget.HexpandSet <- value
    | GLAreaProperty.Vexpand value -> widget.Vexpand <- value
    | GLAreaProperty.VexpandSet value -> widget.VexpandSet <- value
    | GLAreaProperty.Expand value -> widget.Expand <- value
    | GLAreaProperty.Opacity value -> widget.Opacity <- value
    | GLAreaProperty.OnCreateContext handler -> 
        let disposable = widget.CreateContext.Subscribe(handler)
        registerListener widget "CreateContext" disposable
    | GLAreaProperty.OnResize handler -> 
        let disposable = widget.Resize.Subscribe(handler)
        registerListener widget "Resize" disposable
    | GLAreaProperty.OnRender handler -> 
        let disposable = widget.Render.Subscribe(handler)
        registerListener widget "Render" disposable
    | GLAreaProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | GLAreaProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | GLAreaProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | GLAreaProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | GLAreaProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | GLAreaProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | GLAreaProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | GLAreaProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | GLAreaProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | GLAreaProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | GLAreaProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | GLAreaProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | GLAreaProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | GLAreaProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | GLAreaProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | GLAreaProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | GLAreaProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | GLAreaProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | GLAreaProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | GLAreaProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | GLAreaProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | GLAreaProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | GLAreaProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | GLAreaProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | GLAreaProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | GLAreaProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | GLAreaProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | GLAreaProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | GLAreaProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | GLAreaProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | GLAreaProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | GLAreaProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | GLAreaProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | GLAreaProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | GLAreaProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | GLAreaProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | GLAreaProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | GLAreaProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | GLAreaProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | GLAreaProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | GLAreaProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | GLAreaProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | GLAreaProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | GLAreaProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | GLAreaProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | GLAreaProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | GLAreaProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | GLAreaProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | GLAreaProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | GLAreaProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | GLAreaProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | GLAreaProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | GLAreaProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | GLAreaProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | GLAreaProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | GLAreaProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | GLAreaProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type GLAreaPropertyBuilder() =
    inherit BasePropertyBuilder<GLAreaProperty>()
    [<CustomOperation("autoRender")>]
    member this.AutoRender(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.AutoRender value } 
    [<CustomOperation("hasAlpha")>]
    member this.HasAlpha(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HasAlpha value } 
    [<CustomOperation("hasDepthBuffer")>]
    member this.HasDepthBuffer(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HasDepthBuffer value } 
    [<CustomOperation("hasStencilBuffer")>]
    member this.HasStencilBuffer(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HasStencilBuffer value } 
    [<CustomOperation("useEs")>]
    member this.UseEs(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.UseEs value } 
    [<CustomOperation("name")>]
    member this.Name(it: GLAreaProperty seq, value: System.String) =
        seq { yield! it; yield GLAreaProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: GLAreaProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield GLAreaProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: GLAreaProperty seq, value: Gtk.Style) =
        seq { yield! it; yield GLAreaProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: GLAreaProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield GLAreaProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: GLAreaProperty seq, value: System.String) =
        seq { yield! it; yield GLAreaProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: GLAreaProperty seq, value: System.String) =
        seq { yield! it; yield GLAreaProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: GLAreaProperty seq, value: Gdk.Window) =
        seq { yield! it; yield GLAreaProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: GLAreaProperty seq, value: Gtk.Align) =
        seq { yield! it; yield GLAreaProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: GLAreaProperty seq, value: Gtk.Align) =
        seq { yield! it; yield GLAreaProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: GLAreaProperty seq, value: System.Int32) =
        seq { yield! it; yield GLAreaProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: GLAreaProperty seq, value: System.Boolean) =
        seq { yield! it; yield GLAreaProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: GLAreaProperty seq, value: System.Double) =
        seq { yield! it; yield GLAreaProperty.Opacity value } 
    [<CustomOperation("onCreateContext")>]
    member this.OnCreateContext(it: GLAreaProperty seq, value: Gtk.CreateContextArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnCreateContext value } 
    [<CustomOperation("onResize")>]
    member this.OnResize(it: GLAreaProperty seq, value: Gtk.ResizeArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnResize value } 
    [<CustomOperation("onRender")>]
    member this.OnRender(it: GLAreaProperty seq, value: Gtk.RenderArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnRender value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: GLAreaProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: GLAreaProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: GLAreaProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: GLAreaProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: GLAreaProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: GLAreaProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: GLAreaProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: GLAreaProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: GLAreaProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: GLAreaProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: GLAreaProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: GLAreaProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: GLAreaProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: GLAreaProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: GLAreaProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: GLAreaProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: GLAreaProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: GLAreaProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: GLAreaProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: GLAreaProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: GLAreaProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: GLAreaProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: GLAreaProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: GLAreaProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: GLAreaProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: GLAreaProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: GLAreaProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: GLAreaProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: GLAreaProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: GLAreaProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: GLAreaProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: GLAreaProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: GLAreaProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: GLAreaProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: GLAreaProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: GLAreaProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: GLAreaProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: GLAreaProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: GLAreaProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: GLAreaProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: GLAreaProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: GLAreaProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: GLAreaProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: GLAreaProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: GLAreaProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: GLAreaProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: GLAreaProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: GLAreaProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: GLAreaProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: GLAreaProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: GLAreaProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: GLAreaProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: GLAreaProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: GLAreaProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: GLAreaProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: GLAreaProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: GLAreaProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield GLAreaProperty.OnFocused value } 

let prop = GLAreaPropertyBuilder()

type GLAreaDescriptor(props) =
    inherit BaseWidgetDescriptor<GLArea, GLAreaProperty>(props, bindProperty)
    override this.CreateTyped() = new GLArea()

let gLArea props = GLAreaDescriptor(props)

