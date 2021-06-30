module GtkDsl.Binding.ShortcutsShortcut
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ShortcutsShortcutProperty =
    | Accelerator of System.String
    | Icon of GLib.IIcon
    | IconSet of System.Boolean
    | Title of System.String
    | Subtitle of System.String
    | SubtitleSet of System.Boolean
    | Direction of Gtk.TextDirection
    | ShortcutType of Gtk.ShortcutType
    | ActionName of System.String
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

let bindProperty (widget: ShortcutsShortcut) (prop: ShortcutsShortcutProperty) =
    match prop with
    | ShortcutsShortcutProperty.Accelerator value -> widget.Accelerator <- value
    | ShortcutsShortcutProperty.Icon value -> widget.Icon <- value
    | ShortcutsShortcutProperty.IconSet value -> widget.IconSet <- value
    | ShortcutsShortcutProperty.Title value -> widget.Title <- value
    | ShortcutsShortcutProperty.Subtitle value -> widget.Subtitle <- value
    | ShortcutsShortcutProperty.SubtitleSet value -> widget.SubtitleSet <- value
    | ShortcutsShortcutProperty.Direction value -> widget.Direction <- value
    | ShortcutsShortcutProperty.ShortcutType value -> widget.ShortcutType <- value
    | ShortcutsShortcutProperty.ActionName value -> widget.ActionName <- value
    | ShortcutsShortcutProperty.Spacing value -> widget.Spacing <- value
    | ShortcutsShortcutProperty.Homogeneous value -> widget.Homogeneous <- value
    | ShortcutsShortcutProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ShortcutsShortcutProperty.Expand value -> widget.Expand <- value
    | ShortcutsShortcutProperty.Fill value -> widget.Fill <- value
    | ShortcutsShortcutProperty.Padding value -> widget.Padding <- value
    | ShortcutsShortcutProperty.PackType value -> widget.PackType <- value
    | ShortcutsShortcutProperty.Position value -> widget.Position <- value
    | ShortcutsShortcutProperty.Orientation value -> widget.Orientation <- value
    | ShortcutsShortcutProperty.ResizeMode value -> widget.ResizeMode <- value
    | ShortcutsShortcutProperty.BorderWidth value -> widget.BorderWidth <- value
    | ShortcutsShortcutProperty.Name value -> widget.Name <- value
    | ShortcutsShortcutProperty.Parent value -> widget.Parent <- value
    | ShortcutsShortcutProperty.WidthRequest value -> widget.WidthRequest <- value
    | ShortcutsShortcutProperty.HeightRequest value -> widget.HeightRequest <- value
    | ShortcutsShortcutProperty.Visible value -> widget.Visible <- value
    | ShortcutsShortcutProperty.Sensitive value -> widget.Sensitive <- value
    | ShortcutsShortcutProperty.AppPaintable value -> widget.AppPaintable <- value
    | ShortcutsShortcutProperty.CanFocus value -> widget.CanFocus <- value
    | ShortcutsShortcutProperty.HasFocus value -> widget.HasFocus <- value
    | ShortcutsShortcutProperty.IsFocus value -> widget.IsFocus <- value
    | ShortcutsShortcutProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ShortcutsShortcutProperty.CanDefault value -> widget.CanDefault <- value
    | ShortcutsShortcutProperty.HasDefault value -> widget.HasDefault <- value
    | ShortcutsShortcutProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ShortcutsShortcutProperty.Style value -> widget.Style <- value
    | ShortcutsShortcutProperty.Events value -> widget.Events <- value
    | ShortcutsShortcutProperty.NoShowAll value -> widget.NoShowAll <- value
    | ShortcutsShortcutProperty.HasTooltip value -> widget.HasTooltip <- value
    | ShortcutsShortcutProperty.TooltipText value -> widget.TooltipText <- value
    | ShortcutsShortcutProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ShortcutsShortcutProperty.Window value -> widget.Window <- value
    | ShortcutsShortcutProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ShortcutsShortcutProperty.Halign value -> widget.Halign <- value
    | ShortcutsShortcutProperty.Valign value -> widget.Valign <- value
    | ShortcutsShortcutProperty.MarginLeft value -> widget.MarginLeft <- value
    | ShortcutsShortcutProperty.MarginRight value -> widget.MarginRight <- value
    | ShortcutsShortcutProperty.MarginStart value -> widget.MarginStart <- value
    | ShortcutsShortcutProperty.MarginEnd value -> widget.MarginEnd <- value
    | ShortcutsShortcutProperty.MarginTop value -> widget.MarginTop <- value
    | ShortcutsShortcutProperty.MarginBottom value -> widget.MarginBottom <- value
    | ShortcutsShortcutProperty.Margin value -> widget.Margin <- value
    | ShortcutsShortcutProperty.Hexpand value -> widget.Hexpand <- value
    | ShortcutsShortcutProperty.HexpandSet value -> widget.HexpandSet <- value
    | ShortcutsShortcutProperty.Vexpand value -> widget.Vexpand <- value
    | ShortcutsShortcutProperty.VexpandSet value -> widget.VexpandSet <- value
    | ShortcutsShortcutProperty.Opacity value -> widget.Opacity <- value
    | ShortcutsShortcutProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ShortcutsShortcutProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ShortcutsShortcutProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ShortcutsShortcutProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ShortcutsShortcutProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ShortcutsShortcutProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ShortcutsShortcutProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ShortcutsShortcutProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ShortcutsShortcutProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ShortcutsShortcutProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ShortcutsShortcutProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ShortcutsShortcutProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ShortcutsShortcutProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ShortcutsShortcutProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ShortcutsShortcutProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ShortcutsShortcutProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ShortcutsShortcutProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ShortcutsShortcutProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ShortcutsShortcutProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ShortcutsShortcutProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ShortcutsShortcutProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ShortcutsShortcutProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ShortcutsShortcutProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ShortcutsShortcutProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ShortcutsShortcutProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ShortcutsShortcutProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ShortcutsShortcutProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ShortcutsShortcutProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ShortcutsShortcutProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ShortcutsShortcutProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ShortcutsShortcutProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ShortcutsShortcutProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ShortcutsShortcutProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ShortcutsShortcutProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ShortcutsShortcutProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ShortcutsShortcutProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ShortcutsShortcutProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ShortcutsShortcutProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ShortcutsShortcutProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ShortcutsShortcutProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ShortcutsShortcutProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ShortcutsShortcutProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ShortcutsShortcutProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ShortcutsShortcutProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ShortcutsShortcutProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ShortcutsShortcutProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ShortcutsShortcutProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ShortcutsShortcutProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ShortcutsShortcutProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ShortcutsShortcutProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ShortcutsShortcutProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ShortcutsShortcutProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ShortcutsShortcutProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ShortcutsShortcutProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ShortcutsShortcutProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ShortcutsShortcutProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ShortcutsShortcutProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ShortcutsShortcutProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ShortcutsShortcutProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ShortcutsShortcutProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ShortcutsShortcutPropertyBuilder() =
    inherit BasePropertyBuilder<ShortcutsShortcutProperty>()
    [<CustomOperation("accelerator")>]
    member this.Accelerator(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.Accelerator value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: ShortcutsShortcutProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield ShortcutsShortcutProperty.Icon value } 
    [<CustomOperation("iconSet")>]
    member this.IconSet(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.IconSet value } 
    [<CustomOperation("title")>]
    member this.Title(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.Title value } 
    [<CustomOperation("subtitle")>]
    member this.Subtitle(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.Subtitle value } 
    [<CustomOperation("subtitleSet")>]
    member this.SubtitleSet(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.SubtitleSet value } 
    [<CustomOperation("direction")>]
    member this.Direction(it: ShortcutsShortcutProperty seq, value: Gtk.TextDirection) =
        seq { yield! it; yield ShortcutsShortcutProperty.Direction value } 
    [<CustomOperation("shortcutType")>]
    member this.ShortcutType(it: ShortcutsShortcutProperty seq, value: Gtk.ShortcutType) =
        seq { yield! it; yield ShortcutsShortcutProperty.ShortcutType value } 
    [<CustomOperation("actionName")>]
    member this.ActionName(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.ActionName value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ShortcutsShortcutProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ShortcutsShortcutProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ShortcutsShortcutProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsShortcutProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ShortcutsShortcutProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ShortcutsShortcutProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ShortcutsShortcutProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ShortcutsShortcutProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ShortcutsShortcutProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ShortcutsShortcutProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ShortcutsShortcutProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsShortcutProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ShortcutsShortcutProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ShortcutsShortcutProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ShortcutsShortcutProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ShortcutsShortcutProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ShortcutsShortcutProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ShortcutsShortcutProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ShortcutsShortcutProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsShortcutProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ShortcutsShortcutProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ShortcutsShortcutProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ShortcutsShortcutProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsShortcutProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ShortcutsShortcutProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsShortcutProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ShortcutsShortcutProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsShortcutProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ShortcutsShortcutProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsShortcutProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ShortcutsShortcutProperty seq, value: System.Double) =
        seq { yield! it; yield ShortcutsShortcutProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ShortcutsShortcutProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ShortcutsShortcutProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ShortcutsShortcutProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ShortcutsShortcutProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ShortcutsShortcutProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ShortcutsShortcutProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ShortcutsShortcutProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ShortcutsShortcutProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ShortcutsShortcutProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ShortcutsShortcutProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ShortcutsShortcutProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ShortcutsShortcutProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ShortcutsShortcutProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ShortcutsShortcutProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ShortcutsShortcutProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ShortcutsShortcutProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ShortcutsShortcutProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ShortcutsShortcutProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ShortcutsShortcutProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ShortcutsShortcutProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ShortcutsShortcutProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ShortcutsShortcutProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ShortcutsShortcutProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ShortcutsShortcutProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ShortcutsShortcutProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ShortcutsShortcutProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ShortcutsShortcutProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ShortcutsShortcutProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ShortcutsShortcutProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ShortcutsShortcutProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ShortcutsShortcutProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ShortcutsShortcutProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ShortcutsShortcutProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ShortcutsShortcutProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ShortcutsShortcutProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ShortcutsShortcutProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ShortcutsShortcutProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ShortcutsShortcutProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ShortcutsShortcutProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ShortcutsShortcutProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ShortcutsShortcutProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ShortcutsShortcutProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ShortcutsShortcutProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ShortcutsShortcutProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ShortcutsShortcutProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ShortcutsShortcutProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ShortcutsShortcutProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ShortcutsShortcutProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ShortcutsShortcutProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ShortcutsShortcutProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ShortcutsShortcutProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ShortcutsShortcutProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ShortcutsShortcutProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ShortcutsShortcutProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ShortcutsShortcutProperty.OnFocused value } 

let prop = ShortcutsShortcutPropertyBuilder()

