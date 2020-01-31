using System.Drawing;

namespace PizzaDeliveryBot.Models
{
    internal class Coordinates
    {
        private int _X;
        private Point _XY;
        private int _Y;

        public Coordinates(int X, int Y)
        {
            _X = X;
            _Y = Y;
            _XY = new Point(X, Y);
        }
    }
}