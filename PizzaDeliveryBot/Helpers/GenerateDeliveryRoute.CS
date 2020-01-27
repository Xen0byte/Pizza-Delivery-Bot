using System;
using System.Collections.Generic;
using System.Text;
using Environment = PizzaDeliveryBot.Settings.Environment;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PizzaDeliveryBot.Helpers
{
    static class GenerateDeliveryRoute
    {
        private static readonly List<string> RawSourceFileLines = File.ReadAllLines(Environment.SourceFile).ToList();
        private static readonly List<string> SanitizedSourceFileLines = SanitizeSourceFileLines();

        private static List<string> SanitizeSourceFileLines() => RawSourceFileLines.Select(line => line.Replace(" ", "")).Where(sanitizedLine => !string.IsNullOrEmpty(sanitizedLine)).ToList();
    }
}
