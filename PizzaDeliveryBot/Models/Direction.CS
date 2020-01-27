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
            switch (direction)
            {
                case "N": return North;
                case "E": return East; 
                case "S": return South;
                case "W": return West; 
                default: throw new ArgumentException();
            }
        }
    }
}