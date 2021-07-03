module Gtk.DSL.Binding.HeaderBar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HeaderBarProperty =
    | Title of System.String
    | Subtitle of System.String
    | CustomTitle of Gtk.Widget
    | Spacing of System.Int32
    | ShowCloseButton of System.Boolean
    | DecorationLayout of System.String
    | DecorationLayoutSet of System.Boolean
    | HasSubtitle of System.Boolean
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

let bindProperty (widget: HeaderBar) (prop: HeaderBarProperty) =
    match prop with
    | HeaderBarProperty.Title value -> widget.Title <- value
    | HeaderBarProperty.Subtitle value -> widget.Subtitle <- value
    | HeaderBarProperty.CustomTitle value -> widget.CustomTitle <- value
    | HeaderBarProperty.Spacing value -> widget.Spacing <- value
    | HeaderBarProperty.ShowCloseButton value -> widget.ShowCloseButton <- value
    | HeaderBarProperty.DecorationLayout value -> widget.DecorationLayout <- value
    | HeaderBarProperty.DecorationLayoutSet value -> widget.DecorationLayoutSet <- value
    | HeaderBarProperty.HasSubtitle value -> widget.HasSubtitle <- value
    | HeaderBarProperty.ResizeMode value -> widget.ResizeMode <- value
    | HeaderBarProperty.BorderWidth value -> widget.BorderWidth <- value
    | HeaderBarProperty.Name value -> widget.Name <- value
    | HeaderBarProperty.Parent value -> widget.Parent <- value
    | HeaderBarProperty.WidthRequest value -> widget.WidthRequest <- value
    | HeaderBarProperty.HeightRequest value -> widget.HeightRequest <- value
    | HeaderBarProperty.Visible value -> widget.Visible <- value
    | HeaderBarProperty.Sensitive value -> widget.Sensitive <- value
    | HeaderBarProperty.AppPaintable value -> widget.AppPaintable <- value
    | HeaderBarProperty.CanFocus value -> widget.CanFocus <- value
    | HeaderBarProperty.HasFocus value -> widget.HasFocus <- value
    | HeaderBarProperty.IsFocus value -> widget.IsFocus <- value
    | HeaderBarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HeaderBarProperty.CanDefault value -> widget.CanDefault <- value
    | HeaderBarProperty.HasDefault value -> widget.HasDefault <- value
    | HeaderBarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HeaderBarProperty.Style value -> widget.Style <- value
    | HeaderBarProperty.Events value -> widget.Events <- value
    | HeaderBarProperty.NoShowAll value -> widget.NoShowAll <- value
    | HeaderBarProperty.HasTooltip value -> widget.HasTooltip <- value
    | HeaderBarProperty.TooltipText value -> widget.TooltipText <- value
    | HeaderBarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HeaderBarProperty.Window value -> widget.Window <- value
    | HeaderBarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HeaderBarProperty.Halign value -> widget.Halign <- value
    | HeaderBarProperty.Valign value -> widget.Valign <- value
    | HeaderBarProperty.MarginLeft value -> widget.MarginLeft <- value
    | HeaderBarProperty.MarginRight value -> widget.MarginRight <- value
    | HeaderBarProperty.MarginStart value -> widget.MarginStart <- value
    | HeaderBarProperty.MarginEnd value -> widget.MarginEnd <- value
    | HeaderBarProperty.MarginTop value -> widget.MarginTop <- value
    | HeaderBarProperty.MarginBottom value -> widget.MarginBottom <- value
    | HeaderBarProperty.Margin value -> widget.Margin <- value
    | HeaderBarProperty.Hexpand value -> widget.Hexpand <- value
    | HeaderBarProperty.HexpandSet value -> widget.HexpandSet <- value
    | HeaderBarProperty.Vexpand value -> widget.Vexpand <- value
    | HeaderBarProperty.VexpandSet value -> widget.VexpandSet <- value
    | HeaderBarProperty.Expand value -> widget.Expand <- value
    | HeaderBarProperty.Opacity value -> widget.Opacity <- value
    | HeaderBarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | HeaderBarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | HeaderBarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | HeaderBarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HeaderBarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HeaderBarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HeaderBarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HeaderBarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HeaderBarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HeaderBarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HeaderBarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HeaderBarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HeaderBarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HeaderBarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HeaderBarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HeaderBarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HeaderBarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HeaderBarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HeaderBarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HeaderBarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HeaderBarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HeaderBarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HeaderBarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HeaderBarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HeaderBarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HeaderBarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HeaderBarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HeaderBarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HeaderBarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HeaderBarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HeaderBarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HeaderBarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HeaderBarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HeaderBarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HeaderBarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HeaderBarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HeaderBarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HeaderBarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HeaderBarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HeaderBarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HeaderBarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HeaderBarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HeaderBarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HeaderBarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HeaderBarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HeaderBarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HeaderBarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HeaderBarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HeaderBarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HeaderBarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HeaderBarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HeaderBarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HeaderBarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HeaderBarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HeaderBarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HeaderBarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HeaderBarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HeaderBarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HeaderBarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HeaderBarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HeaderBarPropertyBuilder() =
    inherit BasePropertyBuilder<HeaderBarProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: HeaderBarProperty seq, value: System.String) =
        seq { yield! it; yield HeaderBarProperty.Title value } 
    [<CustomOperation("subtitle")>]
    member this.Subtitle(it: HeaderBarProperty seq, value: System.String) =
        seq { yield! it; yield HeaderBarProperty.Subtitle value } 
    [<CustomOperation("customTitle")>]
    member this.CustomTitle(it: HeaderBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HeaderBarProperty.CustomTitle value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.Spacing value } 
    [<CustomOperation("showCloseButton")>]
    member this.ShowCloseButton(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.ShowCloseButton value } 
    [<CustomOperation("decorationLayout")>]
    member this.DecorationLayout(it: HeaderBarProperty seq, value: System.String) =
        seq { yield! it; yield HeaderBarProperty.DecorationLayout value } 
    [<CustomOperation("decorationLayoutSet")>]
    member this.DecorationLayoutSet(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.DecorationLayoutSet value } 
    [<CustomOperation("hasSubtitle")>]
    member this.HasSubtitle(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.HasSubtitle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: HeaderBarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield HeaderBarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: HeaderBarProperty seq, value: System.UInt32) =
        seq { yield! it; yield HeaderBarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: HeaderBarProperty seq, value: System.String) =
        seq { yield! it; yield HeaderBarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HeaderBarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HeaderBarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HeaderBarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HeaderBarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HeaderBarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HeaderBarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HeaderBarProperty seq, value: System.String) =
        seq { yield! it; yield HeaderBarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HeaderBarProperty seq, value: System.String) =
        seq { yield! it; yield HeaderBarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HeaderBarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HeaderBarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HeaderBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HeaderBarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HeaderBarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HeaderBarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HeaderBarProperty seq, value: System.Int32) =
        seq { yield! it; yield HeaderBarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HeaderBarProperty seq, value: System.Boolean) =
        seq { yield! it; yield HeaderBarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HeaderBarProperty seq, value: System.Double) =
        seq { yield! it; yield HeaderBarProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: HeaderBarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: HeaderBarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: HeaderBarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HeaderBarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HeaderBarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HeaderBarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HeaderBarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HeaderBarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HeaderBarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HeaderBarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HeaderBarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HeaderBarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HeaderBarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HeaderBarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HeaderBarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HeaderBarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HeaderBarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HeaderBarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HeaderBarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HeaderBarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HeaderBarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HeaderBarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HeaderBarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HeaderBarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HeaderBarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HeaderBarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HeaderBarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HeaderBarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HeaderBarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HeaderBarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HeaderBarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HeaderBarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HeaderBarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HeaderBarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HeaderBarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HeaderBarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HeaderBarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HeaderBarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HeaderBarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HeaderBarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HeaderBarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HeaderBarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HeaderBarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HeaderBarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HeaderBarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HeaderBarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HeaderBarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HeaderBarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HeaderBarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HeaderBarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HeaderBarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HeaderBarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HeaderBarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HeaderBarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HeaderBarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HeaderBarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HeaderBarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HeaderBarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HeaderBarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HeaderBarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HeaderBarProperty.OnFocused value } 

let prop = HeaderBarPropertyBuilder()

type HeaderBarDescriptor(props) =
    inherit BaseWidgetDescriptor<HeaderBar, HeaderBarProperty>(props, bindProperty)
    override this.CreateTyped() = new HeaderBar()

let headerBar props = HeaderBarDescriptor(props)

