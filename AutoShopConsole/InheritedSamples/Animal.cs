using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedSamples
{
    public abstract class Animal
    {
        public string Name;
        public int Age;
        
        public Species Species;

        public Animal(string name, int age, Species species)
        {
            Name = name;
            Age = age;    
            Species = species;
        }

        public abstract void DoVoice();

        public virtual void ShowVoice()
        {
            Console.WriteLine($"This is a {Name}, has a {Age} year old");
        }

        public void WhatIsThat()
        {
            Console.WriteLine($"This is a {Name}, has a {Age} year old"); 
        }
    }
}
