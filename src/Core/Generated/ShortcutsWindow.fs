module Gtk.DSL.Binding.ShortcutsWindow
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ShortcutsWindowProperty =
    | SectionName of System.String
    | ViewName of System.String
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

let bindProperty (widget: ShortcutsWindow) (prop: ShortcutsWindowProperty) =
    match prop with
    | ShortcutsWindowProperty.SectionName value -> widget.SectionName <- value
    | ShortcutsWindowProperty.ViewName value -> widget.ViewName <- value
    | ShortcutsWindowProperty.Title value -> widget.Title <- value
    | ShortcutsWindowProperty.Role value -> widget.Role <- value
    | ShortcutsWindowProperty.Resizable value -> widget.Resizable <- value
    | ShortcutsWindowProperty.Modal value -> widget.Modal <- value
    | ShortcutsWindowProperty.WindowPosition value -> widget.WindowPosition <- value
    | ShortcutsWindowProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | ShortcutsWindowProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | ShortcutsWindowProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | ShortcutsWindowProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | ShortcutsWindowProperty.Icon value -> widget.Icon <- value
    | ShortcutsWindowProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | ShortcutsWindowProperty.FocusVisible value -> widget.FocusVisible <- value
    | ShortcutsWindowProperty.IconName value -> widget.IconName <- value
    | ShortcutsWindowProperty.Screen value -> widget.Screen <- value
    | ShortcutsWindowProperty.TypeHint value -> widget.TypeHint <- value
    | ShortcutsWindowProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | ShortcutsWindowProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | ShortcutsWindowProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | ShortcutsWindowProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | ShortcutsWindowProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | ShortcutsWindowProperty.Decorated value -> widget.Decorated <- value
    | ShortcutsWindowProperty.Deletable value -> widget.Deletable <- value
    | ShortcutsWindowProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | ShortcutsWindowProperty.Gravity value -> widget.Gravity <- value
    | ShortcutsWindowProperty.TransientFor value -> widget.TransientFor <- value
    | ShortcutsWindowProperty.AttachedTo value -> widget.AttachedTo <- value
    | ShortcutsWindowProperty.Application value -> widget.Application <- value
    | ShortcutsWindowProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | ShortcutsWindowProperty.ResizeMode value -> widget.ResizeMode <- value
    | ShortcutsWindowProperty.BorderWidth value -> widget.BorderWidth <- value
    | ShortcutsWindowProperty.Name value -> widget.Name <- value
    | ShortcutsWindowProperty.Parent value -> widget.Parent <- value
    | ShortcutsWindowProperty.WidthRequest value -> widget.WidthRequest <- value
    | ShortcutsWindowProperty.HeightRequest value -> widget.HeightRequest <- value
    | ShortcutsWindowProperty.Visible value -> widget.Visible <- value
    | ShortcutsWindowProperty.Sensitive value -> widget.Sensitive <- value
    | ShortcutsWindowProperty.AppPaintable value -> widget.AppPaintable <- value
    | ShortcutsWindowProperty.CanFocus value -> widget.CanFocus <- value
    | ShortcutsWindowProperty.HasFocus value -> widget.HasFocus <- value
    | ShortcutsWindowProperty.IsFocus value -> widget.IsFocus <- value
    | ShortcutsWindowProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ShortcutsWindowProperty.CanDefault value -> widget.CanDefault <- value
    | ShortcutsWindowProperty.HasDefault value -> widget.HasDefault <- value
    | ShortcutsWindowProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ShortcutsWindowProperty.Style value -> widget.Style <- value
    | ShortcutsWindowProperty.Events value -> widget.Events <- value
    | ShortcutsWindowProperty.NoShowAll value -> widget.NoShowAll <- value
    | ShortcutsWindowProperty.HasTooltip value -> widget.HasTooltip <- value
    | ShortcutsWindowProperty.TooltipText value -> widget.TooltipText <- value
    | ShortcutsWindowProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ShortcutsWindowProperty.Window value -> widget.Window <- value
    | ShortcutsWindowProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ShortcutsWindowProperty.Halign value -> widget.Halign <- value
    | ShortcutsWindowProperty.Valign value -> widget.Valign <- value
    | ShortcutsWindowProperty.MarginLeft value -> widget.MarginLeft <- value
    | ShortcutsWindowProperty.MarginRight value -> widget.MarginRight <- value
    | ShortcutsWindowProperty.MarginStart value -> widget.MarginStart <- value
    | ShortcutsWindowProperty.MarginEnd value -> widget.MarginEnd <- value
    | ShortcutsWindowProperty.MarginTop value -> widget.MarginTop <- value
    | ShortcutsWindowProperty.MarginBottom value -> widget.MarginBottom <- value
    | ShortcutsWindowProperty.Margin value -> widget.Margin <- value
    | ShortcutsWindowProperty.Hexpand value -> widget.Hexpand <- value
    | ShortcutsWindowProperty.HexpandSet value -> widget.HexpandSet <- value
    | ShortcutsWindowProperty.Vexpand value -> widget.Vexpand <- value
    | ShortcutsWindowProperty.VexpandSet value -> widget.VexpandSet <- value
    | ShortcutsWindowProperty.Expand value -> widget.Expand <- value
    | ShortcutsWindowProperty.Opacity value -> widget.Opacity <- value
    | ShortcutsWindowProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | ShortcutsWindowProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | ShortcutsWindowProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ShortcutsWindowProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ShortcutsWindowProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ShortcutsWindowProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ShortcutsWindowProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ShortcutsWindowProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ShortcutsWindowProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ShortcutsWindowProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ShortcutsWindowProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ShortcutsWindowProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ShortcutsWindowProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ShortcutsWindowProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ShortcutsWindowProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ShortcutsWindowProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ShortcutsWindowProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ShortcutsWindowProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ShortcutsWindowProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ShortcutsWindowProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ShortcutsWindowProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ShortcutsWindowProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ShortcutsWindowProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ShortcutsWindowProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ShortcutsWindowProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ShortcutsWindowProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ShortcutsWindowProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ShortcutsWindowProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ShortcutsWindowProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ShortcutsWindowProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ShortcutsWindowProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ShortcutsWindowProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ShortcutsWindowProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ShortcutsWindowProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ShortcutsWindowProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ShortcutsWindowProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ShortcutsWindowProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ShortcutsWindowProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ShortcutsWindowProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ShortcutsWindowProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ShortcutsWindowProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ShortcutsWindowProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ShortcutsWindowProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ShortcutsWindowProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ShortcutsWindowProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ShortcutsWindowProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ShortcutsWindowProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ShortcutsWindowProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ShortcutsWindowProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ShortcutsWindowProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ShortcutsWindowProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ShortcutsWindowProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ShortcutsWindowProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ShortcutsWindowProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ShortcutsWindowProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ShortcutsWindowProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ShortcutsWindowProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ShortcutsWindowProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ShortcutsWindowProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ShortcutsWindowProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ShortcutsWindowProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ShortcutsWindowProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ShortcutsWindowPropertyBuilder() =
    inherit BasePropertyBuilder<ShortcutsWindowProperty>()
    [<CustomOperation("sectionName")>]
    member this.SectionName(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.SectionName value } 
    [<CustomOperation("viewName")>]
    member this.ViewName(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.ViewName value } 
    [<CustomOperation("title")>]
    member this.Title(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: ShortcutsWindowProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield ShortcutsWindowProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: ShortcutsWindowProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield ShortcutsWindowProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: ShortcutsWindowProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield ShortcutsWindowProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: ShortcutsWindowProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield ShortcutsWindowProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: ShortcutsWindowProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield ShortcutsWindowProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: ShortcutsWindowProperty seq, value: Gtk.Window) =
        seq { yield! it; yield ShortcutsWindowProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: ShortcutsWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ShortcutsWindowProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: ShortcutsWindowProperty seq, value: Gtk.Application) =
        seq { yield! it; yield ShortcutsWindowProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ShortcutsWindowProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ShortcutsWindowProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ShortcutsWindowProperty seq, value: System.UInt32) =
        seq { yield! it; yield ShortcutsWindowProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ShortcutsWindowProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ShortcutsWindowProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ShortcutsWindowProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ShortcutsWindowProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ShortcutsWindowProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ShortcutsWindowProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ShortcutsWindowProperty seq, value: System.String) =
        seq { yield! it; yield ShortcutsWindowProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ShortcutsWindowProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ShortcutsWindowProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ShortcutsWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsWindowProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ShortcutsWindowProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ShortcutsWindowProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ShortcutsWindowProperty seq, value: System.Int32) =
        seq { yield! it; yield ShortcutsWindowProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ShortcutsWindowProperty seq, value: System.Boolean) =
        seq { yield! it; yield ShortcutsWindowProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ShortcutsWindowProperty seq, value: System.Double) =
        seq { yield! it; yield ShortcutsWindowProperty.Opacity value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: ShortcutsWindowProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: ShortcutsWindowProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ShortcutsWindowProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ShortcutsWindowProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ShortcutsWindowProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ShortcutsWindowProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ShortcutsWindowProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ShortcutsWindowProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ShortcutsWindowProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ShortcutsWindowProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ShortcutsWindowProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ShortcutsWindowProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ShortcutsWindowProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ShortcutsWindowProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ShortcutsWindowProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ShortcutsWindowProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ShortcutsWindowProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ShortcutsWindowProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ShortcutsWindowProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ShortcutsWindowProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ShortcutsWindowProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ShortcutsWindowProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ShortcutsWindowProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ShortcutsWindowProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ShortcutsWindowProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ShortcutsWindowProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ShortcutsWindowProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ShortcutsWindowProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ShortcutsWindowProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ShortcutsWindowProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ShortcutsWindowProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ShortcutsWindowProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ShortcutsWindowProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ShortcutsWindowProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ShortcutsWindowProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ShortcutsWindowProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ShortcutsWindowProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ShortcutsWindowProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ShortcutsWindowProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ShortcutsWindowProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ShortcutsWindowProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ShortcutsWindowProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ShortcutsWindowProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ShortcutsWindowProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ShortcutsWindowProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ShortcutsWindowProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ShortcutsWindowProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ShortcutsWindowProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ShortcutsWindowProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ShortcutsWindowProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ShortcutsWindowProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ShortcutsWindowProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ShortcutsWindowProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ShortcutsWindowProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ShortcutsWindowProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ShortcutsWindowProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ShortcutsWindowProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ShortcutsWindowProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ShortcutsWindowProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ShortcutsWindowProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ShortcutsWindowProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ShortcutsWindowProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ShortcutsWindowProperty.OnFocused value } 

let prop = ShortcutsWindowPropertyBuilder()

