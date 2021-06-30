module GtkDsl.Binding.CellView
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type CellViewProperty =
    | BackgroundGdk of Gdk.Color
    | BackgroundRgba of Gdk.RGBA
    | Model of Gtk.ITreeModel
    | DrawSensitive of System.Boolean
    | FitModel of System.Boolean
    | Orientation of Gtk.Orientation
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

let bindProperty (widget: CellView) (prop: CellViewProperty) =
    match prop with
    | CellViewProperty.BackgroundGdk value -> widget.BackgroundGdk <- value
    | CellViewProperty.BackgroundRgba value -> widget.BackgroundRgba <- value
    | CellViewProperty.Model value -> widget.Model <- value
    | CellViewProperty.DrawSensitive value -> widget.DrawSensitive <- value
    | CellViewProperty.FitModel value -> widget.FitModel <- value
    | CellViewProperty.Orientation value -> widget.Orientation <- value
    | CellViewProperty.Name value -> widget.Name <- value
    | CellViewProperty.Parent value -> widget.Parent <- value
    | CellViewProperty.WidthRequest value -> widget.WidthRequest <- value
    | CellViewProperty.HeightRequest value -> widget.HeightRequest <- value
    | CellViewProperty.Visible value -> widget.Visible <- value
    | CellViewProperty.Sensitive value -> widget.Sensitive <- value
    | CellViewProperty.AppPaintable value -> widget.AppPaintable <- value
    | CellViewProperty.CanFocus value -> widget.CanFocus <- value
    | CellViewProperty.HasFocus value -> widget.HasFocus <- value
    | CellViewProperty.IsFocus value -> widget.IsFocus <- value
    | CellViewProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | CellViewProperty.CanDefault value -> widget.CanDefault <- value
    | CellViewProperty.HasDefault value -> widget.HasDefault <- value
    | CellViewProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | CellViewProperty.Style value -> widget.Style <- value
    | CellViewProperty.Events value -> widget.Events <- value
    | CellViewProperty.NoShowAll value -> widget.NoShowAll <- value
    | CellViewProperty.HasTooltip value -> widget.HasTooltip <- value
    | CellViewProperty.TooltipText value -> widget.TooltipText <- value
    | CellViewProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | CellViewProperty.Window value -> widget.Window <- value
    | CellViewProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | CellViewProperty.Halign value -> widget.Halign <- value
    | CellViewProperty.Valign value -> widget.Valign <- value
    | CellViewProperty.MarginLeft value -> widget.MarginLeft <- value
    | CellViewProperty.MarginRight value -> widget.MarginRight <- value
    | CellViewProperty.MarginStart value -> widget.MarginStart <- value
    | CellViewProperty.MarginEnd value -> widget.MarginEnd <- value
    | CellViewProperty.MarginTop value -> widget.MarginTop <- value
    | CellViewProperty.MarginBottom value -> widget.MarginBottom <- value
    | CellViewProperty.Margin value -> widget.Margin <- value
    | CellViewProperty.Hexpand value -> widget.Hexpand <- value
    | CellViewProperty.HexpandSet value -> widget.HexpandSet <- value
    | CellViewProperty.Vexpand value -> widget.Vexpand <- value
    | CellViewProperty.VexpandSet value -> widget.VexpandSet <- value
    | CellViewProperty.Expand value -> widget.Expand <- value
    | CellViewProperty.Opacity value -> widget.Opacity <- value
    | CellViewProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | CellViewProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | CellViewProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | CellViewProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | CellViewProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | CellViewProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | CellViewProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | CellViewProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | CellViewProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | CellViewProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | CellViewProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | CellViewProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | CellViewProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | CellViewProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | CellViewProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | CellViewProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | CellViewProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | CellViewProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | CellViewProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | CellViewProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | CellViewProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | CellViewProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | CellViewProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | CellViewProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | CellViewProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | CellViewProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | CellViewProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | CellViewProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | CellViewProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | CellViewProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | CellViewProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | CellViewProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | CellViewProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | CellViewProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | CellViewProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | CellViewProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | CellViewProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | CellViewProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | CellViewProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | CellViewProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | CellViewProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | CellViewProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | CellViewProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | CellViewProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | CellViewProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | CellViewProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | CellViewProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | CellViewProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | CellViewProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | CellViewProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | CellViewProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | CellViewProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | CellViewProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | CellViewProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | CellViewProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | CellViewProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | CellViewProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type CellViewPropertyBuilder() =
    inherit BasePropertyBuilder<CellViewProperty>()
    [<CustomOperation("backgroundGdk")>]
    member this.BackgroundGdk(it: CellViewProperty seq, value: Gdk.Color) =
        seq { yield! it; yield CellViewProperty.BackgroundGdk value } 
    [<CustomOperation("backgroundRgba")>]
    member this.BackgroundRgba(it: CellViewProperty seq, value: Gdk.RGBA) =
        seq { yield! it; yield CellViewProperty.BackgroundRgba value } 
    [<CustomOperation("model")>]
    member this.Model(it: CellViewProperty seq, value: Gtk.ITreeModel) =
        seq { yield! it; yield CellViewProperty.Model value } 
    [<CustomOperation("drawSensitive")>]
    member this.DrawSensitive(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.DrawSensitive value } 
    [<CustomOperation("fitModel")>]
    member this.FitModel(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.FitModel value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: CellViewProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield CellViewProperty.Orientation value } 
    [<CustomOperation("name")>]
    member this.Name(it: CellViewProperty seq, value: System.String) =
        seq { yield! it; yield CellViewProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: CellViewProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CellViewProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: CellViewProperty seq, value: Gtk.Style) =
        seq { yield! it; yield CellViewProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: CellViewProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield CellViewProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: CellViewProperty seq, value: System.String) =
        seq { yield! it; yield CellViewProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: CellViewProperty seq, value: System.String) =
        seq { yield! it; yield CellViewProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: CellViewProperty seq, value: Gdk.Window) =
        seq { yield! it; yield CellViewProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: CellViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CellViewProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: CellViewProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CellViewProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: CellViewProperty seq, value: System.Int32) =
        seq { yield! it; yield CellViewProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: CellViewProperty seq, value: System.Boolean) =
        seq { yield! it; yield CellViewProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: CellViewProperty seq, value: System.Double) =
        seq { yield! it; yield CellViewProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: CellViewProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: CellViewProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: CellViewProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: CellViewProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: CellViewProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: CellViewProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: CellViewProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: CellViewProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: CellViewProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: CellViewProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: CellViewProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: CellViewProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: CellViewProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: CellViewProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: CellViewProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: CellViewProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: CellViewProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: CellViewProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: CellViewProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: CellViewProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: CellViewProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: CellViewProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: CellViewProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: CellViewProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: CellViewProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: CellViewProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: CellViewProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: CellViewProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: CellViewProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: CellViewProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: CellViewProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: CellViewProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: CellViewProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: CellViewProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: CellViewProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: CellViewProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: CellViewProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: CellViewProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: CellViewProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: CellViewProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: CellViewProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: CellViewProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: CellViewProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: CellViewProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: CellViewProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: CellViewProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: CellViewProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: CellViewProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: CellViewProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: CellViewProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: CellViewProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: CellViewProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: CellViewProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: CellViewProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: CellViewProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: CellViewProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: CellViewProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield CellViewProperty.OnFocused value } 

let prop = CellViewPropertyBuilder()

type CellViewDescriptor(props) =
    inherit BaseWidgetDescriptor<CellView, CellViewProperty>(props, bindProperty)
    override this.CreateTyped() = new CellView()

let cellView props = CellViewDescriptor(props)

