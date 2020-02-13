using System;
using PizzaDeliveryBot.Models;

namespace PizzaDeliveryBot.Helpers
{
    internal static class ConsoleOutput
    {
        internal static string GetCoordinatesWithSign(Coordinates coordinates)
        {
            if (coordinates.X >= 0 && coordinates.Y >= 0) return $"+{coordinates.X:D2}:+{coordinates.Y:D2}";
            if (coordinates.X >= 0) return $"+{coordinates.X:D2}:{coordinates.Y:D2}";
            if (coordinates.Y >= 0) return $"{coordinates.X:D2}:+{coordinates.Y:D2}";

            throw new ArgumentException();
        }
    }
}