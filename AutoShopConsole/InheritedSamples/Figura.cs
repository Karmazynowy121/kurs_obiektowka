using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritedSamples
{
    public class Figura
    {
        public string Name;

        public Figura(string name)
        {
            Name = name;
        }

        public virtual string GetNameAsString()
        {
            return $"Tutaj mamy klasę bazową i jej właściwość name: {Name}";
        }
    }
}
