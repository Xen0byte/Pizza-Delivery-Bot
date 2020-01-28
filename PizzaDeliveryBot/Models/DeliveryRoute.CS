using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryRoute
    {
        public static Tuple<int, int> StartingLocation { get; set; }
        public static DeliveryBot.Direction StartingFacingDirection { get; set; }
        public static List<Delivery> Deliveries { get; set; }
        public static Tuple<int, int> EndingLocation { get; set; }
        public static DeliveryBot.Direction EndingFacingDirection { get; set; }
    }
}