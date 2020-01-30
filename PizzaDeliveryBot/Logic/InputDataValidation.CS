using System.Collections.Generic;
using System.Linq;

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
                        if ((orders[i - 1].Length == 3 && orders[i - 1].All(char.IsLetterOrDigit)) == false) return false; //TODO: Make Validation More Strict (RegEx Match)
                        break;

                    case 2:
                        if (orders[i - 1].All(char.IsLetter) == false) return false; //TODO: Make Validation More Strict (RegEx Match)
                        break;
                }

            return true;
        }
    }
}