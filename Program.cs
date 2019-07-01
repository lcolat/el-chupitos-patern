using System;
using System.Text;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.Drink.ingredient;
using el_chupitos_pattern.drink.simpleDrink;
using el_chupitos_pattern.payment;
using el_chupitos_pattern.stock;
using el_chupitos_pattern.order;

namespace el_chupitos_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = Stock.GetInstance();
            InitStock(stock);
            Console.OutputEncoding = Encoding.UTF8;
            
            PaymentMethod paymentMethod = new PaymentMethod();

            Console.WriteLine("Indiquez le prix");
            var method = Console.ReadLine();
            paymentMethod.setMethod(method);

            Console.WriteLine("Quel type de payement utiliser?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch(input){
                case 1:
                    paymentMethod.setPaymentStrategy(new Cash());
                    paymentMethod.Payement();
                    break;
                case 2:
                    paymentMethod.setPaymentStrategy(new CreditCard());
                    paymentMethod.Payement();
                    break;
                case 3:
                    paymentMethod.setPaymentStrategy(new Cheque());
                    paymentMethod.Payement();
                    break;
                default:
                    Console.WriteLine("Selection invalide");
                    break;
            }
            PinaColada pinaColada = new PinaColada(stock);
            pinaColada.Display();
            Pineapple pinappleExtra = new Pineapple(pinaColada, stock);
            pinappleExtra.AddExtra(2);
            pinappleExtra.Display();
            Lime limeExtra = new Lime(pinaColada, stock);
            limeExtra.AddExtra(1);
            limeExtra.Display();
            pinaColada.Display();
            Console.WriteLine("DEPART \n \n");
            
            IStockItem C = new Confiture("fraise",10);
            stock.AddItem("fraise", 6);
            Console.WriteLine(stock.Item);
            Console.WriteLine("\n\nFIN");
            
            Order order = new Order();
            order.AddDrink(limeExtra);
            order.AddDrink(pinaColada);

            Console.WriteLine("Order price : " + order.GetPrice());

            order.SetState(new PendingOrder());
            order.Action();

            order.SetState(new OrderDelivery());
            order.Action();

            order.SetState(new CompletedOrder());
            order.Action();
        }

        private static void InitStock(Stock stock)
        {
            stock.AddItem(Lime.NAME, 10);
            stock.AddItem(CoconutMilk.NAME, 10);
            stock.AddItem(Pineapple.NAME, 10);
            stock.AddItem(Rum.NAME, 5);
            stock.AddItem(Coca.NAME, 5);
        }
    }
}
