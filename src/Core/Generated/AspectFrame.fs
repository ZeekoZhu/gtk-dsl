module Gtk.DSL.Binding.AspectFrame
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AspectFrameProperty =
    | Xalign of System.Single
    | Yalign of System.Single
    | Ratio of System.Single
    | ObeyChild of System.Boolean
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

let bindProperty (widget: AspectFrame) (prop: AspectFrameProperty) =
    match prop with
    | AspectFrameProperty.Xalign value -> widget.Xalign <- value
    | AspectFrameProperty.Yalign value -> widget.Yalign <- value
    | AspectFrameProperty.Ratio value -> widget.Ratio <- value
    | AspectFrameProperty.ObeyChild value -> widget.ObeyChild <- value
    | AspectFrameProperty.Label value -> widget.Label <- value
    | AspectFrameProperty.LabelXalign value -> widget.LabelXalign <- value
    | AspectFrameProperty.LabelYalign value -> widget.LabelYalign <- value
    | AspectFrameProperty.ShadowType value -> widget.ShadowType <- value
    | AspectFrameProperty.LabelWidget value -> widget.LabelWidget <- value
    | AspectFrameProperty.ResizeMode value -> widget.ResizeMode <- value
    | AspectFrameProperty.BorderWidth value -> widget.BorderWidth <- value
    | AspectFrameProperty.Name value -> widget.Name <- value
    | AspectFrameProperty.Parent value -> widget.Parent <- value
    | AspectFrameProperty.WidthRequest value -> widget.WidthRequest <- value
    | AspectFrameProperty.HeightRequest value -> widget.HeightRequest <- value
    | AspectFrameProperty.Visible value -> widget.Visible <- value
    | AspectFrameProperty.Sensitive value -> widget.Sensitive <- value
    | AspectFrameProperty.AppPaintable value -> widget.AppPaintable <- value
    | AspectFrameProperty.CanFocus value -> widget.CanFocus <- value
    | AspectFrameProperty.HasFocus value -> widget.HasFocus <- value
    | AspectFrameProperty.IsFocus value -> widget.IsFocus <- value
    | AspectFrameProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AspectFrameProperty.CanDefault value -> widget.CanDefault <- value
    | AspectFrameProperty.HasDefault value -> widget.HasDefault <- value
    | AspectFrameProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AspectFrameProperty.Style value -> widget.Style <- value
    | AspectFrameProperty.Events value -> widget.Events <- value
    | AspectFrameProperty.NoShowAll value -> widget.NoShowAll <- value
    | AspectFrameProperty.HasTooltip value -> widget.HasTooltip <- value
    | AspectFrameProperty.TooltipText value -> widget.TooltipText <- value
    | AspectFrameProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AspectFrameProperty.Window value -> widget.Window <- value
    | AspectFrameProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AspectFrameProperty.Halign value -> widget.Halign <- value
    | AspectFrameProperty.Valign value -> widget.Valign <- value
    | AspectFrameProperty.MarginLeft value -> widget.MarginLeft <- value
    | AspectFrameProperty.MarginRight value -> widget.MarginRight <- value
    | AspectFrameProperty.MarginStart value -> widget.MarginStart <- value
    | AspectFrameProperty.MarginEnd value -> widget.MarginEnd <- value
    | AspectFrameProperty.MarginTop value -> widget.MarginTop <- value
    | AspectFrameProperty.MarginBottom value -> widget.MarginBottom <- value
    | AspectFrameProperty.Margin value -> widget.Margin <- value
    | AspectFrameProperty.Hexpand value -> widget.Hexpand <- value
    | AspectFrameProperty.HexpandSet value -> widget.HexpandSet <- value
    | AspectFrameProperty.Vexpand value -> widget.Vexpand <- value
    | AspectFrameProperty.VexpandSet value -> widget.VexpandSet <- value
    | AspectFrameProperty.Expand value -> widget.Expand <- value
    | AspectFrameProperty.Opacity value -> widget.Opacity <- value
    | AspectFrameProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | AspectFrameProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | AspectFrameProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | AspectFrameProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AspectFrameProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AspectFrameProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AspectFrameProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AspectFrameProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AspectFrameProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AspectFrameProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AspectFrameProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AspectFrameProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AspectFrameProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AspectFrameProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AspectFrameProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AspectFrameProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AspectFrameProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AspectFrameProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AspectFrameProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AspectFrameProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AspectFrameProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AspectFrameProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AspectFrameProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AspectFrameProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AspectFrameProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AspectFrameProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AspectFrameProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AspectFrameProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AspectFrameProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AspectFrameProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AspectFrameProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AspectFrameProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AspectFrameProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AspectFrameProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AspectFrameProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AspectFrameProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AspectFrameProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AspectFrameProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AspectFrameProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AspectFrameProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AspectFrameProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AspectFrameProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AspectFrameProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AspectFrameProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AspectFrameProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AspectFrameProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AspectFrameProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AspectFrameProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AspectFrameProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AspectFrameProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AspectFrameProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AspectFrameProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AspectFrameProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AspectFrameProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AspectFrameProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AspectFrameProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AspectFrameProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AspectFrameProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AspectFrameProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AspectFrameProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AspectFramePropertyBuilder() =
    inherit BasePropertyBuilder<AspectFrameProperty>()
    [<CustomOperation("xalign")>]
    member this.Xalign(it: AspectFrameProperty seq, value: System.Single) =
        seq { yield! it; yield AspectFrameProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: AspectFrameProperty seq, value: System.Single) =
        seq { yield! it; yield AspectFrameProperty.Yalign value } 
    [<CustomOperation("ratio")>]
    member this.Ratio(it: AspectFrameProperty seq, value: System.Single) =
        seq { yield! it; yield AspectFrameProperty.Ratio value } 
    [<CustomOperation("obeyChild")>]
    member this.ObeyChild(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.ObeyChild value } 
    [<CustomOperation("label")>]
    member this.Label(it: AspectFrameProperty seq, value: System.String) =
        seq { yield! it; yield AspectFrameProperty.Label value } 
    [<CustomOperation("labelXalign")>]
    member this.LabelXalign(it: AspectFrameProperty seq, value: System.Single) =
        seq { yield! it; yield AspectFrameProperty.LabelXalign value } 
    [<CustomOperation("labelYalign")>]
    member this.LabelYalign(it: AspectFrameProperty seq, value: System.Single) =
        seq { yield! it; yield AspectFrameProperty.LabelYalign value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: AspectFrameProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield AspectFrameProperty.ShadowType value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: AspectFrameProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AspectFrameProperty.LabelWidget value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: AspectFrameProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield AspectFrameProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: AspectFrameProperty seq, value: System.UInt32) =
        seq { yield! it; yield AspectFrameProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: AspectFrameProperty seq, value: System.String) =
        seq { yield! it; yield AspectFrameProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AspectFrameProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AspectFrameProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AspectFrameProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AspectFrameProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AspectFrameProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AspectFrameProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AspectFrameProperty seq, value: System.String) =
        seq { yield! it; yield AspectFrameProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AspectFrameProperty seq, value: System.String) =
        seq { yield! it; yield AspectFrameProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AspectFrameProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AspectFrameProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AspectFrameProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AspectFrameProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AspectFrameProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AspectFrameProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AspectFrameProperty seq, value: System.Int32) =
        seq { yield! it; yield AspectFrameProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AspectFrameProperty seq, value: System.Boolean) =
        seq { yield! it; yield AspectFrameProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AspectFrameProperty seq, value: System.Double) =
        seq { yield! it; yield AspectFrameProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: AspectFrameProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: AspectFrameProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: AspectFrameProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AspectFrameProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AspectFrameProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AspectFrameProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AspectFrameProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AspectFrameProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AspectFrameProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AspectFrameProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AspectFrameProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AspectFrameProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AspectFrameProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AspectFrameProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AspectFrameProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AspectFrameProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AspectFrameProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AspectFrameProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AspectFrameProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AspectFrameProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AspectFrameProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AspectFrameProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AspectFrameProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AspectFrameProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AspectFrameProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AspectFrameProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AspectFrameProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AspectFrameProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AspectFrameProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AspectFrameProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AspectFrameProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AspectFrameProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AspectFrameProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AspectFrameProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AspectFrameProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AspectFrameProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AspectFrameProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AspectFrameProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AspectFrameProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AspectFrameProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AspectFrameProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AspectFrameProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AspectFrameProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AspectFrameProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AspectFrameProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AspectFrameProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AspectFrameProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AspectFrameProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AspectFrameProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AspectFrameProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AspectFrameProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AspectFrameProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AspectFrameProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AspectFrameProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AspectFrameProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AspectFrameProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AspectFrameProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AspectFrameProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AspectFrameProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AspectFrameProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AspectFrameProperty.OnFocused value } 

let prop = AspectFramePropertyBuilder()

