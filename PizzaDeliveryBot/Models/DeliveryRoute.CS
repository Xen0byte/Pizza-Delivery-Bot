using System;
using System.Collections.Generic;

namespace PizzaDeliveryBot.Models
{
    public static class DeliveryRoute /* DeliveryRoute Is A Singleton */
    {
        public static List<Delivery> Deliveries;

        public static Tuple<int, int> SetStartingCoordinates()
        {
            throw new NotImplementedException();
        }

        public static Direction SetStartingFacingDirection()
        {
            throw new NotImplementedException();
        }
    }
}