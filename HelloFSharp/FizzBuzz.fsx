//    if (number % 3 == 0 && number % 5 == 0)
//    {
//        return "FizzBuzz";
//    }
//
//    if (number % 5 == 0)
//    {
//        return "Buzz";
//    }
//
//    if (number % 3 == 0)
//    {
//        return "Fizz";
//    }

let buzzer number =
   match number with
   | i when i % 3 = 0 && i % 5 = 0 -> "FizzBuzz"
   | i when i % 3 = 0 -> "Fizz"
   | i when i % 5 = 0 -> "Buzz"
   | i -> (sprintf "%i" i)
//   | _ -> number.ToString();

for i = 1 to 100 do
    printfn "%s" (buzzer i)

