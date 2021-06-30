module GtkDsl.Binding.SpinButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type SpinButtonProperty =
    | Adjustment of Gtk.Adjustment
    | ClimbRate of System.Double
    | Digits of System.UInt32
    | SnapToTicks of System.Boolean
    | Numeric of System.Boolean
    | Wrap of System.Boolean
    | UpdatePolicy of Gtk.SpinButtonUpdatePolicy
    | Value of System.Double
    | Orientation of Gtk.Orientation
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
    |  OnInput of (Gtk.InputArgs -> unit)
    |  OnChangeValue of (Gtk.ChangeValueArgs -> unit)
    |  OnOutput of (Gtk.OutputArgs -> unit)
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

let bindProperty (widget: SpinButton) (prop: SpinButtonProperty) =
    match prop with
    | SpinButtonProperty.Adjustment value -> widget.Adjustment <- value
    | SpinButtonProperty.ClimbRate value -> widget.ClimbRate <- value
    | SpinButtonProperty.Digits value -> widget.Digits <- value
    | SpinButtonProperty.SnapToTicks value -> widget.SnapToTicks <- value
    | SpinButtonProperty.Numeric value -> widget.Numeric <- value
    | SpinButtonProperty.Wrap value -> widget.Wrap <- value
    | SpinButtonProperty.UpdatePolicy value -> widget.UpdatePolicy <- value
    | SpinButtonProperty.Value value -> widget.Value <- value
    | SpinButtonProperty.Orientation value -> widget.Orientation <- value
    | SpinButtonProperty.Buffer value -> widget.Buffer <- value
    | SpinButtonProperty.MaxLength value -> widget.MaxLength <- value
    | SpinButtonProperty.Visibility value -> widget.Visibility <- value
    | SpinButtonProperty.HasFrame value -> widget.HasFrame <- value
    | SpinButtonProperty.ActivatesDefault value -> widget.ActivatesDefault <- value
    | SpinButtonProperty.WidthChars value -> widget.WidthChars <- value
    | SpinButtonProperty.MaxWidthChars value -> widget.MaxWidthChars <- value
    | SpinButtonProperty.Text value -> widget.Text <- value
    | SpinButtonProperty.Xalign value -> widget.Xalign <- value
    | SpinButtonProperty.TruncateMultiline value -> widget.TruncateMultiline <- value
    | SpinButtonProperty.OverwriteMode value -> widget.OverwriteMode <- value
    | SpinButtonProperty.InvisibleCharSet value -> widget.InvisibleCharSet <- value
    | SpinButtonProperty.CapsLockWarning value -> widget.CapsLockWarning <- value
    | SpinButtonProperty.ProgressFraction value -> widget.ProgressFraction <- value
    | SpinButtonProperty.ProgressPulseStep value -> widget.ProgressPulseStep <- value
    | SpinButtonProperty.PlaceholderText value -> widget.PlaceholderText <- value
    | SpinButtonProperty.PrimaryIconPixbuf value -> widget.PrimaryIconPixbuf <- value
    | SpinButtonProperty.SecondaryIconPixbuf value -> widget.SecondaryIconPixbuf <- value
    | SpinButtonProperty.PrimaryIconStock value -> widget.PrimaryIconStock <- value
    | SpinButtonProperty.SecondaryIconStock value -> widget.SecondaryIconStock <- value
    | SpinButtonProperty.PrimaryIconName value -> widget.PrimaryIconName <- value
    | SpinButtonProperty.SecondaryIconName value -> widget.SecondaryIconName <- value
    | SpinButtonProperty.PrimaryIconGicon value -> widget.PrimaryIconGicon <- value
    | SpinButtonProperty.SecondaryIconGicon value -> widget.SecondaryIconGicon <- value
    | SpinButtonProperty.PrimaryIconActivatable value -> widget.PrimaryIconActivatable <- value
    | SpinButtonProperty.SecondaryIconActivatable value -> widget.SecondaryIconActivatable <- value
    | SpinButtonProperty.PrimaryIconSensitive value -> widget.PrimaryIconSensitive <- value
    | SpinButtonProperty.SecondaryIconSensitive value -> widget.SecondaryIconSensitive <- value
    | SpinButtonProperty.PrimaryIconTooltipText value -> widget.PrimaryIconTooltipText <- value
    | SpinButtonProperty.SecondaryIconTooltipText value -> widget.SecondaryIconTooltipText <- value
    | SpinButtonProperty.PrimaryIconTooltipMarkup value -> widget.PrimaryIconTooltipMarkup <- value
    | SpinButtonProperty.SecondaryIconTooltipMarkup value -> widget.SecondaryIconTooltipMarkup <- value
    | SpinButtonProperty.ImModule value -> widget.ImModule <- value
    | SpinButtonProperty.Completion value -> widget.Completion <- value
    | SpinButtonProperty.InputPurpose value -> widget.InputPurpose <- value
    | SpinButtonProperty.InputHints value -> widget.InputHints <- value
    | SpinButtonProperty.Attributes value -> widget.Attributes <- value
    | SpinButtonProperty.PopulateAll value -> widget.PopulateAll <- value
    | SpinButtonProperty.Tabs value -> widget.Tabs <- value
    | SpinButtonProperty.InvisibleChar value -> widget.InvisibleChar <- value
    | SpinButtonProperty.InnerBorder value -> widget.InnerBorder <- value
    | SpinButtonProperty.Name value -> widget.Name <- value
    | SpinButtonProperty.Parent value -> widget.Parent <- value
    | SpinButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | SpinButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | SpinButtonProperty.Visible value -> widget.Visible <- value
    | SpinButtonProperty.Sensitive value -> widget.Sensitive <- value
    | SpinButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | SpinButtonProperty.CanFocus value -> widget.CanFocus <- value
    | SpinButtonProperty.HasFocus value -> widget.HasFocus <- value
    | SpinButtonProperty.IsFocus value -> widget.IsFocus <- value
    | SpinButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | SpinButtonProperty.CanDefault value -> widget.CanDefault <- value
    | SpinButtonProperty.HasDefault value -> widget.HasDefault <- value
    | SpinButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | SpinButtonProperty.Style value -> widget.Style <- value
    | SpinButtonProperty.Events value -> widget.Events <- value
    | SpinButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | SpinButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | SpinButtonProperty.TooltipText value -> widget.TooltipText <- value
    | SpinButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | SpinButtonProperty.Window value -> widget.Window <- value
    | SpinButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | SpinButtonProperty.Halign value -> widget.Halign <- value
    | SpinButtonProperty.Valign value -> widget.Valign <- value
    | SpinButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | SpinButtonProperty.MarginRight value -> widget.MarginRight <- value
    | SpinButtonProperty.MarginStart value -> widget.MarginStart <- value
    | SpinButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | SpinButtonProperty.MarginTop value -> widget.MarginTop <- value
    | SpinButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | SpinButtonProperty.Margin value -> widget.Margin <- value
    | SpinButtonProperty.Hexpand value -> widget.Hexpand <- value
    | SpinButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | SpinButtonProperty.Vexpand value -> widget.Vexpand <- value
    | SpinButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | SpinButtonProperty.Expand value -> widget.Expand <- value
    | SpinButtonProperty.Opacity value -> widget.Opacity <- value
    | SpinButtonProperty.OnInput handler -> 
        let disposable = widget.Input.Subscribe(handler)
        registerListener widget "Input" disposable
    | SpinButtonProperty.OnChangeValue handler -> 
        let disposable = widget.ChangeValue.Subscribe(handler)
        registerListener widget "ChangeValue" disposable
    | SpinButtonProperty.OnOutput handler -> 
        let disposable = widget.Output.Subscribe(handler)
        registerListener widget "Output" disposable
    | SpinButtonProperty.OnIconPress handler -> 
        let disposable = widget.IconPress.Subscribe(handler)
        registerListener widget "IconPress" disposable
    | SpinButtonProperty.OnIconRelease handler -> 
        let disposable = widget.IconRelease.Subscribe(handler)
        registerListener widget "IconRelease" disposable
    | SpinButtonProperty.OnDeleteFromCursor handler -> 
        let disposable = widget.DeleteFromCursor.Subscribe(handler)
        registerListener widget "DeleteFromCursor" disposable
    | SpinButtonProperty.OnMoveCursor handler -> 
        let disposable = widget.MoveCursor.Subscribe(handler)
        registerListener widget "MoveCursor" disposable
    | SpinButtonProperty.OnPreeditChanged handler -> 
        let disposable = widget.PreeditChanged.Subscribe(handler)
        registerListener widget "PreeditChanged" disposable
    | SpinButtonProperty.OnInsertAtCursor handler -> 
        let disposable = widget.InsertAtCursor.Subscribe(handler)
        registerListener widget "InsertAtCursor" disposable
    | SpinButtonProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | SpinButtonProperty.OnTextInserted handler -> 
        let disposable = widget.TextInserted.Subscribe(handler)
        registerListener widget "TextInserted" disposable
    | SpinButtonProperty.OnTextDeleted handler -> 
        let disposable = widget.TextDeleted.Subscribe(handler)
        registerListener widget "TextDeleted" disposable
    | SpinButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | SpinButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | SpinButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | SpinButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | SpinButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | SpinButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | SpinButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | SpinButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | SpinButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | SpinButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | SpinButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | SpinButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | SpinButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | SpinButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | SpinButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | SpinButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | SpinButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | SpinButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | SpinButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | SpinButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | SpinButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | SpinButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | SpinButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | SpinButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | SpinButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | SpinButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | SpinButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | SpinButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | SpinButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | SpinButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | SpinButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | SpinButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | SpinButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | SpinButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | SpinButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | SpinButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | SpinButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | SpinButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | SpinButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | SpinButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | SpinButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | SpinButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | SpinButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | SpinButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | SpinButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | SpinButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | SpinButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | SpinButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | SpinButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | SpinButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | SpinButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | SpinButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | SpinButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | SpinButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | SpinButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | SpinButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | SpinButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type SpinButtonPropertyBuilder() =
    inherit BasePropertyBuilder<SpinButtonProperty>()
    [<CustomOperation("adjustment")>]
    member this.Adjustment(it: SpinButtonProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield SpinButtonProperty.Adjustment value } 
    [<CustomOperation("climbRate")>]
    member this.ClimbRate(it: SpinButtonProperty seq, value: System.Double) =
        seq { yield! it; yield SpinButtonProperty.ClimbRate value } 
    [<CustomOperation("digits")>]
    member this.Digits(it: SpinButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield SpinButtonProperty.Digits value } 
    [<CustomOperation("snapToTicks")>]
    member this.SnapToTicks(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.SnapToTicks value } 
    [<CustomOperation("numeric")>]
    member this.Numeric(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Numeric value } 
    [<CustomOperation("wrap")>]
    member this.Wrap(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Wrap value } 
    [<CustomOperation("updatePolicy")>]
    member this.UpdatePolicy(it: SpinButtonProperty seq, value: Gtk.SpinButtonUpdatePolicy) =
        seq { yield! it; yield SpinButtonProperty.UpdatePolicy value } 
    [<CustomOperation("value")>]
    member this.Value(it: SpinButtonProperty seq, value: System.Double) =
        seq { yield! it; yield SpinButtonProperty.Value value } 
    [<CustomOperation("orientation")>]
    member this.Orientation(it: SpinButtonProperty seq, value: Gtk.Orientation) =
        seq { yield! it; yield SpinButtonProperty.Orientation value } 
    [<CustomOperation("buffer")>]
    member this.Buffer(it: SpinButtonProperty seq, value: Gtk.EntryBuffer) =
        seq { yield! it; yield SpinButtonProperty.Buffer value } 
    [<CustomOperation("maxLength")>]
    member this.MaxLength(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MaxLength value } 
    [<CustomOperation("visibility")>]
    member this.Visibility(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Visibility value } 
    [<CustomOperation("hasFrame")>]
    member this.HasFrame(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.HasFrame value } 
    [<CustomOperation("activatesDefault")>]
    member this.ActivatesDefault(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.ActivatesDefault value } 
    [<CustomOperation("widthChars")>]
    member this.WidthChars(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.WidthChars value } 
    [<CustomOperation("maxWidthChars")>]
    member this.MaxWidthChars(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MaxWidthChars value } 
    [<CustomOperation("text")>]
    member this.Text(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.Text value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: SpinButtonProperty seq, value: System.Single) =
        seq { yield! it; yield SpinButtonProperty.Xalign value } 
    [<CustomOperation("truncateMultiline")>]
    member this.TruncateMultiline(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.TruncateMultiline value } 
    [<CustomOperation("overwriteMode")>]
    member this.OverwriteMode(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.OverwriteMode value } 
    [<CustomOperation("invisibleCharSet")>]
    member this.InvisibleCharSet(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.InvisibleCharSet value } 
    [<CustomOperation("capsLockWarning")>]
    member this.CapsLockWarning(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.CapsLockWarning value } 
    [<CustomOperation("progressFraction")>]
    member this.ProgressFraction(it: SpinButtonProperty seq, value: System.Double) =
        seq { yield! it; yield SpinButtonProperty.ProgressFraction value } 
    [<CustomOperation("progressPulseStep")>]
    member this.ProgressPulseStep(it: SpinButtonProperty seq, value: System.Double) =
        seq { yield! it; yield SpinButtonProperty.ProgressPulseStep value } 
    [<CustomOperation("placeholderText")>]
    member this.PlaceholderText(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.PlaceholderText value } 
    [<CustomOperation("primaryIconPixbuf")>]
    member this.PrimaryIconPixbuf(it: SpinButtonProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconPixbuf value } 
    [<CustomOperation("secondaryIconPixbuf")>]
    member this.SecondaryIconPixbuf(it: SpinButtonProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconPixbuf value } 
    [<CustomOperation("primaryIconStock")>]
    member this.PrimaryIconStock(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconStock value } 
    [<CustomOperation("secondaryIconStock")>]
    member this.SecondaryIconStock(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconStock value } 
    [<CustomOperation("primaryIconName")>]
    member this.PrimaryIconName(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconName value } 
    [<CustomOperation("secondaryIconName")>]
    member this.SecondaryIconName(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconName value } 
    [<CustomOperation("primaryIconGicon")>]
    member this.PrimaryIconGicon(it: SpinButtonProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconGicon value } 
    [<CustomOperation("secondaryIconGicon")>]
    member this.SecondaryIconGicon(it: SpinButtonProperty seq, value: GLib.IIcon) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconGicon value } 
    [<CustomOperation("primaryIconActivatable")>]
    member this.PrimaryIconActivatable(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconActivatable value } 
    [<CustomOperation("secondaryIconActivatable")>]
    member this.SecondaryIconActivatable(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconActivatable value } 
    [<CustomOperation("primaryIconSensitive")>]
    member this.PrimaryIconSensitive(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconSensitive value } 
    [<CustomOperation("secondaryIconSensitive")>]
    member this.SecondaryIconSensitive(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconSensitive value } 
    [<CustomOperation("primaryIconTooltipText")>]
    member this.PrimaryIconTooltipText(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconTooltipText value } 
    [<CustomOperation("secondaryIconTooltipText")>]
    member this.SecondaryIconTooltipText(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconTooltipText value } 
    [<CustomOperation("primaryIconTooltipMarkup")>]
    member this.PrimaryIconTooltipMarkup(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.PrimaryIconTooltipMarkup value } 
    [<CustomOperation("secondaryIconTooltipMarkup")>]
    member this.SecondaryIconTooltipMarkup(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.SecondaryIconTooltipMarkup value } 
    [<CustomOperation("imModule")>]
    member this.ImModule(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.ImModule value } 
    [<CustomOperation("completion")>]
    member this.Completion(it: SpinButtonProperty seq, value: Gtk.EntryCompletion) =
        seq { yield! it; yield SpinButtonProperty.Completion value } 
    [<CustomOperation("inputPurpose")>]
    member this.InputPurpose(it: SpinButtonProperty seq, value: Gtk.InputPurpose) =
        seq { yield! it; yield SpinButtonProperty.InputPurpose value } 
    [<CustomOperation("inputHints")>]
    member this.InputHints(it: SpinButtonProperty seq, value: Gtk.InputHints) =
        seq { yield! it; yield SpinButtonProperty.InputHints value } 
    [<CustomOperation("attributes")>]
    member this.Attributes(it: SpinButtonProperty seq, value: Pango.AttrList) =
        seq { yield! it; yield SpinButtonProperty.Attributes value } 
    [<CustomOperation("populateAll")>]
    member this.PopulateAll(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.PopulateAll value } 
    [<CustomOperation("tabs")>]
    member this.Tabs(it: SpinButtonProperty seq, value: Pango.TabArray) =
        seq { yield! it; yield SpinButtonProperty.Tabs value } 
    [<CustomOperation("invisibleChar")>]
    member this.InvisibleChar(it: SpinButtonProperty seq, value: System.Char) =
        seq { yield! it; yield SpinButtonProperty.InvisibleChar value } 
    [<Obsolete>]
    [<CustomOperation("innerBorder")>]
    member this.InnerBorder(it: SpinButtonProperty seq, value: Gtk.Border) =
        seq { yield! it; yield SpinButtonProperty.InnerBorder value } 
    [<CustomOperation("name")>]
    member this.Name(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: SpinButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield SpinButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: SpinButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield SpinButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: SpinButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield SpinButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: SpinButtonProperty seq, value: System.String) =
        seq { yield! it; yield SpinButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: SpinButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield SpinButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: SpinButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SpinButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: SpinButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield SpinButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: SpinButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield SpinButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: SpinButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield SpinButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: SpinButtonProperty seq, value: System.Double) =
        seq { yield! it; yield SpinButtonProperty.Opacity value } 
    [<CustomOperation("onInput")>]
    member this.OnInput(it: SpinButtonProperty seq, value: Gtk.InputArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnInput value } 
    [<CustomOperation("onChangeValue")>]
    member this.OnChangeValue(it: SpinButtonProperty seq, value: Gtk.ChangeValueArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnChangeValue value } 
    [<CustomOperation("onOutput")>]
    member this.OnOutput(it: SpinButtonProperty seq, value: Gtk.OutputArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnOutput value } 
    [<CustomOperation("onIconPress")>]
    member this.OnIconPress(it: SpinButtonProperty seq, value: Gtk.IconPressArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnIconPress value } 
    [<CustomOperation("onIconRelease")>]
    member this.OnIconRelease(it: SpinButtonProperty seq, value: Gtk.IconReleaseArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnIconRelease value } 
    [<CustomOperation("onDeleteFromCursor")>]
    member this.OnDeleteFromCursor(it: SpinButtonProperty seq, value: Gtk.DeleteFromCursorArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDeleteFromCursor value } 
    [<CustomOperation("onMoveCursor")>]
    member this.OnMoveCursor(it: SpinButtonProperty seq, value: Gtk.MoveCursorArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnMoveCursor value } 
    [<CustomOperation("onPreeditChanged")>]
    member this.OnPreeditChanged(it: SpinButtonProperty seq, value: Gtk.PreeditChangedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnPreeditChanged value } 
    [<CustomOperation("onInsertAtCursor")>]
    member this.OnInsertAtCursor(it: SpinButtonProperty seq, value: Gtk.InsertAtCursorArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnInsertAtCursor value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: SpinButtonProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnPopulatePopup value } 
    [<CustomOperation("onTextInserted")>]
    member this.OnTextInserted(it: SpinButtonProperty seq, value: Gtk.TextInsertedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnTextInserted value } 
    [<CustomOperation("onTextDeleted")>]
    member this.OnTextDeleted(it: SpinButtonProperty seq, value: Gtk.TextDeletedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnTextDeleted value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: SpinButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: SpinButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: SpinButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: SpinButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: SpinButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: SpinButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: SpinButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: SpinButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: SpinButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: SpinButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: SpinButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: SpinButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: SpinButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: SpinButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: SpinButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: SpinButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: SpinButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: SpinButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: SpinButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: SpinButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: SpinButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: SpinButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: SpinButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: SpinButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: SpinButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: SpinButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: SpinButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: SpinButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: SpinButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: SpinButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: SpinButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: SpinButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: SpinButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: SpinButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: SpinButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: SpinButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: SpinButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: SpinButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: SpinButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: SpinButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: SpinButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: SpinButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: SpinButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: SpinButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: SpinButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: SpinButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: SpinButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: SpinButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: SpinButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: SpinButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: SpinButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: SpinButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: SpinButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: SpinButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: SpinButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: SpinButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: SpinButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield SpinButtonProperty.OnFocused value } 

let prop = SpinButtonPropertyBuilder()

