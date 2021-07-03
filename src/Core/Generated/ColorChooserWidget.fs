module Gtk.DSL.Binding.ColorChooserWidget
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ColorChooserWidgetProperty =
    | ShowEditor of System.Boolean
    | Rgba of Gdk.RGBA
    | UseAlpha of System.Boolean
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
    |  OnColorActivated of (Gtk.ColorActivatedArgs -> unit)
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

let bindProperty (widget: ColorChooserWidget) (prop: ColorChooserWidgetProperty) =
    match prop with
    | ColorChooserWidgetProperty.ShowEditor value -> widget.ShowEditor <- value
    | ColorChooserWidgetProperty.Rgba value -> widget.Rgba <- value
    | ColorChooserWidgetProperty.UseAlpha value -> widget.UseAlpha <- value
    | ColorChooserWidgetProperty.Spacing value -> widget.Spacing <- value
    | ColorChooserWidgetProperty.Homogeneous value -> widget.Homogeneous <- value
    | ColorChooserWidgetProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ColorChooserWidgetProperty.Expand value -> widget.Expand <- value
    | ColorChooserWidgetProperty.Fill value -> widget.Fill <- value
    | ColorChooserWidgetProperty.Padding value -> widget.Padding <- value
    | ColorChooserWidgetProperty.PackType value -> widget.PackType <- value
    | ColorChooserWidgetProperty.Position value -> widget.Position <- value
    | ColorChooserWidgetProperty.Orientation value -> widget.Orientation <- value
    | ColorChooserWidgetProperty.ResizeMode value -> widget.ResizeMode <- value
    | ColorChooserWidgetProperty.BorderWidth value -> widget.BorderWidth <- value
    | ColorChooserWidgetProperty.Name value -> widget.Name <- value
    | ColorChooserWidgetProperty.Parent value -> widget.Parent <- value
    | ColorChooserWidgetProperty.WidthRequest value -> widget.WidthRequest <- value
    | ColorChooserWidgetProperty.HeightRequest value -> widget.HeightRequest <- value
    | ColorChooserWidgetProperty.Visible value -> widget.Visible <- value
    | ColorChooserWidgetProperty.Sensitive value -> widget.Sensitive <- value
    | ColorChooserWidgetProperty.AppPaintable value -> widget.AppPaintable <- value
    | ColorChooserWidgetProperty.CanFocus value -> widget.CanFocus <- value
    | ColorChooserWidgetProperty.HasFocus value -> widget.HasFocus <- value
    | ColorChooserWidgetProperty.IsFocus value -> widget.IsFocus <- value
    | ColorChooserWidgetProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ColorChooserWidgetProperty.CanDefault value -> widget.CanDefault <- value
    | ColorChooserWidgetProperty.HasDefault value -> widget.HasDefault <- value
    | ColorChooserWidgetProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ColorChooserWidgetProperty.Style value -> widget.Style <- value
    | ColorChooserWidgetProperty.Events value -> widget.Events <- value
    | ColorChooserWidgetProperty.NoShowAll value -> widget.NoShowAll <- value
    | ColorChooserWidgetProperty.HasTooltip value -> widget.HasTooltip <- value
    | ColorChooserWidgetProperty.TooltipText value -> widget.TooltipText <- value
    | ColorChooserWidgetProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ColorChooserWidgetProperty.Window value -> widget.Window <- value
    | ColorChooserWidgetProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ColorChooserWidgetProperty.Halign value -> widget.Halign <- value
    | ColorChooserWidgetProperty.Valign value -> widget.Valign <- value
    | ColorChooserWidgetProperty.MarginLeft value -> widget.MarginLeft <- value
    | ColorChooserWidgetProperty.MarginRight value -> widget.MarginRight <- value
    | ColorChooserWidgetProperty.MarginStart value -> widget.MarginStart <- value
    | ColorChooserWidgetProperty.MarginEnd value -> widget.MarginEnd <- value
    | ColorChooserWidgetProperty.MarginTop value -> widget.MarginTop <- value
    | ColorChooserWidgetProperty.MarginBottom value -> widget.MarginBottom <- value
    | ColorChooserWidgetProperty.Margin value -> widget.Margin <- value
    | ColorChooserWidgetProperty.Hexpand value -> widget.Hexpand <- value
    | ColorChooserWidgetProperty.HexpandSet value -> widget.HexpandSet <- value
    | ColorChooserWidgetProperty.Vexpand value -> widget.Vexpand <- value
    | ColorChooserWidgetProperty.VexpandSet value -> widget.VexpandSet <- value
    | ColorChooserWidgetProperty.Opacity value -> widget.Opacity <- value
    | ColorChooserWidgetProperty.OnColorActivated handler -> 
        let disposable = widget.ColorActivated.Subscribe(handler)
        registerListener widget "ColorActivated" disposable
    | ColorChooserWidgetProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ColorChooserWidgetProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ColorChooserWidgetProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ColorChooserWidgetProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ColorChooserWidgetProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ColorChooserWidgetProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ColorChooserWidgetProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ColorChooserWidgetProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ColorChooserWidgetProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ColorChooserWidgetProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ColorChooserWidgetProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ColorChooserWidgetProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ColorChooserWidgetProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ColorChooserWidgetProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ColorChooserWidgetProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ColorChooserWidgetProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ColorChooserWidgetProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ColorChooserWidgetProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ColorChooserWidgetProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ColorChooserWidgetProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ColorChooserWidgetProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ColorChooserWidgetProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ColorChooserWidgetProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ColorChooserWidgetProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ColorChooserWidgetProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ColorChooserWidgetProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ColorChooserWidgetProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ColorChooserWidgetProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ColorChooserWidgetProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ColorChooserWidgetProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ColorChooserWidgetProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ColorChooserWidgetProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ColorChooserWidgetProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ColorChooserWidgetProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ColorChooserWidgetProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ColorChooserWidgetProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ColorChooserWidgetProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ColorChooserWidgetProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ColorChooserWidgetProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ColorChooserWidgetProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ColorChooserWidgetProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ColorChooserWidgetProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ColorChooserWidgetProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ColorChooserWidgetProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ColorChooserWidgetProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ColorChooserWidgetProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ColorChooserWidgetProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ColorChooserWidgetProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ColorChooserWidgetProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ColorChooserWidgetProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ColorChooserWidgetProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ColorChooserWidgetProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ColorChooserWidgetProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ColorChooserWidgetProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ColorChooserWidgetProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ColorChooserWidgetProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ColorChooserWidgetProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ColorChooserWidgetProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ColorChooserWidgetProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ColorChooserWidgetProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ColorChooserWidgetPropertyBuilder() =
    inherit BasePropertyBuilder<ColorChooserWidgetProperty>()
    [<CustomOperation("showEditor")>]
    member this.ShowEditor(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.ShowEditor value } 
    [<CustomOperation("rgba")>]
    member this.Rgba(it: ColorChooserWidgetProperty seq, value: Gdk.RGBA) =
        seq { yield! it; yield ColorChooserWidgetProperty.Rgba value } 
    [<CustomOperation("useAlpha")>]
    member this.UseAlpha(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.UseAlpha value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ColorChooserWidgetProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ColorChooserWidgetProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ColorChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorChooserWidgetProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ColorChooserWidgetProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ColorChooserWidgetProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ColorChooserWidgetProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ColorChooserWidgetProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ColorChooserWidgetProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ColorChooserWidgetProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ColorChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorChooserWidgetProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ColorChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserWidgetProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ColorChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorChooserWidgetProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ColorChooserWidgetProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ColorChooserWidgetProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ColorChooserWidgetProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ColorChooserWidgetProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ColorChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserWidgetProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ColorChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserWidgetProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ColorChooserWidgetProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ColorChooserWidgetProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ColorChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorChooserWidgetProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ColorChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorChooserWidgetProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ColorChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserWidgetProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ColorChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserWidgetProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ColorChooserWidgetProperty seq, value: System.Double) =
        seq { yield! it; yield ColorChooserWidgetProperty.Opacity value } 
    [<CustomOperation("onColorActivated")>]
    member this.OnColorActivated(it: ColorChooserWidgetProperty seq, value: Gtk.ColorActivatedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnColorActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ColorChooserWidgetProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ColorChooserWidgetProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ColorChooserWidgetProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ColorChooserWidgetProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ColorChooserWidgetProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ColorChooserWidgetProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ColorChooserWidgetProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ColorChooserWidgetProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ColorChooserWidgetProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ColorChooserWidgetProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ColorChooserWidgetProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ColorChooserWidgetProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ColorChooserWidgetProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ColorChooserWidgetProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ColorChooserWidgetProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ColorChooserWidgetProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ColorChooserWidgetProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ColorChooserWidgetProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ColorChooserWidgetProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ColorChooserWidgetProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ColorChooserWidgetProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ColorChooserWidgetProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ColorChooserWidgetProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ColorChooserWidgetProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ColorChooserWidgetProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ColorChooserWidgetProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ColorChooserWidgetProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ColorChooserWidgetProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ColorChooserWidgetProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ColorChooserWidgetProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ColorChooserWidgetProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ColorChooserWidgetProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ColorChooserWidgetProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ColorChooserWidgetProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ColorChooserWidgetProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ColorChooserWidgetProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ColorChooserWidgetProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ColorChooserWidgetProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ColorChooserWidgetProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ColorChooserWidgetProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ColorChooserWidgetProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ColorChooserWidgetProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ColorChooserWidgetProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ColorChooserWidgetProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ColorChooserWidgetProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ColorChooserWidgetProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ColorChooserWidgetProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ColorChooserWidgetProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ColorChooserWidgetProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ColorChooserWidgetProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ColorChooserWidgetProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ColorChooserWidgetProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ColorChooserWidgetProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ColorChooserWidgetProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ColorChooserWidgetProperty.OnFocused value } 

let prop = ColorChooserWidgetPropertyBuilder()

type ColorChooserWidgetDescriptor(props) =
    inherit BaseWidgetDescriptor<ColorChooserWidget, ColorChooserWidgetProperty>(props, bindProperty)
    override this.CreateTyped() = new ColorChooserWidget()

let colorChooserWidget props = ColorChooserWidgetDescriptor(props)

