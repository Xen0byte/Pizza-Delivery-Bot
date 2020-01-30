using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public class Delivery
    {
        public Tuple<int, int> StartingLocation { get; set; }
        public DeliveryBot.Direction StartingFacingDirection { get; set; }
        public Tuple<int, int> EndingLocation { get; set; }
        public DeliveryBot.Direction EndingFacingDirection { get; set; }
        public List<DeliveryBot.Instruction> Route { get; set; }
    }
}