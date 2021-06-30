module GtkDsl.Binding.CheckMenuItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type CheckMenuItemProperty =
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

let bindProperty (widget: CheckMenuItem) (prop: CheckMenuItemProperty) =
    match prop with
    | CheckMenuItemProperty.Active value -> widget.Active <- value
    | CheckMenuItemProperty.Inconsistent value -> widget.Inconsistent <- value
    | CheckMenuItemProperty.DrawAsRadio value -> widget.DrawAsRadio <- value
    | CheckMenuItemProperty.RightJustified value -> widget.RightJustified <- value
    | CheckMenuItemProperty.Submenu value -> widget.Submenu <- value
    | CheckMenuItemProperty.AccelPath value -> widget.AccelPath <- value
    | CheckMenuItemProperty.Label value -> widget.Label <- value
    | CheckMenuItemProperty.UseUnderline value -> widget.UseUnderline <- value
    | CheckMenuItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | CheckMenuItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | CheckMenuItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | CheckMenuItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | CheckMenuItemProperty.Name value -> widget.Name <- value
    | CheckMenuItemProperty.Parent value -> widget.Parent <- value
    | CheckMenuItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | CheckMenuItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | CheckMenuItemProperty.Visible value -> widget.Visible <- value
    | CheckMenuItemProperty.Sensitive value -> widget.Sensitive <- value
    | CheckMenuItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | CheckMenuItemProperty.CanFocus value -> widget.CanFocus <- value
    | CheckMenuItemProperty.HasFocus value -> widget.HasFocus <- value
    | CheckMenuItemProperty.IsFocus value -> widget.IsFocus <- value
    | CheckMenuItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | CheckMenuItemProperty.CanDefault value -> widget.CanDefault <- value
    | CheckMenuItemProperty.HasDefault value -> widget.HasDefault <- value
    | CheckMenuItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | CheckMenuItemProperty.Style value -> widget.Style <- value
    | CheckMenuItemProperty.Events value -> widget.Events <- value
    | CheckMenuItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | CheckMenuItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | CheckMenuItemProperty.TooltipText value -> widget.TooltipText <- value
    | CheckMenuItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | CheckMenuItemProperty.Window value -> widget.Window <- value
    | CheckMenuItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | CheckMenuItemProperty.Halign value -> widget.Halign <- value
    | CheckMenuItemProperty.Valign value -> widget.Valign <- value
    | CheckMenuItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | CheckMenuItemProperty.MarginRight value -> widget.MarginRight <- value
    | CheckMenuItemProperty.MarginStart value -> widget.MarginStart <- value
    | CheckMenuItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | CheckMenuItemProperty.MarginTop value -> widget.MarginTop <- value
    | CheckMenuItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | CheckMenuItemProperty.Margin value -> widget.Margin <- value
    | CheckMenuItemProperty.Hexpand value -> widget.Hexpand <- value
    | CheckMenuItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | CheckMenuItemProperty.Vexpand value -> widget.Vexpand <- value
    | CheckMenuItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | CheckMenuItemProperty.Expand value -> widget.Expand <- value
    | CheckMenuItemProperty.Opacity value -> widget.Opacity <- value
    | CheckMenuItemProperty.OnToggleSizeAllocated handler -> 
        let disposable = widget.ToggleSizeAllocated.Subscribe(handler)
        registerListener widget "ToggleSizeAllocated" disposable
    | CheckMenuItemProperty.OnToggleSizeRequested handler -> 
        let disposable = widget.ToggleSizeRequested.Subscribe(handler)
        registerListener widget "ToggleSizeRequested" disposable
    | CheckMenuItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | CheckMenuItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | CheckMenuItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | CheckMenuItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | CheckMenuItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | CheckMenuItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | CheckMenuItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | CheckMenuItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | CheckMenuItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | CheckMenuItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | CheckMenuItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | CheckMenuItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | CheckMenuItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | CheckMenuItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | CheckMenuItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | CheckMenuItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | CheckMenuItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | CheckMenuItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | CheckMenuItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | CheckMenuItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | CheckMenuItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | CheckMenuItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | CheckMenuItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | CheckMenuItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | CheckMenuItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | CheckMenuItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | CheckMenuItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | CheckMenuItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | CheckMenuItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | CheckMenuItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | CheckMenuItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | CheckMenuItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | CheckMenuItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | CheckMenuItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | CheckMenuItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | CheckMenuItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | CheckMenuItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | CheckMenuItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | CheckMenuItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | CheckMenuItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | CheckMenuItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | CheckMenuItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | CheckMenuItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | CheckMenuItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | CheckMenuItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | CheckMenuItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | CheckMenuItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | CheckMenuItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | CheckMenuItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | CheckMenuItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | CheckMenuItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | CheckMenuItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | CheckMenuItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | CheckMenuItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | CheckMenuItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | CheckMenuItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | CheckMenuItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | CheckMenuItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | CheckMenuItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | CheckMenuItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type CheckMenuItemPropertyBuilder() =
    inherit BasePropertyBuilder<CheckMenuItemProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Active value } 
    [<CustomOperation("inconsistent")>]
    member this.Inconsistent(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Inconsistent value } 
    [<CustomOperation("drawAsRadio")>]
    member this.DrawAsRadio(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.DrawAsRadio value } 
    [<Obsolete>]
    [<CustomOperation("rightJustified")>]
    member this.RightJustified(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.RightJustified value } 
    [<CustomOperation("submenu")>]
    member this.Submenu(it: CheckMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CheckMenuItemProperty.Submenu value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: CheckMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield CheckMenuItemProperty.AccelPath value } 
    [<CustomOperation("label")>]
    member this.Label(it: CheckMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield CheckMenuItemProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: CheckMenuItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield CheckMenuItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: CheckMenuItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield CheckMenuItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: CheckMenuItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield CheckMenuItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: CheckMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield CheckMenuItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: CheckMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CheckMenuItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: CheckMenuItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield CheckMenuItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: CheckMenuItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield CheckMenuItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: CheckMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield CheckMenuItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: CheckMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield CheckMenuItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: CheckMenuItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield CheckMenuItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: CheckMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CheckMenuItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: CheckMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CheckMenuItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: CheckMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckMenuItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: CheckMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckMenuItemProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: CheckMenuItemProperty seq, value: System.Double) =
        seq { yield! it; yield CheckMenuItemProperty.Opacity value } 
    [<CustomOperation("onToggleSizeAllocated")>]
    member this.OnToggleSizeAllocated(it: CheckMenuItemProperty seq, value: Gtk.ToggleSizeAllocatedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnToggleSizeAllocated value } 
    [<CustomOperation("onToggleSizeRequested")>]
    member this.OnToggleSizeRequested(it: CheckMenuItemProperty seq, value: Gtk.ToggleSizeRequestedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnToggleSizeRequested value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: CheckMenuItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: CheckMenuItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: CheckMenuItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: CheckMenuItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: CheckMenuItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: CheckMenuItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: CheckMenuItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: CheckMenuItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: CheckMenuItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: CheckMenuItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: CheckMenuItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: CheckMenuItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: CheckMenuItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: CheckMenuItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: CheckMenuItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: CheckMenuItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: CheckMenuItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: CheckMenuItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: CheckMenuItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: CheckMenuItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: CheckMenuItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: CheckMenuItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: CheckMenuItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: CheckMenuItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: CheckMenuItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: CheckMenuItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: CheckMenuItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: CheckMenuItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: CheckMenuItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: CheckMenuItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: CheckMenuItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: CheckMenuItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: CheckMenuItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: CheckMenuItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: CheckMenuItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: CheckMenuItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: CheckMenuItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: CheckMenuItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: CheckMenuItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: CheckMenuItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: CheckMenuItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: CheckMenuItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: CheckMenuItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: CheckMenuItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: CheckMenuItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: CheckMenuItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: CheckMenuItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: CheckMenuItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: CheckMenuItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: CheckMenuItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: CheckMenuItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: CheckMenuItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: CheckMenuItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: CheckMenuItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: CheckMenuItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: CheckMenuItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: CheckMenuItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: CheckMenuItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: CheckMenuItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: CheckMenuItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield CheckMenuItemProperty.OnFocused value } 

let prop = CheckMenuItemPropertyBuilder()

type CheckMenuItemDescriptor(props) =
    inherit BaseWidgetDescriptor<CheckMenuItem, CheckMenuItemProperty>(props, bindProperty)
    override this.CreateTyped() = new CheckMenuItem()

let checkMenuItem props = CheckMenuItemDescriptor(props)
