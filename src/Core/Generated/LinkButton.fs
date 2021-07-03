module Gtk.DSL.Binding.LinkButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type LinkButtonProperty =
    | Uri of System.String
    | Visited of System.Boolean
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
    |  OnActivateLink of (Gtk.ActivateLinkArgs -> unit)
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

let bindProperty (widget: LinkButton) (prop: LinkButtonProperty) =
    match prop with
    | LinkButtonProperty.Uri value -> widget.Uri <- value
    | LinkButtonProperty.Visited value -> widget.Visited <- value
    | LinkButtonProperty.Label value -> widget.Label <- value
    | LinkButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | LinkButtonProperty.UseStock value -> widget.UseStock <- value
    | LinkButtonProperty.Relief value -> widget.Relief <- value
    | LinkButtonProperty.Xalign value -> widget.Xalign <- value
    | LinkButtonProperty.Yalign value -> widget.Yalign <- value
    | LinkButtonProperty.Image value -> widget.Image <- value
    | LinkButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | LinkButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | LinkButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | LinkButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | LinkButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | LinkButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | LinkButtonProperty.Name value -> widget.Name <- value
    | LinkButtonProperty.Parent value -> widget.Parent <- value
    | LinkButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | LinkButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | LinkButtonProperty.Visible value -> widget.Visible <- value
    | LinkButtonProperty.Sensitive value -> widget.Sensitive <- value
    | LinkButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | LinkButtonProperty.CanFocus value -> widget.CanFocus <- value
    | LinkButtonProperty.HasFocus value -> widget.HasFocus <- value
    | LinkButtonProperty.IsFocus value -> widget.IsFocus <- value
    | LinkButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | LinkButtonProperty.CanDefault value -> widget.CanDefault <- value
    | LinkButtonProperty.HasDefault value -> widget.HasDefault <- value
    | LinkButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | LinkButtonProperty.Style value -> widget.Style <- value
    | LinkButtonProperty.Events value -> widget.Events <- value
    | LinkButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | LinkButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | LinkButtonProperty.TooltipText value -> widget.TooltipText <- value
    | LinkButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | LinkButtonProperty.Window value -> widget.Window <- value
    | LinkButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | LinkButtonProperty.Halign value -> widget.Halign <- value
    | LinkButtonProperty.Valign value -> widget.Valign <- value
    | LinkButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | LinkButtonProperty.MarginRight value -> widget.MarginRight <- value
    | LinkButtonProperty.MarginStart value -> widget.MarginStart <- value
    | LinkButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | LinkButtonProperty.MarginTop value -> widget.MarginTop <- value
    | LinkButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | LinkButtonProperty.Margin value -> widget.Margin <- value
    | LinkButtonProperty.Hexpand value -> widget.Hexpand <- value
    | LinkButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | LinkButtonProperty.Vexpand value -> widget.Vexpand <- value
    | LinkButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | LinkButtonProperty.Expand value -> widget.Expand <- value
    | LinkButtonProperty.Opacity value -> widget.Opacity <- value
    | LinkButtonProperty.OnActivateLink handler -> 
        let disposable = widget.ActivateLink.Subscribe(handler)
        registerListener widget "ActivateLink" disposable
    | LinkButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | LinkButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | LinkButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | LinkButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | LinkButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | LinkButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | LinkButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | LinkButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | LinkButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | LinkButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | LinkButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | LinkButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | LinkButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | LinkButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | LinkButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | LinkButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | LinkButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | LinkButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | LinkButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | LinkButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | LinkButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | LinkButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | LinkButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | LinkButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | LinkButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | LinkButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | LinkButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | LinkButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | LinkButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | LinkButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | LinkButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | LinkButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | LinkButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | LinkButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | LinkButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | LinkButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | LinkButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | LinkButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | LinkButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | LinkButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | LinkButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | LinkButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | LinkButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | LinkButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | LinkButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | LinkButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | LinkButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | LinkButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | LinkButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | LinkButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | LinkButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | LinkButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | LinkButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | LinkButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | LinkButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | LinkButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | LinkButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | LinkButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | LinkButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | LinkButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type LinkButtonPropertyBuilder() =
    inherit BasePropertyBuilder<LinkButtonProperty>()
    [<CustomOperation("uri")>]
    member this.Uri(it: LinkButtonProperty seq, value: System.String) =
        seq { yield! it; yield LinkButtonProperty.Uri value } 
    [<CustomOperation("visited")>]
    member this.Visited(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.Visited value } 
    [<CustomOperation("label")>]
    member this.Label(it: LinkButtonProperty seq, value: System.String) =
        seq { yield! it; yield LinkButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: LinkButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield LinkButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: LinkButtonProperty seq, value: System.Single) =
        seq { yield! it; yield LinkButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: LinkButtonProperty seq, value: System.Single) =
        seq { yield! it; yield LinkButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: LinkButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield LinkButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: LinkButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield LinkButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: LinkButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield LinkButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: LinkButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield LinkButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: LinkButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield LinkButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: LinkButtonProperty seq, value: System.String) =
        seq { yield! it; yield LinkButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: LinkButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield LinkButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: LinkButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield LinkButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: LinkButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield LinkButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: LinkButtonProperty seq, value: System.String) =
        seq { yield! it; yield LinkButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: LinkButtonProperty seq, value: System.String) =
        seq { yield! it; yield LinkButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: LinkButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield LinkButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: LinkButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LinkButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: LinkButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LinkButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: LinkButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield LinkButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: LinkButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield LinkButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: LinkButtonProperty seq, value: System.Double) =
        seq { yield! it; yield LinkButtonProperty.Opacity value } 
    [<CustomOperation("onActivateLink")>]
    member this.OnActivateLink(it: LinkButtonProperty seq, value: Gtk.ActivateLinkArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnActivateLink value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: LinkButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: LinkButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: LinkButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: LinkButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: LinkButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: LinkButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: LinkButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: LinkButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: LinkButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: LinkButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: LinkButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: LinkButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: LinkButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: LinkButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: LinkButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: LinkButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: LinkButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: LinkButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: LinkButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: LinkButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: LinkButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: LinkButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: LinkButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: LinkButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: LinkButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: LinkButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: LinkButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: LinkButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: LinkButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: LinkButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: LinkButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: LinkButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: LinkButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: LinkButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: LinkButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: LinkButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: LinkButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: LinkButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: LinkButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: LinkButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: LinkButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: LinkButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: LinkButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: LinkButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: LinkButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: LinkButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: LinkButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: LinkButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: LinkButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: LinkButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: LinkButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: LinkButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: LinkButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: LinkButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: LinkButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: LinkButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: LinkButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: LinkButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: LinkButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: LinkButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield LinkButtonProperty.OnFocused value } 

let prop = LinkButtonPropertyBuilder()

