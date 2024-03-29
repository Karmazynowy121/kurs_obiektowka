﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class AccountsManager
    {
        private IList<Account> _accounts;

        public AccountsManager()
        {
            _accounts = new List<Account>();
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accounts;
        }

        public IEnumerable<Account> GetAllAccountsFor(string firstName, string lastName, long pesel)
        {
            return _accounts.Where(x => x.FirstName == firstName && x.LastName == lastName && x.Pesel == pesel);
        }

        public Account GetAccount(string accountNo)
        {
            return _accounts.Single(x => x.AccountNumber == accountNo);
        }

        public IEnumerable<string> ListOfCustomers()
        {
            return _accounts.Select(a => string.Format("Imię: {0} | Nazwisko: {1} | PESEL: {2}", a.FirstName, a.LastName, a.Pesel)).Distinct();
        }

        public void CloseMonth()
        {
            foreach (SavingsAccount account in _accounts.Where(x => x is SavingsAccount))
            {
                account.AddInterest(0.04M);
            }

            foreach (BillingAccount account in _accounts.Where(x => x is BillingAccount))
            {
                account.TakeCharge(5.0M);
            }
        }

        public void AddMoney(string accountNo, decimal value)
        {
            Account account = GetAccount(accountNo);
            account.ChangeBalance(value);
        }

        public void TakeMoney(string accountNo, decimal value)
        {
            Account account = GetAccount(accountNo);
            account.ChangeBalance(-value);
        }

        public SavingsAccount CreateSavingsAccount(string firstName, string lastName, long pesel)
        {
            int id = generateId();

            SavingsAccount account = new SavingsAccount(id, firstName, lastName, pesel);

            _accounts.Add(account);

            return account;
        }

        public BillingAccount CreateBillingAccount(string firstName, string lastName, long pesel)
        {
            int id = generateId();

            BillingAccount account = new BillingAccount(id, firstName, lastName, pesel);

            _accounts.Add(account);

            return account;
        }

        private int generateId()
        {
            int id = 1;

            if (_accounts.Any())
            {
                id = _accounts.Max(x => x.Id) + 1;
            }

            return id;
        }
        public void LocalTransfer(Account withderwAccount,int recieverAccount, decimal Value)
        {
            bool didFoundAccount = false;
            //foreach (Account account in _accounts)
            //{
            //    if (account.Id == withdrawAccount)
            //    {
            //        account.ChangeBalance(Value);
            //        didFoundAccount = true;
            //    }
            //}

            if (withderwAccount == null)
            {
                Console.WriteLine("Nie ma konta nadawcy!");
                return;
            }

            //if (!didFoundAccount)
            //{
            //    Console.WriteLine("Nie znaleziono konta nadawcy!");
            //    return;
            //}
            didFoundAccount = false;
            foreach (Account account1 in _accounts)
            {
                if (account1.Id == recieverAccount)
                {
                    account1.ChangeBalance(Value);
                    didFoundAccount = true;
                    break;
                }
            }

            if (didFoundAccount)
            {
                withderwAccount.ChangeBalance(Value);
            }

                //if (!didFoundAccount)
                //{
                //    Console.WriteLine("Nie znaleziono konta odbiorcy!");
                //    foreach (Account account in _accounts)
                //    {
                //        if (account.Id == withdrawAccount)
                //        {
                //            account.ChangeBalance(Value);
                //        }
                //    }
                //    return;
                //}
            Console.WriteLine("Przelew zrobiony pomyślnie");
        }
    }
}
