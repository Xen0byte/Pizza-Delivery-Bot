using System;

namespace PizzaDeliveryBot.Models
{
    internal class BotState
    {
        private Tuple<int, int> Location { get; set; }
        private DeliveryBot.Direction FacingDirection { get; set; }

        public BotState(Tuple<int, int> location, DeliveryBot.Direction facingDirection)
        {
            this.Location = location;
            this.FacingDirection = facingDirection;
        }
    }
}