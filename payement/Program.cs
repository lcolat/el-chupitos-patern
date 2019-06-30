using System;

namespace payement
{
    class Program
    {
        static void Main(string[] args)
        {
            PayementMethod payementMethod = new PayementMethod();

            Console.WriteLine("Indiquez le prix");
            var method = Console.ReadLine();
            payementMethod.setMethod(method);

            Console.WriteLine("Quel type de payement utiliser?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch(input){
                case 1:
                    payementMethod.setPayementStrategy(new cash());
                    payementMethod.Payement();
                    break;
                case 2:
                    payementMethod.setPayementStrategy(new cb());
                    payementMethod.Payement();
                    break;
                case 3:
                    payementMethod.setPayementStrategy(new cheque());
                    payementMethod.Payement();
                    break;
                default:
                    Console.WriteLine("Selection invalide");
                    break;
            }
        }
    }
}
