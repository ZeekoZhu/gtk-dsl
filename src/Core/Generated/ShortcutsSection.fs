module Gtk.DSL.Binding.ShortcutsSection
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ShortcutsSectionProperty =
    | SectionName of System.String
    | ViewName of System.String
    | Title of System.String
    | MaxHeight of System.UInt32
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
    |  OnChangeCurrentPage of (Gtk.ChangeCurrentPageArgs -> unit)
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

let bindProperty (widget: ShortcutsSection) (prop: ShortcutsSectionProperty) =
    match prop with
    | ShortcutsSectionProperty.SectionName value -> widget.SectionName <- value
    | ShortcutsSectionProperty.ViewName value -> widget.ViewName <- value
    | ShortcutsSectionProperty.Title value -> widget.Title <- value
    | ShortcutsSectionProperty.MaxHeight value -> widget.MaxHeight <- value
    | ShortcutsSectionProperty.Spacing value -> widget.Spacing <- value
    | ShortcutsSectionProperty.Homogeneous value -> widget.Homogeneous <- value
    | ShortcutsSectionProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | ShortcutsSectionProperty.Expand value -> widget.Expand <- value
    | ShortcutsSectionProperty.Fill value -> widget.Fill <- value
    | ShortcutsSectionProperty.Padding value -> widget.Padding <- value
    | ShortcutsSectionProperty.PackType value -> widget.PackType <- value
    | ShortcutsSectionProperty.Position value -> widget.Position <- value
    | ShortcutsSectionProperty.Orientation value -> widget.Orientation <- value
    | ShortcutsSectionProperty.ResizeMode value -> widget.ResizeMode <- value
    | ShortcutsSectionProperty.BorderWidth value -> widget.BorderWidth <- value
    | ShortcutsSectionProperty.Name value -> widget.Name <- value
    | ShortcutsSectionProperty.Parent value -> widget.Parent <- value
    | ShortcutsSectionProperty.WidthRequest value -> widget.WidthRequest <- value
    | ShortcutsSectionProperty.HeightRequest value -> widget.HeightRequest <- value
    | ShortcutsSectionProperty.Visible value -> widget.Visible <- value
    | ShortcutsSectionProperty.Sensitive value -> widget.Sensitive <- value
    | ShortcutsSectionProperty.AppPaintable value -> widget.AppPaintable <- value
    | ShortcutsSectionProperty.CanFocus value -> widget.CanFocus <- value
    | ShortcutsSectionProperty.HasFocus value -> widget.HasFocus <- value
    | ShortcutsSectionProperty.IsFocus value -> widget.IsFocus <- value
    | ShortcutsSectionProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ShortcutsSectionProperty.CanDefault value -> widget.CanDefault <- value
    | ShortcutsSectionProperty.HasDefault value -> widget.HasDefault <- value
    | ShortcutsSectionProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ShortcutsSectionProperty.Style value -> widget.Style <- value
    | ShortcutsSectionProperty.Events value -> widget.Events <- value
    | ShortcutsSectionProperty.NoShowAll value -> widget.NoShowAll <- value
    | ShortcutsSectionProperty.HasTooltip value -> widget.HasTooltip <- value
    | ShortcutsSectionProperty.TooltipText value -> widget.TooltipText <- value
    | ShortcutsSectionProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ShortcutsSectionProperty.Window value -> widget.Window <- value
    | ShortcutsSectionProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ShortcutsSectionProperty.Halign value -> widget.Halign <- value
    | ShortcutsSectionProperty.Valign value -> widget.Valign <- value
    | ShortcutsSectionProperty.MarginLeft value -> widget.MarginLeft <- value
    | ShortcutsSectionProperty.MarginRight value -> widget.MarginRight <- value
    | ShortcutsSectionProperty.MarginStart value -> widget.MarginStart <- value
    | ShortcutsSectionProperty.MarginEnd value -> widget.MarginEnd <- value
    | ShortcutsSectionProperty.MarginTop value -> widget.MarginTop <- value
    | ShortcutsSectionProperty.MarginBottom value -> widget.MarginBottom <- value
    | ShortcutsSectionProperty.Margin value -> widget.Margin <- value
    | ShortcutsSectionProperty.Hexpand value -> widget.Hexpand <- value
    | ShortcutsSectionProperty.HexpandSet value -> widget.HexpandSet <- value
    | ShortcutsSectionProperty.Vexpand value -> widget.Vexpand <- value
    | ShortcutsSectionProperty.VexpandSet value -> widget.VexpandSet <- value
    | ShortcutsSectionProperty.Opacity value -> widget.Opacity <- value
    | ShortcutsSectionProperty.OnChangeCurrentPage handler -> 
        let disposable = widget.ChangeCurrentPage.Subscribe(handler)
        registerListener widget "ChangeCurrentPage" disposable
    | ShortcutsSectionProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ShortcutsSectionProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ShortcutsSectionProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ShortcutsSectionProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ShortcutsSectionProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ShortcutsSectionProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ShortcutsSectionProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ShortcutsSectionProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ShortcutsSectionProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ShortcutsSectionProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ShortcutsSectionProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ShortcutsSectionProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ShortcutsSectionProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ShortcutsSectionProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ShortcutsSectionProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ShortcutsSectionProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ShortcutsSectionProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ShortcutsSectionProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ShortcutsSectionProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ShortcutsSectionProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ShortcutsSectionProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ShortcutsSectionProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ShortcutsSectionProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ShortcutsSectionProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ShortcutsSectionProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ShortcutsSectionProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ShortcutsSectionProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ShortcutsSectionProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ShortcutsSectionProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ShortcutsSectionProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ShortcutsSectionProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ShortcutsSectionProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ShortcutsSectionProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ShortcutsSectionProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ShortcutsSectionProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ShortcutsSectionProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ShortcutsSectionProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ShortcutsSectionProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ShortcutsSectionProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ShortcutsSectionProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ShortcutsSectionProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ShortcutsSectionProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ShortcutsSectionProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ShortcutsSectionProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ShortcutsSectionProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ShortcutsSectionProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ShortcutsSectionProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ShortcutsSectionProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ShortcutsSectionProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ShortcutsSectionProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ShortcutsSectionProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ShortcutsSectionProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ShortcutsSectionProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ShortcutsSectionProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ShortcutsSectionProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ShortcutsSectionProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ShortcutsSectionProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ShortcutsSectionProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ShortcutsSectionProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ShortcutsSectionProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ShortcutsSectionPropertyBuilder() =
    inherit BasePropertyBuilder<ShortcutsSectionProperty>()
    [<CustomOperation("sectionName")>]
    member this.SectionName(it: ShortcutsSectionProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsSectionProperty.SectionName value } 
    [<CustomOperation("viewName")>]
    member this.ViewName(it: ShortcutsSectionProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsSectionProperty.ViewName value } 
    [<CustomOperation("title")>]
    member this.Title(it: ShortcutsSectionProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsSectionProperty.Title value } 
    [<CustomOperation("maxHeight")>]
    member this.MaxHeight(it: ShortcutsSectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsSectionProperty.MaxHeight value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: ShortcutsSectionProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield ShortcutsSectionProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: ShortcutsSectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsSectionProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: ShortcutsSectionProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield ShortcutsSectionProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ShortcutsSectionProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ShortcutsSectionProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ShortcutsSectionProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ShortcutsSectionProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ShortcutsSectionProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsSectionProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ShortcutsSectionProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsSectionProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ShortcutsSectionProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ShortcutsSectionProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ShortcutsSectionProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ShortcutsSectionProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ShortcutsSectionProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ShortcutsSectionProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ShortcutsSectionProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsSectionProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ShortcutsSectionProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsSectionProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ShortcutsSectionProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ShortcutsSectionProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ShortcutsSectionProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsSectionProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ShortcutsSectionProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsSectionProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ShortcutsSectionProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsSectionProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ShortcutsSectionProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsSectionProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ShortcutsSectionProperty seq, value: System.Double) =
        seq { yield! it; yield ShortcutsSectionProperty.Opacity value } 
    [<CustomOperation("onChangeCurrentPage")>]
    member this.OnChangeCurrentPage(it: ShortcutsSectionProperty seq, value: Gtk.ChangeCurrentPageArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnChangeCurrentPage value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ShortcutsSectionProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ShortcutsSectionProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ShortcutsSectionProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ShortcutsSectionProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ShortcutsSectionProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ShortcutsSectionProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ShortcutsSectionProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ShortcutsSectionProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ShortcutsSectionProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ShortcutsSectionProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ShortcutsSectionProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ShortcutsSectionProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ShortcutsSectionProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ShortcutsSectionProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ShortcutsSectionProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ShortcutsSectionProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ShortcutsSectionProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ShortcutsSectionProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ShortcutsSectionProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ShortcutsSectionProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ShortcutsSectionProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ShortcutsSectionProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ShortcutsSectionProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ShortcutsSectionProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ShortcutsSectionProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ShortcutsSectionProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ShortcutsSectionProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ShortcutsSectionProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ShortcutsSectionProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ShortcutsSectionProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ShortcutsSectionProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ShortcutsSectionProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ShortcutsSectionProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ShortcutsSectionProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ShortcutsSectionProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ShortcutsSectionProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ShortcutsSectionProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ShortcutsSectionProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ShortcutsSectionProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ShortcutsSectionProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ShortcutsSectionProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ShortcutsSectionProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ShortcutsSectionProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ShortcutsSectionProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ShortcutsSectionProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ShortcutsSectionProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ShortcutsSectionProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ShortcutsSectionProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ShortcutsSectionProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ShortcutsSectionProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ShortcutsSectionProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ShortcutsSectionProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ShortcutsSectionProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ShortcutsSectionProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ShortcutsSectionProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ShortcutsSectionProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ShortcutsSectionProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ShortcutsSectionProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ShortcutsSectionProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ShortcutsSectionProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ShortcutsSectionProperty.OnFocused value } 

let prop = ShortcutsSectionPropertyBuilder()

