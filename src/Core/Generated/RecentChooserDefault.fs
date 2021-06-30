module GtkDsl.Binding.RecentChooserDefault
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RecentChooserDefaultProperty =
    | [<Obsolete>] RelatedAction of Gtk.Action
    | [<Obsolete>] UseActionAppearance of System.Boolean
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

let bindProperty (widget: RecentChooserDefault) (prop: RecentChooserDefaultProperty) =
    match prop with
    | RecentChooserDefaultProperty.RelatedAction value -> widget.RelatedAction <- value
    | RecentChooserDefaultProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | RecentChooserDefaultProperty.Spacing value -> widget.Spacing <- value
    | RecentChooserDefaultProperty.Homogeneous value -> widget.Homogeneous <- value
    | RecentChooserDefaultProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | RecentChooserDefaultProperty.Expand value -> widget.Expand <- value
    | RecentChooserDefaultProperty.Fill value -> widget.Fill <- value
    | RecentChooserDefaultProperty.Padding value -> widget.Padding <- value
    | RecentChooserDefaultProperty.PackType value -> widget.PackType <- value
    | RecentChooserDefaultProperty.Position value -> widget.Position <- value
    | RecentChooserDefaultProperty.Orientation value -> widget.Orientation <- value
    | RecentChooserDefaultProperty.ResizeMode value -> widget.ResizeMode <- value
    | RecentChooserDefaultProperty.BorderWidth value -> widget.BorderWidth <- value
    | RecentChooserDefaultProperty.Name value -> widget.Name <- value
    | RecentChooserDefaultProperty.Parent value -> widget.Parent <- value
    | RecentChooserDefaultProperty.WidthRequest value -> widget.WidthRequest <- value
    | RecentChooserDefaultProperty.HeightRequest value -> widget.HeightRequest <- value
    | RecentChooserDefaultProperty.Visible value -> widget.Visible <- value
    | RecentChooserDefaultProperty.Sensitive value -> widget.Sensitive <- value
    | RecentChooserDefaultProperty.AppPaintable value -> widget.AppPaintable <- value
    | RecentChooserDefaultProperty.CanFocus value -> widget.CanFocus <- value
    | RecentChooserDefaultProperty.HasFocus value -> widget.HasFocus <- value
    | RecentChooserDefaultProperty.IsFocus value -> widget.IsFocus <- value
    | RecentChooserDefaultProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RecentChooserDefaultProperty.CanDefault value -> widget.CanDefault <- value
    | RecentChooserDefaultProperty.HasDefault value -> widget.HasDefault <- value
    | RecentChooserDefaultProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RecentChooserDefaultProperty.Style value -> widget.Style <- value
    | RecentChooserDefaultProperty.Events value -> widget.Events <- value
    | RecentChooserDefaultProperty.NoShowAll value -> widget.NoShowAll <- value
    | RecentChooserDefaultProperty.HasTooltip value -> widget.HasTooltip <- value
    | RecentChooserDefaultProperty.TooltipText value -> widget.TooltipText <- value
    | RecentChooserDefaultProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RecentChooserDefaultProperty.Window value -> widget.Window <- value
    | RecentChooserDefaultProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RecentChooserDefaultProperty.Halign value -> widget.Halign <- value
    | RecentChooserDefaultProperty.Valign value -> widget.Valign <- value
    | RecentChooserDefaultProperty.MarginLeft value -> widget.MarginLeft <- value
    | RecentChooserDefaultProperty.MarginRight value -> widget.MarginRight <- value
    | RecentChooserDefaultProperty.MarginStart value -> widget.MarginStart <- value
    | RecentChooserDefaultProperty.MarginEnd value -> widget.MarginEnd <- value
    | RecentChooserDefaultProperty.MarginTop value -> widget.MarginTop <- value
    | RecentChooserDefaultProperty.MarginBottom value -> widget.MarginBottom <- value
    | RecentChooserDefaultProperty.Margin value -> widget.Margin <- value
    | RecentChooserDefaultProperty.Hexpand value -> widget.Hexpand <- value
    | RecentChooserDefaultProperty.HexpandSet value -> widget.HexpandSet <- value
    | RecentChooserDefaultProperty.Vexpand value -> widget.Vexpand <- value
    | RecentChooserDefaultProperty.VexpandSet value -> widget.VexpandSet <- value
    | RecentChooserDefaultProperty.Opacity value -> widget.Opacity <- value
    | RecentChooserDefaultProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RecentChooserDefaultProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RecentChooserDefaultProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RecentChooserDefaultProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RecentChooserDefaultProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RecentChooserDefaultProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RecentChooserDefaultProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RecentChooserDefaultProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RecentChooserDefaultProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RecentChooserDefaultProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RecentChooserDefaultProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RecentChooserDefaultProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RecentChooserDefaultProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RecentChooserDefaultProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RecentChooserDefaultProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RecentChooserDefaultProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RecentChooserDefaultProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RecentChooserDefaultProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RecentChooserDefaultProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RecentChooserDefaultProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RecentChooserDefaultProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RecentChooserDefaultProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RecentChooserDefaultProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RecentChooserDefaultProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RecentChooserDefaultProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RecentChooserDefaultProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RecentChooserDefaultProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RecentChooserDefaultProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RecentChooserDefaultProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RecentChooserDefaultProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RecentChooserDefaultProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RecentChooserDefaultProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RecentChooserDefaultProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RecentChooserDefaultProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RecentChooserDefaultProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RecentChooserDefaultProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RecentChooserDefaultProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RecentChooserDefaultProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RecentChooserDefaultProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RecentChooserDefaultProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RecentChooserDefaultProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RecentChooserDefaultProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RecentChooserDefaultProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RecentChooserDefaultProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RecentChooserDefaultProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RecentChooserDefaultProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RecentChooserDefaultProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RecentChooserDefaultProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RecentChooserDefaultProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RecentChooserDefaultProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RecentChooserDefaultProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RecentChooserDefaultProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RecentChooserDefaultProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RecentChooserDefaultProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RecentChooserDefaultProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RecentChooserDefaultProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RecentChooserDefaultProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RecentChooserDefaultProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RecentChooserDefaultProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RecentChooserDefaultProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RecentChooserDefaultPropertyBuilder() =
    inherit BasePropertyBuilder<RecentChooserDefaultProperty>()
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: RecentChooserDefaultProperty seq, value: Gtk.Action) =
        seq { yield! it; yield RecentChooserDefaultProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.UseActionAppearance value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: RecentChooserDefaultProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield RecentChooserDefaultProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: RecentChooserDefaultProperty seq, value: System.UInt32) =
        seq { yield! it; yield RecentChooserDefaultProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: RecentChooserDefaultProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield RecentChooserDefaultProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: RecentChooserDefaultProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield RecentChooserDefaultProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RecentChooserDefaultProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RecentChooserDefaultProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RecentChooserDefaultProperty seq, value: System.UInt32) =
        seq { yield! it; yield RecentChooserDefaultProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RecentChooserDefaultProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDefaultProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RecentChooserDefaultProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserDefaultProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RecentChooserDefaultProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RecentChooserDefaultProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RecentChooserDefaultProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RecentChooserDefaultProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RecentChooserDefaultProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDefaultProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RecentChooserDefaultProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDefaultProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RecentChooserDefaultProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RecentChooserDefaultProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RecentChooserDefaultProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserDefaultProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RecentChooserDefaultProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserDefaultProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RecentChooserDefaultProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDefaultProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RecentChooserDefaultProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDefaultProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RecentChooserDefaultProperty seq, value: System.Double) =
        seq { yield! it; yield RecentChooserDefaultProperty.Opacity value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RecentChooserDefaultProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RecentChooserDefaultProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RecentChooserDefaultProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RecentChooserDefaultProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RecentChooserDefaultProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RecentChooserDefaultProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RecentChooserDefaultProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RecentChooserDefaultProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RecentChooserDefaultProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RecentChooserDefaultProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RecentChooserDefaultProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RecentChooserDefaultProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RecentChooserDefaultProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RecentChooserDefaultProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RecentChooserDefaultProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RecentChooserDefaultProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RecentChooserDefaultProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RecentChooserDefaultProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RecentChooserDefaultProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RecentChooserDefaultProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RecentChooserDefaultProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RecentChooserDefaultProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RecentChooserDefaultProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RecentChooserDefaultProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RecentChooserDefaultProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RecentChooserDefaultProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RecentChooserDefaultProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RecentChooserDefaultProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RecentChooserDefaultProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RecentChooserDefaultProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RecentChooserDefaultProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RecentChooserDefaultProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RecentChooserDefaultProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RecentChooserDefaultProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RecentChooserDefaultProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RecentChooserDefaultProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RecentChooserDefaultProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RecentChooserDefaultProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RecentChooserDefaultProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RecentChooserDefaultProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RecentChooserDefaultProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RecentChooserDefaultProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RecentChooserDefaultProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RecentChooserDefaultProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RecentChooserDefaultProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RecentChooserDefaultProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RecentChooserDefaultProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RecentChooserDefaultProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RecentChooserDefaultProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RecentChooserDefaultProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RecentChooserDefaultProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RecentChooserDefaultProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RecentChooserDefaultProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RecentChooserDefaultProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RecentChooserDefaultProperty.OnFocused value } 

let prop = RecentChooserDefaultPropertyBuilder()

