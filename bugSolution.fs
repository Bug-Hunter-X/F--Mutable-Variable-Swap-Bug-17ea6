let mutable x = 10
let mutable y = 20

// Correct way to swap mutable variables using references
let swap (x:int byref) (y:int byref) = 
    let temp = x
    x <- y
    y <- temp

swap &x &y
printfn "%d %d" x y //Prints 20 10

//Alternative approach using tuples
let swapTuple (x,y) = (y,x)
let (a,b) = swapTuple (x,y)
printfn "%d %d" a b //Prints 20 10