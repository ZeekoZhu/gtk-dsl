module GtkDsl.Binding.FileChooserButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FileChooserButtonProperty =
    | Title of System.String
    | WidthChars of System.Int32
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
    | Spacing of System.Int32
    | Homogeneous of System.Boolean
    | BaselinePosition of Gtk.BaselinePosition
    | Expand of System.Boolean
    | Fill of System.Boolean
    | Padding of System.UInt32
    | PackType of Gtk.PackType
    | Position of System.Int32
    | Orientation of Gtk.Orientation
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
    | Opacity of System.Double
    |  OnConfirmOverwrite of (Gtk.ConfirmOverwriteArgs -> unit)
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

let bindProperty (widget: FileChooserButton) (prop: FileChooserButtonProperty) =
    match prop with
    | FileChooserButtonProperty.Title value -> widget.Title <- value
    | FileChooserButtonProperty.WidthChars value -> widget.WidthChars <- value
    | FileChooserButtonProperty.Action value -> widget.Action <- value
    | FileChooserButtonProperty.Filter value -> widget.Filter <- value
    | FileChooserButtonProperty.LocalOnly value -> widget.LocalOnly <- value
    | FileChooserButtonProperty.PreviewWidget value -> widget.PreviewWidget <- value
    | FileChooserButtonProperty.PreviewWidgetActive value -> widget.PreviewWidgetActive <- value
    | FileChooserButtonProperty.UsePreviewLabel value -> widget.UsePreviewLabel <- value
    | FileChooserButtonProperty.ExtraWidget value -> widget.ExtraWidget <- value
    | FileChooserButtonProperty.SelectMultiple value -> widget.SelectMultiple <- value
    | FileChooserButtonProperty.ShowHidden value -> widget.ShowHidden <- value
    | FileChooserButtonProperty.DoOverwriteConfirmation value -> widget.DoOverwriteConfirmation <- value
    | FileChooserButtonProperty.CreateFolders value -> widget.CreateFolders <- value
    | FileChooserButtonProperty.Spacing value -> widget.Spacing <- value
    | FileChooserButtonProperty.Homogeneous value -> widget.Homogeneous <- value
    | FileChooserButtonProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | FileChooserButtonProperty.Expand value -> widget.Expand <- value
    | FileChooserButtonProperty.Fill value -> widget.Fill <- value
    | FileChooserButtonProperty.Padding value -> widget.Padding <- value
    | FileChooserButtonProperty.PackType value -> widget.PackType <- value
    | FileChooserButtonProperty.Position value -> widget.Position <- value
    | FileChooserButtonProperty.Orientation value -> widget.Orientation <- value
    | FileChooserButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | FileChooserButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | FileChooserButtonProperty.Name value -> widget.Name <- value
    | FileChooserButtonProperty.Parent value -> widget.Parent <- value
    | FileChooserButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | FileChooserButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | FileChooserButtonProperty.Visible value -> widget.Visible <- value
    | FileChooserButtonProperty.Sensitive value -> widget.Sensitive <- value
    | FileChooserButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | FileChooserButtonProperty.CanFocus value -> widget.CanFocus <- value
    | FileChooserButtonProperty.HasFocus value -> widget.HasFocus <- value
    | FileChooserButtonProperty.IsFocus value -> widget.IsFocus <- value
    | FileChooserButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FileChooserButtonProperty.CanDefault value -> widget.CanDefault <- value
    | FileChooserButtonProperty.HasDefault value -> widget.HasDefault <- value
    | FileChooserButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FileChooserButtonProperty.Style value -> widget.Style <- value
    | FileChooserButtonProperty.Events value -> widget.Events <- value
    | FileChooserButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | FileChooserButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | FileChooserButtonProperty.TooltipText value -> widget.TooltipText <- value
    | FileChooserButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FileChooserButtonProperty.Window value -> widget.Window <- value
    | FileChooserButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FileChooserButtonProperty.Halign value -> widget.Halign <- value
    | FileChooserButtonProperty.Valign value -> widget.Valign <- value
    | FileChooserButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | FileChooserButtonProperty.MarginRight value -> widget.MarginRight <- value
    | FileChooserButtonProperty.MarginStart value -> widget.MarginStart <- value
    | FileChooserButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | FileChooserButtonProperty.MarginTop value -> widget.MarginTop <- value
    | FileChooserButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | FileChooserButtonProperty.Margin value -> widget.Margin <- value
    | FileChooserButtonProperty.Hexpand value -> widget.Hexpand <- value
    | FileChooserButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | FileChooserButtonProperty.Vexpand value -> widget.Vexpand <- value
    | FileChooserButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | FileChooserButtonProperty.Opacity value -> widget.Opacity <- value
    | FileChooserButtonProperty.OnConfirmOverwrite handler -> 
        let disposable = widget.ConfirmOverwrite.Subscribe(handler)
        registerListener widget "ConfirmOverwrite" disposable
    | FileChooserButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FileChooserButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FileChooserButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FileChooserButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FileChooserButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FileChooserButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FileChooserButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FileChooserButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FileChooserButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FileChooserButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FileChooserButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FileChooserButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FileChooserButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FileChooserButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FileChooserButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FileChooserButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FileChooserButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FileChooserButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FileChooserButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FileChooserButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FileChooserButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FileChooserButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FileChooserButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FileChooserButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FileChooserButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FileChooserButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FileChooserButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FileChooserButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FileChooserButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FileChooserButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FileChooserButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FileChooserButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FileChooserButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FileChooserButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FileChooserButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FileChooserButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FileChooserButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FileChooserButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FileChooserButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FileChooserButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FileChooserButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FileChooserButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FileChooserButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FileChooserButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FileChooserButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FileChooserButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FileChooserButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FileChooserButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FileChooserButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FileChooserButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FileChooserButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FileChooserButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FileChooserButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FileChooserButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FileChooserButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FileChooserButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FileChooserButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FileChooserButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FileChooserButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FileChooserButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FileChooserButtonPropertyBuilder() =
    inherit BasePropertyBuilder<FileChooserButtonProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: FileChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserButtonProperty.Title value } 
    [<CustomOperation("widthChars")>]
    member this.WidthChars(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.WidthChars value } 
    [<CustomOperation("action")>]
    member this.Action(it: FileChooserButtonProperty seq, value: Gtk.FileChooserAction) =
        seq { yield! it; yield FileChooserButtonProperty.Action value } 
    [<CustomOperation("filter")>]
    member this.Filter(it: FileChooserButtonProperty seq, value: Gtk.FileFilter) =
        seq { yield! it; yield FileChooserButtonProperty.Filter value } 
    [<CustomOperation("localOnly")>]
    member this.LocalOnly(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.LocalOnly value } 
    [<CustomOperation("previewWidget")>]
    member this.PreviewWidget(it: FileChooserButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserButtonProperty.PreviewWidget value } 
    [<CustomOperation("previewWidgetActive")>]
    member this.PreviewWidgetActive(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.PreviewWidgetActive value } 
    [<CustomOperation("usePreviewLabel")>]
    member this.UsePreviewLabel(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.UsePreviewLabel value } 
    [<CustomOperation("extraWidget")>]
    member this.ExtraWidget(it: FileChooserButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserButtonProperty.ExtraWidget value } 
    [<CustomOperation("selectMultiple")>]
    member this.SelectMultiple(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.SelectMultiple value } 
    [<CustomOperation("showHidden")>]
    member this.ShowHidden(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.ShowHidden value } 
    [<CustomOperation("doOverwriteConfirmation")>]
    member this.DoOverwriteConfirmation(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.DoOverwriteConfirmation value } 
    [<CustomOperation("createFolders")>]
    member this.CreateFolders(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.CreateFolders value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: FileChooserButtonProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield FileChooserButtonProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: FileChooserButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield FileChooserButtonProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: FileChooserButtonProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield FileChooserButtonProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: FileChooserButtonProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield FileChooserButtonProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FileChooserButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FileChooserButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FileChooserButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield FileChooserButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FileChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FileChooserButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FileChooserButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FileChooserButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FileChooserButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FileChooserButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FileChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FileChooserButtonProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FileChooserButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FileChooserButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FileChooserButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FileChooserButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FileChooserButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FileChooserButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FileChooserButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FileChooserButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserButtonProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FileChooserButtonProperty seq, value: System.Double) =
        seq { yield! it; yield FileChooserButtonProperty.Opacity value } 
    [<CustomOperation("onConfirmOverwrite")>]
    member this.OnConfirmOverwrite(it: FileChooserButtonProperty seq, value: Gtk.ConfirmOverwriteArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnConfirmOverwrite value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FileChooserButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FileChooserButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FileChooserButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FileChooserButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FileChooserButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FileChooserButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FileChooserButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FileChooserButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FileChooserButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FileChooserButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FileChooserButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FileChooserButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FileChooserButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FileChooserButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FileChooserButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FileChooserButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FileChooserButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FileChooserButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FileChooserButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FileChooserButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FileChooserButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FileChooserButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FileChooserButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FileChooserButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FileChooserButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FileChooserButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FileChooserButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FileChooserButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FileChooserButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FileChooserButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FileChooserButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FileChooserButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FileChooserButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FileChooserButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FileChooserButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FileChooserButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FileChooserButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FileChooserButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FileChooserButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FileChooserButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FileChooserButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FileChooserButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FileChooserButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FileChooserButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FileChooserButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FileChooserButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FileChooserButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FileChooserButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FileChooserButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FileChooserButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FileChooserButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FileChooserButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FileChooserButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FileChooserButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FileChooserButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FileChooserButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FileChooserButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FileChooserButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FileChooserButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FileChooserButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FileChooserButtonProperty.OnFocused value } 

let prop = FileChooserButtonPropertyBuilder()

