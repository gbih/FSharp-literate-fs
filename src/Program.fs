(*** hide ***)
open System

(**
# F# Pattern Matching

### Record Pattern
The record pattern is used to decompose records to extract the values of fields. 
The pattern does not have to reference all fields of the record; any omitted fields 
just do not participate in matching and are not extracted.
*)
type MyRecord = { Name: string; ID: int }

let IsMatchByName record1 (name: string) =
    match record1 with
    | { MyRecord.Name = nameFound; MyRecord.ID = _; } when nameFound = name -> true
    | _ -> false

let recordX = { Name = "Parker"; ID = 10 }
let isMatched1 = IsMatchByName recordX "Parker"
let isMatched2 = IsMatchByName recordX "Hartono"

printfn "%A" recordX
printfn "%A" isMatched1
printfn "%A" isMatched2


(**
### Patterns That Have Type Annotations
Patterns can have type annotations. These behave like other type annotations and guide 
inference like other type annotations. Parentheses are required around type annotations 
in patterns. The following code shows a pattern that has a type annotation.
*)
let detect1 x =
    match x with
    | 1 -> printfn "Found a 1!"
    | (var1 : int) -> printfn "%d" var1

detect1 0 |> printfn "%A"
detect1 1 |> printfn "%A"


(**
Code samples and explanation are from:

https://github.com/dotnet/docs/blob/master/docs/fsharp/language-reference/pattern-matching.md
*)