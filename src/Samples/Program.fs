namespace Samples

open Gtk.DSL.Binding
open Gtk.DSL.Core


module Program =

    open Gtk
    open Gtk.DSL.Containers.Box


    [<EntryPoint>]
    let main argv =
        Application.Init()
        let view =
            box Seq.empty [
                packStart (true, true, 12u) (Label.label (Label.prop {
                    labelProp "Hello, world"
                }))
            ] :> WidgetDescriptor
        let content = view.Create()
        let content  = view.Bind(Some content)

        let app =
            new Application("org.Samples.Samples", GLib.ApplicationFlags.None)

        app.Register(GLib.Cancellable.Current) |> ignore

        let win = new Window("Samples")
        win.Add(content)
        win.ShowAll()
        app.AddWindow(win)

        win.Destroyed.Subscribe(fun _ -> Application.Quit())
        |> ignore

        win.Show()
        Application.Run()
        0
