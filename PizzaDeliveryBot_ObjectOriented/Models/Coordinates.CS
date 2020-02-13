namespace PizzaDeliveryBot.Models
{
    internal class Coordinates
    {
        internal Coordinates(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        internal int X { get; set; }
        internal int Y { get; set; }
    }
}