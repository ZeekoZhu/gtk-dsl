module GtkDsl.Binding.ToggleButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ToggleButtonProperty =
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

let bindProperty (widget: ToggleButton) (prop: ToggleButtonProperty) =
    match prop with
    | ToggleButtonProperty.Active value -> widget.Active <- value
    | ToggleButtonProperty.Inconsistent value -> widget.Inconsistent <- value
    | ToggleButtonProperty.DrawIndicator value -> widget.DrawIndicator <- value
    | ToggleButtonProperty.Label value -> widget.Label <- value
    | ToggleButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | ToggleButtonProperty.UseStock value -> widget.UseStock <- value
    | ToggleButtonProperty.Relief value -> widget.Relief <- value
    | ToggleButtonProperty.Xalign value -> widget.Xalign <- value
    | ToggleButtonProperty.Yalign value -> widget.Yalign <- value
    | ToggleButtonProperty.Image value -> widget.Image <- value
    | ToggleButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | ToggleButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | ToggleButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | ToggleButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ToggleButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | ToggleButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | ToggleButtonProperty.Name value -> widget.Name <- value
    | ToggleButtonProperty.Parent value -> widget.Parent <- value
    | ToggleButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | ToggleButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | ToggleButtonProperty.Visible value -> widget.Visible <- value
    | ToggleButtonProperty.Sensitive value -> widget.Sensitive <- value
    | ToggleButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | ToggleButtonProperty.CanFocus value -> widget.CanFocus <- value
    | ToggleButtonProperty.HasFocus value -> widget.HasFocus <- value
    | ToggleButtonProperty.IsFocus value -> widget.IsFocus <- value
    | ToggleButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ToggleButtonProperty.CanDefault value -> widget.CanDefault <- value
    | ToggleButtonProperty.HasDefault value -> widget.HasDefault <- value
    | ToggleButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ToggleButtonProperty.Style value -> widget.Style <- value
    | ToggleButtonProperty.Events value -> widget.Events <- value
    | ToggleButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | ToggleButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | ToggleButtonProperty.TooltipText value -> widget.TooltipText <- value
    | ToggleButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ToggleButtonProperty.Window value -> widget.Window <- value
    | ToggleButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ToggleButtonProperty.Halign value -> widget.Halign <- value
    | ToggleButtonProperty.Valign value -> widget.Valign <- value
    | ToggleButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | ToggleButtonProperty.MarginRight value -> widget.MarginRight <- value
    | ToggleButtonProperty.MarginStart value -> widget.MarginStart <- value
    | ToggleButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | ToggleButtonProperty.MarginTop value -> widget.MarginTop <- value
    | ToggleButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | ToggleButtonProperty.Margin value -> widget.Margin <- value
    | ToggleButtonProperty.Hexpand value -> widget.Hexpand <- value
    | ToggleButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | ToggleButtonProperty.Vexpand value -> widget.Vexpand <- value
    | ToggleButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | ToggleButtonProperty.Expand value -> widget.Expand <- value
    | ToggleButtonProperty.Opacity value -> widget.Opacity <- value
    | ToggleButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ToggleButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ToggleButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ToggleButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ToggleButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ToggleButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ToggleButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ToggleButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ToggleButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ToggleButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ToggleButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ToggleButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ToggleButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ToggleButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ToggleButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ToggleButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ToggleButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ToggleButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ToggleButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ToggleButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ToggleButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ToggleButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ToggleButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ToggleButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ToggleButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ToggleButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ToggleButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ToggleButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ToggleButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ToggleButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ToggleButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ToggleButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ToggleButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ToggleButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ToggleButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ToggleButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ToggleButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ToggleButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ToggleButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ToggleButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ToggleButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ToggleButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ToggleButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ToggleButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ToggleButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ToggleButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ToggleButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ToggleButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ToggleButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ToggleButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ToggleButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ToggleButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ToggleButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ToggleButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ToggleButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ToggleButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ToggleButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ToggleButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ToggleButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ToggleButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ToggleButtonPropertyBuilder() =
    inherit BasePropertyBuilder<ToggleButtonProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Active value } 
    [<CustomOperation("inconsistent")>]
    member this.Inconsistent(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Inconsistent value } 
    [<CustomOperation("drawIndicator")>]
    member this.DrawIndicator(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.DrawIndicator value } 
    [<CustomOperation("label")>]
    member this.Label(it: ToggleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: ToggleButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield ToggleButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: ToggleButtonProperty seq, value: System.Single) =
        seq { yield! it; yield ToggleButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: ToggleButtonProperty seq, value: System.Single) =
        seq { yield! it; yield ToggleButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: ToggleButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToggleButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: ToggleButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield ToggleButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ToggleButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ToggleButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ToggleButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ToggleButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ToggleButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield ToggleButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ToggleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ToggleButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ToggleButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ToggleButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ToggleButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ToggleButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ToggleButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ToggleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ToggleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ToggleButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ToggleButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ToggleButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ToggleButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToggleButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ToggleButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ToggleButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ToggleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ToggleButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ToggleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ToggleButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ToggleButtonProperty seq, value: System.Double) =
        seq { yield! it; yield ToggleButtonProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ToggleButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ToggleButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ToggleButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ToggleButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ToggleButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ToggleButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ToggleButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ToggleButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ToggleButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ToggleButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ToggleButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ToggleButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ToggleButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ToggleButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ToggleButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ToggleButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ToggleButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ToggleButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ToggleButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ToggleButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ToggleButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ToggleButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ToggleButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ToggleButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ToggleButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ToggleButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ToggleButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ToggleButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ToggleButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ToggleButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ToggleButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ToggleButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ToggleButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ToggleButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ToggleButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ToggleButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ToggleButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ToggleButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ToggleButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ToggleButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ToggleButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ToggleButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ToggleButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ToggleButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ToggleButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ToggleButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ToggleButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ToggleButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ToggleButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ToggleButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ToggleButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ToggleButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ToggleButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ToggleButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ToggleButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ToggleButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ToggleButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ToggleButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ToggleButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ToggleButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ToggleButtonProperty.OnFocused value } 

let prop = ToggleButtonPropertyBuilder()

type ToggleButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<ToggleButton, ToggleButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new ToggleButton()

let toggleButton props = ToggleButtonDescriptor(props)

