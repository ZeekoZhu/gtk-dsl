module Gtk.DSL.Binding.PlacesSidebar
open System
open Gtk
open Gtk.DSL.Core

#nowarn "0044"
[<RequireQualifiedAccess>]
type PlacesSidebarProperty =
    | Location of GLib.IFile
    | OpenFlags of Gtk.PlacesOpenFlags
    | ShowRecent of System.Boolean
    | ShowDesktop of System.Boolean
    | [<Obsolete>] ShowConnectToServer of System.Boolean
    | ShowEnterLocation of System.Boolean
    | LocalOnly of System.Boolean
    | ShowTrash of System.Boolean
    | ShowOtherLocations of System.Boolean
    | PopulateAll of System.Boolean
    | Hadjustment of Gtk.Adjustment
    | Vadjustment of Gtk.Adjustment
    | HscrollbarPolicy of Gtk.PolicyType
    | VscrollbarPolicy of Gtk.PolicyType
    | WindowPlacement of Gtk.CornerType
    | WindowPlacementSet of System.Boolean
    | ShadowType of Gtk.ShadowType
    | MinContentWidth of System.Int32
    | MinContentHeight of System.Int32
    | KineticScrolling of System.Boolean
    | OverlayScrolling of System.Boolean
    | MaxContentWidth of System.Int32
    | MaxContentHeight of System.Int32
    | PropagateNaturalWidth of System.Boolean
    | PropagateNaturalHeight of System.Boolean
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
    |  OnDragActionAsk of (Gtk.DragActionAskArgs -> unit)
    |  OnMount of (Gtk.MountArgs -> unit)
    |  OnUnmount of (Gtk.UnmountArgs -> unit)
    |  OnShowErrorMessage of (Gtk.ShowErrorMessageArgs -> unit)
    |  OnOpenLocation of (Gtk.OpenLocationArgs -> unit)
    |  OnDragActionRequested of (Gtk.DragActionRequestedArgs -> unit)
    |  OnPopulatePopup of (Gtk.PopulatePopupArgs -> unit)
    |  OnShowOtherLocationsWithFlags of (Gtk.ShowOtherLocationsWithFlagsArgs -> unit)
    |  OnDragPerformDrop of (Gtk.DragPerformDropArgs -> unit)
    |  OnScrollChild of (Gtk.ScrollChildArgs -> unit)
    |  OnEdgeOvershot of (Gtk.EdgeOvershotArgs -> unit)
    |  OnMoveFocusOut of (Gtk.MoveFocusOutArgs -> unit)
    |  OnEdgeReached of (Gtk.EdgeReachedArgs -> unit)
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

let bindProperty (widget: PlacesSidebar) (prop: PlacesSidebarProperty) =
    match prop with
    | PlacesSidebarProperty.Location value -> widget.Location <- value
    | PlacesSidebarProperty.OpenFlags value -> widget.OpenFlags <- value
    | PlacesSidebarProperty.ShowRecent value -> widget.ShowRecent <- value
    | PlacesSidebarProperty.ShowDesktop value -> widget.ShowDesktop <- value
    | PlacesSidebarProperty.ShowConnectToServer value -> widget.ShowConnectToServer <- value
    | PlacesSidebarProperty.ShowEnterLocation value -> widget.ShowEnterLocation <- value
    | PlacesSidebarProperty.LocalOnly value -> widget.LocalOnly <- value
    | PlacesSidebarProperty.ShowTrash value -> widget.ShowTrash <- value
    | PlacesSidebarProperty.ShowOtherLocations value -> widget.ShowOtherLocations <- value
    | PlacesSidebarProperty.PopulateAll value -> widget.PopulateAll <- value
    | PlacesSidebarProperty.Hadjustment value -> widget.Hadjustment <- value
    | PlacesSidebarProperty.Vadjustment value -> widget.Vadjustment <- value
    | PlacesSidebarProperty.HscrollbarPolicy value -> widget.HscrollbarPolicy <- value
    | PlacesSidebarProperty.VscrollbarPolicy value -> widget.VscrollbarPolicy <- value
    | PlacesSidebarProperty.WindowPlacement value -> widget.WindowPlacement <- value
    | PlacesSidebarProperty.WindowPlacementSet value -> widget.WindowPlacementSet <- value
    | PlacesSidebarProperty.ShadowType value -> widget.ShadowType <- value
    | PlacesSidebarProperty.MinContentWidth value -> widget.MinContentWidth <- value
    | PlacesSidebarProperty.MinContentHeight value -> widget.MinContentHeight <- value
    | PlacesSidebarProperty.KineticScrolling value -> widget.KineticScrolling <- value
    | PlacesSidebarProperty.OverlayScrolling value -> widget.OverlayScrolling <- value
    | PlacesSidebarProperty.MaxContentWidth value -> widget.MaxContentWidth <- value
    | PlacesSidebarProperty.MaxContentHeight value -> widget.MaxContentHeight <- value
    | PlacesSidebarProperty.PropagateNaturalWidth value -> widget.PropagateNaturalWidth <- value
    | PlacesSidebarProperty.PropagateNaturalHeight value -> widget.PropagateNaturalHeight <- value
    | PlacesSidebarProperty.ResizeMode value -> widget.ResizeMode <- value
    | PlacesSidebarProperty.BorderWidth value -> widget.BorderWidth <- value
    | PlacesSidebarProperty.Name value -> widget.Name <- value
    | PlacesSidebarProperty.Parent value -> widget.Parent <- value
    | PlacesSidebarProperty.WidthRequest value -> widget.WidthRequest <- value
    | PlacesSidebarProperty.HeightRequest value -> widget.HeightRequest <- value
    | PlacesSidebarProperty.Visible value -> widget.Visible <- value
    | PlacesSidebarProperty.Sensitive value -> widget.Sensitive <- value
    | PlacesSidebarProperty.AppPaintable value -> widget.AppPaintable <- value
    | PlacesSidebarProperty.CanFocus value -> widget.CanFocus <- value
    | PlacesSidebarProperty.HasFocus value -> widget.HasFocus <- value
    | PlacesSidebarProperty.IsFocus value -> widget.IsFocus <- value
    | PlacesSidebarProperty.FocusOnClick value -> widget.FocusOnClick <- value
    | PlacesSidebarProperty.CanDefault value -> widget.CanDefault <- value
    | PlacesSidebarProperty.HasDefault value -> widget.HasDefault <- value
    | PlacesSidebarProperty.ReceivesDefault value -> widget.ReceivesDefault <- value
    | PlacesSidebarProperty.Style value -> widget.Style <- value
    | PlacesSidebarProperty.Events value -> widget.Events <- value
    | PlacesSidebarProperty.NoShowAll value -> widget.NoShowAll <- value
    | PlacesSidebarProperty.HasTooltip value -> widget.HasTooltip <- value
    | PlacesSidebarProperty.TooltipText value -> widget.TooltipText <- value
    | PlacesSidebarProperty.TooltipMarkup value -> widget.TooltipMarkup <- value
    | PlacesSidebarProperty.Window value -> widget.Window <- value
    | PlacesSidebarProperty.DoubleBuffered value -> widget.DoubleBuffered <- value
    | PlacesSidebarProperty.Halign value -> widget.Halign <- value
    | PlacesSidebarProperty.Valign value -> widget.Valign <- value
    | PlacesSidebarProperty.MarginLeft value -> widget.MarginLeft <- value
    | PlacesSidebarProperty.MarginRight value -> widget.MarginRight <- value
    | PlacesSidebarProperty.MarginStart value -> widget.MarginStart <- value
    | PlacesSidebarProperty.MarginEnd value -> widget.MarginEnd <- value
    | PlacesSidebarProperty.MarginTop value -> widget.MarginTop <- value
    | PlacesSidebarProperty.MarginBottom value -> widget.MarginBottom <- value
    | PlacesSidebarProperty.Margin value -> widget.Margin <- value
    | PlacesSidebarProperty.Hexpand value -> widget.Hexpand <- value
    | PlacesSidebarProperty.HexpandSet value -> widget.HexpandSet <- value
    | PlacesSidebarProperty.Vexpand value -> widget.Vexpand <- value
    | PlacesSidebarProperty.VexpandSet value -> widget.VexpandSet <- value
    | PlacesSidebarProperty.Expand value -> widget.Expand <- value
    | PlacesSidebarProperty.Opacity value -> widget.Opacity <- value
    | PlacesSidebarProperty.OnDragActionAsk handler -> 
        let disposable = widget.DragActionAsk.Subscribe(handler)
        registerListener widget "DragActionAsk" disposable
    | PlacesSidebarProperty.OnMount handler -> 
        let disposable = widget.Mount.Subscribe(handler)
        registerListener widget "Mount" disposable
    | PlacesSidebarProperty.OnUnmount handler -> 
        let disposable = widget.Unmount.Subscribe(handler)
        registerListener widget "Unmount" disposable
    | PlacesSidebarProperty.OnShowErrorMessage handler -> 
        let disposable = widget.ShowErrorMessage.Subscribe(handler)
        registerListener widget "ShowErrorMessage" disposable
    | PlacesSidebarProperty.OnOpenLocation handler -> 
        let disposable = widget.OpenLocation.Subscribe(handler)
        registerListener widget "OpenLocation" disposable
    | PlacesSidebarProperty.OnDragActionRequested handler -> 
        let disposable = widget.DragActionRequested.Subscribe(handler)
        registerListener widget "DragActionRequested" disposable
    | PlacesSidebarProperty.OnPopulatePopup handler -> 
        let disposable = widget.PopulatePopup.Subscribe(handler)
        registerListener widget "PopulatePopup" disposable
    | PlacesSidebarProperty.OnShowOtherLocationsWithFlags handler -> 
        let disposable = widget.ShowOtherLocationsWithFlags.Subscribe(handler)
        registerListener widget "ShowOtherLocationsWithFlags" disposable
    | PlacesSidebarProperty.OnDragPerformDrop handler -> 
        let disposable = widget.DragPerformDrop.Subscribe(handler)
        registerListener widget "DragPerformDrop" disposable
    | PlacesSidebarProperty.OnScrollChild handler -> 
        let disposable = widget.ScrollChild.Subscribe(handler)
        registerListener widget "ScrollChild" disposable
    | PlacesSidebarProperty.OnEdgeOvershot handler -> 
        let disposable = widget.EdgeOvershot.Subscribe(handler)
        registerListener widget "EdgeOvershot" disposable
    | PlacesSidebarProperty.OnMoveFocusOut handler -> 
        let disposable = widget.MoveFocusOut.Subscribe(handler)
        registerListener widget "MoveFocusOut" disposable
    | PlacesSidebarProperty.OnEdgeReached handler -> 
        let disposable = widget.EdgeReached.Subscribe(handler)
        registerListener widget "EdgeReached" disposable
    | PlacesSidebarProperty.OnFocusChildSet handler -> 
        let disposable = widget.FocusChildSet.Subscribe(handler)
        registerListener widget "FocusChildSet" disposable
    | PlacesSidebarProperty.OnRemoved handler -> 
        let disposable = widget.Removed.Subscribe(handler)
        registerListener widget "Removed" disposable
    | PlacesSidebarProperty.OnAdded handler -> 
        let disposable = widget.Added.Subscribe(handler)
        registerListener widget "Added" disposable
    | PlacesSidebarProperty.OnDamageEvent handler -> 
        let disposable = widget.DamageEvent.Subscribe(handler)
        registerListener widget "DamageEvent" disposable
    | PlacesSidebarProperty.OnSizeAllocated handler -> 
        let disposable = widget.SizeAllocated.Subscribe(handler)
        registerListener widget "SizeAllocated" disposable
    | PlacesSidebarProperty.OnProximityOutEvent handler -> 
        let disposable = widget.ProximityOutEvent.Subscribe(handler)
        registerListener widget "ProximityOutEvent" disposable
    | PlacesSidebarProperty.OnDeleteEvent handler -> 
        let disposable = widget.DeleteEvent.Subscribe(handler)
        registerListener widget "DeleteEvent" disposable
    | PlacesSidebarProperty.OnDragMotion handler -> 
        let disposable = widget.DragMotion.Subscribe(handler)
        registerListener widget "DragMotion" disposable
    | PlacesSidebarProperty.OnStateFlagsChanged handler -> 
        let disposable = widget.StateFlagsChanged.Subscribe(handler)
        registerListener widget "StateFlagsChanged" disposable
    | PlacesSidebarProperty.OnGrabNotify handler -> 
        let disposable = widget.GrabNotify.Subscribe(handler)
        registerListener widget "GrabNotify" disposable
    | PlacesSidebarProperty.OnConfigureEvent handler -> 
        let disposable = widget.ConfigureEvent.Subscribe(handler)
        registerListener widget "ConfigureEvent" disposable
    | PlacesSidebarProperty.OnButtonPressEvent handler -> 
        let disposable = widget.ButtonPressEvent.Subscribe(handler)
        registerListener widget "ButtonPressEvent" disposable
    | PlacesSidebarProperty.OnFocusOutEvent handler -> 
        let disposable = widget.FocusOutEvent.Subscribe(handler)
        registerListener widget "FocusOutEvent" disposable
    | PlacesSidebarProperty.OnUnmapEvent handler -> 
        let disposable = widget.UnmapEvent.Subscribe(handler)
        registerListener widget "UnmapEvent" disposable
    | PlacesSidebarProperty.OnHelpShown handler -> 
        let disposable = widget.HelpShown.Subscribe(handler)
        registerListener widget "HelpShown" disposable
    | PlacesSidebarProperty.OnMoveFocus handler -> 
        let disposable = widget.MoveFocus.Subscribe(handler)
        registerListener widget "MoveFocus" disposable
    | PlacesSidebarProperty.OnScrollEvent handler -> 
        let disposable = widget.ScrollEvent.Subscribe(handler)
        registerListener widget "ScrollEvent" disposable
    | PlacesSidebarProperty.OnSelectionReceived handler -> 
        let disposable = widget.SelectionReceived.Subscribe(handler)
        registerListener widget "SelectionReceived" disposable
    | PlacesSidebarProperty.OnDirectionChanged handler -> 
        let disposable = widget.DirectionChanged.Subscribe(handler)
        registerListener widget "DirectionChanged" disposable
    | PlacesSidebarProperty.OnPropertyNotifyEvent handler -> 
        let disposable = widget.PropertyNotifyEvent.Subscribe(handler)
        registerListener widget "PropertyNotifyEvent" disposable
    | PlacesSidebarProperty.OnDragDrop handler -> 
        let disposable = widget.DragDrop.Subscribe(handler)
        registerListener widget "DragDrop" disposable
    | PlacesSidebarProperty.OnStyleSet handler -> 
        let disposable = widget.StyleSet.Subscribe(handler)
        registerListener widget "StyleSet" disposable
    | PlacesSidebarProperty.OnParentSet handler -> 
        let disposable = widget.ParentSet.Subscribe(handler)
        registerListener widget "ParentSet" disposable
    | PlacesSidebarProperty.OnDragDataReceived handler -> 
        let disposable = widget.DragDataReceived.Subscribe(handler)
        registerListener widget "DragDataReceived" disposable
    | PlacesSidebarProperty.OnTouchEvent handler -> 
        let disposable = widget.TouchEvent.Subscribe(handler)
        registerListener widget "TouchEvent" disposable
    | PlacesSidebarProperty.OnDrawn handler -> 
        let disposable = widget.Drawn.Subscribe(handler)
        registerListener widget "Drawn" disposable
    | PlacesSidebarProperty.OnSelectionRequestEvent handler -> 
        let disposable = widget.SelectionRequestEvent.Subscribe(handler)
        registerListener widget "SelectionRequestEvent" disposable
    | PlacesSidebarProperty.OnEnterNotifyEvent handler -> 
        let disposable = widget.EnterNotifyEvent.Subscribe(handler)
        registerListener widget "EnterNotifyEvent" disposable
    | PlacesSidebarProperty.OnDragDataDelete handler -> 
        let disposable = widget.DragDataDelete.Subscribe(handler)
        registerListener widget "DragDataDelete" disposable
    | PlacesSidebarProperty.OnScreenChanged handler -> 
        let disposable = widget.ScreenChanged.Subscribe(handler)
        registerListener widget "ScreenChanged" disposable
    | PlacesSidebarProperty.OnWidgetEvent handler -> 
        let disposable = widget.WidgetEvent.Subscribe(handler)
        registerListener widget "WidgetEvent" disposable
    | PlacesSidebarProperty.OnSelectionClearEvent handler -> 
        let disposable = widget.SelectionClearEvent.Subscribe(handler)
        registerListener widget "SelectionClearEvent" disposable
    | PlacesSidebarProperty.OnChildNotified handler -> 
        let disposable = widget.ChildNotified.Subscribe(handler)
        registerListener widget "ChildNotified" disposable
    | PlacesSidebarProperty.OnWindowStateEvent handler -> 
        let disposable = widget.WindowStateEvent.Subscribe(handler)
        registerListener widget "WindowStateEvent" disposable
    | PlacesSidebarProperty.OnDestroyEvent handler -> 
        let disposable = widget.DestroyEvent.Subscribe(handler)
        registerListener widget "DestroyEvent" disposable
    | PlacesSidebarProperty.OnSelectionGet handler -> 
        let disposable = widget.SelectionGet.Subscribe(handler)
        registerListener widget "SelectionGet" disposable
    | PlacesSidebarProperty.OnGrabBrokenEvent handler -> 
        let disposable = widget.GrabBrokenEvent.Subscribe(handler)
        registerListener widget "GrabBrokenEvent" disposable
    | PlacesSidebarProperty.OnDragLeave handler -> 
        let disposable = widget.DragLeave.Subscribe(handler)
        registerListener widget "DragLeave" disposable
    | PlacesSidebarProperty.OnVisibilityNotifyEvent handler -> 
        let disposable = widget.VisibilityNotifyEvent.Subscribe(handler)
        registerListener widget "VisibilityNotifyEvent" disposable
    | PlacesSidebarProperty.OnMotionNotifyEvent handler -> 
        let disposable = widget.MotionNotifyEvent.Subscribe(handler)
        registerListener widget "MotionNotifyEvent" disposable
    | PlacesSidebarProperty.OnKeyReleaseEvent handler -> 
        let disposable = widget.KeyReleaseEvent.Subscribe(handler)
        registerListener widget "KeyReleaseEvent" disposable
    | PlacesSidebarProperty.OnQueryTooltip handler -> 
        let disposable = widget.QueryTooltip.Subscribe(handler)
        registerListener widget "QueryTooltip" disposable
    | PlacesSidebarProperty.OnMapEvent handler -> 
        let disposable = widget.MapEvent.Subscribe(handler)
        registerListener widget "MapEvent" disposable
    | PlacesSidebarProperty.OnFocusInEvent handler -> 
        let disposable = widget.FocusInEvent.Subscribe(handler)
        registerListener widget "FocusInEvent" disposable
    | PlacesSidebarProperty.OnHierarchyChanged handler -> 
        let disposable = widget.HierarchyChanged.Subscribe(handler)
        registerListener widget "HierarchyChanged" disposable
    | PlacesSidebarProperty.OnStateChanged handler -> 
        let disposable = widget.StateChanged.Subscribe(handler)
        registerListener widget "StateChanged" disposable
    | PlacesSidebarProperty.OnDragDataGet handler -> 
        let disposable = widget.DragDataGet.Subscribe(handler)
        registerListener widget "DragDataGet" disposable
    | PlacesSidebarProperty.OnPopupMenu handler -> 
        let disposable = widget.PopupMenu.Subscribe(handler)
        registerListener widget "PopupMenu" disposable
    | PlacesSidebarProperty.OnAccelCanActivate handler -> 
        let disposable = widget.AccelCanActivate.Subscribe(handler)
        registerListener widget "AccelCanActivate" disposable
    | PlacesSidebarProperty.OnDragEnd handler -> 
        let disposable = widget.DragEnd.Subscribe(handler)
        registerListener widget "DragEnd" disposable
    | PlacesSidebarProperty.OnLeaveNotifyEvent handler -> 
        let disposable = widget.LeaveNotifyEvent.Subscribe(handler)
        registerListener widget "LeaveNotifyEvent" disposable
    | PlacesSidebarProperty.OnMnemonicActivated handler -> 
        let disposable = widget.MnemonicActivated.Subscribe(handler)
        registerListener widget "MnemonicActivated" disposable
    | PlacesSidebarProperty.OnKeyPressEvent handler -> 
        let disposable = widget.KeyPressEvent.Subscribe(handler)
        registerListener widget "KeyPressEvent" disposable
    | PlacesSidebarProperty.OnDragBegin handler -> 
        let disposable = widget.DragBegin.Subscribe(handler)
        registerListener widget "DragBegin" disposable
    | PlacesSidebarProperty.OnWidgetEventAfter handler -> 
        let disposable = widget.WidgetEventAfter.Subscribe(handler)
        registerListener widget "WidgetEventAfter" disposable
    | PlacesSidebarProperty.OnProximityInEvent handler -> 
        let disposable = widget.ProximityInEvent.Subscribe(handler)
        registerListener widget "ProximityInEvent" disposable
    | PlacesSidebarProperty.OnButtonReleaseEvent handler -> 
        let disposable = widget.ButtonReleaseEvent.Subscribe(handler)
        registerListener widget "ButtonReleaseEvent" disposable
    | PlacesSidebarProperty.OnDragFailed handler -> 
        let disposable = widget.DragFailed.Subscribe(handler)
        registerListener widget "DragFailed" disposable
    | PlacesSidebarProperty.OnSelectionNotifyEvent handler -> 
        let disposable = widget.SelectionNotifyEvent.Subscribe(handler)
        registerListener widget "SelectionNotifyEvent" disposable
    | PlacesSidebarProperty.OnFocused handler -> 
        let disposable = widget.Focused.Subscribe(handler)
        registerListener widget "Focused" disposable

type PlacesSidebarPropertyBuilder() =
    inherit BasePropertyBuilder<PlacesSidebarProperty>()
    [<CustomOperation("location")>]
    member this.Location(it: PlacesSidebarProperty seq, value: GLib.IFile) =
        seq { yield! it; yield PlacesSidebarProperty.Location value } 
    [<CustomOperation("openFlags")>]
    member this.OpenFlags(it: PlacesSidebarProperty seq, value: Gtk.PlacesOpenFlags) =
        seq { yield! it; yield PlacesSidebarProperty.OpenFlags value } 
    [<CustomOperation("showRecent")>]
    member this.ShowRecent(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ShowRecent value } 
    [<CustomOperation("showDesktop")>]
    member this.ShowDesktop(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ShowDesktop value } 
    [<Obsolete>]
    [<CustomOperation("showConnectToServer")>]
    member this.ShowConnectToServer(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ShowConnectToServer value } 
    [<CustomOperation("showEnterLocation")>]
    member this.ShowEnterLocation(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ShowEnterLocation value } 
    [<CustomOperation("localOnly")>]
    member this.LocalOnly(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.LocalOnly value } 
    [<CustomOperation("showTrash")>]
    member this.ShowTrash(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ShowTrash value } 
    [<CustomOperation("showOtherLocations")>]
    member this.ShowOtherLocations(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ShowOtherLocations value } 
    [<CustomOperation("populateAll")>]
    member this.PopulateAll(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.PopulateAll value } 
    [<CustomOperation("hadjustment")>]
    member this.Hadjustment(it: PlacesSidebarProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield PlacesSidebarProperty.Hadjustment value } 
    [<CustomOperation("vadjustment")>]
    member this.Vadjustment(it: PlacesSidebarProperty seq, value: Gtk.Adjustment) =
        seq { yield! it; yield PlacesSidebarProperty.Vadjustment value } 
    [<CustomOperation("hscrollbarPolicy")>]
    member this.HscrollbarPolicy(it: PlacesSidebarProperty seq, value: Gtk.PolicyType) =
        seq { yield! it; yield PlacesSidebarProperty.HscrollbarPolicy value } 
    [<CustomOperation("vscrollbarPolicy")>]
    member this.VscrollbarPolicy(it: PlacesSidebarProperty seq, value: Gtk.PolicyType) =
        seq { yield! it; yield PlacesSidebarProperty.VscrollbarPolicy value } 
    [<CustomOperation("windowPlacement")>]
    member this.WindowPlacement(it: PlacesSidebarProperty seq, value: Gtk.CornerType) =
        seq { yield! it; yield PlacesSidebarProperty.WindowPlacement value } 
    [<CustomOperation("windowPlacementSet")>]
    member this.WindowPlacementSet(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.WindowPlacementSet value } 
    [<CustomOperation("shadowType")>]
    member this.ShadowType(it: PlacesSidebarProperty seq, value: Gtk.ShadowType) =
        seq { yield! it; yield PlacesSidebarProperty.ShadowType value } 
    [<CustomOperation("minContentWidth")>]
    member this.MinContentWidth(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MinContentWidth value } 
    [<CustomOperation("minContentHeight")>]
    member this.MinContentHeight(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MinContentHeight value } 
    [<CustomOperation("kineticScrolling")>]
    member this.KineticScrolling(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.KineticScrolling value } 
    [<CustomOperation("overlayScrolling")>]
    member this.OverlayScrolling(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.OverlayScrolling value } 
    [<CustomOperation("maxContentWidth")>]
    member this.MaxContentWidth(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MaxContentWidth value } 
    [<CustomOperation("maxContentHeight")>]
    member this.MaxContentHeight(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MaxContentHeight value } 
    [<CustomOperation("propagateNaturalWidth")>]
    member this.PropagateNaturalWidth(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.PropagateNaturalWidth value } 
    [<CustomOperation("propagateNaturalHeight")>]
    member this.PropagateNaturalHeight(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.PropagateNaturalHeight value } 
    [<Obsolete>]
    [<CustomOperation("resizeMode")>]
    member this.ResizeMode(it: PlacesSidebarProperty seq, value: Gtk.ResizeMode) =
        seq { yield! it; yield PlacesSidebarProperty.ResizeMode value } 
    [<CustomOperation("borderWidth")>]
    member this.BorderWidth(it: PlacesSidebarProperty seq, value: System.UInt32) =
        seq { yield! it; yield PlacesSidebarProperty.BorderWidth value } 
    [<CustomOperation("name")>]
    member this.Name(it: PlacesSidebarProperty seq, value: System.String) =
        seq { yield! it; yield PlacesSidebarProperty.Name value } 
    [<CustomOperation("parent")>]
    member this.Parent(it: PlacesSidebarProperty seq, value: Gtk.Widget) =
        seq { yield! it; yield PlacesSidebarProperty.Parent value } 
    [<CustomOperation("widthRequest")>]
    member this.WidthRequest(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.WidthRequest value } 
    [<CustomOperation("heightRequest")>]
    member this.HeightRequest(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.HeightRequest value } 
    [<CustomOperation("visible")>]
    member this.Visible(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.Visible value } 
    [<CustomOperation("sensitive")>]
    member this.Sensitive(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.Sensitive value } 
    [<CustomOperation("appPaintable")>]
    member this.AppPaintable(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.AppPaintable value } 
    [<CustomOperation("canFocus")>]
    member this.CanFocus(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.CanFocus value } 
    [<CustomOperation("hasFocus")>]
    member this.HasFocus(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.HasFocus value } 
    [<CustomOperation("isFocus")>]
    member this.IsFocus(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.IsFocus value } 
    [<CustomOperation("focusOnClick")>]
    member this.FocusOnClick(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.FocusOnClick value } 
    [<CustomOperation("canDefault")>]
    member this.CanDefault(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.CanDefault value } 
    [<CustomOperation("hasDefault")>]
    member this.HasDefault(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.HasDefault value } 
    [<CustomOperation("receivesDefault")>]
    member this.ReceivesDefault(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.ReceivesDefault value } 
    [<Obsolete>]
    [<CustomOperation("style")>]
    member this.Style(it: PlacesSidebarProperty seq, value: Gtk.Style) =
        seq { yield! it; yield PlacesSidebarProperty.Style value } 
    [<CustomOperation("events")>]
    member this.Events(it: PlacesSidebarProperty seq, value: Gdk.EventMask) =
        seq { yield! it; yield PlacesSidebarProperty.Events value } 
    [<CustomOperation("noShowAll")>]
    member this.NoShowAll(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.NoShowAll value } 
    [<CustomOperation("hasTooltip")>]
    member this.HasTooltip(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.HasTooltip value } 
    [<CustomOperation("tooltipText")>]
    member this.TooltipText(it: PlacesSidebarProperty seq, value: System.String) =
        seq { yield! it; yield PlacesSidebarProperty.TooltipText value } 
    [<CustomOperation("tooltipMarkup")>]
    member this.TooltipMarkup(it: PlacesSidebarProperty seq, value: System.String) =
        seq { yield! it; yield PlacesSidebarProperty.TooltipMarkup value } 
    [<CustomOperation("window")>]
    member this.Window(it: PlacesSidebarProperty seq, value: Gdk.Window) =
        seq { yield! it; yield PlacesSidebarProperty.Window value } 
    [<Obsolete>]
    [<CustomOperation("doubleBuffered")>]
    member this.DoubleBuffered(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.DoubleBuffered value } 
    [<CustomOperation("halign")>]
    member this.Halign(it: PlacesSidebarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PlacesSidebarProperty.Halign value } 
    [<CustomOperation("valign")>]
    member this.Valign(it: PlacesSidebarProperty seq, value: Gtk.Align) =
        seq { yield! it; yield PlacesSidebarProperty.Valign value } 
    [<Obsolete>]
    [<CustomOperation("marginLeft")>]
    member this.MarginLeft(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MarginLeft value } 
    [<Obsolete>]
    [<CustomOperation("marginRight")>]
    member this.MarginRight(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MarginRight value } 
    [<CustomOperation("marginStart")>]
    member this.MarginStart(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MarginStart value } 
    [<CustomOperation("marginEnd")>]
    member this.MarginEnd(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MarginEnd value } 
    [<CustomOperation("marginTop")>]
    member this.MarginTop(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MarginTop value } 
    [<CustomOperation("marginBottom")>]
    member this.MarginBottom(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.MarginBottom value } 
    [<CustomOperation("margin")>]
    member this.Margin(it: PlacesSidebarProperty seq, value: System.Int32) =
        seq { yield! it; yield PlacesSidebarProperty.Margin value } 
    [<CustomOperation("hexpand")>]
    member this.Hexpand(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.Hexpand value } 
    [<CustomOperation("hexpandSet")>]
    member this.HexpandSet(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.HexpandSet value } 
    [<CustomOperation("vexpand")>]
    member this.Vexpand(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.Vexpand value } 
    [<CustomOperation("vexpandSet")>]
    member this.VexpandSet(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.VexpandSet value } 
    [<CustomOperation("expand")>]
    member this.Expand(it: PlacesSidebarProperty seq, value: System.Boolean) =
        seq { yield! it; yield PlacesSidebarProperty.Expand value } 
    [<CustomOperation("opacity")>]
    member this.Opacity(it: PlacesSidebarProperty seq, value: System.Double) =
        seq { yield! it; yield PlacesSidebarProperty.Opacity value } 
    [<CustomOperation("onDragActionAsk")>]
    member this.OnDragActionAsk(it: PlacesSidebarProperty seq, value: Gtk.DragActionAskArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragActionAsk value } 
    [<CustomOperation("onMount")>]
    member this.OnMount(it: PlacesSidebarProperty seq, value: Gtk.MountArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnMount value } 
    [<CustomOperation("onUnmount")>]
    member this.OnUnmount(it: PlacesSidebarProperty seq, value: Gtk.UnmountArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnUnmount value } 
    [<CustomOperation("onShowErrorMessage")>]
    member this.OnShowErrorMessage(it: PlacesSidebarProperty seq, value: Gtk.ShowErrorMessageArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnShowErrorMessage value } 
    [<CustomOperation("onOpenLocation")>]
    member this.OnOpenLocation(it: PlacesSidebarProperty seq, value: Gtk.OpenLocationArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnOpenLocation value } 
    [<CustomOperation("onDragActionRequested")>]
    member this.OnDragActionRequested(it: PlacesSidebarProperty seq, value: Gtk.DragActionRequestedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragActionRequested value } 
    [<CustomOperation("onPopulatePopup")>]
    member this.OnPopulatePopup(it: PlacesSidebarProperty seq, value: Gtk.PopulatePopupArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnPopulatePopup value } 
    [<CustomOperation("onShowOtherLocationsWithFlags")>]
    member this.OnShowOtherLocationsWithFlags(it: PlacesSidebarProperty seq, value: Gtk.ShowOtherLocationsWithFlagsArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnShowOtherLocationsWithFlags value } 
    [<CustomOperation("onDragPerformDrop")>]
    member this.OnDragPerformDrop(it: PlacesSidebarProperty seq, value: Gtk.DragPerformDropArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragPerformDrop value } 
    [<CustomOperation("onScrollChild")>]
    member this.OnScrollChild(it: PlacesSidebarProperty seq, value: Gtk.ScrollChildArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnScrollChild value } 
    [<CustomOperation("onEdgeOvershot")>]
    member this.OnEdgeOvershot(it: PlacesSidebarProperty seq, value: Gtk.EdgeOvershotArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnEdgeOvershot value } 
    [<CustomOperation("onMoveFocusOut")>]
    member this.OnMoveFocusOut(it: PlacesSidebarProperty seq, value: Gtk.MoveFocusOutArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnMoveFocusOut value } 
    [<CustomOperation("onEdgeReached")>]
    member this.OnEdgeReached(it: PlacesSidebarProperty seq, value: Gtk.EdgeReachedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnEdgeReached value } 
    [<CustomOperation("onFocusChildSet")>]
    member this.OnFocusChildSet(it: PlacesSidebarProperty seq, value: Gtk.FocusChildSetArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnFocusChildSet value } 
    [<CustomOperation("onRemoved")>]
    member this.OnRemoved(it: PlacesSidebarProperty seq, value: Gtk.RemovedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnRemoved value } 
    [<CustomOperation("onAdded")>]
    member this.OnAdded(it: PlacesSidebarProperty seq, value: Gtk.AddedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnAdded value } 
    [<CustomOperation("onDamageEvent")>]
    member this.OnDamageEvent(it: PlacesSidebarProperty seq, value: Gtk.DamageEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDamageEvent value } 
    [<CustomOperation("onSizeAllocated")>]
    member this.OnSizeAllocated(it: PlacesSidebarProperty seq, value: Gtk.SizeAllocatedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnSizeAllocated value } 
    [<CustomOperation("onProximityOutEvent")>]
    member this.OnProximityOutEvent(it: PlacesSidebarProperty seq, value: Gtk.ProximityOutEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnProximityOutEvent value } 
    [<CustomOperation("onDeleteEvent")>]
    member this.OnDeleteEvent(it: PlacesSidebarProperty seq, value: Gtk.DeleteEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDeleteEvent value } 
    [<CustomOperation("onDragMotion")>]
    member this.OnDragMotion(it: PlacesSidebarProperty seq, value: Gtk.DragMotionArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragMotion value } 
    [<CustomOperation("onStateFlagsChanged")>]
    member this.OnStateFlagsChanged(it: PlacesSidebarProperty seq, value: Gtk.StateFlagsChangedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnStateFlagsChanged value } 
    [<CustomOperation("onGrabNotify")>]
    member this.OnGrabNotify(it: PlacesSidebarProperty seq, value: Gtk.GrabNotifyArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnGrabNotify value } 
    [<CustomOperation("onConfigureEvent")>]
    member this.OnConfigureEvent(it: PlacesSidebarProperty seq, value: Gtk.ConfigureEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnConfigureEvent value } 
    [<CustomOperation("onButtonPressEvent")>]
    member this.OnButtonPressEvent(it: PlacesSidebarProperty seq, value: Gtk.ButtonPressEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnButtonPressEvent value } 
    [<CustomOperation("onFocusOutEvent")>]
    member this.OnFocusOutEvent(it: PlacesSidebarProperty seq, value: Gtk.FocusOutEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnFocusOutEvent value } 
    [<CustomOperation("onUnmapEvent")>]
    member this.OnUnmapEvent(it: PlacesSidebarProperty seq, value: Gtk.UnmapEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnUnmapEvent value } 
    [<CustomOperation("onHelpShown")>]
    member this.OnHelpShown(it: PlacesSidebarProperty seq, value: Gtk.HelpShownArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnHelpShown value } 
    [<CustomOperation("onMoveFocus")>]
    member this.OnMoveFocus(it: PlacesSidebarProperty seq, value: Gtk.MoveFocusArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnMoveFocus value } 
    [<CustomOperation("onScrollEvent")>]
    member this.OnScrollEvent(it: PlacesSidebarProperty seq, value: Gtk.ScrollEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnScrollEvent value } 
    [<CustomOperation("onSelectionReceived")>]
    member this.OnSelectionReceived(it: PlacesSidebarProperty seq, value: Gtk.SelectionReceivedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnSelectionReceived value } 
    [<CustomOperation("onDirectionChanged")>]
    member this.OnDirectionChanged(it: PlacesSidebarProperty seq, value: Gtk.DirectionChangedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDirectionChanged value } 
    [<CustomOperation("onPropertyNotifyEvent")>]
    member this.OnPropertyNotifyEvent(it: PlacesSidebarProperty seq, value: Gtk.PropertyNotifyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnPropertyNotifyEvent value } 
    [<CustomOperation("onDragDrop")>]
    member this.OnDragDrop(it: PlacesSidebarProperty seq, value: Gtk.DragDropArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragDrop value } 
    [<CustomOperation("onStyleSet")>]
    member this.OnStyleSet(it: PlacesSidebarProperty seq, value: Gtk.StyleSetArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnStyleSet value } 
    [<CustomOperation("onParentSet")>]
    member this.OnParentSet(it: PlacesSidebarProperty seq, value: Gtk.ParentSetArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnParentSet value } 
    [<CustomOperation("onDragDataReceived")>]
    member this.OnDragDataReceived(it: PlacesSidebarProperty seq, value: Gtk.DragDataReceivedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragDataReceived value } 
    [<CustomOperation("onTouchEvent")>]
    member this.OnTouchEvent(it: PlacesSidebarProperty seq, value: Gtk.TouchEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnTouchEvent value } 
    [<CustomOperation("onDrawn")>]
    member this.OnDrawn(it: PlacesSidebarProperty seq, value: Gtk.DrawnArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDrawn value } 
    [<CustomOperation("onSelectionRequestEvent")>]
    member this.OnSelectionRequestEvent(it: PlacesSidebarProperty seq, value: Gtk.SelectionRequestEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnSelectionRequestEvent value } 
    [<CustomOperation("onEnterNotifyEvent")>]
    member this.OnEnterNotifyEvent(it: PlacesSidebarProperty seq, value: Gtk.EnterNotifyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnEnterNotifyEvent value } 
    [<CustomOperation("onDragDataDelete")>]
    member this.OnDragDataDelete(it: PlacesSidebarProperty seq, value: Gtk.DragDataDeleteArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragDataDelete value } 
    [<CustomOperation("onScreenChanged")>]
    member this.OnScreenChanged(it: PlacesSidebarProperty seq, value: Gtk.ScreenChangedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnScreenChanged value } 
    [<CustomOperation("onWidgetEvent")>]
    member this.OnWidgetEvent(it: PlacesSidebarProperty seq, value: Gtk.WidgetEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnWidgetEvent value } 
    [<CustomOperation("onSelectionClearEvent")>]
    member this.OnSelectionClearEvent(it: PlacesSidebarProperty seq, value: Gtk.SelectionClearEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnSelectionClearEvent value } 
    [<CustomOperation("onChildNotified")>]
    member this.OnChildNotified(it: PlacesSidebarProperty seq, value: Gtk.ChildNotifiedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnChildNotified value } 
    [<CustomOperation("onWindowStateEvent")>]
    member this.OnWindowStateEvent(it: PlacesSidebarProperty seq, value: Gtk.WindowStateEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnWindowStateEvent value } 
    [<CustomOperation("onDestroyEvent")>]
    member this.OnDestroyEvent(it: PlacesSidebarProperty seq, value: Gtk.DestroyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDestroyEvent value } 
    [<CustomOperation("onSelectionGet")>]
    member this.OnSelectionGet(it: PlacesSidebarProperty seq, value: Gtk.SelectionGetArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnSelectionGet value } 
    [<CustomOperation("onGrabBrokenEvent")>]
    member this.OnGrabBrokenEvent(it: PlacesSidebarProperty seq, value: Gtk.GrabBrokenEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnGrabBrokenEvent value } 
    [<CustomOperation("onDragLeave")>]
    member this.OnDragLeave(it: PlacesSidebarProperty seq, value: Gtk.DragLeaveArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragLeave value } 
    [<CustomOperation("onVisibilityNotifyEvent")>]
    member this.OnVisibilityNotifyEvent(it: PlacesSidebarProperty seq, value: Gtk.VisibilityNotifyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnVisibilityNotifyEvent value } 
    [<CustomOperation("onMotionNotifyEvent")>]
    member this.OnMotionNotifyEvent(it: PlacesSidebarProperty seq, value: Gtk.MotionNotifyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnMotionNotifyEvent value } 
    [<CustomOperation("onKeyReleaseEvent")>]
    member this.OnKeyReleaseEvent(it: PlacesSidebarProperty seq, value: Gtk.KeyReleaseEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnKeyReleaseEvent value } 
    [<CustomOperation("onQueryTooltip")>]
    member this.OnQueryTooltip(it: PlacesSidebarProperty seq, value: Gtk.QueryTooltipArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnQueryTooltip value } 
    [<CustomOperation("onMapEvent")>]
    member this.OnMapEvent(it: PlacesSidebarProperty seq, value: Gtk.MapEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnMapEvent value } 
    [<CustomOperation("onFocusInEvent")>]
    member this.OnFocusInEvent(it: PlacesSidebarProperty seq, value: Gtk.FocusInEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnFocusInEvent value } 
    [<CustomOperation("onHierarchyChanged")>]
    member this.OnHierarchyChanged(it: PlacesSidebarProperty seq, value: Gtk.HierarchyChangedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnHierarchyChanged value } 
    [<CustomOperation("onStateChanged")>]
    member this.OnStateChanged(it: PlacesSidebarProperty seq, value: Gtk.StateChangedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnStateChanged value } 
    [<CustomOperation("onDragDataGet")>]
    member this.OnDragDataGet(it: PlacesSidebarProperty seq, value: Gtk.DragDataGetArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragDataGet value } 
    [<CustomOperation("onPopupMenu")>]
    member this.OnPopupMenu(it: PlacesSidebarProperty seq, value: Gtk.PopupMenuArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnPopupMenu value } 
    [<CustomOperation("onAccelCanActivate")>]
    member this.OnAccelCanActivate(it: PlacesSidebarProperty seq, value: Gtk.AccelCanActivateArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnAccelCanActivate value } 
    [<CustomOperation("onDragEnd")>]
    member this.OnDragEnd(it: PlacesSidebarProperty seq, value: Gtk.DragEndArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragEnd value } 
    [<CustomOperation("onLeaveNotifyEvent")>]
    member this.OnLeaveNotifyEvent(it: PlacesSidebarProperty seq, value: Gtk.LeaveNotifyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnLeaveNotifyEvent value } 
    [<CustomOperation("onMnemonicActivated")>]
    member this.OnMnemonicActivated(it: PlacesSidebarProperty seq, value: Gtk.MnemonicActivatedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnMnemonicActivated value } 
    [<CustomOperation("onKeyPressEvent")>]
    member this.OnKeyPressEvent(it: PlacesSidebarProperty seq, value: Gtk.KeyPressEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnKeyPressEvent value } 
    [<CustomOperation("onDragBegin")>]
    member this.OnDragBegin(it: PlacesSidebarProperty seq, value: Gtk.DragBeginArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragBegin value } 
    [<CustomOperation("onWidgetEventAfter")>]
    member this.OnWidgetEventAfter(it: PlacesSidebarProperty seq, value: Gtk.WidgetEventAfterArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnWidgetEventAfter value } 
    [<CustomOperation("onProximityInEvent")>]
    member this.OnProximityInEvent(it: PlacesSidebarProperty seq, value: Gtk.ProximityInEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnProximityInEvent value } 
    [<CustomOperation("onButtonReleaseEvent")>]
    member this.OnButtonReleaseEvent(it: PlacesSidebarProperty seq, value: Gtk.ButtonReleaseEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnButtonReleaseEvent value } 
    [<CustomOperation("onDragFailed")>]
    member this.OnDragFailed(it: PlacesSidebarProperty seq, value: Gtk.DragFailedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnDragFailed value } 
    [<CustomOperation("onSelectionNotifyEvent")>]
    member this.OnSelectionNotifyEvent(it: PlacesSidebarProperty seq, value: Gtk.SelectionNotifyEventArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnSelectionNotifyEvent value } 
    [<CustomOperation("onFocused")>]
    member this.OnFocused(it: PlacesSidebarProperty seq, value: Gtk.FocusedArgs -> unit) =
        seq { yield! it; yield PlacesSidebarProperty.OnFocused value } 

let prop = PlacesSidebarPropertyBuilder()

type PlacesSidebarDescriptor(props) =
    inherit BaseWidgetDescriptor<PlacesSidebar, PlacesSidebarProperty>(props, bindProperty)
    override this.CreateTyped() = new PlacesSidebar()

let placesSidebar props = PlacesSidebarDescriptor(props)

