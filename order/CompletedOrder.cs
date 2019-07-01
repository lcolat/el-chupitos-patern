using System;

namespace el_chupitos_pattern.order
{
    public class CompletedOrder : IOrderState
    {
        public void Action(Order context)
        {
            Console.WriteLine("Order is completed", context.drinks.ToString());
        }
    }
}