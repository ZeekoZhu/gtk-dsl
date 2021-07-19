module UnitTest.Gtk

open Gtk

let tryInit () =
    let mutable args = [||]
    Application.InitCheck("test", &args) |> ignore
