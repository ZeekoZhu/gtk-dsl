namespace Samples

open Gdk
open Gdk
open Gtk
open Gtk.DSL.Core
open Gtk.DSL.Component
open Gtk.DSL.Quotation


module Program =

    open Gtk
    open Gtk.DSL.Widgets.Quote
    open Gtk.DSL.Widgets.Box
    open Gtk.DSL.Widgets.VoidWidgets
    open Gtk.DSL.Widgets.Bin

    let textButton =
        fun (text, onClick) (ctx: ComponentContext) ->
            ctx.OnCreated(fun () -> printfn "text button created")
            ctx.OnDestroy(fun () -> printfn "text button destroyed")

            button [ <@ _button.Clicked @> @= onClick ]
            <| label [ <@ _label.LabelProp @> := text ]
        |> statefullComponent

    let todoMain =
        fun () (ctx: ComponentContext) ->
            label [ <@ _label.LabelProp @> := "todos"
                    classNames [ "todo-title" ] ]
        |> statefullComponent

    let mainWindow =
        fun () (ctx: ComponentContext) -> todoMain ()
        |> statefullComponent

    [<EntryPoint>]
    let main argv =
        Application.Init()

        let view = mainWindow ()

        let app =
            new Application("org.Samples.Todo", GLib.ApplicationFlags.None)

        app.Register(GLib.Cancellable.Current) |> ignore

        let win = new Window("Samples")
        mount win view
        app.AddWindow(win)

        win.Destroyed.Subscribe(fun _ -> Application.Quit())
        |> ignore

        win.Show()
        let cssProvider = new CssProvider()

        if cssProvider.LoadFromPath "./app.css" then
//            win.StyleContext.AddProvider(cssProvider, 800u)
            StyleContext.AddProviderForScreen(Screen.Default, cssProvider, 800u)
        else
            printfn "not loaded"

        Application.Run()
        0
