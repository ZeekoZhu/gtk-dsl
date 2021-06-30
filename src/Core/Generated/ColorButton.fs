module GtkDsl.Binding.ColorButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ColorButtonProperty =
    | HasAlpha of System.Boolean
    | Title of System.String
    | [<Obsolete>] Color of Gdk.Color
    | [<Obsolete>] Alpha of System.UInt16
    | ShowEditor of System.Boolean
    | Rgba of Gdk.RGBA
    | UseAlpha of System.Boolean
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
    |  OnColorActivated of (Gtk.ColorActivatedArgs -> unit)
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

let bindProperty (widget: ColorButton) (prop: ColorButtonProperty) =
    match prop with
    | ColorButtonProperty.HasAlpha value -> widget.HasAlpha <- value
    | ColorButtonProperty.Title value -> widget.Title <- value
    | ColorButtonProperty.Color value -> widget.Color <- value
    | ColorButtonProperty.Alpha value -> widget.Alpha <- value
    | ColorButtonProperty.ShowEditor value -> widget.ShowEditor <- value
    | ColorButtonProperty.Rgba value -> widget.Rgba <- value
    | ColorButtonProperty.UseAlpha value -> widget.UseAlpha <- value
    | ColorButtonProperty.Label value -> widget.Label <- value
    | ColorButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | ColorButtonProperty.UseStock value -> widget.UseStock <- value
    | ColorButtonProperty.Relief value -> widget.Relief <- value
    | ColorButtonProperty.Xalign value -> widget.Xalign <- value
    | ColorButtonProperty.Yalign value -> widget.Yalign <- value
    | ColorButtonProperty.Image value -> widget.Image <- value
    | ColorButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | ColorButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | ColorButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | ColorButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ColorButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | ColorButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | ColorButtonProperty.Name value -> widget.Name <- value
    | ColorButtonProperty.Parent value -> widget.Parent <- value
    | ColorButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | ColorButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | ColorButtonProperty.Visible value -> widget.Visible <- value
    | ColorButtonProperty.Sensitive value -> widget.Sensitive <- value
    | ColorButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | ColorButtonProperty.CanFocus value -> widget.CanFocus <- value
    | ColorButtonProperty.HasFocus value -> widget.HasFocus <- value
    | ColorButtonProperty.IsFocus value -> widget.IsFocus <- value
    | ColorButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ColorButtonProperty.CanDefault value -> widget.CanDefault <- value
    | ColorButtonProperty.HasDefault value -> widget.HasDefault <- value
    | ColorButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ColorButtonProperty.Style value -> widget.Style <- value
    | ColorButtonProperty.Events value -> widget.Events <- value
    | ColorButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | ColorButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | ColorButtonProperty.TooltipText value -> widget.TooltipText <- value
    | ColorButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ColorButtonProperty.Window value -> widget.Window <- value
    | ColorButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ColorButtonProperty.Halign value -> widget.Halign <- value
    | ColorButtonProperty.Valign value -> widget.Valign <- value
    | ColorButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | ColorButtonProperty.MarginRight value -> widget.MarginRight <- value
    | ColorButtonProperty.MarginStart value -> widget.MarginStart <- value
    | ColorButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | ColorButtonProperty.MarginTop value -> widget.MarginTop <- value
    | ColorButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | ColorButtonProperty.Margin value -> widget.Margin <- value
    | ColorButtonProperty.Hexpand value -> widget.Hexpand <- value
    | ColorButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | ColorButtonProperty.Vexpand value -> widget.Vexpand <- value
    | ColorButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | ColorButtonProperty.Expand value -> widget.Expand <- value
    | ColorButtonProperty.Opacity value -> widget.Opacity <- value
    | ColorButtonProperty.OnColorActivated handler -> 
        let disposable = widget.ColorActivated.Subscribe(handler)
        registerListener widget "ColorActivated" disposable
    | ColorButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ColorButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ColorButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ColorButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ColorButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ColorButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ColorButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ColorButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ColorButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ColorButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ColorButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ColorButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ColorButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ColorButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ColorButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ColorButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ColorButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ColorButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ColorButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ColorButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ColorButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ColorButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ColorButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ColorButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ColorButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ColorButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ColorButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ColorButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ColorButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ColorButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ColorButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ColorButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ColorButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ColorButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ColorButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ColorButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ColorButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ColorButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ColorButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ColorButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ColorButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ColorButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ColorButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ColorButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ColorButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ColorButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ColorButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ColorButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ColorButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ColorButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ColorButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ColorButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ColorButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ColorButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ColorButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ColorButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ColorButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ColorButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ColorButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ColorButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ColorButtonPropertyBuilder() =
    inherit BasePropertyBuilder<ColorButtonProperty>()
    [<CustomOperation("hasAlpha")>]
    member this.HasAlpha(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.HasAlpha value } 
    [<CustomOperation("title")>]
    member this.Title(it: ColorButtonProperty seq, value: System.String) =
        seq { yield! it; yield ColorButtonProperty.Title value } 
    [<Obsolete>]
    [<CustomOperation("color")>]
    member this.Color(it: ColorButtonProperty seq, value: Gdk.Color) =
        seq { yield! it; yield ColorButtonProperty.Color value } 
    [<Obsolete>]
    [<CustomOperation("alpha")>]
    member this.Alpha(it: ColorButtonProperty seq, value: System.UInt16) =
        seq { yield! it; yield ColorButtonProperty.Alpha value } 
    [<CustomOperation("showEditor")>]
    member this.ShowEditor(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.ShowEditor value } 
    [<CustomOperation("rgba")>]
    member this.Rgba(it: ColorButtonProperty seq, value: Gdk.RGBA) =
        seq { yield! it; yield ColorButtonProperty.Rgba value } 
    [<CustomOperation("useAlpha")>]
    member this.UseAlpha(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.UseAlpha value } 
    [<CustomOperation("label")>]
    member this.Label(it: ColorButtonProperty seq, value: System.String) =
        seq { yield! it; yield ColorButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: ColorButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield ColorButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: ColorButtonProperty seq, value: System.Single) =
        seq { yield! it; yield ColorButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: ColorButtonProperty seq, value: System.Single) =
        seq { yield! it; yield ColorButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: ColorButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: ColorButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield ColorButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ColorButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ColorButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ColorButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ColorButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ColorButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ColorButtonProperty seq, value: System.String) =
        seq { yield! it; yield ColorButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ColorButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ColorButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ColorButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ColorButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ColorButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ColorButtonProperty seq, value: System.String) =
        seq { yield! it; yield ColorButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ColorButtonProperty seq, value: System.String) =
        seq { yield! it; yield ColorButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ColorButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ColorButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ColorButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ColorButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ColorButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ColorButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ColorButtonProperty seq, value: System.Double) =
        seq { yield! it; yield ColorButtonProperty.Opacity value } 
    [<CustomOperation("onColorActivated")>]
    member this.OnColorActivated(it: ColorButtonProperty seq, value: Gtk.ColorActivatedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnColorActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ColorButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ColorButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ColorButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ColorButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ColorButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ColorButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ColorButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ColorButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ColorButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ColorButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ColorButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ColorButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ColorButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ColorButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ColorButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ColorButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ColorButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ColorButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ColorButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ColorButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ColorButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ColorButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ColorButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ColorButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ColorButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ColorButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ColorButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ColorButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ColorButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ColorButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ColorButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ColorButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ColorButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ColorButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ColorButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ColorButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ColorButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ColorButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ColorButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ColorButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ColorButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ColorButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ColorButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ColorButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ColorButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ColorButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ColorButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ColorButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ColorButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ColorButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ColorButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ColorButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ColorButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ColorButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ColorButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ColorButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ColorButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ColorButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ColorButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ColorButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ColorButtonProperty.OnFocused value } 

let prop = ColorButtonPropertyBuilder()

type ColorButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<ColorButton, ColorButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new ColorButton()

let colorButton props = ColorButtonDescriptor(props)

