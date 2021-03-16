module Lists

let rec length L =
    match L with
    | [] -> 0
    | head::tail -> 1 + (length tail)


let rec reverse L =
    match L with
    | [] -> []
    | head::tail -> (reverse tail) @ [head]