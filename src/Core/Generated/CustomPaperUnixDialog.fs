module GtkDsl.Binding.CustomPaperUnixDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type CustomPaperUnixDialogProperty =
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

let bindProperty (widget: CustomPaperUnixDialog) (prop: CustomPaperUnixDialogProperty) =
    match prop with
    | CustomPaperUnixDialogProperty.Title value -> widget.Title <- value
    | CustomPaperUnixDialogProperty.Role value -> widget.Role <- value
    | CustomPaperUnixDialogProperty.Resizable value -> widget.Resizable <- value
    | CustomPaperUnixDialogProperty.Modal value -> widget.Modal <- value
    | CustomPaperUnixDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | CustomPaperUnixDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | CustomPaperUnixDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | CustomPaperUnixDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | CustomPaperUnixDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | CustomPaperUnixDialogProperty.Icon value -> widget.Icon <- value
    | CustomPaperUnixDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | CustomPaperUnixDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | CustomPaperUnixDialogProperty.IconName value -> widget.IconName <- value
    | CustomPaperUnixDialogProperty.Screen value -> widget.Screen <- value
    | CustomPaperUnixDialogProperty.TypeHint value -> widget.TypeHint <- value
    | CustomPaperUnixDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | CustomPaperUnixDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | CustomPaperUnixDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | CustomPaperUnixDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | CustomPaperUnixDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | CustomPaperUnixDialogProperty.Decorated value -> widget.Decorated <- value
    | CustomPaperUnixDialogProperty.Deletable value -> widget.Deletable <- value
    | CustomPaperUnixDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | CustomPaperUnixDialogProperty.Gravity value -> widget.Gravity <- value
    | CustomPaperUnixDialogProperty.TransientFor value -> widget.TransientFor <- value
    | CustomPaperUnixDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | CustomPaperUnixDialogProperty.Application value -> widget.Application <- value
    | CustomPaperUnixDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | CustomPaperUnixDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | CustomPaperUnixDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | CustomPaperUnixDialogProperty.Name value -> widget.Name <- value
    | CustomPaperUnixDialogProperty.Parent value -> widget.Parent <- value
    | CustomPaperUnixDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | CustomPaperUnixDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | CustomPaperUnixDialogProperty.Visible value -> widget.Visible <- value
    | CustomPaperUnixDialogProperty.Sensitive value -> widget.Sensitive <- value
    | CustomPaperUnixDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | CustomPaperUnixDialogProperty.CanFocus value -> widget.CanFocus <- value
    | CustomPaperUnixDialogProperty.HasFocus value -> widget.HasFocus <- value
    | CustomPaperUnixDialogProperty.IsFocus value -> widget.IsFocus <- value
    | CustomPaperUnixDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | CustomPaperUnixDialogProperty.CanDefault value -> widget.CanDefault <- value
    | CustomPaperUnixDialogProperty.HasDefault value -> widget.HasDefault <- value
    | CustomPaperUnixDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | CustomPaperUnixDialogProperty.Style value -> widget.Style <- value
    | CustomPaperUnixDialogProperty.Events value -> widget.Events <- value
    | CustomPaperUnixDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | CustomPaperUnixDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | CustomPaperUnixDialogProperty.TooltipText value -> widget.TooltipText <- value
    | CustomPaperUnixDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | CustomPaperUnixDialogProperty.Window value -> widget.Window <- value
    | CustomPaperUnixDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | CustomPaperUnixDialogProperty.Halign value -> widget.Halign <- value
    | CustomPaperUnixDialogProperty.Valign value -> widget.Valign <- value
    | CustomPaperUnixDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | CustomPaperUnixDialogProperty.MarginRight value -> widget.MarginRight <- value
    | CustomPaperUnixDialogProperty.MarginStart value -> widget.MarginStart <- value
    | CustomPaperUnixDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | CustomPaperUnixDialogProperty.MarginTop value -> widget.MarginTop <- value
    | CustomPaperUnixDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | CustomPaperUnixDialogProperty.Margin value -> widget.Margin <- value
    | CustomPaperUnixDialogProperty.Hexpand value -> widget.Hexpand <- value
    | CustomPaperUnixDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | CustomPaperUnixDialogProperty.Vexpand value -> widget.Vexpand <- value
    | CustomPaperUnixDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | CustomPaperUnixDialogProperty.Expand value -> widget.Expand <- value
    | CustomPaperUnixDialogProperty.Opacity value -> widget.Opacity <- value
    | CustomPaperUnixDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | CustomPaperUnixDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | CustomPaperUnixDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | CustomPaperUnixDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | CustomPaperUnixDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | CustomPaperUnixDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | CustomPaperUnixDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | CustomPaperUnixDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | CustomPaperUnixDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | CustomPaperUnixDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | CustomPaperUnixDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | CustomPaperUnixDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | CustomPaperUnixDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | CustomPaperUnixDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | CustomPaperUnixDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | CustomPaperUnixDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | CustomPaperUnixDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | CustomPaperUnixDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | CustomPaperUnixDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | CustomPaperUnixDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | CustomPaperUnixDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | CustomPaperUnixDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | CustomPaperUnixDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | CustomPaperUnixDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | CustomPaperUnixDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | CustomPaperUnixDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | CustomPaperUnixDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | CustomPaperUnixDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | CustomPaperUnixDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | CustomPaperUnixDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | CustomPaperUnixDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | CustomPaperUnixDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | CustomPaperUnixDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | CustomPaperUnixDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | CustomPaperUnixDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | CustomPaperUnixDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | CustomPaperUnixDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | CustomPaperUnixDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | CustomPaperUnixDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | CustomPaperUnixDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | CustomPaperUnixDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | CustomPaperUnixDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | CustomPaperUnixDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | CustomPaperUnixDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | CustomPaperUnixDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | CustomPaperUnixDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | CustomPaperUnixDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | CustomPaperUnixDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | CustomPaperUnixDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | CustomPaperUnixDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | CustomPaperUnixDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | CustomPaperUnixDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | CustomPaperUnixDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | CustomPaperUnixDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | CustomPaperUnixDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | CustomPaperUnixDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | CustomPaperUnixDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | CustomPaperUnixDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | CustomPaperUnixDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | CustomPaperUnixDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | CustomPaperUnixDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | CustomPaperUnixDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | CustomPaperUnixDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type CustomPaperUnixDialogPropertyBuilder() =
    inherit BasePropertyBuilder<CustomPaperUnixDialogProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: CustomPaperUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: CustomPaperUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: CustomPaperUnixDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: CustomPaperUnixDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: CustomPaperUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: CustomPaperUnixDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: CustomPaperUnixDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: CustomPaperUnixDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: CustomPaperUnixDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: CustomPaperUnixDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: CustomPaperUnixDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: CustomPaperUnixDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: CustomPaperUnixDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: CustomPaperUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: CustomPaperUnixDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: CustomPaperUnixDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: CustomPaperUnixDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: CustomPaperUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: CustomPaperUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: CustomPaperUnixDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: CustomPaperUnixDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: CustomPaperUnixDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: CustomPaperUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: CustomPaperUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: CustomPaperUnixDialogProperty seq, value: System.Double) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: CustomPaperUnixDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: CustomPaperUnixDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: CustomPaperUnixDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: CustomPaperUnixDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: CustomPaperUnixDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: CustomPaperUnixDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: CustomPaperUnixDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: CustomPaperUnixDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: CustomPaperUnixDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: CustomPaperUnixDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: CustomPaperUnixDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: CustomPaperUnixDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: CustomPaperUnixDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: CustomPaperUnixDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: CustomPaperUnixDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: CustomPaperUnixDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: CustomPaperUnixDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: CustomPaperUnixDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: CustomPaperUnixDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: CustomPaperUnixDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: CustomPaperUnixDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: CustomPaperUnixDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: CustomPaperUnixDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: CustomPaperUnixDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: CustomPaperUnixDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: CustomPaperUnixDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: CustomPaperUnixDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: CustomPaperUnixDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: CustomPaperUnixDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield CustomPaperUnixDialogProperty.OnFocused value } 

let prop = CustomPaperUnixDialogPropertyBuilder()

