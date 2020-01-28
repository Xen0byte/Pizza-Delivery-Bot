using System;

namespace PizzaDeliveryBot.Models
{
    public static class Action
    {
        public static Tuple<int, int> StartingLocation { get; set; }
        public static DeliveryBot.Direction StartingFacingDirection { get; set; }
        public static Tuple<int, int> EndingLocation { get; set; }
        public static DeliveryBot.Direction EndingFacingDirection { get; set; }

        private static void TurnLeft()
        {
        }

        private static void TurnRight()
        {
        }

        private static void MoveForward()
        {
        }
    }
}