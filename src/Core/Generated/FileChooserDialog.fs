module GtkDsl.Binding.FileChooserDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FileChooserDialogProperty =
    | Action of Gtk.FileChooserAction
    | Filter of Gtk.FileFilter
    | LocalOnly of System.Boolean
    | PreviewWidget of Gtk.Widget
    | PreviewWidgetActive of System.Boolean
    | UsePreviewLabel of System.Boolean
    | ExtraWidget of Gtk.Widget
    | SelectMultiple of System.Boolean
    | ShowHidden of System.Boolean
    | DoOverwriteConfirmation of System.Boolean
    | CreateFolders of System.Boolean
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
    |  OnConfirmOverwrite of (Gtk.ConfirmOverwriteArgs -> unit)
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

let bindProperty (widget: FileChooserDialog) (prop: FileChooserDialogProperty) =
    match prop with
    | FileChooserDialogProperty.Action value -> widget.Action <- value
    | FileChooserDialogProperty.Filter value -> widget.Filter <- value
    | FileChooserDialogProperty.LocalOnly value -> widget.LocalOnly <- value
    | FileChooserDialogProperty.PreviewWidget value -> widget.PreviewWidget <- value
    | FileChooserDialogProperty.PreviewWidgetActive value -> widget.PreviewWidgetActive <- value
    | FileChooserDialogProperty.UsePreviewLabel value -> widget.UsePreviewLabel <- value
    | FileChooserDialogProperty.ExtraWidget value -> widget.ExtraWidget <- value
    | FileChooserDialogProperty.SelectMultiple value -> widget.SelectMultiple <- value
    | FileChooserDialogProperty.ShowHidden value -> widget.ShowHidden <- value
    | FileChooserDialogProperty.DoOverwriteConfirmation value -> widget.DoOverwriteConfirmation <- value
    | FileChooserDialogProperty.CreateFolders value -> widget.CreateFolders <- value
    | FileChooserDialogProperty.Title value -> widget.Title <- value
    | FileChooserDialogProperty.Role value -> widget.Role <- value
    | FileChooserDialogProperty.Resizable value -> widget.Resizable <- value
    | FileChooserDialogProperty.Modal value -> widget.Modal <- value
    | FileChooserDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | FileChooserDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | FileChooserDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | FileChooserDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | FileChooserDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | FileChooserDialogProperty.Icon value -> widget.Icon <- value
    | FileChooserDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | FileChooserDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | FileChooserDialogProperty.IconName value -> widget.IconName <- value
    | FileChooserDialogProperty.Screen value -> widget.Screen <- value
    | FileChooserDialogProperty.TypeHint value -> widget.TypeHint <- value
    | FileChooserDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | FileChooserDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | FileChooserDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | FileChooserDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | FileChooserDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | FileChooserDialogProperty.Decorated value -> widget.Decorated <- value
    | FileChooserDialogProperty.Deletable value -> widget.Deletable <- value
    | FileChooserDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | FileChooserDialogProperty.Gravity value -> widget.Gravity <- value
    | FileChooserDialogProperty.TransientFor value -> widget.TransientFor <- value
    | FileChooserDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | FileChooserDialogProperty.Application value -> widget.Application <- value
    | FileChooserDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | FileChooserDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | FileChooserDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | FileChooserDialogProperty.Name value -> widget.Name <- value
    | FileChooserDialogProperty.Parent value -> widget.Parent <- value
    | FileChooserDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | FileChooserDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | FileChooserDialogProperty.Visible value -> widget.Visible <- value
    | FileChooserDialogProperty.Sensitive value -> widget.Sensitive <- value
    | FileChooserDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | FileChooserDialogProperty.CanFocus value -> widget.CanFocus <- value
    | FileChooserDialogProperty.HasFocus value -> widget.HasFocus <- value
    | FileChooserDialogProperty.IsFocus value -> widget.IsFocus <- value
    | FileChooserDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FileChooserDialogProperty.CanDefault value -> widget.CanDefault <- value
    | FileChooserDialogProperty.HasDefault value -> widget.HasDefault <- value
    | FileChooserDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FileChooserDialogProperty.Style value -> widget.Style <- value
    | FileChooserDialogProperty.Events value -> widget.Events <- value
    | FileChooserDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | FileChooserDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | FileChooserDialogProperty.TooltipText value -> widget.TooltipText <- value
    | FileChooserDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FileChooserDialogProperty.Window value -> widget.Window <- value
    | FileChooserDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FileChooserDialogProperty.Halign value -> widget.Halign <- value
    | FileChooserDialogProperty.Valign value -> widget.Valign <- value
    | FileChooserDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | FileChooserDialogProperty.MarginRight value -> widget.MarginRight <- value
    | FileChooserDialogProperty.MarginStart value -> widget.MarginStart <- value
    | FileChooserDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | FileChooserDialogProperty.MarginTop value -> widget.MarginTop <- value
    | FileChooserDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | FileChooserDialogProperty.Margin value -> widget.Margin <- value
    | FileChooserDialogProperty.Hexpand value -> widget.Hexpand <- value
    | FileChooserDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | FileChooserDialogProperty.Vexpand value -> widget.Vexpand <- value
    | FileChooserDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | FileChooserDialogProperty.Expand value -> widget.Expand <- value
    | FileChooserDialogProperty.Opacity value -> widget.Opacity <- value
    | FileChooserDialogProperty.OnConfirmOverwrite handler -> 
        let disposable = widget.ConfirmOverwrite.Subscribe(handler)
        registerListener widget "ConfirmOverwrite" disposable
    | FileChooserDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | FileChooserDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | FileChooserDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | FileChooserDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FileChooserDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FileChooserDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FileChooserDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FileChooserDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FileChooserDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FileChooserDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FileChooserDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FileChooserDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FileChooserDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FileChooserDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FileChooserDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FileChooserDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FileChooserDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FileChooserDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FileChooserDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FileChooserDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FileChooserDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FileChooserDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FileChooserDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FileChooserDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FileChooserDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FileChooserDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FileChooserDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FileChooserDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FileChooserDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FileChooserDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FileChooserDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FileChooserDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FileChooserDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FileChooserDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FileChooserDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FileChooserDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FileChooserDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FileChooserDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FileChooserDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FileChooserDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FileChooserDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FileChooserDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FileChooserDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FileChooserDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FileChooserDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FileChooserDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FileChooserDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FileChooserDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FileChooserDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FileChooserDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FileChooserDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FileChooserDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FileChooserDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FileChooserDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FileChooserDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FileChooserDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FileChooserDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FileChooserDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FileChooserDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FileChooserDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FileChooserDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FileChooserDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FileChooserDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FileChooserDialogPropertyBuilder() =
    inherit BasePropertyBuilder<FileChooserDialogProperty>()
    [<CustomOperation("action")>]
    member this.Action(it: FileChooserDialogProperty seq, value: Gtk.FileChooserAction) =
        seq { yield! it; yield FileChooserDialogProperty.Action value } 
    [<CustomOperation("filter")>]
    member this.Filter(it: FileChooserDialogProperty seq, value: Gtk.FileFilter) =
        seq { yield! it; yield FileChooserDialogProperty.Filter value } 
    [<CustomOperation("localOnly")>]
    member this.LocalOnly(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.LocalOnly value } 
    [<CustomOperation("previewWidget")>]
    member this.PreviewWidget(it: FileChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserDialogProperty.PreviewWidget value } 
    [<CustomOperation("previewWidgetActive")>]
    member this.PreviewWidgetActive(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.PreviewWidgetActive value } 
    [<CustomOperation("usePreviewLabel")>]
    member this.UsePreviewLabel(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.UsePreviewLabel value } 
    [<CustomOperation("extraWidget")>]
    member this.ExtraWidget(it: FileChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserDialogProperty.ExtraWidget value } 
    [<CustomOperation("selectMultiple")>]
    member this.SelectMultiple(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.SelectMultiple value } 
    [<CustomOperation("showHidden")>]
    member this.ShowHidden(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.ShowHidden value } 
    [<CustomOperation("doOverwriteConfirmation")>]
    member this.DoOverwriteConfirmation(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.DoOverwriteConfirmation value } 
    [<CustomOperation("createFolders")>]
    member this.CreateFolders(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.CreateFolders value } 
    [<CustomOperation("title")>]
    member this.Title(it: FileChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: FileChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: FileChooserDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield FileChooserDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: FileChooserDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield FileChooserDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: FileChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: FileChooserDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield FileChooserDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: FileChooserDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield FileChooserDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: FileChooserDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield FileChooserDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: FileChooserDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield FileChooserDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: FileChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: FileChooserDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield FileChooserDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FileChooserDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FileChooserDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FileChooserDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield FileChooserDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FileChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FileChooserDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FileChooserDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FileChooserDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FileChooserDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FileChooserDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FileChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FileChooserDialogProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FileChooserDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FileChooserDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FileChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FileChooserDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FileChooserDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FileChooserDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FileChooserDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FileChooserDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FileChooserDialogProperty seq, value: System.Double) =
        seq { yield! it; yield FileChooserDialogProperty.Opacity value } 
    [<CustomOperation("onConfirmOverwrite")>]
    member this.OnConfirmOverwrite(it: FileChooserDialogProperty seq, value: Gtk.ConfirmOverwriteArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnConfirmOverwrite value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: FileChooserDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: FileChooserDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: FileChooserDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FileChooserDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FileChooserDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FileChooserDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FileChooserDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FileChooserDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FileChooserDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FileChooserDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FileChooserDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FileChooserDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FileChooserDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FileChooserDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FileChooserDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FileChooserDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FileChooserDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FileChooserDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FileChooserDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FileChooserDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FileChooserDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FileChooserDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FileChooserDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FileChooserDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FileChooserDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FileChooserDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FileChooserDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FileChooserDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FileChooserDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FileChooserDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FileChooserDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FileChooserDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FileChooserDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FileChooserDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FileChooserDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FileChooserDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FileChooserDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FileChooserDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FileChooserDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FileChooserDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FileChooserDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FileChooserDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FileChooserDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FileChooserDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FileChooserDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FileChooserDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FileChooserDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FileChooserDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FileChooserDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FileChooserDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FileChooserDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FileChooserDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FileChooserDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FileChooserDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FileChooserDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FileChooserDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FileChooserDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FileChooserDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FileChooserDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FileChooserDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FileChooserDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FileChooserDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FileChooserDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FileChooserDialogProperty.OnFocused value } 

let prop = FileChooserDialogPropertyBuilder()

