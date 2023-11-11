module FizzBuzzTests

open NUnit.Framework
open FizzBuzz

[<TestFixture>]
type FizzBuzzTests() =
    let fizzbuzz = new FizzBuzz()
    [<Test>]
    member this.Given3ReturnFizz() = 
        Assert.AreEqual("Fizz", fizzbuzz.Execute(3))

    [<Test>]
    member this.Given5ReturnBuzz() = 
        Assert.AreEqual("Buzz", fizzbuzz.Execute(5))

    [<Test>]
    member this.Given6ReturnFizz() = 
        Assert.AreEqual("Fizz", fizzbuzz.Execute(6))


    [<Test>]
    member this.Given2Return2() = 
        Assert.AreEqual("2", fizzbuzz.Execute(2))

    [<Test>]
    member this.Given1Return1() = 
        Assert.AreEqual("1", fizzbuzz.Execute(1))

    [<Test>]
    member this.Given10ReturnBuzz() = 
        Assert.AreEqual("Buzz", fizzbuzz.Execute(10))

    [<Test>]
    member this.Given15ReturnFizzBuzz() = 
        Assert.AreEqual("FizzBuzz", fizzbuzz.Execute(15))