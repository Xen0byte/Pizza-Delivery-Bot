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

        private static bool ValidatePathIntegrity(IReadOnlyList<Tuple<BotState, BotState>> keyStates)
        {
            // TODO: Implement This And Run At The End Of BuildRoute()
        }

        private static List<Delivery> BuildRoute()
        {
            if (!ValidateOrders()) throw new ValidationException();

            List<Delivery> deliveries = new List<Delivery>();
            List<Tuple<BotState, BotState>> keyStates = new List<Tuple<BotState, BotState>>();

            for (int i = 0; i <= Orders.Count - 3; i += 3)
            {
                Delivery delivery = new Delivery
                {
                    StartingLocation = Tuple.Create(int.Parse(Orders[i][0].ToString()), int.Parse(Orders[i][1].ToString())),
                    StartingFacingDirection = DeliveryBot.ParseDirection(Orders[i][2].ToString()),
                    Route = DeliveryBot.ParseInstructions(Orders[i + 1]),
                    EndingLocation = Tuple.Create(int.Parse(Orders[i + 2][0].ToString()), int.Parse(Orders[i + 2][1].ToString())),
                    EndingFacingDirection = DeliveryBot.ParseDirection(Orders[i + 2][2].ToString())
                };

                keyStates.Add(Tuple.Create(new BotState(delivery.StartingLocation, delivery.StartingFacingDirection), new BotState(delivery.EndingLocation, delivery.EndingFacingDirection)));

                deliveries.Add(delivery);
            }

            return deliveries;
        }

        public static List<Delivery> GetDeliveryRoute() => DeliveryRoute;
    }
}