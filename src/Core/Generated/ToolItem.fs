module GtkDsl.Binding.ToolItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToolItemProperty =
    | VisibleHorizontal of System.Boolean
    | VisibleVertical of System.Boolean
    | IsImportant of System.Boolean
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
    | Opacity of System.Double
    |  OnCreateMenuProxy of (Gtk.CreateMenuProxyArgs -> unit)
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

let bindProperty (widget: ToolItem) (prop: ToolItemProperty) =
    match prop with
    | ToolItemProperty.VisibleHorizontal value -> widget.VisibleHorizontal <- value
    | ToolItemProperty.VisibleVertical value -> widget.VisibleVertical <- value
    | ToolItemProperty.IsImportant value -> widget.IsImportant <- value
    | ToolItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | ToolItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ToolItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToolItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToolItemProperty.Name value -> widget.Name <- value
    | ToolItemProperty.Parent value -> widget.Parent <- value
    | ToolItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToolItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToolItemProperty.Visible value -> widget.Visible <- value
    | ToolItemProperty.Sensitive value -> widget.Sensitive <- value
    | ToolItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToolItemProperty.CanFocus value -> widget.CanFocus <- value
    | ToolItemProperty.HasFocus value -> widget.HasFocus <- value
    | ToolItemProperty.IsFocus value -> widget.IsFocus <- value
    | ToolItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToolItemProperty.CanDefault value -> widget.CanDefault <- value
    | ToolItemProperty.HasDefault value -> widget.HasDefault <- value
    | ToolItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToolItemProperty.Style value -> widget.Style <- value
    | ToolItemProperty.Events value -> widget.Events <- value
    | ToolItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToolItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToolItemProperty.TooltipText value -> widget.TooltipText <- value
    | ToolItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToolItemProperty.Window value -> widget.Window <- value
    | ToolItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToolItemProperty.Halign value -> widget.Halign <- value
    | ToolItemProperty.Valign value -> widget.Valign <- value
    | ToolItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToolItemProperty.MarginRight value -> widget.MarginRight <- value
    | ToolItemProperty.MarginStart value -> widget.MarginStart <- value
    | ToolItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToolItemProperty.MarginTop value -> widget.MarginTop <- value
    | ToolItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToolItemProperty.Margin value -> widget.Margin <- value
    | ToolItemProperty.Hexpand value -> widget.Hexpand <- value
    | ToolItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToolItemProperty.Vexpand value -> widget.Vexpand <- value
    | ToolItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToolItemProperty.Opacity value -> widget.Opacity <- value
    | ToolItemProperty.OnCreateMenuProxy handler -> 
        let disposable = widget.CreateMenuProxy.Subscribe(handler)
        registerListener widget "CreateMenuProxy" disposable
    | ToolItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToolItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToolItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToolItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToolItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToolItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToolItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToolItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToolItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToolItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToolItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToolItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToolItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToolItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToolItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToolItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToolItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToolItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToolItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToolItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToolItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToolItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToolItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToolItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToolItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToolItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToolItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToolItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToolItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToolItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToolItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToolItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToolItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToolItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToolItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToolItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToolItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToolItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToolItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToolItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToolItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToolItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToolItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToolItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToolItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToolItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToolItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToolItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToolItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToolItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToolItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToolItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToolItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToolItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToolItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToolItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToolItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToolItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToolItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToolItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToolItemPropertyBuilder() =
    inherit BasePropertyBuilder<ToolItemProperty>()
    [<CustomOperation("visibleHorizontal")>]
    member this.VisibleHorizontal(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.VisibleHorizontal value } 
    [<CustomOperation("visibleVertical")>]
    member this.VisibleVertical(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.VisibleVertical value } 
    [<CustomOperation("isImportant")>]
    member this.IsImportant(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.IsImportant value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ToolItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ToolItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToolItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToolItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToolItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToolItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToolItemProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToolItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ToolItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ToolItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToolItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToolItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToolItemProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToolItemProperty seq, value: System.String) =
        seq { yield! it; yield ToolItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToolItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToolItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToolItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToolItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolItemProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToolItemProperty seq, value: System.Double) =
        seq { yield! it; yield ToolItemProperty.Opacity value } 
    [<CustomOperation("onCreateMenuProxy")>]
    member this.OnCreateMenuProxy(it: ToolItemProperty seq, value: Gtk.CreateMenuProxyArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnCreateMenuProxy value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToolItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToolItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToolItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToolItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToolItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToolItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToolItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToolItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToolItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToolItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToolItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToolItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToolItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToolItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToolItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToolItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToolItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToolItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToolItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToolItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToolItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToolItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToolItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToolItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToolItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToolItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToolItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToolItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToolItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToolItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToolItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToolItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToolItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToolItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToolItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToolItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToolItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToolItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToolItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToolItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToolItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToolItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToolItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToolItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToolItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToolItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToolItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToolItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToolItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToolItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToolItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToolItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToolItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToolItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToolItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToolItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToolItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToolItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToolItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToolItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToolItemProperty.OnFocused value } 

let prop = ToolItemPropertyBuilder()

type ToolItemDescriptor(props) =
    inherit BaseWidgetDescriptor<ToolItem, ToolItemProperty>(props, bindProperty)
    override this.CreateTyped() = new ToolItem()

let toolItem props = ToolItemDescriptor(props)

