module GtkDsl.Binding.ApplicationWindow
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ApplicationWindowProperty =
    | ShowMenubar of System.Boolean
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

let bindProperty (widget: ApplicationWindow) (prop: ApplicationWindowProperty) =
    match prop with
    | ApplicationWindowProperty.ShowMenubar value -> widget.ShowMenubar <- value
    | ApplicationWindowProperty.Title value -> widget.Title <- value
    | ApplicationWindowProperty.Role value -> widget.Role <- value
    | ApplicationWindowProperty.Resizable value -> widget.Resizable <- value
    | ApplicationWindowProperty.Modal value -> widget.Modal <- value
    | ApplicationWindowProperty.WindowPosition value -> widget.WindowPosition <- value
    | ApplicationWindowProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | ApplicationWindowProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | ApplicationWindowProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | ApplicationWindowProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | ApplicationWindowProperty.Icon value -> widget.Icon <- value
    | ApplicationWindowProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | ApplicationWindowProperty.FocusVisible value -> widget.FocusVisible <- value
    | ApplicationWindowProperty.IconName value -> widget.IconName <- value
    | ApplicationWindowProperty.Screen value -> widget.Screen <- value
    | ApplicationWindowProperty.TypeHint value -> widget.TypeHint <- value
    | ApplicationWindowProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | ApplicationWindowProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | ApplicationWindowProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | ApplicationWindowProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | ApplicationWindowProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | ApplicationWindowProperty.Decorated value -> widget.Decorated <- value
    | ApplicationWindowProperty.Deletable value -> widget.Deletable <- value
    | ApplicationWindowProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | ApplicationWindowProperty.Gravity value -> widget.Gravity <- value
    | ApplicationWindowProperty.TransientFor value -> widget.TransientFor <- value
    | ApplicationWindowProperty.AttachedTo value -> widget.AttachedTo <- value
    | ApplicationWindowProperty.Application value -> widget.Application <- value
    | ApplicationWindowProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | ApplicationWindowProperty.ResizeMode value -> widget.ResizeMode <- value
    | ApplicationWindowProperty.BorderWidth value -> widget.BorderWidth <- value
    | ApplicationWindowProperty.Name value -> widget.Name <- value
    | ApplicationWindowProperty.Parent value -> widget.Parent <- value
    | ApplicationWindowProperty.WidthRequest value -> widget.WidthRequest <- value
    | ApplicationWindowProperty.HeightRequest value -> widget.HeightRequest <- value
    | ApplicationWindowProperty.Visible value -> widget.Visible <- value
    | ApplicationWindowProperty.Sensitive value -> widget.Sensitive <- value
    | ApplicationWindowProperty.AppPaintable value -> widget.AppPaintable <- value
    | ApplicationWindowProperty.CanFocus value -> widget.CanFocus <- value
    | ApplicationWindowProperty.HasFocus value -> widget.HasFocus <- value
    | ApplicationWindowProperty.IsFocus value -> widget.IsFocus <- value
    | ApplicationWindowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ApplicationWindowProperty.CanDefault value -> widget.CanDefault <- value
    | ApplicationWindowProperty.HasDefault value -> widget.HasDefault <- value
    | ApplicationWindowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ApplicationWindowProperty.Style value -> widget.Style <- value
    | ApplicationWindowProperty.Events value -> widget.Events <- value
    | ApplicationWindowProperty.NoShowAll value -> widget.NoShowAll <- value
    | ApplicationWindowProperty.HasTooltip value -> widget.HasTooltip <- value
    | ApplicationWindowProperty.TooltipText value -> widget.TooltipText <- value
    | ApplicationWindowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ApplicationWindowProperty.Window value -> widget.Window <- value
    | ApplicationWindowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ApplicationWindowProperty.Halign value -> widget.Halign <- value
    | ApplicationWindowProperty.Valign value -> widget.Valign <- value
    | ApplicationWindowProperty.MarginLeft value -> widget.MarginLeft <- value
    | ApplicationWindowProperty.MarginRight value -> widget.MarginRight <- value
    | ApplicationWindowProperty.MarginStart value -> widget.MarginStart <- value
    | ApplicationWindowProperty.MarginEnd value -> widget.MarginEnd <- value
    | ApplicationWindowProperty.MarginTop value -> widget.MarginTop <- value
    | ApplicationWindowProperty.MarginBottom value -> widget.MarginBottom <- value
    | ApplicationWindowProperty.Margin value -> widget.Margin <- value
    | ApplicationWindowProperty.Hexpand value -> widget.Hexpand <- value
    | ApplicationWindowProperty.HexpandSet value -> widget.HexpandSet <- value
    | ApplicationWindowProperty.Vexpand value -> widget.Vexpand <- value
    | ApplicationWindowProperty.VexpandSet value -> widget.VexpandSet <- value
    | ApplicationWindowProperty.Expand value -> widget.Expand <- value
    | ApplicationWindowProperty.Opacity value -> widget.Opacity <- value
    | ApplicationWindowProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | ApplicationWindowProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | ApplicationWindowProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ApplicationWindowProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ApplicationWindowProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ApplicationWindowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ApplicationWindowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ApplicationWindowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ApplicationWindowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ApplicationWindowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ApplicationWindowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ApplicationWindowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ApplicationWindowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ApplicationWindowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ApplicationWindowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ApplicationWindowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ApplicationWindowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ApplicationWindowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ApplicationWindowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ApplicationWindowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ApplicationWindowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ApplicationWindowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ApplicationWindowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ApplicationWindowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ApplicationWindowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ApplicationWindowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ApplicationWindowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ApplicationWindowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ApplicationWindowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ApplicationWindowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ApplicationWindowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ApplicationWindowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ApplicationWindowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ApplicationWindowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ApplicationWindowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ApplicationWindowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ApplicationWindowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ApplicationWindowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ApplicationWindowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ApplicationWindowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ApplicationWindowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ApplicationWindowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ApplicationWindowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ApplicationWindowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ApplicationWindowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ApplicationWindowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ApplicationWindowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ApplicationWindowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ApplicationWindowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ApplicationWindowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ApplicationWindowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ApplicationWindowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ApplicationWindowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ApplicationWindowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ApplicationWindowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ApplicationWindowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ApplicationWindowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ApplicationWindowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ApplicationWindowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ApplicationWindowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ApplicationWindowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ApplicationWindowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ApplicationWindowPropertyBuilder() =
    inherit BasePropertyBuilder<ApplicationWindowProperty>()
    [<CustomOperation("showMenubar")>]
    member this.ShowMenubar(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.ShowMenubar value } 
    [<CustomOperation("title")>]
    member this.Title(it: ApplicationWindowProperty seq, value: System.String) =
        seq { yield! it; yield ApplicationWindowProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: ApplicationWindowProperty seq, value: System.String) =
        seq { yield! it; yield ApplicationWindowProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: ApplicationWindowProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield ApplicationWindowProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: ApplicationWindowProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield ApplicationWindowProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ApplicationWindowProperty seq, value: System.String) =
        seq { yield! it; yield ApplicationWindowProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: ApplicationWindowProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield ApplicationWindowProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: ApplicationWindowProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield ApplicationWindowProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: ApplicationWindowProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield ApplicationWindowProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: ApplicationWindowProperty seq, value: Gtk.Window) =
        seq { yield! it; yield ApplicationWindowProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: ApplicationWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ApplicationWindowProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: ApplicationWindowProperty seq, value: Gtk.Application) =
        seq { yield! it; yield ApplicationWindowProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ApplicationWindowProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ApplicationWindowProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ApplicationWindowProperty seq, value: System.UInt32) =
        seq { yield! it; yield ApplicationWindowProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ApplicationWindowProperty seq, value: System.String) =
        seq { yield! it; yield ApplicationWindowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ApplicationWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ApplicationWindowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ApplicationWindowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ApplicationWindowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ApplicationWindowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ApplicationWindowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ApplicationWindowProperty seq, value: System.String) =
        seq { yield! it; yield ApplicationWindowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ApplicationWindowProperty seq, value: System.String) =
        seq { yield! it; yield ApplicationWindowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ApplicationWindowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ApplicationWindowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ApplicationWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ApplicationWindowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ApplicationWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ApplicationWindowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ApplicationWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ApplicationWindowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ApplicationWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ApplicationWindowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ApplicationWindowProperty seq, value: System.Double) =
        seq { yield! it; yield ApplicationWindowProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: ApplicationWindowProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: ApplicationWindowProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ApplicationWindowProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ApplicationWindowProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ApplicationWindowProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ApplicationWindowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ApplicationWindowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ApplicationWindowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ApplicationWindowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ApplicationWindowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ApplicationWindowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ApplicationWindowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ApplicationWindowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ApplicationWindowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ApplicationWindowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ApplicationWindowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ApplicationWindowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ApplicationWindowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ApplicationWindowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ApplicationWindowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ApplicationWindowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ApplicationWindowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ApplicationWindowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ApplicationWindowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ApplicationWindowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ApplicationWindowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ApplicationWindowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ApplicationWindowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ApplicationWindowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ApplicationWindowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ApplicationWindowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ApplicationWindowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ApplicationWindowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ApplicationWindowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ApplicationWindowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ApplicationWindowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ApplicationWindowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ApplicationWindowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ApplicationWindowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ApplicationWindowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ApplicationWindowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ApplicationWindowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ApplicationWindowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ApplicationWindowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ApplicationWindowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ApplicationWindowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ApplicationWindowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ApplicationWindowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ApplicationWindowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ApplicationWindowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ApplicationWindowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ApplicationWindowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ApplicationWindowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ApplicationWindowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ApplicationWindowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ApplicationWindowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ApplicationWindowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ApplicationWindowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ApplicationWindowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ApplicationWindowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ApplicationWindowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ApplicationWindowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ApplicationWindowProperty.OnFocused value } 

let prop = ApplicationWindowPropertyBuilder()

