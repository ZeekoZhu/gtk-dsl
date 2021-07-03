module Gtk.DSL.Binding.ToolButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToolButtonProperty =
    | Label of System.String
    | UseUnderline of System.Boolean
    | LabelWidget of Gtk.Widget
    | [<Obsolete>] StockId of System.String
    | IconName of System.String
    | IconWidget of Gtk.Widget
    | IconSpacing of System.Int32
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

let bindProperty (widget: ToolButton) (prop: ToolButtonProperty) =
    match prop with
    | ToolButtonProperty.Label value -> widget.Label <- value
    | ToolButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | ToolButtonProperty.LabelWidget value -> widget.LabelWidget <- value
    | ToolButtonProperty.StockId value -> widget.StockId <- value
    | ToolButtonProperty.IconName value -> widget.IconName <- value
    | ToolButtonProperty.IconWidget value -> widget.IconWidget <- value
    | ToolButtonProperty.IconSpacing value -> widget.IconSpacing <- value
    | ToolButtonProperty.VisibleHorizontal value -> widget.VisibleHorizontal <- value
    | ToolButtonProperty.VisibleVertical value -> widget.VisibleVertical <- value
    | ToolButtonProperty.IsImportant value -> widget.IsImportant <- value
    | ToolButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | ToolButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ToolButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToolButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToolButtonProperty.Name value -> widget.Name <- value
    | ToolButtonProperty.Parent value -> widget.Parent <- value
    | ToolButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToolButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToolButtonProperty.Visible value -> widget.Visible <- value
    | ToolButtonProperty.Sensitive value -> widget.Sensitive <- value
    | ToolButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToolButtonProperty.CanFocus value -> widget.CanFocus <- value
    | ToolButtonProperty.HasFocus value -> widget.HasFocus <- value
    | ToolButtonProperty.IsFocus value -> widget.IsFocus <- value
    | ToolButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToolButtonProperty.CanDefault value -> widget.CanDefault <- value
    | ToolButtonProperty.HasDefault value -> widget.HasDefault <- value
    | ToolButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToolButtonProperty.Style value -> widget.Style <- value
    | ToolButtonProperty.Events value -> widget.Events <- value
    | ToolButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToolButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToolButtonProperty.TooltipText value -> widget.TooltipText <- value
    | ToolButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToolButtonProperty.Window value -> widget.Window <- value
    | ToolButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToolButtonProperty.Halign value -> widget.Halign <- value
    | ToolButtonProperty.Valign value -> widget.Valign <- value
    | ToolButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToolButtonProperty.MarginRight value -> widget.MarginRight <- value
    | ToolButtonProperty.MarginStart value -> widget.MarginStart <- value
    | ToolButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToolButtonProperty.MarginTop value -> widget.MarginTop <- value
    | ToolButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToolButtonProperty.Margin value -> widget.Margin <- value
    | ToolButtonProperty.Hexpand value -> widget.Hexpand <- value
    | ToolButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToolButtonProperty.Vexpand value -> widget.Vexpand <- value
    | ToolButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToolButtonProperty.Opacity value -> widget.Opacity <- value
    | ToolButtonProperty.OnCreateMenuProxy handler -> 
        let disposable = widget.CreateMenuProxy.Subscribe(handler)
        registerListener widget "CreateMenuProxy" disposable
    | ToolButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToolButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToolButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToolButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToolButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToolButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToolButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToolButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToolButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToolButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToolButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToolButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToolButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToolButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToolButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToolButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToolButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToolButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToolButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToolButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToolButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToolButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToolButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToolButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToolButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToolButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToolButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToolButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToolButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToolButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToolButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToolButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToolButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToolButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToolButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToolButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToolButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToolButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToolButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToolButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToolButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToolButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToolButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToolButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToolButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToolButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToolButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToolButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToolButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToolButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToolButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToolButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToolButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToolButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToolButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToolButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToolButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToolButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToolButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToolButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToolButtonPropertyBuilder() =
    inherit BasePropertyBuilder<ToolButtonProperty>()
    [<CustomOperation("label")>]
    member this.Label(it: ToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToolButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.UseUnderline value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: ToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolButtonProperty.LabelWidget value } 
    [<Obsolete>]
    [<CustomOperation("stockId")>]
    member this.StockId(it: ToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToolButtonProperty.StockId value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToolButtonProperty.IconName value } 
    [<CustomOperation("iconWidget")>]
    member this.IconWidget(it: ToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolButtonProperty.IconWidget value } 
    [<CustomOperation("iconSpacing")>]
    member this.IconSpacing(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.IconSpacing value } 
    [<CustomOperation("visibleHorizontal")>]
    member this.VisibleHorizontal(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.VisibleHorizontal value } 
    [<CustomOperation("visibleVertical")>]
    member this.VisibleVertical(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.VisibleVertical value } 
    [<CustomOperation("isImportant")>]
    member this.IsImportant(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.IsImportant value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ToolButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ToolButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToolButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToolButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToolButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToolButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToolButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToolButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ToolButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ToolButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToolButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToolButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToolButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToolButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToolButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToolButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToolButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToolButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToolButtonProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToolButtonProperty seq, value: System.Double) =
        seq { yield! it; yield ToolButtonProperty.Opacity value } 
    [<CustomOperation("onCreateMenuProxy")>]
    member this.OnCreateMenuProxy(it: ToolButtonProperty seq, value: Gtk.CreateMenuProxyArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnCreateMenuProxy value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToolButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToolButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToolButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToolButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToolButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToolButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToolButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToolButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToolButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToolButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToolButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToolButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToolButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToolButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToolButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToolButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToolButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToolButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToolButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToolButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToolButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToolButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToolButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToolButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToolButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToolButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToolButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToolButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToolButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToolButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToolButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToolButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToolButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToolButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToolButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToolButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToolButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToolButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToolButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToolButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToolButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToolButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToolButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToolButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToolButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToolButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToolButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToolButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToolButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToolButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToolButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToolButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToolButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToolButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToolButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToolButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToolButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToolButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToolButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToolButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToolButtonProperty.OnFocused value } 

let prop = ToolButtonPropertyBuilder()

