module Gtk.DSL.Binding.FontChooserWidget
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FontChooserWidgetProperty =
    | Font of System.String
    | FontDesc of Pango.FontDescription
    | PreviewText of System.String
    | ShowPreviewEntry of System.Boolean
    | Spacing of System.Int32
    | Homogeneous of System.Boolean
    | BaselinePosition of Gtk.BaselinePosition
    | Expand of System.Boolean
    | Fill of System.Boolean
    | Padding of System.UInt32
    | PackType of Gtk.PackType
    | Position of System.Int32
    | Orientation of Gtk.Orientation
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
    |  OnFontActivated of (Gtk.FontActivatedArgs -> unit)
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

let bindProperty (widget: FontChooserWidget) (prop: FontChooserWidgetProperty) =
    match prop with
    | FontChooserWidgetProperty.Font value -> widget.Font <- value
    | FontChooserWidgetProperty.FontDesc value -> widget.FontDesc <- value
    | FontChooserWidgetProperty.PreviewText value -> widget.PreviewText <- value
    | FontChooserWidgetProperty.ShowPreviewEntry value -> widget.ShowPreviewEntry <- value
    | FontChooserWidgetProperty.Spacing value -> widget.Spacing <- value
    | FontChooserWidgetProperty.Homogeneous value -> widget.Homogeneous <- value
    | FontChooserWidgetProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | FontChooserWidgetProperty.Expand value -> widget.Expand <- value
    | FontChooserWidgetProperty.Fill value -> widget.Fill <- value
    | FontChooserWidgetProperty.Padding value -> widget.Padding <- value
    | FontChooserWidgetProperty.PackType value -> widget.PackType <- value
    | FontChooserWidgetProperty.Position value -> widget.Position <- value
    | FontChooserWidgetProperty.Orientation value -> widget.Orientation <- value
    | FontChooserWidgetProperty.ResizeMode value -> widget.ResizeMode <- value
    | FontChooserWidgetProperty.BorderWidth value -> widget.BorderWidth <- value
    | FontChooserWidgetProperty.Name value -> widget.Name <- value
    | FontChooserWidgetProperty.Parent value -> widget.Parent <- value
    | FontChooserWidgetProperty.WidthRequest value -> widget.WidthRequest <- value
    | FontChooserWidgetProperty.HeightRequest value -> widget.HeightRequest <- value
    | FontChooserWidgetProperty.Visible value -> widget.Visible <- value
    | FontChooserWidgetProperty.Sensitive value -> widget.Sensitive <- value
    | FontChooserWidgetProperty.AppPaintable value -> widget.AppPaintable <- value
    | FontChooserWidgetProperty.CanFocus value -> widget.CanFocus <- value
    | FontChooserWidgetProperty.HasFocus value -> widget.HasFocus <- value
    | FontChooserWidgetProperty.IsFocus value -> widget.IsFocus <- value
    | FontChooserWidgetProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FontChooserWidgetProperty.CanDefault value -> widget.CanDefault <- value
    | FontChooserWidgetProperty.HasDefault value -> widget.HasDefault <- value
    | FontChooserWidgetProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FontChooserWidgetProperty.Style value -> widget.Style <- value
    | FontChooserWidgetProperty.Events value -> widget.Events <- value
    | FontChooserWidgetProperty.NoShowAll value -> widget.NoShowAll <- value
    | FontChooserWidgetProperty.HasTooltip value -> widget.HasTooltip <- value
    | FontChooserWidgetProperty.TooltipText value -> widget.TooltipText <- value
    | FontChooserWidgetProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FontChooserWidgetProperty.Window value -> widget.Window <- value
    | FontChooserWidgetProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FontChooserWidgetProperty.Halign value -> widget.Halign <- value
    | FontChooserWidgetProperty.Valign value -> widget.Valign <- value
    | FontChooserWidgetProperty.MarginLeft value -> widget.MarginLeft <- value
    | FontChooserWidgetProperty.MarginRight value -> widget.MarginRight <- value
    | FontChooserWidgetProperty.MarginStart value -> widget.MarginStart <- value
    | FontChooserWidgetProperty.MarginEnd value -> widget.MarginEnd <- value
    | FontChooserWidgetProperty.MarginTop value -> widget.MarginTop <- value
    | FontChooserWidgetProperty.MarginBottom value -> widget.MarginBottom <- value
    | FontChooserWidgetProperty.Margin value -> widget.Margin <- value
    | FontChooserWidgetProperty.Hexpand value -> widget.Hexpand <- value
    | FontChooserWidgetProperty.HexpandSet value -> widget.HexpandSet <- value
    | FontChooserWidgetProperty.Vexpand value -> widget.Vexpand <- value
    | FontChooserWidgetProperty.VexpandSet value -> widget.VexpandSet <- value
    | FontChooserWidgetProperty.Opacity value -> widget.Opacity <- value
    | FontChooserWidgetProperty.OnFontActivated handler -> 
        let disposable = widget.FontActivated.Subscribe(handler)
        registerListener widget "FontActivated" disposable
    | FontChooserWidgetProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FontChooserWidgetProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FontChooserWidgetProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FontChooserWidgetProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FontChooserWidgetProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FontChooserWidgetProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FontChooserWidgetProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FontChooserWidgetProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FontChooserWidgetProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FontChooserWidgetProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FontChooserWidgetProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FontChooserWidgetProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FontChooserWidgetProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FontChooserWidgetProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FontChooserWidgetProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FontChooserWidgetProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FontChooserWidgetProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FontChooserWidgetProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FontChooserWidgetProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FontChooserWidgetProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FontChooserWidgetProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FontChooserWidgetProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FontChooserWidgetProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FontChooserWidgetProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FontChooserWidgetProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FontChooserWidgetProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FontChooserWidgetProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FontChooserWidgetProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FontChooserWidgetProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FontChooserWidgetProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FontChooserWidgetProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FontChooserWidgetProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FontChooserWidgetProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FontChooserWidgetProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FontChooserWidgetProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FontChooserWidgetProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FontChooserWidgetProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FontChooserWidgetProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FontChooserWidgetProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FontChooserWidgetProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FontChooserWidgetProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FontChooserWidgetProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FontChooserWidgetProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FontChooserWidgetProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FontChooserWidgetProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FontChooserWidgetProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FontChooserWidgetProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FontChooserWidgetProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FontChooserWidgetProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FontChooserWidgetProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FontChooserWidgetProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FontChooserWidgetProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FontChooserWidgetProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FontChooserWidgetProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FontChooserWidgetProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FontChooserWidgetProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FontChooserWidgetProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FontChooserWidgetProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FontChooserWidgetProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FontChooserWidgetProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FontChooserWidgetPropertyBuilder() =
    inherit BasePropertyBuilder<FontChooserWidgetProperty>()
    [<CustomOperation("font")>]
    member this.Font(it: FontChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserWidgetProperty.Font value } 
    [<CustomOperation("fontDesc")>]
    member this.FontDesc(it: FontChooserWidgetProperty seq, value: Pango.FontDescription) =
        seq { yield! it; yield FontChooserWidgetProperty.FontDesc value } 
    [<CustomOperation("previewText")>]
    member this.PreviewText(it: FontChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserWidgetProperty.PreviewText value } 
    [<CustomOperation("showPreviewEntry")>]
    member this.ShowPreviewEntry(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.ShowPreviewEntry value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: FontChooserWidgetProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield FontChooserWidgetProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: FontChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontChooserWidgetProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: FontChooserWidgetProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield FontChooserWidgetProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: FontChooserWidgetProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield FontChooserWidgetProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FontChooserWidgetProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FontChooserWidgetProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FontChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontChooserWidgetProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FontChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserWidgetProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FontChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontChooserWidgetProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FontChooserWidgetProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FontChooserWidgetProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FontChooserWidgetProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FontChooserWidgetProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FontChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserWidgetProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FontChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserWidgetProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FontChooserWidgetProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FontChooserWidgetProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FontChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontChooserWidgetProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FontChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontChooserWidgetProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FontChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserWidgetProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FontChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserWidgetProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FontChooserWidgetProperty seq, value: System.Double) =
        seq { yield! it; yield FontChooserWidgetProperty.Opacity value } 
    [<CustomOperation("onFontActivated")>]
    member this.OnFontActivated(it: FontChooserWidgetProperty seq, value: Gtk.FontActivatedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnFontActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FontChooserWidgetProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FontChooserWidgetProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FontChooserWidgetProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FontChooserWidgetProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FontChooserWidgetProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FontChooserWidgetProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FontChooserWidgetProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FontChooserWidgetProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FontChooserWidgetProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FontChooserWidgetProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FontChooserWidgetProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FontChooserWidgetProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FontChooserWidgetProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FontChooserWidgetProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FontChooserWidgetProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FontChooserWidgetProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FontChooserWidgetProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FontChooserWidgetProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FontChooserWidgetProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FontChooserWidgetProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FontChooserWidgetProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FontChooserWidgetProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FontChooserWidgetProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FontChooserWidgetProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FontChooserWidgetProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FontChooserWidgetProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FontChooserWidgetProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FontChooserWidgetProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FontChooserWidgetProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FontChooserWidgetProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FontChooserWidgetProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FontChooserWidgetProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FontChooserWidgetProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FontChooserWidgetProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FontChooserWidgetProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FontChooserWidgetProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FontChooserWidgetProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FontChooserWidgetProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FontChooserWidgetProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FontChooserWidgetProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FontChooserWidgetProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FontChooserWidgetProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FontChooserWidgetProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FontChooserWidgetProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FontChooserWidgetProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FontChooserWidgetProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FontChooserWidgetProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FontChooserWidgetProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FontChooserWidgetProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FontChooserWidgetProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FontChooserWidgetProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FontChooserWidgetProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FontChooserWidgetProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FontChooserWidgetProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FontChooserWidgetProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FontChooserWidgetProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FontChooserWidgetProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FontChooserWidgetProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FontChooserWidgetProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FontChooserWidgetProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FontChooserWidgetProperty.OnFocused value } 

let prop = FontChooserWidgetPropertyBuilder()

type FontChooserWidgetDescriptor(props) =
    inherit BaseWidgetDescriptor<FontChooserWidget, FontChooserWidgetProperty>(props, bindProperty)
    override this.CreateTyped() = new FontChooserWidget()

let fontChooserWidget props = FontChooserWidgetDescriptor(props)

