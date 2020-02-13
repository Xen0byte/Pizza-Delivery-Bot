using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaDeliveryBot.Helpers;
using PizzaDeliveryBot.Models;

namespace PizzaDeliveryBot.Logic
{
    internal static class GenerateDeliveryRoute
    {
        internal static readonly List<string> Orders = OrdersParser.GetSanitizedOrders();

        internal static List<Order> BuildRoute()
        {
            if (!InputDataValidation.ValidateOrders(Orders)) throw new ValidationException();

            List<Order> orders = new List<Order>();

            for (int i = 0; i <= Orders.Count - 3; i += 3)
            {
                Order order = new Order // TODO: Use The RegEx In InputDataValidation To Validate AND Build The Route (Saves One Iteration Through The Input Data)
                {
                    StartingLocation = new Coordinates(int.Parse(Orders[i][0].ToString()), int.Parse(Orders[i][1].ToString())),
                    StartingFacingDirection = DirectionParser.ParseDirection(Orders[i][2].ToString()),
                    Route = InstructionsParser.ParseInstructions(Orders[i + 1]),
                    EndingLocation = new Coordinates(int.Parse(Orders[i + 2][0].ToString()), int.Parse(Orders[i + 2][1].ToString())),
                    EndingFacingDirection = DirectionParser.ParseDirection(Orders[i + 2][2].ToString())
                };

                orders.Add(order);
            }

            return orders;
        }
    }
}