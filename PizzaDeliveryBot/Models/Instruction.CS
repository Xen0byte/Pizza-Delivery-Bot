using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryBot.Models
{
    public class Instruction
    {
        public Instruction Left { get; set; }
        public Instruction Right { get; set; }
        public Instruction Forward { get; set; }

        public Instruction ParseInstruction(string instruction)
        {
            return instruction switch
            {
                "L" => Left,
                "R" => Right,
                "F" => Forward,
                _ => throw new ArgumentException()
            };
        }

        public List<Instruction> ParseInstructions (string instructions)
        {
            List<Instruction> parsedInstructions = new List<Instruction>();

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
