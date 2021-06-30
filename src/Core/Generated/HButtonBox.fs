module GtkDsl.Binding.HButtonBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type HButtonBoxProperty =
    | LayoutStyle of Gtk.ButtonBoxStyle
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

let bindProperty (widget: HButtonBox) (prop: HButtonBoxProperty) =
    match prop with
    | HButtonBoxProperty.LayoutStyle value -> widget.LayoutStyle <- value
    | HButtonBoxProperty.Spacing value -> widget.Spacing <- value
    | HButtonBoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | HButtonBoxProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | HButtonBoxProperty.Expand value -> widget.Expand <- value
    | HButtonBoxProperty.Fill value -> widget.Fill <- value
    | HButtonBoxProperty.Padding value -> widget.Padding <- value
    | HButtonBoxProperty.PackType value -> widget.PackType <- value
    | HButtonBoxProperty.Position value -> widget.Position <- value
    | HButtonBoxProperty.Orientation value -> widget.Orientation <- value
    | HButtonBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | HButtonBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | HButtonBoxProperty.Name value -> widget.Name <- value
    | HButtonBoxProperty.Parent value -> widget.Parent <- value
    | HButtonBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | HButtonBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | HButtonBoxProperty.Visible value -> widget.Visible <- value
    | HButtonBoxProperty.Sensitive value -> widget.Sensitive <- value
    | HButtonBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | HButtonBoxProperty.CanFocus value -> widget.CanFocus <- value
    | HButtonBoxProperty.HasFocus value -> widget.HasFocus <- value
    | HButtonBoxProperty.IsFocus value -> widget.IsFocus <- value
    | HButtonBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | HButtonBoxProperty.CanDefault value -> widget.CanDefault <- value
    | HButtonBoxProperty.HasDefault value -> widget.HasDefault <- value
    | HButtonBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | HButtonBoxProperty.Style value -> widget.Style <- value
    | HButtonBoxProperty.Events value -> widget.Events <- value
    | HButtonBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | HButtonBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | HButtonBoxProperty.TooltipText value -> widget.TooltipText <- value
    | HButtonBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | HButtonBoxProperty.Window value -> widget.Window <- value
    | HButtonBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | HButtonBoxProperty.Halign value -> widget.Halign <- value
    | HButtonBoxProperty.Valign value -> widget.Valign <- value
    | HButtonBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | HButtonBoxProperty.MarginRight value -> widget.MarginRight <- value
    | HButtonBoxProperty.MarginStart value -> widget.MarginStart <- value
    | HButtonBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | HButtonBoxProperty.MarginTop value -> widget.MarginTop <- value
    | HButtonBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | HButtonBoxProperty.Margin value -> widget.Margin <- value
    | HButtonBoxProperty.Hexpand value -> widget.Hexpand <- value
    | HButtonBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | HButtonBoxProperty.Vexpand value -> widget.Vexpand <- value
    | HButtonBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | HButtonBoxProperty.Opacity value -> widget.Opacity <- value
    | HButtonBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | HButtonBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | HButtonBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | HButtonBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | HButtonBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | HButtonBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | HButtonBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | HButtonBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | HButtonBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | HButtonBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | HButtonBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | HButtonBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | HButtonBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | HButtonBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | HButtonBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | HButtonBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | HButtonBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | HButtonBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | HButtonBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | HButtonBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | HButtonBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | HButtonBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | HButtonBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | HButtonBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | HButtonBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | HButtonBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | HButtonBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | HButtonBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | HButtonBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | HButtonBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | HButtonBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | HButtonBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | HButtonBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | HButtonBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | HButtonBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | HButtonBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | HButtonBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | HButtonBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | HButtonBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | HButtonBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | HButtonBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | HButtonBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | HButtonBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | HButtonBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | HButtonBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | HButtonBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | HButtonBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | HButtonBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | HButtonBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | HButtonBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | HButtonBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | HButtonBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | HButtonBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | HButtonBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | HButtonBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | HButtonBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | HButtonBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | HButtonBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | HButtonBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | HButtonBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type HButtonBoxPropertyBuilder() =
    inherit BasePropertyBuilder<HButtonBoxProperty>()
    [<CustomOperation("layoutStyle")>]
    member this.LayoutStyle(it: HButtonBoxProperty seq, value: Gtk.ButtonBoxStyle) =
        seq { yield! it; yield HButtonBoxProperty.LayoutStyle value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: HButtonBoxProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield HButtonBoxProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: HButtonBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield HButtonBoxProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: HButtonBoxProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield HButtonBoxProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: HButtonBoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield HButtonBoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: HButtonBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield HButtonBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: HButtonBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield HButtonBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: HButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield HButtonBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: HButtonBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield HButtonBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: HButtonBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield HButtonBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: HButtonBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield HButtonBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: HButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield HButtonBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: HButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield HButtonBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: HButtonBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield HButtonBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: HButtonBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HButtonBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: HButtonBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield HButtonBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: HButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield HButtonBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: HButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield HButtonBoxProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: HButtonBoxProperty seq, value: System.Double) =
        seq { yield! it; yield HButtonBoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: HButtonBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: HButtonBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: HButtonBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: HButtonBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: HButtonBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: HButtonBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: HButtonBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: HButtonBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: HButtonBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: HButtonBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: HButtonBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: HButtonBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: HButtonBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: HButtonBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: HButtonBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: HButtonBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: HButtonBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: HButtonBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: HButtonBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: HButtonBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: HButtonBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: HButtonBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: HButtonBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: HButtonBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: HButtonBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: HButtonBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: HButtonBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: HButtonBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: HButtonBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: HButtonBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: HButtonBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: HButtonBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: HButtonBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: HButtonBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: HButtonBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: HButtonBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: HButtonBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: HButtonBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: HButtonBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: HButtonBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: HButtonBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: HButtonBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: HButtonBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: HButtonBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: HButtonBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: HButtonBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: HButtonBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: HButtonBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: HButtonBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: HButtonBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: HButtonBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: HButtonBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: HButtonBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: HButtonBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: HButtonBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: HButtonBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: HButtonBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: HButtonBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: HButtonBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: HButtonBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield HButtonBoxProperty.OnFocused value } 

let prop = HButtonBoxPropertyBuilder()

type HButtonBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<HButtonBox, HButtonBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new HButtonBox()

let hButtonBox props = HButtonBoxDescriptor(props)

