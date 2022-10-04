using ExceptionsTutorial.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTutorial
{
    public class Examples
    {
        private List<User> users;

        public Examples()
        {
            users = new() 
            { 
                new User(0, "email0@example.com", "secret1234"),
                new User(1, "email1@example.com", "secret1234"), 
                new User(2, "email2@example.com", "secret1234"),
                new User(3, "email3@example.com", "secret1234"),
                new User(4, "email4@example.com", "secret1234"),
                new User(5, "email5@example.com", "secret1234") 
            };
        }

        public double Devide(double a, double b)
        {
            if (b == 0)
            {
                return double.NaN;
            }

            return a / b;
        }

        

        public double TryDevide(double a, double b)
        {
            if (b == 0)
            {
                throw new MyOwnException(0,"Can't devide for zero!");
            }

            return a / b;
        }

    }
}
