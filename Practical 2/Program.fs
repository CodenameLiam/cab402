// Learn more about F# at http://fsharp.org

open System
let nl = System.Environment.NewLine

[<EntryPoint>]
let main argv =

    //let b1 = B.B1
    //let b3 = B.B3

    printfn "Abs -5: %d" (D.absolute -5)

    printfn "Hyp of triangle with sides 3 and 4 len: %f" (D.hyp(3, 4))

    printfn "1990 is Leap: %b" (D.isLeapYear 1999)
    printfn "2008 is Leap: %b" (D.isLeapYear 2008)

    printfn "Days in feb: %d" (D.daysInMonth 2)
    printfn "Days in jan: %d" (D.daysInMonth 1)
    printfn "Days in jun: %d" (D.daysInMonth 6)
    printfn "Days in jul: %d" (D.daysInMonth 7)
    printfn "Days in nov: %d" (D.daysInMonth 11)
    printfn "Days in dec: %d" (D.daysInMonth 12)

    printfn "%sLucas numbers" nl
    for i in 1..10 do
        printf "%d, " (D.lucasNumber i)


    printfn "%s%sAckermann" nl nl
    for i in 1..4 do
        printf "%d, " (D.ackermann i 0)

    printfn "%s%sPrimes" nl nl
    for i in 1..20 do
        if (D.isPrime i 2) = true then printf "%d, " i
        

    printfn "%s%sGCD 36, 116: %d" nl nl (D.gcd 36 116)

    printfn "%s%sLCM 4, 6: %d" nl nl (D.lcm 4 6)

    
    
    0 // return an integer exit code
