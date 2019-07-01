using System;
using el_chupitos_pattern.payment;

namespace payement
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod payementMethod = new PaymentMethod();

            Console.WriteLine("Indiquez le prix");
            var method = Console.ReadLine();
            payementMethod.setMethod(method);

            Console.WriteLine("Quel type de payement utiliser?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch(input){
                case 1:
                    payementMethod.setPaymentStrategy(new Cash());
                    payementMethod.Payement();
                    break;
                case 2:
                    payementMethod.setPaymentStrategy(new CreditCard());
                    payementMethod.Payement();
                    break;
                case 3:
                    payementMethod.setPaymentStrategy(new Cheque());
                    payementMethod.Payement();
                    break;
                default:
                    Console.WriteLine("Selection invalide");
                    break;
            }
        }
    }
}
