using System;
using System.Collections.Generic;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Helpers
{
    internal static class InstructionsParser
    {
        internal static List<Instruction> ParseInstructions(string instructions)
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