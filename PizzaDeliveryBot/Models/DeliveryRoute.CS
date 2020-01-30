using System;
using System.Collections.Generic;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryRoute
    {
        public static Tuple<int, int> CurrentLocation { get; set; }
        public static DeliveryBot.Direction CurrentFacingDirection { get; set; }

        public static List<Delivery> Deliveries = Logic.GenerateDeliveryRoute.BuildRoute();

        public static void TurnLeft()
        {
            DeliveryBot.Direction directionStore = CurrentFacingDirection;

            CurrentFacingDirection = CurrentFacingDirection switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => throw new ArgumentException(),
            };

            Console.WriteLine($"[{CurrentLocation.Item1:D2}:{CurrentLocation.Item2:D2}:{directionStore.ToString()[0]}] The delivery bot has TURNED LEFT. His new facing direction is {CurrentFacingDirection}.");
        }

        public static void TurnRight()
        {
            DeliveryBot.Direction directionStore = CurrentFacingDirection;

            CurrentFacingDirection = CurrentFacingDirection switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => throw new ArgumentException(),
            };

            Console.WriteLine($"[{CurrentLocation.Item1:D2}:{CurrentLocation.Item2:D2}:{directionStore.ToString()[0]}] The delivery bot has TURNED RIGHT. His new facing direction is {CurrentFacingDirection}.");
        }

        public static void MoveForward()
        {
            Tuple<int, int> coordinatesStore = CurrentLocation;

            switch (CurrentFacingDirection)
            {
                case Direction.North: break;
                case Direction.East: break;
                case Direction.South: break;
                case Direction.West: break;
                default: throw new ArgumentException();
            }
        }
    }
}