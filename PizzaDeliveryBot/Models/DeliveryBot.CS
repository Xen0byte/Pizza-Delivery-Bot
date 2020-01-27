using System;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryBot   /* DeliveryBot Is A Singleton */
    {
        public static Tuple<int, int> CurrentCoordinates = DeliveryRoute.SetStartingCoordinates();
        public static Direction FacingDirection = DeliveryRoute.SetStartingFacingDirection();

        public static void Move(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
