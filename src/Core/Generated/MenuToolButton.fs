module Gtk.DSL.Binding.MenuToolButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuToolButtonProperty =
    | Menu of Gtk.Widget
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

let bindProperty (widget: MenuToolButton) (prop: MenuToolButtonProperty) =
    match prop with
    | MenuToolButtonProperty.Menu value -> widget.Menu <- value
    | MenuToolButtonProperty.Label value -> widget.Label <- value
    | MenuToolButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | MenuToolButtonProperty.LabelWidget value -> widget.LabelWidget <- value
    | MenuToolButtonProperty.StockId value -> widget.StockId <- value
    | MenuToolButtonProperty.IconName value -> widget.IconName <- value
    | MenuToolButtonProperty.IconWidget value -> widget.IconWidget <- value
    | MenuToolButtonProperty.IconSpacing value -> widget.IconSpacing <- value
    | MenuToolButtonProperty.VisibleHorizontal value -> widget.VisibleHorizontal <- value
    | MenuToolButtonProperty.VisibleVertical value -> widget.VisibleVertical <- value
    | MenuToolButtonProperty.IsImportant value -> widget.IsImportant <- value
    | MenuToolButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | MenuToolButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | MenuToolButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuToolButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuToolButtonProperty.Name value -> widget.Name <- value
    | MenuToolButtonProperty.Parent value -> widget.Parent <- value
    | MenuToolButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuToolButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuToolButtonProperty.Visible value -> widget.Visible <- value
    | MenuToolButtonProperty.Sensitive value -> widget.Sensitive <- value
    | MenuToolButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuToolButtonProperty.CanFocus value -> widget.CanFocus <- value
    | MenuToolButtonProperty.HasFocus value -> widget.HasFocus <- value
    | MenuToolButtonProperty.IsFocus value -> widget.IsFocus <- value
    | MenuToolButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuToolButtonProperty.CanDefault value -> widget.CanDefault <- value
    | MenuToolButtonProperty.HasDefault value -> widget.HasDefault <- value
    | MenuToolButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuToolButtonProperty.Style value -> widget.Style <- value
    | MenuToolButtonProperty.Events value -> widget.Events <- value
    | MenuToolButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuToolButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuToolButtonProperty.TooltipText value -> widget.TooltipText <- value
    | MenuToolButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuToolButtonProperty.Window value -> widget.Window <- value
    | MenuToolButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuToolButtonProperty.Halign value -> widget.Halign <- value
    | MenuToolButtonProperty.Valign value -> widget.Valign <- value
    | MenuToolButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuToolButtonProperty.MarginRight value -> widget.MarginRight <- value
    | MenuToolButtonProperty.MarginStart value -> widget.MarginStart <- value
    | MenuToolButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuToolButtonProperty.MarginTop value -> widget.MarginTop <- value
    | MenuToolButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuToolButtonProperty.Margin value -> widget.Margin <- value
    | MenuToolButtonProperty.Hexpand value -> widget.Hexpand <- value
    | MenuToolButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuToolButtonProperty.Vexpand value -> widget.Vexpand <- value
    | MenuToolButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuToolButtonProperty.Opacity value -> widget.Opacity <- value
    | MenuToolButtonProperty.OnCreateMenuProxy handler -> 
        let disposable = widget.CreateMenuProxy.Subscribe(handler)
        registerListener widget "CreateMenuProxy" disposable
    | MenuToolButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuToolButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuToolButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuToolButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuToolButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuToolButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuToolButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuToolButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuToolButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuToolButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuToolButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuToolButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuToolButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuToolButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuToolButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuToolButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuToolButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuToolButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuToolButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuToolButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuToolButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuToolButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuToolButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuToolButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuToolButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuToolButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuToolButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuToolButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuToolButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuToolButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuToolButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuToolButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuToolButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuToolButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuToolButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuToolButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuToolButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuToolButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuToolButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuToolButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuToolButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuToolButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuToolButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuToolButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuToolButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuToolButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuToolButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuToolButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuToolButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuToolButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuToolButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuToolButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuToolButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuToolButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuToolButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuToolButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuToolButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuToolButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuToolButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuToolButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuToolButtonPropertyBuilder() =
    inherit BasePropertyBuilder<MenuToolButtonProperty>()
    [<CustomOperation("menu")>]
    member this.Menu(it: MenuToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuToolButtonProperty.Menu value } 
    [<CustomOperation("label")>]
    member this.Label(it: MenuToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuToolButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.UseUnderline value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: MenuToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuToolButtonProperty.LabelWidget value } 
    [<Obsolete>]
    [<CustomOperation("stockId")>]
    member this.StockId(it: MenuToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuToolButtonProperty.StockId value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: MenuToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuToolButtonProperty.IconName value } 
    [<CustomOperation("iconWidget")>]
    member this.IconWidget(it: MenuToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuToolButtonProperty.IconWidget value } 
    [<CustomOperation("iconSpacing")>]
    member this.IconSpacing(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.IconSpacing value } 
    [<CustomOperation("visibleHorizontal")>]
    member this.VisibleHorizontal(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.VisibleHorizontal value } 
    [<CustomOperation("visibleVertical")>]
    member this.VisibleVertical(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.VisibleVertical value } 
    [<CustomOperation("isImportant")>]
    member this.IsImportant(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.IsImportant value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: MenuToolButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield MenuToolButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuToolButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuToolButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuToolButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuToolButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuToolButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuToolButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuToolButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuToolButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuToolButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuToolButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuToolButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuToolButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuToolButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuToolButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuToolButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuToolButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuToolButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuToolButtonProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuToolButtonProperty seq, value: System.Double) =
        seq { yield! it; yield MenuToolButtonProperty.Opacity value } 
    [<CustomOperation("onCreateMenuProxy")>]
    member this.OnCreateMenuProxy(it: MenuToolButtonProperty seq, value: Gtk.CreateMenuProxyArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnCreateMenuProxy value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuToolButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuToolButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuToolButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuToolButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuToolButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuToolButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuToolButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuToolButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuToolButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuToolButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuToolButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuToolButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuToolButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuToolButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuToolButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuToolButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuToolButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuToolButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuToolButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuToolButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuToolButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuToolButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuToolButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuToolButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuToolButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuToolButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuToolButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuToolButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuToolButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuToolButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuToolButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuToolButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuToolButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuToolButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuToolButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuToolButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuToolButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuToolButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuToolButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuToolButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuToolButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuToolButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuToolButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuToolButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuToolButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuToolButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuToolButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuToolButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuToolButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuToolButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuToolButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuToolButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuToolButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuToolButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuToolButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuToolButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuToolButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuToolButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuToolButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuToolButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuToolButtonProperty.OnFocused value } 

let prop = MenuToolButtonPropertyBuilder()

