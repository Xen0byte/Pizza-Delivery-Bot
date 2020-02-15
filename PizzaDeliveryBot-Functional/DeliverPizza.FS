open System

[<EntryPoint>]
let main argv = // TODO: Add Support For Feeding Input Data As Command Line Parameter
    let deliveryRoute = OrdersParser.parseOrders

    let output = 
        InputDataReader.inputData
        |> deliveryRoute
        |> Seq.map RunDeliveryRoute.validateDeliveryRoute
        |> Seq.iter (Printf.kprintf (fun text -> use _console = SetConsoleForegroundColor.consoleColor ConsoleColor.Green in printfn "%s" text) "%s\r\n\r\n")

    output

    0 // Return An Integer Exit Code