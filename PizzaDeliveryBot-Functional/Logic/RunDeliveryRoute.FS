module RunDeliveryRoute

open Direction
open Instruction
open DeliveryBot
open Order

let turnRight = function 
    | North -> East
    | East ->  South
    | South -> West
    | West ->  North

let turnLeft = function 
    | North -> West
    | East ->  North
    | South -> East
    | West ->  South

let moveForward (x, y) direction = 
    match direction with
    | North -> x+0, y+1
    | East ->  x+1, y+0
    | South -> x+0, y-1
    | West ->  x-1, y+0

let executeInstruction deliveryBot instruction =
    match instruction with
    | TurnRight -> { deliveryBot with FacingDirection = turnRight deliveryBot.FacingDirection }
    | TurnLeft -> { deliveryBot with FacingDirection = turnLeft deliveryBot.FacingDirection }
    | MoveForward -> { deliveryBot with Coordinates = moveForward deliveryBot.Coordinates deliveryBot.FacingDirection }

let terminalOutput deliveryBot instruction = 
    printfn "Delivery Bot :: %A" deliveryBot
    printfn "Instruction  :: %A" instruction
    executeInstruction deliveryBot instruction
        
let validateDeliveryRoute route = 
    let order = 
        (route.StartingLocation, route.Instructions)
        ||> List.fold terminalOutput

    if (route.EndingLocation = order) then
        "Success"
    else
        sprintf "Expected :: %A\r\nActual   :: %A" route.EndingLocation order