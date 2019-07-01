using System;

namespace stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEPART \n \n");
            Stock s = new Stock();
            IStockItem C = new Confiture("fraise",10);
            s.AddItem("fraise", 6);
            Console.WriteLine(s.Item);
            Console.WriteLine("\n\nFIN");
        }
    }
}
