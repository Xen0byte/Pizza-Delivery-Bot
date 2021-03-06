﻿using System;
using static PizzaDeliveryBot.Helpers.ConsoleOutput;
using static PizzaDeliveryBot.Models.DeliveryRoute;

namespace PizzaDeliveryBot.Models

{
    internal static class DeliveryBot
    {
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

            Console.WriteLine($"[{GetCoordinatesWithSign(CurrentLocation)}:{directionStore.ToString()[0]}] " +
                              $"The delivery bot has TURNED LEFT. His new facing direction is {CurrentFacingDirection.ToString().ToUpper()}.");
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

            Console.WriteLine($"[{GetCoordinatesWithSign(CurrentLocation)}:{directionStore.ToString()[0]}] " +
                              $"The delivery bot has TURNED RIGHT. His new facing direction is {CurrentFacingDirection.ToString().ToUpper()}.");
        }

        internal static void MoveForward()
        {
            Coordinates coordinatesStore = CurrentLocation;

            CurrentLocation = CurrentFacingDirection switch
            {
                Direction.North => new Coordinates(CurrentLocation.X, CurrentLocation.Y + 1),
                Direction.East => new Coordinates(CurrentLocation.X + 1, CurrentLocation.Y),
                Direction.South => new Coordinates(CurrentLocation.X, CurrentLocation.Y - 1),
                Direction.West => new Coordinates(CurrentLocation.X - 1, CurrentLocation.Y),
                _ => throw new ArgumentException()
            };

            Console.WriteLine($"[{GetCoordinatesWithSign(coordinatesStore)}:{CurrentFacingDirection.ToString()[0]}] " +
                              $"The delivery bot has MOVED FORWARD. His new coordinates are [{GetCoordinatesWithSign(CurrentLocation)}].");
        }

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
    }
}