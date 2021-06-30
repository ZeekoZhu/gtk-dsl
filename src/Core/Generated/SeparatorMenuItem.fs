module GtkDsl.Binding.SeparatorMenuItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SeparatorMenuItemProperty =
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

let bindProperty (widget: SeparatorMenuItem) (prop: SeparatorMenuItemProperty) =
    match prop with
    | SeparatorMenuItemProperty.RightJustified value -> widget.RightJustified <- value
    | SeparatorMenuItemProperty.Submenu value -> widget.Submenu <- value
    | SeparatorMenuItemProperty.AccelPath value -> widget.AccelPath <- value
    | SeparatorMenuItemProperty.Label value -> widget.Label <- value
    | SeparatorMenuItemProperty.UseUnderline value -> widget.UseUnderline <- value
    | SeparatorMenuItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | SeparatorMenuItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | SeparatorMenuItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | SeparatorMenuItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | SeparatorMenuItemProperty.Name value -> widget.Name <- value
    | SeparatorMenuItemProperty.Parent value -> widget.Parent <- value
    | SeparatorMenuItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | SeparatorMenuItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | SeparatorMenuItemProperty.Visible value -> widget.Visible <- value
    | SeparatorMenuItemProperty.Sensitive value -> widget.Sensitive <- value
    | SeparatorMenuItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | SeparatorMenuItemProperty.CanFocus value -> widget.CanFocus <- value
    | SeparatorMenuItemProperty.HasFocus value -> widget.HasFocus <- value
    | SeparatorMenuItemProperty.IsFocus value -> widget.IsFocus <- value
    | SeparatorMenuItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SeparatorMenuItemProperty.CanDefault value -> widget.CanDefault <- value
    | SeparatorMenuItemProperty.HasDefault value -> widget.HasDefault <- value
    | SeparatorMenuItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SeparatorMenuItemProperty.Style value -> widget.Style <- value
    | SeparatorMenuItemProperty.Events value -> widget.Events <- value
    | SeparatorMenuItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | SeparatorMenuItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | SeparatorMenuItemProperty.TooltipText value -> widget.TooltipText <- value
    | SeparatorMenuItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SeparatorMenuItemProperty.Window value -> widget.Window <- value
    | SeparatorMenuItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SeparatorMenuItemProperty.Halign value -> widget.Halign <- value
    | SeparatorMenuItemProperty.Valign value -> widget.Valign <- value
    | SeparatorMenuItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | SeparatorMenuItemProperty.MarginRight value -> widget.MarginRight <- value
    | SeparatorMenuItemProperty.MarginStart value -> widget.MarginStart <- value
    | SeparatorMenuItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | SeparatorMenuItemProperty.MarginTop value -> widget.MarginTop <- value
    | SeparatorMenuItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | SeparatorMenuItemProperty.Margin value -> widget.Margin <- value
    | SeparatorMenuItemProperty.Hexpand value -> widget.Hexpand <- value
    | SeparatorMenuItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | SeparatorMenuItemProperty.Vexpand value -> widget.Vexpand <- value
    | SeparatorMenuItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | SeparatorMenuItemProperty.Expand value -> widget.Expand <- value
    | SeparatorMenuItemProperty.Opacity value -> widget.Opacity <- value
    | SeparatorMenuItemProperty.OnToggleSizeAllocated handler -> 
        let disposable = widget.ToggleSizeAllocated.Subscribe(handler)
        registerListener widget "ToggleSizeAllocated" disposable
    | SeparatorMenuItemProperty.OnToggleSizeRequested handler -> 
        let disposable = widget.ToggleSizeRequested.Subscribe(handler)
        registerListener widget "ToggleSizeRequested" disposable
    | SeparatorMenuItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | SeparatorMenuItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | SeparatorMenuItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | SeparatorMenuItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SeparatorMenuItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SeparatorMenuItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SeparatorMenuItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SeparatorMenuItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SeparatorMenuItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SeparatorMenuItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SeparatorMenuItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SeparatorMenuItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SeparatorMenuItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SeparatorMenuItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SeparatorMenuItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SeparatorMenuItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SeparatorMenuItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SeparatorMenuItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SeparatorMenuItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SeparatorMenuItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SeparatorMenuItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SeparatorMenuItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SeparatorMenuItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SeparatorMenuItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SeparatorMenuItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SeparatorMenuItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SeparatorMenuItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SeparatorMenuItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SeparatorMenuItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SeparatorMenuItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SeparatorMenuItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SeparatorMenuItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SeparatorMenuItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SeparatorMenuItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SeparatorMenuItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SeparatorMenuItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SeparatorMenuItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SeparatorMenuItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SeparatorMenuItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SeparatorMenuItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SeparatorMenuItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SeparatorMenuItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SeparatorMenuItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SeparatorMenuItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SeparatorMenuItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SeparatorMenuItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SeparatorMenuItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SeparatorMenuItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SeparatorMenuItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SeparatorMenuItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SeparatorMenuItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SeparatorMenuItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SeparatorMenuItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SeparatorMenuItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SeparatorMenuItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SeparatorMenuItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SeparatorMenuItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SeparatorMenuItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SeparatorMenuItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SeparatorMenuItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SeparatorMenuItemPropertyBuilder() =
    inherit BasePropertyBuilder<SeparatorMenuItemProperty>()
    [<Obsolete>]
    [<CustomOperation("rightJustified")>]
    member this.RightJustified(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.RightJustified value } 
    [<CustomOperation("submenu")>]
    member this.Submenu(it: SeparatorMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SeparatorMenuItemProperty.Submenu value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: SeparatorMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorMenuItemProperty.AccelPath value } 
    [<CustomOperation("label")>]
    member this.Label(it: SeparatorMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorMenuItemProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: SeparatorMenuItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield SeparatorMenuItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: SeparatorMenuItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield SeparatorMenuItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: SeparatorMenuItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield SeparatorMenuItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: SeparatorMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorMenuItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SeparatorMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SeparatorMenuItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SeparatorMenuItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SeparatorMenuItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SeparatorMenuItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SeparatorMenuItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SeparatorMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorMenuItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SeparatorMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorMenuItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SeparatorMenuItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SeparatorMenuItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SeparatorMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SeparatorMenuItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SeparatorMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SeparatorMenuItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SeparatorMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorMenuItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SeparatorMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorMenuItemProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SeparatorMenuItemProperty seq, value: System.Double) =
        seq { yield! it; yield SeparatorMenuItemProperty.Opacity value } 
    [<CustomOperation("onToggleSizeAllocated")>]
    member this.OnToggleSizeAllocated(it: SeparatorMenuItemProperty seq, value: Gtk.ToggleSizeAllocatedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnToggleSizeAllocated value } 
    [<CustomOperation("onToggleSizeRequested")>]
    member this.OnToggleSizeRequested(it: SeparatorMenuItemProperty seq, value: Gtk.ToggleSizeRequestedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnToggleSizeRequested value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: SeparatorMenuItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: SeparatorMenuItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: SeparatorMenuItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SeparatorMenuItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SeparatorMenuItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SeparatorMenuItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SeparatorMenuItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SeparatorMenuItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SeparatorMenuItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SeparatorMenuItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SeparatorMenuItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SeparatorMenuItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SeparatorMenuItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SeparatorMenuItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SeparatorMenuItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SeparatorMenuItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SeparatorMenuItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SeparatorMenuItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SeparatorMenuItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SeparatorMenuItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SeparatorMenuItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SeparatorMenuItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SeparatorMenuItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SeparatorMenuItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SeparatorMenuItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SeparatorMenuItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SeparatorMenuItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SeparatorMenuItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SeparatorMenuItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SeparatorMenuItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SeparatorMenuItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SeparatorMenuItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SeparatorMenuItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SeparatorMenuItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SeparatorMenuItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SeparatorMenuItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SeparatorMenuItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SeparatorMenuItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SeparatorMenuItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SeparatorMenuItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SeparatorMenuItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SeparatorMenuItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SeparatorMenuItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SeparatorMenuItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SeparatorMenuItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SeparatorMenuItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SeparatorMenuItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SeparatorMenuItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SeparatorMenuItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SeparatorMenuItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SeparatorMenuItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SeparatorMenuItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SeparatorMenuItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SeparatorMenuItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SeparatorMenuItemProperty.OnFocused value } 

let prop = SeparatorMenuItemPropertyBuilder()

type SeparatorMenuItemDescriptor(props) =
    inherit BaseWidgetDescriptor<SeparatorMenuItem, SeparatorMenuItemProperty>(props, bindProperty)
    override this.CreateTyped() = new SeparatorMenuItem()

let separatorMenuItem props = SeparatorMenuItemDescriptor(props)

