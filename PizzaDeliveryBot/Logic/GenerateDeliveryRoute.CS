using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaDeliveryBot.Helpers;
using PizzaDeliveryBot.Models;

namespace PizzaDeliveryBot.Logic
{
    internal static class GenerateDeliveryRoute
    {
        private static readonly List<string> Orders = OrdersParser.GetSanitizedOrders();
        private static readonly List<Delivery> DeliveryRoute = BuildRoute();

        private static bool ValidateOrders()
        {
            if (Orders.Count % 3 != 0) return false;


            for (int i = 1; i <= Orders.Count; i++)
                switch (i % 3)
                {
                    case 1:
                    case 3:
                        if ((Orders[i - 1].Length == 3 && Orders[i - 1].All(char.IsLetterOrDigit)) == false) return false; //TODO: Make Validation More Strict (RegEx Match)
                        break;

                    case 2:
                        if (Orders[i - 1].All(char.IsLetter) == false) return false; //TODO: Make Validation More Strict (RegEx Match)
                        break;
                }

            return true;
        }

        private static List<Delivery> BuildRoute()
        {
            if (!ValidateOrders()) throw new ValidationException();

            List<Delivery> deliveries = new List<Delivery>();

            for (int i = 0; i <= Orders.Count - 3; i += 3)
            {
                Delivery delivery = new Delivery
                {
                    StartingLocation = Tuple.Create(int.Parse(Orders[i][0].ToString()), int.Parse(Orders[i][1].ToString())),
                    StartingFacingDirection = new Direction().ParseDirection(Orders[i][2].ToString()),
                    Route = new Instruction().ParseInstructions(Orders[i + 1]),
                    EndingLocation = Tuple.Create(int.Parse(Orders[i + 2][0].ToString()), int.Parse(Orders[i + 2][1].ToString())),
                    EndingFacingDirection = new Direction().ParseDirection(Orders[i + 2][2].ToString())
                };

                deliveries.Add(delivery);
            }

            return deliveries;
        }

        public static List<Delivery> GetDeliveryRoute() => DeliveryRoute;
    }
}