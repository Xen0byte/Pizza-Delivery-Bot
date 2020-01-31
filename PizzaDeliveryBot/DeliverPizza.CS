using System;
using System.IO;
using PizzaDeliveryBot.Logic;
using PizzaDeliveryBot.Models;
using Environment = PizzaDeliveryBot.Settings.Environment;

namespace PizzaDeliveryBot
{
    internal class DeliverPizza
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1 && File.Exists(args[0])) Environment.SourceFile = args[0];
            if (args.Length == 1 && !File.Exists(args[0]) || args.Length > 1) throw new ArgumentException();

            // RunDeliveryRoute.DeliverPizza();

            Coordinates coords = new Coordinates(1,1);
            Console.WriteLine(coords.X.ToString() + coords.Y.ToString());
            Coordinates coords2 = coords.NewX(2);
            Console.WriteLine(coords.X.ToString() + coords.Y.ToString());
            Console.WriteLine(coords2.X.ToString() + coords2.Y.ToString());
            Console.WriteLine(coords.X.ToString() + coords.NewY(2).Y.ToString());
        }
    }
}