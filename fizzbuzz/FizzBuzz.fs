module FizzBuzz
open System.Text

let isDivisibleBy3(input: int) = input%3=0

let isDivisibleBy5(input: int) = input%5=0 

type FizzBuzz() = 
    member x.Execute( input: int) =
        if isDivisibleBy3(input) && isDivisibleBy5(input) then
            "FizzBuzz"
        else if isDivisibleBy3(input) then
            "Fizz"
        else if isDivisibleBy5(input) then
            "Buzz"
        else
            input.ToString()
