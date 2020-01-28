using System;

namespace PizzaDeliveryBot.Models
{
    public class Direction
    {
        public Direction North { get; set; }
        public Direction East { get; set; }
        public Direction South { get; set; }
        public Direction West { get; set; }

        public Direction ParseDirection(string direction)
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