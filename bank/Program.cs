using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IPrinter printer = new Printer();

            Console.WriteLine("Autor: Mirosław Trollewicz");
            //var przyjmuje kazdy typ, w zaleznosci od zdefiniowania
            int version = 1;
            Console.WriteLine("wersja {0}", version);
            Console.WriteLine("__________________________");
            Console.WriteLine();

            // tworzenie listy i tworzenie listą
            IList<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1, 0.0M, "Jan", "Kowalski", 14882137420));
            accounts.Add(new BillingAccount(2, 0.0M, "Jan", "Kowalski", 14882137420));

            AccountsManager manager = new AccountsManager();
            manager.CreateSavingsAccount("Jan", "Kowalski", 82148137420);
            manager.CreateBillingAccount("Jan", "Kowalski", 14882137420);
            manager.CreateBillingAccount("George", "Bussing", 21156969515);

            // tworzenie bez konstruktora
            SavingsAccount account = new SavingsAccount();
            account.AccountNumber = "900000000001";
            account.Balance = 0.0M;
            account.FirstName = "Jan";
            account.LastName = "Kowalski";
            account.Pesel = 14882137420;

            // przepisanie listy nienumerowanej z foreachem, można łączyć
            foreach (Account account in manager.GetAllAccounts())
            {
                printer.Print(account);
            }

            // przepisanie listy numerowanej
            IList<Account> accounts = (IList<Account>)manager.GetAllAccounts();
            printer.Print(accounts[2]);

            foreach (Account account1 in manager.GetAllAccountsFor(14882137420))
                printer.Print(account1);

            printer.Print(manager.GetAccount("940000000003"));

            foreach (string user in manager.ListOfCustomers())
                Console.WriteLine(user);

            // tworzenie z kontruktorem
            SavingsAccount savingsAccount = new SavingsAccount("900000000001", 0.0M, "Jan", "Kowalski", 14882137420);
            printer.Print(savingsAccount);

            BillingAccount billingAccount = new BillingAccount("900000000002", 0.0M, "Jan", "Kowalski", 14882137420);
            smallPrinter.Print(billingAccount);

            //drukowanie z listą
            printer.Print(accounts[0]);
            smallPrinter.Print(accounts[1]);

            Console.ReadKey();
            //on godd shits bussin no cap fr fr
            */

            BankManager bank = new BankManager();
            bank.Run();
        }
    }
}
