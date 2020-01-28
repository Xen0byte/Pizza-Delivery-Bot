using System;

namespace PizzaDeliveryBot.Models
{
    public class Action
    {
        public Tuple<int, int> StartingLocation { get; set; }
        public string StartingFacingDirection { get; set; }
        public Instruction Instruction { get; set; }
        public Tuple<int, int> EndingLocation { get; set; }
        public string EndingFacingDirection { get; set; }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }

        public void MoveForward()
        {
        }
    }
}