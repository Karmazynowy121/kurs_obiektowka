using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedSamples
{
    public class Kolo : Figura
    {
        public Kolo(string name) 
            : base(name)
        {
            
        }

        public override string GetNameAsString()
        {
            var koloname = $"To jest klasa kolo z właściowścią Name: {Name}. A tutaj z bazowej klasy {base.GetNameAsString()}";
            return koloname;
        }
    }
}
