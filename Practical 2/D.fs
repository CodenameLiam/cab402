module D

let absolute x = abs x

let hyp (a:int, b:int):float =
    let square x = x*x
    sqrt (square (float a) + square (float b))

let isLeapYear (year: int):bool = 
    year % 400 = 0 || ((year % 100 <> 0) && (year % 4 = 0))

let daysInMonth (month: int): int = 
    if month = 2 then 28 
    else if (month < 7 && month % 2 = 1) || (month >= 7 && month % 2 = 0) then 31
    else 30

let rec lucasNumber n = 
    if n <= 0 then 2
    else if n = 1 then 1
    else (lucasNumber (n - 1) + lucasNumber (n - 2))

let rec ackermann m n =
    if m = 0 then n + 1
    else if m > 0 && n = 0 then ackermann (m-1) 1
    else ackermann (m-1) (ackermann m (n-1))

let rec isPrime n divisor = 
    if n < 2 then false
    else if n = 2 then true
    else if n % divisor = 0 then false
    else if divisor * divisor > n then true
    else isPrime n (divisor + 1)

let rec gcd n1 n2 = 
    if (n2 <> 0 ) then
        gcd n2 (n1 % n2);
    else
        n1;

let rec lcm n1 n2 = 
    n1 * n2 / gcd n1 n2




    