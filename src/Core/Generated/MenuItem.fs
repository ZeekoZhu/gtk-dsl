module GtkDsl.Binding.MenuItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuItemProperty =
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

let bindProperty (widget: MenuItem) (prop: MenuItemProperty) =
    match prop with
    | MenuItemProperty.RightJustified value -> widget.RightJustified <- value
    | MenuItemProperty.Submenu value -> widget.Submenu <- value
    | MenuItemProperty.AccelPath value -> widget.AccelPath <- value
    | MenuItemProperty.Label value -> widget.Label <- value
    | MenuItemProperty.UseUnderline value -> widget.UseUnderline <- value
    | MenuItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | MenuItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | MenuItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuItemProperty.Name value -> widget.Name <- value
    | MenuItemProperty.Parent value -> widget.Parent <- value
    | MenuItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuItemProperty.Visible value -> widget.Visible <- value
    | MenuItemProperty.Sensitive value -> widget.Sensitive <- value
    | MenuItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuItemProperty.CanFocus value -> widget.CanFocus <- value
    | MenuItemProperty.HasFocus value -> widget.HasFocus <- value
    | MenuItemProperty.IsFocus value -> widget.IsFocus <- value
    | MenuItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuItemProperty.CanDefault value -> widget.CanDefault <- value
    | MenuItemProperty.HasDefault value -> widget.HasDefault <- value
    | MenuItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuItemProperty.Style value -> widget.Style <- value
    | MenuItemProperty.Events value -> widget.Events <- value
    | MenuItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuItemProperty.TooltipText value -> widget.TooltipText <- value
    | MenuItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuItemProperty.Window value -> widget.Window <- value
    | MenuItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuItemProperty.Halign value -> widget.Halign <- value
    | MenuItemProperty.Valign value -> widget.Valign <- value
    | MenuItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuItemProperty.MarginRight value -> widget.MarginRight <- value
    | MenuItemProperty.MarginStart value -> widget.MarginStart <- value
    | MenuItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuItemProperty.MarginTop value -> widget.MarginTop <- value
    | MenuItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuItemProperty.Margin value -> widget.Margin <- value
    | MenuItemProperty.Hexpand value -> widget.Hexpand <- value
    | MenuItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuItemProperty.Vexpand value -> widget.Vexpand <- value
    | MenuItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuItemProperty.Expand value -> widget.Expand <- value
    | MenuItemProperty.Opacity value -> widget.Opacity <- value
    | MenuItemProperty.OnToggleSizeAllocated handler -> 
        let disposable = widget.ToggleSizeAllocated.Subscribe(handler)
        registerListener widget "ToggleSizeAllocated" disposable
    | MenuItemProperty.OnToggleSizeRequested handler -> 
        let disposable = widget.ToggleSizeRequested.Subscribe(handler)
        registerListener widget "ToggleSizeRequested" disposable
    | MenuItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuItemPropertyBuilder() =
    inherit BasePropertyBuilder<MenuItemProperty>()
    [<Obsolete>]
    [<CustomOperation("rightJustified")>]
    member this.RightJustified(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.RightJustified value } 
    [<CustomOperation("submenu")>]
    member this.Submenu(it: MenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuItemProperty.Submenu value } 
    [<CustomOperation("accelPath")>]
    member this.AccelPath(it: MenuItemProperty seq, value: System.String) =
        seq { yield! it; yield MenuItemProperty.AccelPath value } 
    [<CustomOperation("label")>]
    member this.Label(it: MenuItemProperty seq, value: System.String) =
        seq { yield! it; yield MenuItemProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: MenuItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield MenuItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuItemProperty seq, value: System.String) =
        seq { yield! it; yield MenuItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuItemProperty seq, value: System.String) =
        seq { yield! it; yield MenuItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuItemProperty seq, value: System.String) =
        seq { yield! it; yield MenuItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuItemProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MenuItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuItemProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuItemProperty seq, value: System.Double) =
        seq { yield! it; yield MenuItemProperty.Opacity value } 
    [<CustomOperation("onToggleSizeAllocated")>]
    member this.OnToggleSizeAllocated(it: MenuItemProperty seq, value: Gtk.ToggleSizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnToggleSizeAllocated value } 
    [<CustomOperation("onToggleSizeRequested")>]
    member this.OnToggleSizeRequested(it: MenuItemProperty seq, value: Gtk.ToggleSizeRequestedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnToggleSizeRequested value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuItemProperty.OnFocused value } 

let prop = MenuItemPropertyBuilder()

type MenuItemDescriptor(props) =
    inherit BaseWidgetDescriptor<MenuItem, MenuItemProperty>(props, bindProperty)
    override this.CreateTyped() = new MenuItem()

let menuItem props = MenuItemDescriptor(props)

