using System;

namespace el_chupitos_pattern.order
{
    public class OrderDelivery : IOrderState
    {
        public void Action(Order context)
        {
            Console.WriteLine("Order is in delivery", context.drinks.ToString());
        }
    }
}