namespace PizzaDeliveryBot.Models
{
    public static class DeliveryBot
    {
        public enum Direction
        {
            North,
            East,
            South,
            West
        }

        public enum Instruction
        {
            Left,
            Right,
            Forward
        }
    }
}