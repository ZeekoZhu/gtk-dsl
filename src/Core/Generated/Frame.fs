module GtkDsl.Binding.Frame
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FrameProperty =
    | Label of System.String
    | LabelXalign of System.Single
    | LabelYalign of System.Single
    | ShadowType of Gtk.ShadowType
    | LabelWidget of Gtk.Widget
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

let bindProperty (widget: Frame) (prop: FrameProperty) =
    match prop with
    | FrameProperty.Label value -> widget.Label <- value
    | FrameProperty.LabelXalign value -> widget.LabelXalign <- value
    | FrameProperty.LabelYalign value -> widget.LabelYalign <- value
    | FrameProperty.ShadowType value -> widget.ShadowType <- value
    | FrameProperty.LabelWidget value -> widget.LabelWidget <- value
    | FrameProperty.ResizeMode value -> widget.ResizeMode <- value
    | FrameProperty.BorderWidth value -> widget.BorderWidth <- value
    | FrameProperty.Name value -> widget.Name <- value
    | FrameProperty.Parent value -> widget.Parent <- value
    | FrameProperty.WidthRequest value -> widget.WidthRequest <- value
    | FrameProperty.HeightRequest value -> widget.HeightRequest <- value
    | FrameProperty.Visible value -> widget.Visible <- value
    | FrameProperty.Sensitive value -> widget.Sensitive <- value
    | FrameProperty.AppPaintable value -> widget.AppPaintable <- value
    | FrameProperty.CanFocus value -> widget.CanFocus <- value
    | FrameProperty.HasFocus value -> widget.HasFocus <- value
    | FrameProperty.IsFocus value -> widget.IsFocus <- value
    | FrameProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FrameProperty.CanDefault value -> widget.CanDefault <- value
    | FrameProperty.HasDefault value -> widget.HasDefault <- value
    | FrameProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FrameProperty.Style value -> widget.Style <- value
    | FrameProperty.Events value -> widget.Events <- value
    | FrameProperty.NoShowAll value -> widget.NoShowAll <- value
    | FrameProperty.HasTooltip value -> widget.HasTooltip <- value
    | FrameProperty.TooltipText value -> widget.TooltipText <- value
    | FrameProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FrameProperty.Window value -> widget.Window <- value
    | FrameProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FrameProperty.Halign value -> widget.Halign <- value
    | FrameProperty.Valign value -> widget.Valign <- value
    | FrameProperty.MarginLeft value -> widget.MarginLeft <- value
    | FrameProperty.MarginRight value -> widget.MarginRight <- value
    | FrameProperty.MarginStart value -> widget.MarginStart <- value
    | FrameProperty.MarginEnd value -> widget.MarginEnd <- value
    | FrameProperty.MarginTop value -> widget.MarginTop <- value
    | FrameProperty.MarginBottom value -> widget.MarginBottom <- value
    | FrameProperty.Margin value -> widget.Margin <- value
    | FrameProperty.Hexpand value -> widget.Hexpand <- value
    | FrameProperty.HexpandSet value -> widget.HexpandSet <- value
    | FrameProperty.Vexpand value -> widget.Vexpand <- value
    | FrameProperty.VexpandSet value -> widget.VexpandSet <- value
    | FrameProperty.Expand value -> widget.Expand <- value
    | FrameProperty.Opacity value -> widget.Opacity <- value
    | FrameProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FrameProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FrameProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FrameProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FrameProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FrameProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FrameProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FrameProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FrameProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FrameProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FrameProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FrameProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FrameProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FrameProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FrameProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FrameProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FrameProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FrameProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FrameProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FrameProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FrameProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FrameProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FrameProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FrameProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FrameProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FrameProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FrameProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FrameProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FrameProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FrameProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FrameProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FrameProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FrameProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FrameProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FrameProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FrameProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FrameProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FrameProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FrameProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FrameProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FrameProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FrameProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FrameProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FrameProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FrameProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FrameProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FrameProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FrameProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FrameProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FrameProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FrameProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FrameProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FrameProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FrameProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FrameProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FrameProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FrameProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FrameProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FrameProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FrameProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FramePropertyBuilder() =
    inherit BasePropertyBuilder<FrameProperty>()
    [<CustomOperation("label")>]
    member this.Label(it: FrameProperty seq, value: System.String) =
        seq { yield! it; yield FrameProperty.Label value } 
    [<CustomOperation("labelXalign")>]
    member this.LabelXalign(it: FrameProperty seq, value: System.Single) =
        seq { yield! it; yield FrameProperty.LabelXalign value } 
    [<CustomOperation("labelYalign")>]
    member this.LabelYalign(it: FrameProperty seq, value: System.Single) =
        seq { yield! it; yield FrameProperty.LabelYalign value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: FrameProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield FrameProperty.ShadowType value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: FrameProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FrameProperty.LabelWidget value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FrameProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FrameProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FrameProperty seq, value: System.UInt32) =
        seq { yield! it; yield FrameProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FrameProperty seq, value: System.String) =
        seq { yield! it; yield FrameProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FrameProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FrameProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FrameProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FrameProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FrameProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FrameProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FrameProperty seq, value: System.String) =
        seq { yield! it; yield FrameProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FrameProperty seq, value: System.String) =
        seq { yield! it; yield FrameProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FrameProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FrameProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FrameProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FrameProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FrameProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FrameProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FrameProperty seq, value: System.Int32) =
        seq { yield! it; yield FrameProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield FrameProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FrameProperty seq, value: System.Double) =
        seq { yield! it; yield FrameProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FrameProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FrameProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FrameProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FrameProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FrameProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FrameProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FrameProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FrameProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FrameProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FrameProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FrameProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FrameProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FrameProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FrameProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FrameProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FrameProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FrameProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FrameProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FrameProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FrameProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FrameProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FrameProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FrameProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FrameProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FrameProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FrameProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FrameProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FrameProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FrameProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FrameProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FrameProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FrameProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FrameProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FrameProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FrameProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FrameProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FrameProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FrameProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FrameProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FrameProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FrameProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FrameProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FrameProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FrameProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FrameProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FrameProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FrameProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FrameProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FrameProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FrameProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FrameProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FrameProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FrameProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FrameProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FrameProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FrameProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FrameProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FrameProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FrameProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FrameProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FrameProperty.OnFocused value } 

let prop = FramePropertyBuilder()

type FrameDescriptor(props) =
    inherit BaseWidgetDescriptor<Frame, FrameProperty>(props, bindProperty)
    override this.CreateTyped() = new Frame()

let frame props = FrameDescriptor(props)

