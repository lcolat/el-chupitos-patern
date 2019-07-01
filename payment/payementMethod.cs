using System;
using System.Text;

namespace el_chupitos_pattern.payment
{
    abstract class PaymentStrategy{
        public abstract void Payement(string method);
    }

    class Cash : PaymentStrategy{
        public override void Payement(string method){
            Console.WriteLine("\nPayement " + method + "€ par cash");
        }
    }

    class CreditCard : PaymentStrategy{
        public override void Payement(string method){
            Console.WriteLine("\nPayement " + method + "€ par CB");
        }
    }

    class Cheque : PaymentStrategy{
        public override void Payement(string method){
            Console.WriteLine("\nPayement " + method + "€ par cheque");
        }
    }

    class PaymentMethod{
        private string Method;
        private PaymentStrategy _paymentStrategy;

        public void setPaymentStrategy(PaymentStrategy paymentStrategy){
            this._paymentStrategy = paymentStrategy;
        }

        public void setMethod(string name){
            Method = name;
        }

        public void Payement(){
            _paymentStrategy.Payement(Method);
            Console.WriteLine();
        }
    }
}