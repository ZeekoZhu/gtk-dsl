open System.IO
open Gtk
open CodeGen.Model
open CodeGen.Template

[<EntryPoint>]
let main argv =
    Directory.CreateDirectory "../Core/Generated"
    |> ignore

    let widgetType = typeof<Widget>

    widgetType.Assembly.GetExportedTypes()
    |> Seq.filter (fun t -> t.IsAssignableTo widgetType)
    |> Seq.map getBindingInfo
    |> Seq.iter (fun t -> File.WriteAllText("../Core/Generated/" + t.Name + ".fs", moduleTemplate t))


    0 // return an integer exit code
