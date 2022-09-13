using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    abstract class Account
    {
        public int ID { get; /*private set;*/ }
        // "get" sprawia, że zmienna jest tylko do odczytu
        public string AccountNumber { get; }
        public decimal Balance/*IAGA*/ { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account(int id, decimal balance, string firstName, string lastName, long pesel)
        {
            ID = id;
            AccountNumber = generateAccountNumber(id);
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public string GetFullName()
        {
            string fullName = string.Format("{0} {1}", FirstName, LastName);
            return fullName;
        }

        public abstract string TypeName();
        public abstract void Money(decimal value);
        private string generateAccountNumber(int id)
        {
            string number = string.Format("94{0:D10}", id);
            return number;
        }

        public void ChangeBalance(decimal value)
        {
            Balance += value;
        }
    }
}
