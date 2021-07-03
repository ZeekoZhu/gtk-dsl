module Gtk.DSL.Binding.RecentChooserDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type RecentChooserDialogProperty =
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

let bindProperty (widget: RecentChooserDialog) (prop: RecentChooserDialogProperty) =
    match prop with
    | RecentChooserDialogProperty.Title value -> widget.Title <- value
    | RecentChooserDialogProperty.Role value -> widget.Role <- value
    | RecentChooserDialogProperty.Resizable value -> widget.Resizable <- value
    | RecentChooserDialogProperty.Modal value -> widget.Modal <- value
    | RecentChooserDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | RecentChooserDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | RecentChooserDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | RecentChooserDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | RecentChooserDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | RecentChooserDialogProperty.Icon value -> widget.Icon <- value
    | RecentChooserDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | RecentChooserDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | RecentChooserDialogProperty.IconName value -> widget.IconName <- value
    | RecentChooserDialogProperty.Screen value -> widget.Screen <- value
    | RecentChooserDialogProperty.TypeHint value -> widget.TypeHint <- value
    | RecentChooserDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | RecentChooserDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | RecentChooserDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | RecentChooserDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | RecentChooserDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | RecentChooserDialogProperty.Decorated value -> widget.Decorated <- value
    | RecentChooserDialogProperty.Deletable value -> widget.Deletable <- value
    | RecentChooserDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | RecentChooserDialogProperty.Gravity value -> widget.Gravity <- value
    | RecentChooserDialogProperty.TransientFor value -> widget.TransientFor <- value
    | RecentChooserDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | RecentChooserDialogProperty.Application value -> widget.Application <- value
    | RecentChooserDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | RecentChooserDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | RecentChooserDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | RecentChooserDialogProperty.Name value -> widget.Name <- value
    | RecentChooserDialogProperty.Parent value -> widget.Parent <- value
    | RecentChooserDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | RecentChooserDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | RecentChooserDialogProperty.Visible value -> widget.Visible <- value
    | RecentChooserDialogProperty.Sensitive value -> widget.Sensitive <- value
    | RecentChooserDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | RecentChooserDialogProperty.CanFocus value -> widget.CanFocus <- value
    | RecentChooserDialogProperty.HasFocus value -> widget.HasFocus <- value
    | RecentChooserDialogProperty.IsFocus value -> widget.IsFocus <- value
    | RecentChooserDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | RecentChooserDialogProperty.CanDefault value -> widget.CanDefault <- value
    | RecentChooserDialogProperty.HasDefault value -> widget.HasDefault <- value
    | RecentChooserDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | RecentChooserDialogProperty.Style value -> widget.Style <- value
    | RecentChooserDialogProperty.Events value -> widget.Events <- value
    | RecentChooserDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | RecentChooserDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | RecentChooserDialogProperty.TooltipText value -> widget.TooltipText <- value
    | RecentChooserDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | RecentChooserDialogProperty.Window value -> widget.Window <- value
    | RecentChooserDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | RecentChooserDialogProperty.Halign value -> widget.Halign <- value
    | RecentChooserDialogProperty.Valign value -> widget.Valign <- value
    | RecentChooserDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | RecentChooserDialogProperty.MarginRight value -> widget.MarginRight <- value
    | RecentChooserDialogProperty.MarginStart value -> widget.MarginStart <- value
    | RecentChooserDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | RecentChooserDialogProperty.MarginTop value -> widget.MarginTop <- value
    | RecentChooserDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | RecentChooserDialogProperty.Margin value -> widget.Margin <- value
    | RecentChooserDialogProperty.Hexpand value -> widget.Hexpand <- value
    | RecentChooserDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | RecentChooserDialogProperty.Vexpand value -> widget.Vexpand <- value
    | RecentChooserDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | RecentChooserDialogProperty.Expand value -> widget.Expand <- value
    | RecentChooserDialogProperty.Opacity value -> widget.Opacity <- value
    | RecentChooserDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | RecentChooserDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | RecentChooserDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | RecentChooserDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | RecentChooserDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | RecentChooserDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | RecentChooserDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | RecentChooserDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | RecentChooserDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | RecentChooserDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | RecentChooserDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | RecentChooserDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | RecentChooserDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | RecentChooserDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | RecentChooserDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | RecentChooserDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | RecentChooserDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | RecentChooserDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | RecentChooserDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | RecentChooserDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | RecentChooserDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | RecentChooserDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | RecentChooserDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | RecentChooserDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | RecentChooserDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | RecentChooserDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | RecentChooserDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | RecentChooserDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | RecentChooserDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | RecentChooserDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | RecentChooserDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | RecentChooserDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | RecentChooserDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | RecentChooserDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | RecentChooserDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | RecentChooserDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | RecentChooserDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | RecentChooserDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | RecentChooserDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | RecentChooserDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | RecentChooserDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | RecentChooserDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | RecentChooserDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | RecentChooserDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | RecentChooserDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | RecentChooserDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | RecentChooserDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | RecentChooserDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | RecentChooserDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | RecentChooserDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | RecentChooserDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | RecentChooserDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | RecentChooserDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | RecentChooserDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | RecentChooserDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | RecentChooserDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | RecentChooserDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | RecentChooserDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | RecentChooserDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | RecentChooserDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | RecentChooserDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | RecentChooserDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | RecentChooserDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type RecentChooserDialogPropertyBuilder() =
    inherit BasePropertyBuilder<RecentChooserDialogProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: RecentChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: RecentChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: RecentChooserDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield RecentChooserDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: RecentChooserDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield RecentChooserDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: RecentChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: RecentChooserDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield RecentChooserDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: RecentChooserDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield RecentChooserDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: RecentChooserDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield RecentChooserDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: RecentChooserDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield RecentChooserDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: RecentChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: RecentChooserDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield RecentChooserDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: RecentChooserDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield RecentChooserDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: RecentChooserDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield RecentChooserDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: RecentChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: RecentChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield RecentChooserDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: RecentChooserDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield RecentChooserDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: RecentChooserDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield RecentChooserDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: RecentChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: RecentChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield RecentChooserDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: RecentChooserDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield RecentChooserDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: RecentChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: RecentChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield RecentChooserDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: RecentChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield RecentChooserDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: RecentChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield RecentChooserDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: RecentChooserDialogProperty seq, value: System.Double) =
        seq { yield! it; yield RecentChooserDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: RecentChooserDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: RecentChooserDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: RecentChooserDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: RecentChooserDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: RecentChooserDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: RecentChooserDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: RecentChooserDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: RecentChooserDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: RecentChooserDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: RecentChooserDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: RecentChooserDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: RecentChooserDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: RecentChooserDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: RecentChooserDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: RecentChooserDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: RecentChooserDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: RecentChooserDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: RecentChooserDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: RecentChooserDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: RecentChooserDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: RecentChooserDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: RecentChooserDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: RecentChooserDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: RecentChooserDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: RecentChooserDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: RecentChooserDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: RecentChooserDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: RecentChooserDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: RecentChooserDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: RecentChooserDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: RecentChooserDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: RecentChooserDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: RecentChooserDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: RecentChooserDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: RecentChooserDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: RecentChooserDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: RecentChooserDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: RecentChooserDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: RecentChooserDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: RecentChooserDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: RecentChooserDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: RecentChooserDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: RecentChooserDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: RecentChooserDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: RecentChooserDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: RecentChooserDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: RecentChooserDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: RecentChooserDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: RecentChooserDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: RecentChooserDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: RecentChooserDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: RecentChooserDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: RecentChooserDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: RecentChooserDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: RecentChooserDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: RecentChooserDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: RecentChooserDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: RecentChooserDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: RecentChooserDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: RecentChooserDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: RecentChooserDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: RecentChooserDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: RecentChooserDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield RecentChooserDialogProperty.OnFocused value } 

let prop = RecentChooserDialogPropertyBuilder()

