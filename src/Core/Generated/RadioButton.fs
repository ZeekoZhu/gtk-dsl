module GtkDsl.Binding.RadioButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RadioButtonProperty =
    | Group of Gtk.RadioButton[]
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

let bindProperty (widget: RadioButton) (prop: RadioButtonProperty) =
    match prop with
    | RadioButtonProperty.Group value -> widget.Group <- value
    | RadioButtonProperty.Active value -> widget.Active <- value
    | RadioButtonProperty.Inconsistent value -> widget.Inconsistent <- value
    | RadioButtonProperty.DrawIndicator value -> widget.DrawIndicator <- value
    | RadioButtonProperty.Label value -> widget.Label <- value
    | RadioButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | RadioButtonProperty.UseStock value -> widget.UseStock <- value
    | RadioButtonProperty.Relief value -> widget.Relief <- value
    | RadioButtonProperty.Xalign value -> widget.Xalign <- value
    | RadioButtonProperty.Yalign value -> widget.Yalign <- value
    | RadioButtonProperty.Image value -> widget.Image <- value
    | RadioButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | RadioButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | RadioButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | RadioButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | RadioButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | RadioButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | RadioButtonProperty.Name value -> widget.Name <- value
    | RadioButtonProperty.Parent value -> widget.Parent <- value
    | RadioButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | RadioButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | RadioButtonProperty.Visible value -> widget.Visible <- value
    | RadioButtonProperty.Sensitive value -> widget.Sensitive <- value
    | RadioButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | RadioButtonProperty.CanFocus value -> widget.CanFocus <- value
    | RadioButtonProperty.HasFocus value -> widget.HasFocus <- value
    | RadioButtonProperty.IsFocus value -> widget.IsFocus <- value
    | RadioButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RadioButtonProperty.CanDefault value -> widget.CanDefault <- value
    | RadioButtonProperty.HasDefault value -> widget.HasDefault <- value
    | RadioButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RadioButtonProperty.Style value -> widget.Style <- value
    | RadioButtonProperty.Events value -> widget.Events <- value
    | RadioButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | RadioButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | RadioButtonProperty.TooltipText value -> widget.TooltipText <- value
    | RadioButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RadioButtonProperty.Window value -> widget.Window <- value
    | RadioButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RadioButtonProperty.Halign value -> widget.Halign <- value
    | RadioButtonProperty.Valign value -> widget.Valign <- value
    | RadioButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | RadioButtonProperty.MarginRight value -> widget.MarginRight <- value
    | RadioButtonProperty.MarginStart value -> widget.MarginStart <- value
    | RadioButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | RadioButtonProperty.MarginTop value -> widget.MarginTop <- value
    | RadioButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | RadioButtonProperty.Margin value -> widget.Margin <- value
    | RadioButtonProperty.Hexpand value -> widget.Hexpand <- value
    | RadioButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | RadioButtonProperty.Vexpand value -> widget.Vexpand <- value
    | RadioButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | RadioButtonProperty.Expand value -> widget.Expand <- value
    | RadioButtonProperty.Opacity value -> widget.Opacity <- value
    | RadioButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RadioButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RadioButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RadioButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RadioButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RadioButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RadioButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RadioButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RadioButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RadioButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RadioButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RadioButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RadioButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RadioButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RadioButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RadioButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RadioButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RadioButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RadioButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RadioButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RadioButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RadioButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RadioButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RadioButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RadioButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RadioButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RadioButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RadioButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RadioButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RadioButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RadioButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RadioButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RadioButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RadioButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RadioButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RadioButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RadioButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RadioButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RadioButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RadioButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RadioButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RadioButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RadioButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RadioButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RadioButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RadioButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RadioButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RadioButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RadioButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RadioButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RadioButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RadioButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RadioButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RadioButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RadioButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RadioButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RadioButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RadioButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RadioButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RadioButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RadioButtonPropertyBuilder() =
    inherit BasePropertyBuilder<RadioButtonProperty>()
    [<CustomOperation("group")>]
    member this.Group(it: RadioButtonProperty seq, value: Gtk.RadioButton[]) =
        seq { yield! it; yield RadioButtonProperty.Group value } 
    [<CustomOperation("active")>]
    member this.Active(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Active value } 
    [<CustomOperation("inconsistent")>]
    member this.Inconsistent(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Inconsistent value } 
    [<CustomOperation("drawIndicator")>]
    member this.DrawIndicator(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.DrawIndicator value } 
    [<CustomOperation("label")>]
    member this.Label(it: RadioButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: RadioButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield RadioButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: RadioButtonProperty seq, value: System.Single) =
        seq { yield! it; yield RadioButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: RadioButtonProperty seq, value: System.Single) =
        seq { yield! it; yield RadioButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: RadioButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: RadioButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield RadioButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: RadioButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield RadioButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RadioButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RadioButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RadioButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield RadioButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RadioButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RadioButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RadioButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RadioButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RadioButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RadioButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RadioButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RadioButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RadioButtonProperty seq, value: System.String) =
        seq { yield! it; yield RadioButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RadioButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RadioButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RadioButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RadioButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RadioButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RadioButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RadioButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield RadioButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RadioButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield RadioButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RadioButtonProperty seq, value: System.Double) =
        seq { yield! it; yield RadioButtonProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RadioButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RadioButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RadioButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RadioButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RadioButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RadioButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RadioButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RadioButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RadioButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RadioButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RadioButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RadioButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RadioButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RadioButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RadioButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RadioButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RadioButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RadioButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RadioButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RadioButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RadioButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RadioButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RadioButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RadioButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RadioButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RadioButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RadioButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RadioButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RadioButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RadioButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RadioButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RadioButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RadioButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RadioButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RadioButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RadioButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RadioButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RadioButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RadioButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RadioButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RadioButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RadioButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RadioButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RadioButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RadioButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RadioButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RadioButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RadioButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RadioButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RadioButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RadioButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RadioButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RadioButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RadioButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RadioButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RadioButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RadioButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RadioButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RadioButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RadioButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RadioButtonProperty.OnFocused value } 

let prop = RadioButtonPropertyBuilder()

