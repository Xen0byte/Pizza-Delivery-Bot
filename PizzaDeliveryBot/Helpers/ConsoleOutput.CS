using System;
using PizzaDeliveryBot.Models;

namespace PizzaDeliveryBot.Helpers
{
    internal static class ConsoleOutput
    {
        internal static string GetCoordinatesWithSign(Coordinates coordinates)
        {
            if (coordinates.Item1 >= 0 && coordinates.Item2 >= 0) return $"+{coordinates.Item1:D2}:+{coordinates.Item2:D2}";
            if (coordinates.Item1 >= 0) return $"+{coordinates.Item1:D2}:{coordinates.Item2:D2}";
            if (coordinates.Item2 >= 0) return $"{coordinates.Item1:D2}:+{coordinates.Item2:D2}";

            throw new ArgumentException();
        }
    }
}