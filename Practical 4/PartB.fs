module PartB

let B1 = 
    let getRandom a = 
        let random = new System.Random(a)
        random.Next(1, 100)
           

    let r1 = getRandom 2
    let r2 = getRandom 6

    printfn "Random number 1: %d" r1
    printfn "Random number 2: %d" r2

    