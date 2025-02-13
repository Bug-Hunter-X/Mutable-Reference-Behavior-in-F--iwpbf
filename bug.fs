let mutable x = 10
let y = &x
!y <- 20
printfn "%d" x //This will print 20, not 10 as one might expect if not familiar with mutable references in F#.