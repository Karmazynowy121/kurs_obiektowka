using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace banki
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.SignUp("Pablo", "0000", "Gorlice", "Biecka");
            bank.SignUp("Kubito", "1111", "Gorlice", "Garbarska");
            bank.Login("Pablo", "0000");
            bank.Login("Kubito", "1111");
            bank.authorizedUser.CreateAccount(1500);
            bank.Transfer(1, "Kubito", 1, 1000);
            bank.authorizedUser.CheckAccountValue(0);
        }
        class Bank
        {
            public User authorizedUser;
            public List<User> users = new List<User>();

            public void SignUp(String username, String password, String city, String street)
            {

                foreach (User user in users)
                {
                    if (user.UserName == username)
                    {
                        Console.WriteLine("Taki login już istnieje, spróbuj inny");
                        return;
                    }
                }
                this.users.Add(new User(username, password, city, street));
            }

            public void Login(String userName, String pass)
            {
                foreach (User user in users)
                {
                    if (user.UserName == userName)
                    {
                        if (user.IsPasswordOk(pass))
                        {
                            Console.WriteLine("Brawo! Zalogowałeś się jako " + user.UserName);
                            authorizedUser = user;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowe hasło!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa nazwa uzytkownika");
                    }
                }
            }

            public void Transfer(int userAccount, String receiverUser, int receiverAccount, double value)
            {
                bool transferOk = false;
                foreach (Account account in authorizedUser.accounts)
                    if (account.accountNumber == userAccount)
                    {
                        if (account.getSaldo() >= value)
                        {
                            account.setSaldo(account.getSaldo() - value); ;
                        }
                    }
                Console.WriteLine("Nie znaleziono konta nadawcy");
                foreach (User user in users)
                {
                    if (user.UserName == receiverUser)
                    {
                        foreach (Account account in user.accounts)
                        {
                            account.setSaldo(account.getSaldo() + value);
                            transferOk = true;
                        }
                    }

                }
                if (transferOk == false)
                {
                    foreach (Account account in authorizedUser.accounts)
                        if (account.accountNumber == receiverAccount)
                        {
                            if (account.getSaldo() >= value)
                            {
                                account.setSaldo(account.getSaldo() + value);
                            }
                        }
                    Console.WriteLine("Przelew nieudany, zwracam hajs na konto");
                }


            }
        }

        class User
        {
            public String UserName;
            private String Password;
            public Adress Adress;
            public List<Account> accounts = new List<Account>();

            public User(string userName, string password, String city, String street)
            {
                this.UserName = userName;
                this.Password = password;
                this.Adress = new Adress(city, street);
            }

            public bool IsPasswordOk(String pass)
            {
                if (pass == Password)
                {
                    return true;
                }
              
                return false;
            }
            public void CreateAccount(double value)
            {
                int newAccountNumber = accounts.Count + 1;

                accounts.Add(new Account(newAccountNumber, value));

            }
            public void CheckAccountValue(int accountNumber)
            {
                foreach (Account account in accounts)
                {
                    if (account.accountNumber == accountNumber)
                    {
                        Console.WriteLine("Konto: " + account.accountNumber + " Saldo: " + account.getSaldo());
                    }
                }
            }

        }

        class Account
        {
            public int accountNumber;
            private double saldo;

            public Account(int accountNumber, double saldo)
            {
                this.accountNumber = accountNumber;
                this.saldo = saldo;
            }

            public double getSaldo()
            {
                return saldo;
            }
            public void setSaldo(double value)
            {
                saldo = value;
            }

            public void checkAccountValue()
            {
                Console.WriteLine("Saldo na koncie = {0}", saldo);
            }

            public void withdraw(double value)
            {
                if (value <= saldo)
                {
                    Console.WriteLine("Wypłacić " + value + "zł?");
                    Console.WriteLine("Napisz tak/nie");
                    String x = Console.ReadLine();
                    if (x == "tak")
                    {
                        saldo = saldo - value;
                        Console.WriteLine("Wypłacono" + value + "zł");
                    }
                    else { Console.WriteLine("Wypłatę anulowano"); }
                }
                else
                {
                    Console.WriteLine("Brak środków na koncie. Wybierz mniejsza kwote biedaku!");
                }
            }
            public void deposit(double value)
            {
                Console.WriteLine("Wpłacić " + value + "zł?");
                Console.WriteLine("Napisz tak/nie");
                String x = Console.ReadLine();
                if (x == "tak")
                {
                    saldo = saldo + value;
                    Console.WriteLine("Wpłacono" + value + "zł");

                }
                else { Console.WriteLine("Wpłatę anulowano"); }
            }
        }
        class Adress
        {
            private String city;
            private String street;

            public Adress(String city, String street)
            {
                this.city = city;
                this.street = street;
            }
            public String getCity()
            {
                return city;
            }
            public String getStreet()
            {
                return street;
            }
        }


    }
}
