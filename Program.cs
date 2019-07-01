using System;
using System.Text;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.Drink.ingredient;
using el_chupitos_pattern.payment;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
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
            PinaColada pinaColada = new PinaColada();
            pinaColada.Display();
            Pineapple pinappleExtra = new Pineapple(pinaColada);
            pinappleExtra.AddExtra(2);
            pinappleExtra.Display();
            Lime limeExtra = new Lime(pinaColada);
            limeExtra.AddExtra(1);
            limeExtra.Display();
            pinaColada.Display();
            Console.WriteLine("DEPART \n \n");
            Stock s = new Stock();
            IStockItem C = new Confiture("fraise",10);
            s.AddItem("fraise", 6);
            Console.WriteLine(s.Item);
            Console.WriteLine("\n\nFIN");
        }
    }
}
