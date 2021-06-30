module GtkDsl.Binding.FontButton
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type FontButtonProperty =
    | Title of System.String
    | FontName of System.String
    | UseFont of System.Boolean
    | UseSize of System.Boolean
    | ShowStyle of System.Boolean
    | ShowSize of System.Boolean
    | Font of System.String
    | FontDesc of Pango.FontDescription
    | PreviewText of System.String
    | ShowPreviewEntry of System.Boolean
    | Label of System.String
    | UseUnderline of System.Boolean
    | [<Obsolete>] UseStock of System.Boolean
    | Relief of Gtk.ReliefStyle
    | Xalign of System.Single
    | Yalign of System.Single
    | Image of Gtk.Widget
    | ImagePosition of Gtk.PositionType
    | AlwaysShowImage of System.Boolean
    | [<Obsolete>] RelatedAction of Gtk.Action
    | [<Obsolete>] UseActionAppearance of System.Boolean
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

let bindProperty (widget: FontButton) (prop: FontButtonProperty) =
    match prop with
    | FontButtonProperty.Title value -> widget.Title <- value
    | FontButtonProperty.FontName value -> widget.FontName <- value
    | FontButtonProperty.UseFont value -> widget.UseFont <- value
    | FontButtonProperty.UseSize value -> widget.UseSize <- value
    | FontButtonProperty.ShowStyle value -> widget.ShowStyle <- value
    | FontButtonProperty.ShowSize value -> widget.ShowSize <- value
    | FontButtonProperty.Font value -> widget.Font <- value
    | FontButtonProperty.FontDesc value -> widget.FontDesc <- value
    | FontButtonProperty.PreviewText value -> widget.PreviewText <- value
    | FontButtonProperty.ShowPreviewEntry value -> widget.ShowPreviewEntry <- value
    | FontButtonProperty.Label value -> widget.Label <- value
    | FontButtonProperty.UseUnderline value -> widget.UseUnderline <- value
    | FontButtonProperty.UseStock value -> widget.UseStock <- value
    | FontButtonProperty.Relief value -> widget.Relief <- value
    | FontButtonProperty.Xalign value -> widget.Xalign <- value
    | FontButtonProperty.Yalign value -> widget.Yalign <- value
    | FontButtonProperty.Image value -> widget.Image <- value
    | FontButtonProperty.ImagePosition value -> widget.ImagePosition <- value
    | FontButtonProperty.AlwaysShowImage value -> widget.AlwaysShowImage <- value
    | FontButtonProperty.RelatedAction value -> widget.RelatedAction <- value
    | FontButtonProperty.UseActionAppearance value -> widget.UseActionAppearance <- value
    | FontButtonProperty.ResizeMode value -> widget.ResizeMode <- value
    | FontButtonProperty.BorderWidth value -> widget.BorderWidth <- value
    | FontButtonProperty.Name value -> widget.Name <- value
    | FontButtonProperty.Parent value -> widget.Parent <- value
    | FontButtonProperty.WidthRequest value -> widget.WidthRequest <- value
    | FontButtonProperty.HeightRequest value -> widget.HeightRequest <- value
    | FontButtonProperty.Visible value -> widget.Visible <- value
    | FontButtonProperty.Sensitive value -> widget.Sensitive <- value
    | FontButtonProperty.AppPaintable value -> widget.AppPaintable <- value
    | FontButtonProperty.CanFocus value -> widget.CanFocus <- value
    | FontButtonProperty.HasFocus value -> widget.HasFocus <- value
    | FontButtonProperty.IsFocus value -> widget.IsFocus <- value
    | FontButtonProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | FontButtonProperty.CanDefault value -> widget.CanDefault <- value
    | FontButtonProperty.HasDefault value -> widget.HasDefault <- value
    | FontButtonProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | FontButtonProperty.Style value -> widget.Style <- value
    | FontButtonProperty.Events value -> widget.Events <- value
    | FontButtonProperty.NoShowAll value -> widget.NoShowAll <- value
    | FontButtonProperty.HasTooltip value -> widget.HasTooltip <- value
    | FontButtonProperty.TooltipText value -> widget.TooltipText <- value
    | FontButtonProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | FontButtonProperty.Window value -> widget.Window <- value
    | FontButtonProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | FontButtonProperty.Halign value -> widget.Halign <- value
    | FontButtonProperty.Valign value -> widget.Valign <- value
    | FontButtonProperty.MarginLeft value -> widget.MarginLeft <- value
    | FontButtonProperty.MarginRight value -> widget.MarginRight <- value
    | FontButtonProperty.MarginStart value -> widget.MarginStart <- value
    | FontButtonProperty.MarginEnd value -> widget.MarginEnd <- value
    | FontButtonProperty.MarginTop value -> widget.MarginTop <- value
    | FontButtonProperty.MarginBottom value -> widget.MarginBottom <- value
    | FontButtonProperty.Margin value -> widget.Margin <- value
    | FontButtonProperty.Hexpand value -> widget.Hexpand <- value
    | FontButtonProperty.HexpandSet value -> widget.HexpandSet <- value
    | FontButtonProperty.Vexpand value -> widget.Vexpand <- value
    | FontButtonProperty.VexpandSet value -> widget.VexpandSet <- value
    | FontButtonProperty.Expand value -> widget.Expand <- value
    | FontButtonProperty.Opacity value -> widget.Opacity <- value
    | FontButtonProperty.OnFontActivated handler -> 
        let disposable = widget.FontActivated.Subscribe(handler)
        registerListener widget "FontActivated" disposable
    | FontButtonProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | FontButtonProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | FontButtonProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | FontButtonProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | FontButtonProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | FontButtonProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | FontButtonProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | FontButtonProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | FontButtonProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | FontButtonProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | FontButtonProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | FontButtonProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | FontButtonProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | FontButtonProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | FontButtonProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | FontButtonProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | FontButtonProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | FontButtonProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | FontButtonProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | FontButtonProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | FontButtonProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | FontButtonProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | FontButtonProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | FontButtonProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | FontButtonProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | FontButtonProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | FontButtonProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | FontButtonProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | FontButtonProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | FontButtonProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | FontButtonProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | FontButtonProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | FontButtonProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | FontButtonProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | FontButtonProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | FontButtonProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | FontButtonProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | FontButtonProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | FontButtonProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | FontButtonProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | FontButtonProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | FontButtonProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | FontButtonProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | FontButtonProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | FontButtonProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | FontButtonProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | FontButtonProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | FontButtonProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | FontButtonProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | FontButtonProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | FontButtonProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | FontButtonProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | FontButtonProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | FontButtonProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | FontButtonProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | FontButtonProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | FontButtonProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | FontButtonProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | FontButtonProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | FontButtonProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type FontButtonPropertyBuilder() =
    inherit BasePropertyBuilder<FontButtonProperty>()
    [<CustomOperation("title")>]
    member this.Title(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.Title value } 
    [<CustomOperation("fontName")>]
    member this.FontName(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.FontName value } 
    [<CustomOperation("useFont")>]
    member this.UseFont(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.UseFont value } 
    [<CustomOperation("useSize")>]
    member this.UseSize(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.UseSize value } 
    [<CustomOperation("showStyle")>]
    member this.ShowStyle(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.ShowStyle value } 
    [<CustomOperation("showSize")>]
    member this.ShowSize(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.ShowSize value } 
    [<CustomOperation("font")>]
    member this.Font(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.Font value } 
    [<CustomOperation("fontDesc")>]
    member this.FontDesc(it: FontButtonProperty seq, value: Pango.FontDescription) =
        seq { yield! it; yield FontButtonProperty.FontDesc value } 
    [<CustomOperation("previewText")>]
    member this.PreviewText(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.PreviewText value } 
    [<CustomOperation("showPreviewEntry")>]
    member this.ShowPreviewEntry(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.ShowPreviewEntry value } 
    [<CustomOperation("label")>]
    member this.Label(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.Label value } 
    [<CustomOperation("useUnderline")>]
    member this.UseUnderline(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.UseUnderline value } 
    [<Obsolete>]
    [<CustomOperation("useStock")>]
    member this.UseStock(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.UseStock value } 
    [<CustomOperation("relief")>]
    member this.Relief(it: FontButtonProperty seq, value: Gtk.ReliefStyle) =
        seq { yield! it; yield FontButtonProperty.Relief value } 
    [<CustomOperation("xalign")>]
    member this.Xalign(it: FontButtonProperty seq, value: System.Single) =
        seq { yield! it; yield FontButtonProperty.Xalign value } 
    [<CustomOperation("yalign")>]
    member this.Yalign(it: FontButtonProperty seq, value: System.Single) =
        seq { yield! it; yield FontButtonProperty.Yalign value } 
    [<CustomOperation("image")>]
    member this.Image(it: FontButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontButtonProperty.Image value } 
    [<CustomOperation("imagePosition")>]
    member this.ImagePosition(it: FontButtonProperty seq, value: Gtk.PositionType) =
        seq { yield! it; yield FontButtonProperty.ImagePosition value } 
    [<CustomOperation("alwaysShowImage")>]
    member this.AlwaysShowImage(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.AlwaysShowImage value } 
    [<Obsolete>]
    [<CustomOperation("relatedAction")>]
    member this.RelatedAction(it: FontButtonProperty seq, value: Gtk.Action) =
        seq { yield! it; yield FontButtonProperty.RelatedAction value } 
    [<Obsolete>]
    [<CustomOperation("useActionAppearance")>]
    member this.UseActionAppearance(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.UseActionAppearance value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: FontButtonProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield FontButtonProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: FontButtonProperty seq, value: System.UInt32) =
        seq { yield! it; yield FontButtonProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: FontButtonProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield FontButtonProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: FontButtonProperty seq, value: Gtk.Style) =
        seq { yield! it; yield FontButtonProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: FontButtonProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield FontButtonProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: FontButtonProperty seq, value: System.String) =
        seq { yield! it; yield FontButtonProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: FontButtonProperty seq, value: Gdk.Window) =
        seq { yield! it; yield FontButtonProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: FontButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontButtonProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: FontButtonProperty seq, value: Gtk.Align) =
        seq { yield! it; yield FontButtonProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: FontButtonProperty seq, value: System.Int32) =
        seq { yield! it; yield FontButtonProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: FontButtonProperty seq, value: System.Boolean) =
        seq { yield! it; yield FontButtonProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: FontButtonProperty seq, value: System.Double) =
        seq { yield! it; yield FontButtonProperty.Opacity value } 
    [<CustomOperation("onFontActivated")>]
    member this.OnFontActivated(it: FontButtonProperty seq, value: Gtk.FontActivatedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnFontActivated value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: FontButtonProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: FontButtonProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: FontButtonProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: FontButtonProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: FontButtonProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: FontButtonProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: FontButtonProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: FontButtonProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: FontButtonProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: FontButtonProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: FontButtonProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: FontButtonProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: FontButtonProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: FontButtonProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: FontButtonProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: FontButtonProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: FontButtonProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: FontButtonProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: FontButtonProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: FontButtonProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: FontButtonProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: FontButtonProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: FontButtonProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: FontButtonProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: FontButtonProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: FontButtonProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: FontButtonProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: FontButtonProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: FontButtonProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: FontButtonProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: FontButtonProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: FontButtonProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: FontButtonProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: FontButtonProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: FontButtonProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: FontButtonProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: FontButtonProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: FontButtonProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: FontButtonProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: FontButtonProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: FontButtonProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: FontButtonProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: FontButtonProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: FontButtonProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: FontButtonProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: FontButtonProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: FontButtonProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: FontButtonProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: FontButtonProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: FontButtonProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: FontButtonProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: FontButtonProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: FontButtonProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: FontButtonProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: FontButtonProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: FontButtonProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: FontButtonProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: FontButtonProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: FontButtonProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: FontButtonProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield FontButtonProperty.OnFocused value } 

let prop = FontButtonPropertyBuilder()

type FontButtonDescriptor(props) =
    inherit BaseWidgetDescriptor<FontButton, FontButtonProperty>(props, bindProperty)
    override this.CreateTyped() = new FontButton()

let fontButton props = FontButtonDescriptor(props)

