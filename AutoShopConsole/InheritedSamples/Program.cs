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

            //animals.Add(new Dog("Cociel Spaniel", 4, "Canis familiaris"));
            //animals.Add(new Cat("Dachowiec", 14, "Perski"));

            //foreach (var item in animals)
            //{
            //    item.DoVoice();
            //    item.WhatIsThat();
            //}

        }
    }
}
