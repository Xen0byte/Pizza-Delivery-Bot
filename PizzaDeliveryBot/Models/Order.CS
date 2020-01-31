using System;
using System.Collections.Generic;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Models
{
    internal class Order
    {
        internal Coordinates StartingLocation { get; set; }
        internal Direction StartingFacingDirection { get; set; }
        internal Coordinates EndingLocation { get; set; }
        internal Direction EndingFacingDirection { get; set; }
        internal List<Instruction> Route { get; set; }
    }
}