using System;
namespace payement
{
    abstract class PayementStrategy{
        public abstract void Payement(string method);
    }

    class cash : PayementStrategy{
        public override void Payement(string method){
            Console.WriteLine("\nPayement " + method + "e par cash");
        }
    }

    class cb : PayementStrategy{
        public override void Payement(string method){
            Console.WriteLine("\nPayement " + method + "e par CB");
        }
    }

    class cheque : PayementStrategy{
        public override void Payement(string method){
            Console.WriteLine("\nPayement " + method + "e par cheque");
        }
    }

    class PayementMethod{
        private string Method;
        private PayementStrategy _payementStrategy;

        public void setPayementStrategy(PayementStrategy payementStrategy){
            this._payementStrategy = payementStrategy;
        }

        public void setMethod(string name){
            Method = name;
        }

        public void Payement(){
            _payementStrategy.Payement(Method);
            Console.WriteLine();
        }
    }
}