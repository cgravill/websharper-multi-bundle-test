namespace Bundle1

open WebSharper

[<JavaScriptExport>]
type Class1() = 
    member this.X = "F#"

[<JavaScript>]
module Bundle1 =

    [<JavaScript>]
    let wrapsIndirect() =
        let matrix = Library1.Matrix.ofArray [|[|1.0;1.0|]|]
        matrix.MatrixData.[0].[0] + 7.0