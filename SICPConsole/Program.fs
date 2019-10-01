// Learn more about F# at http://fsharp.org

open System
open SICPLibrary.Chapter1

let n = 10

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    printfn "Fib(%d) = %d" n (Exercise_1_13.fib n)
    printfn "Phi(%d) = %f" n (Exercise_1_13.phi n)
    printfn "Psi(%d) = %f" n (Exercise_1_13.psi n)
    
    printfn "high(%d) = %f" n (Exercise_1_13.``fib-interpolation-high`` n)
    printfn "low(%d) = %f" n (Exercise_1_13.``fib-interpolation-low`` n)

    let b = 4
    let e = 6
    printfn "Fast exp %d %d = %d" b e (Exponentiation.fastExpt b e)
    printfn "Fast exp %d %d = %d" b e (Exponentiation.Exercise_1_16.fastExpIter b e)

    0 // return an integer exit code
