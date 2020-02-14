[<EntryPoint>]
let main argv =
    let deliveryRoute = OrdersParser.parseOrders

    let output = 
        InputDataReader.inputData
        |> deliveryRoute
        |> Seq.map RunDeliveryRoute.validateDeliveryRoute
        
    printfn "%A" output

    0 // Return An Integer Exit Code