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

module Exponentiation = 

    let rec exptRec b n =
        if n = 0 then 1
        else b * (exptRec b (n - 1))

    let exptIter b n =
        let rec expt b counter product =
            if counter = 0 then product
            else expt b (counter - 1) (b * product)

        expt b n 1

    let (|Even|_|) n = 
        if (n % 2) = 0 then Some(n)
        else None

    let rec fastExpt b n =

        let square x = x * x

        if n = 0 then 1
        else
            match n with
            | Even n -> square (fastExpt b (n / 2))
            | _ -> b * (fastExpt b (n - 1))


    module Exercise_1_16 =

        let fastExpIter b n =
            let rec exp p a nr n =
                if nr = n then p * a
                elif (n - nr) < nr then exp (p * a) b 1 (n - nr)
                else
                    match n with
                    | Even n -> exp p (a * a) (nr * 2) n
                    | _ -> exp (p * b) a nr (n - 1)

            if n = 0 then 1
            else
                exp 1 b 1 n


    module Exercise_1_17 =

        let rec (*) a b =
            if b = 0 then 0
            else a + ((*) a (b - 1)) 