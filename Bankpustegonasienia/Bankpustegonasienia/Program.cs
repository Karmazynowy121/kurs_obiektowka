using System;

namespace Bankpustegonasienia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kontobankowe krzysztof = new kontobankowe();
            Logowanie Krzysztof = new Logowanie("Krzysztof", "Krzysiu12", true, 9);
            kontobankowe mandaryn = new kontobankowe();
            Logowanie Mandaryn = new Logowanie("Mandaryn", "mandarynian69", false, 10);

            int t = mandaryn.Getnumerkonta();
            Console.WriteLine(mandaryn.Getnumerkonta());
            int k = krzysztof.Getnumerkonta();
            Console.WriteLine(krzysztof.Getnumerkonta()+ 2);


            bool wpłać = mandaryn.wpłata(10000);
            if (wpłać)
            {
                Console.WriteLine("Udana wpłata na konto" + t);
                Console.WriteLine(mandaryn.pokazsaldo());
            }
            double wypłata = mandaryn.wypłać(500);
            Console.WriteLine(wypłata);
            
        }
    }
}
