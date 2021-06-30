module GtkDsl.Binding.Image
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ImageProperty =
    | Pixbuf of Gdk.Pixbuf
    | File of System.String
    | Stock of System.String
    | IconSet of Gtk.IconSet
    | IconSize of System.Int32
    | PixelSize of System.Int32
    | PixbufAnimation of Gdk.PixbufAnimation
    | IconName of System.String
    | Icon of GLib.IIcon
    | Resource of System.String
    | UseFallback of System.Boolean
    | Xalign of System.Single
    | Yalign of System.Single
    | Xpad of System.Int32
    | Ypad of System.Int32
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

let bindProperty (widget: Image) (prop: ImageProperty) =
    match prop with
    | ImageProperty.Pixbuf value -> widget.Pixbuf <- value
    | ImageProperty.File value -> widget.File <- value
    | ImageProperty.Stock value -> widget.Stock <- value
    | ImageProperty.IconSet value -> widget.IconSet <- value
    | ImageProperty.IconSize value -> widget.IconSize <- value
    | ImageProperty.PixelSize value -> widget.PixelSize <- value
    | ImageProperty.PixbufAnimation value -> widget.PixbufAnimation <- value
    | ImageProperty.IconName value -> widget.IconName <- value
    | ImageProperty.Icon value -> widget.Icon <- value
    | ImageProperty.Resource value -> widget.Resource <- value
    | ImageProperty.UseFallback value -> widget.UseFallback <- value
    | ImageProperty.Xalign value -> widget.Xalign <- value
    | ImageProperty.Yalign value -> widget.Yalign <- value
    | ImageProperty.Xpad value -> widget.Xpad <- value
    | ImageProperty.Ypad value -> widget.Ypad <- value
    | ImageProperty.Name value -> widget.Name <- value
    | ImageProperty.Parent value -> widget.Parent <- value
    | ImageProperty.WidthRequest value -> widget.WidthRequest <- value
    | ImageProperty.HeightRequest value -> widget.HeightRequest <- value
    | ImageProperty.Visible value -> widget.Visible <- value
    | ImageProperty.Sensitive value -> widget.Sensitive <- value
    | ImageProperty.AppPaintable value -> widget.AppPaintable <- value
    | ImageProperty.CanFocus value -> widget.CanFocus <- value
    | ImageProperty.HasFocus value -> widget.HasFocus <- value
    | ImageProperty.IsFocus value -> widget.IsFocus <- value
    | ImageProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ImageProperty.CanDefault value -> widget.CanDefault <- value
    | ImageProperty.HasDefault value -> widget.HasDefault <- value
    | ImageProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ImageProperty.Style value -> widget.Style <- value
    | ImageProperty.Events value -> widget.Events <- value
    | ImageProperty.NoShowAll value -> widget.NoShowAll <- value
    | ImageProperty.HasTooltip value -> widget.HasTooltip <- value
    | ImageProperty.TooltipText value -> widget.TooltipText <- value
    | ImageProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ImageProperty.Window value -> widget.Window <- value
    | ImageProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ImageProperty.Halign value -> widget.Halign <- value
    | ImageProperty.Valign value -> widget.Valign <- value
    | ImageProperty.MarginLeft value -> widget.MarginLeft <- value
    | ImageProperty.MarginRight value -> widget.MarginRight <- value
    | ImageProperty.MarginStart value -> widget.MarginStart <- value
    | ImageProperty.MarginEnd value -> widget.MarginEnd <- value
    | ImageProperty.MarginTop value -> widget.MarginTop <- value
    | ImageProperty.MarginBottom value -> widget.MarginBottom <- value
    | ImageProperty.Margin value -> widget.Margin <- value
    | ImageProperty.Hexpand value -> widget.Hexpand <- value
    | ImageProperty.HexpandSet value -> widget.HexpandSet <- value
    | ImageProperty.Vexpand value -> widget.Vexpand <- value
    | ImageProperty.VexpandSet value -> widget.VexpandSet <- value
    | ImageProperty.Expand value -> widget.Expand <- value
    | ImageProperty.Opacity value -> widget.Opacity <- value
    | ImageProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ImageProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ImageProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ImageProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ImageProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ImageProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ImageProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ImageProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ImageProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ImageProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ImageProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ImageProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ImageProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ImageProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ImageProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ImageProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ImageProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ImageProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ImageProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ImageProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ImageProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ImageProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ImageProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ImageProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ImageProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ImageProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ImageProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ImageProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ImageProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ImageProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ImageProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ImageProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ImageProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ImageProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ImageProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ImageProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ImageProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ImageProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ImageProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ImageProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ImageProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ImageProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ImageProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ImageProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ImageProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ImageProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ImageProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ImageProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ImageProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ImageProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ImageProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ImageProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ImageProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ImageProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ImageProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ImageProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ImageProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ImagePropertyBuilder() =
    inherit BasePropertyBuilder<ImageProperty>()
    [<CustomOperation("pixbuf")>]
    member this.Pixbuf(it: ImageProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield ImageProperty.Pixbuf value } 
    [<CustomOperation("file")>]
    member this.File(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.File value } 
    [<CustomOperation("stock")>]
    member this.Stock(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.Stock value } 
    [<CustomOperation("iconSet")>]
    member this.IconSet(it: ImageProperty seq, value: Gtk.IconSet) =
        seq { yield! it; yield ImageProperty.IconSet value } 
    [<CustomOperation("iconSize")>]
    member this.IconSize(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.IconSize value } 
    [<CustomOperation("pixelSize")>]
    member this.PixelSize(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.PixelSize value } 
    [<CustomOperation("pixbufAnimation")>]
    member this.PixbufAnimation(it: ImageProperty seq, value: Gdk.PixbufAnimation) =
        seq { yield! it; yield ImageProperty.PixbufAnimation value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.IconName value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: ImageProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield ImageProperty.Icon value } 
    [<CustomOperation("resource")>]
    member this.Resource(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.Resource value } 
    [<CustomOperation("useFallback")>]
    member this.UseFallback(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.UseFallback value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: ImageProperty seq, value: System.Single) =
        seq { yield! it; yield ImageProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: ImageProperty seq, value: System.Single) =
        seq { yield! it; yield ImageProperty.Yalign value } 
    [<CustomOperation("xpad")>]
    member this.Xpad(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.Xpad value } 
    [<CustomOperation("ypad")>]
    member this.Ypad(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.Ypad value } 
    [<CustomOperation("name")>]
    member this.Name(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ImageProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ImageProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ImageProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ImageProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ImageProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ImageProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ImageProperty seq, value: System.String) =
        seq { yield! it; yield ImageProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ImageProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ImageProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ImageProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ImageProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ImageProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ImageProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ImageProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ImageProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ImageProperty seq, value: System.Double) =
        seq { yield! it; yield ImageProperty.Opacity value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ImageProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ImageProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ImageProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ImageProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ImageProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ImageProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ImageProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ImageProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ImageProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ImageProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ImageProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ImageProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ImageProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ImageProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ImageProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ImageProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ImageProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ImageProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ImageProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ImageProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ImageProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ImageProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ImageProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ImageProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ImageProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ImageProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ImageProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ImageProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ImageProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ImageProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ImageProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ImageProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ImageProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ImageProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ImageProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ImageProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ImageProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ImageProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ImageProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ImageProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ImageProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ImageProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ImageProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ImageProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ImageProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ImageProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ImageProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ImageProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ImageProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ImageProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ImageProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ImageProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ImageProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ImageProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ImageProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ImageProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ImageProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ImageProperty.OnFocused value } 

let prop = ImagePropertyBuilder()

type ImageDescriptor(props) =
    inherit BaseWidgetDescriptor<Image, ImageProperty>(props, bindProperty)
    override this.CreateTyped() = new Image()

let image props = ImageDescriptor(props)

