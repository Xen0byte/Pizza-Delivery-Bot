namespace PizzaDeliveryBot.Models
{
    internal class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        internal Coordinates(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        internal Coordinates NewX(int newX) => new Coordinates(newX, Y);
        internal Coordinates NewY(int newY) => new Coordinates(X, newY);
    }
}