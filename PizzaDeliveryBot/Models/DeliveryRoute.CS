using System;
using System.Collections.Generic;
using PizzaDeliveryBot.Logic;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Models
{
    internal static class DeliveryRoute
    {
        internal static List<Order> Deliveries = GenerateDeliveryRoute.BuildRoute();
        internal static Tuple<int, int> CurrentLocation { get; set; }
        internal static Direction CurrentFacingDirection { get; set; }
    }
}