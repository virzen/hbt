open System

[<EntryPoint>]
let main argv =
    
    match argv with
    | [|"slot"; "add"; time; description|] -> printf "Add slot"
    | [|"task"; "add"; description|] -> printf "Add task"
    | _ -> printfn "Usage: ..."
     
    
    0 // return an integer exit code
