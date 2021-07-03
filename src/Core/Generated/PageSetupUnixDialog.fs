module Gtk.DSL.Binding.PageSetupUnixDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PageSetupUnixDialogProperty =
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

let bindProperty (widget: PageSetupUnixDialog) (prop: PageSetupUnixDialogProperty) =
    match prop with
    | PageSetupUnixDialogProperty.Title value -> widget.Title <- value
    | PageSetupUnixDialogProperty.Role value -> widget.Role <- value
    | PageSetupUnixDialogProperty.Resizable value -> widget.Resizable <- value
    | PageSetupUnixDialogProperty.Modal value -> widget.Modal <- value
    | PageSetupUnixDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | PageSetupUnixDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | PageSetupUnixDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | PageSetupUnixDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | PageSetupUnixDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | PageSetupUnixDialogProperty.Icon value -> widget.Icon <- value
    | PageSetupUnixDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | PageSetupUnixDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | PageSetupUnixDialogProperty.IconName value -> widget.IconName <- value
    | PageSetupUnixDialogProperty.Screen value -> widget.Screen <- value
    | PageSetupUnixDialogProperty.TypeHint value -> widget.TypeHint <- value
    | PageSetupUnixDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | PageSetupUnixDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | PageSetupUnixDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | PageSetupUnixDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | PageSetupUnixDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | PageSetupUnixDialogProperty.Decorated value -> widget.Decorated <- value
    | PageSetupUnixDialogProperty.Deletable value -> widget.Deletable <- value
    | PageSetupUnixDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | PageSetupUnixDialogProperty.Gravity value -> widget.Gravity <- value
    | PageSetupUnixDialogProperty.TransientFor value -> widget.TransientFor <- value
    | PageSetupUnixDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | PageSetupUnixDialogProperty.Application value -> widget.Application <- value
    | PageSetupUnixDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | PageSetupUnixDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | PageSetupUnixDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | PageSetupUnixDialogProperty.Name value -> widget.Name <- value
    | PageSetupUnixDialogProperty.Parent value -> widget.Parent <- value
    | PageSetupUnixDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | PageSetupUnixDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | PageSetupUnixDialogProperty.Visible value -> widget.Visible <- value
    | PageSetupUnixDialogProperty.Sensitive value -> widget.Sensitive <- value
    | PageSetupUnixDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | PageSetupUnixDialogProperty.CanFocus value -> widget.CanFocus <- value
    | PageSetupUnixDialogProperty.HasFocus value -> widget.HasFocus <- value
    | PageSetupUnixDialogProperty.IsFocus value -> widget.IsFocus <- value
    | PageSetupUnixDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PageSetupUnixDialogProperty.CanDefault value -> widget.CanDefault <- value
    | PageSetupUnixDialogProperty.HasDefault value -> widget.HasDefault <- value
    | PageSetupUnixDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PageSetupUnixDialogProperty.Style value -> widget.Style <- value
    | PageSetupUnixDialogProperty.Events value -> widget.Events <- value
    | PageSetupUnixDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | PageSetupUnixDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | PageSetupUnixDialogProperty.TooltipText value -> widget.TooltipText <- value
    | PageSetupUnixDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PageSetupUnixDialogProperty.Window value -> widget.Window <- value
    | PageSetupUnixDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PageSetupUnixDialogProperty.Halign value -> widget.Halign <- value
    | PageSetupUnixDialogProperty.Valign value -> widget.Valign <- value
    | PageSetupUnixDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | PageSetupUnixDialogProperty.MarginRight value -> widget.MarginRight <- value
    | PageSetupUnixDialogProperty.MarginStart value -> widget.MarginStart <- value
    | PageSetupUnixDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | PageSetupUnixDialogProperty.MarginTop value -> widget.MarginTop <- value
    | PageSetupUnixDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | PageSetupUnixDialogProperty.Margin value -> widget.Margin <- value
    | PageSetupUnixDialogProperty.Hexpand value -> widget.Hexpand <- value
    | PageSetupUnixDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | PageSetupUnixDialogProperty.Vexpand value -> widget.Vexpand <- value
    | PageSetupUnixDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | PageSetupUnixDialogProperty.Expand value -> widget.Expand <- value
    | PageSetupUnixDialogProperty.Opacity value -> widget.Opacity <- value
    | PageSetupUnixDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | PageSetupUnixDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | PageSetupUnixDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | PageSetupUnixDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PageSetupUnixDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PageSetupUnixDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PageSetupUnixDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PageSetupUnixDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PageSetupUnixDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PageSetupUnixDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PageSetupUnixDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PageSetupUnixDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PageSetupUnixDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PageSetupUnixDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PageSetupUnixDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PageSetupUnixDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PageSetupUnixDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PageSetupUnixDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PageSetupUnixDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PageSetupUnixDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PageSetupUnixDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PageSetupUnixDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PageSetupUnixDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PageSetupUnixDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PageSetupUnixDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PageSetupUnixDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PageSetupUnixDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PageSetupUnixDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PageSetupUnixDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PageSetupUnixDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PageSetupUnixDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PageSetupUnixDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PageSetupUnixDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PageSetupUnixDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PageSetupUnixDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PageSetupUnixDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PageSetupUnixDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PageSetupUnixDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PageSetupUnixDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PageSetupUnixDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PageSetupUnixDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PageSetupUnixDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PageSetupUnixDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PageSetupUnixDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PageSetupUnixDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PageSetupUnixDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PageSetupUnixDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PageSetupUnixDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PageSetupUnixDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PageSetupUnixDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PageSetupUnixDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PageSetupUnixDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PageSetupUnixDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PageSetupUnixDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PageSetupUnixDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PageSetupUnixDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PageSetupUnixDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PageSetupUnixDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PageSetupUnixDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PageSetupUnixDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PageSetupUnixDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PageSetupUnixDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PageSetupUnixDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PageSetupUnixDialogPropertyBuilder() =
    inherit BasePropertyBuilder<PageSetupUnixDialogProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: PageSetupUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: PageSetupUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: PageSetupUnixDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield PageSetupUnixDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: PageSetupUnixDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: PageSetupUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PageSetupUnixDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: PageSetupUnixDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: PageSetupUnixDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield PageSetupUnixDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: PageSetupUnixDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: PageSetupUnixDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield PageSetupUnixDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: PageSetupUnixDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PageSetupUnixDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: PageSetupUnixDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PageSetupUnixDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PageSetupUnixDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PageSetupUnixDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PageSetupUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PageSetupUnixDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PageSetupUnixDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PageSetupUnixDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PageSetupUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PageSetupUnixDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PageSetupUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PageSetupUnixDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PageSetupUnixDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PageSetupUnixDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PageSetupUnixDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PageSetupUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PageSetupUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PageSetupUnixDialogProperty seq, value: System.Double) =
        seq { yield! it; yield PageSetupUnixDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: PageSetupUnixDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: PageSetupUnixDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: PageSetupUnixDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PageSetupUnixDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PageSetupUnixDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PageSetupUnixDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PageSetupUnixDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PageSetupUnixDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PageSetupUnixDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PageSetupUnixDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PageSetupUnixDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PageSetupUnixDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PageSetupUnixDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PageSetupUnixDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PageSetupUnixDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PageSetupUnixDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PageSetupUnixDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PageSetupUnixDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PageSetupUnixDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PageSetupUnixDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PageSetupUnixDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PageSetupUnixDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PageSetupUnixDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PageSetupUnixDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PageSetupUnixDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PageSetupUnixDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PageSetupUnixDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PageSetupUnixDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PageSetupUnixDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PageSetupUnixDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PageSetupUnixDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PageSetupUnixDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PageSetupUnixDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PageSetupUnixDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PageSetupUnixDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PageSetupUnixDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PageSetupUnixDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PageSetupUnixDialogProperty.OnFocused value } 

let prop = PageSetupUnixDialogPropertyBuilder()

