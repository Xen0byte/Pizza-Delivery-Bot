using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryRoute
    {
        public static Tuple<int, int> CurrentLocation { get; set; }
        public static DeliveryBot.Direction CurrentFacingDirection { get; set; }

        public static List<Delivery> Deliveries { get; set; }

        public static void TurnLeft() { }
        public static void TurnRight() { }
        public static void MoveForward() { }
    }
}