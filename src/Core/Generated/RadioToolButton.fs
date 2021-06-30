module GtkDsl.Binding.RadioToolButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RadioToolButtonProperty =
    | Group of Gtk.RadioToolButton[]
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

let bindProperty (widget: RadioToolButton) (prop: RadioToolButtonProperty) =
    match prop with
    | RadioToolButtonProperty.Group value -> widget.Group <- value
    | RadioToolButtonProperty.Active value -> widget.Active <- value
    | RadioToolButtonProperty.Label value -> widget.Label <- value
    | RadioToolButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | RadioToolButtonProperty.LabelWidget value -> widget.LabelWidget <- value
    | RadioToolButtonProperty.StockId value -> widget.StockId <- value
    | RadioToolButtonProperty.IconName value -> widget.IconName <- value
    | RadioToolButtonProperty.IconWidget value -> widget.IconWidget <- value
    | RadioToolButtonProperty.IconSpacing value -> widget.IconSpacing <- value
    | RadioToolButtonProperty.VisibleHorizontal value -> widget.VisibleHorizontal <- value
    | RadioToolButtonProperty.VisibleVertical value -> widget.VisibleVertical <- value
    | RadioToolButtonProperty.IsImportant value -> widget.IsImportant <- value
    | RadioToolButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | RadioToolButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | RadioToolButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | RadioToolButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | RadioToolButtonProperty.Name value -> widget.Name <- value
    | RadioToolButtonProperty.Parent value -> widget.Parent <- value
    | RadioToolButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | RadioToolButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | RadioToolButtonProperty.Visible value -> widget.Visible <- value
    | RadioToolButtonProperty.Sensitive value -> widget.Sensitive <- value
    | RadioToolButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | RadioToolButtonProperty.CanFocus value -> widget.CanFocus <- value
    | RadioToolButtonProperty.HasFocus value -> widget.HasFocus <- value
    | RadioToolButtonProperty.IsFocus value -> widget.IsFocus <- value
    | RadioToolButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RadioToolButtonProperty.CanDefault value -> widget.CanDefault <- value
    | RadioToolButtonProperty.HasDefault value -> widget.HasDefault <- value
    | RadioToolButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RadioToolButtonProperty.Style value -> widget.Style <- value
    | RadioToolButtonProperty.Events value -> widget.Events <- value
    | RadioToolButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | RadioToolButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | RadioToolButtonProperty.TooltipText value -> widget.TooltipText <- value
    | RadioToolButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RadioToolButtonProperty.Window value -> widget.Window <- value
    | RadioToolButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RadioToolButtonProperty.Halign value -> widget.Halign <- value
    | RadioToolButtonProperty.Valign value -> widget.Valign <- value
    | RadioToolButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | RadioToolButtonProperty.MarginRight value -> widget.MarginRight <- value
    | RadioToolButtonProperty.MarginStart value -> widget.MarginStart <- value
    | RadioToolButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | RadioToolButtonProperty.MarginTop value -> widget.MarginTop <- value
    | RadioToolButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | RadioToolButtonProperty.Margin value -> widget.Margin <- value
    | RadioToolButtonProperty.Hexpand value -> widget.Hexpand <- value
    | RadioToolButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | RadioToolButtonProperty.Vexpand value -> widget.Vexpand <- value
    | RadioToolButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | RadioToolButtonProperty.Opacity value -> widget.Opacity <- value
    | RadioToolButtonProperty.OnCreateMenuProxy handler -> 
        let disposable = widget.CreateMenuProxy.Subscribe(handler)
        registerListener widget "CreateMenuProxy" disposable
    | RadioToolButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RadioToolButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RadioToolButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RadioToolButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RadioToolButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RadioToolButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RadioToolButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RadioToolButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RadioToolButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RadioToolButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RadioToolButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RadioToolButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RadioToolButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RadioToolButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RadioToolButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RadioToolButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RadioToolButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RadioToolButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RadioToolButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RadioToolButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RadioToolButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RadioToolButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RadioToolButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RadioToolButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RadioToolButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RadioToolButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RadioToolButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RadioToolButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RadioToolButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RadioToolButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RadioToolButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RadioToolButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RadioToolButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RadioToolButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RadioToolButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RadioToolButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RadioToolButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RadioToolButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RadioToolButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RadioToolButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RadioToolButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RadioToolButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RadioToolButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RadioToolButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RadioToolButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RadioToolButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RadioToolButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RadioToolButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RadioToolButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RadioToolButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RadioToolButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RadioToolButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RadioToolButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RadioToolButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RadioToolButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RadioToolButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RadioToolButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RadioToolButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RadioToolButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RadioToolButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RadioToolButtonPropertyBuilder() =
    inherit BasePropertyBuilder<RadioToolButtonProperty>()
    [<CustomOperation("group")>]
    member this.Group(it: RadioToolButtonProperty seq, value: Gtk.RadioToolButton[]) =
        seq { yield! it; yield RadioToolButtonProperty.Group value } 
    [<CustomOperation("active")>]
    member this.Active(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.Active value } 
    [<CustomOperation("label")>]
    member this.Label(it: RadioToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioToolButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.UseUnderline value } 
    [<CustomOperation("labelWidget")>]
    member this.LabelWidget(it: RadioToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioToolButtonProperty.LabelWidget value } 
    [<Obsolete>]
    [<CustomOperation("stockId")>]
    member this.StockId(it: RadioToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioToolButtonProperty.StockId value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: RadioToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioToolButtonProperty.IconName value } 
    [<CustomOperation("iconWidget")>]
    member this.IconWidget(it: RadioToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioToolButtonProperty.IconWidget value } 
    [<CustomOperation("iconSpacing")>]
    member this.IconSpacing(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.IconSpacing value } 
    [<CustomOperation("visibleHorizontal")>]
    member this.VisibleHorizontal(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.VisibleHorizontal value } 
    [<CustomOperation("visibleVertical")>]
    member this.VisibleVertical(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.VisibleVertical value } 
    [<CustomOperation("isImportant")>]
    member this.IsImportant(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.IsImportant value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: RadioToolButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield RadioToolButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RadioToolButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RadioToolButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RadioToolButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield RadioToolButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RadioToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioToolButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RadioToolButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioToolButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RadioToolButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RadioToolButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RadioToolButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RadioToolButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RadioToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioToolButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RadioToolButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioToolButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RadioToolButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RadioToolButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RadioToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RadioToolButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RadioToolButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RadioToolButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RadioToolButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioToolButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RadioToolButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioToolButtonProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RadioToolButtonProperty seq, value: System.Double) =
        seq { yield! it; yield RadioToolButtonProperty.Opacity value } 
    [<CustomOperation("onCreateMenuProxy")>]
    member this.OnCreateMenuProxy(it: RadioToolButtonProperty seq, value: Gtk.CreateMenuProxyArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnCreateMenuProxy value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RadioToolButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RadioToolButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RadioToolButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RadioToolButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RadioToolButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RadioToolButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RadioToolButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RadioToolButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RadioToolButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RadioToolButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RadioToolButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RadioToolButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RadioToolButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RadioToolButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RadioToolButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RadioToolButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RadioToolButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RadioToolButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RadioToolButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RadioToolButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RadioToolButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RadioToolButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RadioToolButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RadioToolButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RadioToolButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RadioToolButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RadioToolButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RadioToolButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RadioToolButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RadioToolButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RadioToolButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RadioToolButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RadioToolButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RadioToolButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RadioToolButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RadioToolButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RadioToolButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RadioToolButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RadioToolButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RadioToolButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RadioToolButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RadioToolButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RadioToolButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RadioToolButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RadioToolButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RadioToolButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RadioToolButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RadioToolButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RadioToolButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RadioToolButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RadioToolButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RadioToolButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RadioToolButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RadioToolButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RadioToolButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RadioToolButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RadioToolButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RadioToolButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RadioToolButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RadioToolButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RadioToolButtonProperty.OnFocused value } 

let prop = RadioToolButtonPropertyBuilder()

