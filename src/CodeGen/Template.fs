module CodeGen.Template

open System
open System.Text
open CodeGen.Model
open Humanizer

let private keywords = set [ "fixed" ]

let moduleTemplate (info: BindableWidget) =
    let sb = StringBuilder()
    let mutable indentCnt = 0
    let push () = indentCnt <- indentCnt + 1
    let pop () = indentCnt <- indentCnt - 1
    let emptyLine () = sb.AppendLine() |> ignore


    let line str =
        sb.AppendLine(String(' ', indentCnt * 4) + str)
        |> ignore

    let indent fn =
        push ()
        fn ()
        pop ()

    line $"module GtkDsl.Binding.{info.Name}"
    line "open System"
    line "open Gtk"
    line "open Gtk.DSL.Core"
    emptyLine ()
    line "#nowarn \"0044\""

    let propTypeName = $"{info.Name}Property"
    // property
    line "[<RequireQualifiedAccess>]"
    line $"type {propTypeName} ="

    indent
        (fun () ->
            for prop in info.Properties do
                let obsolete =
                    if prop.Deprecated then
                        "[<Obsolete>] "
                    else
                        ""

                line $"| {obsolete}{prop.Name} of {prop.ValueType}"

            for event in info.Events do
                let obsolete =
                    if event.Deprecated then
                        " [<Obsolete>] "
                    else
                        ""

                line $"| {obsolete} On{event.Name} of ({event.EventArgType} -> unit)")


    emptyLine ()
    // apply properties
    line $"let bindProperty (widget: {info.Name}) (prop: {propTypeName}) ="

    indent
        (fun () ->
            line "match prop with"

            for prop in info.Properties do
                line $"| {propTypeName}.{prop.Name} value -> widget.{prop.Name} <- value"

            for event in info.Events do
                line $"| {propTypeName}.On{event.Name} handler -> "

                indent
                    (fun () ->
                        line $"let disposable = widget.{event.Name}.Subscribe(handler)"
                        line $"""registerListener widget "{event.Name}" disposable"""))

    emptyLine ()

    // property builder
    line $"type {propTypeName}Builder() ="

    indent
        (fun () ->
            line $"inherit BasePropertyBuilder<{info.Name}Property>()"

            for prop in info.Properties do
                if prop.Deprecated then
                    line "[<Obsolete>]"

                line $"[<CustomOperation(\"{prop.Name.Camelize()}\")>]"
                line $"member this.{prop.Name}(it: {propTypeName} seq, value: {prop.ValueType}) ="
                indent (fun () -> line $"seq {{ yield! it; yield {propTypeName}.{prop.Name} value }} ")

            for event in info.Events do
                if event.Deprecated then
                    line "[<Obsolete>]"

                let eventName = "On" + event.Name
                line $"[<CustomOperation(\"{eventName.Camelize()}\")>]"
                line $"member this.{eventName}(it: {propTypeName} seq, value: {event.EventArgType} -> unit) ="
                indent (fun () -> line $"seq {{ yield! it; yield {propTypeName}.{eventName} value }} ")

            )

    emptyLine ()

    line $"let prop = {propTypeName}Builder()"
    emptyLine ()

    if info.HasVoidCtor then
        line $"type {info.Name}Descriptor(props) ="

        indent
            (fun () ->
                line $"inherit BaseWidgetDescriptor<{info.Name}, {propTypeName}>(props, bindProperty)"
                line $"override this.CreateTyped() = new {info.Name}()")

        emptyLine ()

        let mutable builderName = info.Name.Camelize()

        if keywords.Contains builderName then
            builderName <- "_" + builderName

        line $"let {builderName} props = {info.Name}Descriptor(props)"
        emptyLine ()

    sb.ToString()
