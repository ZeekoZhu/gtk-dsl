module GtkDsl.Binding.ScaleButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ScaleButtonProperty =
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

let bindProperty (widget: ScaleButton) (prop: ScaleButtonProperty) =
    match prop with
    | ScaleButtonProperty.Value value -> widget.Value <- value
    | ScaleButtonProperty.Size value -> widget.Size <- value
    | ScaleButtonProperty.Adjustment value -> widget.Adjustment <- value
    | ScaleButtonProperty.Icons value -> widget.Icons <- value
    | ScaleButtonProperty.Orientation value -> widget.Orientation <- value
    | ScaleButtonProperty.Label value -> widget.Label <- value
    | ScaleButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | ScaleButtonProperty.UseStock value -> widget.UseStock <- value
    | ScaleButtonProperty.Relief value -> widget.Relief <- value
    | ScaleButtonProperty.Xalign value -> widget.Xalign <- value
    | ScaleButtonProperty.Yalign value -> widget.Yalign <- value
    | ScaleButtonProperty.Image value -> widget.Image <- value
    | ScaleButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | ScaleButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | ScaleButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | ScaleButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | ScaleButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | ScaleButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | ScaleButtonProperty.Name value -> widget.Name <- value
    | ScaleButtonProperty.Parent value -> widget.Parent <- value
    | ScaleButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | ScaleButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | ScaleButtonProperty.Visible value -> widget.Visible <- value
    | ScaleButtonProperty.Sensitive value -> widget.Sensitive <- value
    | ScaleButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | ScaleButtonProperty.CanFocus value -> widget.CanFocus <- value
    | ScaleButtonProperty.HasFocus value -> widget.HasFocus <- value
    | ScaleButtonProperty.IsFocus value -> widget.IsFocus <- value
    | ScaleButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ScaleButtonProperty.CanDefault value -> widget.CanDefault <- value
    | ScaleButtonProperty.HasDefault value -> widget.HasDefault <- value
    | ScaleButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ScaleButtonProperty.Style value -> widget.Style <- value
    | ScaleButtonProperty.Events value -> widget.Events <- value
    | ScaleButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | ScaleButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | ScaleButtonProperty.TooltipText value -> widget.TooltipText <- value
    | ScaleButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ScaleButtonProperty.Window value -> widget.Window <- value
    | ScaleButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ScaleButtonProperty.Halign value -> widget.Halign <- value
    | ScaleButtonProperty.Valign value -> widget.Valign <- value
    | ScaleButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | ScaleButtonProperty.MarginRight value -> widget.MarginRight <- value
    | ScaleButtonProperty.MarginStart value -> widget.MarginStart <- value
    | ScaleButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | ScaleButtonProperty.MarginTop value -> widget.MarginTop <- value
    | ScaleButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | ScaleButtonProperty.Margin value -> widget.Margin <- value
    | ScaleButtonProperty.Hexpand value -> widget.Hexpand <- value
    | ScaleButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | ScaleButtonProperty.Vexpand value -> widget.Vexpand <- value
    | ScaleButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | ScaleButtonProperty.Expand value -> widget.Expand <- value
    | ScaleButtonProperty.Opacity value -> widget.Opacity <- value
    | ScaleButtonProperty.OnValueChanged handler -> 
        let disposable = widget.ValueChanged.Subscribe(handler)
        registerListener widget "ValueChanged" disposable
    | ScaleButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ScaleButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ScaleButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ScaleButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ScaleButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ScaleButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ScaleButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ScaleButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ScaleButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ScaleButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ScaleButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ScaleButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ScaleButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ScaleButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ScaleButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ScaleButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ScaleButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ScaleButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ScaleButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ScaleButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ScaleButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ScaleButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ScaleButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ScaleButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ScaleButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ScaleButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ScaleButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ScaleButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ScaleButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ScaleButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ScaleButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ScaleButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ScaleButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ScaleButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ScaleButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ScaleButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ScaleButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ScaleButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ScaleButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ScaleButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ScaleButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ScaleButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ScaleButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ScaleButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ScaleButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ScaleButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ScaleButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ScaleButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ScaleButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ScaleButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ScaleButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ScaleButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ScaleButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ScaleButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ScaleButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ScaleButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ScaleButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ScaleButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ScaleButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ScaleButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ScaleButtonPropertyBuilder() =
    inherit BasePropertyBuilder<ScaleButtonProperty>()
    [<CustomOperation("value")>]
    member this.Value(it: ScaleButtonProperty seq, value: System.Double) =
        seq { yield! it; yield ScaleButtonProperty.Value value } 
    [<CustomOperation("size")>]
    member this.Size(it: ScaleButtonProperty seq, value: Gtk.IconSize) =
        seq { yield! it; yield ScaleButtonProperty.Size value } 
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: ScaleButtonProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield ScaleButtonProperty.Adjustment value } 
    [<CustomOperation("icons")>]
    member this.Icons(it: ScaleButtonProperty seq, value: System.String[]) =
        seq { yield! it; yield ScaleButtonProperty.Icons value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: ScaleButtonProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield ScaleButtonProperty.Orientation value } 
    [<CustomOperation("label")>]
    member this.Label(it: ScaleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ScaleButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: ScaleButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield ScaleButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: ScaleButtonProperty seq, value: System.Single) =
        seq { yield! it; yield ScaleButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: ScaleButtonProperty seq, value: System.Single) =
        seq { yield! it; yield ScaleButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: ScaleButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ScaleButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: ScaleButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield ScaleButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: ScaleButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield ScaleButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ScaleButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ScaleButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ScaleButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield ScaleButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ScaleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ScaleButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ScaleButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ScaleButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ScaleButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ScaleButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ScaleButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ScaleButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ScaleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ScaleButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ScaleButtonProperty seq, value: System.String) =
        seq { yield! it; yield ScaleButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ScaleButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ScaleButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ScaleButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScaleButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ScaleButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ScaleButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ScaleButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield ScaleButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ScaleButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield ScaleButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ScaleButtonProperty seq, value: System.Double) =
        seq { yield! it; yield ScaleButtonProperty.Opacity value } 
    [<CustomOperation("onValueChanged")>]
    member this.OnValueChanged(it: ScaleButtonProperty seq, value: Gtk.ValueChangedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnValueChanged value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ScaleButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ScaleButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ScaleButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ScaleButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ScaleButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ScaleButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ScaleButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ScaleButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ScaleButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ScaleButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ScaleButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ScaleButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ScaleButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ScaleButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ScaleButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ScaleButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ScaleButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ScaleButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ScaleButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ScaleButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ScaleButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ScaleButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ScaleButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ScaleButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ScaleButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ScaleButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ScaleButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ScaleButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ScaleButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ScaleButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ScaleButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ScaleButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ScaleButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ScaleButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ScaleButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ScaleButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ScaleButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ScaleButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ScaleButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ScaleButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ScaleButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ScaleButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ScaleButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ScaleButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ScaleButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ScaleButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ScaleButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ScaleButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ScaleButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ScaleButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ScaleButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ScaleButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ScaleButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ScaleButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ScaleButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ScaleButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ScaleButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ScaleButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ScaleButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ScaleButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ScaleButtonProperty.OnFocused value } 

let prop = ScaleButtonPropertyBuilder()

