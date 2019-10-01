namespace SICPLibrary.Tests.Chapter1Tests

open NUnit.Framework
open SICPLibrary.Chapter1

module Exercise_1_13Tests =

    [<SetUp>]
    let Setup () =
        ()

    [<TestCase(0, 0)>]
    [<TestCase(1, 1)>]
    [<TestCase(2, 1)>]
    [<TestCase(3, 2)>]
    [<TestCase(4, 3)>]
    [<TestCase(5, 5)>]
    [<TestCase(6, 8)>]
    [<TestCase(7, 13)>]
    [<TestCase(8, 21)>]
    [<TestCase(9, 34)>]
    [<TestCase(10, 55)>]
    let ``fib returns expected and equals interpolation`` n res =
        Assert.That( Exercise_1_13.fib n, Is.EqualTo( res ) )
        Assert.That( Exercise_1_13.fib n, Is.EqualTo( int (Exercise_1_13.``fib-interpolation-low`` n) ) )

    [<TestCase(7, 8, 56)>]
    let ``(*) returns expected`` a b res =
        Assert.That( Exponentiation.Exercise_1_17.(*) a b, Is.EqualTo( res ) )