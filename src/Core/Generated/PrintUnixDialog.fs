module Gtk.DSL.Binding.PrintUnixDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PrintUnixDialogProperty =
    | PageSetup of Gtk.PageSetup
    | CurrentPage of System.Int32
    | PrintSettings of Gtk.PrintSettings
    | ManualCapabilities of Gtk.PrintCapabilities
    | SupportSelection of System.Boolean
    | HasSelection of System.Boolean
    | EmbedPageSetup of System.Boolean
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

let bindProperty (widget: PrintUnixDialog) (prop: PrintUnixDialogProperty) =
    match prop with
    | PrintUnixDialogProperty.PageSetup value -> widget.PageSetup <- value
    | PrintUnixDialogProperty.CurrentPage value -> widget.CurrentPage <- value
    | PrintUnixDialogProperty.PrintSettings value -> widget.PrintSettings <- value
    | PrintUnixDialogProperty.ManualCapabilities value -> widget.ManualCapabilities <- value
    | PrintUnixDialogProperty.SupportSelection value -> widget.SupportSelection <- value
    | PrintUnixDialogProperty.HasSelection value -> widget.HasSelection <- value
    | PrintUnixDialogProperty.EmbedPageSetup value -> widget.EmbedPageSetup <- value
    | PrintUnixDialogProperty.Title value -> widget.Title <- value
    | PrintUnixDialogProperty.Role value -> widget.Role <- value
    | PrintUnixDialogProperty.Resizable value -> widget.Resizable <- value
    | PrintUnixDialogProperty.Modal value -> widget.Modal <- value
    | PrintUnixDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | PrintUnixDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | PrintUnixDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | PrintUnixDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | PrintUnixDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | PrintUnixDialogProperty.Icon value -> widget.Icon <- value
    | PrintUnixDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | PrintUnixDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | PrintUnixDialogProperty.IconName value -> widget.IconName <- value
    | PrintUnixDialogProperty.Screen value -> widget.Screen <- value
    | PrintUnixDialogProperty.TypeHint value -> widget.TypeHint <- value
    | PrintUnixDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | PrintUnixDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | PrintUnixDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | PrintUnixDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | PrintUnixDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | PrintUnixDialogProperty.Decorated value -> widget.Decorated <- value
    | PrintUnixDialogProperty.Deletable value -> widget.Deletable <- value
    | PrintUnixDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | PrintUnixDialogProperty.Gravity value -> widget.Gravity <- value
    | PrintUnixDialogProperty.TransientFor value -> widget.TransientFor <- value
    | PrintUnixDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | PrintUnixDialogProperty.Application value -> widget.Application <- value
    | PrintUnixDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | PrintUnixDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | PrintUnixDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | PrintUnixDialogProperty.Name value -> widget.Name <- value
    | PrintUnixDialogProperty.Parent value -> widget.Parent <- value
    | PrintUnixDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | PrintUnixDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | PrintUnixDialogProperty.Visible value -> widget.Visible <- value
    | PrintUnixDialogProperty.Sensitive value -> widget.Sensitive <- value
    | PrintUnixDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | PrintUnixDialogProperty.CanFocus value -> widget.CanFocus <- value
    | PrintUnixDialogProperty.HasFocus value -> widget.HasFocus <- value
    | PrintUnixDialogProperty.IsFocus value -> widget.IsFocus <- value
    | PrintUnixDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PrintUnixDialogProperty.CanDefault value -> widget.CanDefault <- value
    | PrintUnixDialogProperty.HasDefault value -> widget.HasDefault <- value
    | PrintUnixDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PrintUnixDialogProperty.Style value -> widget.Style <- value
    | PrintUnixDialogProperty.Events value -> widget.Events <- value
    | PrintUnixDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | PrintUnixDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | PrintUnixDialogProperty.TooltipText value -> widget.TooltipText <- value
    | PrintUnixDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PrintUnixDialogProperty.Window value -> widget.Window <- value
    | PrintUnixDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PrintUnixDialogProperty.Halign value -> widget.Halign <- value
    | PrintUnixDialogProperty.Valign value -> widget.Valign <- value
    | PrintUnixDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | PrintUnixDialogProperty.MarginRight value -> widget.MarginRight <- value
    | PrintUnixDialogProperty.MarginStart value -> widget.MarginStart <- value
    | PrintUnixDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | PrintUnixDialogProperty.MarginTop value -> widget.MarginTop <- value
    | PrintUnixDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | PrintUnixDialogProperty.Margin value -> widget.Margin <- value
    | PrintUnixDialogProperty.Hexpand value -> widget.Hexpand <- value
    | PrintUnixDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | PrintUnixDialogProperty.Vexpand value -> widget.Vexpand <- value
    | PrintUnixDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | PrintUnixDialogProperty.Expand value -> widget.Expand <- value
    | PrintUnixDialogProperty.Opacity value -> widget.Opacity <- value
    | PrintUnixDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | PrintUnixDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | PrintUnixDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | PrintUnixDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PrintUnixDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PrintUnixDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PrintUnixDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PrintUnixDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PrintUnixDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PrintUnixDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PrintUnixDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PrintUnixDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PrintUnixDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PrintUnixDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PrintUnixDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PrintUnixDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PrintUnixDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PrintUnixDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PrintUnixDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PrintUnixDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PrintUnixDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PrintUnixDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PrintUnixDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PrintUnixDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PrintUnixDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PrintUnixDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PrintUnixDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PrintUnixDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PrintUnixDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PrintUnixDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PrintUnixDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PrintUnixDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PrintUnixDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PrintUnixDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PrintUnixDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PrintUnixDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PrintUnixDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PrintUnixDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PrintUnixDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PrintUnixDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PrintUnixDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PrintUnixDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PrintUnixDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PrintUnixDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PrintUnixDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PrintUnixDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PrintUnixDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PrintUnixDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PrintUnixDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PrintUnixDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PrintUnixDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PrintUnixDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PrintUnixDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PrintUnixDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PrintUnixDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PrintUnixDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PrintUnixDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PrintUnixDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PrintUnixDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PrintUnixDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PrintUnixDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PrintUnixDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PrintUnixDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PrintUnixDialogPropertyBuilder() =
    inherit BasePropertyBuilder<PrintUnixDialogProperty>()
    [<CustomOperation("pageSetup")>]
    member this.PageSetup(it: PrintUnixDialogProperty seq, value: Gtk.PageSetup) =
        seq { yield! it; yield PrintUnixDialogProperty.PageSetup value } 
    [<CustomOperation("currentPage")>]
    member this.CurrentPage(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.CurrentPage value } 
    [<CustomOperation("printSettings")>]
    member this.PrintSettings(it: PrintUnixDialogProperty seq, value: Gtk.PrintSettings) =
        seq { yield! it; yield PrintUnixDialogProperty.PrintSettings value } 
    [<CustomOperation("manualCapabilities")>]
    member this.ManualCapabilities(it: PrintUnixDialogProperty seq, value: Gtk.PrintCapabilities) =
        seq { yield! it; yield PrintUnixDialogProperty.ManualCapabilities value } 
    [<CustomOperation("supportSelection")>]
    member this.SupportSelection(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.SupportSelection value } 
    [<CustomOperation("hasSelection")>]
    member this.HasSelection(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HasSelection value } 
    [<CustomOperation("embedPageSetup")>]
    member this.EmbedPageSetup(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.EmbedPageSetup value } 
    [<CustomOperation("title")>]
    member this.Title(it: PrintUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PrintUnixDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: PrintUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PrintUnixDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: PrintUnixDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield PrintUnixDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: PrintUnixDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield PrintUnixDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: PrintUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PrintUnixDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: PrintUnixDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield PrintUnixDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: PrintUnixDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield PrintUnixDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: PrintUnixDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield PrintUnixDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: PrintUnixDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield PrintUnixDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: PrintUnixDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PrintUnixDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: PrintUnixDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield PrintUnixDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PrintUnixDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PrintUnixDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PrintUnixDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield PrintUnixDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PrintUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PrintUnixDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PrintUnixDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PrintUnixDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PrintUnixDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PrintUnixDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PrintUnixDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PrintUnixDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PrintUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PrintUnixDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PrintUnixDialogProperty seq, value: System.String) =
        seq { yield! it; yield PrintUnixDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PrintUnixDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PrintUnixDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PrintUnixDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PrintUnixDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PrintUnixDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PrintUnixDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PrintUnixDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield PrintUnixDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PrintUnixDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield PrintUnixDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PrintUnixDialogProperty seq, value: System.Double) =
        seq { yield! it; yield PrintUnixDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: PrintUnixDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: PrintUnixDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: PrintUnixDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PrintUnixDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PrintUnixDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PrintUnixDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PrintUnixDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PrintUnixDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PrintUnixDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PrintUnixDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PrintUnixDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PrintUnixDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PrintUnixDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PrintUnixDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PrintUnixDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PrintUnixDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PrintUnixDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PrintUnixDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PrintUnixDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PrintUnixDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PrintUnixDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PrintUnixDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PrintUnixDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PrintUnixDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PrintUnixDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PrintUnixDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PrintUnixDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PrintUnixDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PrintUnixDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PrintUnixDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PrintUnixDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PrintUnixDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PrintUnixDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PrintUnixDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PrintUnixDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PrintUnixDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PrintUnixDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PrintUnixDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PrintUnixDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PrintUnixDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PrintUnixDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PrintUnixDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PrintUnixDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PrintUnixDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PrintUnixDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PrintUnixDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PrintUnixDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PrintUnixDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PrintUnixDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PrintUnixDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PrintUnixDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PrintUnixDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PrintUnixDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PrintUnixDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PrintUnixDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PrintUnixDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PrintUnixDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PrintUnixDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PrintUnixDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PrintUnixDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PrintUnixDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PrintUnixDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PrintUnixDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PrintUnixDialogProperty.OnFocused value } 

let prop = PrintUnixDialogPropertyBuilder()

