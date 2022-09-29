using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankpustegonasienia
{
    public class kontobankowe
    {
        static int count = 100;
        private int numerkonta;
        private double saldo = 0;
        

        public kontobankowe()
        {
            count=count+1;
            numerkonta = count;
        }
      public int Getnumerkonta()
        {
            return numerkonta;
        }
        public bool wpłata(double kasa)
        {
            double staresaldo = saldo;
            saldo = saldo + kasa;
            if (saldo == staresaldo + kasa)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public string pokazsaldo()
        {
            return "Account balance is" + saldo + "zł";
        }
        public double wypłać(double kwota)
        {
            if (saldo > (kwota + 500))
            {
                saldo = saldo - kwota;
                Console.WriteLine("udało się wypłacić pieniądze");
            }
            else
            {
                Console.WriteLine("nie udało się wypłacić pieniędzy");
            }
            return saldo;
        }
        public bool transfer()
        {
           if ()
            {

            }
        }
    }
}
