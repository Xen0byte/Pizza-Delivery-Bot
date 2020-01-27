using System.Collections.Generic;
using System.IO;
using System.Linq;
using PizzaDeliveryBot.Settings;

namespace PizzaDeliveryBot.Helpers
{
    internal static class OrdersParser
    {
        private static readonly List<string> RawSourceFileLines = File.ReadAllLines(Environment.SourceFile).ToList();
        private static readonly List<string> SanitizedSourceFileLines = SanitizeSourceFileLines();

        private static List<string> SanitizeSourceFileLines() =>
            RawSourceFileLines.
                Select(line => line.Replace(" ", "")).
                Where(sanitizedLine => !string.IsNullOrEmpty(sanitizedLine)).ToList();

        public static List<string> GetSanitizedOrders() => SanitizedSourceFileLines;
    }
}