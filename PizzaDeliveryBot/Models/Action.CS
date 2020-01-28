using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PizzaDeliveryBot.Models
{
    public class Action
    {
        public Tuple<int, int> StartingLocation { get; set; }
        public Direction StartingFacingDirection { get; set; }
        public Instruction Instruction { get; set; }
        public Tuple<int, int> EndingLocation { get; set; }
        public Direction EndingFacingDirection { get; set; }

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
