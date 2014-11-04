
// Alternate syntax is: dumper (name:string) (age:int) which forces
// type checking at the top instead of lazy at bottom.
let dumper name age =
    // - using %s will force type of string.
    // - using % will force type of int.
    printfn "Your name is %s and you are %i years old" name age

dumper "Geoffrey Huntley" 101

