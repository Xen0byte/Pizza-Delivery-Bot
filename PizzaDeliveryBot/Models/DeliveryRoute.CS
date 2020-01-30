using System;
using System.Collections.Generic;
using PizzaDeliveryBot.Logic;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryRoute
    {
        public static List<Delivery> Deliveries = GenerateDeliveryRoute.BuildRoute();
        public static Tuple<int, int> CurrentLocation { get; set; }
        public static Direction CurrentFacingDirection { get; set; }
    }
}