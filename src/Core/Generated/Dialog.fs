module Gtk.DSL.Binding.Dialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type DialogProperty =
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

let bindProperty (widget: Dialog) (prop: DialogProperty) =
    match prop with
    | DialogProperty.Title value -> widget.Title <- value
    | DialogProperty.Role value -> widget.Role <- value
    | DialogProperty.Resizable value -> widget.Resizable <- value
    | DialogProperty.Modal value -> widget.Modal <- value
    | DialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | DialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | DialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | DialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | DialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | DialogProperty.Icon value -> widget.Icon <- value
    | DialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | DialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | DialogProperty.IconName value -> widget.IconName <- value
    | DialogProperty.Screen value -> widget.Screen <- value
    | DialogProperty.TypeHint value -> widget.TypeHint <- value
    | DialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | DialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | DialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | DialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | DialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | DialogProperty.Decorated value -> widget.Decorated <- value
    | DialogProperty.Deletable value -> widget.Deletable <- value
    | DialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | DialogProperty.Gravity value -> widget.Gravity <- value
    | DialogProperty.TransientFor value -> widget.TransientFor <- value
    | DialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | DialogProperty.Application value -> widget.Application <- value
    | DialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | DialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | DialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | DialogProperty.Name value -> widget.Name <- value
    | DialogProperty.Parent value -> widget.Parent <- value
    | DialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | DialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | DialogProperty.Visible value -> widget.Visible <- value
    | DialogProperty.Sensitive value -> widget.Sensitive <- value
    | DialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | DialogProperty.CanFocus value -> widget.CanFocus <- value
    | DialogProperty.HasFocus value -> widget.HasFocus <- value
    | DialogProperty.IsFocus value -> widget.IsFocus <- value
    | DialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | DialogProperty.CanDefault value -> widget.CanDefault <- value
    | DialogProperty.HasDefault value -> widget.HasDefault <- value
    | DialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | DialogProperty.Style value -> widget.Style <- value
    | DialogProperty.Events value -> widget.Events <- value
    | DialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | DialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | DialogProperty.TooltipText value -> widget.TooltipText <- value
    | DialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | DialogProperty.Window value -> widget.Window <- value
    | DialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | DialogProperty.Halign value -> widget.Halign <- value
    | DialogProperty.Valign value -> widget.Valign <- value
    | DialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | DialogProperty.MarginRight value -> widget.MarginRight <- value
    | DialogProperty.MarginStart value -> widget.MarginStart <- value
    | DialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | DialogProperty.MarginTop value -> widget.MarginTop <- value
    | DialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | DialogProperty.Margin value -> widget.Margin <- value
    | DialogProperty.Hexpand value -> widget.Hexpand <- value
    | DialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | DialogProperty.Vexpand value -> widget.Vexpand <- value
    | DialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | DialogProperty.Expand value -> widget.Expand <- value
    | DialogProperty.Opacity value -> widget.Opacity <- value
    | DialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | DialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | DialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | DialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | DialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | DialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | DialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | DialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | DialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | DialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | DialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | DialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | DialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | DialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | DialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | DialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | DialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | DialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | DialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | DialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | DialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | DialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | DialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | DialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | DialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | DialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | DialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | DialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | DialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | DialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | DialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | DialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | DialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | DialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | DialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | DialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | DialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | DialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | DialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | DialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | DialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | DialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | DialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | DialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | DialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | DialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | DialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | DialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | DialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | DialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | DialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | DialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | DialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | DialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | DialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | DialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | DialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | DialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | DialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | DialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | DialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | DialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | DialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type DialogPropertyBuilder() =
    inherit BasePropertyBuilder<DialogProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: DialogProperty seq, value: System.String) =
        seq { yield! it; yield DialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: DialogProperty seq, value: System.String) =
        seq { yield! it; yield DialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: DialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield DialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: DialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield DialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: DialogProperty seq, value: System.String) =
        seq { yield! it; yield DialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: DialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield DialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: DialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield DialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: DialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield DialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: DialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield DialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: DialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield DialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: DialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield DialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: DialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield DialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: DialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield DialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: DialogProperty seq, value: System.String) =
        seq { yield! it; yield DialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: DialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield DialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: DialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield DialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: DialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield DialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: DialogProperty seq, value: System.String) =
        seq { yield! it; yield DialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: DialogProperty seq, value: System.String) =
        seq { yield! it; yield DialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: DialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield DialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: DialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield DialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: DialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield DialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: DialogProperty seq, value: System.Int32) =
        seq { yield! it; yield DialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: DialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield DialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: DialogProperty seq, value: System.Double) =
        seq { yield! it; yield DialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: DialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: DialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: DialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: DialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: DialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: DialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: DialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: DialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: DialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: DialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: DialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: DialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: DialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: DialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: DialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: DialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: DialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: DialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: DialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: DialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: DialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: DialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: DialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: DialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: DialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: DialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: DialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: DialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: DialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: DialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: DialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: DialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: DialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: DialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: DialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: DialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: DialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: DialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: DialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: DialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: DialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: DialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: DialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: DialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: DialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: DialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: DialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: DialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: DialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: DialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: DialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: DialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: DialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: DialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: DialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: DialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: DialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: DialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: DialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: DialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: DialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: DialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: DialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield DialogProperty.OnFocused value } 

let prop = DialogPropertyBuilder()

type DialogDescriptor(props) =
    inherit BaseWidgetDescriptor<Dialog, DialogProperty>(props, bindProperty)
    override this.CreateTyped() = new Dialog()

let dialog props = DialogDescriptor(props)

