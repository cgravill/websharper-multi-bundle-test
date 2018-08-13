namespace Library1

open WebSharper

[<JavaScript>]
type UsedIn1() = 
    member this.X = "UsedIn1"

[<JavaScript>]
type Matrix =
    {
        MatrixData : float [][]
    }

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<JavaScript>]
module Matrix =
    type M = Matrix

    let ofArray array =
        { MatrixData = array}
