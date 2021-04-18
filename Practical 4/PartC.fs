module PartC

let printArray x =
    for e in x do
        printf "%d, " e
    printfn ""

let genRandomNums count = 
    let rnd = new System.Random()
    Array.init count (fun _ -> rnd.Next(1, 100)) 

let C = 
    let x = [| 1 .. 100|]
    printfn "Original Array"
    printArray x

    x.[5] <- 19
    printfn "Change element in pos 5 to 19"
    printArray x

    let rndArray = genRandomNums 100
    printfn "Random Array 1"
    printArray rndArray

    //let rndArray2 = genRandomNums 100
    //printfn "Random Array 2"
    //printArray rndArray2

    let sortArray = rndArray |> Array.sort
    printfn "Random Array 1"
    printArray sortArray

    

    
    

    


