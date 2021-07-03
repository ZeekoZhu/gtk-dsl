module Gtk.DSL.Binding.TearoffMenuItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type TearoffMenuItemProperty =
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

let bindProperty (widget: TearoffMenuItem) (prop: TearoffMenuItemProperty) =
    match prop with
    | TearoffMenuItemProperty.RightJustified value -> widget.RightJustified <- value
    | TearoffMenuItemProperty.Submenu value -> widget.Submenu <- value
    | TearoffMenuItemProperty.AccelPath value -> widget.AccelPath <- value
    | TearoffMenuItemProperty.Label value -> widget.Label <- value
    | TearoffMenuItemProperty.UseUnderline value -> widget.UseUnderline <- value
    | TearoffMenuItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | TearoffMenuItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | TearoffMenuItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | TearoffMenuItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | TearoffMenuItemProperty.Name value -> widget.Name <- value
    | TearoffMenuItemProperty.Parent value -> widget.Parent <- value
    | TearoffMenuItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | TearoffMenuItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | TearoffMenuItemProperty.Visible value -> widget.Visible <- value
    | TearoffMenuItemProperty.Sensitive value -> widget.Sensitive <- value
    | TearoffMenuItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | TearoffMenuItemProperty.CanFocus value -> widget.CanFocus <- value
    | TearoffMenuItemProperty.HasFocus value -> widget.HasFocus <- value
    | TearoffMenuItemProperty.IsFocus value -> widget.IsFocus <- value
    | TearoffMenuItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | TearoffMenuItemProperty.CanDefault value -> widget.CanDefault <- value
    | TearoffMenuItemProperty.HasDefault value -> widget.HasDefault <- value
    | TearoffMenuItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | TearoffMenuItemProperty.Style value -> widget.Style <- value
    | TearoffMenuItemProperty.Events value -> widget.Events <- value
    | TearoffMenuItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | TearoffMenuItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | TearoffMenuItemProperty.TooltipText value -> widget.TooltipText <- value
    | TearoffMenuItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | TearoffMenuItemProperty.Window value -> widget.Window <- value
    | TearoffMenuItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | TearoffMenuItemProperty.Halign value -> widget.Halign <- value
    | TearoffMenuItemProperty.Valign value -> widget.Valign <- value
    | TearoffMenuItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | TearoffMenuItemProperty.MarginRight value -> widget.MarginRight <- value
    | TearoffMenuItemProperty.MarginStart value -> widget.MarginStart <- value
    | TearoffMenuItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | TearoffMenuItemProperty.MarginTop value -> widget.MarginTop <- value
    | TearoffMenuItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | TearoffMenuItemProperty.Margin value -> widget.Margin <- value
    | TearoffMenuItemProperty.Hexpand value -> widget.Hexpand <- value
    | TearoffMenuItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | TearoffMenuItemProperty.Vexpand value -> widget.Vexpand <- value
    | TearoffMenuItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | TearoffMenuItemProperty.Expand value -> widget.Expand <- value
    | TearoffMenuItemProperty.Opacity value -> widget.Opacity <- value
    | TearoffMenuItemProperty.OnToggleSizeAllocated handler -> 
        let disposable = widget.ToggleSizeAllocated.Subscribe(handler)
        registerListener widget "ToggleSizeAllocated" disposable
    | TearoffMenuItemProperty.OnToggleSizeRequested handler -> 
        let disposable = widget.ToggleSizeRequested.Subscribe(handler)
        registerListener widget "ToggleSizeRequested" disposable
    | TearoffMenuItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | TearoffMenuItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | TearoffMenuItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | TearoffMenuItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | TearoffMenuItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | TearoffMenuItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | TearoffMenuItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | TearoffMenuItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | TearoffMenuItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | TearoffMenuItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | TearoffMenuItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | TearoffMenuItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | TearoffMenuItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | TearoffMenuItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | TearoffMenuItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | TearoffMenuItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | TearoffMenuItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | TearoffMenuItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | TearoffMenuItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | TearoffMenuItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | TearoffMenuItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | TearoffMenuItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | TearoffMenuItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | TearoffMenuItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | TearoffMenuItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | TearoffMenuItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | TearoffMenuItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | TearoffMenuItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | TearoffMenuItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | TearoffMenuItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | TearoffMenuItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | TearoffMenuItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | TearoffMenuItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | TearoffMenuItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | TearoffMenuItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | TearoffMenuItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | TearoffMenuItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | TearoffMenuItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | TearoffMenuItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | TearoffMenuItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | TearoffMenuItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | TearoffMenuItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | TearoffMenuItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | TearoffMenuItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | TearoffMenuItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | TearoffMenuItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | TearoffMenuItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | TearoffMenuItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | TearoffMenuItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | TearoffMenuItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | TearoffMenuItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | TearoffMenuItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | TearoffMenuItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | TearoffMenuItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | TearoffMenuItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | TearoffMenuItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | TearoffMenuItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | TearoffMenuItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | TearoffMenuItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | TearoffMenuItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type TearoffMenuItemPropertyBuilder() =
    inherit BasePropertyBuilder<TearoffMenuItemProperty>()
    [<Obsolete>]
    [<CustomOperation("rightJustified")>]
    member this.RightJustified(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.RightJustified value } 
    [<CustomOperation("submenu")>]
    member this.Submenu(it: TearoffMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TearoffMenuItemProperty.Submenu value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: TearoffMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield TearoffMenuItemProperty.AccelPath value } 
    [<CustomOperation("label")>]
    member this.Label(it: TearoffMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield TearoffMenuItemProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: TearoffMenuItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield TearoffMenuItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: TearoffMenuItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield TearoffMenuItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: TearoffMenuItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield TearoffMenuItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: TearoffMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield TearoffMenuItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: TearoffMenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TearoffMenuItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: TearoffMenuItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield TearoffMenuItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: TearoffMenuItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield TearoffMenuItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: TearoffMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield TearoffMenuItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: TearoffMenuItemProperty seq, value: System.String) =
        seq { yield! it; yield TearoffMenuItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: TearoffMenuItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield TearoffMenuItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: TearoffMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TearoffMenuItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: TearoffMenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TearoffMenuItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: TearoffMenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield TearoffMenuItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: TearoffMenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield TearoffMenuItemProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: TearoffMenuItemProperty seq, value: System.Double) =
        seq { yield! it; yield TearoffMenuItemProperty.Opacity value } 
    [<CustomOperation("onToggleSizeAllocated")>]
    member this.OnToggleSizeAllocated(it: TearoffMenuItemProperty seq, value: Gtk.ToggleSizeAllocatedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnToggleSizeAllocated value } 
    [<CustomOperation("onToggleSizeRequested")>]
    member this.OnToggleSizeRequested(it: TearoffMenuItemProperty seq, value: Gtk.ToggleSizeRequestedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnToggleSizeRequested value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: TearoffMenuItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: TearoffMenuItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: TearoffMenuItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: TearoffMenuItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: TearoffMenuItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: TearoffMenuItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: TearoffMenuItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: TearoffMenuItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: TearoffMenuItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: TearoffMenuItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: TearoffMenuItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: TearoffMenuItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: TearoffMenuItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: TearoffMenuItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: TearoffMenuItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: TearoffMenuItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: TearoffMenuItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: TearoffMenuItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: TearoffMenuItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: TearoffMenuItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: TearoffMenuItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: TearoffMenuItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: TearoffMenuItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: TearoffMenuItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: TearoffMenuItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: TearoffMenuItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: TearoffMenuItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: TearoffMenuItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: TearoffMenuItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: TearoffMenuItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: TearoffMenuItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: TearoffMenuItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: TearoffMenuItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: TearoffMenuItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: TearoffMenuItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: TearoffMenuItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: TearoffMenuItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: TearoffMenuItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: TearoffMenuItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: TearoffMenuItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: TearoffMenuItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: TearoffMenuItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: TearoffMenuItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: TearoffMenuItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: TearoffMenuItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: TearoffMenuItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: TearoffMenuItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: TearoffMenuItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: TearoffMenuItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: TearoffMenuItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: TearoffMenuItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: TearoffMenuItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: TearoffMenuItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: TearoffMenuItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: TearoffMenuItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: TearoffMenuItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: TearoffMenuItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: TearoffMenuItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: TearoffMenuItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: TearoffMenuItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield TearoffMenuItemProperty.OnFocused value } 

let prop = TearoffMenuItemPropertyBuilder()

type TearoffMenuItemDescriptor(props) =
    inherit BaseWidgetDescriptor<TearoffMenuItem, TearoffMenuItemProperty>(props, bindProperty)
    override this.CreateTyped() = new TearoffMenuItem()

let tearoffMenuItem props = TearoffMenuItemDescriptor(props)

