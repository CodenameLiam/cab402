// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    let list = [1;2;3]
    let length = Lists.length(list)
    let reverse = Lists.reverse(list)

    let minimum = List.map (fun x -> x * 2) list |> List.reduce (fun x y -> if x < y then x else y)
    let evens = List.filter (fun x -> if x % 2 = 0 then true else false) list



    0 // return an integer exit code
