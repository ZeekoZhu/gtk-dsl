module GtkDsl.Binding.Entry
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type EntryProperty =
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

let bindProperty (widget: Entry) (prop: EntryProperty) =
    match prop with
    | EntryProperty.Buffer value -> widget.Buffer <- value
    | EntryProperty.MaxLength value -> widget.MaxLength <- value
    | EntryProperty.Visibility value -> widget.Visibility <- value
    | EntryProperty.HasFrame value -> widget.HasFrame <- value
    | EntryProperty.ActivatesDefault value -> widget.ActivatesDefault <- value
    | EntryProperty.WidthChars value -> widget.WidthChars <- value
    | EntryProperty.MaxWidthChars value -> widget.MaxWidthChars <- value
    | EntryProperty.Text value -> widget.Text <- value
    | EntryProperty.Xalign value -> widget.Xalign <- value
    | EntryProperty.TruncateMultiline value -> widget.TruncateMultiline <- value
    | EntryProperty.ShadowType value -> widget.ShadowType <- value
    | EntryProperty.OverwriteMode value -> widget.OverwriteMode <- value
    | EntryProperty.InvisibleCharSet value -> widget.InvisibleCharSet <- value
    | EntryProperty.CapsLockWarning value -> widget.CapsLockWarning <- value
    | EntryProperty.ProgressFraction value -> widget.ProgressFraction <- value
    | EntryProperty.ProgressPulseStep value -> widget.ProgressPulseStep <- value
    | EntryProperty.PlaceholderText value -> widget.PlaceholderText <- value
    | EntryProperty.PrimaryIconPixbuf value -> widget.PrimaryIconPixbuf <- value
    | EntryProperty.SecondaryIconPixbuf value -> widget.SecondaryIconPixbuf <- value
    | EntryProperty.PrimaryIconStock value -> widget.PrimaryIconStock <- value
    | EntryProperty.SecondaryIconStock value -> widget.SecondaryIconStock <- value
    | EntryProperty.PrimaryIconName value -> widget.PrimaryIconName <- value
    | EntryProperty.SecondaryIconName value -> widget.SecondaryIconName <- value
    | EntryProperty.PrimaryIconGicon value -> widget.PrimaryIconGicon <- value
    | EntryProperty.SecondaryIconGicon value -> widget.SecondaryIconGicon <- value
    | EntryProperty.PrimaryIconActivatable value -> widget.PrimaryIconActivatable <- value
    | EntryProperty.SecondaryIconActivatable value -> widget.SecondaryIconActivatable <- value
    | EntryProperty.PrimaryIconSensitive value -> widget.PrimaryIconSensitive <- value
    | EntryProperty.SecondaryIconSensitive value -> widget.SecondaryIconSensitive <- value
    | EntryProperty.PrimaryIconTooltipText value -> widget.PrimaryIconTooltipText <- value
    | EntryProperty.SecondaryIconTooltipText value -> widget.SecondaryIconTooltipText <- value
    | EntryProperty.PrimaryIconTooltipMarkup value -> widget.PrimaryIconTooltipMarkup <- value
    | EntryProperty.SecondaryIconTooltipMarkup value -> widget.SecondaryIconTooltipMarkup <- value
    | EntryProperty.ImModule value -> widget.ImModule <- value
    | EntryProperty.Completion value -> widget.Completion <- value
    | EntryProperty.InputPurpose value -> widget.InputPurpose <- value
    | EntryProperty.InputHints value -> widget.InputHints <- value
    | EntryProperty.Attributes value -> widget.Attributes <- value
    | EntryProperty.PopulateAll value -> widget.PopulateAll <- value
    | EntryProperty.Tabs value -> widget.Tabs <- value
    | EntryProperty.InvisibleChar value -> widget.InvisibleChar <- value
    | EntryProperty.InnerBorder value -> widget.InnerBorder <- value
    | EntryProperty.Name value -> widget.Name <- value
    | EntryProperty.Parent value -> widget.Parent <- value
    | EntryProperty.WidthRequest value -> widget.WidthRequest <- value
    | EntryProperty.HeightRequest value -> widget.HeightRequest <- value
    | EntryProperty.Visible value -> widget.Visible <- value
    | EntryProperty.Sensitive value -> widget.Sensitive <- value
    | EntryProperty.AppPaintable value -> widget.AppPaintable <- value
    | EntryProperty.CanFocus value -> widget.CanFocus <- value
    | EntryProperty.HasFocus value -> widget.HasFocus <- value
    | EntryProperty.IsFocus value -> widget.IsFocus <- value
    | EntryProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | EntryProperty.CanDefault value -> widget.CanDefault <- value
    | EntryProperty.HasDefault value -> widget.HasDefault <- value
    | EntryProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | EntryProperty.Style value -> widget.Style <- value
    | EntryProperty.Events value -> widget.Events <- value
    | EntryProperty.NoShowAll value -> widget.NoShowAll <- value
    | EntryProperty.HasTooltip value -> widget.HasTooltip <- value
    | EntryProperty.TooltipText value -> widget.TooltipText <- value
    | EntryProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | EntryProperty.Window value -> widget.Window <- value
    | EntryProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | EntryProperty.Halign value -> widget.Halign <- value
    | EntryProperty.Valign value -> widget.Valign <- value
    | EntryProperty.MarginLeft value -> widget.MarginLeft <- value
    | EntryProperty.MarginRight value -> widget.MarginRight <- value
    | EntryProperty.MarginStart value -> widget.MarginStart <- value
    | EntryProperty.MarginEnd value -> widget.MarginEnd <- value
    | EntryProperty.MarginTop value -> widget.MarginTop <- value
    | EntryProperty.MarginBottom value -> widget.MarginBottom <- value
    | EntryProperty.Margin value -> widget.Margin <- value
    | EntryProperty.Hexpand value -> widget.Hexpand <- value
    | EntryProperty.HexpandSet value -> widget.HexpandSet <- value
    | EntryProperty.Vexpand value -> widget.Vexpand <- value
    | EntryProperty.VexpandSet value -> widget.VexpandSet <- value
    | EntryProperty.Expand value -> widget.Expand <- value
    | EntryProperty.Opacity value -> widget.Opacity <- value
    | EntryProperty.OnIconPress handler -> 
        let disposable = widget.IconPress.Subscribe(handler)
        registerListener widget "IconPress" disposable
    | EntryProperty.OnIconRelease handler -> 
        let disposable = widget.IconRelease.Subscribe(handler)
        registerListener widget "IconRelease" disposable
    | EntryProperty.OnDeleteFromCursor handler -> 
        let disposable = widget.DeleteFromCursor.Subscribe(handler)
        registerListener widget "DeleteFromCursor" disposable
    | EntryProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | EntryProperty.OnPreeditChanged handler -> 
        let disposable = widget.PreeditChanged.Subscribe(handler)
        registerListener widget "PreeditChanged" disposable
    | EntryProperty.OnInsertAtCursor handler -> 
        let disposable = widget.InsertAtCursor.Subscribe(handler)
        registerListener widget "InsertAtCursor" disposable
    | EntryProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | EntryProperty.OnTextInserted handler -> 
        let disposable = widget.TextInserted.Subscribe(handler)
        registerListener widget "TextInserted" disposable
    | EntryProperty.OnTextDeleted handler -> 
        let disposable = widget.TextDeleted.Subscribe(handler)
        registerListener widget "TextDeleted" disposable
    | EntryProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | EntryProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | EntryProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | EntryProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | EntryProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | EntryProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | EntryProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | EntryProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | EntryProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | EntryProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | EntryProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | EntryProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | EntryProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | EntryProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | EntryProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | EntryProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | EntryProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | EntryProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | EntryProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | EntryProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | EntryProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | EntryProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | EntryProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | EntryProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | EntryProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | EntryProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | EntryProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | EntryProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | EntryProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | EntryProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | EntryProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | EntryProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | EntryProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | EntryProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | EntryProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | EntryProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | EntryProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | EntryProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | EntryProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | EntryProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | EntryProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | EntryProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | EntryProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | EntryProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | EntryProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | EntryProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | EntryProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | EntryProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | EntryProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | EntryProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | EntryProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | EntryProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | EntryProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | EntryProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | EntryProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | EntryProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | EntryProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type EntryPropertyBuilder() =
    inherit BasePropertyBuilder<EntryProperty>()
    [<CustomOperation("buffer")>]
    member this.Buffer(it: EntryProperty seq, value: Gtk.EntryBuffer) =
        seq { yield! it; yield EntryProperty.Buffer value } 
    [<CustomOperation("maxLength")>]
    member this.MaxLength(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MaxLength value } 
    [<CustomOperation("visibility")>]
    member this.Visibility(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.Visibility value } 
    [<CustomOperation("hasFrame")>]
    member this.HasFrame(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.HasFrame value } 
    [<CustomOperation("activatesDefault")>]
    member this.ActivatesDefault(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.ActivatesDefault value } 
    [<CustomOperation("widthChars")>]
    member this.WidthChars(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.WidthChars value } 
    [<CustomOperation("maxWidthChars")>]
    member this.MaxWidthChars(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MaxWidthChars value } 
    [<CustomOperation("text")>]
    member this.Text(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.Text value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: EntryProperty seq, value: System.Single) =
        seq { yield! it; yield EntryProperty.Xalign value } 
    [<CustomOperation("truncateMultiline")>]
    member this.TruncateMultiline(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.TruncateMultiline value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: EntryProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield EntryProperty.ShadowType value } 
    [<CustomOperation("overwriteMode")>]
    member this.OverwriteMode(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.OverwriteMode value } 
    [<CustomOperation("invisibleCharSet")>]
    member this.InvisibleCharSet(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.InvisibleCharSet value } 
    [<CustomOperation("capsLockWarning")>]
    member this.CapsLockWarning(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.CapsLockWarning value } 
    [<CustomOperation("progressFraction")>]
    member this.ProgressFraction(it: EntryProperty seq, value: System.Double) =
        seq { yield! it; yield EntryProperty.ProgressFraction value } 
    [<CustomOperation("progressPulseStep")>]
    member this.ProgressPulseStep(it: EntryProperty seq, value: System.Double) =
        seq { yield! it; yield EntryProperty.ProgressPulseStep value } 
    [<CustomOperation("placeholderText")>]
    member this.PlaceholderText(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.PlaceholderText value } 
    [<CustomOperation("primaryIconPixbuf")>]
    member this.PrimaryIconPixbuf(it: EntryProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield EntryProperty.PrimaryIconPixbuf value } 
    [<CustomOperation("secondaryIconPixbuf")>]
    member this.SecondaryIconPixbuf(it: EntryProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield EntryProperty.SecondaryIconPixbuf value } 
    [<CustomOperation("primaryIconStock")>]
    member this.PrimaryIconStock(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.PrimaryIconStock value } 
    [<CustomOperation("secondaryIconStock")>]
    member this.SecondaryIconStock(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.SecondaryIconStock value } 
    [<CustomOperation("primaryIconName")>]
    member this.PrimaryIconName(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.PrimaryIconName value } 
    [<CustomOperation("secondaryIconName")>]
    member this.SecondaryIconName(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.SecondaryIconName value } 
    [<CustomOperation("primaryIconGicon")>]
    member this.PrimaryIconGicon(it: EntryProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield EntryProperty.PrimaryIconGicon value } 
    [<CustomOperation("secondaryIconGicon")>]
    member this.SecondaryIconGicon(it: EntryProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield EntryProperty.SecondaryIconGicon value } 
    [<CustomOperation("primaryIconActivatable")>]
    member this.PrimaryIconActivatable(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.PrimaryIconActivatable value } 
    [<CustomOperation("secondaryIconActivatable")>]
    member this.SecondaryIconActivatable(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.SecondaryIconActivatable value } 
    [<CustomOperation("primaryIconSensitive")>]
    member this.PrimaryIconSensitive(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.PrimaryIconSensitive value } 
    [<CustomOperation("secondaryIconSensitive")>]
    member this.SecondaryIconSensitive(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.SecondaryIconSensitive value } 
    [<CustomOperation("primaryIconTooltipText")>]
    member this.PrimaryIconTooltipText(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.PrimaryIconTooltipText value } 
    [<CustomOperation("secondaryIconTooltipText")>]
    member this.SecondaryIconTooltipText(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.SecondaryIconTooltipText value } 
    [<CustomOperation("primaryIconTooltipMarkup")>]
    member this.PrimaryIconTooltipMarkup(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.PrimaryIconTooltipMarkup value } 
    [<CustomOperation("secondaryIconTooltipMarkup")>]
    member this.SecondaryIconTooltipMarkup(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.SecondaryIconTooltipMarkup value } 
    [<CustomOperation("imModule")>]
    member this.ImModule(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.ImModule value } 
    [<CustomOperation("completion")>]
    member this.Completion(it: EntryProperty seq, value: Gtk.EntryCompletion) =
        seq { yield! it; yield EntryProperty.Completion value } 
    [<CustomOperation("inputPurpose")>]
    member this.InputPurpose(it: EntryProperty seq, value: Gtk.InputPurpose) =
        seq { yield! it; yield EntryProperty.InputPurpose value } 
    [<CustomOperation("inputHints")>]
    member this.InputHints(it: EntryProperty seq, value: Gtk.InputHints) =
        seq { yield! it; yield EntryProperty.InputHints value } 
    [<CustomOperation("attributes")>]
    member this.Attributes(it: EntryProperty seq, value: Pango.AttrList) =
        seq { yield! it; yield EntryProperty.Attributes value } 
    [<CustomOperation("populateAll")>]
    member this.PopulateAll(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.PopulateAll value } 
    [<CustomOperation("tabs")>]
    member this.Tabs(it: EntryProperty seq, value: Pango.TabArray) =
        seq { yield! it; yield EntryProperty.Tabs value } 
    [<CustomOperation("invisibleChar")>]
    member this.InvisibleChar(it: EntryProperty seq, value: System.Char) =
        seq { yield! it; yield EntryProperty.InvisibleChar value } 
    [<Obsolete>]
    [<CustomOperation("innerBorder")>]
    member this.InnerBorder(it: EntryProperty seq, value: Gtk.Border) =
        seq { yield! it; yield EntryProperty.InnerBorder value } 
    [<CustomOperation("name")>]
    member this.Name(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: EntryProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield EntryProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: EntryProperty seq, value: Gtk.Style) =
        seq { yield! it; yield EntryProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: EntryProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield EntryProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: EntryProperty seq, value: System.String) =
        seq { yield! it; yield EntryProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: EntryProperty seq, value: Gdk.Window) =
        seq { yield! it; yield EntryProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: EntryProperty seq, value: Gtk.Align) =
        seq { yield! it; yield EntryProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: EntryProperty seq, value: Gtk.Align) =
        seq { yield! it; yield EntryProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: EntryProperty seq, value: System.Int32) =
        seq { yield! it; yield EntryProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: EntryProperty seq, value: System.Boolean) =
        seq { yield! it; yield EntryProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: EntryProperty seq, value: System.Double) =
        seq { yield! it; yield EntryProperty.Opacity value } 
    [<CustomOperation("onIconPress")>]
    member this.OnIconPress(it: EntryProperty seq, value: Gtk.IconPressArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnIconPress value } 
    [<CustomOperation("onIconRelease")>]
    member this.OnIconRelease(it: EntryProperty seq, value: Gtk.IconReleaseArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnIconRelease value } 
    [<CustomOperation("onDeleteFromCursor")>]
    member this.OnDeleteFromCursor(it: EntryProperty seq, value: Gtk.DeleteFromCursorArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDeleteFromCursor value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: EntryProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnMoveCursor value } 
    [<CustomOperation("onPreeditChanged")>]
    member this.OnPreeditChanged(it: EntryProperty seq, value: Gtk.PreeditChangedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnPreeditChanged value } 
    [<CustomOperation("onInsertAtCursor")>]
    member this.OnInsertAtCursor(it: EntryProperty seq, value: Gtk.InsertAtCursorArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnInsertAtCursor value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: EntryProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnPopulatePopup value } 
    [<CustomOperation("onTextInserted")>]
    member this.OnTextInserted(it: EntryProperty seq, value: Gtk.TextInsertedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnTextInserted value } 
    [<CustomOperation("onTextDeleted")>]
    member this.OnTextDeleted(it: EntryProperty seq, value: Gtk.TextDeletedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnTextDeleted value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: EntryProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: EntryProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: EntryProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: EntryProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: EntryProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: EntryProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: EntryProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: EntryProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: EntryProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: EntryProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: EntryProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: EntryProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: EntryProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: EntryProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: EntryProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: EntryProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: EntryProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: EntryProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: EntryProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: EntryProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: EntryProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: EntryProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: EntryProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: EntryProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: EntryProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: EntryProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: EntryProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: EntryProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: EntryProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: EntryProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: EntryProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: EntryProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: EntryProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: EntryProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: EntryProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: EntryProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: EntryProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: EntryProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: EntryProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: EntryProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: EntryProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: EntryProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: EntryProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: EntryProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: EntryProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: EntryProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: EntryProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: EntryProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: EntryProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: EntryProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: EntryProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: EntryProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: EntryProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: EntryProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: EntryProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: EntryProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: EntryProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield EntryProperty.OnFocused value } 

let prop = EntryPropertyBuilder()

type EntryDescriptor(props) =
    inherit BaseWidgetDescriptor<Entry, EntryProperty>(props, bindProperty)
    override this.CreateTyped() = new Entry()

let entry props = EntryDescriptor(props)

