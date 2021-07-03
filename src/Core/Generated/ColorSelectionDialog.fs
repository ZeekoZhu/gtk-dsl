module Gtk.DSL.Binding.ColorSelectionDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ColorSelectionDialogProperty =
    | Title of System.String
    | Role of System.String
    | Resizable of System.Boolean
    | Modal of System.Boolean
    | WindowPosition of Gtk.WindowPosition
    | DefaultWidth of System.Int32
    | DefaultHeight of System.Int32
    | DestroyWithParent of System.Boolean
    | HideTitlebarWhenMaximized of System.Boolean
    | Icon of Gdk.Pixbuf
    | MnemonicsVisible of System.Boolean
    | FocusVisible of System.Boolean
    | IconName of System.String
    | Screen of Gdk.Screen
    | TypeHint of Gdk.WindowTypeHint
    | SkipTaskbarHint of System.Boolean
    | SkipPagerHint of System.Boolean
    | UrgencyHint of System.Boolean
    | AcceptFocus of System.Boolean
    | FocusOnMap of System.Boolean
    | Decorated of System.Boolean
    | Deletable of System.Boolean
    | [<Obsolete>] HasResizeGrip of System.Boolean
    | Gravity of Gdk.Gravity
    | TransientFor of Gtk.Window
    | AttachedTo of Gtk.Widget
    | Application of Gtk.Application
    | DecorationResizeHandle of System.Int32
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
    |  OnResponse of (Gtk.ResponseArgs -> unit)
    |  OnEnableDebugging of (Gtk.EnableDebuggingArgs -> unit)
    |  OnSetFocus of (Gtk.SetFocusArgs -> unit)
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

let bindProperty (widget: ColorSelectionDialog) (prop: ColorSelectionDialogProperty) =
    match prop with
    | ColorSelectionDialogProperty.Title value -> widget.Title <- value
    | ColorSelectionDialogProperty.Role value -> widget.Role <- value
    | ColorSelectionDialogProperty.Resizable value -> widget.Resizable <- value
    | ColorSelectionDialogProperty.Modal value -> widget.Modal <- value
    | ColorSelectionDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | ColorSelectionDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | ColorSelectionDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | ColorSelectionDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | ColorSelectionDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | ColorSelectionDialogProperty.Icon value -> widget.Icon <- value
    | ColorSelectionDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | ColorSelectionDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | ColorSelectionDialogProperty.IconName value -> widget.IconName <- value
    | ColorSelectionDialogProperty.Screen value -> widget.Screen <- value
    | ColorSelectionDialogProperty.TypeHint value -> widget.TypeHint <- value
    | ColorSelectionDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | ColorSelectionDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | ColorSelectionDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | ColorSelectionDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | ColorSelectionDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | ColorSelectionDialogProperty.Decorated value -> widget.Decorated <- value
    | ColorSelectionDialogProperty.Deletable value -> widget.Deletable <- value
    | ColorSelectionDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | ColorSelectionDialogProperty.Gravity value -> widget.Gravity <- value
    | ColorSelectionDialogProperty.TransientFor value -> widget.TransientFor <- value
    | ColorSelectionDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | ColorSelectionDialogProperty.Application value -> widget.Application <- value
    | ColorSelectionDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | ColorSelectionDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | ColorSelectionDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | ColorSelectionDialogProperty.Name value -> widget.Name <- value
    | ColorSelectionDialogProperty.Parent value -> widget.Parent <- value
    | ColorSelectionDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | ColorSelectionDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | ColorSelectionDialogProperty.Visible value -> widget.Visible <- value
    | ColorSelectionDialogProperty.Sensitive value -> widget.Sensitive <- value
    | ColorSelectionDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | ColorSelectionDialogProperty.CanFocus value -> widget.CanFocus <- value
    | ColorSelectionDialogProperty.HasFocus value -> widget.HasFocus <- value
    | ColorSelectionDialogProperty.IsFocus value -> widget.IsFocus <- value
    | ColorSelectionDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ColorSelectionDialogProperty.CanDefault value -> widget.CanDefault <- value
    | ColorSelectionDialogProperty.HasDefault value -> widget.HasDefault <- value
    | ColorSelectionDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ColorSelectionDialogProperty.Style value -> widget.Style <- value
    | ColorSelectionDialogProperty.Events value -> widget.Events <- value
    | ColorSelectionDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | ColorSelectionDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | ColorSelectionDialogProperty.TooltipText value -> widget.TooltipText <- value
    | ColorSelectionDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ColorSelectionDialogProperty.Window value -> widget.Window <- value
    | ColorSelectionDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ColorSelectionDialogProperty.Halign value -> widget.Halign <- value
    | ColorSelectionDialogProperty.Valign value -> widget.Valign <- value
    | ColorSelectionDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | ColorSelectionDialogProperty.MarginRight value -> widget.MarginRight <- value
    | ColorSelectionDialogProperty.MarginStart value -> widget.MarginStart <- value
    | ColorSelectionDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | ColorSelectionDialogProperty.MarginTop value -> widget.MarginTop <- value
    | ColorSelectionDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | ColorSelectionDialogProperty.Margin value -> widget.Margin <- value
    | ColorSelectionDialogProperty.Hexpand value -> widget.Hexpand <- value
    | ColorSelectionDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | ColorSelectionDialogProperty.Vexpand value -> widget.Vexpand <- value
    | ColorSelectionDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | ColorSelectionDialogProperty.Expand value -> widget.Expand <- value
    | ColorSelectionDialogProperty.Opacity value -> widget.Opacity <- value
    | ColorSelectionDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | ColorSelectionDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | ColorSelectionDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | ColorSelectionDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ColorSelectionDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ColorSelectionDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ColorSelectionDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ColorSelectionDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ColorSelectionDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ColorSelectionDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ColorSelectionDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ColorSelectionDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ColorSelectionDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ColorSelectionDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ColorSelectionDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ColorSelectionDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ColorSelectionDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ColorSelectionDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ColorSelectionDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ColorSelectionDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ColorSelectionDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ColorSelectionDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ColorSelectionDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ColorSelectionDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ColorSelectionDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ColorSelectionDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ColorSelectionDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ColorSelectionDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ColorSelectionDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ColorSelectionDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ColorSelectionDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ColorSelectionDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ColorSelectionDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ColorSelectionDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ColorSelectionDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ColorSelectionDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ColorSelectionDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ColorSelectionDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ColorSelectionDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ColorSelectionDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ColorSelectionDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ColorSelectionDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ColorSelectionDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ColorSelectionDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ColorSelectionDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ColorSelectionDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ColorSelectionDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ColorSelectionDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ColorSelectionDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ColorSelectionDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ColorSelectionDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ColorSelectionDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ColorSelectionDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ColorSelectionDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ColorSelectionDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ColorSelectionDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ColorSelectionDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ColorSelectionDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ColorSelectionDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ColorSelectionDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ColorSelectionDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ColorSelectionDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ColorSelectionDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ColorSelectionDialogPropertyBuilder() =
    inherit BasePropertyBuilder<ColorSelectionDialogProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: ColorSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: ColorSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: ColorSelectionDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield ColorSelectionDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: ColorSelectionDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield ColorSelectionDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ColorSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: ColorSelectionDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield ColorSelectionDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: ColorSelectionDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield ColorSelectionDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: ColorSelectionDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield ColorSelectionDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: ColorSelectionDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield ColorSelectionDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: ColorSelectionDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorSelectionDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: ColorSelectionDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield ColorSelectionDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ColorSelectionDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ColorSelectionDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ColorSelectionDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorSelectionDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ColorSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ColorSelectionDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorSelectionDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ColorSelectionDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ColorSelectionDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ColorSelectionDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ColorSelectionDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ColorSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ColorSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorSelectionDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ColorSelectionDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ColorSelectionDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ColorSelectionDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorSelectionDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ColorSelectionDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorSelectionDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ColorSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorSelectionDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ColorSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorSelectionDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ColorSelectionDialogProperty seq, value: System.Double) =
        seq { yield! it; yield ColorSelectionDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: ColorSelectionDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: ColorSelectionDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: ColorSelectionDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ColorSelectionDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ColorSelectionDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ColorSelectionDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ColorSelectionDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ColorSelectionDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ColorSelectionDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ColorSelectionDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ColorSelectionDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ColorSelectionDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ColorSelectionDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ColorSelectionDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ColorSelectionDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ColorSelectionDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ColorSelectionDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ColorSelectionDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ColorSelectionDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ColorSelectionDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ColorSelectionDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ColorSelectionDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ColorSelectionDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ColorSelectionDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ColorSelectionDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ColorSelectionDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ColorSelectionDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ColorSelectionDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ColorSelectionDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ColorSelectionDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ColorSelectionDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ColorSelectionDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ColorSelectionDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ColorSelectionDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ColorSelectionDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ColorSelectionDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ColorSelectionDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ColorSelectionDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ColorSelectionDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ColorSelectionDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ColorSelectionDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ColorSelectionDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ColorSelectionDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ColorSelectionDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ColorSelectionDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ColorSelectionDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ColorSelectionDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ColorSelectionDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ColorSelectionDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ColorSelectionDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ColorSelectionDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ColorSelectionDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ColorSelectionDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ColorSelectionDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ColorSelectionDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ColorSelectionDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ColorSelectionDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ColorSelectionDialogProperty.OnFocused value } 

let prop = ColorSelectionDialogPropertyBuilder()

