module GtkDsl.Binding.FontChooserDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FontChooserDialogProperty =
    | Font of System.String
    | FontDesc of Pango.FontDescription
    | PreviewText of System.String
    | ShowPreviewEntry of System.Boolean
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
    |  OnFontActivated of (Gtk.FontActivatedArgs -> unit)
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

let bindProperty (widget: FontChooserDialog) (prop: FontChooserDialogProperty) =
    match prop with
    | FontChooserDialogProperty.Font value -> widget.Font <- value
    | FontChooserDialogProperty.FontDesc value -> widget.FontDesc <- value
    | FontChooserDialogProperty.PreviewText value -> widget.PreviewText <- value
    | FontChooserDialogProperty.ShowPreviewEntry value -> widget.ShowPreviewEntry <- value
    | FontChooserDialogProperty.Title value -> widget.Title <- value
    | FontChooserDialogProperty.Role value -> widget.Role <- value
    | FontChooserDialogProperty.Resizable value -> widget.Resizable <- value
    | FontChooserDialogProperty.Modal value -> widget.Modal <- value
    | FontChooserDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | FontChooserDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | FontChooserDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | FontChooserDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | FontChooserDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | FontChooserDialogProperty.Icon value -> widget.Icon <- value
    | FontChooserDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | FontChooserDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | FontChooserDialogProperty.IconName value -> widget.IconName <- value
    | FontChooserDialogProperty.Screen value -> widget.Screen <- value
    | FontChooserDialogProperty.TypeHint value -> widget.TypeHint <- value
    | FontChooserDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | FontChooserDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | FontChooserDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | FontChooserDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | FontChooserDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | FontChooserDialogProperty.Decorated value -> widget.Decorated <- value
    | FontChooserDialogProperty.Deletable value -> widget.Deletable <- value
    | FontChooserDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | FontChooserDialogProperty.Gravity value -> widget.Gravity <- value
    | FontChooserDialogProperty.TransientFor value -> widget.TransientFor <- value
    | FontChooserDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | FontChooserDialogProperty.Application value -> widget.Application <- value
    | FontChooserDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | FontChooserDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | FontChooserDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | FontChooserDialogProperty.Name value -> widget.Name <- value
    | FontChooserDialogProperty.Parent value -> widget.Parent <- value
    | FontChooserDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | FontChooserDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | FontChooserDialogProperty.Visible value -> widget.Visible <- value
    | FontChooserDialogProperty.Sensitive value -> widget.Sensitive <- value
    | FontChooserDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | FontChooserDialogProperty.CanFocus value -> widget.CanFocus <- value
    | FontChooserDialogProperty.HasFocus value -> widget.HasFocus <- value
    | FontChooserDialogProperty.IsFocus value -> widget.IsFocus <- value
    | FontChooserDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FontChooserDialogProperty.CanDefault value -> widget.CanDefault <- value
    | FontChooserDialogProperty.HasDefault value -> widget.HasDefault <- value
    | FontChooserDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FontChooserDialogProperty.Style value -> widget.Style <- value
    | FontChooserDialogProperty.Events value -> widget.Events <- value
    | FontChooserDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | FontChooserDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | FontChooserDialogProperty.TooltipText value -> widget.TooltipText <- value
    | FontChooserDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FontChooserDialogProperty.Window value -> widget.Window <- value
    | FontChooserDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FontChooserDialogProperty.Halign value -> widget.Halign <- value
    | FontChooserDialogProperty.Valign value -> widget.Valign <- value
    | FontChooserDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | FontChooserDialogProperty.MarginRight value -> widget.MarginRight <- value
    | FontChooserDialogProperty.MarginStart value -> widget.MarginStart <- value
    | FontChooserDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | FontChooserDialogProperty.MarginTop value -> widget.MarginTop <- value
    | FontChooserDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | FontChooserDialogProperty.Margin value -> widget.Margin <- value
    | FontChooserDialogProperty.Hexpand value -> widget.Hexpand <- value
    | FontChooserDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | FontChooserDialogProperty.Vexpand value -> widget.Vexpand <- value
    | FontChooserDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | FontChooserDialogProperty.Expand value -> widget.Expand <- value
    | FontChooserDialogProperty.Opacity value -> widget.Opacity <- value
    | FontChooserDialogProperty.OnFontActivated handler -> 
        let disposable = widget.FontActivated.Subscribe(handler)
        registerListener widget "FontActivated" disposable
    | FontChooserDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | FontChooserDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | FontChooserDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | FontChooserDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FontChooserDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FontChooserDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FontChooserDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FontChooserDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FontChooserDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FontChooserDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FontChooserDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FontChooserDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FontChooserDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FontChooserDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FontChooserDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FontChooserDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FontChooserDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FontChooserDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FontChooserDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FontChooserDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FontChooserDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FontChooserDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FontChooserDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FontChooserDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FontChooserDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FontChooserDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FontChooserDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FontChooserDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FontChooserDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FontChooserDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FontChooserDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FontChooserDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FontChooserDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FontChooserDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FontChooserDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FontChooserDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FontChooserDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FontChooserDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FontChooserDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FontChooserDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FontChooserDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FontChooserDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FontChooserDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FontChooserDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FontChooserDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FontChooserDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FontChooserDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FontChooserDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FontChooserDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FontChooserDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FontChooserDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FontChooserDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FontChooserDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FontChooserDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FontChooserDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FontChooserDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FontChooserDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FontChooserDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FontChooserDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FontChooserDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FontChooserDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FontChooserDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FontChooserDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FontChooserDialogPropertyBuilder() =
    inherit BasePropertyBuilder<FontChooserDialogProperty>()
    [<CustomOperation("font")>]
    member this.Font(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.Font value } 
    [<CustomOperation("fontDesc")>]
    member this.FontDesc(it: FontChooserDialogProperty seq, value: Pango.FontDescription) =
        seq { yield! it; yield FontChooserDialogProperty.FontDesc value } 
    [<CustomOperation("previewText")>]
    member this.PreviewText(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.PreviewText value } 
    [<CustomOperation("showPreviewEntry")>]
    member this.ShowPreviewEntry(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.ShowPreviewEntry value } 
    [<CustomOperation("title")>]
    member this.Title(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: FontChooserDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield FontChooserDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: FontChooserDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield FontChooserDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: FontChooserDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield FontChooserDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: FontChooserDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield FontChooserDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: FontChooserDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield FontChooserDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: FontChooserDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield FontChooserDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: FontChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontChooserDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: FontChooserDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield FontChooserDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FontChooserDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FontChooserDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FontChooserDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontChooserDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FontChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontChooserDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FontChooserDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FontChooserDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FontChooserDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FontChooserDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FontChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FontChooserDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FontChooserDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FontChooserDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FontChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontChooserDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FontChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontChooserDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FontChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FontChooserDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FontChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontChooserDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FontChooserDialogProperty seq, value: System.Double) =
        seq { yield! it; yield FontChooserDialogProperty.Opacity value } 
    [<CustomOperation("onFontActivated")>]
    member this.OnFontActivated(it: FontChooserDialogProperty seq, value: Gtk.FontActivatedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnFontActivated value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: FontChooserDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: FontChooserDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: FontChooserDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FontChooserDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FontChooserDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FontChooserDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FontChooserDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FontChooserDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FontChooserDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FontChooserDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FontChooserDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FontChooserDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FontChooserDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FontChooserDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FontChooserDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FontChooserDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FontChooserDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FontChooserDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FontChooserDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FontChooserDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FontChooserDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FontChooserDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FontChooserDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FontChooserDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FontChooserDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FontChooserDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FontChooserDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FontChooserDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FontChooserDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FontChooserDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FontChooserDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FontChooserDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FontChooserDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FontChooserDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FontChooserDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FontChooserDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FontChooserDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FontChooserDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FontChooserDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FontChooserDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FontChooserDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FontChooserDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FontChooserDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FontChooserDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FontChooserDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FontChooserDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FontChooserDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FontChooserDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FontChooserDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FontChooserDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FontChooserDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FontChooserDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FontChooserDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FontChooserDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FontChooserDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FontChooserDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FontChooserDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FontChooserDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FontChooserDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FontChooserDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FontChooserDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FontChooserDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FontChooserDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FontChooserDialogProperty.OnFocused value } 

let prop = FontChooserDialogPropertyBuilder()

