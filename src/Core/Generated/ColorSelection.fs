module GtkDsl.Binding.ColorSelection
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ColorSelectionProperty =
    | [<Obsolete>] HasOpacityControl of System.Boolean
    | [<Obsolete>] HasPalette of System.Boolean
    | [<Obsolete>] CurrentColor of Gdk.Color
    | [<Obsolete>] CurrentAlpha of System.UInt16
    | [<Obsolete>] CurrentRgba of Gdk.RGBA
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

let bindProperty (widget: ColorSelection) (prop: ColorSelectionProperty) =
    match prop with
    | ColorSelectionProperty.HasOpacityControl value -> widget.HasOpacityControl <- value
    | ColorSelectionProperty.HasPalette value -> widget.HasPalette <- value
    | ColorSelectionProperty.CurrentColor value -> widget.CurrentColor <- value
    | ColorSelectionProperty.CurrentAlpha value -> widget.CurrentAlpha <- value
    | ColorSelectionProperty.CurrentRgba value -> widget.CurrentRgba <- value
    | ColorSelectionProperty.Spacing value -> widget.Spacing <- value
    | ColorSelectionProperty.Homogeneous value -> widget.Homogeneous <- value
    | ColorSelectionProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ColorSelectionProperty.Expand value -> widget.Expand <- value
    | ColorSelectionProperty.Fill value -> widget.Fill <- value
    | ColorSelectionProperty.Padding value -> widget.Padding <- value
    | ColorSelectionProperty.PackType value -> widget.PackType <- value
    | ColorSelectionProperty.Position value -> widget.Position <- value
    | ColorSelectionProperty.Orientation value -> widget.Orientation <- value
    | ColorSelectionProperty.ResizeMode value -> widget.ResizeMode <- value
    | ColorSelectionProperty.BorderWidth value -> widget.BorderWidth <- value
    | ColorSelectionProperty.Name value -> widget.Name <- value
    | ColorSelectionProperty.Parent value -> widget.Parent <- value
    | ColorSelectionProperty.WidthRequest value -> widget.WidthRequest <- value
    | ColorSelectionProperty.HeightRequest value -> widget.HeightRequest <- value
    | ColorSelectionProperty.Visible value -> widget.Visible <- value
    | ColorSelectionProperty.Sensitive value -> widget.Sensitive <- value
    | ColorSelectionProperty.AppPaintable value -> widget.AppPaintable <- value
    | ColorSelectionProperty.CanFocus value -> widget.CanFocus <- value
    | ColorSelectionProperty.HasFocus value -> widget.HasFocus <- value
    | ColorSelectionProperty.IsFocus value -> widget.IsFocus <- value
    | ColorSelectionProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ColorSelectionProperty.CanDefault value -> widget.CanDefault <- value
    | ColorSelectionProperty.HasDefault value -> widget.HasDefault <- value
    | ColorSelectionProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ColorSelectionProperty.Style value -> widget.Style <- value
    | ColorSelectionProperty.Events value -> widget.Events <- value
    | ColorSelectionProperty.NoShowAll value -> widget.NoShowAll <- value
    | ColorSelectionProperty.HasTooltip value -> widget.HasTooltip <- value
    | ColorSelectionProperty.TooltipText value -> widget.TooltipText <- value
    | ColorSelectionProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ColorSelectionProperty.Window value -> widget.Window <- value
    | ColorSelectionProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ColorSelectionProperty.Halign value -> widget.Halign <- value
    | ColorSelectionProperty.Valign value -> widget.Valign <- value
    | ColorSelectionProperty.MarginLeft value -> widget.MarginLeft <- value
    | ColorSelectionProperty.MarginRight value -> widget.MarginRight <- value
    | ColorSelectionProperty.MarginStart value -> widget.MarginStart <- value
    | ColorSelectionProperty.MarginEnd value -> widget.MarginEnd <- value
    | ColorSelectionProperty.MarginTop value -> widget.MarginTop <- value
    | ColorSelectionProperty.MarginBottom value -> widget.MarginBottom <- value
    | ColorSelectionProperty.Margin value -> widget.Margin <- value
    | ColorSelectionProperty.Hexpand value -> widget.Hexpand <- value
    | ColorSelectionProperty.HexpandSet value -> widget.HexpandSet <- value
    | ColorSelectionProperty.Vexpand value -> widget.Vexpand <- value
    | ColorSelectionProperty.VexpandSet value -> widget.VexpandSet <- value
    | ColorSelectionProperty.Opacity value -> widget.Opacity <- value
    | ColorSelectionProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ColorSelectionProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ColorSelectionProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ColorSelectionProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ColorSelectionProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ColorSelectionProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ColorSelectionProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ColorSelectionProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ColorSelectionProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ColorSelectionProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ColorSelectionProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ColorSelectionProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ColorSelectionProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ColorSelectionProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ColorSelectionProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ColorSelectionProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ColorSelectionProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ColorSelectionProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ColorSelectionProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ColorSelectionProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ColorSelectionProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ColorSelectionProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ColorSelectionProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ColorSelectionProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ColorSelectionProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ColorSelectionProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ColorSelectionProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ColorSelectionProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ColorSelectionProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ColorSelectionProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ColorSelectionProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ColorSelectionProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ColorSelectionProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ColorSelectionProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ColorSelectionProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ColorSelectionProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ColorSelectionProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ColorSelectionProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ColorSelectionProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ColorSelectionProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ColorSelectionProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ColorSelectionProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ColorSelectionProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ColorSelectionProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ColorSelectionProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ColorSelectionProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ColorSelectionProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ColorSelectionProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ColorSelectionProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ColorSelectionProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ColorSelectionProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ColorSelectionProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ColorSelectionProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ColorSelectionProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ColorSelectionProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ColorSelectionProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ColorSelectionProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ColorSelectionProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ColorSelectionProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ColorSelectionProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ColorSelectionPropertyBuilder() =
    inherit BasePropertyBuilder<ColorSelectionProperty>()
    [<Obsolete>]
    [<CustomOperation("hasOpacityControl")>]
    member this.HasOpacityControl(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.HasOpacityControl value } 
    [<Obsolete>]
    [<CustomOperation("hasPalette")>]
    member this.HasPalette(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.HasPalette value } 
    [<Obsolete>]
    [<CustomOperation("currentColor")>]
    member this.CurrentColor(it: ColorSelectionProperty seq, value: Gdk.Color) =
        seq { yield! it; yield ColorSelectionProperty.CurrentColor value } 
    [<Obsolete>]
    [<CustomOperation("currentAlpha")>]
    member this.CurrentAlpha(it: ColorSelectionProperty seq, value: System.UInt16) =
        seq { yield! it; yield ColorSelectionProperty.CurrentAlpha value } 
    [<Obsolete>]
    [<CustomOperation("currentRgba")>]
    member this.CurrentRgba(it: ColorSelectionProperty seq, value: Gdk.RGBA) =
        seq { yield! it; yield ColorSelectionProperty.CurrentRgba value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ColorSelectionProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ColorSelectionProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ColorSelectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorSelectionProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ColorSelectionProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ColorSelectionProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ColorSelectionProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ColorSelectionProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ColorSelectionProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ColorSelectionProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ColorSelectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorSelectionProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ColorSelectionProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ColorSelectionProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorSelectionProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ColorSelectionProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ColorSelectionProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ColorSelectionProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ColorSelectionProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ColorSelectionProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ColorSelectionProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ColorSelectionProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ColorSelectionProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ColorSelectionProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorSelectionProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ColorSelectionProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorSelectionProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ColorSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ColorSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ColorSelectionProperty seq, value: System.Double) =
        seq { yield! it; yield ColorSelectionProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ColorSelectionProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ColorSelectionProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ColorSelectionProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ColorSelectionProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ColorSelectionProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ColorSelectionProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ColorSelectionProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ColorSelectionProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ColorSelectionProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ColorSelectionProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ColorSelectionProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ColorSelectionProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ColorSelectionProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ColorSelectionProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ColorSelectionProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ColorSelectionProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ColorSelectionProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ColorSelectionProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ColorSelectionProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ColorSelectionProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ColorSelectionProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ColorSelectionProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ColorSelectionProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ColorSelectionProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ColorSelectionProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ColorSelectionProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ColorSelectionProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ColorSelectionProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ColorSelectionProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ColorSelectionProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ColorSelectionProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ColorSelectionProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ColorSelectionProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ColorSelectionProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ColorSelectionProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ColorSelectionProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ColorSelectionProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ColorSelectionProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ColorSelectionProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ColorSelectionProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ColorSelectionProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ColorSelectionProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ColorSelectionProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ColorSelectionProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ColorSelectionProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ColorSelectionProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ColorSelectionProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ColorSelectionProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ColorSelectionProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ColorSelectionProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ColorSelectionProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ColorSelectionProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ColorSelectionProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ColorSelectionProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ColorSelectionProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ColorSelectionProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ColorSelectionProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ColorSelectionProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ColorSelectionProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ColorSelectionProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ColorSelectionProperty.OnFocused value } 

let prop = ColorSelectionPropertyBuilder()

type ColorSelectionDescriptor(props) =
    inherit BaseWidgetDescriptor<ColorSelection, ColorSelectionProperty>(props, bindProperty)
    override this.CreateTyped() = new ColorSelection()

let colorSelection props = ColorSelectionDescriptor(props)

