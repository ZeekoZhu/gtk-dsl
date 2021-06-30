module GtkDsl.Binding.Window
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type WindowProperty =
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

let bindProperty (widget: Window) (prop: WindowProperty) =
    match prop with
    | WindowProperty.Title value -> widget.Title <- value
    | WindowProperty.Role value -> widget.Role <- value
    | WindowProperty.Resizable value -> widget.Resizable <- value
    | WindowProperty.Modal value -> widget.Modal <- value
    | WindowProperty.WindowPosition value -> widget.WindowPosition <- value
    | WindowProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | WindowProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | WindowProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | WindowProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | WindowProperty.Icon value -> widget.Icon <- value
    | WindowProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | WindowProperty.FocusVisible value -> widget.FocusVisible <- value
    | WindowProperty.IconName value -> widget.IconName <- value
    | WindowProperty.Screen value -> widget.Screen <- value
    | WindowProperty.TypeHint value -> widget.TypeHint <- value
    | WindowProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | WindowProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | WindowProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | WindowProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | WindowProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | WindowProperty.Decorated value -> widget.Decorated <- value
    | WindowProperty.Deletable value -> widget.Deletable <- value
    | WindowProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | WindowProperty.Gravity value -> widget.Gravity <- value
    | WindowProperty.TransientFor value -> widget.TransientFor <- value
    | WindowProperty.AttachedTo value -> widget.AttachedTo <- value
    | WindowProperty.Application value -> widget.Application <- value
    | WindowProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | WindowProperty.ResizeMode value -> widget.ResizeMode <- value
    | WindowProperty.BorderWidth value -> widget.BorderWidth <- value
    | WindowProperty.Name value -> widget.Name <- value
    | WindowProperty.Parent value -> widget.Parent <- value
    | WindowProperty.WidthRequest value -> widget.WidthRequest <- value
    | WindowProperty.HeightRequest value -> widget.HeightRequest <- value
    | WindowProperty.Visible value -> widget.Visible <- value
    | WindowProperty.Sensitive value -> widget.Sensitive <- value
    | WindowProperty.AppPaintable value -> widget.AppPaintable <- value
    | WindowProperty.CanFocus value -> widget.CanFocus <- value
    | WindowProperty.HasFocus value -> widget.HasFocus <- value
    | WindowProperty.IsFocus value -> widget.IsFocus <- value
    | WindowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | WindowProperty.CanDefault value -> widget.CanDefault <- value
    | WindowProperty.HasDefault value -> widget.HasDefault <- value
    | WindowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | WindowProperty.Style value -> widget.Style <- value
    | WindowProperty.Events value -> widget.Events <- value
    | WindowProperty.NoShowAll value -> widget.NoShowAll <- value
    | WindowProperty.HasTooltip value -> widget.HasTooltip <- value
    | WindowProperty.TooltipText value -> widget.TooltipText <- value
    | WindowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | WindowProperty.Window value -> widget.Window <- value
    | WindowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | WindowProperty.Halign value -> widget.Halign <- value
    | WindowProperty.Valign value -> widget.Valign <- value
    | WindowProperty.MarginLeft value -> widget.MarginLeft <- value
    | WindowProperty.MarginRight value -> widget.MarginRight <- value
    | WindowProperty.MarginStart value -> widget.MarginStart <- value
    | WindowProperty.MarginEnd value -> widget.MarginEnd <- value
    | WindowProperty.MarginTop value -> widget.MarginTop <- value
    | WindowProperty.MarginBottom value -> widget.MarginBottom <- value
    | WindowProperty.Margin value -> widget.Margin <- value
    | WindowProperty.Hexpand value -> widget.Hexpand <- value
    | WindowProperty.HexpandSet value -> widget.HexpandSet <- value
    | WindowProperty.Vexpand value -> widget.Vexpand <- value
    | WindowProperty.VexpandSet value -> widget.VexpandSet <- value
    | WindowProperty.Expand value -> widget.Expand <- value
    | WindowProperty.Opacity value -> widget.Opacity <- value
    | WindowProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | WindowProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | WindowProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | WindowProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | WindowProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | WindowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | WindowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | WindowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | WindowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | WindowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | WindowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | WindowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | WindowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | WindowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | WindowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | WindowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | WindowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | WindowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | WindowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | WindowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | WindowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | WindowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | WindowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | WindowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | WindowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | WindowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | WindowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | WindowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | WindowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | WindowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | WindowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | WindowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | WindowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | WindowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | WindowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | WindowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | WindowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | WindowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | WindowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | WindowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | WindowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | WindowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | WindowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | WindowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | WindowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | WindowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | WindowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | WindowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | WindowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | WindowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | WindowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | WindowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | WindowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | WindowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | WindowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | WindowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | WindowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | WindowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | WindowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | WindowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | WindowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | WindowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type WindowPropertyBuilder() =
    inherit BasePropertyBuilder<WindowProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: WindowProperty seq, value: System.String) =
        seq { yield! it; yield WindowProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: WindowProperty seq, value: System.String) =
        seq { yield! it; yield WindowProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: WindowProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield WindowProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: WindowProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield WindowProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: WindowProperty seq, value: System.String) =
        seq { yield! it; yield WindowProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: WindowProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield WindowProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: WindowProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield WindowProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: WindowProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield WindowProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: WindowProperty seq, value: Gtk.Window) =
        seq { yield! it; yield WindowProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: WindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield WindowProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: WindowProperty seq, value: Gtk.Application) =
        seq { yield! it; yield WindowProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: WindowProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield WindowProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: WindowProperty seq, value: System.UInt32) =
        seq { yield! it; yield WindowProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: WindowProperty seq, value: System.String) =
        seq { yield! it; yield WindowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: WindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield WindowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: WindowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield WindowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: WindowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield WindowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: WindowProperty seq, value: System.String) =
        seq { yield! it; yield WindowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: WindowProperty seq, value: System.String) =
        seq { yield! it; yield WindowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: WindowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield WindowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: WindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield WindowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: WindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield WindowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: WindowProperty seq, value: System.Int32) =
        seq { yield! it; yield WindowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: WindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield WindowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: WindowProperty seq, value: System.Double) =
        seq { yield! it; yield WindowProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: WindowProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: WindowProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: WindowProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: WindowProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: WindowProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: WindowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: WindowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: WindowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: WindowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: WindowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: WindowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: WindowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: WindowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: WindowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: WindowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: WindowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: WindowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: WindowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: WindowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: WindowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: WindowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: WindowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: WindowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: WindowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: WindowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: WindowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: WindowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: WindowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: WindowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: WindowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: WindowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: WindowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: WindowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: WindowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: WindowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: WindowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: WindowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: WindowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: WindowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: WindowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: WindowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: WindowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: WindowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: WindowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: WindowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: WindowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: WindowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: WindowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: WindowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: WindowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: WindowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: WindowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: WindowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: WindowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: WindowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: WindowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: WindowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: WindowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: WindowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: WindowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: WindowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: WindowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield WindowProperty.OnFocused value } 

let prop = WindowPropertyBuilder()

