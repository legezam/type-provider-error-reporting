module TypeProviderErrorReproduction.Parent.Child

module FooTest =
    let toString: foo -> string =
        function
        | foo.a -> ""
        | foo.b -> ""
        | _ -> ""
