module Order

open DeliveryBot
open Instruction

type Order = {
    Start: DeliveryBot
    Instructions: Instruction list
    End: DeliveryBot }