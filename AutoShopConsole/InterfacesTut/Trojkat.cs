using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTut
{
    public class Trojkat : Figura, IObliczeniaFigur
    {
        private int a;
        private int b;
        private int c;

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
            return 1 / 2 * a * PitaPita();
        }

        private double PitaPita()
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2);
        }
    }
}
