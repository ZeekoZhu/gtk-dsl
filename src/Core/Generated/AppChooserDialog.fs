module GtkDsl.Binding.AppChooserDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AppChooserDialogProperty =
    | Heading of System.String
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

let bindProperty (widget: AppChooserDialog) (prop: AppChooserDialogProperty) =
    match prop with
    | AppChooserDialogProperty.Heading value -> widget.Heading <- value
    | AppChooserDialogProperty.Title value -> widget.Title <- value
    | AppChooserDialogProperty.Role value -> widget.Role <- value
    | AppChooserDialogProperty.Resizable value -> widget.Resizable <- value
    | AppChooserDialogProperty.Modal value -> widget.Modal <- value
    | AppChooserDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | AppChooserDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | AppChooserDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | AppChooserDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | AppChooserDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | AppChooserDialogProperty.Icon value -> widget.Icon <- value
    | AppChooserDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | AppChooserDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | AppChooserDialogProperty.IconName value -> widget.IconName <- value
    | AppChooserDialogProperty.Screen value -> widget.Screen <- value
    | AppChooserDialogProperty.TypeHint value -> widget.TypeHint <- value
    | AppChooserDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | AppChooserDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | AppChooserDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | AppChooserDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | AppChooserDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | AppChooserDialogProperty.Decorated value -> widget.Decorated <- value
    | AppChooserDialogProperty.Deletable value -> widget.Deletable <- value
    | AppChooserDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | AppChooserDialogProperty.Gravity value -> widget.Gravity <- value
    | AppChooserDialogProperty.TransientFor value -> widget.TransientFor <- value
    | AppChooserDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | AppChooserDialogProperty.Application value -> widget.Application <- value
    | AppChooserDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | AppChooserDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | AppChooserDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | AppChooserDialogProperty.Name value -> widget.Name <- value
    | AppChooserDialogProperty.Parent value -> widget.Parent <- value
    | AppChooserDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | AppChooserDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | AppChooserDialogProperty.Visible value -> widget.Visible <- value
    | AppChooserDialogProperty.Sensitive value -> widget.Sensitive <- value
    | AppChooserDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | AppChooserDialogProperty.CanFocus value -> widget.CanFocus <- value
    | AppChooserDialogProperty.HasFocus value -> widget.HasFocus <- value
    | AppChooserDialogProperty.IsFocus value -> widget.IsFocus <- value
    | AppChooserDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AppChooserDialogProperty.CanDefault value -> widget.CanDefault <- value
    | AppChooserDialogProperty.HasDefault value -> widget.HasDefault <- value
    | AppChooserDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AppChooserDialogProperty.Style value -> widget.Style <- value
    | AppChooserDialogProperty.Events value -> widget.Events <- value
    | AppChooserDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | AppChooserDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | AppChooserDialogProperty.TooltipText value -> widget.TooltipText <- value
    | AppChooserDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AppChooserDialogProperty.Window value -> widget.Window <- value
    | AppChooserDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AppChooserDialogProperty.Halign value -> widget.Halign <- value
    | AppChooserDialogProperty.Valign value -> widget.Valign <- value
    | AppChooserDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | AppChooserDialogProperty.MarginRight value -> widget.MarginRight <- value
    | AppChooserDialogProperty.MarginStart value -> widget.MarginStart <- value
    | AppChooserDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | AppChooserDialogProperty.MarginTop value -> widget.MarginTop <- value
    | AppChooserDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | AppChooserDialogProperty.Margin value -> widget.Margin <- value
    | AppChooserDialogProperty.Hexpand value -> widget.Hexpand <- value
    | AppChooserDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | AppChooserDialogProperty.Vexpand value -> widget.Vexpand <- value
    | AppChooserDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | AppChooserDialogProperty.Expand value -> widget.Expand <- value
    | AppChooserDialogProperty.Opacity value -> widget.Opacity <- value
    | AppChooserDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | AppChooserDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | AppChooserDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | AppChooserDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | AppChooserDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | AppChooserDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | AppChooserDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AppChooserDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AppChooserDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AppChooserDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AppChooserDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AppChooserDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AppChooserDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AppChooserDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AppChooserDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AppChooserDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AppChooserDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AppChooserDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AppChooserDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AppChooserDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AppChooserDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AppChooserDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AppChooserDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AppChooserDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AppChooserDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AppChooserDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AppChooserDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AppChooserDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AppChooserDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AppChooserDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AppChooserDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AppChooserDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AppChooserDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AppChooserDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AppChooserDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AppChooserDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AppChooserDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AppChooserDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AppChooserDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AppChooserDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AppChooserDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AppChooserDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AppChooserDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AppChooserDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AppChooserDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AppChooserDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AppChooserDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AppChooserDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AppChooserDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AppChooserDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AppChooserDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AppChooserDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AppChooserDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AppChooserDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AppChooserDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AppChooserDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AppChooserDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AppChooserDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AppChooserDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AppChooserDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AppChooserDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AppChooserDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AppChooserDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AppChooserDialogPropertyBuilder() =
    inherit BasePropertyBuilder<AppChooserDialogProperty>()
    [<CustomOperation("heading")>]
    member this.Heading(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.Heading value } 
    [<CustomOperation("title")>]
    member this.Title(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: AppChooserDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield AppChooserDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: AppChooserDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield AppChooserDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: AppChooserDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield AppChooserDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: AppChooserDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield AppChooserDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: AppChooserDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield AppChooserDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: AppChooserDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield AppChooserDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: AppChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AppChooserDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: AppChooserDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield AppChooserDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: AppChooserDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield AppChooserDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: AppChooserDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield AppChooserDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AppChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AppChooserDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AppChooserDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AppChooserDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AppChooserDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AppChooserDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AppChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield AppChooserDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AppChooserDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AppChooserDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AppChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AppChooserDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AppChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AppChooserDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AppChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AppChooserDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AppChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AppChooserDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AppChooserDialogProperty seq, value: System.Double) =
        seq { yield! it; yield AppChooserDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: AppChooserDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: AppChooserDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: AppChooserDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: AppChooserDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: AppChooserDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: AppChooserDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AppChooserDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AppChooserDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AppChooserDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AppChooserDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AppChooserDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AppChooserDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AppChooserDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AppChooserDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AppChooserDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AppChooserDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AppChooserDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AppChooserDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AppChooserDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AppChooserDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AppChooserDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AppChooserDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AppChooserDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AppChooserDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AppChooserDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AppChooserDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AppChooserDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AppChooserDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AppChooserDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AppChooserDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AppChooserDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AppChooserDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AppChooserDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AppChooserDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AppChooserDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AppChooserDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AppChooserDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AppChooserDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AppChooserDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AppChooserDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AppChooserDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AppChooserDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AppChooserDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AppChooserDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AppChooserDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AppChooserDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AppChooserDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AppChooserDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AppChooserDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AppChooserDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AppChooserDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AppChooserDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AppChooserDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AppChooserDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AppChooserDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AppChooserDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AppChooserDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AppChooserDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AppChooserDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AppChooserDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AppChooserDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AppChooserDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AppChooserDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AppChooserDialogProperty.OnFocused value } 

let prop = AppChooserDialogPropertyBuilder()

