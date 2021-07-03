module Gtk.DSL.Binding.AboutDialog
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type AboutDialogProperty =
    | ProgramName of System.String
    | Version of System.String
    | Copyright of System.String
    | Comments of System.String
    | License of System.String
    | LicenseType of Gtk.License
    | Website of System.String
    | WebsiteLabel of System.String
    | Authors of System.String[]
    | Documenters of System.String[]
    | Artists of System.String[]
    | TranslatorCredits of System.String
    | Logo of Gdk.Pixbuf
    | LogoIconName of System.String
    | WrapLicense of System.Boolean
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
    |  OnActivateLink of (Gtk.ActivateLinkArgs -> unit)
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

let bindProperty (widget: AboutDialog) (prop: AboutDialogProperty) =
    match prop with
    | AboutDialogProperty.ProgramName value -> widget.ProgramName <- value
    | AboutDialogProperty.Version value -> widget.Version <- value
    | AboutDialogProperty.Copyright value -> widget.Copyright <- value
    | AboutDialogProperty.Comments value -> widget.Comments <- value
    | AboutDialogProperty.License value -> widget.License <- value
    | AboutDialogProperty.LicenseType value -> widget.LicenseType <- value
    | AboutDialogProperty.Website value -> widget.Website <- value
    | AboutDialogProperty.WebsiteLabel value -> widget.WebsiteLabel <- value
    | AboutDialogProperty.Authors value -> widget.Authors <- value
    | AboutDialogProperty.Documenters value -> widget.Documenters <- value
    | AboutDialogProperty.Artists value -> widget.Artists <- value
    | AboutDialogProperty.TranslatorCredits value -> widget.TranslatorCredits <- value
    | AboutDialogProperty.Logo value -> widget.Logo <- value
    | AboutDialogProperty.LogoIconName value -> widget.LogoIconName <- value
    | AboutDialogProperty.WrapLicense value -> widget.WrapLicense <- value
    | AboutDialogProperty.Title value -> widget.Title <- value
    | AboutDialogProperty.Role value -> widget.Role <- value
    | AboutDialogProperty.Resizable value -> widget.Resizable <- value
    | AboutDialogProperty.Modal value -> widget.Modal <- value
    | AboutDialogProperty.WindowPosition value -> widget.WindowPosition <- value
    | AboutDialogProperty.DefaultWidth value -> widget.DefaultWidth <- value
    | AboutDialogProperty.DefaultHeight value -> widget.DefaultHeight <- value
    | AboutDialogProperty.DestroyWithParent value -> widget.DestroyWithParent <- value
    | AboutDialogProperty.HideTitlebarWhenMaximized value -> widget.HideTitlebarWhenMaximized <- value
    | AboutDialogProperty.Icon value -> widget.Icon <- value
    | AboutDialogProperty.MnemonicsVisible value -> widget.MnemonicsVisible <- value
    | AboutDialogProperty.FocusVisible value -> widget.FocusVisible <- value
    | AboutDialogProperty.IconName value -> widget.IconName <- value
    | AboutDialogProperty.Screen value -> widget.Screen <- value
    | AboutDialogProperty.TypeHint value -> widget.TypeHint <- value
    | AboutDialogProperty.SkipTaskbarHint value -> widget.SkipTaskbarHint <- value
    | AboutDialogProperty.SkipPagerHint value -> widget.SkipPagerHint <- value
    | AboutDialogProperty.UrgencyHint value -> widget.UrgencyHint <- value
    | AboutDialogProperty.AcceptFocus value -> widget.AcceptFocus <- value
    | AboutDialogProperty.FocusOnMap value -> widget.FocusOnMap <- value
    | AboutDialogProperty.Decorated value -> widget.Decorated <- value
    | AboutDialogProperty.Deletable value -> widget.Deletable <- value
    | AboutDialogProperty.HasResizeGrip value -> widget.HasResizeGrip <- value
    | AboutDialogProperty.Gravity value -> widget.Gravity <- value
    | AboutDialogProperty.TransientFor value -> widget.TransientFor <- value
    | AboutDialogProperty.AttachedTo value -> widget.AttachedTo <- value
    | AboutDialogProperty.Application value -> widget.Application <- value
    | AboutDialogProperty.DecorationResizeHandle value -> widget.DecorationResizeHandle <- value
    | AboutDialogProperty.ResizeMode value -> widget.ResizeMode <- value
    | AboutDialogProperty.BorderWidth value -> widget.BorderWidth <- value
    | AboutDialogProperty.Name value -> widget.Name <- value
    | AboutDialogProperty.Parent value -> widget.Parent <- value
    | AboutDialogProperty.WidthRequest value -> widget.WidthRequest <- value
    | AboutDialogProperty.HeightRequest value -> widget.HeightRequest <- value
    | AboutDialogProperty.Visible value -> widget.Visible <- value
    | AboutDialogProperty.Sensitive value -> widget.Sensitive <- value
    | AboutDialogProperty.AppPaintable value -> widget.AppPaintable <- value
    | AboutDialogProperty.CanFocus value -> widget.CanFocus <- value
    | AboutDialogProperty.HasFocus value -> widget.HasFocus <- value
    | AboutDialogProperty.IsFocus value -> widget.IsFocus <- value
    | AboutDialogProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | AboutDialogProperty.CanDefault value -> widget.CanDefault <- value
    | AboutDialogProperty.HasDefault value -> widget.HasDefault <- value
    | AboutDialogProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | AboutDialogProperty.Style value -> widget.Style <- value
    | AboutDialogProperty.Events value -> widget.Events <- value
    | AboutDialogProperty.NoShowAll value -> widget.NoShowAll <- value
    | AboutDialogProperty.HasTooltip value -> widget.HasTooltip <- value
    | AboutDialogProperty.TooltipText value -> widget.TooltipText <- value
    | AboutDialogProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | AboutDialogProperty.Window value -> widget.Window <- value
    | AboutDialogProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | AboutDialogProperty.Halign value -> widget.Halign <- value
    | AboutDialogProperty.Valign value -> widget.Valign <- value
    | AboutDialogProperty.MarginLeft value -> widget.MarginLeft <- value
    | AboutDialogProperty.MarginRight value -> widget.MarginRight <- value
    | AboutDialogProperty.MarginStart value -> widget.MarginStart <- value
    | AboutDialogProperty.MarginEnd value -> widget.MarginEnd <- value
    | AboutDialogProperty.MarginTop value -> widget.MarginTop <- value
    | AboutDialogProperty.MarginBottom value -> widget.MarginBottom <- value
    | AboutDialogProperty.Margin value -> widget.Margin <- value
    | AboutDialogProperty.Hexpand value -> widget.Hexpand <- value
    | AboutDialogProperty.HexpandSet value -> widget.HexpandSet <- value
    | AboutDialogProperty.Vexpand value -> widget.Vexpand <- value
    | AboutDialogProperty.VexpandSet value -> widget.VexpandSet <- value
    | AboutDialogProperty.Expand value -> widget.Expand <- value
    | AboutDialogProperty.Opacity value -> widget.Opacity <- value
    | AboutDialogProperty.OnActivateLink handler -> 
        let disposable = widget.ActivateLink.Subscribe(handler)
        registerListener widget "ActivateLink" disposable
    | AboutDialogProperty.OnResponse handler -> 
        let disposable = widget.Response.Subscribe(handler)
        registerListener widget "Response" disposable
    | AboutDialogProperty.OnEnableDebugging handler -> 
        let disposable = widget.EnableDebugging.Subscribe(handler)
        registerListener widget "EnableDebugging" disposable
    | AboutDialogProperty.OnSetFocus handler -> 
        let disposable = widget.SetFocus.Subscribe(handler)
        registerListener widget "SetFocus" disposable
    | AboutDialogProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | AboutDialogProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | AboutDialogProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | AboutDialogProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | AboutDialogProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | AboutDialogProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | AboutDialogProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | AboutDialogProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | AboutDialogProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | AboutDialogProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | AboutDialogProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | AboutDialogProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | AboutDialogProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | AboutDialogProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | AboutDialogProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | AboutDialogProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | AboutDialogProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | AboutDialogProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | AboutDialogProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | AboutDialogProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | AboutDialogProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | AboutDialogProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | AboutDialogProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | AboutDialogProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | AboutDialogProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | AboutDialogProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | AboutDialogProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | AboutDialogProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | AboutDialogProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | AboutDialogProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | AboutDialogProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | AboutDialogProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | AboutDialogProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | AboutDialogProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | AboutDialogProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | AboutDialogProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | AboutDialogProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | AboutDialogProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | AboutDialogProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | AboutDialogProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | AboutDialogProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | AboutDialogProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | AboutDialogProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | AboutDialogProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | AboutDialogProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | AboutDialogProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | AboutDialogProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | AboutDialogProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | AboutDialogProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | AboutDialogProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | AboutDialogProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | AboutDialogProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | AboutDialogProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | AboutDialogProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | AboutDialogProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | AboutDialogProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | AboutDialogProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | AboutDialogProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | AboutDialogProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | AboutDialogProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type AboutDialogPropertyBuilder() =
    inherit BasePropertyBuilder<AboutDialogProperty>()
    [<CustomOperation("programName")>]
    member this.ProgramName(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.ProgramName value } 
    [<CustomOperation("version")>]
    member this.Version(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Version value } 
    [<CustomOperation("copyright")>]
    member this.Copyright(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Copyright value } 
    [<CustomOperation("comments")>]
    member this.Comments(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Comments value } 
    [<CustomOperation("license")>]
    member this.License(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.License value } 
    [<CustomOperation("licenseType")>]
    member this.LicenseType(it: AboutDialogProperty seq, value: Gtk.License) =
        seq { yield! it; yield AboutDialogProperty.LicenseType value } 
    [<CustomOperation("website")>]
    member this.Website(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Website value } 
    [<CustomOperation("websiteLabel")>]
    member this.WebsiteLabel(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.WebsiteLabel value } 
    [<CustomOperation("authors")>]
    member this.Authors(it: AboutDialogProperty seq, value: System.String[]) =
        seq { yield! it; yield AboutDialogProperty.Authors value } 
    [<CustomOperation("documenters")>]
    member this.Documenters(it: AboutDialogProperty seq, value: System.String[]) =
        seq { yield! it; yield AboutDialogProperty.Documenters value } 
    [<CustomOperation("artists")>]
    member this.Artists(it: AboutDialogProperty seq, value: System.String[]) =
        seq { yield! it; yield AboutDialogProperty.Artists value } 
    [<CustomOperation("translatorCredits")>]
    member this.TranslatorCredits(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.TranslatorCredits value } 
    [<CustomOperation("logo")>]
    member this.Logo(it: AboutDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield AboutDialogProperty.Logo value } 
    [<CustomOperation("logoIconName")>]
    member this.LogoIconName(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.LogoIconName value } 
    [<CustomOperation("wrapLicense")>]
    member this.WrapLicense(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.WrapLicense value } 
    [<CustomOperation("title")>]
    member this.Title(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Title value } 
    [<CustomOperation("role")>]
    member this.Role(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Role value } 
    [<CustomOperation("resizable")>]
    member this.Resizable(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Resizable value } 
    [<CustomOperation("modal")>]
    member this.Modal(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Modal value } 
    [<CustomOperation("windowPosition")>]
    member this.WindowPosition(it: AboutDialogProperty seq, value: Gtk.WindowPosition) =
        seq { yield! it; yield AboutDialogProperty.WindowPosition value } 
    [<CustomOperation("defaultWidth")>]
    member this.DefaultWidth(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.DefaultWidth value } 
    [<CustomOperation("defaultHeight")>]
    member this.DefaultHeight(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.DefaultHeight value } 
    [<CustomOperation("destroyWithParent")>]
    member this.DestroyWithParent(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.DestroyWithParent value } 
    [<CustomOperation("hideTitlebarWhenMaximized")>]
    member this.HideTitlebarWhenMaximized(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.HideTitlebarWhenMaximized value } 
    [<CustomOperation("icon")>]
    member this.Icon(it: AboutDialogProperty seq, value: Gdk.Pixbuf) =
        seq { yield! it; yield AboutDialogProperty.Icon value } 
    [<CustomOperation("mnemonicsVisible")>]
    member this.MnemonicsVisible(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.MnemonicsVisible value } 
    [<CustomOperation("focusVisible")>]
    member this.FocusVisible(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.FocusVisible value } 
    [<CustomOperation("iconName")>]
    member this.IconName(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.IconName value } 
    [<CustomOperation("screen")>]
    member this.Screen(it: AboutDialogProperty seq, value: Gdk.Screen) =
        seq { yield! it; yield AboutDialogProperty.Screen value } 
    [<CustomOperation("typeHint")>]
    member this.TypeHint(it: AboutDialogProperty seq, value: Gdk.WindowTypeHint) =
        seq { yield! it; yield AboutDialogProperty.TypeHint value } 
    [<CustomOperation("skipTaskbarHint")>]
    member this.SkipTaskbarHint(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.SkipTaskbarHint value } 
    [<CustomOperation("skipPagerHint")>]
    member this.SkipPagerHint(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.SkipPagerHint value } 
    [<CustomOperation("urgencyHint")>]
    member this.UrgencyHint(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.UrgencyHint value } 
    [<CustomOperation("acceptFocus")>]
    member this.AcceptFocus(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.AcceptFocus value } 
    [<CustomOperation("focusOnMap")>]
    member this.FocusOnMap(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.FocusOnMap value } 
    [<CustomOperation("decorated")>]
    member this.Decorated(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Decorated value } 
    [<CustomOperation("deletable")>]
    member this.Deletable(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Deletable value } 
    [<Obsolete>]
    [<CustomOperation("hasResizeGrip")>]
    member this.HasResizeGrip(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.HasResizeGrip value } 
    [<CustomOperation("gravity")>]
    member this.Gravity(it: AboutDialogProperty seq, value: Gdk.Gravity) =
        seq { yield! it; yield AboutDialogProperty.Gravity value } 
    [<CustomOperation("transientFor")>]
    member this.TransientFor(it: AboutDialogProperty seq, value: Gtk.Window) =
        seq { yield! it; yield AboutDialogProperty.TransientFor value } 
    [<CustomOperation("attachedTo")>]
    member this.AttachedTo(it: AboutDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AboutDialogProperty.AttachedTo value } 
    [<CustomOperation("application")>]
    member this.Application(it: AboutDialogProperty seq, value: Gtk.Application) =
        seq { yield! it; yield AboutDialogProperty.Application value } 
    [<CustomOperation("decorationResizeHandle")>]
    member this.DecorationResizeHandle(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.DecorationResizeHandle value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: AboutDialogProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield AboutDialogProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: AboutDialogProperty seq, value: System.UInt32) =
        seq { yield! it; yield AboutDialogProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: AboutDialogProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield AboutDialogProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: AboutDialogProperty seq, value: Gtk.Style) =
        seq { yield! it; yield AboutDialogProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: AboutDialogProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield AboutDialogProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: AboutDialogProperty seq, value: System.String) =
        seq { yield! it; yield AboutDialogProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: AboutDialogProperty seq, value: Gdk.Window) =
        seq { yield! it; yield AboutDialogProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: AboutDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AboutDialogProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: AboutDialogProperty seq, value: Gtk.Align) =
        seq { yield! it; yield AboutDialogProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: AboutDialogProperty seq, value: System.Int32) =
        seq { yield! it; yield AboutDialogProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: AboutDialogProperty seq, value: System.Boolean) =
        seq { yield! it; yield AboutDialogProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: AboutDialogProperty seq, value: System.Double) =
        seq { yield! it; yield AboutDialogProperty.Opacity value } 
    [<CustomOperation("onActivateLink")>]
    member this.OnActivateLink(it: AboutDialogProperty seq, value: Gtk.ActivateLinkArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnActivateLink value } 
    [<CustomOperation("onResponse")>]
    member this.OnResponse(it: AboutDialogProperty seq, value: Gtk.ResponseArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnResponse value } 
    [<CustomOperation("onEnableDebugging")>]
    member this.OnEnableDebugging(it: AboutDialogProperty seq, value: Gtk.EnableDebuggingArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnEnableDebugging value } 
    [<CustomOperation("onSetFocus")>]
    member this.OnSetFocus(it: AboutDialogProperty seq, value: Gtk.SetFocusArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSetFocus value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: AboutDialogProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: AboutDialogProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: AboutDialogProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: AboutDialogProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: AboutDialogProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: AboutDialogProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: AboutDialogProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: AboutDialogProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: AboutDialogProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: AboutDialogProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: AboutDialogProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: AboutDialogProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: AboutDialogProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: AboutDialogProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: AboutDialogProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: AboutDialogProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: AboutDialogProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: AboutDialogProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: AboutDialogProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: AboutDialogProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: AboutDialogProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: AboutDialogProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: AboutDialogProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: AboutDialogProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: AboutDialogProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: AboutDialogProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: AboutDialogProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: AboutDialogProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: AboutDialogProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: AboutDialogProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: AboutDialogProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: AboutDialogProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: AboutDialogProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: AboutDialogProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: AboutDialogProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: AboutDialogProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: AboutDialogProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: AboutDialogProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: AboutDialogProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: AboutDialogProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: AboutDialogProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: AboutDialogProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: AboutDialogProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: AboutDialogProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: AboutDialogProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: AboutDialogProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: AboutDialogProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: AboutDialogProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: AboutDialogProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: AboutDialogProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: AboutDialogProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: AboutDialogProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: AboutDialogProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: AboutDialogProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: AboutDialogProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: AboutDialogProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: AboutDialogProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: AboutDialogProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: AboutDialogProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: AboutDialogProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield AboutDialogProperty.OnFocused value } 

let prop = AboutDialogPropertyBuilder()

type AboutDialogDescriptor(props) =
    inherit BaseWidgetDescriptor<AboutDialog, AboutDialogProperty>(props, bindProperty)
    override this.CreateTyped() = new AboutDialog()

let aboutDialog props = AboutDialogDescriptor(props)

