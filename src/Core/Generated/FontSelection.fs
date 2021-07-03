module Gtk.DSL.Binding.FontSelection
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FontSelectionProperty =
    | [<Obsolete>] FontName of System.String
    | [<Obsolete>] PreviewText of System.String
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

let bindProperty (widget: FontSelection) (prop: FontSelectionProperty) =
    match prop with
    | FontSelectionProperty.FontName value -> widget.FontName <- value
    | FontSelectionProperty.PreviewText value -> widget.PreviewText <- value
    | FontSelectionProperty.Spacing value -> widget.Spacing <- value
    | FontSelectionProperty.Homogeneous value -> widget.Homogeneous <- value
    | FontSelectionProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | FontSelectionProperty.Expand value -> widget.Expand <- value
    | FontSelectionProperty.Fill value -> widget.Fill <- value
    | FontSelectionProperty.Padding value -> widget.Padding <- value
    | FontSelectionProperty.PackType value -> widget.PackType <- value
    | FontSelectionProperty.Position value -> widget.Position <- value
    | FontSelectionProperty.Orientation value -> widget.Orientation <- value
    | FontSelectionProperty.ResizeMode value -> widget.ResizeMode <- value
    | FontSelectionProperty.BorderWidth value -> widget.BorderWidth <- value
    | FontSelectionProperty.Name value -> widget.Name <- value
    | FontSelectionProperty.Parent value -> widget.Parent <- value
    | FontSelectionProperty.WidthRequest value -> widget.WidthRequest <- value
    | FontSelectionProperty.HeightRequest value -> widget.HeightRequest <- value
    | FontSelectionProperty.Visible value -> widget.Visible <- value
    | FontSelectionProperty.Sensitive value -> widget.Sensitive <- value
    | FontSelectionProperty.AppPaintable value -> widget.AppPaintable <- value
    | FontSelectionProperty.CanFocus value -> widget.CanFocus <- value
    | FontSelectionProperty.HasFocus value -> widget.HasFocus <- value
    | FontSelectionProperty.IsFocus value -> widget.IsFocus <- value
    | FontSelectionProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FontSelectionProperty.CanDefault value -> widget.CanDefault <- value
    | FontSelectionProperty.HasDefault value -> widget.HasDefault <- value
    | FontSelectionProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FontSelectionProperty.Style value -> widget.Style <- value
    | FontSelectionProperty.Events value -> widget.Events <- value
    | FontSelectionProperty.NoShowAll value -> widget.NoShowAll <- value
    | FontSelectionProperty.HasTooltip value -> widget.HasTooltip <- value
    | FontSelectionProperty.TooltipText value -> widget.TooltipText <- value
    | FontSelectionProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FontSelectionProperty.Window value -> widget.Window <- value
    | FontSelectionProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FontSelectionProperty.Halign value -> widget.Halign <- value
    | FontSelectionProperty.Valign value -> widget.Valign <- value
    | FontSelectionProperty.MarginLeft value -> widget.MarginLeft <- value
    | FontSelectionProperty.MarginRight value -> widget.MarginRight <- value
    | FontSelectionProperty.MarginStart value -> widget.MarginStart <- value
    | FontSelectionProperty.MarginEnd value -> widget.MarginEnd <- value
    | FontSelectionProperty.MarginTop value -> widget.MarginTop <- value
    | FontSelectionProperty.MarginBottom value -> widget.MarginBottom <- value
    | FontSelectionProperty.Margin value -> widget.Margin <- value
    | FontSelectionProperty.Hexpand value -> widget.Hexpand <- value
    | FontSelectionProperty.HexpandSet value -> widget.HexpandSet <- value
    | FontSelectionProperty.Vexpand value -> widget.Vexpand <- value
    | FontSelectionProperty.VexpandSet value -> widget.VexpandSet <- value
    | FontSelectionProperty.Opacity value -> widget.Opacity <- value
    | FontSelectionProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FontSelectionProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FontSelectionProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FontSelectionProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FontSelectionProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FontSelectionProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FontSelectionProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FontSelectionProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FontSelectionProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FontSelectionProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FontSelectionProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FontSelectionProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FontSelectionProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FontSelectionProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FontSelectionProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FontSelectionProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FontSelectionProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FontSelectionProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FontSelectionProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FontSelectionProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FontSelectionProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FontSelectionProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FontSelectionProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FontSelectionProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FontSelectionProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FontSelectionProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FontSelectionProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FontSelectionProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FontSelectionProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FontSelectionProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FontSelectionProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FontSelectionProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FontSelectionProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FontSelectionProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FontSelectionProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FontSelectionProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FontSelectionProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FontSelectionProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FontSelectionProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FontSelectionProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FontSelectionProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FontSelectionProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FontSelectionProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FontSelectionProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FontSelectionProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FontSelectionProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FontSelectionProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FontSelectionProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FontSelectionProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FontSelectionProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FontSelectionProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FontSelectionProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FontSelectionProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FontSelectionProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FontSelectionProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FontSelectionProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FontSelectionProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FontSelectionProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FontSelectionProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FontSelectionProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FontSelectionPropertyBuilder() =
    inherit BasePropertyBuilder<FontSelectionProperty>()
    [<Obsolete>]
    [<CustomOperation("fontName")>]
    member this.FontName(it: FontSelectionProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionProperty.FontName value } 
    [<Obsolete>]
    [<CustomOperation("previewText")>]
    member this.PreviewText(it: FontSelectionProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionProperty.PreviewText value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: FontSelectionProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield FontSelectionProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: FontSelectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontSelectionProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: FontSelectionProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield FontSelectionProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: FontSelectionProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield FontSelectionProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FontSelectionProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FontSelectionProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FontSelectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontSelectionProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FontSelectionProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FontSelectionProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontSelectionProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FontSelectionProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FontSelectionProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FontSelectionProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FontSelectionProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FontSelectionProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FontSelectionProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FontSelectionProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FontSelectionProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FontSelectionProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontSelectionProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FontSelectionProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontSelectionProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FontSelectionProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FontSelectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FontSelectionProperty seq, value: System.Double) =
        seq { yield! it; yield FontSelectionProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FontSelectionProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FontSelectionProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FontSelectionProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FontSelectionProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FontSelectionProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FontSelectionProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FontSelectionProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FontSelectionProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FontSelectionProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FontSelectionProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FontSelectionProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FontSelectionProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FontSelectionProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FontSelectionProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FontSelectionProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FontSelectionProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FontSelectionProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FontSelectionProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FontSelectionProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FontSelectionProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FontSelectionProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FontSelectionProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FontSelectionProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FontSelectionProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FontSelectionProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FontSelectionProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FontSelectionProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FontSelectionProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FontSelectionProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FontSelectionProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FontSelectionProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FontSelectionProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FontSelectionProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FontSelectionProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FontSelectionProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FontSelectionProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FontSelectionProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FontSelectionProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FontSelectionProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FontSelectionProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FontSelectionProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FontSelectionProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FontSelectionProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FontSelectionProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FontSelectionProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FontSelectionProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FontSelectionProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FontSelectionProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FontSelectionProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FontSelectionProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FontSelectionProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FontSelectionProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FontSelectionProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FontSelectionProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FontSelectionProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FontSelectionProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FontSelectionProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FontSelectionProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FontSelectionProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FontSelectionProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FontSelectionProperty.OnFocused value } 

let prop = FontSelectionPropertyBuilder()

type FontSelectionDescriptor(props) =
    inherit BaseWidgetDescriptor<FontSelection, FontSelectionProperty>(props, bindProperty)
    override this.CreateTyped() = new FontSelection()

let fontSelection props = FontSelectionDescriptor(props)

