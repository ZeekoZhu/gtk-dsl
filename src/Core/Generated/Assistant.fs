module Gtk.DSL.Binding.Assistant
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AssistantProperty =
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
    |  OnPrepare of (Gtk.PrepareArgs -> unit)
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

let bindProperty (widget: Assistant) (prop: AssistantProperty) =
    match prop with
    | AssistantProperty.Title value -> widget.Title <- value
    | AssistantProperty.Role value -> widget.Role <- value
    | AssistantProperty.Resizable value -> widget.Resizable <- value
    | AssistantProperty.Modal value -> widget.Modal <- value
    | AssistantProperty.WindowPosition value -> widget.WindowPosition <- value
    | AssistantProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | AssistantProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | AssistantProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | AssistantProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | AssistantProperty.Icon value -> widget.Icon <- value
    | AssistantProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | AssistantProperty.FocusVisible value -> widget.FocusVisible <- value
    | AssistantProperty.IconName value -> widget.IconName <- value
    | AssistantProperty.Screen value -> widget.Screen <- value
    | AssistantProperty.TypeHint value -> widget.TypeHint <- value
    | AssistantProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | AssistantProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | AssistantProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | AssistantProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | AssistantProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | AssistantProperty.Decorated value -> widget.Decorated <- value
    | AssistantProperty.Deletable value -> widget.Deletable <- value
    | AssistantProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | AssistantProperty.Gravity value -> widget.Gravity <- value
    | AssistantProperty.TransientFor value -> widget.TransientFor <- value
    | AssistantProperty.AttachedTo value -> widget.AttachedTo <- value
    | AssistantProperty.Application value -> widget.Application <- value
    | AssistantProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | AssistantProperty.ResizeMode value -> widget.ResizeMode <- value
    | AssistantProperty.BorderWidth value -> widget.BorderWidth <- value
    | AssistantProperty.Name value -> widget.Name <- value
    | AssistantProperty.Parent value -> widget.Parent <- value
    | AssistantProperty.WidthRequest value -> widget.WidthRequest <- value
    | AssistantProperty.HeightRequest value -> widget.HeightRequest <- value
    | AssistantProperty.Visible value -> widget.Visible <- value
    | AssistantProperty.Sensitive value -> widget.Sensitive <- value
    | AssistantProperty.AppPaintable value -> widget.AppPaintable <- value
    | AssistantProperty.CanFocus value -> widget.CanFocus <- value
    | AssistantProperty.HasFocus value -> widget.HasFocus <- value
    | AssistantProperty.IsFocus value -> widget.IsFocus <- value
    | AssistantProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AssistantProperty.CanDefault value -> widget.CanDefault <- value
    | AssistantProperty.HasDefault value -> widget.HasDefault <- value
    | AssistantProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AssistantProperty.Style value -> widget.Style <- value
    | AssistantProperty.Events value -> widget.Events <- value
    | AssistantProperty.NoShowAll value -> widget.NoShowAll <- value
    | AssistantProperty.HasTooltip value -> widget.HasTooltip <- value
    | AssistantProperty.TooltipText value -> widget.TooltipText <- value
    | AssistantProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AssistantProperty.Window value -> widget.Window <- value
    | AssistantProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AssistantProperty.Halign value -> widget.Halign <- value
    | AssistantProperty.Valign value -> widget.Valign <- value
    | AssistantProperty.MarginLeft value -> widget.MarginLeft <- value
    | AssistantProperty.MarginRight value -> widget.MarginRight <- value
    | AssistantProperty.MarginStart value -> widget.MarginStart <- value
    | AssistantProperty.MarginEnd value -> widget.MarginEnd <- value
    | AssistantProperty.MarginTop value -> widget.MarginTop <- value
    | AssistantProperty.MarginBottom value -> widget.MarginBottom <- value
    | AssistantProperty.Margin value -> widget.Margin <- value
    | AssistantProperty.Hexpand value -> widget.Hexpand <- value
    | AssistantProperty.HexpandSet value -> widget.HexpandSet <- value
    | AssistantProperty.Vexpand value -> widget.Vexpand <- value
    | AssistantProperty.VexpandSet value -> widget.VexpandSet <- value
    | AssistantProperty.Expand value -> widget.Expand <- value
    | AssistantProperty.Opacity value -> widget.Opacity <- value
    | AssistantProperty.OnPrepare handler -> 
        let disposable = widget.Prepare.Subscribe(handler)
        registerListener widget "Prepare" disposable
    | AssistantProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | AssistantProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | AssistantProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | AssistantProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | AssistantProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | AssistantProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AssistantProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AssistantProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AssistantProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AssistantProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AssistantProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AssistantProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AssistantProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AssistantProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AssistantProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AssistantProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AssistantProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AssistantProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AssistantProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AssistantProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AssistantProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AssistantProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AssistantProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AssistantProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AssistantProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AssistantProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AssistantProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AssistantProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AssistantProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AssistantProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AssistantProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AssistantProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AssistantProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AssistantProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AssistantProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AssistantProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AssistantProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AssistantProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AssistantProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AssistantProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AssistantProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AssistantProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AssistantProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AssistantProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AssistantProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AssistantProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AssistantProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AssistantProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AssistantProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AssistantProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AssistantProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AssistantProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AssistantProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AssistantProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AssistantProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AssistantProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AssistantProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AssistantProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AssistantProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AssistantProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AssistantProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AssistantProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AssistantPropertyBuilder() =
    inherit BasePropertyBuilder<AssistantProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: AssistantProperty seq, value: System.String) =
        seq { yield! it; yield AssistantProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: AssistantProperty seq, value: System.String) =
        seq { yield! it; yield AssistantProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: AssistantProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield AssistantProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: AssistantProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield AssistantProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: AssistantProperty seq, value: System.String) =
        seq { yield! it; yield AssistantProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: AssistantProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield AssistantProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: AssistantProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield AssistantProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: AssistantProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield AssistantProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: AssistantProperty seq, value: Gtk.Window) =
        seq { yield! it; yield AssistantProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: AssistantProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AssistantProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: AssistantProperty seq, value: Gtk.Application) =
        seq { yield! it; yield AssistantProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: AssistantProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield AssistantProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: AssistantProperty seq, value: System.UInt32) =
        seq { yield! it; yield AssistantProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: AssistantProperty seq, value: System.String) =
        seq { yield! it; yield AssistantProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AssistantProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AssistantProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AssistantProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AssistantProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AssistantProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AssistantProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AssistantProperty seq, value: System.String) =
        seq { yield! it; yield AssistantProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AssistantProperty seq, value: System.String) =
        seq { yield! it; yield AssistantProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AssistantProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AssistantProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AssistantProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AssistantProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AssistantProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AssistantProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AssistantProperty seq, value: System.Int32) =
        seq { yield! it; yield AssistantProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AssistantProperty seq, value: System.Boolean) =
        seq { yield! it; yield AssistantProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AssistantProperty seq, value: System.Double) =
        seq { yield! it; yield AssistantProperty.Opacity value } 
    [<CustomOperation("onPrepare")>]
    member this.OnPrepare(it: AssistantProperty seq, value: Gtk.PrepareArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnPrepare value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: AssistantProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: AssistantProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: AssistantProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: AssistantProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: AssistantProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AssistantProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AssistantProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AssistantProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AssistantProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AssistantProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AssistantProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AssistantProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AssistantProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AssistantProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AssistantProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AssistantProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AssistantProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AssistantProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AssistantProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AssistantProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AssistantProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AssistantProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AssistantProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AssistantProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AssistantProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AssistantProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AssistantProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AssistantProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AssistantProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AssistantProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AssistantProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AssistantProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AssistantProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AssistantProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AssistantProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AssistantProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AssistantProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AssistantProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AssistantProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AssistantProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AssistantProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AssistantProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AssistantProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AssistantProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AssistantProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AssistantProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AssistantProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AssistantProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AssistantProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AssistantProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AssistantProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AssistantProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AssistantProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AssistantProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AssistantProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AssistantProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AssistantProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AssistantProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AssistantProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AssistantProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AssistantProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AssistantProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AssistantProperty.OnFocused value } 

let prop = AssistantPropertyBuilder()

type AssistantDescriptor(props) =
    inherit BaseWidgetDescriptor<Assistant, AssistantProperty>(props, bindProperty)
    override this.CreateTyped() = new Assistant()

let assistant props = AssistantDescriptor(props)

