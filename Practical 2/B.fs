module B

let B1 = 
    let a = 42
    let r = a + 3
    printfn "B1: %d" r

let B3 = 
    let succ x = x + 1
    printfn "succ 3: %d" (succ 3)
    printfn "succ (succ 3): %d" (succ(succ 3))
  
let B4 = 
    let add x y  = x + y
    printfn "3 + 5 = %d" (add 3 5)
 
let B5 = 
    let quadrupal x = 
        let double x = 
            x * 2
        double(double x)
    printfn "quadrupal 3: %d" (quadrupal 3)

let B6 = 
    // isMe is passed to chrisTest as a variable
    // chrisTest exeucts the isMe function with the string defined next to the 
    let chrisTest test = test "Christy"
    let isMe x =
        if x = "Chris" then "its Chris!" else "its someone else"
    printfn "%s" (chrisTest isMe)


let B7 = 
    let add = fun x y -> x + y
    printfn "lambda add 2 + 2 = %d" (add 2 2)

let B8 = 
    //testing to see if a number is less than 0 using lambda inline functions
    let twoTest test = 
        test -2
    printfn "twoTest %b" (twoTest (fun x -> x < 0))
