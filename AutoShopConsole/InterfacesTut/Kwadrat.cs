using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTut
{
    public class Kwadrat : Figura, IObliczeniaFigur
    {
        private int a;
        private int b;

        public double ObliczDlugoscOdcinka()
        {
            throw new NotImplementedException();
        }

        public double ObliczPoj()
        {
            throw new NotImplementedException();
        }

        public double ObliczPole()
        {
            return a * b;
        }
    }
}
