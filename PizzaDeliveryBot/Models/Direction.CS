using System;
using System.Collections.Generic;

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

        public List<Direction> ParseDirections(string directions)
        {
            List<Direction> parsedDirections = new List<Direction>();

            foreach (char direction in directions)
                switch (direction.ToString())
                {
                    case "N":
                        parsedDirections.Add(North);
                        break;
                    case "E":
                        parsedDirections.Add(East);
                        break;
                    case "S":
                        parsedDirections.Add(South);
                        break;
                    case "W":
                        parsedDirections.Add(West);
                        break;
                    default: throw new ArgumentException();
                }

            return parsedDirections;
        }
    }
}