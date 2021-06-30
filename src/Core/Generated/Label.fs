module GtkDsl.Binding.Label
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type LabelProperty =
    | LabelProp of System.String
    | Attributes of Pango.AttrList
    | UseMarkup of System.Boolean
    | UseUnderline of System.Boolean
    | Justify of Gtk.Justification
    | Xalign of System.Single
    | Yalign of System.Single
    | Wrap of System.Boolean
    | LineWrapMode of Pango.WrapMode
    | Selectable of System.Boolean
    | MnemonicWidget of Gtk.Widget
    | Ellipsize of Pango.EllipsizeMode
    | WidthChars of System.Int32
    | SingleLineMode of System.Boolean
    | Angle of System.Double
    | MaxWidthChars of System.Int32
    | TrackVisitedLinks of System.Boolean
    | Lines of System.Int32
    | Xpad of System.Int32
    | Ypad of System.Int32
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
    |  OnMoveCursor of (Gtk.MoveCursorArgs -> unit)
    |  OnActivateLink of (Gtk.ActivateLinkArgs -> unit)
    |  OnPopulatePopup of (Gtk.PopulatePopupArgs -> unit)
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

let bindProperty (widget: Label) (prop: LabelProperty) =
    match prop with
    | LabelProperty.LabelProp value -> widget.LabelProp <- value
    | LabelProperty.Attributes value -> widget.Attributes <- value
    | LabelProperty.UseMarkup value -> widget.UseMarkup <- value
    | LabelProperty.UseUnderline value -> widget.UseUnderline <- value
    | LabelProperty.Justify value -> widget.Justify <- value
    | LabelProperty.Xalign value -> widget.Xalign <- value
    | LabelProperty.Yalign value -> widget.Yalign <- value
    | LabelProperty.Wrap value -> widget.Wrap <- value
    | LabelProperty.LineWrapMode value -> widget.LineWrapMode <- value
    | LabelProperty.Selectable value -> widget.Selectable <- value
    | LabelProperty.MnemonicWidget value -> widget.MnemonicWidget <- value
    | LabelProperty.Ellipsize value -> widget.Ellipsize <- value
    | LabelProperty.WidthChars value -> widget.WidthChars <- value
    | LabelProperty.SingleLineMode value -> widget.SingleLineMode <- value
    | LabelProperty.Angle value -> widget.Angle <- value
    | LabelProperty.MaxWidthChars value -> widget.MaxWidthChars <- value
    | LabelProperty.TrackVisitedLinks value -> widget.TrackVisitedLinks <- value
    | LabelProperty.Lines value -> widget.Lines <- value
    | LabelProperty.Xpad value -> widget.Xpad <- value
    | LabelProperty.Ypad value -> widget.Ypad <- value
    | LabelProperty.Name value -> widget.Name <- value
    | LabelProperty.Parent value -> widget.Parent <- value
    | LabelProperty.WidthRequest value -> widget.WidthRequest <- value
    | LabelProperty.HeightRequest value -> widget.HeightRequest <- value
    | LabelProperty.Visible value -> widget.Visible <- value
    | LabelProperty.Sensitive value -> widget.Sensitive <- value
    | LabelProperty.AppPaintable value -> widget.AppPaintable <- value
    | LabelProperty.CanFocus value -> widget.CanFocus <- value
    | LabelProperty.HasFocus value -> widget.HasFocus <- value
    | LabelProperty.IsFocus value -> widget.IsFocus <- value
    | LabelProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | LabelProperty.CanDefault value -> widget.CanDefault <- value
    | LabelProperty.HasDefault value -> widget.HasDefault <- value
    | LabelProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | LabelProperty.Style value -> widget.Style <- value
    | LabelProperty.Events value -> widget.Events <- value
    | LabelProperty.NoShowAll value -> widget.NoShowAll <- value
    | LabelProperty.HasTooltip value -> widget.HasTooltip <- value
    | LabelProperty.TooltipText value -> widget.TooltipText <- value
    | LabelProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | LabelProperty.Window value -> widget.Window <- value
    | LabelProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | LabelProperty.Halign value -> widget.Halign <- value
    | LabelProperty.Valign value -> widget.Valign <- value
    | LabelProperty.MarginLeft value -> widget.MarginLeft <- value
    | LabelProperty.MarginRight value -> widget.MarginRight <- value
    | LabelProperty.MarginStart value -> widget.MarginStart <- value
    | LabelProperty.MarginEnd value -> widget.MarginEnd <- value
    | LabelProperty.MarginTop value -> widget.MarginTop <- value
    | LabelProperty.MarginBottom value -> widget.MarginBottom <- value
    | LabelProperty.Margin value -> widget.Margin <- value
    | LabelProperty.Hexpand value -> widget.Hexpand <- value
    | LabelProperty.HexpandSet value -> widget.HexpandSet <- value
    | LabelProperty.Vexpand value -> widget.Vexpand <- value
    | LabelProperty.VexpandSet value -> widget.VexpandSet <- value
    | LabelProperty.Expand value -> widget.Expand <- value
    | LabelProperty.Opacity value -> widget.Opacity <- value
    | LabelProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | LabelProperty.OnActivateLink handler -> 
        let disposable = widget.ActivateLink.Subscribe(handler)
        registerListener widget "ActivateLink" disposable
    | LabelProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | LabelProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | LabelProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | LabelProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | LabelProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | LabelProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | LabelProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | LabelProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | LabelProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | LabelProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | LabelProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | LabelProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | LabelProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | LabelProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | LabelProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | LabelProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | LabelProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | LabelProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | LabelProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | LabelProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | LabelProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | LabelProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | LabelProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | LabelProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | LabelProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | LabelProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | LabelProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | LabelProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | LabelProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | LabelProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | LabelProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | LabelProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | LabelProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | LabelProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | LabelProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | LabelProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | LabelProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | LabelProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | LabelProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | LabelProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | LabelProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | LabelProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | LabelProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | LabelProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | LabelProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | LabelProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | LabelProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | LabelProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | LabelProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | LabelProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | LabelProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | LabelProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | LabelProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | LabelProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | LabelProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | LabelProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | LabelProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | LabelProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type LabelPropertyBuilder() =
    inherit BasePropertyBuilder<LabelProperty>()
    [<CustomOperation("labelProp")>]
    member this.LabelProp(it: LabelProperty seq, value: System.String) =
        seq { yield! it; yield LabelProperty.LabelProp value } 
    [<CustomOperation("attributes")>]
    member this.Attributes(it: LabelProperty seq, value: Pango.AttrList) =
        seq { yield! it; yield LabelProperty.Attributes value } 
    [<CustomOperation("useMarkup")>]
    member this.UseMarkup(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.UseMarkup value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.UseUnderline value } 
    [<CustomOperation("justify")>]
    member this.Justify(it: LabelProperty seq, value: Gtk.Justification) =
        seq { yield! it; yield LabelProperty.Justify value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: LabelProperty seq, value: System.Single) =
        seq { yield! it; yield LabelProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: LabelProperty seq, value: System.Single) =
        seq { yield! it; yield LabelProperty.Yalign value } 
    [<CustomOperation("wrap")>]
    member this.Wrap(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Wrap value } 
    [<CustomOperation("lineWrapMode")>]
    member this.LineWrapMode(it: LabelProperty seq, value: Pango.WrapMode) =
        seq { yield! it; yield LabelProperty.LineWrapMode value } 
    [<CustomOperation("selectable")>]
    member this.Selectable(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Selectable value } 
    [<CustomOperation("mnemonicWidget")>]
    member this.MnemonicWidget(it: LabelProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield LabelProperty.MnemonicWidget value } 
    [<CustomOperation("ellipsize")>]
    member this.Ellipsize(it: LabelProperty seq, value: Pango.EllipsizeMode) =
        seq { yield! it; yield LabelProperty.Ellipsize value } 
    [<CustomOperation("widthChars")>]
    member this.WidthChars(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.WidthChars value } 
    [<CustomOperation("singleLineMode")>]
    member this.SingleLineMode(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.SingleLineMode value } 
    [<CustomOperation("angle")>]
    member this.Angle(it: LabelProperty seq, value: System.Double) =
        seq { yield! it; yield LabelProperty.Angle value } 
    [<CustomOperation("maxWidthChars")>]
    member this.MaxWidthChars(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MaxWidthChars value } 
    [<CustomOperation("trackVisitedLinks")>]
    member this.TrackVisitedLinks(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.TrackVisitedLinks value } 
    [<CustomOperation("lines")>]
    member this.Lines(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.Lines value } 
    [<CustomOperation("xpad")>]
    member this.Xpad(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.Xpad value } 
    [<CustomOperation("ypad")>]
    member this.Ypad(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.Ypad value } 
    [<CustomOperation("name")>]
    member this.Name(it: LabelProperty seq, value: System.String) =
        seq { yield! it; yield LabelProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: LabelProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield LabelProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: LabelProperty seq, value: Gtk.Style) =
        seq { yield! it; yield LabelProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: LabelProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield LabelProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: LabelProperty seq, value: System.String) =
        seq { yield! it; yield LabelProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: LabelProperty seq, value: System.String) =
        seq { yield! it; yield LabelProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: LabelProperty seq, value: Gdk.Window) =
        seq { yield! it; yield LabelProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: LabelProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LabelProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: LabelProperty seq, value: Gtk.Align) =
        seq { yield! it; yield LabelProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: LabelProperty seq, value: System.Int32) =
        seq { yield! it; yield LabelProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: LabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield LabelProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: LabelProperty seq, value: System.Double) =
        seq { yield! it; yield LabelProperty.Opacity value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: LabelProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnMoveCursor value } 
    [<CustomOperation("onActivateLink")>]
    member this.OnActivateLink(it: LabelProperty seq, value: Gtk.ActivateLinkArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnActivateLink value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: LabelProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnPopulatePopup value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: LabelProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: LabelProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: LabelProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: LabelProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: LabelProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: LabelProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: LabelProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: LabelProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: LabelProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: LabelProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: LabelProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: LabelProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: LabelProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: LabelProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: LabelProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: LabelProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: LabelProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: LabelProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: LabelProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: LabelProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: LabelProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: LabelProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: LabelProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: LabelProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: LabelProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: LabelProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: LabelProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: LabelProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: LabelProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: LabelProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: LabelProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: LabelProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: LabelProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: LabelProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: LabelProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: LabelProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: LabelProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: LabelProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: LabelProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: LabelProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: LabelProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: LabelProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: LabelProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: LabelProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: LabelProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: LabelProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: LabelProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: LabelProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: LabelProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: LabelProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: LabelProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: LabelProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: LabelProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: LabelProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: LabelProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: LabelProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: LabelProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield LabelProperty.OnFocused value } 

let prop = LabelPropertyBuilder()

type LabelDescriptor(props) =
    inherit BaseWidgetDescriptor<Label, LabelProperty>(props, bindProperty)
    override this.CreateTyped() = new Label()

let label props = LabelDescriptor(props)

