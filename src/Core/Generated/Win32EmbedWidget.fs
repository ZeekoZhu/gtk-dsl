module Gtk.DSL.Binding.Win32EmbedWidget
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type Win32EmbedWidgetProperty =
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

let bindProperty (widget: Win32EmbedWidget) (prop: Win32EmbedWidgetProperty) =
    match prop with
    | Win32EmbedWidgetProperty.Title value -> widget.Title <- value
    | Win32EmbedWidgetProperty.Role value -> widget.Role <- value
    | Win32EmbedWidgetProperty.Resizable value -> widget.Resizable <- value
    | Win32EmbedWidgetProperty.Modal value -> widget.Modal <- value
    | Win32EmbedWidgetProperty.WindowPosition value -> widget.WindowPosition <- value
    | Win32EmbedWidgetProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | Win32EmbedWidgetProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | Win32EmbedWidgetProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | Win32EmbedWidgetProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | Win32EmbedWidgetProperty.Icon value -> widget.Icon <- value
    | Win32EmbedWidgetProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | Win32EmbedWidgetProperty.FocusVisible value -> widget.FocusVisible <- value
    | Win32EmbedWidgetProperty.IconName value -> widget.IconName <- value
    | Win32EmbedWidgetProperty.Screen value -> widget.Screen <- value
    | Win32EmbedWidgetProperty.TypeHint value -> widget.TypeHint <- value
    | Win32EmbedWidgetProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | Win32EmbedWidgetProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | Win32EmbedWidgetProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | Win32EmbedWidgetProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | Win32EmbedWidgetProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | Win32EmbedWidgetProperty.Decorated value -> widget.Decorated <- value
    | Win32EmbedWidgetProperty.Deletable value -> widget.Deletable <- value
    | Win32EmbedWidgetProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | Win32EmbedWidgetProperty.Gravity value -> widget.Gravity <- value
    | Win32EmbedWidgetProperty.TransientFor value -> widget.TransientFor <- value
    | Win32EmbedWidgetProperty.AttachedTo value -> widget.AttachedTo <- value
    | Win32EmbedWidgetProperty.Application value -> widget.Application <- value
    | Win32EmbedWidgetProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | Win32EmbedWidgetProperty.ResizeMode value -> widget.ResizeMode <- value
    | Win32EmbedWidgetProperty.BorderWidth value -> widget.BorderWidth <- value
    | Win32EmbedWidgetProperty.Name value -> widget.Name <- value
    | Win32EmbedWidgetProperty.Parent value -> widget.Parent <- value
    | Win32EmbedWidgetProperty.WidthRequest value -> widget.WidthRequest <- value
    | Win32EmbedWidgetProperty.HeightRequest value -> widget.HeightRequest <- value
    | Win32EmbedWidgetProperty.Visible value -> widget.Visible <- value
    | Win32EmbedWidgetProperty.Sensitive value -> widget.Sensitive <- value
    | Win32EmbedWidgetProperty.AppPaintable value -> widget.AppPaintable <- value
    | Win32EmbedWidgetProperty.CanFocus value -> widget.CanFocus <- value
    | Win32EmbedWidgetProperty.HasFocus value -> widget.HasFocus <- value
    | Win32EmbedWidgetProperty.IsFocus value -> widget.IsFocus <- value
    | Win32EmbedWidgetProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | Win32EmbedWidgetProperty.CanDefault value -> widget.CanDefault <- value
    | Win32EmbedWidgetProperty.HasDefault value -> widget.HasDefault <- value
    | Win32EmbedWidgetProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | Win32EmbedWidgetProperty.Style value -> widget.Style <- value
    | Win32EmbedWidgetProperty.Events value -> widget.Events <- value
    | Win32EmbedWidgetProperty.NoShowAll value -> widget.NoShowAll <- value
    | Win32EmbedWidgetProperty.HasTooltip value -> widget.HasTooltip <- value
    | Win32EmbedWidgetProperty.TooltipText value -> widget.TooltipText <- value
    | Win32EmbedWidgetProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | Win32EmbedWidgetProperty.Window value -> widget.Window <- value
    | Win32EmbedWidgetProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | Win32EmbedWidgetProperty.Halign value -> widget.Halign <- value
    | Win32EmbedWidgetProperty.Valign value -> widget.Valign <- value
    | Win32EmbedWidgetProperty.MarginLeft value -> widget.MarginLeft <- value
    | Win32EmbedWidgetProperty.MarginRight value -> widget.MarginRight <- value
    | Win32EmbedWidgetProperty.MarginStart value -> widget.MarginStart <- value
    | Win32EmbedWidgetProperty.MarginEnd value -> widget.MarginEnd <- value
    | Win32EmbedWidgetProperty.MarginTop value -> widget.MarginTop <- value
    | Win32EmbedWidgetProperty.MarginBottom value -> widget.MarginBottom <- value
    | Win32EmbedWidgetProperty.Margin value -> widget.Margin <- value
    | Win32EmbedWidgetProperty.Hexpand value -> widget.Hexpand <- value
    | Win32EmbedWidgetProperty.HexpandSet value -> widget.HexpandSet <- value
    | Win32EmbedWidgetProperty.Vexpand value -> widget.Vexpand <- value
    | Win32EmbedWidgetProperty.VexpandSet value -> widget.VexpandSet <- value
    | Win32EmbedWidgetProperty.Expand value -> widget.Expand <- value
    | Win32EmbedWidgetProperty.Opacity value -> widget.Opacity <- value
    | Win32EmbedWidgetProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | Win32EmbedWidgetProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | Win32EmbedWidgetProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | Win32EmbedWidgetProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | Win32EmbedWidgetProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | Win32EmbedWidgetProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | Win32EmbedWidgetProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | Win32EmbedWidgetProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | Win32EmbedWidgetProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | Win32EmbedWidgetProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | Win32EmbedWidgetProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | Win32EmbedWidgetProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | Win32EmbedWidgetProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | Win32EmbedWidgetProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | Win32EmbedWidgetProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | Win32EmbedWidgetProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | Win32EmbedWidgetProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | Win32EmbedWidgetProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | Win32EmbedWidgetProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | Win32EmbedWidgetProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | Win32EmbedWidgetProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | Win32EmbedWidgetProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | Win32EmbedWidgetProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | Win32EmbedWidgetProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | Win32EmbedWidgetProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | Win32EmbedWidgetProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | Win32EmbedWidgetProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | Win32EmbedWidgetProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | Win32EmbedWidgetProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | Win32EmbedWidgetProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | Win32EmbedWidgetProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | Win32EmbedWidgetProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | Win32EmbedWidgetProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | Win32EmbedWidgetProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | Win32EmbedWidgetProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | Win32EmbedWidgetProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | Win32EmbedWidgetProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | Win32EmbedWidgetProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | Win32EmbedWidgetProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | Win32EmbedWidgetProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | Win32EmbedWidgetProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | Win32EmbedWidgetProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | Win32EmbedWidgetProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | Win32EmbedWidgetProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | Win32EmbedWidgetProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | Win32EmbedWidgetProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | Win32EmbedWidgetProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | Win32EmbedWidgetProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | Win32EmbedWidgetProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | Win32EmbedWidgetProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | Win32EmbedWidgetProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | Win32EmbedWidgetProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | Win32EmbedWidgetProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | Win32EmbedWidgetProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | Win32EmbedWidgetProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | Win32EmbedWidgetProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | Win32EmbedWidgetProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | Win32EmbedWidgetProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | Win32EmbedWidgetProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | Win32EmbedWidgetProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | Win32EmbedWidgetProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | Win32EmbedWidgetProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type Win32EmbedWidgetPropertyBuilder() =
    inherit BasePropertyBuilder<Win32EmbedWidgetProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: Win32EmbedWidgetProperty seq, value: System.String) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: Win32EmbedWidgetProperty seq, value: System.String) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: Win32EmbedWidgetProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield Win32EmbedWidgetProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: Win32EmbedWidgetProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: Win32EmbedWidgetProperty seq, value: System.String) =
        seq { yield! it; yield Win32EmbedWidgetProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: Win32EmbedWidgetProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: Win32EmbedWidgetProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield Win32EmbedWidgetProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: Win32EmbedWidgetProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: Win32EmbedWidgetProperty seq, value: Gtk.Window) =
        seq { yield! it; yield Win32EmbedWidgetProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: Win32EmbedWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield Win32EmbedWidgetProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: Win32EmbedWidgetProperty seq, value: Gtk.Application) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: Win32EmbedWidgetProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield Win32EmbedWidgetProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: Win32EmbedWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: Win32EmbedWidgetProperty seq, value: System.String) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: Win32EmbedWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: Win32EmbedWidgetProperty seq, value: Gtk.Style) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: Win32EmbedWidgetProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: Win32EmbedWidgetProperty seq, value: System.String) =
        seq { yield! it; yield Win32EmbedWidgetProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: Win32EmbedWidgetProperty seq, value: System.String) =
        seq { yield! it; yield Win32EmbedWidgetProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: Win32EmbedWidgetProperty seq, value: Gdk.Window) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: Win32EmbedWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: Win32EmbedWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: Win32EmbedWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: Win32EmbedWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: Win32EmbedWidgetProperty seq, value: System.Double) =
        seq { yield! it; yield Win32EmbedWidgetProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: Win32EmbedWidgetProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: Win32EmbedWidgetProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: Win32EmbedWidgetProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: Win32EmbedWidgetProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: Win32EmbedWidgetProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: Win32EmbedWidgetProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: Win32EmbedWidgetProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: Win32EmbedWidgetProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: Win32EmbedWidgetProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: Win32EmbedWidgetProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: Win32EmbedWidgetProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: Win32EmbedWidgetProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: Win32EmbedWidgetProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: Win32EmbedWidgetProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: Win32EmbedWidgetProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: Win32EmbedWidgetProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: Win32EmbedWidgetProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: Win32EmbedWidgetProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: Win32EmbedWidgetProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: Win32EmbedWidgetProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: Win32EmbedWidgetProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: Win32EmbedWidgetProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: Win32EmbedWidgetProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: Win32EmbedWidgetProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: Win32EmbedWidgetProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: Win32EmbedWidgetProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: Win32EmbedWidgetProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: Win32EmbedWidgetProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: Win32EmbedWidgetProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: Win32EmbedWidgetProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: Win32EmbedWidgetProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: Win32EmbedWidgetProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: Win32EmbedWidgetProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: Win32EmbedWidgetProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: Win32EmbedWidgetProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: Win32EmbedWidgetProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield Win32EmbedWidgetProperty.OnFocused value } 

let prop = Win32EmbedWidgetPropertyBuilder()

