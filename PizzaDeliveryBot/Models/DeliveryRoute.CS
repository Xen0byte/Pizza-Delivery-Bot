using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryRoute
    {
        public static List<Delivery> Deliveries;
        public static Tuple<int, int> StartingLocation { get; set; }
        public static string StartingFacingDirection { get; set; }
        public static Tuple<int, int> EndingLocation { get; set; }
        public static string EndingFacingDirection { get; set; }
    }
}