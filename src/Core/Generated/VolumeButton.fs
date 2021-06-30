module GtkDsl.Binding.VolumeButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type VolumeButtonProperty =
    | UseSymbolic of System.Boolean
    | Value of System.Double
    | Size of Gtk.IconSize
    | Adjustment of Gtk.Adjustment
    | Icons of System.String[]
    | Orientation of Gtk.Orientation
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
    |  OnValueChanged of (Gtk.ValueChangedArgs -> unit)
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

let bindProperty (widget: VolumeButton) (prop: VolumeButtonProperty) =
    match prop with
    | VolumeButtonProperty.UseSymbolic value -> widget.UseSymbolic <- value
    | VolumeButtonProperty.Value value -> widget.Value <- value
    | VolumeButtonProperty.Size value -> widget.Size <- value
    | VolumeButtonProperty.Adjustment value -> widget.Adjustment <- value
    | VolumeButtonProperty.Icons value -> widget.Icons <- value
    | VolumeButtonProperty.Orientation value -> widget.Orientation <- value
    | VolumeButtonProperty.Label value -> widget.Label <- value
    | VolumeButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | VolumeButtonProperty.UseStock value -> widget.UseStock <- value
    | VolumeButtonProperty.Relief value -> widget.Relief <- value
    | VolumeButtonProperty.Xalign value -> widget.Xalign <- value
    | VolumeButtonProperty.Yalign value -> widget.Yalign <- value
    | VolumeButtonProperty.Image value -> widget.Image <- value
    | VolumeButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | VolumeButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | VolumeButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | VolumeButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | VolumeButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | VolumeButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | VolumeButtonProperty.Name value -> widget.Name <- value
    | VolumeButtonProperty.Parent value -> widget.Parent <- value
    | VolumeButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | VolumeButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | VolumeButtonProperty.Visible value -> widget.Visible <- value
    | VolumeButtonProperty.Sensitive value -> widget.Sensitive <- value
    | VolumeButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | VolumeButtonProperty.CanFocus value -> widget.CanFocus <- value
    | VolumeButtonProperty.HasFocus value -> widget.HasFocus <- value
    | VolumeButtonProperty.IsFocus value -> widget.IsFocus <- value
    | VolumeButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | VolumeButtonProperty.CanDefault value -> widget.CanDefault <- value
    | VolumeButtonProperty.HasDefault value -> widget.HasDefault <- value
    | VolumeButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | VolumeButtonProperty.Style value -> widget.Style <- value
    | VolumeButtonProperty.Events value -> widget.Events <- value
    | VolumeButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | VolumeButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | VolumeButtonProperty.TooltipText value -> widget.TooltipText <- value
    | VolumeButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | VolumeButtonProperty.Window value -> widget.Window <- value
    | VolumeButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | VolumeButtonProperty.Halign value -> widget.Halign <- value
    | VolumeButtonProperty.Valign value -> widget.Valign <- value
    | VolumeButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | VolumeButtonProperty.MarginRight value -> widget.MarginRight <- value
    | VolumeButtonProperty.MarginStart value -> widget.MarginStart <- value
    | VolumeButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | VolumeButtonProperty.MarginTop value -> widget.MarginTop <- value
    | VolumeButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | VolumeButtonProperty.Margin value -> widget.Margin <- value
    | VolumeButtonProperty.Hexpand value -> widget.Hexpand <- value
    | VolumeButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | VolumeButtonProperty.Vexpand value -> widget.Vexpand <- value
    | VolumeButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | VolumeButtonProperty.Expand value -> widget.Expand <- value
    | VolumeButtonProperty.Opacity value -> widget.Opacity <- value
    | VolumeButtonProperty.OnValueChanged handler -> 
        let disposable = widget.ValueChanged.Subscribe(handler)
        registerListener widget "ValueChanged" disposable
    | VolumeButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | VolumeButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | VolumeButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | VolumeButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | VolumeButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | VolumeButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | VolumeButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | VolumeButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | VolumeButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | VolumeButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | VolumeButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | VolumeButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | VolumeButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | VolumeButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | VolumeButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | VolumeButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | VolumeButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | VolumeButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | VolumeButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | VolumeButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | VolumeButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | VolumeButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | VolumeButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | VolumeButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | VolumeButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | VolumeButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | VolumeButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | VolumeButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | VolumeButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | VolumeButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | VolumeButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | VolumeButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | VolumeButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | VolumeButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | VolumeButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | VolumeButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | VolumeButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | VolumeButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | VolumeButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | VolumeButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | VolumeButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | VolumeButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | VolumeButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | VolumeButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | VolumeButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | VolumeButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | VolumeButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | VolumeButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | VolumeButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | VolumeButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | VolumeButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | VolumeButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | VolumeButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | VolumeButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | VolumeButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | VolumeButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | VolumeButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | VolumeButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | VolumeButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | VolumeButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type VolumeButtonPropertyBuilder() =
    inherit BasePropertyBuilder<VolumeButtonProperty>()
    [<CustomOperation("useSymbolic")>]
    member this.UseSymbolic(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.UseSymbolic value } 
    [<CustomOperation("value")>]
    member this.Value(it: VolumeButtonProperty seq, value: System.Double) =
        seq { yield! it; yield VolumeButtonProperty.Value value } 
    [<CustomOperation("size")>]
    member this.Size(it: VolumeButtonProperty seq, value: Gtk.IconSize) =
        seq { yield! it; yield VolumeButtonProperty.Size value } 
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: VolumeButtonProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield VolumeButtonProperty.Adjustment value } 
    [<CustomOperation("icons")>]
    member this.Icons(it: VolumeButtonProperty seq, value: System.String[]) =
        seq { yield! it; yield VolumeButtonProperty.Icons value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: VolumeButtonProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield VolumeButtonProperty.Orientation value } 
    [<CustomOperation("label")>]
    member this.Label(it: VolumeButtonProperty seq, value: System.String) =
        seq { yield! it; yield VolumeButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: VolumeButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield VolumeButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: VolumeButtonProperty seq, value: System.Single) =
        seq { yield! it; yield VolumeButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: VolumeButtonProperty seq, value: System.Single) =
        seq { yield! it; yield VolumeButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: VolumeButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VolumeButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: VolumeButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield VolumeButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: VolumeButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield VolumeButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: VolumeButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield VolumeButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: VolumeButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield VolumeButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: VolumeButtonProperty seq, value: System.String) =
        seq { yield! it; yield VolumeButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: VolumeButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield VolumeButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: VolumeButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield VolumeButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: VolumeButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield VolumeButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: VolumeButtonProperty seq, value: System.String) =
        seq { yield! it; yield VolumeButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: VolumeButtonProperty seq, value: System.String) =
        seq { yield! it; yield VolumeButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: VolumeButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield VolumeButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: VolumeButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VolumeButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: VolumeButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield VolumeButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: VolumeButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield VolumeButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: VolumeButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield VolumeButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: VolumeButtonProperty seq, value: System.Double) =
        seq { yield! it; yield VolumeButtonProperty.Opacity value } 
    [<CustomOperation("onValueChanged")>]
    member this.OnValueChanged(it: VolumeButtonProperty seq, value: Gtk.ValueChangedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnValueChanged value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: VolumeButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: VolumeButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: VolumeButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: VolumeButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: VolumeButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: VolumeButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: VolumeButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: VolumeButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: VolumeButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: VolumeButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: VolumeButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: VolumeButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: VolumeButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: VolumeButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: VolumeButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: VolumeButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: VolumeButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: VolumeButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: VolumeButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: VolumeButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: VolumeButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: VolumeButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: VolumeButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: VolumeButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: VolumeButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: VolumeButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: VolumeButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: VolumeButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: VolumeButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: VolumeButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: VolumeButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: VolumeButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: VolumeButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: VolumeButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: VolumeButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: VolumeButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: VolumeButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: VolumeButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: VolumeButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: VolumeButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: VolumeButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: VolumeButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: VolumeButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: VolumeButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: VolumeButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: VolumeButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: VolumeButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: VolumeButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: VolumeButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: VolumeButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: VolumeButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: VolumeButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: VolumeButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: VolumeButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: VolumeButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: VolumeButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: VolumeButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: VolumeButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: VolumeButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: VolumeButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield VolumeButtonProperty.OnFocused value } 

let prop = VolumeButtonPropertyBuilder()

type VolumeButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<VolumeButton, VolumeButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new VolumeButton()

let volumeButton props = VolumeButtonDescriptor(props)

