namespace Samples

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

    let mainWindow =
        fun () (ctx: ComponentContext) ->
            let cnt = ctx.UseState 0
            let boxRef = ctx.UseRef<Box>()

            let boxChildrenCnt () =
                match boxRef.Current with
                | Some box -> box.Children.Length.ToString()
                | None -> "box ref is not captured"

            gtkBox [ <@ _box.Orientation @> := Orientation.Vertical
                     bindRef boxRef ] [
                packStart (false, false, 24u) (textButton ("box ref", (fun _ -> printfn $"%s{boxChildrenCnt ()}")))
                packStart
                    (false, false, 24u)
                    (gtkBox [ <@ _box.Orientation @> := Orientation.Horizontal
                              <@ _box.Valign @> := Align.Center
                              <@ _box.Halign @> := Align.Center ] [
                        packStart (false, false, 24u) (textButton ("-", (fun _ -> cnt.Value <- (cnt.Value - 1))))
                        packStart (false, false, 24u) (label [ <@ _label.LabelProp @> := cnt.Value.ToString() ])
                        packStart (false, false, 24u) (textButton ("+", (fun _ -> cnt.Value <- (cnt.Value + 1))))
                     ])
                if cnt.Value > 0 then
                    for i in 1 .. cnt.Value do
                        packStart (false, false, 24u) (label [ <@ _label.LabelProp @> := i.ToString() ])
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
