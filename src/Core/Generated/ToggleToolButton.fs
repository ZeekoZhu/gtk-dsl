module GtkDsl.Binding.ToggleToolButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToggleToolButtonProperty =
    | Active of System.Boolean
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

let bindProperty (widget: ToggleToolButton) (prop: ToggleToolButtonProperty) =
    match prop with
    | ToggleToolButtonProperty.Active value -> widget.Active <- value
    | ToggleToolButtonProperty.Label value -> widget.Label <- value
    | ToggleToolButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | ToggleToolButtonProperty.LabelWidget value -> widget.LabelWidget <- value
    | ToggleToolButtonProperty.StockId value -> widget.StockId <- value
    | ToggleToolButtonProperty.IconName value -> widget.IconName <- value
    | ToggleToolButtonProperty.IconWidget value -> widget.IconWidget <- value
    | ToggleToolButtonProperty.IconSpacing value -> widget.IconSpacing <- value
    | ToggleToolButtonProperty.VisibleHorizontal value -> widget.VisibleHorizontal <- value
    | ToggleToolButtonProperty.VisibleVertical value -> widget.VisibleVertical <- value
    | ToggleToolButtonProperty.IsImportant value -> widget.IsImportant <- value
    | ToggleToolButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | ToggleToolButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ToggleToolButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToggleToolButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToggleToolButtonProperty.Name value -> widget.Name <- value
    | ToggleToolButtonProperty.Parent value -> widget.Parent <- value
    | ToggleToolButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToggleToolButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToggleToolButtonProperty.Visible value -> widget.Visible <- value
    | ToggleToolButtonProperty.Sensitive value -> widget.Sensitive <- value
    | ToggleToolButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToggleToolButtonProperty.CanFocus value -> widget.CanFocus <- value
    | ToggleToolButtonProperty.HasFocus value -> widget.HasFocus <- value
    | ToggleToolButtonProperty.IsFocus value -> widget.IsFocus <- value
    | ToggleToolButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToggleToolButtonProperty.CanDefault value -> widget.CanDefault <- value
    | ToggleToolButtonProperty.HasDefault value -> widget.HasDefault <- value
    | ToggleToolButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToggleToolButtonProperty.Style value -> widget.Style <- value
    | ToggleToolButtonProperty.Events value -> widget.Events <- value
    | ToggleToolButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToggleToolButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToggleToolButtonProperty.TooltipText value -> widget.TooltipText <- value
    | ToggleToolButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToggleToolButtonProperty.Window value -> widget.Window <- value
    | ToggleToolButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToggleToolButtonProperty.Halign value -> widget.Halign <- value
    | ToggleToolButtonProperty.Valign value -> widget.Valign <- value
    | ToggleToolButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToggleToolButtonProperty.MarginRight value -> widget.MarginRight <- value
    | ToggleToolButtonProperty.MarginStart value -> widget.MarginStart <- value
    | ToggleToolButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToggleToolButtonProperty.MarginTop value -> widget.MarginTop <- value
    | ToggleToolButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToggleToolButtonProperty.Margin value -> widget.Margin <- value
    | ToggleToolButtonProperty.Hexpand value -> widget.Hexpand <- value
    | ToggleToolButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToggleToolButtonProperty.Vexpand value -> widget.Vexpand <- value
    | ToggleToolButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToggleToolButtonProperty.Opacity value -> widget.Opacity <- value
    | ToggleToolButtonProperty.OnCreateMenuProxy handler -> 
        let disposable = widget.CreateMenuProxy.Subscribe(handler)
        registerListener widget "CreateMenuProxy" disposable
    | ToggleToolButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToggleToolButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToggleToolButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToggleToolButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToggleToolButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToggleToolButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToggleToolButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToggleToolButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToggleToolButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToggleToolButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToggleToolButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToggleToolButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToggleToolButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToggleToolButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToggleToolButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToggleToolButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToggleToolButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToggleToolButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToggleToolButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToggleToolButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToggleToolButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToggleToolButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToggleToolButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToggleToolButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToggleToolButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToggleToolButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToggleToolButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToggleToolButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToggleToolButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToggleToolButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToggleToolButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToggleToolButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToggleToolButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToggleToolButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToggleToolButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToggleToolButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToggleToolButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToggleToolButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToggleToolButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToggleToolButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToggleToolButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToggleToolButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToggleToolButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToggleToolButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToggleToolButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToggleToolButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToggleToolButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToggleToolButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToggleToolButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToggleToolButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToggleToolButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToggleToolButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToggleToolButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToggleToolButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToggleToolButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToggleToolButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToggleToolButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToggleToolButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToggleToolButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToggleToolButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToggleToolButtonPropertyBuilder() =
    inherit BasePropertyBuilder<ToggleToolButtonProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.Active value } 
    [<CustomOperation("label")>]
    member this.Label(it: ToggleToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleToolButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.UseUnderline value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: ToggleToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToggleToolButtonProperty.LabelWidget value } 
    [<Obsolete>]
    [<CustomOperation("stockId")>]
    member this.StockId(it: ToggleToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleToolButtonProperty.StockId value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ToggleToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleToolButtonProperty.IconName value } 
    [<CustomOperation("iconWidget")>]
    member this.IconWidget(it: ToggleToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToggleToolButtonProperty.IconWidget value } 
    [<CustomOperation("iconSpacing")>]
    member this.IconSpacing(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.IconSpacing value } 
    [<CustomOperation("visibleHorizontal")>]
    member this.VisibleHorizontal(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.VisibleHorizontal value } 
    [<CustomOperation("visibleVertical")>]
    member this.VisibleVertical(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.VisibleVertical value } 
    [<CustomOperation("isImportant")>]
    member this.IsImportant(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.IsImportant value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ToggleToolButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ToggleToolButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToggleToolButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToggleToolButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToggleToolButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToggleToolButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToggleToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleToolButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToggleToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToggleToolButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ToggleToolButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ToggleToolButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToggleToolButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToggleToolButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToggleToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleToolButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToggleToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleToolButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToggleToolButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToggleToolButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToggleToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToggleToolButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToggleToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToggleToolButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToggleToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleToolButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToggleToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleToolButtonProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToggleToolButtonProperty seq, value: System.Double) =
        seq { yield! it; yield ToggleToolButtonProperty.Opacity value } 
    [<CustomOperation("onCreateMenuProxy")>]
    member this.OnCreateMenuProxy(it: ToggleToolButtonProperty seq, value: Gtk.CreateMenuProxyArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnCreateMenuProxy value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToggleToolButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToggleToolButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToggleToolButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToggleToolButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToggleToolButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToggleToolButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToggleToolButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToggleToolButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToggleToolButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToggleToolButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToggleToolButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToggleToolButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToggleToolButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToggleToolButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToggleToolButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToggleToolButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToggleToolButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToggleToolButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToggleToolButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToggleToolButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToggleToolButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToggleToolButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToggleToolButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToggleToolButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToggleToolButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToggleToolButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToggleToolButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToggleToolButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToggleToolButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToggleToolButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToggleToolButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToggleToolButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToggleToolButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToggleToolButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToggleToolButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToggleToolButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToggleToolButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToggleToolButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToggleToolButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToggleToolButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToggleToolButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToggleToolButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToggleToolButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToggleToolButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToggleToolButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToggleToolButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToggleToolButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToggleToolButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToggleToolButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToggleToolButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToggleToolButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToggleToolButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToggleToolButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToggleToolButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToggleToolButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToggleToolButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToggleToolButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToggleToolButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToggleToolButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToggleToolButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToggleToolButtonProperty.OnFocused value } 

let prop = ToggleToolButtonPropertyBuilder()

type ToggleToolButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<ToggleToolButton, ToggleToolButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new ToggleToolButton()

let toggleToolButton props = ToggleToolButtonDescriptor(props)

