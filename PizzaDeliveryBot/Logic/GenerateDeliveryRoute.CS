using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaDeliveryBot.Helpers;
using PizzaDeliveryBot.Models;

namespace PizzaDeliveryBot.Logic
{
    public static class GenerateDeliveryRoute
    {
        public static readonly List<string> Orders = OrdersParser.GetSanitizedOrders();

        public static List<Delivery> BuildRoute()
        {
            if (!InputDataValidation.ValidateOrders(Orders)) throw new ValidationException();

            List<Delivery> deliveries = new List<Delivery>();

            for (int i = 0; i <= Orders.Count - 3; i += 3)
            {
                Delivery delivery = new Delivery // TODO: Make This Prettier
                {
                    StartingLocation = Tuple.Create(int.Parse(Orders[i][0].ToString()), int.Parse(Orders[i][1].ToString())),
                    StartingFacingDirection = DirectionParser.ParseDirection(Orders[i][2].ToString()),
                    Route = InstructionsParser.ParseInstructions(Orders[i + 1]),
                    EndingLocation = Tuple.Create(int.Parse(Orders[i + 2][0].ToString()), int.Parse(Orders[i + 2][1].ToString())),
                    EndingFacingDirection = DirectionParser.ParseDirection(Orders[i + 2][2].ToString())
                };

                deliveries.Add(delivery);
            }

            return deliveries;
        }
    }
}