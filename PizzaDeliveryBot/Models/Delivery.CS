using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public class Delivery
    {
        public Tuple<int, int> StartingLocation { get; set; }
        public string StartingFacingDirection { get; set; }
        public List<string> Route { get; set; }
        public Tuple<int, int> EndingLocation { get; set; }
        public string EndingFacingDirection { get; set; }
    }
}