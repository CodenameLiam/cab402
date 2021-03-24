module PartA


let A2 = 
    printfn ".. Operator"
    let x = seq {1 .. 100}

    for element in x do
        printf "%d, " element

    printfn ""


let A3 = 
    printfn "Custom Operator"
    //let rec from a b  = seq { yield a; if a < b then yield! from (a + 1) b }
    //let x = from 1 100

    //for element in x do
    //    printf "%d, " element



    //Can also do this
    let counter = Seq.init 100 (fun i -> i + 1)
    counter |> Seq.iter (fun elem -> printf "%d, " elem)

    printfn ""


let A4 = 
    printfn "Power of 2"

    //let rec power a = seq {yield a*a; if (a < 10) then yield! power (a + 1) }
    //let x = power 1

    //x |>  Seq.iter (fun elem -> printf "%d, " elem )

    //Can also do this
    let power = Seq.init 10 (fun i -> i * i)
    power |> Seq.iter (fun elem -> printf "%d, " elem)

    printfn ""


let A5 = 
    printfn "Power of 2 infinite take 10"
    let square a = a * a
    let powerSeq a = Seq.initInfinite (fun i -> square (a + i))
    let first10 = powerSeq 3 |> Seq.take 10

    first10 |> Seq.iter (fun elem -> printf "%d, " elem)

    printfn ""
    
    
