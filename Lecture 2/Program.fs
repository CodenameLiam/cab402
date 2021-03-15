module Program

open System

[<EntryPoint>]
let main argv =

    let add x y = (x + y)
    let r = add 5 7
    printfn "Sum of 5 and 7 = %d" r

    let add3 x = x + 3
    let r2 = add3 3
    printfn "Add 3 to 3 = %d" r2

    let twice f x = f ( f x )
    let succ x = x + 1
    let r3 = twice twice twice succ 0
    printfn "Twice twice SUCC 0 = %d" r3

    //let r4 = twice twice twice add3 0
    //printfn "Twice twice add 3 = %d" r4


    0
