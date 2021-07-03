module Gtk.DSL.Binding.AccelLabel
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AccelLabelProperty =
    | AccelClosure of System.IntPtr
    | AccelWidget of Gtk.Widget
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

let bindProperty (widget: AccelLabel) (prop: AccelLabelProperty) =
    match prop with
    | AccelLabelProperty.AccelClosure value -> widget.AccelClosure <- value
    | AccelLabelProperty.AccelWidget value -> widget.AccelWidget <- value
    | AccelLabelProperty.LabelProp value -> widget.LabelProp <- value
    | AccelLabelProperty.Attributes value -> widget.Attributes <- value
    | AccelLabelProperty.UseMarkup value -> widget.UseMarkup <- value
    | AccelLabelProperty.UseUnderline value -> widget.UseUnderline <- value
    | AccelLabelProperty.Justify value -> widget.Justify <- value
    | AccelLabelProperty.Xalign value -> widget.Xalign <- value
    | AccelLabelProperty.Yalign value -> widget.Yalign <- value
    | AccelLabelProperty.Wrap value -> widget.Wrap <- value
    | AccelLabelProperty.LineWrapMode value -> widget.LineWrapMode <- value
    | AccelLabelProperty.Selectable value -> widget.Selectable <- value
    | AccelLabelProperty.MnemonicWidget value -> widget.MnemonicWidget <- value
    | AccelLabelProperty.Ellipsize value -> widget.Ellipsize <- value
    | AccelLabelProperty.WidthChars value -> widget.WidthChars <- value
    | AccelLabelProperty.SingleLineMode value -> widget.SingleLineMode <- value
    | AccelLabelProperty.Angle value -> widget.Angle <- value
    | AccelLabelProperty.MaxWidthChars value -> widget.MaxWidthChars <- value
    | AccelLabelProperty.TrackVisitedLinks value -> widget.TrackVisitedLinks <- value
    | AccelLabelProperty.Lines value -> widget.Lines <- value
    | AccelLabelProperty.Xpad value -> widget.Xpad <- value
    | AccelLabelProperty.Ypad value -> widget.Ypad <- value
    | AccelLabelProperty.Name value -> widget.Name <- value
    | AccelLabelProperty.Parent value -> widget.Parent <- value
    | AccelLabelProperty.WidthRequest value -> widget.WidthRequest <- value
    | AccelLabelProperty.HeightRequest value -> widget.HeightRequest <- value
    | AccelLabelProperty.Visible value -> widget.Visible <- value
    | AccelLabelProperty.Sensitive value -> widget.Sensitive <- value
    | AccelLabelProperty.AppPaintable value -> widget.AppPaintable <- value
    | AccelLabelProperty.CanFocus value -> widget.CanFocus <- value
    | AccelLabelProperty.HasFocus value -> widget.HasFocus <- value
    | AccelLabelProperty.IsFocus value -> widget.IsFocus <- value
    | AccelLabelProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AccelLabelProperty.CanDefault value -> widget.CanDefault <- value
    | AccelLabelProperty.HasDefault value -> widget.HasDefault <- value
    | AccelLabelProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AccelLabelProperty.Style value -> widget.Style <- value
    | AccelLabelProperty.Events value -> widget.Events <- value
    | AccelLabelProperty.NoShowAll value -> widget.NoShowAll <- value
    | AccelLabelProperty.HasTooltip value -> widget.HasTooltip <- value
    | AccelLabelProperty.TooltipText value -> widget.TooltipText <- value
    | AccelLabelProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AccelLabelProperty.Window value -> widget.Window <- value
    | AccelLabelProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AccelLabelProperty.Halign value -> widget.Halign <- value
    | AccelLabelProperty.Valign value -> widget.Valign <- value
    | AccelLabelProperty.MarginLeft value -> widget.MarginLeft <- value
    | AccelLabelProperty.MarginRight value -> widget.MarginRight <- value
    | AccelLabelProperty.MarginStart value -> widget.MarginStart <- value
    | AccelLabelProperty.MarginEnd value -> widget.MarginEnd <- value
    | AccelLabelProperty.MarginTop value -> widget.MarginTop <- value
    | AccelLabelProperty.MarginBottom value -> widget.MarginBottom <- value
    | AccelLabelProperty.Margin value -> widget.Margin <- value
    | AccelLabelProperty.Hexpand value -> widget.Hexpand <- value
    | AccelLabelProperty.HexpandSet value -> widget.HexpandSet <- value
    | AccelLabelProperty.Vexpand value -> widget.Vexpand <- value
    | AccelLabelProperty.VexpandSet value -> widget.VexpandSet <- value
    | AccelLabelProperty.Expand value -> widget.Expand <- value
    | AccelLabelProperty.Opacity value -> widget.Opacity <- value
    | AccelLabelProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | AccelLabelProperty.OnActivateLink handler -> 
        let disposable = widget.ActivateLink.Subscribe(handler)
        registerListener widget "ActivateLink" disposable
    | AccelLabelProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | AccelLabelProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AccelLabelProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AccelLabelProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AccelLabelProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AccelLabelProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AccelLabelProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AccelLabelProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AccelLabelProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AccelLabelProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AccelLabelProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AccelLabelProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AccelLabelProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AccelLabelProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AccelLabelProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AccelLabelProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AccelLabelProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AccelLabelProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AccelLabelProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AccelLabelProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AccelLabelProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AccelLabelProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AccelLabelProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AccelLabelProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AccelLabelProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AccelLabelProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AccelLabelProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AccelLabelProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AccelLabelProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AccelLabelProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AccelLabelProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AccelLabelProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AccelLabelProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AccelLabelProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AccelLabelProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AccelLabelProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AccelLabelProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AccelLabelProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AccelLabelProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AccelLabelProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AccelLabelProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AccelLabelProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AccelLabelProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AccelLabelProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AccelLabelProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AccelLabelProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AccelLabelProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AccelLabelProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AccelLabelProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AccelLabelProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AccelLabelProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AccelLabelProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AccelLabelProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AccelLabelProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AccelLabelProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AccelLabelProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AccelLabelProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AccelLabelProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AccelLabelPropertyBuilder() =
    inherit BasePropertyBuilder<AccelLabelProperty>()
    [<CustomOperation("accelClosure")>]
    member this.AccelClosure(it: AccelLabelProperty seq, value: System.IntPtr) =
        seq { yield! it; yield AccelLabelProperty.AccelClosure value } 
    [<CustomOperation("accelWidget")>]
    member this.AccelWidget(it: AccelLabelProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AccelLabelProperty.AccelWidget value } 
    [<CustomOperation("labelProp")>]
    member this.LabelProp(it: AccelLabelProperty seq, value: System.String) =
        seq { yield! it; yield AccelLabelProperty.LabelProp value } 
    [<CustomOperation("attributes")>]
    member this.Attributes(it: AccelLabelProperty seq, value: Pango.AttrList) =
        seq { yield! it; yield AccelLabelProperty.Attributes value } 
    [<CustomOperation("useMarkup")>]
    member this.UseMarkup(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.UseMarkup value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.UseUnderline value } 
    [<CustomOperation("justify")>]
    member this.Justify(it: AccelLabelProperty seq, value: Gtk.Justification) =
        seq { yield! it; yield AccelLabelProperty.Justify value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: AccelLabelProperty seq, value: System.Single) =
        seq { yield! it; yield AccelLabelProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: AccelLabelProperty seq, value: System.Single) =
        seq { yield! it; yield AccelLabelProperty.Yalign value } 
    [<CustomOperation("wrap")>]
    member this.Wrap(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Wrap value } 
    [<CustomOperation("lineWrapMode")>]
    member this.LineWrapMode(it: AccelLabelProperty seq, value: Pango.WrapMode) =
        seq { yield! it; yield AccelLabelProperty.LineWrapMode value } 
    [<CustomOperation("selectable")>]
    member this.Selectable(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Selectable value } 
    [<CustomOperation("mnemonicWidget")>]
    member this.MnemonicWidget(it: AccelLabelProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AccelLabelProperty.MnemonicWidget value } 
    [<CustomOperation("ellipsize")>]
    member this.Ellipsize(it: AccelLabelProperty seq, value: Pango.EllipsizeMode) =
        seq { yield! it; yield AccelLabelProperty.Ellipsize value } 
    [<CustomOperation("widthChars")>]
    member this.WidthChars(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.WidthChars value } 
    [<CustomOperation("singleLineMode")>]
    member this.SingleLineMode(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.SingleLineMode value } 
    [<CustomOperation("angle")>]
    member this.Angle(it: AccelLabelProperty seq, value: System.Double) =
        seq { yield! it; yield AccelLabelProperty.Angle value } 
    [<CustomOperation("maxWidthChars")>]
    member this.MaxWidthChars(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MaxWidthChars value } 
    [<CustomOperation("trackVisitedLinks")>]
    member this.TrackVisitedLinks(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.TrackVisitedLinks value } 
    [<CustomOperation("lines")>]
    member this.Lines(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.Lines value } 
    [<CustomOperation("xpad")>]
    member this.Xpad(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.Xpad value } 
    [<CustomOperation("ypad")>]
    member this.Ypad(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.Ypad value } 
    [<CustomOperation("name")>]
    member this.Name(it: AccelLabelProperty seq, value: System.String) =
        seq { yield! it; yield AccelLabelProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AccelLabelProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AccelLabelProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AccelLabelProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AccelLabelProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AccelLabelProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AccelLabelProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AccelLabelProperty seq, value: System.String) =
        seq { yield! it; yield AccelLabelProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AccelLabelProperty seq, value: System.String) =
        seq { yield! it; yield AccelLabelProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AccelLabelProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AccelLabelProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AccelLabelProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AccelLabelProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AccelLabelProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AccelLabelProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AccelLabelProperty seq, value: System.Int32) =
        seq { yield! it; yield AccelLabelProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AccelLabelProperty seq, value: System.Boolean) =
        seq { yield! it; yield AccelLabelProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AccelLabelProperty seq, value: System.Double) =
        seq { yield! it; yield AccelLabelProperty.Opacity value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: AccelLabelProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnMoveCursor value } 
    [<CustomOperation("onActivateLink")>]
    member this.OnActivateLink(it: AccelLabelProperty seq, value: Gtk.ActivateLinkArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnActivateLink value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: AccelLabelProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnPopulatePopup value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AccelLabelProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AccelLabelProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AccelLabelProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AccelLabelProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AccelLabelProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AccelLabelProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AccelLabelProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AccelLabelProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AccelLabelProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AccelLabelProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AccelLabelProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AccelLabelProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AccelLabelProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AccelLabelProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AccelLabelProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AccelLabelProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AccelLabelProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AccelLabelProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AccelLabelProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AccelLabelProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AccelLabelProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AccelLabelProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AccelLabelProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AccelLabelProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AccelLabelProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AccelLabelProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AccelLabelProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AccelLabelProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AccelLabelProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AccelLabelProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AccelLabelProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AccelLabelProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AccelLabelProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AccelLabelProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AccelLabelProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AccelLabelProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AccelLabelProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AccelLabelProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AccelLabelProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AccelLabelProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AccelLabelProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AccelLabelProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AccelLabelProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AccelLabelProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AccelLabelProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AccelLabelProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AccelLabelProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AccelLabelProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AccelLabelProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AccelLabelProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AccelLabelProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AccelLabelProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AccelLabelProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AccelLabelProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AccelLabelProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AccelLabelProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AccelLabelProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AccelLabelProperty.OnFocused value } 

let prop = AccelLabelPropertyBuilder()

