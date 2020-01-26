using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryBot
{
    class DeliveryBot : IDeliveryBot
    {
        public Tuple<int, int> CurrentCoordinates { get; set; }
        public Direction FacingDirection { get; set; }
        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
