module UnitTest.BaseWidget

open Xunit
open Gtk
open DSL.Core
open FsUnit.Xunit



[<Fact>]
let ``it can create new widget`` () =
    tryInit ()
    let mutable propertySet = 0
    let mutable created = 0
    let setProperty a b = propertySet <- propertySet + 1

    let create () =
        created <- created + 1
        new Label()

    let desc = baseWidget setProperty create [ 1 ]

    desc.NodeType.Value
    |> should equal typeof<Label>.FullName

    desc.PatchWidget None |> ignore
    propertySet |> should equal 1
    created |> should equal 1

[<Fact>]
let ``it can patch current widget`` () =
    tryInit ()
    let mutable propertySet = 0
    let mutable created = 0
    let setProperty a b = propertySet <- propertySet + 1

    let create () =
        created <- created + 1
        new Label()

    let widget = new Label() :> Widget
    let desc = baseWidget setProperty create [ 1 ]
    let result = desc.PatchWidget(Some widget)
    propertySet |> should equal 1
    created |> should equal 0
    result |> should equal widget

[<Fact>]
let ``it should fail when update different widget`` () =
    tryInit ()
    let mutable propertySet = 0
    let mutable created = 0
    let setProperty a b = propertySet <- propertySet + 1

    let create () =
        created <- created + 1
        new Label()

    let widget = new Button() :> Widget
    let desc = baseWidget setProperty create [ 1 ]

    fun () -> desc.PatchWidget(Some widget) |> ignore
    |> shouldFail
