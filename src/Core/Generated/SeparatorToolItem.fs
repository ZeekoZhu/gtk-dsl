module GtkDsl.Binding.SeparatorToolItem
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SeparatorToolItemProperty =
    | Draw of System.Boolean
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

let bindProperty (widget: SeparatorToolItem) (prop: SeparatorToolItemProperty) =
    match prop with
    | SeparatorToolItemProperty.Draw value -> widget.Draw <- value
    | SeparatorToolItemProperty.VisibleHorizontal value -> widget.VisibleHorizontal <- value
    | SeparatorToolItemProperty.VisibleVertical value -> widget.VisibleVertical <- value
    | SeparatorToolItemProperty.IsImportant value -> widget.IsImportant <- value
    | SeparatorToolItemProperty.RelatedAction value -> widget.RelatedAction <- value
    | SeparatorToolItemProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | SeparatorToolItemProperty.ResizeMode value -> widget.ResizeMode <- value
    | SeparatorToolItemProperty.BorderWidth value -> widget.BorderWidth <- value
    | SeparatorToolItemProperty.Name value -> widget.Name <- value
    | SeparatorToolItemProperty.Parent value -> widget.Parent <- value
    | SeparatorToolItemProperty.WidthRequest value -> widget.WidthRequest <- value
    | SeparatorToolItemProperty.HeightRequest value -> widget.HeightRequest <- value
    | SeparatorToolItemProperty.Visible value -> widget.Visible <- value
    | SeparatorToolItemProperty.Sensitive value -> widget.Sensitive <- value
    | SeparatorToolItemProperty.AppPaintable value -> widget.AppPaintable <- value
    | SeparatorToolItemProperty.CanFocus value -> widget.CanFocus <- value
    | SeparatorToolItemProperty.HasFocus value -> widget.HasFocus <- value
    | SeparatorToolItemProperty.IsFocus value -> widget.IsFocus <- value
    | SeparatorToolItemProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SeparatorToolItemProperty.CanDefault value -> widget.CanDefault <- value
    | SeparatorToolItemProperty.HasDefault value -> widget.HasDefault <- value
    | SeparatorToolItemProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SeparatorToolItemProperty.Style value -> widget.Style <- value
    | SeparatorToolItemProperty.Events value -> widget.Events <- value
    | SeparatorToolItemProperty.NoShowAll value -> widget.NoShowAll <- value
    | SeparatorToolItemProperty.HasTooltip value -> widget.HasTooltip <- value
    | SeparatorToolItemProperty.TooltipText value -> widget.TooltipText <- value
    | SeparatorToolItemProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SeparatorToolItemProperty.Window value -> widget.Window <- value
    | SeparatorToolItemProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SeparatorToolItemProperty.Halign value -> widget.Halign <- value
    | SeparatorToolItemProperty.Valign value -> widget.Valign <- value
    | SeparatorToolItemProperty.MarginLeft value -> widget.MarginLeft <- value
    | SeparatorToolItemProperty.MarginRight value -> widget.MarginRight <- value
    | SeparatorToolItemProperty.MarginStart value -> widget.MarginStart <- value
    | SeparatorToolItemProperty.MarginEnd value -> widget.MarginEnd <- value
    | SeparatorToolItemProperty.MarginTop value -> widget.MarginTop <- value
    | SeparatorToolItemProperty.MarginBottom value -> widget.MarginBottom <- value
    | SeparatorToolItemProperty.Margin value -> widget.Margin <- value
    | SeparatorToolItemProperty.Hexpand value -> widget.Hexpand <- value
    | SeparatorToolItemProperty.HexpandSet value -> widget.HexpandSet <- value
    | SeparatorToolItemProperty.Vexpand value -> widget.Vexpand <- value
    | SeparatorToolItemProperty.VexpandSet value -> widget.VexpandSet <- value
    | SeparatorToolItemProperty.Opacity value -> widget.Opacity <- value
    | SeparatorToolItemProperty.OnCreateMenuProxy handler -> 
        let disposable = widget.CreateMenuProxy.Subscribe(handler)
        registerListener widget "CreateMenuProxy" disposable
    | SeparatorToolItemProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | SeparatorToolItemProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | SeparatorToolItemProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | SeparatorToolItemProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SeparatorToolItemProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SeparatorToolItemProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SeparatorToolItemProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SeparatorToolItemProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SeparatorToolItemProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SeparatorToolItemProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SeparatorToolItemProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SeparatorToolItemProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SeparatorToolItemProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SeparatorToolItemProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SeparatorToolItemProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SeparatorToolItemProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SeparatorToolItemProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SeparatorToolItemProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SeparatorToolItemProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SeparatorToolItemProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SeparatorToolItemProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SeparatorToolItemProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SeparatorToolItemProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SeparatorToolItemProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SeparatorToolItemProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SeparatorToolItemProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SeparatorToolItemProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SeparatorToolItemProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SeparatorToolItemProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SeparatorToolItemProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SeparatorToolItemProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SeparatorToolItemProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SeparatorToolItemProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SeparatorToolItemProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SeparatorToolItemProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SeparatorToolItemProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SeparatorToolItemProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SeparatorToolItemProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SeparatorToolItemProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SeparatorToolItemProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SeparatorToolItemProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SeparatorToolItemProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SeparatorToolItemProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SeparatorToolItemProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SeparatorToolItemProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SeparatorToolItemProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SeparatorToolItemProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SeparatorToolItemProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SeparatorToolItemProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SeparatorToolItemProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SeparatorToolItemProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SeparatorToolItemProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SeparatorToolItemProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SeparatorToolItemProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SeparatorToolItemProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SeparatorToolItemProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SeparatorToolItemProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SeparatorToolItemProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SeparatorToolItemProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SeparatorToolItemProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SeparatorToolItemPropertyBuilder() =
    inherit BasePropertyBuilder<SeparatorToolItemProperty>()
    [<CustomOperation("draw")>]
    member this.Draw(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.Draw value } 
    [<CustomOperation("visibleHorizontal")>]
    member this.VisibleHorizontal(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.VisibleHorizontal value } 
    [<CustomOperation("visibleVertical")>]
    member this.VisibleVertical(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.VisibleVertical value } 
    [<CustomOperation("isImportant")>]
    member this.IsImportant(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.IsImportant value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: SeparatorToolItemProperty seq, value: Gtk.Action) =
        seq { yield! it; yield SeparatorToolItemProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: SeparatorToolItemProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield SeparatorToolItemProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: SeparatorToolItemProperty seq, value: System.UInt32) =
        seq { yield! it; yield SeparatorToolItemProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: SeparatorToolItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorToolItemProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SeparatorToolItemProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SeparatorToolItemProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SeparatorToolItemProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SeparatorToolItemProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SeparatorToolItemProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SeparatorToolItemProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SeparatorToolItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorToolItemProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SeparatorToolItemProperty seq, value: System.String) =
        seq { yield! it; yield SeparatorToolItemProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SeparatorToolItemProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SeparatorToolItemProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SeparatorToolItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SeparatorToolItemProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SeparatorToolItemProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SeparatorToolItemProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SeparatorToolItemProperty seq, value: System.Int32) =
        seq { yield! it; yield SeparatorToolItemProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SeparatorToolItemProperty seq, value: System.Boolean) =
        seq { yield! it; yield SeparatorToolItemProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SeparatorToolItemProperty seq, value: System.Double) =
        seq { yield! it; yield SeparatorToolItemProperty.Opacity value } 
    [<CustomOperation("onCreateMenuProxy")>]
    member this.OnCreateMenuProxy(it: SeparatorToolItemProperty seq, value: Gtk.CreateMenuProxyArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnCreateMenuProxy value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: SeparatorToolItemProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: SeparatorToolItemProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: SeparatorToolItemProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SeparatorToolItemProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SeparatorToolItemProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SeparatorToolItemProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SeparatorToolItemProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SeparatorToolItemProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SeparatorToolItemProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SeparatorToolItemProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SeparatorToolItemProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SeparatorToolItemProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SeparatorToolItemProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SeparatorToolItemProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SeparatorToolItemProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SeparatorToolItemProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SeparatorToolItemProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SeparatorToolItemProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SeparatorToolItemProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SeparatorToolItemProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SeparatorToolItemProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SeparatorToolItemProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SeparatorToolItemProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SeparatorToolItemProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SeparatorToolItemProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SeparatorToolItemProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SeparatorToolItemProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SeparatorToolItemProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SeparatorToolItemProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SeparatorToolItemProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SeparatorToolItemProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SeparatorToolItemProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SeparatorToolItemProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SeparatorToolItemProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SeparatorToolItemProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SeparatorToolItemProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SeparatorToolItemProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SeparatorToolItemProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SeparatorToolItemProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SeparatorToolItemProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SeparatorToolItemProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SeparatorToolItemProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SeparatorToolItemProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SeparatorToolItemProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SeparatorToolItemProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SeparatorToolItemProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SeparatorToolItemProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SeparatorToolItemProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SeparatorToolItemProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SeparatorToolItemProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SeparatorToolItemProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SeparatorToolItemProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SeparatorToolItemProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SeparatorToolItemProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SeparatorToolItemProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SeparatorToolItemProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SeparatorToolItemProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SeparatorToolItemProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SeparatorToolItemProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SeparatorToolItemProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SeparatorToolItemProperty.OnFocused value } 

let prop = SeparatorToolItemPropertyBuilder()

type SeparatorToolItemDescriptor(props) =
    inherit BaseWidgetDescriptor<SeparatorToolItem, SeparatorToolItemProperty>(props, bindProperty)
    override this.CreateTyped() = new SeparatorToolItem()

let separatorToolItem props = SeparatorToolItemDescriptor(props)

