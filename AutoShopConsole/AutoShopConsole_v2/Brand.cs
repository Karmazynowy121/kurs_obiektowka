using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopConsole_v2
{
    public class Brand
    {
        public readonly string Nazwa;
        public readonly string Marka;

        public Brand(string nazwa, string marka)
        {
            Nazwa = nazwa;
            Marka = marka;
        }
    }
}
