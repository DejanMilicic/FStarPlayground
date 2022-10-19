// For more information see https://aka.ms/fsharp-console-apps

open TestFSharp

printfn "Hello from F#"

let a = pass1 () () (fun x y -> x = y)
let b = pass1 5 2 (fun x y -> x = y)

printf "a = %b\n" a
printf "b = %b" b