module GtkDsl.Binding.ColorChooserDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type ColorChooserDialogProperty =
    | ShowEditor of System.Boolean
    | Rgba of Gdk.RGBA
    | UseAlpha of System.Boolean
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
    |  OnColorActivated of (Gtk.ColorActivatedArgs -> unit)
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

let bindProperty (widget: ColorChooserDialog) (prop: ColorChooserDialogProperty) =
    match prop with
    | ColorChooserDialogProperty.ShowEditor value -> widget.ShowEditor <- value
    | ColorChooserDialogProperty.Rgba value -> widget.Rgba <- value
    | ColorChooserDialogProperty.UseAlpha value -> widget.UseAlpha <- value
    | ColorChooserDialogProperty.Title value -> widget.Title <- value
    | ColorChooserDialogProperty.Role value -> widget.Role <- value
    | ColorChooserDialogProperty.Resizable value -> widget.Resizable <- value
    | ColorChooserDialogProperty.Modal value -> widget.Modal <- value
    | ColorChooserDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | ColorChooserDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | ColorChooserDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | ColorChooserDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | ColorChooserDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | ColorChooserDialogProperty.Icon value -> widget.Icon <- value
    | ColorChooserDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | ColorChooserDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | ColorChooserDialogProperty.IconName value -> widget.IconName <- value
    | ColorChooserDialogProperty.Screen value -> widget.Screen <- value
    | ColorChooserDialogProperty.TypeHint value -> widget.TypeHint <- value
    | ColorChooserDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | ColorChooserDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | ColorChooserDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | ColorChooserDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | ColorChooserDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | ColorChooserDialogProperty.Decorated value -> widget.Decorated <- value
    | ColorChooserDialogProperty.Deletable value -> widget.Deletable <- value
    | ColorChooserDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | ColorChooserDialogProperty.Gravity value -> widget.Gravity <- value
    | ColorChooserDialogProperty.TransientFor value -> widget.TransientFor <- value
    | ColorChooserDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | ColorChooserDialogProperty.Application value -> widget.Application <- value
    | ColorChooserDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | ColorChooserDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | ColorChooserDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | ColorChooserDialogProperty.Name value -> widget.Name <- value
    | ColorChooserDialogProperty.Parent value -> widget.Parent <- value
    | ColorChooserDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | ColorChooserDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | ColorChooserDialogProperty.Visible value -> widget.Visible <- value
    | ColorChooserDialogProperty.Sensitive value -> widget.Sensitive <- value
    | ColorChooserDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | ColorChooserDialogProperty.CanFocus value -> widget.CanFocus <- value
    | ColorChooserDialogProperty.HasFocus value -> widget.HasFocus <- value
    | ColorChooserDialogProperty.IsFocus value -> widget.IsFocus <- value
    | ColorChooserDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | ColorChooserDialogProperty.CanDefault value -> widget.CanDefault <- value
    | ColorChooserDialogProperty.HasDefault value -> widget.HasDefault <- value
    | ColorChooserDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | ColorChooserDialogProperty.Style value -> widget.Style <- value
    | ColorChooserDialogProperty.Events value -> widget.Events <- value
    | ColorChooserDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | ColorChooserDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | ColorChooserDialogProperty.TooltipText value -> widget.TooltipText <- value
    | ColorChooserDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | ColorChooserDialogProperty.Window value -> widget.Window <- value
    | ColorChooserDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | ColorChooserDialogProperty.Halign value -> widget.Halign <- value
    | ColorChooserDialogProperty.Valign value -> widget.Valign <- value
    | ColorChooserDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | ColorChooserDialogProperty.MarginRight value -> widget.MarginRight <- value
    | ColorChooserDialogProperty.MarginStart value -> widget.MarginStart <- value
    | ColorChooserDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | ColorChooserDialogProperty.MarginTop value -> widget.MarginTop <- value
    | ColorChooserDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | ColorChooserDialogProperty.Margin value -> widget.Margin <- value
    | ColorChooserDialogProperty.Hexpand value -> widget.Hexpand <- value
    | ColorChooserDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | ColorChooserDialogProperty.Vexpand value -> widget.Vexpand <- value
    | ColorChooserDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | ColorChooserDialogProperty.Expand value -> widget.Expand <- value
    | ColorChooserDialogProperty.Opacity value -> widget.Opacity <- value
    | ColorChooserDialogProperty.OnColorActivated handler -> 
        let disposable = widget.ColorActivated.Subscribe(handler)
        registerListener widget "ColorActivated" disposable
    | ColorChooserDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | ColorChooserDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | ColorChooserDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | ColorChooserDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | ColorChooserDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | ColorChooserDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | ColorChooserDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | ColorChooserDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | ColorChooserDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | ColorChooserDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | ColorChooserDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | ColorChooserDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | ColorChooserDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | ColorChooserDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | ColorChooserDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | ColorChooserDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | ColorChooserDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | ColorChooserDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | ColorChooserDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | ColorChooserDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | ColorChooserDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | ColorChooserDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | ColorChooserDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | ColorChooserDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | ColorChooserDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | ColorChooserDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | ColorChooserDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | ColorChooserDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | ColorChooserDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | ColorChooserDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | ColorChooserDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | ColorChooserDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | ColorChooserDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | ColorChooserDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | ColorChooserDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | ColorChooserDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | ColorChooserDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | ColorChooserDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | ColorChooserDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | ColorChooserDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | ColorChooserDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | ColorChooserDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | ColorChooserDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | ColorChooserDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | ColorChooserDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | ColorChooserDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | ColorChooserDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | ColorChooserDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | ColorChooserDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | ColorChooserDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | ColorChooserDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | ColorChooserDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | ColorChooserDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | ColorChooserDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | ColorChooserDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | ColorChooserDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | ColorChooserDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | ColorChooserDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | ColorChooserDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | ColorChooserDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | ColorChooserDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | ColorChooserDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | ColorChooserDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type ColorChooserDialogPropertyBuilder() =
    inherit BasePropertyBuilder<ColorChooserDialogProperty>()
    [<CustomOperation("showEditor")>]
    member this.ShowEditor(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.ShowEditor value } 
    [<CustomOperation("rgba")>]
    member this.Rgba(it: ColorChooserDialogProperty seq, value: Gdk.RGBA) =
        seq { yield! it; yield ColorChooserDialogProperty.Rgba value } 
    [<CustomOperation("useAlpha")>]
    member this.UseAlpha(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.UseAlpha value } 
    [<CustomOperation("title")>]
    member this.Title(it: ColorChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: ColorChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: ColorChooserDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield ColorChooserDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: ColorChooserDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield ColorChooserDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: ColorChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: ColorChooserDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield ColorChooserDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: ColorChooserDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield ColorChooserDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: ColorChooserDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield ColorChooserDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: ColorChooserDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield ColorChooserDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: ColorChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorChooserDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: ColorChooserDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield ColorChooserDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: ColorChooserDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield ColorChooserDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: ColorChooserDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield ColorChooserDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: ColorChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: ColorChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield ColorChooserDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: ColorChooserDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield ColorChooserDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: ColorChooserDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield ColorChooserDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: ColorChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: ColorChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield ColorChooserDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: ColorChooserDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield ColorChooserDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: ColorChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorChooserDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: ColorChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield ColorChooserDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: ColorChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield ColorChooserDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: ColorChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield ColorChooserDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: ColorChooserDialogProperty seq, value: System.Double) =
        seq { yield! it; yield ColorChooserDialogProperty.Opacity value } 
    [<CustomOperation("onColorActivated")>]
    member this.OnColorActivated(it: ColorChooserDialogProperty seq, value: Gtk.ColorActivatedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnColorActivated value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: ColorChooserDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: ColorChooserDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: ColorChooserDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: ColorChooserDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: ColorChooserDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: ColorChooserDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: ColorChooserDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: ColorChooserDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: ColorChooserDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: ColorChooserDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: ColorChooserDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: ColorChooserDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: ColorChooserDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: ColorChooserDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: ColorChooserDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: ColorChooserDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: ColorChooserDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: ColorChooserDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: ColorChooserDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: ColorChooserDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: ColorChooserDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: ColorChooserDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: ColorChooserDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: ColorChooserDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: ColorChooserDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: ColorChooserDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: ColorChooserDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: ColorChooserDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: ColorChooserDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: ColorChooserDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: ColorChooserDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: ColorChooserDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: ColorChooserDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: ColorChooserDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: ColorChooserDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: ColorChooserDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: ColorChooserDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: ColorChooserDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: ColorChooserDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: ColorChooserDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: ColorChooserDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: ColorChooserDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: ColorChooserDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: ColorChooserDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: ColorChooserDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: ColorChooserDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: ColorChooserDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: ColorChooserDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: ColorChooserDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: ColorChooserDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: ColorChooserDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: ColorChooserDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: ColorChooserDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: ColorChooserDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: ColorChooserDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: ColorChooserDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: ColorChooserDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: ColorChooserDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: ColorChooserDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: ColorChooserDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: ColorChooserDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: ColorChooserDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: ColorChooserDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield ColorChooserDialogProperty.OnFocused value } 

let prop = ColorChooserDialogPropertyBuilder()

