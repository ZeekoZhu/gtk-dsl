module GtkDsl.Binding.CheckButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type CheckButtonProperty =
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

let bindProperty (widget: CheckButton) (prop: CheckButtonProperty) =
    match prop with
    | CheckButtonProperty.Active value -> widget.Active <- value
    | CheckButtonProperty.Inconsistent value -> widget.Inconsistent <- value
    | CheckButtonProperty.DrawIndicator value -> widget.DrawIndicator <- value
    | CheckButtonProperty.Label value -> widget.Label <- value
    | CheckButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | CheckButtonProperty.UseStock value -> widget.UseStock <- value
    | CheckButtonProperty.Relief value -> widget.Relief <- value
    | CheckButtonProperty.Xalign value -> widget.Xalign <- value
    | CheckButtonProperty.Yalign value -> widget.Yalign <- value
    | CheckButtonProperty.Image value -> widget.Image <- value
    | CheckButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | CheckButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | CheckButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | CheckButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | CheckButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | CheckButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | CheckButtonProperty.Name value -> widget.Name <- value
    | CheckButtonProperty.Parent value -> widget.Parent <- value
    | CheckButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | CheckButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | CheckButtonProperty.Visible value -> widget.Visible <- value
    | CheckButtonProperty.Sensitive value -> widget.Sensitive <- value
    | CheckButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | CheckButtonProperty.CanFocus value -> widget.CanFocus <- value
    | CheckButtonProperty.HasFocus value -> widget.HasFocus <- value
    | CheckButtonProperty.IsFocus value -> widget.IsFocus <- value
    | CheckButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | CheckButtonProperty.CanDefault value -> widget.CanDefault <- value
    | CheckButtonProperty.HasDefault value -> widget.HasDefault <- value
    | CheckButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | CheckButtonProperty.Style value -> widget.Style <- value
    | CheckButtonProperty.Events value -> widget.Events <- value
    | CheckButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | CheckButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | CheckButtonProperty.TooltipText value -> widget.TooltipText <- value
    | CheckButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | CheckButtonProperty.Window value -> widget.Window <- value
    | CheckButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | CheckButtonProperty.Halign value -> widget.Halign <- value
    | CheckButtonProperty.Valign value -> widget.Valign <- value
    | CheckButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | CheckButtonProperty.MarginRight value -> widget.MarginRight <- value
    | CheckButtonProperty.MarginStart value -> widget.MarginStart <- value
    | CheckButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | CheckButtonProperty.MarginTop value -> widget.MarginTop <- value
    | CheckButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | CheckButtonProperty.Margin value -> widget.Margin <- value
    | CheckButtonProperty.Hexpand value -> widget.Hexpand <- value
    | CheckButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | CheckButtonProperty.Vexpand value -> widget.Vexpand <- value
    | CheckButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | CheckButtonProperty.Expand value -> widget.Expand <- value
    | CheckButtonProperty.Opacity value -> widget.Opacity <- value
    | CheckButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | CheckButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | CheckButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | CheckButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | CheckButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | CheckButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | CheckButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | CheckButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | CheckButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | CheckButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | CheckButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | CheckButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | CheckButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | CheckButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | CheckButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | CheckButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | CheckButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | CheckButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | CheckButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | CheckButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | CheckButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | CheckButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | CheckButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | CheckButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | CheckButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | CheckButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | CheckButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | CheckButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | CheckButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | CheckButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | CheckButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | CheckButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | CheckButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | CheckButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | CheckButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | CheckButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | CheckButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | CheckButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | CheckButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | CheckButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | CheckButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | CheckButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | CheckButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | CheckButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | CheckButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | CheckButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | CheckButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | CheckButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | CheckButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | CheckButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | CheckButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | CheckButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | CheckButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | CheckButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | CheckButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | CheckButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | CheckButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | CheckButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | CheckButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | CheckButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type CheckButtonPropertyBuilder() =
    inherit BasePropertyBuilder<CheckButtonProperty>()
    [<CustomOperation("active")>]
    member this.Active(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Active value } 
    [<CustomOperation("inconsistent")>]
    member this.Inconsistent(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Inconsistent value } 
    [<CustomOperation("drawIndicator")>]
    member this.DrawIndicator(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.DrawIndicator value } 
    [<CustomOperation("label")>]
    member this.Label(it: CheckButtonProperty seq, value: System.String) =
        seq { yield! it; yield CheckButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: CheckButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield CheckButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: CheckButtonProperty seq, value: System.Single) =
        seq { yield! it; yield CheckButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: CheckButtonProperty seq, value: System.Single) =
        seq { yield! it; yield CheckButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: CheckButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CheckButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: CheckButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield CheckButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: CheckButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield CheckButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: CheckButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield CheckButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: CheckButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield CheckButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: CheckButtonProperty seq, value: System.String) =
        seq { yield! it; yield CheckButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: CheckButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CheckButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: CheckButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield CheckButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: CheckButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield CheckButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: CheckButtonProperty seq, value: System.String) =
        seq { yield! it; yield CheckButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: CheckButtonProperty seq, value: System.String) =
        seq { yield! it; yield CheckButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: CheckButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield CheckButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: CheckButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CheckButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: CheckButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CheckButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: CheckButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield CheckButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: CheckButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield CheckButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: CheckButtonProperty seq, value: System.Double) =
        seq { yield! it; yield CheckButtonProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: CheckButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: CheckButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: CheckButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: CheckButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: CheckButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: CheckButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: CheckButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: CheckButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: CheckButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: CheckButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: CheckButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: CheckButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: CheckButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: CheckButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: CheckButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: CheckButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: CheckButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: CheckButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: CheckButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: CheckButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: CheckButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: CheckButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: CheckButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: CheckButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: CheckButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: CheckButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: CheckButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: CheckButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: CheckButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: CheckButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: CheckButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: CheckButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: CheckButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: CheckButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: CheckButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: CheckButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: CheckButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: CheckButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: CheckButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: CheckButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: CheckButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: CheckButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: CheckButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: CheckButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: CheckButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: CheckButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: CheckButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: CheckButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: CheckButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: CheckButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: CheckButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: CheckButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: CheckButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: CheckButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: CheckButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: CheckButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: CheckButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: CheckButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: CheckButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: CheckButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield CheckButtonProperty.OnFocused value } 

let prop = CheckButtonPropertyBuilder()

type CheckButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<CheckButton, CheckButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new CheckButton()

let checkButton props = CheckButtonDescriptor(props)

