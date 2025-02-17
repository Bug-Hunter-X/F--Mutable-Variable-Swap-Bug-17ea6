let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 10

//However, if we do this:

let swap2 (x:int byref) (y:int byref) = 
    let temp = x
    x <- y
    y <- temp

let mutable x2 = 10
let mutable y2 = 20
swap2 &x2 &y2
printfn "%d %d" x2 y2 //This will correctly print 20 10

//If we are passing values rather than references, then the swap won't work
let swap3 x y = 
    let temp = x
    x <- y
    y <- temp

let x3 = 10
let y3 = 20
swap3 x3 y3
printfn "%d %d" x3 y3 //This will print 10 20 because we are passing by value, not by reference