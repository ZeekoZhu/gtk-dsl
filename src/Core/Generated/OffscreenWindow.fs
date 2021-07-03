module Gtk.DSL.Binding.OffscreenWindow
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type OffscreenWindowProperty =
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

let bindProperty (widget: OffscreenWindow) (prop: OffscreenWindowProperty) =
    match prop with
    | OffscreenWindowProperty.Title value -> widget.Title <- value
    | OffscreenWindowProperty.Role value -> widget.Role <- value
    | OffscreenWindowProperty.Resizable value -> widget.Resizable <- value
    | OffscreenWindowProperty.Modal value -> widget.Modal <- value
    | OffscreenWindowProperty.WindowPosition value -> widget.WindowPosition <- value
    | OffscreenWindowProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | OffscreenWindowProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | OffscreenWindowProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | OffscreenWindowProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | OffscreenWindowProperty.Icon value -> widget.Icon <- value
    | OffscreenWindowProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | OffscreenWindowProperty.FocusVisible value -> widget.FocusVisible <- value
    | OffscreenWindowProperty.IconName value -> widget.IconName <- value
    | OffscreenWindowProperty.Screen value -> widget.Screen <- value
    | OffscreenWindowProperty.TypeHint value -> widget.TypeHint <- value
    | OffscreenWindowProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | OffscreenWindowProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | OffscreenWindowProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | OffscreenWindowProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | OffscreenWindowProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | OffscreenWindowProperty.Decorated value -> widget.Decorated <- value
    | OffscreenWindowProperty.Deletable value -> widget.Deletable <- value
    | OffscreenWindowProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | OffscreenWindowProperty.Gravity value -> widget.Gravity <- value
    | OffscreenWindowProperty.TransientFor value -> widget.TransientFor <- value
    | OffscreenWindowProperty.AttachedTo value -> widget.AttachedTo <- value
    | OffscreenWindowProperty.Application value -> widget.Application <- value
    | OffscreenWindowProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | OffscreenWindowProperty.ResizeMode value -> widget.ResizeMode <- value
    | OffscreenWindowProperty.BorderWidth value -> widget.BorderWidth <- value
    | OffscreenWindowProperty.Name value -> widget.Name <- value
    | OffscreenWindowProperty.Parent value -> widget.Parent <- value
    | OffscreenWindowProperty.WidthRequest value -> widget.WidthRequest <- value
    | OffscreenWindowProperty.HeightRequest value -> widget.HeightRequest <- value
    | OffscreenWindowProperty.Visible value -> widget.Visible <- value
    | OffscreenWindowProperty.Sensitive value -> widget.Sensitive <- value
    | OffscreenWindowProperty.AppPaintable value -> widget.AppPaintable <- value
    | OffscreenWindowProperty.CanFocus value -> widget.CanFocus <- value
    | OffscreenWindowProperty.HasFocus value -> widget.HasFocus <- value
    | OffscreenWindowProperty.IsFocus value -> widget.IsFocus <- value
    | OffscreenWindowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | OffscreenWindowProperty.CanDefault value -> widget.CanDefault <- value
    | OffscreenWindowProperty.HasDefault value -> widget.HasDefault <- value
    | OffscreenWindowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | OffscreenWindowProperty.Style value -> widget.Style <- value
    | OffscreenWindowProperty.Events value -> widget.Events <- value
    | OffscreenWindowProperty.NoShowAll value -> widget.NoShowAll <- value
    | OffscreenWindowProperty.HasTooltip value -> widget.HasTooltip <- value
    | OffscreenWindowProperty.TooltipText value -> widget.TooltipText <- value
    | OffscreenWindowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | OffscreenWindowProperty.Window value -> widget.Window <- value
    | OffscreenWindowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | OffscreenWindowProperty.Halign value -> widget.Halign <- value
    | OffscreenWindowProperty.Valign value -> widget.Valign <- value
    | OffscreenWindowProperty.MarginLeft value -> widget.MarginLeft <- value
    | OffscreenWindowProperty.MarginRight value -> widget.MarginRight <- value
    | OffscreenWindowProperty.MarginStart value -> widget.MarginStart <- value
    | OffscreenWindowProperty.MarginEnd value -> widget.MarginEnd <- value
    | OffscreenWindowProperty.MarginTop value -> widget.MarginTop <- value
    | OffscreenWindowProperty.MarginBottom value -> widget.MarginBottom <- value
    | OffscreenWindowProperty.Margin value -> widget.Margin <- value
    | OffscreenWindowProperty.Hexpand value -> widget.Hexpand <- value
    | OffscreenWindowProperty.HexpandSet value -> widget.HexpandSet <- value
    | OffscreenWindowProperty.Vexpand value -> widget.Vexpand <- value
    | OffscreenWindowProperty.VexpandSet value -> widget.VexpandSet <- value
    | OffscreenWindowProperty.Expand value -> widget.Expand <- value
    | OffscreenWindowProperty.Opacity value -> widget.Opacity <- value
    | OffscreenWindowProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | OffscreenWindowProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | OffscreenWindowProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | OffscreenWindowProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | OffscreenWindowProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | OffscreenWindowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | OffscreenWindowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | OffscreenWindowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | OffscreenWindowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | OffscreenWindowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | OffscreenWindowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | OffscreenWindowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | OffscreenWindowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | OffscreenWindowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | OffscreenWindowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | OffscreenWindowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | OffscreenWindowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | OffscreenWindowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | OffscreenWindowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | OffscreenWindowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | OffscreenWindowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | OffscreenWindowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | OffscreenWindowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | OffscreenWindowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | OffscreenWindowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | OffscreenWindowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | OffscreenWindowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | OffscreenWindowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | OffscreenWindowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | OffscreenWindowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | OffscreenWindowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | OffscreenWindowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | OffscreenWindowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | OffscreenWindowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | OffscreenWindowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | OffscreenWindowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | OffscreenWindowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | OffscreenWindowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | OffscreenWindowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | OffscreenWindowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | OffscreenWindowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | OffscreenWindowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | OffscreenWindowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | OffscreenWindowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | OffscreenWindowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | OffscreenWindowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | OffscreenWindowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | OffscreenWindowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | OffscreenWindowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | OffscreenWindowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | OffscreenWindowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | OffscreenWindowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | OffscreenWindowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | OffscreenWindowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | OffscreenWindowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | OffscreenWindowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | OffscreenWindowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | OffscreenWindowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | OffscreenWindowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | OffscreenWindowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | OffscreenWindowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | OffscreenWindowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type OffscreenWindowPropertyBuilder() =
    inherit BasePropertyBuilder<OffscreenWindowProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: OffscreenWindowProperty seq, value: System.String) =
        seq { yield! it; yield OffscreenWindowProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: OffscreenWindowProperty seq, value: System.String) =
        seq { yield! it; yield OffscreenWindowProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: OffscreenWindowProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield OffscreenWindowProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: OffscreenWindowProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield OffscreenWindowProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: OffscreenWindowProperty seq, value: System.String) =
        seq { yield! it; yield OffscreenWindowProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: OffscreenWindowProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield OffscreenWindowProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: OffscreenWindowProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield OffscreenWindowProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: OffscreenWindowProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield OffscreenWindowProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: OffscreenWindowProperty seq, value: Gtk.Window) =
        seq { yield! it; yield OffscreenWindowProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: OffscreenWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield OffscreenWindowProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: OffscreenWindowProperty seq, value: Gtk.Application) =
        seq { yield! it; yield OffscreenWindowProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: OffscreenWindowProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield OffscreenWindowProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: OffscreenWindowProperty seq, value: System.UInt32) =
        seq { yield! it; yield OffscreenWindowProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: OffscreenWindowProperty seq, value: System.String) =
        seq { yield! it; yield OffscreenWindowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: OffscreenWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield OffscreenWindowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: OffscreenWindowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield OffscreenWindowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: OffscreenWindowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield OffscreenWindowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: OffscreenWindowProperty seq, value: System.String) =
        seq { yield! it; yield OffscreenWindowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: OffscreenWindowProperty seq, value: System.String) =
        seq { yield! it; yield OffscreenWindowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: OffscreenWindowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield OffscreenWindowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: OffscreenWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield OffscreenWindowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: OffscreenWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield OffscreenWindowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: OffscreenWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield OffscreenWindowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: OffscreenWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield OffscreenWindowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: OffscreenWindowProperty seq, value: System.Double) =
        seq { yield! it; yield OffscreenWindowProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: OffscreenWindowProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: OffscreenWindowProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: OffscreenWindowProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: OffscreenWindowProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: OffscreenWindowProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: OffscreenWindowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: OffscreenWindowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: OffscreenWindowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: OffscreenWindowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: OffscreenWindowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: OffscreenWindowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: OffscreenWindowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: OffscreenWindowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: OffscreenWindowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: OffscreenWindowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: OffscreenWindowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: OffscreenWindowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: OffscreenWindowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: OffscreenWindowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: OffscreenWindowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: OffscreenWindowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: OffscreenWindowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: OffscreenWindowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: OffscreenWindowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: OffscreenWindowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: OffscreenWindowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: OffscreenWindowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: OffscreenWindowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: OffscreenWindowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: OffscreenWindowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: OffscreenWindowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: OffscreenWindowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: OffscreenWindowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: OffscreenWindowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: OffscreenWindowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: OffscreenWindowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: OffscreenWindowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: OffscreenWindowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: OffscreenWindowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: OffscreenWindowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: OffscreenWindowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: OffscreenWindowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: OffscreenWindowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: OffscreenWindowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: OffscreenWindowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: OffscreenWindowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: OffscreenWindowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: OffscreenWindowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: OffscreenWindowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: OffscreenWindowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: OffscreenWindowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: OffscreenWindowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: OffscreenWindowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: OffscreenWindowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: OffscreenWindowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: OffscreenWindowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: OffscreenWindowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: OffscreenWindowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: OffscreenWindowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: OffscreenWindowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: OffscreenWindowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: OffscreenWindowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield OffscreenWindowProperty.OnFocused value } 

let prop = OffscreenWindowPropertyBuilder()

type OffscreenWindowDescriptor(props) =
    inherit BaseWidgetDescriptor<OffscreenWindow, OffscreenWindowProperty>(props, bindProperty)
    override this.CreateTyped() = new OffscreenWindow()

let offscreenWindow props = OffscreenWindowDescriptor(props)

