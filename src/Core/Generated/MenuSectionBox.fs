module GtkDsl.Binding.MenuSectionBox
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MenuSectionBoxProperty =
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

let bindProperty (widget: MenuSectionBox) (prop: MenuSectionBoxProperty) =
    match prop with
    | MenuSectionBoxProperty.Spacing value -> widget.Spacing <- value
    | MenuSectionBoxProperty.Homogeneous value -> widget.Homogeneous <- value
    | MenuSectionBoxProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | MenuSectionBoxProperty.Expand value -> widget.Expand <- value
    | MenuSectionBoxProperty.Fill value -> widget.Fill <- value
    | MenuSectionBoxProperty.Padding value -> widget.Padding <- value
    | MenuSectionBoxProperty.PackType value -> widget.PackType <- value
    | MenuSectionBoxProperty.Position value -> widget.Position <- value
    | MenuSectionBoxProperty.Orientation value -> widget.Orientation <- value
    | MenuSectionBoxProperty.ResizeMode value -> widget.ResizeMode <- value
    | MenuSectionBoxProperty.BorderWidth value -> widget.BorderWidth <- value
    | MenuSectionBoxProperty.Name value -> widget.Name <- value
    | MenuSectionBoxProperty.Parent value -> widget.Parent <- value
    | MenuSectionBoxProperty.WidthRequest value -> widget.WidthRequest <- value
    | MenuSectionBoxProperty.HeightRequest value -> widget.HeightRequest <- value
    | MenuSectionBoxProperty.Visible value -> widget.Visible <- value
    | MenuSectionBoxProperty.Sensitive value -> widget.Sensitive <- value
    | MenuSectionBoxProperty.AppPaintable value -> widget.AppPaintable <- value
    | MenuSectionBoxProperty.CanFocus value -> widget.CanFocus <- value
    | MenuSectionBoxProperty.HasFocus value -> widget.HasFocus <- value
    | MenuSectionBoxProperty.IsFocus value -> widget.IsFocus <- value
    | MenuSectionBoxProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MenuSectionBoxProperty.CanDefault value -> widget.CanDefault <- value
    | MenuSectionBoxProperty.HasDefault value -> widget.HasDefault <- value
    | MenuSectionBoxProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MenuSectionBoxProperty.Style value -> widget.Style <- value
    | MenuSectionBoxProperty.Events value -> widget.Events <- value
    | MenuSectionBoxProperty.NoShowAll value -> widget.NoShowAll <- value
    | MenuSectionBoxProperty.HasTooltip value -> widget.HasTooltip <- value
    | MenuSectionBoxProperty.TooltipText value -> widget.TooltipText <- value
    | MenuSectionBoxProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MenuSectionBoxProperty.Window value -> widget.Window <- value
    | MenuSectionBoxProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MenuSectionBoxProperty.Halign value -> widget.Halign <- value
    | MenuSectionBoxProperty.Valign value -> widget.Valign <- value
    | MenuSectionBoxProperty.MarginLeft value -> widget.MarginLeft <- value
    | MenuSectionBoxProperty.MarginRight value -> widget.MarginRight <- value
    | MenuSectionBoxProperty.MarginStart value -> widget.MarginStart <- value
    | MenuSectionBoxProperty.MarginEnd value -> widget.MarginEnd <- value
    | MenuSectionBoxProperty.MarginTop value -> widget.MarginTop <- value
    | MenuSectionBoxProperty.MarginBottom value -> widget.MarginBottom <- value
    | MenuSectionBoxProperty.Margin value -> widget.Margin <- value
    | MenuSectionBoxProperty.Hexpand value -> widget.Hexpand <- value
    | MenuSectionBoxProperty.HexpandSet value -> widget.HexpandSet <- value
    | MenuSectionBoxProperty.Vexpand value -> widget.Vexpand <- value
    | MenuSectionBoxProperty.VexpandSet value -> widget.VexpandSet <- value
    | MenuSectionBoxProperty.Opacity value -> widget.Opacity <- value
    | MenuSectionBoxProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MenuSectionBoxProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MenuSectionBoxProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MenuSectionBoxProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MenuSectionBoxProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MenuSectionBoxProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MenuSectionBoxProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MenuSectionBoxProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MenuSectionBoxProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MenuSectionBoxProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MenuSectionBoxProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MenuSectionBoxProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MenuSectionBoxProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MenuSectionBoxProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MenuSectionBoxProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MenuSectionBoxProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MenuSectionBoxProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MenuSectionBoxProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MenuSectionBoxProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MenuSectionBoxProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MenuSectionBoxProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MenuSectionBoxProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MenuSectionBoxProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MenuSectionBoxProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MenuSectionBoxProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MenuSectionBoxProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MenuSectionBoxProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MenuSectionBoxProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MenuSectionBoxProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MenuSectionBoxProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MenuSectionBoxProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MenuSectionBoxProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MenuSectionBoxProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MenuSectionBoxProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MenuSectionBoxProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MenuSectionBoxProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MenuSectionBoxProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MenuSectionBoxProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MenuSectionBoxProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MenuSectionBoxProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MenuSectionBoxProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MenuSectionBoxProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MenuSectionBoxProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MenuSectionBoxProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MenuSectionBoxProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MenuSectionBoxProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MenuSectionBoxProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MenuSectionBoxProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MenuSectionBoxProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MenuSectionBoxProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MenuSectionBoxProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MenuSectionBoxProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MenuSectionBoxProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MenuSectionBoxProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MenuSectionBoxProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MenuSectionBoxProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MenuSectionBoxProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MenuSectionBoxProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MenuSectionBoxProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MenuSectionBoxProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MenuSectionBoxPropertyBuilder() =
    inherit BasePropertyBuilder<MenuSectionBoxProperty>()
    [<CustomOperation("spacing")>]
    member this.Spacing(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: MenuSectionBoxProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield MenuSectionBoxProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: MenuSectionBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuSectionBoxProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: MenuSectionBoxProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield MenuSectionBoxProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: MenuSectionBoxProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield MenuSectionBoxProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MenuSectionBoxProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MenuSectionBoxProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MenuSectionBoxProperty seq, value: System.UInt32) =
        seq { yield! it; yield MenuSectionBoxProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MenuSectionBoxProperty seq, value: System.String) =
        seq { yield! it; yield MenuSectionBoxProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MenuSectionBoxProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MenuSectionBoxProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MenuSectionBoxProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MenuSectionBoxProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MenuSectionBoxProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MenuSectionBoxProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MenuSectionBoxProperty seq, value: System.String) =
        seq { yield! it; yield MenuSectionBoxProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MenuSectionBoxProperty seq, value: System.String) =
        seq { yield! it; yield MenuSectionBoxProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MenuSectionBoxProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MenuSectionBoxProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MenuSectionBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuSectionBoxProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MenuSectionBoxProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MenuSectionBoxProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MenuSectionBoxProperty seq, value: System.Int32) =
        seq { yield! it; yield MenuSectionBoxProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MenuSectionBoxProperty seq, value: System.Boolean) =
        seq { yield! it; yield MenuSectionBoxProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MenuSectionBoxProperty seq, value: System.Double) =
        seq { yield! it; yield MenuSectionBoxProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MenuSectionBoxProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MenuSectionBoxProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MenuSectionBoxProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MenuSectionBoxProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MenuSectionBoxProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MenuSectionBoxProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MenuSectionBoxProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MenuSectionBoxProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MenuSectionBoxProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MenuSectionBoxProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MenuSectionBoxProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MenuSectionBoxProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MenuSectionBoxProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MenuSectionBoxProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MenuSectionBoxProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MenuSectionBoxProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MenuSectionBoxProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MenuSectionBoxProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MenuSectionBoxProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MenuSectionBoxProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MenuSectionBoxProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MenuSectionBoxProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MenuSectionBoxProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MenuSectionBoxProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MenuSectionBoxProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MenuSectionBoxProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MenuSectionBoxProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MenuSectionBoxProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MenuSectionBoxProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MenuSectionBoxProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MenuSectionBoxProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MenuSectionBoxProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MenuSectionBoxProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MenuSectionBoxProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MenuSectionBoxProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MenuSectionBoxProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MenuSectionBoxProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MenuSectionBoxProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MenuSectionBoxProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MenuSectionBoxProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MenuSectionBoxProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MenuSectionBoxProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MenuSectionBoxProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MenuSectionBoxProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MenuSectionBoxProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MenuSectionBoxProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MenuSectionBoxProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MenuSectionBoxProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MenuSectionBoxProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MenuSectionBoxProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MenuSectionBoxProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MenuSectionBoxProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MenuSectionBoxProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MenuSectionBoxProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MenuSectionBoxProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MenuSectionBoxProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MenuSectionBoxProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MenuSectionBoxProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MenuSectionBoxProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MenuSectionBoxProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MenuSectionBoxProperty.OnFocused value } 

let prop = MenuSectionBoxPropertyBuilder()

