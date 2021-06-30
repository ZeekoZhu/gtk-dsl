module GtkDsl.Binding.VButtonBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VButtonBoxProperty =
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

let bindProperty (widget: VButtonBox) (prop: VButtonBoxProperty) =
    match prop with
    | VButtonBoxProperty.LayoutStyle value -> widget.LayoutStyle <- value
    | VButtonBoxProperty.Spacing value -> widget.Spacing <- value
    | VButtonBoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | VButtonBoxProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | VButtonBoxProperty.Expand value -> widget.Expand <- value
    | VButtonBoxProperty.Fill value -> widget.Fill <- value
    | VButtonBoxProperty.Padding value -> widget.Padding <- value
    | VButtonBoxProperty.PackType value -> widget.PackType <- value
    | VButtonBoxProperty.Position value -> widget.Position <- value
    | VButtonBoxProperty.Orientation value -> widget.Orientation <- value
    | VButtonBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | VButtonBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | VButtonBoxProperty.Name value -> widget.Name <- value
    | VButtonBoxProperty.Parent value -> widget.Parent <- value
    | VButtonBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | VButtonBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | VButtonBoxProperty.Visible value -> widget.Visible <- value
    | VButtonBoxProperty.Sensitive value -> widget.Sensitive <- value
    | VButtonBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | VButtonBoxProperty.CanFocus value -> widget.CanFocus <- value
    | VButtonBoxProperty.HasFocus value -> widget.HasFocus <- value
    | VButtonBoxProperty.IsFocus value -> widget.IsFocus <- value
    | VButtonBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VButtonBoxProperty.CanDefault value -> widget.CanDefault <- value
    | VButtonBoxProperty.HasDefault value -> widget.HasDefault <- value
    | VButtonBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VButtonBoxProperty.Style value -> widget.Style <- value
    | VButtonBoxProperty.Events value -> widget.Events <- value
    | VButtonBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | VButtonBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | VButtonBoxProperty.TooltipText value -> widget.TooltipText <- value
    | VButtonBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VButtonBoxProperty.Window value -> widget.Window <- value
    | VButtonBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VButtonBoxProperty.Halign value -> widget.Halign <- value
    | VButtonBoxProperty.Valign value -> widget.Valign <- value
    | VButtonBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | VButtonBoxProperty.MarginRight value -> widget.MarginRight <- value
    | VButtonBoxProperty.MarginStart value -> widget.MarginStart <- value
    | VButtonBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | VButtonBoxProperty.MarginTop value -> widget.MarginTop <- value
    | VButtonBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | VButtonBoxProperty.Margin value -> widget.Margin <- value
    | VButtonBoxProperty.Hexpand value -> widget.Hexpand <- value
    | VButtonBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | VButtonBoxProperty.Vexpand value -> widget.Vexpand <- value
    | VButtonBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | VButtonBoxProperty.Opacity value -> widget.Opacity <- value
    | VButtonBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | VButtonBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | VButtonBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | VButtonBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VButtonBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VButtonBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VButtonBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VButtonBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VButtonBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VButtonBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VButtonBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VButtonBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VButtonBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VButtonBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VButtonBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VButtonBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VButtonBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VButtonBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VButtonBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VButtonBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VButtonBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VButtonBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VButtonBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VButtonBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VButtonBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VButtonBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VButtonBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VButtonBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VButtonBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VButtonBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VButtonBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VButtonBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VButtonBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VButtonBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VButtonBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VButtonBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VButtonBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VButtonBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VButtonBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VButtonBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VButtonBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VButtonBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VButtonBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VButtonBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VButtonBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VButtonBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VButtonBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VButtonBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VButtonBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VButtonBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VButtonBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VButtonBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VButtonBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VButtonBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VButtonBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VButtonBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VButtonBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VButtonBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VButtonBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VButtonBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VButtonBoxPropertyBuilder() =
    inherit BasePropertyBuilder<VButtonBoxProperty>()
    [<CustomOperation("layoutStyle")>]
    member this.LayoutStyle(it: VButtonBoxProperty seq, value: Gtk.ButtonBoxStyle) =
        seq { yield! it; yield VButtonBoxProperty.LayoutStyle value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: VButtonBoxProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield VButtonBoxProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: VButtonBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield VButtonBoxProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: VButtonBoxProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield VButtonBoxProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: VButtonBoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield VButtonBoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: VButtonBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield VButtonBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: VButtonBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield VButtonBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: VButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield VButtonBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VButtonBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VButtonBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VButtonBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VButtonBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VButtonBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VButtonBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield VButtonBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VButtonBoxProperty seq, value: System.String) =
        seq { yield! it; yield VButtonBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VButtonBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VButtonBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VButtonBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VButtonBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VButtonBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VButtonBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VButtonBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield VButtonBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VButtonBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield VButtonBoxProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VButtonBoxProperty seq, value: System.Double) =
        seq { yield! it; yield VButtonBoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: VButtonBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: VButtonBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: VButtonBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VButtonBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VButtonBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VButtonBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VButtonBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VButtonBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VButtonBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VButtonBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VButtonBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VButtonBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VButtonBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VButtonBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VButtonBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VButtonBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VButtonBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VButtonBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VButtonBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VButtonBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VButtonBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VButtonBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VButtonBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VButtonBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VButtonBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VButtonBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VButtonBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VButtonBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VButtonBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VButtonBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VButtonBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VButtonBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VButtonBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VButtonBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VButtonBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VButtonBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VButtonBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VButtonBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VButtonBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VButtonBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VButtonBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VButtonBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VButtonBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VButtonBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VButtonBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VButtonBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VButtonBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VButtonBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VButtonBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VButtonBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VButtonBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VButtonBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VButtonBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VButtonBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VButtonBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VButtonBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VButtonBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VButtonBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VButtonBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VButtonBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VButtonBoxProperty.OnFocused value } 

let prop = VButtonBoxPropertyBuilder()

type VButtonBoxDescriptor(props) =
    inherit BaseWidgetDescriptor<VButtonBox, VButtonBoxProperty>(props, bindProperty)
    override this.CreateTyped() = new VButtonBox()

let vButtonBox props = VButtonBoxDescriptor(props)

