using System;

namespace PizzaDeliveryBot.Models
{
    public class Direction
    {
        private const string North = "North";
        private const string East = "East";
        private const string South = "South";
        private const string West = "West";

        public string ParseDirection(string direction)
        {
            return direction switch
            {
                "N" => North,
                "E" => East,
                "S" => South,
                "W" => West,
                _ => throw new ArgumentException()
            };
        }
    }
}