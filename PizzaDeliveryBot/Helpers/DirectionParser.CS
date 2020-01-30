using System;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Helpers
{
    internal static class DirectionParser
    {
        internal static Direction ParseDirection(string direction)
        {
            return direction switch
            {
                "N" => Direction.North,
                "E" => Direction.East,
                "S" => Direction.South,
                "W" => Direction.West,
                _ => throw new ArgumentException()
            };
        }
    }
}