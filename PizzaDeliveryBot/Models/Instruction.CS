using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public class Instruction
    {
        private const string Left = "Left";
        private const string Right = "Right";
        private const string Forward = "Forward";

        public string ParseInstruction(string instruction)
        {
            return instruction switch
            {
                "L" => Left,
                "R" => Right,
                "F" => Forward,
                _ => throw new ArgumentException()
            };
        }

        public List<string> ParseInstructions(string instructions)
        {
            List<string> parsedInstructions = new List<string>();

            foreach (char instruction in instructions)
                switch (instruction.ToString())
                {
                    case "L":
                        parsedInstructions.Add(Left);
                        break;
                    case "R":
                        parsedInstructions.Add(Right);
                        break;
                    case "F":
                        parsedInstructions.Add(Forward);
                        break;
                    default: throw new ArgumentException();
                }

            return parsedInstructions;
        }
    }
}