using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    internal class Delivery
    {
        internal Tuple<int, int> StartingLocation { get; set; }
        internal DeliveryBot.Direction StartingFacingDirection { get; set; }
        internal Tuple<int, int> EndingLocation { get; set; }
        internal DeliveryBot.Direction EndingFacingDirection { get; set; }
        internal List<DeliveryBot.Instruction> Route { get; set; }
    }
}