module GtkDsl.Binding.MenuButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuButtonProperty =
    | Popup of Gtk.Menu
    | MenuModel of GLib.MenuModel
    | AlignWidget of Gtk.Widget
    | Direction of Gtk.ArrowType
    | UsePopover of System.Boolean
    | Popover of Gtk.Popover
    | Active of System.Boolean
    | Inconsistent of System.Boolean
    | DrawIndicator of System.Boolean
    | Label of System.String
    | UseUnderline of System.Boolean
    | [<Obsolete>] UseStock of System.Boolean
    | Relief of Gtk.ReliefStyle
    | Xalign of System.Single
    | Yalign of System.Single
    | Image of Gtk.Widget
    | ImagePosition of Gtk.PositionType
    | AlwaysShowImage of System.Boolean
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

let bindProperty (widget: MenuButton) (prop: MenuButtonProperty) =
    match prop with
    | MenuButtonProperty.Popup value -> widget.Popup <- value
    | MenuButtonProperty.MenuModel value -> widget.MenuModel <- value
    | MenuButtonProperty.AlignWidget value -> widget.AlignWidget <- value
    | MenuButtonProperty.Direction value -> widget.Direction <- value
    | MenuButtonProperty.UsePopover value -> widget.UsePopover <- value
    | MenuButtonProperty.Popover value -> widget.Popover <- value
    | MenuButtonProperty.Active value -> widget.Active <- value
    | MenuButtonProperty.Inconsistent value -> widget.Inconsistent <- value
    | MenuButtonProperty.DrawIndicator value -> widget.DrawIndicator <- value
    | MenuButtonProperty.Label value -> widget.Label <- value
    | MenuButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | MenuButtonProperty.UseStock value -> widget.UseStock <- value
    | MenuButtonProperty.Relief value -> widget.Relief <- value
    | MenuButtonProperty.Xalign value -> widget.Xalign <- value
    | MenuButtonProperty.Yalign value -> widget.Yalign <- value
    | MenuButtonProperty.Image value -> widget.Image <- value
    | MenuButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | MenuButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | MenuButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | MenuButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | MenuButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuButtonProperty.Name value -> widget.Name <- value
    | MenuButtonProperty.Parent value -> widget.Parent <- value
    | MenuButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuButtonProperty.Visible value -> widget.Visible <- value
    | MenuButtonProperty.Sensitive value -> widget.Sensitive <- value
    | MenuButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuButtonProperty.CanFocus value -> widget.CanFocus <- value
    | MenuButtonProperty.HasFocus value -> widget.HasFocus <- value
    | MenuButtonProperty.IsFocus value -> widget.IsFocus <- value
    | MenuButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuButtonProperty.CanDefault value -> widget.CanDefault <- value
    | MenuButtonProperty.HasDefault value -> widget.HasDefault <- value
    | MenuButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuButtonProperty.Style value -> widget.Style <- value
    | MenuButtonProperty.Events value -> widget.Events <- value
    | MenuButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuButtonProperty.TooltipText value -> widget.TooltipText <- value
    | MenuButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuButtonProperty.Window value -> widget.Window <- value
    | MenuButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuButtonProperty.Halign value -> widget.Halign <- value
    | MenuButtonProperty.Valign value -> widget.Valign <- value
    | MenuButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuButtonProperty.MarginRight value -> widget.MarginRight <- value
    | MenuButtonProperty.MarginStart value -> widget.MarginStart <- value
    | MenuButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuButtonProperty.MarginTop value -> widget.MarginTop <- value
    | MenuButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuButtonProperty.Margin value -> widget.Margin <- value
    | MenuButtonProperty.Hexpand value -> widget.Hexpand <- value
    | MenuButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuButtonProperty.Vexpand value -> widget.Vexpand <- value
    | MenuButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuButtonProperty.Expand value -> widget.Expand <- value
    | MenuButtonProperty.Opacity value -> widget.Opacity <- value
    | MenuButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuButtonPropertyBuilder() =
    inherit BasePropertyBuilder<MenuButtonProperty>()
    [<CustomOperation("popup")>]
    member this.Popup(it: MenuButtonProperty seq, value: Gtk.Menu) =
        seq { yield! it; yield MenuButtonProperty.Popup value } 
    [<CustomOperation("menuModel")>]
    member this.MenuModel(it: MenuButtonProperty seq, value: GLib.MenuModel) =
        seq { yield! it; yield MenuButtonProperty.MenuModel value } 
    [<CustomOperation("alignWidget")>]
    member this.AlignWidget(it: MenuButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuButtonProperty.AlignWidget value } 
    [<CustomOperation("direction")>]
    member this.Direction(it: MenuButtonProperty seq, value: Gtk.ArrowType) =
        seq { yield! it; yield MenuButtonProperty.Direction value } 
    [<CustomOperation("usePopover")>]
    member this.UsePopover(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.UsePopover value } 
    [<CustomOperation("popover")>]
    member this.Popover(it: MenuButtonProperty seq, value: Gtk.Popover) =
        seq { yield! it; yield MenuButtonProperty.Popover value } 
    [<CustomOperation("active")>]
    member this.Active(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Active value } 
    [<CustomOperation("inconsistent")>]
    member this.Inconsistent(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Inconsistent value } 
    [<CustomOperation("drawIndicator")>]
    member this.DrawIndicator(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.DrawIndicator value } 
    [<CustomOperation("label")>]
    member this.Label(it: MenuButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: MenuButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield MenuButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: MenuButtonProperty seq, value: System.Single) =
        seq { yield! it; yield MenuButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: MenuButtonProperty seq, value: System.Single) =
        seq { yield! it; yield MenuButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: MenuButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: MenuButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield MenuButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: MenuButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield MenuButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuButtonProperty seq, value: System.String) =
        seq { yield! it; yield MenuButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MenuButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuButtonProperty seq, value: System.Double) =
        seq { yield! it; yield MenuButtonProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuButtonProperty.OnFocused value } 

let prop = MenuButtonPropertyBuilder()

type MenuButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<MenuButton, MenuButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new MenuButton()

let menuButton props = MenuButtonDescriptor(props)

