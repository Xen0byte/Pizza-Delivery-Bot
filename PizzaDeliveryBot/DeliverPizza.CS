using System;
using System.IO;
using PizzaDeliveryBot.Logic;
using Environment = PizzaDeliveryBot.Settings.Environment;

namespace PizzaDeliveryBot
{
    internal class DeliverPizza
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1 && File.Exists(args[0])) Environment.SourceFile = args[0];
            if ((args.Length == 1 && !File.Exists(args[0])) || args.Length > 1) throw new ArgumentException();

            RunDeliveryRoute.DeliverPizza();
        }
    }
}