namespace Bundle2

open WebSharper

[<JavaScriptExport>]
type Class1() = 
    member this.X = "F#"

    static member Test =
        Bundle1.Bundle1.wrapsIndirect()