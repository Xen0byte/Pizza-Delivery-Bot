using System.Collections.Generic;
using System.Linq;
using PizzaDeliveryBot.Helpers;

namespace PizzaDeliveryBot.Logic
{
    internal static class GenerateDeliveryRoute
    {
        private static readonly List<string> Orders = OrdersParser.GetSanitizedOrders();

        private static bool ValidateOrders()
        {
            if (Orders.Count % 3 != 0) return false;


            for (int i = 1; i <= Orders.Count; i++)
            {
                if ((i % 3 != 2 && Orders[i].Length == 3 && Orders[i].All(char.IsLetterOrDigit)) == false) return false;

                if ((i % 3 == 2 && Orders[i].All(char.IsLetter)) == false) return false;
            }

            return true;
        }
    }
}