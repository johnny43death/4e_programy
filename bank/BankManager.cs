using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class BankManager
    {
        private AccountsManager _accountsManager;
        private IPrinter _printer;
        
        public BankManager()
        {
            _accountsManager = new AccountsManager();
            _printer = new Printer();
        }

        private void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - lista kont klienta");
            Console.WriteLine("2 - dodaj konto rozliczeniowe");
            Console.WriteLine("3 - dodaj konto oszczędnościowe");
            Console.WriteLine("4 - wpłać pieniądze na konto");
            Console.WriteLine("5 - wypłać pieniądze z konta");
            Console.WriteLine("6 - lista klientów");
            Console.WriteLine("7 - wszystkie konta");
            Console.WriteLine("8 - zamknij miesiąc");
            Console.WriteLine("0 - zakończ program");
        }

        public void Run()
        {
            int action;
            do
            {
                PrintMainMenu();
                action = SelectedAction();

                switch (action)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę kont klientów");
                        ListOfAccounts();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Wybrano otwarcie konta rozliczeniowego");
                        AddBilling();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Wybrano otwarcie konta oszczędnościowego");
                        AddSavings();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Wybrano wpłacenie pieniędzy na konto");
                        Deposit();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Wybrano wypłacenie pieniędzy z konta");
                        Withdraw();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Wybrano listę klientów");
                        ListOfCustomers();
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Wybrano wyświetlenie wszystkich kont");
                        ListOfAllAccounts();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Wybrano zakończenie miesiąca");
                        CloseMonth();
                        Console.ReadKey();
                        break;
                }
            }
            while (action != 0);
        }

        private int SelectedAction()
        {
            Console.Write("Akcja: ");
            string action = Console.ReadLine();
            if (string.IsNullOrEmpty(action))
                return -1;
            else
                return int.Parse(action);
        }

        private void ListOfAccounts()
        {
            Console.Write("pesel: ");
            string pesel = Console.ReadLine();
            foreach (Account account in _accountsManager.GetAllAccountsFor(long.Parse(pesel)))
                _printer.Print(account);
        }

        private CustomerData ReadCustomerData()
        {
            string firstName;
            string lastName;
            string pesel;
            Console.WriteLine("Podaj dane klienta:");
            Console.Write("Imię: ");
            firstName = Console.ReadLine();
            Console.Write("Nazwisko: ");
            lastName = Console.ReadLine();
            Console.Write("Pesel: ");
            pesel = Console.ReadLine();
            return new CustomerData(firstName, lastName, pesel);
        }

        private void AddBilling()
        {
            CustomerData data = ReadCustomerData();
            Account billing = _accountsManager.CreateBillingAccount(data.FirstName, data.LastName, data.Pesel);
            Console.WriteLine("_______________________________");
            Console.WriteLine("Utworzono konto: ");
            _printer.Print(billing);
        }

        private void AddSavings()
        {
            CustomerData data = ReadCustomerData();
            Account savings = _accountsManager.CreateBillingAccount(data.FirstName, data.LastName, data.Pesel);
            Console.WriteLine("_______________________________");
            Console.WriteLine("Utworzono konto: ");
            _printer.Print(savings);
        }

        private AccountCustomerData ReadAccountCustomerData()
        {
            string accNo;
            string moners;
            Console.WriteLine("Podaj dane klienta:");
            Console.Write("Numer konta: ");
            accNo = Console.ReadLine();
            Console.Write("Kwota: ");
            moners = Console.ReadLine();
            return new AccountCustomerData(accNo, moners);
        }

        private void Deposit()
        {
            AccountCustomerData data = ReadAccountCustomerData();
            _accountsManager.AddMoney(data.AccountNumber, data.Balance);
            Account account = _accountsManager.GetAccount(data.AccountNumber);
            _printer.Print(account);

        }

        private void Withdraw()
        {
            AccountCustomerData data = ReadAccountCustomerData();
            _accountsManager.TakeMoney(data.AccountNumber, data.Balance);
            Account account = _accountsManager.GetAccount(data.AccountNumber);
            _printer.Print(account);
        }

        private void ListOfCustomers()
        {
            foreach(string customer in _accountsManager.ListOfCustomers())
                Console.WriteLine(customer);
        }

        private void ListOfAllAccounts()
        {
            foreach (Account account in _accountsManager.GetAllAccounts())
                _printer.Print(account);
        }

        private void CloseMonth()
        {
            _accountsManager.CloseMonth();
            Console.WriteLine("Miesiąc zamknięty");
        }
    }
}
