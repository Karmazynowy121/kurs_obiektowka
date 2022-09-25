using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopConsole_v2
{
    public class Auto
    {
        public Brand Brand;
        private int LiczbaDrzwi;
        private double PojSilnika;

        public Auto()
        {
        }


        public Auto(string nazwa, string marka, int ldrzwi, double poj)
        {
            LiczbaDrzwi = ldrzwi;
            PojSilnika = poj;
            Brand = new Brand(nazwa, marka);
        }

        public string GetAutoDataAsString()
        {
            return $"Samochód: {Brand.Nazwa} {Brand.Marka}, Liczba drzwi: {LiczbaDrzwi}, poj: {PojSilnika}";
        }
    }
}
