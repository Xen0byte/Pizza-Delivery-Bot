using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryBot
    {
        public enum Direction
        {
            North,
            East,
            South,
            West
        }

        public enum Instruction
        {
            Left,
            Right,
            Forward
        }

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

        public static List<Instruction> ParseInstructions(string instructions)
        {
            List<Instruction> parsedInstructions = new List<Instruction>();

            foreach (char instruction in instructions)
                switch (instruction.ToString())
                {
                    case "L":
                        parsedInstructions.Add(Instruction.Left);
                        break;
                    case "R":
                        parsedInstructions.Add(Instruction.Right);
                        break;
                    case "F":
                        parsedInstructions.Add(Instruction.Forward);
                        break;
                    default: throw new ArgumentException();
                }

            return parsedInstructions;
        }
    }
}