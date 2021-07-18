module UnitTest.Moq

open System
open System.Linq.Expressions
open System.Runtime.CompilerServices
open Moq

[<Extension>]
type MoqExtensions =
    [<Extension>]
    static member VerifyAction(mock: Mock<'t>, action: Expression<Action<'t>>, times: Times) =
        mock.Verify(action, times)

    [<Extension>]
    static member VerifyAction(mock: Mock<'t>, action: Expression<Action<'t>>, times: Func<Times>) =
        mock.Verify(action, times.Invoke())
