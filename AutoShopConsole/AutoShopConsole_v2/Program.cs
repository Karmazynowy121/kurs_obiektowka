using System;
using System.Collections.Generic;

namespace AutoShopConsole_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>();


            Auto auto = new Auto("Ibiza", "Seat", 5, 1.2);

            autos.Add(auto);
            autos.Add(new Auto());


          

            foreach (Auto a in autos)
            {
                if (a.Brand.Nazwa == "Opel")
                {
                    autos.Remove(a);
                }
            }


            string valueS = auto.GetAutoDataAsString(); 
            Console.WriteLine(valueS);
        }
    }
}
