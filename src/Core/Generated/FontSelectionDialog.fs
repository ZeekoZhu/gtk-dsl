module Gtk.DSL.Binding.FontSelectionDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FontSelectionDialogProperty =
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

let bindProperty (widget: FontSelectionDialog) (prop: FontSelectionDialogProperty) =
    match prop with
    | FontSelectionDialogProperty.Title value -> widget.Title <- value
    | FontSelectionDialogProperty.Role value -> widget.Role <- value
    | FontSelectionDialogProperty.Resizable value -> widget.Resizable <- value
    | FontSelectionDialogProperty.Modal value -> widget.Modal <- value
    | FontSelectionDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | FontSelectionDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | FontSelectionDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | FontSelectionDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | FontSelectionDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | FontSelectionDialogProperty.Icon value -> widget.Icon <- value
    | FontSelectionDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | FontSelectionDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | FontSelectionDialogProperty.IconName value -> widget.IconName <- value
    | FontSelectionDialogProperty.Screen value -> widget.Screen <- value
    | FontSelectionDialogProperty.TypeHint value -> widget.TypeHint <- value
    | FontSelectionDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | FontSelectionDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | FontSelectionDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | FontSelectionDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | FontSelectionDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | FontSelectionDialogProperty.Decorated value -> widget.Decorated <- value
    | FontSelectionDialogProperty.Deletable value -> widget.Deletable <- value
    | FontSelectionDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | FontSelectionDialogProperty.Gravity value -> widget.Gravity <- value
    | FontSelectionDialogProperty.TransientFor value -> widget.TransientFor <- value
    | FontSelectionDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | FontSelectionDialogProperty.Application value -> widget.Application <- value
    | FontSelectionDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | FontSelectionDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | FontSelectionDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | FontSelectionDialogProperty.Name value -> widget.Name <- value
    | FontSelectionDialogProperty.Parent value -> widget.Parent <- value
    | FontSelectionDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | FontSelectionDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | FontSelectionDialogProperty.Visible value -> widget.Visible <- value
    | FontSelectionDialogProperty.Sensitive value -> widget.Sensitive <- value
    | FontSelectionDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | FontSelectionDialogProperty.CanFocus value -> widget.CanFocus <- value
    | FontSelectionDialogProperty.HasFocus value -> widget.HasFocus <- value
    | FontSelectionDialogProperty.IsFocus value -> widget.IsFocus <- value
    | FontSelectionDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FontSelectionDialogProperty.CanDefault value -> widget.CanDefault <- value
    | FontSelectionDialogProperty.HasDefault value -> widget.HasDefault <- value
    | FontSelectionDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FontSelectionDialogProperty.Style value -> widget.Style <- value
    | FontSelectionDialogProperty.Events value -> widget.Events <- value
    | FontSelectionDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | FontSelectionDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | FontSelectionDialogProperty.TooltipText value -> widget.TooltipText <- value
    | FontSelectionDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FontSelectionDialogProperty.Window value -> widget.Window <- value
    | FontSelectionDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FontSelectionDialogProperty.Halign value -> widget.Halign <- value
    | FontSelectionDialogProperty.Valign value -> widget.Valign <- value
    | FontSelectionDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | FontSelectionDialogProperty.MarginRight value -> widget.MarginRight <- value
    | FontSelectionDialogProperty.MarginStart value -> widget.MarginStart <- value
    | FontSelectionDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | FontSelectionDialogProperty.MarginTop value -> widget.MarginTop <- value
    | FontSelectionDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | FontSelectionDialogProperty.Margin value -> widget.Margin <- value
    | FontSelectionDialogProperty.Hexpand value -> widget.Hexpand <- value
    | FontSelectionDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | FontSelectionDialogProperty.Vexpand value -> widget.Vexpand <- value
    | FontSelectionDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | FontSelectionDialogProperty.Expand value -> widget.Expand <- value
    | FontSelectionDialogProperty.Opacity value -> widget.Opacity <- value
    | FontSelectionDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | FontSelectionDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | FontSelectionDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | FontSelectionDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FontSelectionDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FontSelectionDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FontSelectionDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FontSelectionDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FontSelectionDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FontSelectionDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FontSelectionDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FontSelectionDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FontSelectionDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FontSelectionDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FontSelectionDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FontSelectionDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FontSelectionDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FontSelectionDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FontSelectionDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FontSelectionDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FontSelectionDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FontSelectionDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FontSelectionDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FontSelectionDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FontSelectionDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FontSelectionDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FontSelectionDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FontSelectionDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FontSelectionDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FontSelectionDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FontSelectionDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FontSelectionDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FontSelectionDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FontSelectionDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FontSelectionDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FontSelectionDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FontSelectionDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FontSelectionDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FontSelectionDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FontSelectionDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FontSelectionDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FontSelectionDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FontSelectionDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FontSelectionDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FontSelectionDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FontSelectionDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FontSelectionDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FontSelectionDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FontSelectionDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FontSelectionDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FontSelectionDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FontSelectionDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FontSelectionDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FontSelectionDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FontSelectionDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FontSelectionDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FontSelectionDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FontSelectionDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FontSelectionDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FontSelectionDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FontSelectionDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FontSelectionDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FontSelectionDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FontSelectionDialogPropertyBuilder() =
    inherit BasePropertyBuilder<FontSelectionDialogProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: FontSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: FontSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: FontSelectionDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield FontSelectionDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: FontSelectionDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield FontSelectionDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: FontSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: FontSelectionDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield FontSelectionDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: FontSelectionDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield FontSelectionDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: FontSelectionDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield FontSelectionDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: FontSelectionDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield FontSelectionDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: FontSelectionDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontSelectionDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: FontSelectionDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield FontSelectionDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FontSelectionDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FontSelectionDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FontSelectionDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontSelectionDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FontSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FontSelectionDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontSelectionDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FontSelectionDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FontSelectionDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FontSelectionDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FontSelectionDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FontSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FontSelectionDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontSelectionDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FontSelectionDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FontSelectionDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FontSelectionDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontSelectionDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FontSelectionDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontSelectionDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FontSelectionDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontSelectionDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FontSelectionDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontSelectionDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FontSelectionDialogProperty seq, value: System.Double) =
        seq { yield! it; yield FontSelectionDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: FontSelectionDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: FontSelectionDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: FontSelectionDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FontSelectionDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FontSelectionDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FontSelectionDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FontSelectionDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FontSelectionDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FontSelectionDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FontSelectionDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FontSelectionDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FontSelectionDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FontSelectionDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FontSelectionDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FontSelectionDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FontSelectionDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FontSelectionDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FontSelectionDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FontSelectionDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FontSelectionDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FontSelectionDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FontSelectionDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FontSelectionDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FontSelectionDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FontSelectionDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FontSelectionDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FontSelectionDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FontSelectionDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FontSelectionDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FontSelectionDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FontSelectionDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FontSelectionDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FontSelectionDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FontSelectionDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FontSelectionDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FontSelectionDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FontSelectionDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FontSelectionDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FontSelectionDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FontSelectionDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FontSelectionDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FontSelectionDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FontSelectionDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FontSelectionDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FontSelectionDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FontSelectionDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FontSelectionDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FontSelectionDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FontSelectionDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FontSelectionDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FontSelectionDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FontSelectionDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FontSelectionDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FontSelectionDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FontSelectionDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FontSelectionDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FontSelectionDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FontSelectionDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FontSelectionDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FontSelectionDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FontSelectionDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FontSelectionDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FontSelectionDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FontSelectionDialogProperty.OnFocused value } 

let prop = FontSelectionDialogPropertyBuilder()

