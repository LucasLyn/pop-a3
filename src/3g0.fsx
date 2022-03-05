// 3ga - Beginning of function sum.
// We sum together each value from 1 to n with a for-loop.
let mutable n = 5   // Define n with a placeholder value.

let sum (n : int) : int =
    let mutable s = 0
    let mutable i = 0
    if n < 1 then 0
    else
        while i < n + 1 do
            s <- s + i
            i <- i + 1
        s




// 3gb - Beginning of function simpleSum.
// We sum together each value from 1 to n with a simple equation
let mutable finalSum = 0

let simpleSum (n : int) : int =
    if n < 0 then 0
    else
        finalSum <- (n * (n + 1)) / 2
        finalSum




// 3gc - Start of user input.
// We get input, convert it to int, and print the result from sum and simpleSum.
printfn "Please input the number you want n to be!"

let  nInput = System.Console.ReadLine()
n <- nInput |> int

printfn "%A %A %A \n" (n) (sum n) (simpleSum n)




// 3gd - Start of table.
// We call the functions sum and simpleSum with the values from 1 to 10.
// We print the results in a table with 4 characters in between.
for i = 1 to 10 do
    printfn "%4d %4d %4d" (i) (sum i) (simpleSum i)




// 3ge - Start of explanation of maximum possible value.
// The maximum possible value of n that sum and simpleSum can calculate
// is 65535 for sum, and 46340 for simpleSun. The difference comes in the
// formula. sum simply adds all the values together, while simpleSum
// first multiplies the the integers, before dividing them by 2.
// This is due to the fact that int defaults to a 32-bit integer.
// This can be fixed by converting to 64-bit integers,
// which has a maximum value of 9,223,372,036,854,775,807, and the functions
// can thus calculate a max value of n to be much more.
