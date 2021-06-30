module GtkDsl.Binding.TrayIcon
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type TrayIconProperty =
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

let bindProperty (widget: TrayIcon) (prop: TrayIconProperty) =
    match prop with
    | TrayIconProperty.Title value -> widget.Title <- value
    | TrayIconProperty.Role value -> widget.Role <- value
    | TrayIconProperty.Resizable value -> widget.Resizable <- value
    | TrayIconProperty.Modal value -> widget.Modal <- value
    | TrayIconProperty.WindowPosition value -> widget.WindowPosition <- value
    | TrayIconProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | TrayIconProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | TrayIconProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | TrayIconProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | TrayIconProperty.Icon value -> widget.Icon <- value
    | TrayIconProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | TrayIconProperty.FocusVisible value -> widget.FocusVisible <- value
    | TrayIconProperty.IconName value -> widget.IconName <- value
    | TrayIconProperty.Screen value -> widget.Screen <- value
    | TrayIconProperty.TypeHint value -> widget.TypeHint <- value
    | TrayIconProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | TrayIconProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | TrayIconProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | TrayIconProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | TrayIconProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | TrayIconProperty.Decorated value -> widget.Decorated <- value
    | TrayIconProperty.Deletable value -> widget.Deletable <- value
    | TrayIconProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | TrayIconProperty.Gravity value -> widget.Gravity <- value
    | TrayIconProperty.TransientFor value -> widget.TransientFor <- value
    | TrayIconProperty.AttachedTo value -> widget.AttachedTo <- value
    | TrayIconProperty.Application value -> widget.Application <- value
    | TrayIconProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | TrayIconProperty.ResizeMode value -> widget.ResizeMode <- value
    | TrayIconProperty.BorderWidth value -> widget.BorderWidth <- value
    | TrayIconProperty.Name value -> widget.Name <- value
    | TrayIconProperty.Parent value -> widget.Parent <- value
    | TrayIconProperty.WidthRequest value -> widget.WidthRequest <- value
    | TrayIconProperty.HeightRequest value -> widget.HeightRequest <- value
    | TrayIconProperty.Visible value -> widget.Visible <- value
    | TrayIconProperty.Sensitive value -> widget.Sensitive <- value
    | TrayIconProperty.AppPaintable value -> widget.AppPaintable <- value
    | TrayIconProperty.CanFocus value -> widget.CanFocus <- value
    | TrayIconProperty.HasFocus value -> widget.HasFocus <- value
    | TrayIconProperty.IsFocus value -> widget.IsFocus <- value
    | TrayIconProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | TrayIconProperty.CanDefault value -> widget.CanDefault <- value
    | TrayIconProperty.HasDefault value -> widget.HasDefault <- value
    | TrayIconProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | TrayIconProperty.Style value -> widget.Style <- value
    | TrayIconProperty.Events value -> widget.Events <- value
    | TrayIconProperty.NoShowAll value -> widget.NoShowAll <- value
    | TrayIconProperty.HasTooltip value -> widget.HasTooltip <- value
    | TrayIconProperty.TooltipText value -> widget.TooltipText <- value
    | TrayIconProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | TrayIconProperty.Window value -> widget.Window <- value
    | TrayIconProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | TrayIconProperty.Halign value -> widget.Halign <- value
    | TrayIconProperty.Valign value -> widget.Valign <- value
    | TrayIconProperty.MarginLeft value -> widget.MarginLeft <- value
    | TrayIconProperty.MarginRight value -> widget.MarginRight <- value
    | TrayIconProperty.MarginStart value -> widget.MarginStart <- value
    | TrayIconProperty.MarginEnd value -> widget.MarginEnd <- value
    | TrayIconProperty.MarginTop value -> widget.MarginTop <- value
    | TrayIconProperty.MarginBottom value -> widget.MarginBottom <- value
    | TrayIconProperty.Margin value -> widget.Margin <- value
    | TrayIconProperty.Hexpand value -> widget.Hexpand <- value
    | TrayIconProperty.HexpandSet value -> widget.HexpandSet <- value
    | TrayIconProperty.Vexpand value -> widget.Vexpand <- value
    | TrayIconProperty.VexpandSet value -> widget.VexpandSet <- value
    | TrayIconProperty.Expand value -> widget.Expand <- value
    | TrayIconProperty.Opacity value -> widget.Opacity <- value
    | TrayIconProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | TrayIconProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | TrayIconProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | TrayIconProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | TrayIconProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | TrayIconProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | TrayIconProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | TrayIconProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | TrayIconProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | TrayIconProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | TrayIconProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | TrayIconProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | TrayIconProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | TrayIconProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | TrayIconProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | TrayIconProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | TrayIconProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | TrayIconProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | TrayIconProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | TrayIconProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | TrayIconProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | TrayIconProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | TrayIconProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | TrayIconProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | TrayIconProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | TrayIconProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | TrayIconProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | TrayIconProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | TrayIconProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | TrayIconProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | TrayIconProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | TrayIconProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | TrayIconProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | TrayIconProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | TrayIconProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | TrayIconProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | TrayIconProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | TrayIconProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | TrayIconProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | TrayIconProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | TrayIconProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | TrayIconProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | TrayIconProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | TrayIconProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | TrayIconProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | TrayIconProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | TrayIconProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | TrayIconProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | TrayIconProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | TrayIconProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | TrayIconProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | TrayIconProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | TrayIconProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | TrayIconProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | TrayIconProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | TrayIconProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | TrayIconProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | TrayIconProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | TrayIconProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | TrayIconProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | TrayIconProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | TrayIconProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type TrayIconPropertyBuilder() =
    inherit BasePropertyBuilder<TrayIconProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: TrayIconProperty seq, value: System.String) =
        seq { yield! it; yield TrayIconProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: TrayIconProperty seq, value: System.String) =
        seq { yield! it; yield TrayIconProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: TrayIconProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield TrayIconProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: TrayIconProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield TrayIconProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: TrayIconProperty seq, value: System.String) =
        seq { yield! it; yield TrayIconProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: TrayIconProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield TrayIconProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: TrayIconProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield TrayIconProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: TrayIconProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield TrayIconProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: TrayIconProperty seq, value: Gtk.Window) =
        seq { yield! it; yield TrayIconProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: TrayIconProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TrayIconProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: TrayIconProperty seq, value: Gtk.Application) =
        seq { yield! it; yield TrayIconProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: TrayIconProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield TrayIconProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: TrayIconProperty seq, value: System.UInt32) =
        seq { yield! it; yield TrayIconProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: TrayIconProperty seq, value: System.String) =
        seq { yield! it; yield TrayIconProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: TrayIconProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield TrayIconProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: TrayIconProperty seq, value: Gtk.Style) =
        seq { yield! it; yield TrayIconProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: TrayIconProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield TrayIconProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: TrayIconProperty seq, value: System.String) =
        seq { yield! it; yield TrayIconProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: TrayIconProperty seq, value: System.String) =
        seq { yield! it; yield TrayIconProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: TrayIconProperty seq, value: Gdk.Window) =
        seq { yield! it; yield TrayIconProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: TrayIconProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TrayIconProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: TrayIconProperty seq, value: Gtk.Align) =
        seq { yield! it; yield TrayIconProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: TrayIconProperty seq, value: System.Int32) =
        seq { yield! it; yield TrayIconProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: TrayIconProperty seq, value: System.Boolean) =
        seq { yield! it; yield TrayIconProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: TrayIconProperty seq, value: System.Double) =
        seq { yield! it; yield TrayIconProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: TrayIconProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: TrayIconProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: TrayIconProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: TrayIconProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: TrayIconProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: TrayIconProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: TrayIconProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: TrayIconProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: TrayIconProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: TrayIconProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: TrayIconProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: TrayIconProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: TrayIconProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: TrayIconProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: TrayIconProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: TrayIconProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: TrayIconProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: TrayIconProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: TrayIconProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: TrayIconProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: TrayIconProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: TrayIconProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: TrayIconProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: TrayIconProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: TrayIconProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: TrayIconProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: TrayIconProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: TrayIconProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: TrayIconProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: TrayIconProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: TrayIconProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: TrayIconProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: TrayIconProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: TrayIconProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: TrayIconProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: TrayIconProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: TrayIconProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: TrayIconProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: TrayIconProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: TrayIconProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: TrayIconProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: TrayIconProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: TrayIconProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: TrayIconProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: TrayIconProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: TrayIconProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: TrayIconProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: TrayIconProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: TrayIconProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: TrayIconProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: TrayIconProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: TrayIconProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: TrayIconProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: TrayIconProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: TrayIconProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: TrayIconProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: TrayIconProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: TrayIconProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: TrayIconProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: TrayIconProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: TrayIconProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: TrayIconProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield TrayIconProperty.OnFocused value } 

let prop = TrayIconPropertyBuilder()

