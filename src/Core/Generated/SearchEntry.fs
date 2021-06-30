module GtkDsl.Binding.SearchEntry
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SearchEntryProperty =
    | Buffer of Gtk.EntryBuffer
    | MaxLength of System.Int32
    | Visibility of System.Boolean
    | HasFrame of System.Boolean
    | ActivatesDefault of System.Boolean
    | WidthChars of System.Int32
    | MaxWidthChars of System.Int32
    | Text of System.String
    | Xalign of System.Single
    | TruncateMultiline of System.Boolean
    | ShadowType of Gtk.ShadowType
    | OverwriteMode of System.Boolean
    | InvisibleCharSet of System.Boolean
    | CapsLockWarning of System.Boolean
    | ProgressFraction of System.Double
    | ProgressPulseStep of System.Double
    | PlaceholderText of System.String
    | PrimaryIconPixbuf of Gdk.Pixbuf
    | SecondaryIconPixbuf of Gdk.Pixbuf
    | PrimaryIconStock of System.String
    | SecondaryIconStock of System.String
    | PrimaryIconName of System.String
    | SecondaryIconName of System.String
    | PrimaryIconGicon of GLib.IIcon
    | SecondaryIconGicon of GLib.IIcon
    | PrimaryIconActivatable of System.Boolean
    | SecondaryIconActivatable of System.Boolean
    | PrimaryIconSensitive of System.Boolean
    | SecondaryIconSensitive of System.Boolean
    | PrimaryIconTooltipText of System.String
    | SecondaryIconTooltipText of System.String
    | PrimaryIconTooltipMarkup of System.String
    | SecondaryIconTooltipMarkup of System.String
    | ImModule of System.String
    | Completion of Gtk.EntryCompletion
    | InputPurpose of Gtk.InputPurpose
    | InputHints of Gtk.InputHints
    | Attributes of Pango.AttrList
    | PopulateAll of System.Boolean
    | Tabs of Pango.TabArray
    | InvisibleChar of System.Char
    | [<Obsolete>] InnerBorder of Gtk.Border
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
    |  OnIconPress of (Gtk.IconPressArgs -> unit)
    |  OnIconRelease of (Gtk.IconReleaseArgs -> unit)
    |  OnDeleteFromCursor of (Gtk.DeleteFromCursorArgs -> unit)
    |  OnMoveCursor of (Gtk.MoveCursorArgs -> unit)
    |  OnPreeditChanged of (Gtk.PreeditChangedArgs -> unit)
    |  OnInsertAtCursor of (Gtk.InsertAtCursorArgs -> unit)
    |  OnPopulatePopup of (Gtk.PopulatePopupArgs -> unit)
    |  OnTextInserted of (Gtk.TextInsertedArgs -> unit)
    |  OnTextDeleted of (Gtk.TextDeletedArgs -> unit)
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

let bindProperty (widget: SearchEntry) (prop: SearchEntryProperty) =
    match prop with
    | SearchEntryProperty.Buffer value -> widget.Buffer <- value
    | SearchEntryProperty.MaxLength value -> widget.MaxLength <- value
    | SearchEntryProperty.Visibility value -> widget.Visibility <- value
    | SearchEntryProperty.HasFrame value -> widget.HasFrame <- value
    | SearchEntryProperty.ActivatesDefault value -> widget.ActivatesDefault <- value
    | SearchEntryProperty.WidthChars value -> widget.WidthChars <- value
    | SearchEntryProperty.MaxWidthChars value -> widget.MaxWidthChars <- value
    | SearchEntryProperty.Text value -> widget.Text <- value
    | SearchEntryProperty.Xalign value -> widget.Xalign <- value
    | SearchEntryProperty.TruncateMultiline value -> widget.TruncateMultiline <- value
    | SearchEntryProperty.ShadowType value -> widget.ShadowType <- value
    | SearchEntryProperty.OverwriteMode value -> widget.OverwriteMode <- value
    | SearchEntryProperty.InvisibleCharSet value -> widget.InvisibleCharSet <- value
    | SearchEntryProperty.CapsLockWarning value -> widget.CapsLockWarning <- value
    | SearchEntryProperty.ProgressFraction value -> widget.ProgressFraction <- value
    | SearchEntryProperty.ProgressPulseStep value -> widget.ProgressPulseStep <- value
    | SearchEntryProperty.PlaceholderText value -> widget.PlaceholderText <- value
    | SearchEntryProperty.PrimaryIconPixbuf value -> widget.PrimaryIconPixbuf <- value
    | SearchEntryProperty.SecondaryIconPixbuf value -> widget.SecondaryIconPixbuf <- value
    | SearchEntryProperty.PrimaryIconStock value -> widget.PrimaryIconStock <- value
    | SearchEntryProperty.SecondaryIconStock value -> widget.SecondaryIconStock <- value
    | SearchEntryProperty.PrimaryIconName value -> widget.PrimaryIconName <- value
    | SearchEntryProperty.SecondaryIconName value -> widget.SecondaryIconName <- value
    | SearchEntryProperty.PrimaryIconGicon value -> widget.PrimaryIconGicon <- value
    | SearchEntryProperty.SecondaryIconGicon value -> widget.SecondaryIconGicon <- value
    | SearchEntryProperty.PrimaryIconActivatable value -> widget.PrimaryIconActivatable <- value
    | SearchEntryProperty.SecondaryIconActivatable value -> widget.SecondaryIconActivatable <- value
    | SearchEntryProperty.PrimaryIconSensitive value -> widget.PrimaryIconSensitive <- value
    | SearchEntryProperty.SecondaryIconSensitive value -> widget.SecondaryIconSensitive <- value
    | SearchEntryProperty.PrimaryIconTooltipText value -> widget.PrimaryIconTooltipText <- value
    | SearchEntryProperty.SecondaryIconTooltipText value -> widget.SecondaryIconTooltipText <- value
    | SearchEntryProperty.PrimaryIconTooltipMarkup value -> widget.PrimaryIconTooltipMarkup <- value
    | SearchEntryProperty.SecondaryIconTooltipMarkup value -> widget.SecondaryIconTooltipMarkup <- value
    | SearchEntryProperty.ImModule value -> widget.ImModule <- value
    | SearchEntryProperty.Completion value -> widget.Completion <- value
    | SearchEntryProperty.InputPurpose value -> widget.InputPurpose <- value
    | SearchEntryProperty.InputHints value -> widget.InputHints <- value
    | SearchEntryProperty.Attributes value -> widget.Attributes <- value
    | SearchEntryProperty.PopulateAll value -> widget.PopulateAll <- value
    | SearchEntryProperty.Tabs value -> widget.Tabs <- value
    | SearchEntryProperty.InvisibleChar value -> widget.InvisibleChar <- value
    | SearchEntryProperty.InnerBorder value -> widget.InnerBorder <- value
    | SearchEntryProperty.Name value -> widget.Name <- value
    | SearchEntryProperty.Parent value -> widget.Parent <- value
    | SearchEntryProperty.WidthRequest value -> widget.WidthRequest <- value
    | SearchEntryProperty.HeightRequest value -> widget.HeightRequest <- value
    | SearchEntryProperty.Visible value -> widget.Visible <- value
    | SearchEntryProperty.Sensitive value -> widget.Sensitive <- value
    | SearchEntryProperty.AppPaintable value -> widget.AppPaintable <- value
    | SearchEntryProperty.CanFocus value -> widget.CanFocus <- value
    | SearchEntryProperty.HasFocus value -> widget.HasFocus <- value
    | SearchEntryProperty.IsFocus value -> widget.IsFocus <- value
    | SearchEntryProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SearchEntryProperty.CanDefault value -> widget.CanDefault <- value
    | SearchEntryProperty.HasDefault value -> widget.HasDefault <- value
    | SearchEntryProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SearchEntryProperty.Style value -> widget.Style <- value
    | SearchEntryProperty.Events value -> widget.Events <- value
    | SearchEntryProperty.NoShowAll value -> widget.NoShowAll <- value
    | SearchEntryProperty.HasTooltip value -> widget.HasTooltip <- value
    | SearchEntryProperty.TooltipText value -> widget.TooltipText <- value
    | SearchEntryProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SearchEntryProperty.Window value -> widget.Window <- value
    | SearchEntryProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SearchEntryProperty.Halign value -> widget.Halign <- value
    | SearchEntryProperty.Valign value -> widget.Valign <- value
    | SearchEntryProperty.MarginLeft value -> widget.MarginLeft <- value
    | SearchEntryProperty.MarginRight value -> widget.MarginRight <- value
    | SearchEntryProperty.MarginStart value -> widget.MarginStart <- value
    | SearchEntryProperty.MarginEnd value -> widget.MarginEnd <- value
    | SearchEntryProperty.MarginTop value -> widget.MarginTop <- value
    | SearchEntryProperty.MarginBottom value -> widget.MarginBottom <- value
    | SearchEntryProperty.Margin value -> widget.Margin <- value
    | SearchEntryProperty.Hexpand value -> widget.Hexpand <- value
    | SearchEntryProperty.HexpandSet value -> widget.HexpandSet <- value
    | SearchEntryProperty.Vexpand value -> widget.Vexpand <- value
    | SearchEntryProperty.VexpandSet value -> widget.VexpandSet <- value
    | SearchEntryProperty.Expand value -> widget.Expand <- value
    | SearchEntryProperty.Opacity value -> widget.Opacity <- value
    | SearchEntryProperty.OnIconPress handler -> 
        let disposable = widget.IconPress.Subscribe(handler)
        registerListener widget "IconPress" disposable
    | SearchEntryProperty.OnIconRelease handler -> 
        let disposable = widget.IconRelease.Subscribe(handler)
        registerListener widget "IconRelease" disposable
    | SearchEntryProperty.OnDeleteFromCursor handler -> 
        let disposable = widget.DeleteFromCursor.Subscribe(handler)
        registerListener widget "DeleteFromCursor" disposable
    | SearchEntryProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | SearchEntryProperty.OnPreeditChanged handler -> 
        let disposable = widget.PreeditChanged.Subscribe(handler)
        registerListener widget "PreeditChanged" disposable
    | SearchEntryProperty.OnInsertAtCursor handler -> 
        let disposable = widget.InsertAtCursor.Subscribe(handler)
        registerListener widget "InsertAtCursor" disposable
    | SearchEntryProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | SearchEntryProperty.OnTextInserted handler -> 
        let disposable = widget.TextInserted.Subscribe(handler)
        registerListener widget "TextInserted" disposable
    | SearchEntryProperty.OnTextDeleted handler -> 
        let disposable = widget.TextDeleted.Subscribe(handler)
        registerListener widget "TextDeleted" disposable
    | SearchEntryProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SearchEntryProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SearchEntryProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SearchEntryProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SearchEntryProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SearchEntryProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SearchEntryProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SearchEntryProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SearchEntryProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SearchEntryProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SearchEntryProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SearchEntryProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SearchEntryProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SearchEntryProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SearchEntryProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SearchEntryProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SearchEntryProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SearchEntryProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SearchEntryProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SearchEntryProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SearchEntryProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SearchEntryProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SearchEntryProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SearchEntryProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SearchEntryProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SearchEntryProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SearchEntryProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SearchEntryProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SearchEntryProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SearchEntryProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SearchEntryProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SearchEntryProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SearchEntryProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SearchEntryProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SearchEntryProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SearchEntryProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SearchEntryProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SearchEntryProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SearchEntryProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SearchEntryProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SearchEntryProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SearchEntryProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SearchEntryProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SearchEntryProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SearchEntryProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SearchEntryProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SearchEntryProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SearchEntryProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SearchEntryProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SearchEntryProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SearchEntryProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SearchEntryProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SearchEntryProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SearchEntryProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SearchEntryProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SearchEntryProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SearchEntryProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SearchEntryPropertyBuilder() =
    inherit BasePropertyBuilder<SearchEntryProperty>()
    [<CustomOperation("buffer")>]
    member this.Buffer(it: SearchEntryProperty seq, value: Gtk.EntryBuffer) =
        seq { yield! it; yield SearchEntryProperty.Buffer value } 
    [<CustomOperation("maxLength")>]
    member this.MaxLength(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MaxLength value } 
    [<CustomOperation("visibility")>]
    member this.Visibility(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.Visibility value } 
    [<CustomOperation("hasFrame")>]
    member this.HasFrame(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.HasFrame value } 
    [<CustomOperation("activatesDefault")>]
    member this.ActivatesDefault(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.ActivatesDefault value } 
    [<CustomOperation("widthChars")>]
    member this.WidthChars(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.WidthChars value } 
    [<CustomOperation("maxWidthChars")>]
    member this.MaxWidthChars(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MaxWidthChars value } 
    [<CustomOperation("text")>]
    member this.Text(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.Text value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: SearchEntryProperty seq, value: System.Single) =
        seq { yield! it; yield SearchEntryProperty.Xalign value } 
    [<CustomOperation("truncateMultiline")>]
    member this.TruncateMultiline(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.TruncateMultiline value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: SearchEntryProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield SearchEntryProperty.ShadowType value } 
    [<CustomOperation("overwriteMode")>]
    member this.OverwriteMode(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.OverwriteMode value } 
    [<CustomOperation("invisibleCharSet")>]
    member this.InvisibleCharSet(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.InvisibleCharSet value } 
    [<CustomOperation("capsLockWarning")>]
    member this.CapsLockWarning(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.CapsLockWarning value } 
    [<CustomOperation("progressFraction")>]
    member this.ProgressFraction(it: SearchEntryProperty seq, value: System.Double) =
        seq { yield! it; yield SearchEntryProperty.ProgressFraction value } 
    [<CustomOperation("progressPulseStep")>]
    member this.ProgressPulseStep(it: SearchEntryProperty seq, value: System.Double) =
        seq { yield! it; yield SearchEntryProperty.ProgressPulseStep value } 
    [<CustomOperation("placeholderText")>]
    member this.PlaceholderText(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.PlaceholderText value } 
    [<CustomOperation("primaryIconPixbuf")>]
    member this.PrimaryIconPixbuf(it: SearchEntryProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconPixbuf value } 
    [<CustomOperation("secondaryIconPixbuf")>]
    member this.SecondaryIconPixbuf(it: SearchEntryProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconPixbuf value } 
    [<CustomOperation("primaryIconStock")>]
    member this.PrimaryIconStock(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconStock value } 
    [<CustomOperation("secondaryIconStock")>]
    member this.SecondaryIconStock(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconStock value } 
    [<CustomOperation("primaryIconName")>]
    member this.PrimaryIconName(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconName value } 
    [<CustomOperation("secondaryIconName")>]
    member this.SecondaryIconName(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconName value } 
    [<CustomOperation("primaryIconGicon")>]
    member this.PrimaryIconGicon(it: SearchEntryProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconGicon value } 
    [<CustomOperation("secondaryIconGicon")>]
    member this.SecondaryIconGicon(it: SearchEntryProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconGicon value } 
    [<CustomOperation("primaryIconActivatable")>]
    member this.PrimaryIconActivatable(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconActivatable value } 
    [<CustomOperation("secondaryIconActivatable")>]
    member this.SecondaryIconActivatable(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconActivatable value } 
    [<CustomOperation("primaryIconSensitive")>]
    member this.PrimaryIconSensitive(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconSensitive value } 
    [<CustomOperation("secondaryIconSensitive")>]
    member this.SecondaryIconSensitive(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconSensitive value } 
    [<CustomOperation("primaryIconTooltipText")>]
    member this.PrimaryIconTooltipText(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconTooltipText value } 
    [<CustomOperation("secondaryIconTooltipText")>]
    member this.SecondaryIconTooltipText(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconTooltipText value } 
    [<CustomOperation("primaryIconTooltipMarkup")>]
    member this.PrimaryIconTooltipMarkup(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.PrimaryIconTooltipMarkup value } 
    [<CustomOperation("secondaryIconTooltipMarkup")>]
    member this.SecondaryIconTooltipMarkup(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.SecondaryIconTooltipMarkup value } 
    [<CustomOperation("imModule")>]
    member this.ImModule(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.ImModule value } 
    [<CustomOperation("completion")>]
    member this.Completion(it: SearchEntryProperty seq, value: Gtk.EntryCompletion) =
        seq { yield! it; yield SearchEntryProperty.Completion value } 
    [<CustomOperation("inputPurpose")>]
    member this.InputPurpose(it: SearchEntryProperty seq, value: Gtk.InputPurpose) =
        seq { yield! it; yield SearchEntryProperty.InputPurpose value } 
    [<CustomOperation("inputHints")>]
    member this.InputHints(it: SearchEntryProperty seq, value: Gtk.InputHints) =
        seq { yield! it; yield SearchEntryProperty.InputHints value } 
    [<CustomOperation("attributes")>]
    member this.Attributes(it: SearchEntryProperty seq, value: Pango.AttrList) =
        seq { yield! it; yield SearchEntryProperty.Attributes value } 
    [<CustomOperation("populateAll")>]
    member this.PopulateAll(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.PopulateAll value } 
    [<CustomOperation("tabs")>]
    member this.Tabs(it: SearchEntryProperty seq, value: Pango.TabArray) =
        seq { yield! it; yield SearchEntryProperty.Tabs value } 
    [<CustomOperation("invisibleChar")>]
    member this.InvisibleChar(it: SearchEntryProperty seq, value: System.Char) =
        seq { yield! it; yield SearchEntryProperty.InvisibleChar value } 
    [<Obsolete>]
    [<CustomOperation("innerBorder")>]
    member this.InnerBorder(it: SearchEntryProperty seq, value: Gtk.Border) =
        seq { yield! it; yield SearchEntryProperty.InnerBorder value } 
    [<CustomOperation("name")>]
    member this.Name(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SearchEntryProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SearchEntryProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SearchEntryProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SearchEntryProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SearchEntryProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SearchEntryProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SearchEntryProperty seq, value: System.String) =
        seq { yield! it; yield SearchEntryProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SearchEntryProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SearchEntryProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SearchEntryProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SearchEntryProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SearchEntryProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SearchEntryProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SearchEntryProperty seq, value: System.Int32) =
        seq { yield! it; yield SearchEntryProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SearchEntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield SearchEntryProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SearchEntryProperty seq, value: System.Double) =
        seq { yield! it; yield SearchEntryProperty.Opacity value } 
    [<CustomOperation("onIconPress")>]
    member this.OnIconPress(it: SearchEntryProperty seq, value: Gtk.IconPressArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnIconPress value } 
    [<CustomOperation("onIconRelease")>]
    member this.OnIconRelease(it: SearchEntryProperty seq, value: Gtk.IconReleaseArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnIconRelease value } 
    [<CustomOperation("onDeleteFromCursor")>]
    member this.OnDeleteFromCursor(it: SearchEntryProperty seq, value: Gtk.DeleteFromCursorArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDeleteFromCursor value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: SearchEntryProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnMoveCursor value } 
    [<CustomOperation("onPreeditChanged")>]
    member this.OnPreeditChanged(it: SearchEntryProperty seq, value: Gtk.PreeditChangedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnPreeditChanged value } 
    [<CustomOperation("onInsertAtCursor")>]
    member this.OnInsertAtCursor(it: SearchEntryProperty seq, value: Gtk.InsertAtCursorArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnInsertAtCursor value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: SearchEntryProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnPopulatePopup value } 
    [<CustomOperation("onTextInserted")>]
    member this.OnTextInserted(it: SearchEntryProperty seq, value: Gtk.TextInsertedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnTextInserted value } 
    [<CustomOperation("onTextDeleted")>]
    member this.OnTextDeleted(it: SearchEntryProperty seq, value: Gtk.TextDeletedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnTextDeleted value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SearchEntryProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SearchEntryProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SearchEntryProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SearchEntryProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SearchEntryProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SearchEntryProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SearchEntryProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SearchEntryProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SearchEntryProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SearchEntryProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SearchEntryProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SearchEntryProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SearchEntryProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SearchEntryProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SearchEntryProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SearchEntryProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SearchEntryProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SearchEntryProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SearchEntryProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SearchEntryProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SearchEntryProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SearchEntryProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SearchEntryProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SearchEntryProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SearchEntryProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SearchEntryProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SearchEntryProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SearchEntryProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SearchEntryProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SearchEntryProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SearchEntryProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SearchEntryProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SearchEntryProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SearchEntryProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SearchEntryProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SearchEntryProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SearchEntryProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SearchEntryProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SearchEntryProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SearchEntryProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SearchEntryProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SearchEntryProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SearchEntryProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SearchEntryProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SearchEntryProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SearchEntryProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SearchEntryProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SearchEntryProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SearchEntryProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SearchEntryProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SearchEntryProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SearchEntryProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SearchEntryProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SearchEntryProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SearchEntryProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SearchEntryProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SearchEntryProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SearchEntryProperty.OnFocused value } 

let prop = SearchEntryPropertyBuilder()

type SearchEntryDescriptor(props) =
    inherit BaseWidgetDescriptor<SearchEntry, SearchEntryProperty>(props, bindProperty)
    override this.CreateTyped() = new SearchEntry()

let searchEntry props = SearchEntryDescriptor(props)

