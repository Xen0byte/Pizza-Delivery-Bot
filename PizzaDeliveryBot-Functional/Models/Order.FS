module Order

open DeliveryBot
open Instruction

type Order = {
    StartingLocation: DeliveryBot
    Instructions: Instruction list
    EndingLocation: DeliveryBot }