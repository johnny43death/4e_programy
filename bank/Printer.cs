using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Printer : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine("Dane konta: ");
            Console.WriteLine("Rodzaj konta: {0}", account.TypeName());
            Console.WriteLine("Środki na koncie: {0} zł", account.Balance);
            Console.WriteLine("Numer konta: {0}", account.AccountNumber);
            //Console.WriteLine("Imię właściciela: {0}", account.FirstName);
            //Console.WriteLine("Nazwisko właściciela: {0}", account.LastName);
            Console.WriteLine("Imię i Nazwisko właściciela: {0}", account.GetFullName());
            Console.WriteLine("Numer PESEL: {0}", account.Pesel);
            Console.WriteLine("_______________________________");
            Console.WriteLine();
        }
    }
}
