using System;

namespace AlgorytmySortowania
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Podaj liczbę w zbiorze do posrotowania: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            Sort buble = new Sort(liczba);

            Console.WriteLine();
        }


    }
}