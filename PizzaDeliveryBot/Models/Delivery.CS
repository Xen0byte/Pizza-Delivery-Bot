using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public class Delivery
    {
        public Tuple<int, int> StartingLocation { get; set; }
        public Direction StartingFacingDirection { get; set; }
        public List<Direction> Route { get; set; }
        public Tuple<int, int> EndingLocation { get; set; }
        public Direction EndingFacingDirection { get; set; }
    }
}