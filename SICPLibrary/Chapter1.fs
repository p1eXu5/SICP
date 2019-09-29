namespace SICPLibrary.Chapter1

module Exercise_1_13 =
    
    let fib n =
        let rec fibIter ``fib(n-1)`` ``fib(n-2)``  nr =
            if nr >= n then ``fib(n-1)``
            else fibIter 
                    (``fib(n-1)`` + ``fib(n-2)``)
                    ``fib(n-1)``
                    (nr + 1)
        if n <= 0 then n
        else fibIter 1 0 1

    let phi n = ((1.0 + (sqrt 5.0)) / 2.0) ** (float n)
    let psi n = ((1.0 - (sqrt 5.0)) / 2.0) ** (float n)

    let ``fib-interpolation-high`` n = (phi n) / sqrt 5.0
    let ``fib-interpolation-low`` n = ((phi n) - (psi n)) / sqrt 5.0
