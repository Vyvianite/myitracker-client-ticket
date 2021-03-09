namespace Core

open System
open HttpApi

module Main = 
  (*This should return an error type, but honestly I'm too assed to care so it returns
    bool instead.*)
  let post ticket =
    Config.read ()
    |>function // Match the result of config.read
      | Ok config ->
          Map [ "token", config.Token
                "customerId", config.CustomerId 
                "subject", ticket.Subject
                "body", ticket.Body
                "priority", ticket.Priority ]
          |> Some
          |> post (Uri (config.Server + "tickets/")) "savecustomerticket"
          |> Async.RunSynchronously
      | Error x -> 
          Error "Error Reading config file"
    |>function //match on the result, either a passed through config error, or a posting/network error.
      | Ok i -> true // Oll Korrect
      | Error i ->
          Logger.log i true
          false