module Order

open DeliveryBot

type Order = {
Start: DeliveryBot
    Instructions: Instruction list
End: DeliveryBot }