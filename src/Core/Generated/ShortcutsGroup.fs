module GtkDsl.Binding.ShortcutsGroup
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ShortcutsGroupProperty =
    | Title of System.String
    | View of System.String
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

let bindProperty (widget: ShortcutsGroup) (prop: ShortcutsGroupProperty) =
    match prop with
    | ShortcutsGroupProperty.Title value -> widget.Title <- value
    | ShortcutsGroupProperty.View value -> widget.View <- value
    | ShortcutsGroupProperty.Spacing value -> widget.Spacing <- value
    | ShortcutsGroupProperty.Homogeneous value -> widget.Homogeneous <- value
    | ShortcutsGroupProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ShortcutsGroupProperty.Expand value -> widget.Expand <- value
    | ShortcutsGroupProperty.Fill value -> widget.Fill <- value
    | ShortcutsGroupProperty.Padding value -> widget.Padding <- value
    | ShortcutsGroupProperty.PackType value -> widget.PackType <- value
    | ShortcutsGroupProperty.Position value -> widget.Position <- value
    | ShortcutsGroupProperty.Orientation value -> widget.Orientation <- value
    | ShortcutsGroupProperty.ResizeMode value -> widget.ResizeMode <- value
    | ShortcutsGroupProperty.BorderWidth value -> widget.BorderWidth <- value
    | ShortcutsGroupProperty.Name value -> widget.Name <- value
    | ShortcutsGroupProperty.Parent value -> widget.Parent <- value
    | ShortcutsGroupProperty.WidthRequest value -> widget.WidthRequest <- value
    | ShortcutsGroupProperty.HeightRequest value -> widget.HeightRequest <- value
    | ShortcutsGroupProperty.Visible value -> widget.Visible <- value
    | ShortcutsGroupProperty.Sensitive value -> widget.Sensitive <- value
    | ShortcutsGroupProperty.AppPaintable value -> widget.AppPaintable <- value
    | ShortcutsGroupProperty.CanFocus value -> widget.CanFocus <- value
    | ShortcutsGroupProperty.HasFocus value -> widget.HasFocus <- value
    | ShortcutsGroupProperty.IsFocus value -> widget.IsFocus <- value
    | ShortcutsGroupProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ShortcutsGroupProperty.CanDefault value -> widget.CanDefault <- value
    | ShortcutsGroupProperty.HasDefault value -> widget.HasDefault <- value
    | ShortcutsGroupProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ShortcutsGroupProperty.Style value -> widget.Style <- value
    | ShortcutsGroupProperty.Events value -> widget.Events <- value
    | ShortcutsGroupProperty.NoShowAll value -> widget.NoShowAll <- value
    | ShortcutsGroupProperty.HasTooltip value -> widget.HasTooltip <- value
    | ShortcutsGroupProperty.TooltipText value -> widget.TooltipText <- value
    | ShortcutsGroupProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ShortcutsGroupProperty.Window value -> widget.Window <- value
    | ShortcutsGroupProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ShortcutsGroupProperty.Halign value -> widget.Halign <- value
    | ShortcutsGroupProperty.Valign value -> widget.Valign <- value
    | ShortcutsGroupProperty.MarginLeft value -> widget.MarginLeft <- value
    | ShortcutsGroupProperty.MarginRight value -> widget.MarginRight <- value
    | ShortcutsGroupProperty.MarginStart value -> widget.MarginStart <- value
    | ShortcutsGroupProperty.MarginEnd value -> widget.MarginEnd <- value
    | ShortcutsGroupProperty.MarginTop value -> widget.MarginTop <- value
    | ShortcutsGroupProperty.MarginBottom value -> widget.MarginBottom <- value
    | ShortcutsGroupProperty.Margin value -> widget.Margin <- value
    | ShortcutsGroupProperty.Hexpand value -> widget.Hexpand <- value
    | ShortcutsGroupProperty.HexpandSet value -> widget.HexpandSet <- value
    | ShortcutsGroupProperty.Vexpand value -> widget.Vexpand <- value
    | ShortcutsGroupProperty.VexpandSet value -> widget.VexpandSet <- value
    | ShortcutsGroupProperty.Opacity value -> widget.Opacity <- value
    | ShortcutsGroupProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ShortcutsGroupProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ShortcutsGroupProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ShortcutsGroupProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ShortcutsGroupProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ShortcutsGroupProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ShortcutsGroupProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ShortcutsGroupProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ShortcutsGroupProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ShortcutsGroupProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ShortcutsGroupProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ShortcutsGroupProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ShortcutsGroupProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ShortcutsGroupProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ShortcutsGroupProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ShortcutsGroupProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ShortcutsGroupProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ShortcutsGroupProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ShortcutsGroupProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ShortcutsGroupProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ShortcutsGroupProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ShortcutsGroupProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ShortcutsGroupProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ShortcutsGroupProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ShortcutsGroupProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ShortcutsGroupProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ShortcutsGroupProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ShortcutsGroupProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ShortcutsGroupProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ShortcutsGroupProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ShortcutsGroupProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ShortcutsGroupProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ShortcutsGroupProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ShortcutsGroupProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ShortcutsGroupProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ShortcutsGroupProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ShortcutsGroupProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ShortcutsGroupProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ShortcutsGroupProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ShortcutsGroupProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ShortcutsGroupProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ShortcutsGroupProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ShortcutsGroupProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ShortcutsGroupProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ShortcutsGroupProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ShortcutsGroupProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ShortcutsGroupProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ShortcutsGroupProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ShortcutsGroupProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ShortcutsGroupProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ShortcutsGroupProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ShortcutsGroupProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ShortcutsGroupProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ShortcutsGroupProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ShortcutsGroupProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ShortcutsGroupProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ShortcutsGroupProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ShortcutsGroupProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ShortcutsGroupProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ShortcutsGroupProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ShortcutsGroupPropertyBuilder() =
    inherit BasePropertyBuilder<ShortcutsGroupProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: ShortcutsGroupProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsGroupProperty.Title value } 
    [<CustomOperation("view")>]
    member this.View(it: ShortcutsGroupProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsGroupProperty.View value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ShortcutsGroupProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ShortcutsGroupProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ShortcutsGroupProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsGroupProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ShortcutsGroupProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ShortcutsGroupProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ShortcutsGroupProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ShortcutsGroupProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ShortcutsGroupProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ShortcutsGroupProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ShortcutsGroupProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsGroupProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ShortcutsGroupProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsGroupProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ShortcutsGroupProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ShortcutsGroupProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ShortcutsGroupProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ShortcutsGroupProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ShortcutsGroupProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ShortcutsGroupProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ShortcutsGroupProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsGroupProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ShortcutsGroupProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsGroupProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ShortcutsGroupProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ShortcutsGroupProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ShortcutsGroupProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsGroupProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ShortcutsGroupProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsGroupProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ShortcutsGroupProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsGroupProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ShortcutsGroupProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsGroupProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ShortcutsGroupProperty seq, value: System.Double) =
        seq { yield! it; yield ShortcutsGroupProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ShortcutsGroupProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ShortcutsGroupProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ShortcutsGroupProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ShortcutsGroupProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ShortcutsGroupProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ShortcutsGroupProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ShortcutsGroupProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ShortcutsGroupProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ShortcutsGroupProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ShortcutsGroupProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ShortcutsGroupProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ShortcutsGroupProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ShortcutsGroupProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ShortcutsGroupProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ShortcutsGroupProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ShortcutsGroupProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ShortcutsGroupProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ShortcutsGroupProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ShortcutsGroupProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ShortcutsGroupProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ShortcutsGroupProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ShortcutsGroupProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ShortcutsGroupProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ShortcutsGroupProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ShortcutsGroupProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ShortcutsGroupProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ShortcutsGroupProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ShortcutsGroupProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ShortcutsGroupProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ShortcutsGroupProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ShortcutsGroupProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ShortcutsGroupProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ShortcutsGroupProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ShortcutsGroupProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ShortcutsGroupProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ShortcutsGroupProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ShortcutsGroupProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ShortcutsGroupProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ShortcutsGroupProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ShortcutsGroupProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ShortcutsGroupProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ShortcutsGroupProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ShortcutsGroupProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ShortcutsGroupProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ShortcutsGroupProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ShortcutsGroupProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ShortcutsGroupProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ShortcutsGroupProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ShortcutsGroupProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ShortcutsGroupProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ShortcutsGroupProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ShortcutsGroupProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ShortcutsGroupProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ShortcutsGroupProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ShortcutsGroupProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ShortcutsGroupProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ShortcutsGroupProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ShortcutsGroupProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ShortcutsGroupProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ShortcutsGroupProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ShortcutsGroupProperty.OnFocused value } 

let prop = ShortcutsGroupPropertyBuilder()

