using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedSamples
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string speciesName) 
            : base(name, age, new Species(speciesName))
        {
        }

        public override void DoVoice()
        {
            Console.WriteLine($"Wof Wof");
        }
    }
}
