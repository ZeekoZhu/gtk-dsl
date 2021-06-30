module GtkDsl.Binding.Plug
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PlugProperty =
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

let bindProperty (widget: Plug) (prop: PlugProperty) =
    match prop with
    | PlugProperty.Title value -> widget.Title <- value
    | PlugProperty.Role value -> widget.Role <- value
    | PlugProperty.Resizable value -> widget.Resizable <- value
    | PlugProperty.Modal value -> widget.Modal <- value
    | PlugProperty.WindowPosition value -> widget.WindowPosition <- value
    | PlugProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | PlugProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | PlugProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | PlugProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | PlugProperty.Icon value -> widget.Icon <- value
    | PlugProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | PlugProperty.FocusVisible value -> widget.FocusVisible <- value
    | PlugProperty.IconName value -> widget.IconName <- value
    | PlugProperty.Screen value -> widget.Screen <- value
    | PlugProperty.TypeHint value -> widget.TypeHint <- value
    | PlugProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | PlugProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | PlugProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | PlugProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | PlugProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | PlugProperty.Decorated value -> widget.Decorated <- value
    | PlugProperty.Deletable value -> widget.Deletable <- value
    | PlugProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | PlugProperty.Gravity value -> widget.Gravity <- value
    | PlugProperty.TransientFor value -> widget.TransientFor <- value
    | PlugProperty.AttachedTo value -> widget.AttachedTo <- value
    | PlugProperty.Application value -> widget.Application <- value
    | PlugProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | PlugProperty.ResizeMode value -> widget.ResizeMode <- value
    | PlugProperty.BorderWidth value -> widget.BorderWidth <- value
    | PlugProperty.Name value -> widget.Name <- value
    | PlugProperty.Parent value -> widget.Parent <- value
    | PlugProperty.WidthRequest value -> widget.WidthRequest <- value
    | PlugProperty.HeightRequest value -> widget.HeightRequest <- value
    | PlugProperty.Visible value -> widget.Visible <- value
    | PlugProperty.Sensitive value -> widget.Sensitive <- value
    | PlugProperty.AppPaintable value -> widget.AppPaintable <- value
    | PlugProperty.CanFocus value -> widget.CanFocus <- value
    | PlugProperty.HasFocus value -> widget.HasFocus <- value
    | PlugProperty.IsFocus value -> widget.IsFocus <- value
    | PlugProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PlugProperty.CanDefault value -> widget.CanDefault <- value
    | PlugProperty.HasDefault value -> widget.HasDefault <- value
    | PlugProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PlugProperty.Style value -> widget.Style <- value
    | PlugProperty.Events value -> widget.Events <- value
    | PlugProperty.NoShowAll value -> widget.NoShowAll <- value
    | PlugProperty.HasTooltip value -> widget.HasTooltip <- value
    | PlugProperty.TooltipText value -> widget.TooltipText <- value
    | PlugProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PlugProperty.Window value -> widget.Window <- value
    | PlugProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PlugProperty.Halign value -> widget.Halign <- value
    | PlugProperty.Valign value -> widget.Valign <- value
    | PlugProperty.MarginLeft value -> widget.MarginLeft <- value
    | PlugProperty.MarginRight value -> widget.MarginRight <- value
    | PlugProperty.MarginStart value -> widget.MarginStart <- value
    | PlugProperty.MarginEnd value -> widget.MarginEnd <- value
    | PlugProperty.MarginTop value -> widget.MarginTop <- value
    | PlugProperty.MarginBottom value -> widget.MarginBottom <- value
    | PlugProperty.Margin value -> widget.Margin <- value
    | PlugProperty.Hexpand value -> widget.Hexpand <- value
    | PlugProperty.HexpandSet value -> widget.HexpandSet <- value
    | PlugProperty.Vexpand value -> widget.Vexpand <- value
    | PlugProperty.VexpandSet value -> widget.VexpandSet <- value
    | PlugProperty.Expand value -> widget.Expand <- value
    | PlugProperty.Opacity value -> widget.Opacity <- value
    | PlugProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | PlugProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | PlugProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PlugProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PlugProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PlugProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PlugProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PlugProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PlugProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PlugProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PlugProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PlugProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PlugProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PlugProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PlugProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PlugProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PlugProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PlugProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PlugProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PlugProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PlugProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PlugProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PlugProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PlugProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PlugProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PlugProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PlugProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PlugProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PlugProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PlugProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PlugProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PlugProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PlugProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PlugProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PlugProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PlugProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PlugProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PlugProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PlugProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PlugProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PlugProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PlugProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PlugProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PlugProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PlugProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PlugProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PlugProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PlugProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PlugProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PlugProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PlugProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PlugProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PlugProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PlugProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PlugProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PlugProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PlugProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PlugProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PlugProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PlugProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PlugProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PlugProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PlugPropertyBuilder() =
    inherit BasePropertyBuilder<PlugProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: PlugProperty seq, value: System.String) =
        seq { yield! it; yield PlugProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: PlugProperty seq, value: System.String) =
        seq { yield! it; yield PlugProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: PlugProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield PlugProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: PlugProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield PlugProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: PlugProperty seq, value: System.String) =
        seq { yield! it; yield PlugProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: PlugProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield PlugProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: PlugProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield PlugProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: PlugProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield PlugProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: PlugProperty seq, value: Gtk.Window) =
        seq { yield! it; yield PlugProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: PlugProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PlugProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: PlugProperty seq, value: Gtk.Application) =
        seq { yield! it; yield PlugProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PlugProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PlugProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PlugProperty seq, value: System.UInt32) =
        seq { yield! it; yield PlugProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PlugProperty seq, value: System.String) =
        seq { yield! it; yield PlugProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PlugProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PlugProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PlugProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PlugProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PlugProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PlugProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PlugProperty seq, value: System.String) =
        seq { yield! it; yield PlugProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PlugProperty seq, value: System.String) =
        seq { yield! it; yield PlugProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PlugProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PlugProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PlugProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PlugProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PlugProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PlugProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PlugProperty seq, value: System.Int32) =
        seq { yield! it; yield PlugProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PlugProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlugProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PlugProperty seq, value: System.Double) =
        seq { yield! it; yield PlugProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: PlugProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: PlugProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PlugProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PlugProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PlugProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PlugProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PlugProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PlugProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PlugProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PlugProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PlugProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PlugProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PlugProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PlugProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PlugProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PlugProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PlugProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PlugProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PlugProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PlugProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PlugProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PlugProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PlugProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PlugProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PlugProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PlugProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PlugProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PlugProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PlugProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PlugProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PlugProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PlugProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PlugProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PlugProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PlugProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PlugProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PlugProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PlugProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PlugProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PlugProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PlugProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PlugProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PlugProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PlugProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PlugProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PlugProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PlugProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PlugProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PlugProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PlugProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PlugProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PlugProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PlugProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PlugProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PlugProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PlugProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PlugProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PlugProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PlugProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PlugProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PlugProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PlugProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PlugProperty.OnFocused value } 

let prop = PlugPropertyBuilder()

