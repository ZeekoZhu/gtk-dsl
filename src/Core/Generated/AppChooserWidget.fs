module Gtk.DSL.Binding.AppChooserWidget
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AppChooserWidgetProperty =
    | ShowDefault of System.Boolean
    | ShowRecommended of System.Boolean
    | ShowFallback of System.Boolean
    | ShowOther of System.Boolean
    | ShowAll of System.Boolean
    | DefaultText of System.String
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
    |  OnApplicationSelected of (Gtk.ApplicationSelectedArgs -> unit)
    |  OnPopulatePopup of (Gtk.PopulatePopupArgs -> unit)
    |  OnApplicationActivated of (Gtk.ApplicationActivatedArgs -> unit)
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

let bindProperty (widget: AppChooserWidget) (prop: AppChooserWidgetProperty) =
    match prop with
    | AppChooserWidgetProperty.ShowDefault value -> widget.ShowDefault <- value
    | AppChooserWidgetProperty.ShowRecommended value -> widget.ShowRecommended <- value
    | AppChooserWidgetProperty.ShowFallback value -> widget.ShowFallback <- value
    | AppChooserWidgetProperty.ShowOther value -> widget.ShowOther <- value
    | AppChooserWidgetProperty.ShowAll value -> widget.ShowAll <- value
    | AppChooserWidgetProperty.DefaultText value -> widget.DefaultText <- value
    | AppChooserWidgetProperty.Spacing value -> widget.Spacing <- value
    | AppChooserWidgetProperty.Homogeneous value -> widget.Homogeneous <- value
    | AppChooserWidgetProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | AppChooserWidgetProperty.Expand value -> widget.Expand <- value
    | AppChooserWidgetProperty.Fill value -> widget.Fill <- value
    | AppChooserWidgetProperty.Padding value -> widget.Padding <- value
    | AppChooserWidgetProperty.PackType value -> widget.PackType <- value
    | AppChooserWidgetProperty.Position value -> widget.Position <- value
    | AppChooserWidgetProperty.Orientation value -> widget.Orientation <- value
    | AppChooserWidgetProperty.ResizeMode value -> widget.ResizeMode <- value
    | AppChooserWidgetProperty.BorderWidth value -> widget.BorderWidth <- value
    | AppChooserWidgetProperty.Name value -> widget.Name <- value
    | AppChooserWidgetProperty.Parent value -> widget.Parent <- value
    | AppChooserWidgetProperty.WidthRequest value -> widget.WidthRequest <- value
    | AppChooserWidgetProperty.HeightRequest value -> widget.HeightRequest <- value
    | AppChooserWidgetProperty.Visible value -> widget.Visible <- value
    | AppChooserWidgetProperty.Sensitive value -> widget.Sensitive <- value
    | AppChooserWidgetProperty.AppPaintable value -> widget.AppPaintable <- value
    | AppChooserWidgetProperty.CanFocus value -> widget.CanFocus <- value
    | AppChooserWidgetProperty.HasFocus value -> widget.HasFocus <- value
    | AppChooserWidgetProperty.IsFocus value -> widget.IsFocus <- value
    | AppChooserWidgetProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AppChooserWidgetProperty.CanDefault value -> widget.CanDefault <- value
    | AppChooserWidgetProperty.HasDefault value -> widget.HasDefault <- value
    | AppChooserWidgetProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AppChooserWidgetProperty.Style value -> widget.Style <- value
    | AppChooserWidgetProperty.Events value -> widget.Events <- value
    | AppChooserWidgetProperty.NoShowAll value -> widget.NoShowAll <- value
    | AppChooserWidgetProperty.HasTooltip value -> widget.HasTooltip <- value
    | AppChooserWidgetProperty.TooltipText value -> widget.TooltipText <- value
    | AppChooserWidgetProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AppChooserWidgetProperty.Window value -> widget.Window <- value
    | AppChooserWidgetProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AppChooserWidgetProperty.Halign value -> widget.Halign <- value
    | AppChooserWidgetProperty.Valign value -> widget.Valign <- value
    | AppChooserWidgetProperty.MarginLeft value -> widget.MarginLeft <- value
    | AppChooserWidgetProperty.MarginRight value -> widget.MarginRight <- value
    | AppChooserWidgetProperty.MarginStart value -> widget.MarginStart <- value
    | AppChooserWidgetProperty.MarginEnd value -> widget.MarginEnd <- value
    | AppChooserWidgetProperty.MarginTop value -> widget.MarginTop <- value
    | AppChooserWidgetProperty.MarginBottom value -> widget.MarginBottom <- value
    | AppChooserWidgetProperty.Margin value -> widget.Margin <- value
    | AppChooserWidgetProperty.Hexpand value -> widget.Hexpand <- value
    | AppChooserWidgetProperty.HexpandSet value -> widget.HexpandSet <- value
    | AppChooserWidgetProperty.Vexpand value -> widget.Vexpand <- value
    | AppChooserWidgetProperty.VexpandSet value -> widget.VexpandSet <- value
    | AppChooserWidgetProperty.Opacity value -> widget.Opacity <- value
    | AppChooserWidgetProperty.OnApplicationSelected handler -> 
        let disposable = widget.ApplicationSelected.Subscribe(handler)
        registerListener widget "ApplicationSelected" disposable
    | AppChooserWidgetProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | AppChooserWidgetProperty.OnApplicationActivated handler -> 
        let disposable = widget.ApplicationActivated.Subscribe(handler)
        registerListener widget "ApplicationActivated" disposable
    | AppChooserWidgetProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | AppChooserWidgetProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | AppChooserWidgetProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | AppChooserWidgetProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AppChooserWidgetProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AppChooserWidgetProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AppChooserWidgetProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AppChooserWidgetProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AppChooserWidgetProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AppChooserWidgetProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AppChooserWidgetProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AppChooserWidgetProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AppChooserWidgetProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AppChooserWidgetProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AppChooserWidgetProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AppChooserWidgetProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AppChooserWidgetProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AppChooserWidgetProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AppChooserWidgetProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AppChooserWidgetProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AppChooserWidgetProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AppChooserWidgetProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AppChooserWidgetProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AppChooserWidgetProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AppChooserWidgetProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AppChooserWidgetProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AppChooserWidgetProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AppChooserWidgetProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AppChooserWidgetProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AppChooserWidgetProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AppChooserWidgetProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AppChooserWidgetProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AppChooserWidgetProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AppChooserWidgetProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AppChooserWidgetProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AppChooserWidgetProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AppChooserWidgetProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AppChooserWidgetProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AppChooserWidgetProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AppChooserWidgetProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AppChooserWidgetProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AppChooserWidgetProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AppChooserWidgetProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AppChooserWidgetProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AppChooserWidgetProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AppChooserWidgetProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AppChooserWidgetProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AppChooserWidgetProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AppChooserWidgetProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AppChooserWidgetProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AppChooserWidgetProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AppChooserWidgetProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AppChooserWidgetProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AppChooserWidgetProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AppChooserWidgetProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AppChooserWidgetProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AppChooserWidgetProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AppChooserWidgetProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AppChooserWidgetProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AppChooserWidgetProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AppChooserWidgetPropertyBuilder() =
    inherit BasePropertyBuilder<AppChooserWidgetProperty>()
    [<CustomOperation("showDefault")>]
    member this.ShowDefault(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.ShowDefault value } 
    [<CustomOperation("showRecommended")>]
    member this.ShowRecommended(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.ShowRecommended value } 
    [<CustomOperation("showFallback")>]
    member this.ShowFallback(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.ShowFallback value } 
    [<CustomOperation("showOther")>]
    member this.ShowOther(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.ShowOther value } 
    [<CustomOperation("showAll")>]
    member this.ShowAll(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.ShowAll value } 
    [<CustomOperation("defaultText")>]
    member this.DefaultText(it: AppChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserWidgetProperty.DefaultText value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: AppChooserWidgetProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield AppChooserWidgetProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: AppChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield AppChooserWidgetProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: AppChooserWidgetProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield AppChooserWidgetProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: AppChooserWidgetProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield AppChooserWidgetProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: AppChooserWidgetProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield AppChooserWidgetProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: AppChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield AppChooserWidgetProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: AppChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserWidgetProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AppChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AppChooserWidgetProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AppChooserWidgetProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AppChooserWidgetProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AppChooserWidgetProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AppChooserWidgetProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AppChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserWidgetProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AppChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserWidgetProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AppChooserWidgetProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AppChooserWidgetProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AppChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AppChooserWidgetProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AppChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AppChooserWidgetProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AppChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserWidgetProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AppChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserWidgetProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AppChooserWidgetProperty seq, value: System.Double) =
        seq { yield! it; yield AppChooserWidgetProperty.Opacity value } 
    [<CustomOperation("onApplicationSelected")>]
    member this.OnApplicationSelected(it: AppChooserWidgetProperty seq, value: Gtk.ApplicationSelectedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnApplicationSelected value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: AppChooserWidgetProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnPopulatePopup value } 
    [<CustomOperation("onApplicationActivated")>]
    member this.OnApplicationActivated(it: AppChooserWidgetProperty seq, value: Gtk.ApplicationActivatedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnApplicationActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: AppChooserWidgetProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: AppChooserWidgetProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: AppChooserWidgetProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AppChooserWidgetProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AppChooserWidgetProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AppChooserWidgetProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AppChooserWidgetProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AppChooserWidgetProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AppChooserWidgetProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AppChooserWidgetProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AppChooserWidgetProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AppChooserWidgetProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AppChooserWidgetProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AppChooserWidgetProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AppChooserWidgetProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AppChooserWidgetProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AppChooserWidgetProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AppChooserWidgetProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AppChooserWidgetProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AppChooserWidgetProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AppChooserWidgetProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AppChooserWidgetProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AppChooserWidgetProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AppChooserWidgetProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AppChooserWidgetProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AppChooserWidgetProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AppChooserWidgetProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AppChooserWidgetProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AppChooserWidgetProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AppChooserWidgetProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AppChooserWidgetProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AppChooserWidgetProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AppChooserWidgetProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AppChooserWidgetProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AppChooserWidgetProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AppChooserWidgetProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AppChooserWidgetProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AppChooserWidgetProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AppChooserWidgetProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AppChooserWidgetProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AppChooserWidgetProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AppChooserWidgetProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AppChooserWidgetProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AppChooserWidgetProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AppChooserWidgetProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AppChooserWidgetProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AppChooserWidgetProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AppChooserWidgetProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AppChooserWidgetProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AppChooserWidgetProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AppChooserWidgetProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AppChooserWidgetProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AppChooserWidgetProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AppChooserWidgetProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AppChooserWidgetProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AppChooserWidgetProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AppChooserWidgetProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AppChooserWidgetProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AppChooserWidgetProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AppChooserWidgetProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AppChooserWidgetProperty.OnFocused value } 

let prop = AppChooserWidgetPropertyBuilder()

