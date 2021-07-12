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
        fun (text, onClick) ->
            button [ <@ _button.Clicked @> @= onClick ]
            <| label [ <@ _label.LabelProp @> := text ]
        |> stateless


    [<EntryPoint>]
    let main argv =
        Application.Init()
        let updateEvent = Event<_>()
        let mutable count = 0
        let mutable items : DateTime list = []

        let handleListBtnClick i _ =
            items <- items |> List.filter (fun x -> x <> i)
            updateEvent.Trigger()

        let createItem i =
            packStart (true, true, 0u) (textButton ($"{i}", (handleListBtnClick i)))

        let view () =
            let labels = items |> Seq.map createItem

            (box [ <@ _box.Direction @> := TextDirection.Rtl
                   <@ _box.Orientation @> := Orientation.Vertical ] [
                packStart
                    (true, true, 0u)
                    (label [ <@ _label.LabelProp @>
                             := (if count = 0 then
                                     "Hello world!"
                                 else
                                     $"You clicked {count} times") ])
                yield! labels
                packStart
                    (false, false, 24u)
                    (button
                        [ <@ _button.MarginStart @> := 12
                          <@ _button.MarginEnd @> := 12
                          <@ _button.Clicked @>
                          @= (fun _ ->
                              count <- count + 1
                              items <- DateTime.Now :: items
                              updateEvent.Trigger()) ]
                        (label [ <@ _label.LabelProp @> := count.ToString() ]))
             ])

        let content = (view () :> WidgetDescriptor).Create()
        let update () = view().Bind(Some content) |> ignore
        updateEvent.Publish.Subscribe(update) |> ignore


        let app =
            new Application("org.Samples.Samples", GLib.ApplicationFlags.None)

        app.Register(GLib.Cancellable.Current) |> ignore

        let win = new Window("Samples")
        win.Add(content)
        updateEvent.Trigger()
        win.ShowAll()
        app.AddWindow(win)

        win.Destroyed.Subscribe(fun _ -> Application.Quit())
        |> ignore

        win.Show()
        Application.Run()
        0
