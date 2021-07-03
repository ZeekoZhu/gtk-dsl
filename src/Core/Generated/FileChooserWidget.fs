module Gtk.DSL.Binding.FileChooserWidget
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FileChooserWidgetProperty =
    | SearchMode of System.Boolean
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
    |  OnQuickBookmark of (Gtk.QuickBookmarkArgs -> unit)
    |  OnLocationPopup of (Gtk.LocationPopupArgs -> unit)
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

let bindProperty (widget: FileChooserWidget) (prop: FileChooserWidgetProperty) =
    match prop with
    | FileChooserWidgetProperty.SearchMode value -> widget.SearchMode <- value
    | FileChooserWidgetProperty.Action value -> widget.Action <- value
    | FileChooserWidgetProperty.Filter value -> widget.Filter <- value
    | FileChooserWidgetProperty.LocalOnly value -> widget.LocalOnly <- value
    | FileChooserWidgetProperty.PreviewWidget value -> widget.PreviewWidget <- value
    | FileChooserWidgetProperty.PreviewWidgetActive value -> widget.PreviewWidgetActive <- value
    | FileChooserWidgetProperty.UsePreviewLabel value -> widget.UsePreviewLabel <- value
    | FileChooserWidgetProperty.ExtraWidget value -> widget.ExtraWidget <- value
    | FileChooserWidgetProperty.SelectMultiple value -> widget.SelectMultiple <- value
    | FileChooserWidgetProperty.ShowHidden value -> widget.ShowHidden <- value
    | FileChooserWidgetProperty.DoOverwriteConfirmation value -> widget.DoOverwriteConfirmation <- value
    | FileChooserWidgetProperty.CreateFolders value -> widget.CreateFolders <- value
    | FileChooserWidgetProperty.Spacing value -> widget.Spacing <- value
    | FileChooserWidgetProperty.Homogeneous value -> widget.Homogeneous <- value
    | FileChooserWidgetProperty.BaselinePosition value -> widget.BaselinePosition <- value
    | FileChooserWidgetProperty.Expand value -> widget.Expand <- value
    | FileChooserWidgetProperty.Fill value -> widget.Fill <- value
    | FileChooserWidgetProperty.Padding value -> widget.Padding <- value
    | FileChooserWidgetProperty.PackType value -> widget.PackType <- value
    | FileChooserWidgetProperty.Position value -> widget.Position <- value
    | FileChooserWidgetProperty.Orientation value -> widget.Orientation <- value
    | FileChooserWidgetProperty.ResizeMode value -> widget.ResizeMode <- value
    | FileChooserWidgetProperty.BorderWidth value -> widget.BorderWidth <- value
    | FileChooserWidgetProperty.Name value -> widget.Name <- value
    | FileChooserWidgetProperty.Parent value -> widget.Parent <- value
    | FileChooserWidgetProperty.WidthRequest value -> widget.WidthRequest <- value
    | FileChooserWidgetProperty.HeightRequest value -> widget.HeightRequest <- value
    | FileChooserWidgetProperty.Visible value -> widget.Visible <- value
    | FileChooserWidgetProperty.Sensitive value -> widget.Sensitive <- value
    | FileChooserWidgetProperty.AppPaintable value -> widget.AppPaintable <- value
    | FileChooserWidgetProperty.CanFocus value -> widget.CanFocus <- value
    | FileChooserWidgetProperty.HasFocus value -> widget.HasFocus <- value
    | FileChooserWidgetProperty.IsFocus value -> widget.IsFocus <- value
    | FileChooserWidgetProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FileChooserWidgetProperty.CanDefault value -> widget.CanDefault <- value
    | FileChooserWidgetProperty.HasDefault value -> widget.HasDefault <- value
    | FileChooserWidgetProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FileChooserWidgetProperty.Style value -> widget.Style <- value
    | FileChooserWidgetProperty.Events value -> widget.Events <- value
    | FileChooserWidgetProperty.NoShowAll value -> widget.NoShowAll <- value
    | FileChooserWidgetProperty.HasTooltip value -> widget.HasTooltip <- value
    | FileChooserWidgetProperty.TooltipText value -> widget.TooltipText <- value
    | FileChooserWidgetProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FileChooserWidgetProperty.Window value -> widget.Window <- value
    | FileChooserWidgetProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FileChooserWidgetProperty.Halign value -> widget.Halign <- value
    | FileChooserWidgetProperty.Valign value -> widget.Valign <- value
    | FileChooserWidgetProperty.MarginLeft value -> widget.MarginLeft <- value
    | FileChooserWidgetProperty.MarginRight value -> widget.MarginRight <- value
    | FileChooserWidgetProperty.MarginStart value -> widget.MarginStart <- value
    | FileChooserWidgetProperty.MarginEnd value -> widget.MarginEnd <- value
    | FileChooserWidgetProperty.MarginTop value -> widget.MarginTop <- value
    | FileChooserWidgetProperty.MarginBottom value -> widget.MarginBottom <- value
    | FileChooserWidgetProperty.Margin value -> widget.Margin <- value
    | FileChooserWidgetProperty.Hexpand value -> widget.Hexpand <- value
    | FileChooserWidgetProperty.HexpandSet value -> widget.HexpandSet <- value
    | FileChooserWidgetProperty.Vexpand value -> widget.Vexpand <- value
    | FileChooserWidgetProperty.VexpandSet value -> widget.VexpandSet <- value
    | FileChooserWidgetProperty.Opacity value -> widget.Opacity <- value
    | FileChooserWidgetProperty.OnQuickBookmark handler -> 
        let disposable = widget.QuickBookmark.Subscribe(handler)
        registerListener widget "QuickBookmark" disposable
    | FileChooserWidgetProperty.OnLocationPopup handler -> 
        let disposable = widget.LocationPopup.Subscribe(handler)
        registerListener widget "LocationPopup" disposable
    | FileChooserWidgetProperty.OnConfirmOverwrite handler -> 
        let disposable = widget.ConfirmOverwrite.Subscribe(handler)
        registerListener widget "ConfirmOverwrite" disposable
    | FileChooserWidgetProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FileChooserWidgetProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FileChooserWidgetProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FileChooserWidgetProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FileChooserWidgetProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FileChooserWidgetProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FileChooserWidgetProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FileChooserWidgetProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FileChooserWidgetProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FileChooserWidgetProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FileChooserWidgetProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FileChooserWidgetProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FileChooserWidgetProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FileChooserWidgetProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FileChooserWidgetProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FileChooserWidgetProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FileChooserWidgetProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FileChooserWidgetProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FileChooserWidgetProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FileChooserWidgetProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FileChooserWidgetProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FileChooserWidgetProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FileChooserWidgetProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FileChooserWidgetProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FileChooserWidgetProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FileChooserWidgetProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FileChooserWidgetProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FileChooserWidgetProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FileChooserWidgetProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FileChooserWidgetProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FileChooserWidgetProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FileChooserWidgetProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FileChooserWidgetProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FileChooserWidgetProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FileChooserWidgetProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FileChooserWidgetProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FileChooserWidgetProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FileChooserWidgetProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FileChooserWidgetProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FileChooserWidgetProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FileChooserWidgetProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FileChooserWidgetProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FileChooserWidgetProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FileChooserWidgetProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FileChooserWidgetProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FileChooserWidgetProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FileChooserWidgetProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FileChooserWidgetProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FileChooserWidgetProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FileChooserWidgetProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FileChooserWidgetProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FileChooserWidgetProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FileChooserWidgetProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FileChooserWidgetProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FileChooserWidgetProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FileChooserWidgetProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FileChooserWidgetProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FileChooserWidgetProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FileChooserWidgetProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FileChooserWidgetProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FileChooserWidgetPropertyBuilder() =
    inherit BasePropertyBuilder<FileChooserWidgetProperty>()
    [<CustomOperation("searchMode")>]
    member this.SearchMode(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.SearchMode value } 
    [<CustomOperation("action")>]
    member this.Action(it: FileChooserWidgetProperty seq, value: Gtk.FileChooserAction) =
        seq { yield! it; yield FileChooserWidgetProperty.Action value } 
    [<CustomOperation("filter")>]
    member this.Filter(it: FileChooserWidgetProperty seq, value: Gtk.FileFilter) =
        seq { yield! it; yield FileChooserWidgetProperty.Filter value } 
    [<CustomOperation("localOnly")>]
    member this.LocalOnly(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.LocalOnly value } 
    [<CustomOperation("previewWidget")>]
    member this.PreviewWidget(it: FileChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserWidgetProperty.PreviewWidget value } 
    [<CustomOperation("previewWidgetActive")>]
    member this.PreviewWidgetActive(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.PreviewWidgetActive value } 
    [<CustomOperation("usePreviewLabel")>]
    member this.UsePreviewLabel(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.UsePreviewLabel value } 
    [<CustomOperation("extraWidget")>]
    member this.ExtraWidget(it: FileChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserWidgetProperty.ExtraWidget value } 
    [<CustomOperation("selectMultiple")>]
    member this.SelectMultiple(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.SelectMultiple value } 
    [<CustomOperation("showHidden")>]
    member this.ShowHidden(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.ShowHidden value } 
    [<CustomOperation("doOverwriteConfirmation")>]
    member this.DoOverwriteConfirmation(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.DoOverwriteConfirmation value } 
    [<CustomOperation("createFolders")>]
    member this.CreateFolders(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.CreateFolders value } 
    [<CustomOperation("spacing")>]
    member this.Spacing(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.Spacing value } 
    [<CustomOperation("homogeneous")>]
    member this.Homogeneous(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Homogeneous value } 
    [<CustomOperation("baselinePosition")>]
    member this.BaselinePosition(it: FileChooserWidgetProperty seq, value: Gtk.BaselinePosition) =
        seq { yield! it; yield FileChooserWidgetProperty.BaselinePosition value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Expand value } 
    [<CustomOperation("fill")>]
    member this.Fill(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Fill value } 
    [<CustomOperation("padding")>]
    member this.Padding(it: FileChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield FileChooserWidgetProperty.Padding value } 
    [<CustomOperation("packType")>]
    member this.PackType(it: FileChooserWidgetProperty seq, value: Gtk.PackType) =
        seq { yield! it; yield FileChooserWidgetProperty.PackType value } 
    [<CustomOperation("position")>]
    member this.Position(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.Position value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: FileChooserWidgetProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield FileChooserWidgetProperty.Orientation value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FileChooserWidgetProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FileChooserWidgetProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FileChooserWidgetProperty seq, value: System.UInt32) =
        seq { yield! it; yield FileChooserWidgetProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FileChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserWidgetProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FileChooserWidgetProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FileChooserWidgetProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FileChooserWidgetProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FileChooserWidgetProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FileChooserWidgetProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FileChooserWidgetProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FileChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserWidgetProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FileChooserWidgetProperty seq, value: System.String) =
        seq { yield! it; yield FileChooserWidgetProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FileChooserWidgetProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FileChooserWidgetProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FileChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FileChooserWidgetProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FileChooserWidgetProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FileChooserWidgetProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FileChooserWidgetProperty seq, value: System.Int32) =
        seq { yield! it; yield FileChooserWidgetProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FileChooserWidgetProperty seq, value: System.Boolean) =
        seq { yield! it; yield FileChooserWidgetProperty.VexpandSet value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FileChooserWidgetProperty seq, value: System.Double) =
        seq { yield! it; yield FileChooserWidgetProperty.Opacity value } 
    [<CustomOperation("onQuickBookmark")>]
    member this.OnQuickBookmark(it: FileChooserWidgetProperty seq, value: Gtk.QuickBookmarkArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnQuickBookmark value } 
    [<CustomOperation("onLocationPopup")>]
    member this.OnLocationPopup(it: FileChooserWidgetProperty seq, value: Gtk.LocationPopupArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnLocationPopup value } 
    [<CustomOperation("onConfirmOverwrite")>]
    member this.OnConfirmOverwrite(it: FileChooserWidgetProperty seq, value: Gtk.ConfirmOverwriteArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnConfirmOverwrite value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FileChooserWidgetProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FileChooserWidgetProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FileChooserWidgetProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FileChooserWidgetProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FileChooserWidgetProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FileChooserWidgetProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FileChooserWidgetProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FileChooserWidgetProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FileChooserWidgetProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FileChooserWidgetProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FileChooserWidgetProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FileChooserWidgetProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FileChooserWidgetProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FileChooserWidgetProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FileChooserWidgetProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FileChooserWidgetProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FileChooserWidgetProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FileChooserWidgetProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FileChooserWidgetProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FileChooserWidgetProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FileChooserWidgetProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FileChooserWidgetProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FileChooserWidgetProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FileChooserWidgetProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FileChooserWidgetProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FileChooserWidgetProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FileChooserWidgetProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FileChooserWidgetProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FileChooserWidgetProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FileChooserWidgetProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FileChooserWidgetProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FileChooserWidgetProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FileChooserWidgetProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FileChooserWidgetProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FileChooserWidgetProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FileChooserWidgetProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FileChooserWidgetProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FileChooserWidgetProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FileChooserWidgetProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FileChooserWidgetProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FileChooserWidgetProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FileChooserWidgetProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FileChooserWidgetProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FileChooserWidgetProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FileChooserWidgetProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FileChooserWidgetProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FileChooserWidgetProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FileChooserWidgetProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FileChooserWidgetProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FileChooserWidgetProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FileChooserWidgetProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FileChooserWidgetProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FileChooserWidgetProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FileChooserWidgetProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FileChooserWidgetProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FileChooserWidgetProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FileChooserWidgetProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FileChooserWidgetProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FileChooserWidgetProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FileChooserWidgetProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FileChooserWidgetProperty.OnFocused value } 

let prop = FileChooserWidgetPropertyBuilder()

