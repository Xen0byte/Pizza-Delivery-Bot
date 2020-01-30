using System;
using static PizzaDeliveryBot.Models.DeliveryRoute;

namespace PizzaDeliveryBot.Models

{
    internal static class DeliveryBot
    {
        internal enum Direction
        {
            North,
            East,
            South,
            West
        }

        internal enum Instruction
        {
            Left,
            Right,
            Forward
        }

        internal static void TurnLeft()
        {
            Direction directionStore = CurrentFacingDirection;

            CurrentFacingDirection = CurrentFacingDirection switch
            {
                Direction.North => Direction.West,
                Direction.East => Direction.North,
                Direction.South => Direction.East,
                Direction.West => Direction.South,
                _ => throw new ArgumentException()
            };

            Console.WriteLine($"[{CurrentLocation.Item1:D2}:{CurrentLocation.Item2:D2}:{directionStore.ToString()[0]}] The delivery bot has TURNED LEFT. His new facing direction is {CurrentFacingDirection}.");
        }

        internal static void TurnRight()
        {
            Direction directionStore = CurrentFacingDirection;

            CurrentFacingDirection = CurrentFacingDirection switch
            {
                Direction.North => Direction.East,
                Direction.East => Direction.South,
                Direction.South => Direction.West,
                Direction.West => Direction.North,
                _ => throw new ArgumentException()
            };

            Console.WriteLine($"[{CurrentLocation.Item1:D2}:{CurrentLocation.Item2:D2}:{directionStore.ToString()[0]}] The delivery bot has TURNED RIGHT. His new facing direction is {CurrentFacingDirection}.");
        }

        internal static void MoveForward()
        {
            Tuple<int, int> coordinatesStore = CurrentLocation;

            CurrentLocation = CurrentFacingDirection switch
            {
                Direction.North => new Tuple<int, int>(CurrentLocation.Item1, CurrentLocation.Item2 + 1),
                Direction.East => new Tuple<int, int>(CurrentLocation.Item1 + 1, CurrentLocation.Item2),
                Direction.South => new Tuple<int, int>(CurrentLocation.Item1, CurrentLocation.Item2 - 1),
                Direction.West => new Tuple<int, int>(CurrentLocation.Item1 - 1, CurrentLocation.Item2),
                _ => throw new ArgumentException()
            };

            Console.WriteLine($"[{coordinatesStore.Item1:D2}:{coordinatesStore.Item2:D2}:{CurrentFacingDirection.ToString()[0]}] The delivery bot has MOVED FORWARD. His new coordinates are [{CurrentLocation.Item1:D2}:{CurrentLocation.Item2:D2}].");
        }
    }
}