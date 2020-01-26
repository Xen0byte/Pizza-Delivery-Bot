using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace PizzaDeliveryBot
{
    interface IDeliveryBot
    {
        Tuple<int, int> CurrentCoordinates { get; set; }
        Direction FacingDirection { get; set; }

        void Move(Direction direction);
    }
}
