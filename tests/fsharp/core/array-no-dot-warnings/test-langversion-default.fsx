let f1 a = ()
let f2 a b = ()

let v1 = f1[1]            // with langversion 'default' or 'latest' enabled this should give a warning saying to add a space or enable preview
let v2 = f2[1][2]        // with langversion 'default' or 'latest' enabled this should give a warning saying to add a space or enable preview
let v3 = f2 [1][2]       // with langversion 'default' or 'latest' enabled this should give a warning saying to add a space or enable preview
let v4 = f2 (id [1])[2]  // with langversion 'default' or 'latest' enabled this should give a warning saying to add a space or enable preview

let _error = 1 + 1.0