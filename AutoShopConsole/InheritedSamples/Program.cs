using System;
using System.Collections.Generic;

namespace InheritedSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolo kolo = new Kolo("Maciek");

            Console.WriteLine(kolo.GetNameAsString());
        }
    }
}
