using System;
using PizzaDeliveryBot.Helpers;
using static PizzaDeliveryBot.Models.DeliveryRoute;
using static PizzaDeliveryBot.Models.DeliveryBot;

namespace PizzaDeliveryBot.Logic
{
    internal class RunDeliveryRoute
    {
        internal static void DeliverPizza()
        {
            CurrentLocation = Deliveries[0].StartingLocation;
            CurrentFacingDirection = Deliveries[0].StartingFacingDirection;

            Console.WriteLine($"{Deliveries.Count} orders have been placed." + Environment.NewLine);

            for (int i = 0; i < Deliveries.Count; i++)
            {
                Console.WriteLine($"The delivery bot has TELEPORTED at coordinates {ConsoleOutput.GetCoordinatesWithSign(Deliveries[i].StartingLocation)}, " +
                                  $"facing {Deliveries[i].StartingFacingDirection.ToString().ToUpper()}.");

                foreach (Instruction instruction in Deliveries[i].Route)
                    switch (instruction)
                    {
                        case Instruction.Left:
                            TurnLeft();
                            break;
                        case Instruction.Right:
                            TurnRight();
                            break;
                        case Instruction.Forward:
                            MoveForward();
                            break;
                        default: throw new ArgumentException();
                    }

                Console.WriteLine($"The delivery bot has COMPLETED DELIVERY #{i + 1}, " +
                                  $"at coordinates {ConsoleOutput.GetCoordinatesWithSign(Deliveries[i].EndingLocation)}, " +
                                  $"facing {Deliveries[i].EndingFacingDirection.ToString().ToUpper()}." +
                                  Environment.NewLine);
            }
        }
    }
}