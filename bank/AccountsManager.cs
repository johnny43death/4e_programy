using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class AccountsManager
    {
        // prywatne poprzedzone podłogą
        private IList<Account> _accounts;
        public AccountsManager()
        {
            _accounts = new List<Account>();
        }
        public IEnumerable<Account> GetAllAccounts()
        {
            return _accounts;
        }
        private int generateId()
        {
            int id = 1;
            if (_accounts.Any())
            {
                // "a" to "alias" - zmienna zastępcza, która wskazuje na obiekt
                id = _accounts.Max(a => a.ID) + 1;
            }
            return id;
        }
        public SavingsAccount CreateSavingsAccount(string firstName, string lastName, long pesel)
        {
            int id = generateId();
            SavingsAccount account = new SavingsAccount(id, 0.0M, firstName, lastName, pesel);
            _accounts.Add(account);
            return account;
        }

        public BillingAccount CreateBillingAccount(string firstName, string lastName, long pesel)
        {
            int id = generateId();
            BillingAccount account = new BillingAccount(id, 0.0M, firstName, lastName, pesel);
            _accounts.Add(account);
            return account;
        }

        public IEnumerable<Account> GetAllAccountsFor(long pesel)
        {
            // długa wersja
            /*List<Account> customerAccounts = new List<Account>();
            foreach(Account account in _accounts)
                if(account.Pesel == pesel)
                    customerAccounts.Add(account);
            return customerAccounts;*/

            //krótka wersja
            return _accounts.Where(a => a.Pesel == pesel);
            // możesz użyć "&&" aby łączyć by wypluwać wiele kolumn lmao
        }

        public Account GetAccount(string accountNo)
        {
            return _accounts.SingleOrDefault(x => x.AccountNumber == accountNo);
        }

        public IEnumerable<string> ListOfCustomers()
        {
            return _accounts.Select(a => string.Format("Imię: {0} | Nazwisko: {1} | PESEL: {2}",a.FirstName,a.LastName,a.Pesel)).Distinct();
        }

        public void CloseMonth()
        {
            // jedno rozwiązanie
            /*foreach (var account in _accounts)
            {
                if (account.TypeName() == "Oszczędnościowe")
                {
                    account.Money(0.04M);
                }
                else
                {
                    account.Money(5.0M);
                }
            }*/

            // drugie rozwiązanie
            foreach (SavingsAccount account in _accounts.Where(x => x is SavingsAccount))
                account.AddInterest(0.04M);
            foreach (BillingAccount account in _accounts.Where(x => x is BillingAccount))
                account.TakeCharge(5.0M);
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
    }
}
