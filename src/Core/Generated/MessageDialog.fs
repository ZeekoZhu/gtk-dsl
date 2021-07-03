module Gtk.DSL.Binding.MessageDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type MessageDialogProperty =
    | MessageType of Gtk.MessageType
    | Text of System.String
    | UseMarkup of System.Boolean
    | SecondaryText of System.String
    | SecondaryUseMarkup of System.Boolean
    | [<Obsolete>] Image of Gtk.Widget
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

let bindProperty (widget: MessageDialog) (prop: MessageDialogProperty) =
    match prop with
    | MessageDialogProperty.MessageType value -> widget.MessageType <- value
    | MessageDialogProperty.Text value -> widget.Text <- value
    | MessageDialogProperty.UseMarkup value -> widget.UseMarkup <- value
    | MessageDialogProperty.SecondaryText value -> widget.SecondaryText <- value
    | MessageDialogProperty.SecondaryUseMarkup value -> widget.SecondaryUseMarkup <- value
    | MessageDialogProperty.Image value -> widget.Image <- value
    | MessageDialogProperty.Title value -> widget.Title <- value
    | MessageDialogProperty.Role value -> widget.Role <- value
    | MessageDialogProperty.Resizable value -> widget.Resizable <- value
    | MessageDialogProperty.Modal value -> widget.Modal <- value
    | MessageDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | MessageDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | MessageDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | MessageDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | MessageDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | MessageDialogProperty.Icon value -> widget.Icon <- value
    | MessageDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | MessageDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | MessageDialogProperty.IconName value -> widget.IconName <- value
    | MessageDialogProperty.Screen value -> widget.Screen <- value
    | MessageDialogProperty.TypeHint value -> widget.TypeHint <- value
    | MessageDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | MessageDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | MessageDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | MessageDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | MessageDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | MessageDialogProperty.Decorated value -> widget.Decorated <- value
    | MessageDialogProperty.Deletable value -> widget.Deletable <- value
    | MessageDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | MessageDialogProperty.Gravity value -> widget.Gravity <- value
    | MessageDialogProperty.TransientFor value -> widget.TransientFor <- value
    | MessageDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | MessageDialogProperty.Application value -> widget.Application <- value
    | MessageDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | MessageDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | MessageDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | MessageDialogProperty.Name value -> widget.Name <- value
    | MessageDialogProperty.Parent value -> widget.Parent <- value
    | MessageDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | MessageDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | MessageDialogProperty.Visible value -> widget.Visible <- value
    | MessageDialogProperty.Sensitive value -> widget.Sensitive <- value
    | MessageDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | MessageDialogProperty.CanFocus value -> widget.CanFocus <- value
    | MessageDialogProperty.HasFocus value -> widget.HasFocus <- value
    | MessageDialogProperty.IsFocus value -> widget.IsFocus <- value
    | MessageDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | MessageDialogProperty.CanDefault value -> widget.CanDefault <- value
    | MessageDialogProperty.HasDefault value -> widget.HasDefault <- value
    | MessageDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | MessageDialogProperty.Style value -> widget.Style <- value
    | MessageDialogProperty.Events value -> widget.Events <- value
    | MessageDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | MessageDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | MessageDialogProperty.TooltipText value -> widget.TooltipText <- value
    | MessageDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | MessageDialogProperty.Window value -> widget.Window <- value
    | MessageDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | MessageDialogProperty.Halign value -> widget.Halign <- value
    | MessageDialogProperty.Valign value -> widget.Valign <- value
    | MessageDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | MessageDialogProperty.MarginRight value -> widget.MarginRight <- value
    | MessageDialogProperty.MarginStart value -> widget.MarginStart <- value
    | MessageDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | MessageDialogProperty.MarginTop value -> widget.MarginTop <- value
    | MessageDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | MessageDialogProperty.Margin value -> widget.Margin <- value
    | MessageDialogProperty.Hexpand value -> widget.Hexpand <- value
    | MessageDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | MessageDialogProperty.Vexpand value -> widget.Vexpand <- value
    | MessageDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | MessageDialogProperty.Expand value -> widget.Expand <- value
    | MessageDialogProperty.Opacity value -> widget.Opacity <- value
    | MessageDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | MessageDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | MessageDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | MessageDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | MessageDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | MessageDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | MessageDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | MessageDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | MessageDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | MessageDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | MessageDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | MessageDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | MessageDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | MessageDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | MessageDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | MessageDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | MessageDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | MessageDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | MessageDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | MessageDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | MessageDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | MessageDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | MessageDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | MessageDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | MessageDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | MessageDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | MessageDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | MessageDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | MessageDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | MessageDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | MessageDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | MessageDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | MessageDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | MessageDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | MessageDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | MessageDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | MessageDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | MessageDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | MessageDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | MessageDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | MessageDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | MessageDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | MessageDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | MessageDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | MessageDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | MessageDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | MessageDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | MessageDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | MessageDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | MessageDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | MessageDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | MessageDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | MessageDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | MessageDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | MessageDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | MessageDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | MessageDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | MessageDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | MessageDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | MessageDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | MessageDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | MessageDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | MessageDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type MessageDialogPropertyBuilder() =
    inherit BasePropertyBuilder<MessageDialogProperty>()
    [<CustomOperation("messageType")>]
    member this.MessageType(it: MessageDialogProperty seq, value: Gtk.MessageType) =
        seq { yield! it; yield MessageDialogProperty.MessageType value } 
    [<CustomOperation("text")>]
    member this.Text(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.Text value } 
    [<CustomOperation("useMarkup")>]
    member this.UseMarkup(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.UseMarkup value } 
    [<CustomOperation("secondaryText")>]
    member this.SecondaryText(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.SecondaryText value } 
    [<CustomOperation("secondaryUseMarkup")>]
    member this.SecondaryUseMarkup(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.SecondaryUseMarkup value } 
    [<Obsolete>]
    [<CustomOperation("image")>]
    member this.Image(it: MessageDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MessageDialogProperty.Image value } 
    [<CustomOperation("title")>]
    member this.Title(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: MessageDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield MessageDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: MessageDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield MessageDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: MessageDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield MessageDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: MessageDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield MessageDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: MessageDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield MessageDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: MessageDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield MessageDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: MessageDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MessageDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: MessageDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield MessageDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: MessageDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield MessageDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: MessageDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield MessageDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: MessageDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield MessageDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: MessageDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield MessageDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: MessageDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield MessageDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: MessageDialogProperty seq, value: System.String) =
        seq { yield! it; yield MessageDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: MessageDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield MessageDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: MessageDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MessageDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: MessageDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield MessageDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: MessageDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield MessageDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: MessageDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield MessageDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: MessageDialogProperty seq, value: System.Double) =
        seq { yield! it; yield MessageDialogProperty.Opacity value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: MessageDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: MessageDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: MessageDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: MessageDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: MessageDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: MessageDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: MessageDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: MessageDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: MessageDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: MessageDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: MessageDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: MessageDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: MessageDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: MessageDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: MessageDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: MessageDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: MessageDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: MessageDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: MessageDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: MessageDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: MessageDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: MessageDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: MessageDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: MessageDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: MessageDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: MessageDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: MessageDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: MessageDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: MessageDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: MessageDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: MessageDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: MessageDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: MessageDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: MessageDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: MessageDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: MessageDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: MessageDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: MessageDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: MessageDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: MessageDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: MessageDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: MessageDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: MessageDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: MessageDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: MessageDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: MessageDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: MessageDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: MessageDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: MessageDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: MessageDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: MessageDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: MessageDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: MessageDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: MessageDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: MessageDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: MessageDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: MessageDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: MessageDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: MessageDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: MessageDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: MessageDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: MessageDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: MessageDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield MessageDialogProperty.OnFocused value } 

let prop = MessageDialogPropertyBuilder()

