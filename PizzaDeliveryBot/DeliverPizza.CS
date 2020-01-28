using System;
using PizzaDeliveryBot.Logic;

namespace PizzaDeliveryBot
{
    internal class DeliverPizza
    {
        private static void Main()
        {
            Console.WriteLine(GenerateDeliveryRoute.GetDeliveryRoute());
        }
    }
}