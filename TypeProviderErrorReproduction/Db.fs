module TypeProviderErrorReproduction.Db

open FSharp.Data.Npgsql

type Db = NpgsqlConnection<"Host=localhost;Username=postgres;Password=postgres;Database=test;Pooling=true">

// To trigger type inference from the database
let bar =
    let command = Db.CreateCommand<"""SELECT * FROM test.test""">(null)
    0
