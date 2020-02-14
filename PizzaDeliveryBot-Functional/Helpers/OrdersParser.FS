module OrdersParser

open System
open Direction
open DeliveryBot
open Instruction
open Order

let split (by: string) (line: string) = 
    line.Split(by.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

let parseDirection = function 
    | "N" -> North  | "n" -> North
    | "E" -> East   | "e" -> East
    | "S" -> South  | "s" -> South
    | "W" -> West   | "w" -> West
    | _ -> failwith "Invalid Direction"

let parseState (deliveryBotState: string) = 
    let state = deliveryBotState |> split " "
        // [split ""] Should Be, In Theory, More Robust Than [split " "] Because [split] Removes Empty Entries
        // TODO: Make This More Robust, Potentially By Using RegEx Like In The OOP Project
    { Coordinates = int state.[0], int state.[1]; FacingDirection = parseDirection state.[2] }

let parseInstruction = function
    | 'L' -> TurnLeft       | 'l' -> TurnLeft
    | 'R' -> TurnRight      | 'r' -> TurnRight
    | 'F' -> MoveForward    | 'f' -> MoveForward
    | _ -> failwith "Invalid Instruction"

let parseInstructions (instructions: string) = 
    instructions
    |> Seq.map parseInstruction
    |> Seq.toList

let parseOrder (order: string seq) = 
    let order = Seq.toList order
    { StartingLocation = parseState order.[0]; Instructions = parseInstructions order.[1]; EndingLocation = parseState order.[2] }

let parseOrders source =
    source
    |> split Environment.NewLine
    |> Seq.toList
    |> List.chunkBySize 3
    |> List.map parseOrder