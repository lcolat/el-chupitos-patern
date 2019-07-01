using System;

namespace el_chupitos_pattern.order
{
    public class PendingOrder : IOrderState
    {
        public void Action(Order context)
        {
            Console.WriteLine("Order is pending", context.drinks.ToString());
        }
    }
}