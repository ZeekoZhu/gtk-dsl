module GtkDsl.Binding.LevelBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type LevelBarProperty =
    | Value of System.Double
    | MinValue of System.Double
    | MaxValue of System.Double
    | Mode of Gtk.LevelBarMode
    | Inverted of System.Boolean
    | MinBlockHeight of System.Int32
    | MinBlockWidth of System.Int32
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
    |  OnOffsetChanged of (Gtk.OffsetChangedArgs -> unit)
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

let bindProperty (widget: LevelBar) (prop: LevelBarProperty) =
    match prop with
    | LevelBarProperty.Value value -> widget.Value <- value
    | LevelBarProperty.MinValue value -> widget.MinValue <- value
    | LevelBarProperty.MaxValue value -> widget.MaxValue <- value
    | LevelBarProperty.Mode value -> widget.Mode <- value
    | LevelBarProperty.Inverted value -> widget.Inverted <- value
    | LevelBarProperty.MinBlockHeight value -> widget.MinBlockHeight <- value
    | LevelBarProperty.MinBlockWidth value -> widget.MinBlockWidth <- value
    | LevelBarProperty.Orientation value -> widget.Orientation <- value
    | LevelBarProperty.Name value -> widget.Name <- value
    | LevelBarProperty.Parent value -> widget.Parent <- value
    | LevelBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | LevelBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | LevelBarProperty.Visible value -> widget.Visible <- value
    | LevelBarProperty.Sensitive value -> widget.Sensitive <- value
    | LevelBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | LevelBarProperty.CanFocus value -> widget.CanFocus <- value
    | LevelBarProperty.HasFocus value -> widget.HasFocus <- value
    | LevelBarProperty.IsFocus value -> widget.IsFocus <- value
    | LevelBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | LevelBarProperty.CanDefault value -> widget.CanDefault <- value
    | LevelBarProperty.HasDefault value -> widget.HasDefault <- value
    | LevelBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | LevelBarProperty.Style value -> widget.Style <- value
    | LevelBarProperty.Events value -> widget.Events <- value
    | LevelBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | LevelBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | LevelBarProperty.TooltipText value -> widget.TooltipText <- value
    | LevelBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | LevelBarProperty.Window value -> widget.Window <- value
    | LevelBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | LevelBarProperty.Halign value -> widget.Halign <- value
    | LevelBarProperty.Valign value -> widget.Valign <- value
    | LevelBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | LevelBarProperty.MarginRight value -> widget.MarginRight <- value
    | LevelBarProperty.MarginStart value -> widget.MarginStart <- value
    | LevelBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | LevelBarProperty.MarginTop value -> widget.MarginTop <- value
    | LevelBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | LevelBarProperty.Margin value -> widget.Margin <- value
    | LevelBarProperty.Hexpand value -> widget.Hexpand <- value
    | LevelBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | LevelBarProperty.Vexpand value -> widget.Vexpand <- value
    | LevelBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | LevelBarProperty.Expand value -> widget.Expand <- value
    | LevelBarProperty.Opacity value -> widget.Opacity <- value
    | LevelBarProperty.OnOffsetChanged handler -> 
        let disposable = widget.OffsetChanged.Subscribe(handler)
        registerListener widget "OffsetChanged" disposable
    | LevelBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | LevelBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | LevelBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | LevelBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | LevelBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | LevelBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | LevelBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | LevelBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | LevelBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | LevelBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | LevelBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | LevelBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | LevelBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | LevelBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | LevelBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | LevelBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | LevelBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | LevelBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | LevelBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | LevelBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | LevelBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | LevelBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | LevelBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | LevelBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | LevelBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | LevelBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | LevelBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | LevelBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | LevelBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | LevelBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | LevelBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | LevelBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | LevelBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | LevelBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | LevelBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | LevelBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | LevelBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | LevelBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | LevelBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | LevelBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | LevelBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | LevelBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | LevelBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | LevelBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | LevelBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | LevelBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | LevelBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | LevelBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | LevelBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | LevelBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | LevelBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | LevelBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | LevelBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | LevelBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | LevelBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | LevelBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | LevelBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type LevelBarPropertyBuilder() =
    inherit BasePropertyBuilder<LevelBarProperty>()
    [<CustomOperation("value")>]
    member this.Value(it: LevelBarProperty seq, value: System.Double) =
        seq { yield! it; yield LevelBarProperty.Value value } 
    [<CustomOperation("minValue")>]
    member this.MinValue(it: LevelBarProperty seq, value: System.Double) =
        seq { yield! it; yield LevelBarProperty.MinValue value } 
    [<CustomOperation("maxValue")>]
    member this.MaxValue(it: LevelBarProperty seq, value: System.Double) =
        seq { yield! it; yield LevelBarProperty.MaxValue value } 
    [<CustomOperation("mode")>]
    member this.Mode(it: LevelBarProperty seq, value: Gtk.LevelBarMode) =
        seq { yield! it; yield LevelBarProperty.Mode value } 
    [<CustomOperation("inverted")>]
    member this.Inverted(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.Inverted value } 
    [<CustomOperation("minBlockHeight")>]
    member this.MinBlockHeight(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MinBlockHeight value } 
    [<CustomOperation("minBlockWidth")>]
    member this.MinBlockWidth(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MinBlockWidth value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: LevelBarProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield LevelBarProperty.Orientation value } 
    [<CustomOperation("name")>]
    member this.Name(it: LevelBarProperty seq, value: System.String) =
        seq { yield! it; yield LevelBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: LevelBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield LevelBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: LevelBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield LevelBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: LevelBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield LevelBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: LevelBarProperty seq, value: System.String) =
        seq { yield! it; yield LevelBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: LevelBarProperty seq, value: System.String) =
        seq { yield! it; yield LevelBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: LevelBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield LevelBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: LevelBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LevelBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: LevelBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LevelBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: LevelBarProperty seq, value: System.Int32) =
        seq { yield! it; yield LevelBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: LevelBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield LevelBarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: LevelBarProperty seq, value: System.Double) =
        seq { yield! it; yield LevelBarProperty.Opacity value } 
    [<CustomOperation("onOffsetChanged")>]
    member this.OnOffsetChanged(it: LevelBarProperty seq, value: Gtk.OffsetChangedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnOffsetChanged value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: LevelBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: LevelBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: LevelBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: LevelBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: LevelBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: LevelBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: LevelBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: LevelBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: LevelBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: LevelBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: LevelBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: LevelBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: LevelBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: LevelBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: LevelBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: LevelBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: LevelBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: LevelBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: LevelBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: LevelBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: LevelBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: LevelBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: LevelBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: LevelBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: LevelBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: LevelBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: LevelBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: LevelBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: LevelBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: LevelBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: LevelBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: LevelBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: LevelBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: LevelBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: LevelBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: LevelBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: LevelBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: LevelBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: LevelBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: LevelBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: LevelBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: LevelBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: LevelBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: LevelBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: LevelBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: LevelBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: LevelBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: LevelBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: LevelBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: LevelBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: LevelBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: LevelBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: LevelBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: LevelBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: LevelBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: LevelBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: LevelBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield LevelBarProperty.OnFocused value } 

let prop = LevelBarPropertyBuilder()

type LevelBarDescriptor(props) =
    inherit BaseWidgetDescriptor<LevelBar, LevelBarProperty>(props, bindProperty)
    override this.CreateTyped() = new LevelBar()

let levelBar props = LevelBarDescriptor(props)

