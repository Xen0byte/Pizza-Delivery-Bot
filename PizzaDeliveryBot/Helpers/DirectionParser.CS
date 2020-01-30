using System;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Helpers
{
    public static class DirectionParser
    {
        public static Direction ParseDirection(string direction)
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