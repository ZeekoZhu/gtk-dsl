module Tests

open System
open Gtk
open DSL.Core
open Moq
open UnitTest.Moq
open Xunit
open FsUnit.Xunit


[<Fact>]
let ``it can add new listener`` () =
    Application.Init()
    let widget = new Label()
    let teardown = Mock<IDisposable>()
    let event = { Event = "foo" }

    registerListener widget "foo" teardown.Object
    widget.Data.ContainsKey event |> should be True

    widget.Data.[event]
    |> should equal teardown.Object

[<Fact>]
let ``it should remove previous listener`` () =
    Application.Init()
    let widget = new Label()
    let handler1 = Mock<IDisposable>()
    let handler2 = Mock<IDisposable>()

    let event = { Event = "foo" }

    registerListener widget "foo" handler1.Object
    registerListener widget "foo" handler2.Object
    widget.Data.ContainsKey event |> should be True

    widget.Data.[event]
    |> should equal handler2.Object

    handler1.VerifyAction((fun x -> x.Dispose()), Times.Once)
