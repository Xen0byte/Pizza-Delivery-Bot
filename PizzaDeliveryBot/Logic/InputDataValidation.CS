using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PizzaDeliveryBot.Logic
{
    internal static class InputDataValidation
    {
        internal static bool ValidateOrders(List<string> orders)
        {
            if (orders.Count % 3 != 0) return false;

            for (int i = 1; i <= orders.Count; i++)
                switch (i % 3)
                {
                    case 1:
                    case 3:
                        // Intentionally Capped To Two-Digit Coordinates; For N-Digit Coordinates, Change {1,2} To {1,N}
                        if (!Regex.IsMatch(orders[i - 1], @"(?<position>(?<x>[0-9]{1,2})\s*(?<y>[0-9]{1,2})\s*(?<direction>[NnEeSsWw]{1}))")) return false;
                        break;

                    case 2:
                        // Intentionally Set To Look For Instruction Sets That Are Four Digits And More; To Lower The Limit To N, Change {4,} To {N,}
                        if (!Regex.IsMatch(orders[i - 1], @"(?<instructions>[LlRrFf]{4,})")) return false;
                        break;
                }

            return true;
        }
    }
}