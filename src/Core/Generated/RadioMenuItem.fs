module Gtk.DSL.Binding.RadioMenuItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RadioMenuItemProperty =
    | Group of Gtk.RadioMenuItem[]
    | Active of System.Boolean
    | Inconsistent of System.Boolean
    | DrawAsRadio of System.Boolean
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

let bindProperty (widget: RadioMenuItem) (prop: RadioMenuItemProperty) =
    match prop with
    | RadioMenuItemProperty.Group value -> widget.Group <- value
    | RadioMenuItemProperty.Active value -> widget.Active <- value
    | RadioMenuItemProperty.Inconsistent value -> widget.Inconsistent <- value
    | RadioMenuItemProperty.DrawAsRadio value -> widget.DrawAsRadio <- value
    | RadioMenuItemProperty.RightJustified value -> widget.RightJustified <- value
    | RadioMenuItemProperty.Submenu value -> widget.Submenu <- value
    | RadioMenuItemProperty.AccelPath value -> widget.AccelPath <- value
    | RadioMenuItemProperty.Label value -> widget.Label <- value
    | RadioMenuItemProperty.UseUnderline value -> widget.UseUnderline <- value
    | RadioMenuItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | RadioMenuItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | RadioMenuItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | RadioMenuItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | RadioMenuItemProperty.Name value -> widget.Name <- value
    | RadioMenuItemProperty.Parent value -> widget.Parent <- value
    | RadioMenuItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | RadioMenuItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | RadioMenuItemProperty.Visible value -> widget.Visible <- value
    | RadioMenuItemProperty.Sensitive value -> widget.Sensitive <- value
    | RadioMenuItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | RadioMenuItemProperty.CanFocus value -> widget.CanFocus <- value
    | RadioMenuItemProperty.HasFocus value -> widget.HasFocus <- value
    | RadioMenuItemProperty.IsFocus value -> widget.IsFocus <- value
    | RadioMenuItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RadioMenuItemProperty.CanDefault value -> widget.CanDefault <- value
    | RadioMenuItemProperty.HasDefault value -> widget.HasDefault <- value
    | RadioMenuItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RadioMenuItemProperty.Style value -> widget.Style <- value
    | RadioMenuItemProperty.Events value -> widget.Events <- value
    | RadioMenuItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | RadioMenuItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | RadioMenuItemProperty.TooltipText value -> widget.TooltipText <- value
    | RadioMenuItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RadioMenuItemProperty.Window value -> widget.Window <- value
    | RadioMenuItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RadioMenuItemProperty.Halign value -> widget.Halign <- value
    | RadioMenuItemProperty.Valign value -> widget.Valign <- value
    | RadioMenuItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | RadioMenuItemProperty.MarginRight value -> widget.MarginRight <- value
    | RadioMenuItemProperty.MarginStart value -> widget.MarginStart <- value
    | RadioMenuItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | RadioMenuItemProperty.MarginTop value -> widget.MarginTop <- value
    | RadioMenuItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | RadioMenuItemProperty.Margin value -> widget.Margin <- value
    | RadioMenuItemProperty.Hexpand value -> widget.Hexpand <- value
    | RadioMenuItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | RadioMenuItemProperty.Vexpand value -> widget.Vexpand <- value
    | RadioMenuItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | RadioMenuItemProperty.Expand value -> widget.Expand <- value
    | RadioMenuItemProperty.Opacity value -> widget.Opacity <- value
    | RadioMenuItemProperty.OnToggleSizeAllocated handler -> 
        let disposable = widget.ToggleSizeAllocated.Subscribe(handler)
        registerListener widget "ToggleSizeAllocated" disposable
    | RadioMenuItemProperty.OnToggleSizeRequested handler -> 
        let disposable = widget.ToggleSizeRequested.Subscribe(handler)
        registerListener widget "ToggleSizeRequested" disposable
    | RadioMenuItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RadioMenuItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RadioMenuItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RadioMenuItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RadioMenuItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RadioMenuItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RadioMenuItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RadioMenuItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RadioMenuItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RadioMenuItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RadioMenuItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RadioMenuItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RadioMenuItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RadioMenuItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RadioMenuItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RadioMenuItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RadioMenuItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RadioMenuItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RadioMenuItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RadioMenuItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RadioMenuItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RadioMenuItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RadioMenuItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RadioMenuItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RadioMenuItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RadioMenuItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RadioMenuItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RadioMenuItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RadioMenuItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RadioMenuItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RadioMenuItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RadioMenuItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RadioMenuItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RadioMenuItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RadioMenuItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RadioMenuItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RadioMenuItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RadioMenuItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RadioMenuItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RadioMenuItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RadioMenuItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RadioMenuItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RadioMenuItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RadioMenuItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RadioMenuItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RadioMenuItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RadioMenuItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RadioMenuItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RadioMenuItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RadioMenuItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RadioMenuItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RadioMenuItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RadioMenuItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RadioMenuItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RadioMenuItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RadioMenuItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RadioMenuItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RadioMenuItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RadioMenuItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RadioMenuItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RadioMenuItemPropertyBuilder() =
    inherit BasePropertyBuilder<RadioMenuItemProperty>()
    [<CustomOperation("group")>]
    member this.Group(it: RadioMenuItemProperty seq, value: Gtk.RadioMenuItem[]) =
        seq { yield! it; yield RadioMenuItemProperty.Group value } 
    [<CustomOperation("active")>]
    member this.Active(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Active value } 
    [<CustomOperation("inconsistent")>]
    member this.Inconsistent(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Inconsistent value } 
    [<CustomOperation("drawAsRadio")>]
    member this.DrawAsRadio(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.DrawAsRadio value } 
    [<Obsolete>]
    [<CustomOperation("rightJustified")>]
    member this.RightJustified(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.RightJustified value } 
    [<CustomOperation("submenu")>]
    member this.Submenu(it: RadioMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioMenuItemProperty.Submenu value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: RadioMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield RadioMenuItemProperty.AccelPath value } 
    [<CustomOperation("label")>]
    member this.Label(it: RadioMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield RadioMenuItemProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: RadioMenuItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield RadioMenuItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RadioMenuItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RadioMenuItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RadioMenuItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield RadioMenuItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RadioMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield RadioMenuItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RadioMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioMenuItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RadioMenuItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RadioMenuItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RadioMenuItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RadioMenuItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RadioMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield RadioMenuItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RadioMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield RadioMenuItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RadioMenuItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RadioMenuItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RadioMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RadioMenuItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RadioMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RadioMenuItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RadioMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioMenuItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RadioMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioMenuItemProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RadioMenuItemProperty seq, value: System.Double) =
        seq { yield! it; yield RadioMenuItemProperty.Opacity value } 
    [<CustomOperation("onToggleSizeAllocated")>]
    member this.OnToggleSizeAllocated(it: RadioMenuItemProperty seq, value: Gtk.ToggleSizeAllocatedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnToggleSizeAllocated value } 
    [<CustomOperation("onToggleSizeRequested")>]
    member this.OnToggleSizeRequested(it: RadioMenuItemProperty seq, value: Gtk.ToggleSizeRequestedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnToggleSizeRequested value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RadioMenuItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RadioMenuItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RadioMenuItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RadioMenuItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RadioMenuItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RadioMenuItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RadioMenuItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RadioMenuItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RadioMenuItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RadioMenuItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RadioMenuItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RadioMenuItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RadioMenuItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RadioMenuItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RadioMenuItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RadioMenuItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RadioMenuItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RadioMenuItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RadioMenuItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RadioMenuItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RadioMenuItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RadioMenuItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RadioMenuItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RadioMenuItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RadioMenuItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RadioMenuItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RadioMenuItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RadioMenuItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RadioMenuItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RadioMenuItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RadioMenuItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RadioMenuItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RadioMenuItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RadioMenuItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RadioMenuItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RadioMenuItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RadioMenuItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RadioMenuItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RadioMenuItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RadioMenuItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RadioMenuItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RadioMenuItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RadioMenuItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RadioMenuItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RadioMenuItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RadioMenuItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RadioMenuItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RadioMenuItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RadioMenuItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RadioMenuItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RadioMenuItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RadioMenuItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RadioMenuItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RadioMenuItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RadioMenuItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RadioMenuItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RadioMenuItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RadioMenuItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RadioMenuItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RadioMenuItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RadioMenuItemProperty.OnFocused value } 

let prop = RadioMenuItemPropertyBuilder()

