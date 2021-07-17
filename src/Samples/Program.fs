namespace Samples

open System
open Gtk.DSL.Core
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

    let mainWindow =
        fun () (ctx: ComponentContext) ->
            let cnt, setCnt = ctx.UseState 0

            gtkBox [ <@ _box.Orientation @> := Orientation.Horizontal
                     <@ _box.Valign @> := Align.Center
                     <@ _box.Halign @> := Align.Center ] [
                packStart (false, false, 24u) (textButton ("-", (fun _ -> setCnt (cnt - 1))))
                packStart (false, false, 24u) (label [ <@ _label.LabelProp @> := cnt.ToString() ])
                packStart (false, false, 24u) (textButton ("+", (fun _ -> setCnt (cnt + 1))))
            ]
        |> statefullComponent

    [<EntryPoint>]
    let main argv =
        Application.Init()

        let view = mainWindow ()

        let app =
            new Application("org.Samples.Samples", GLib.ApplicationFlags.None)

        app.Register(GLib.Cancellable.Current) |> ignore

        let win = new Window("Samples")
        mount win view
        app.AddWindow(win)

        win.Destroyed.Subscribe(fun _ -> Application.Quit())
        |> ignore

        win.Show()
        Application.Run()
        0
