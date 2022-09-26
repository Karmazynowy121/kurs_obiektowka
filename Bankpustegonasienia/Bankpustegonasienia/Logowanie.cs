using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankpustegonasienia
{
    public class Logowanie
    {
        public string Name;
        public string Password;

        public bool RememberMe;
        public int AccNumber;
        public Logowanie(string name, string password, bool rememberMe, int accNumber)
        {
            Name = name;
            Password = password;
            RememberMe = rememberMe;
            AccNumber = accNumber;

        }

    }
}
