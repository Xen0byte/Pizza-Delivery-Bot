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
                switch (i % 3)
                {
                    case 1:
                    case 3:
                        if ((Orders[i - 1].Length == 3 && Orders[i - 1].All(char.IsLetterOrDigit)) == false) return false;
                        break;

                    case 2:
                        if (Orders[i - 1].All(char.IsLetter) == false) return false;
                        break;
                }

            return true;
        }
    }
}