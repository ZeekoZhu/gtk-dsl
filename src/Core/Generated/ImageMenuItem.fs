module Gtk.DSL.Binding.ImageMenuItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ImageMenuItemProperty =
    | [<Obsolete>] Image of Gtk.Widget
    | [<Obsolete>] UseStock of System.Boolean
    | [<Obsolete>] AlwaysShowImage of System.Boolean
    | [<Obsolete>] RightJustified of System.Boolean
    | Submenu of Gtk.Widget
    | AccelPath of System.String
    | Label of System.String
    | UseUnderline of System.Boolean
    | [<Obsolete>] RelatedAction of Gtk.Action
    | [<Obsolete>] UseActionAppearance of System.Boolean
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
    |  OnToggleSizeAllocated of (Gtk.ToggleSizeAllocatedArgs -> unit)
    |  OnToggleSizeRequested of (Gtk.ToggleSizeRequestedArgs -> unit)
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

let bindProperty (widget: ImageMenuItem) (prop: ImageMenuItemProperty) =
    match prop with
    | ImageMenuItemProperty.Image value -> widget.Image <- value
    | ImageMenuItemProperty.UseStock value -> widget.UseStock <- value
    | ImageMenuItemProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | ImageMenuItemProperty.RightJustified value -> widget.RightJustified <- value
    | ImageMenuItemProperty.Submenu value -> widget.Submenu <- value
    | ImageMenuItemProperty.AccelPath value -> widget.AccelPath <- value
    | ImageMenuItemProperty.Label value -> widget.Label <- value
    | ImageMenuItemProperty.UseUnderline value -> widget.UseUnderline <- value
    | ImageMenuItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | ImageMenuItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ImageMenuItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | ImageMenuItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | ImageMenuItemProperty.Name value -> widget.Name <- value
    | ImageMenuItemProperty.Parent value -> widget.Parent <- value
    | ImageMenuItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | ImageMenuItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | ImageMenuItemProperty.Visible value -> widget.Visible <- value
    | ImageMenuItemProperty.Sensitive value -> widget.Sensitive <- value
    | ImageMenuItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | ImageMenuItemProperty.CanFocus value -> widget.CanFocus <- value
    | ImageMenuItemProperty.HasFocus value -> widget.HasFocus <- value
    | ImageMenuItemProperty.IsFocus value -> widget.IsFocus <- value
    | ImageMenuItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ImageMenuItemProperty.CanDefault value -> widget.CanDefault <- value
    | ImageMenuItemProperty.HasDefault value -> widget.HasDefault <- value
    | ImageMenuItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ImageMenuItemProperty.Style value -> widget.Style <- value
    | ImageMenuItemProperty.Events value -> widget.Events <- value
    | ImageMenuItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | ImageMenuItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | ImageMenuItemProperty.TooltipText value -> widget.TooltipText <- value
    | ImageMenuItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ImageMenuItemProperty.Window value -> widget.Window <- value
    | ImageMenuItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ImageMenuItemProperty.Halign value -> widget.Halign <- value
    | ImageMenuItemProperty.Valign value -> widget.Valign <- value
    | ImageMenuItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | ImageMenuItemProperty.MarginRight value -> widget.MarginRight <- value
    | ImageMenuItemProperty.MarginStart value -> widget.MarginStart <- value
    | ImageMenuItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | ImageMenuItemProperty.MarginTop value -> widget.MarginTop <- value
    | ImageMenuItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | ImageMenuItemProperty.Margin value -> widget.Margin <- value
    | ImageMenuItemProperty.Hexpand value -> widget.Hexpand <- value
    | ImageMenuItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | ImageMenuItemProperty.Vexpand value -> widget.Vexpand <- value
    | ImageMenuItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | ImageMenuItemProperty.Expand value -> widget.Expand <- value
    | ImageMenuItemProperty.Opacity value -> widget.Opacity <- value
    | ImageMenuItemProperty.OnToggleSizeAllocated handler -> 
        let disposable = widget.ToggleSizeAllocated.Subscribe(handler)
        registerListener widget "ToggleSizeAllocated" disposable
    | ImageMenuItemProperty.OnToggleSizeRequested handler -> 
        let disposable = widget.ToggleSizeRequested.Subscribe(handler)
        registerListener widget "ToggleSizeRequested" disposable
    | ImageMenuItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ImageMenuItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ImageMenuItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ImageMenuItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ImageMenuItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ImageMenuItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ImageMenuItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ImageMenuItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ImageMenuItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ImageMenuItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ImageMenuItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ImageMenuItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ImageMenuItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ImageMenuItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ImageMenuItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ImageMenuItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ImageMenuItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ImageMenuItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ImageMenuItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ImageMenuItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ImageMenuItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ImageMenuItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ImageMenuItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ImageMenuItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ImageMenuItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ImageMenuItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ImageMenuItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ImageMenuItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ImageMenuItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ImageMenuItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ImageMenuItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ImageMenuItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ImageMenuItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ImageMenuItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ImageMenuItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ImageMenuItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ImageMenuItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ImageMenuItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ImageMenuItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ImageMenuItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ImageMenuItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ImageMenuItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ImageMenuItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ImageMenuItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ImageMenuItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ImageMenuItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ImageMenuItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ImageMenuItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ImageMenuItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ImageMenuItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ImageMenuItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ImageMenuItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ImageMenuItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ImageMenuItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ImageMenuItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ImageMenuItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ImageMenuItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ImageMenuItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ImageMenuItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ImageMenuItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ImageMenuItemPropertyBuilder() =
    inherit BasePropertyBuilder<ImageMenuItemProperty>()
    [<Obsolete>]
    [<CustomOperation("image")>]
    member this.Image(it: ImageMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ImageMenuItemProperty.Image value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.UseStock value } 
    [<Obsolete>]
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("rightJustified")>]
    member this.RightJustified(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.RightJustified value } 
    [<CustomOperation("submenu")>]
    member this.Submenu(it: ImageMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ImageMenuItemProperty.Submenu value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: ImageMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield ImageMenuItemProperty.AccelPath value } 
    [<CustomOperation("label")>]
    member this.Label(it: ImageMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield ImageMenuItemProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ImageMenuItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ImageMenuItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ImageMenuItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ImageMenuItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ImageMenuItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield ImageMenuItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ImageMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield ImageMenuItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ImageMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ImageMenuItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ImageMenuItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ImageMenuItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ImageMenuItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ImageMenuItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ImageMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield ImageMenuItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ImageMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield ImageMenuItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ImageMenuItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ImageMenuItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ImageMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ImageMenuItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ImageMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ImageMenuItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ImageMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ImageMenuItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ImageMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ImageMenuItemProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ImageMenuItemProperty seq, value: System.Double) =
        seq { yield! it; yield ImageMenuItemProperty.Opacity value } 
    [<CustomOperation("onToggleSizeAllocated")>]
    member this.OnToggleSizeAllocated(it: ImageMenuItemProperty seq, value: Gtk.ToggleSizeAllocatedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnToggleSizeAllocated value } 
    [<CustomOperation("onToggleSizeRequested")>]
    member this.OnToggleSizeRequested(it: ImageMenuItemProperty seq, value: Gtk.ToggleSizeRequestedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnToggleSizeRequested value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ImageMenuItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ImageMenuItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ImageMenuItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ImageMenuItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ImageMenuItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ImageMenuItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ImageMenuItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ImageMenuItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ImageMenuItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ImageMenuItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ImageMenuItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ImageMenuItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ImageMenuItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ImageMenuItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ImageMenuItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ImageMenuItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ImageMenuItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ImageMenuItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ImageMenuItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ImageMenuItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ImageMenuItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ImageMenuItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ImageMenuItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ImageMenuItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ImageMenuItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ImageMenuItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ImageMenuItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ImageMenuItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ImageMenuItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ImageMenuItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ImageMenuItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ImageMenuItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ImageMenuItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ImageMenuItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ImageMenuItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ImageMenuItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ImageMenuItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ImageMenuItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ImageMenuItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ImageMenuItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ImageMenuItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ImageMenuItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ImageMenuItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ImageMenuItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ImageMenuItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ImageMenuItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ImageMenuItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ImageMenuItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ImageMenuItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ImageMenuItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ImageMenuItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ImageMenuItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ImageMenuItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ImageMenuItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ImageMenuItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ImageMenuItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ImageMenuItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ImageMenuItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ImageMenuItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ImageMenuItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ImageMenuItemProperty.OnFocused value } 

let prop = ImageMenuItemPropertyBuilder()

type ImageMenuItemDescriptor(props) =
    inherit BaseWidgetDescriptor<ImageMenuItem, ImageMenuItemProperty>(props, bindProperty)
    override this.CreateTyped() = new ImageMenuItem()

let imageMenuItem props = ImageMenuItemDescriptor(props)

