# F# Formatting: Literate programming with .fs files

This is an experiment to create a literate F# .fs file.

We are using a forked version of [FSharp.Formatting](https://github.com/fsprojects/FSharp.Formatting) to compile a command line tool.

The only changes to the original source code are to FSharp.Literate/Main.fs and FSharp.Literate/Transformations.fs, where we now target .fs files (not .fsx)


The organization of this sample is:

1. Source .fs files are organized in /src
2. Misc assets (css, images) are in /doc-assets
3. Shell scripts are in /doc-cmd
4. Html output are in /doc-output
5. fsformatting.exe and other necessary DLLs are copied to /doc-tools
6. Bootstrap 4.3.1 is used for CSS


## Getting started

To create the project: 

` dotnet run `

To generate documentation from .fs files in /src:

`doc-cmd/publish.sh` or `doc-cmd/pubish.bat`



## Sample .fs file

```
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
```