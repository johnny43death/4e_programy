using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsandhobbies
{
    internal class Program
    {
        public static AppManager appManager = new AppManager();

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("HARMONOGRAM XDDD");
            Console.WriteLine("================");
            appManager.PrintAllUsers();
            Console.WriteLine("================");
            appManager.PrintAllEvents();
            Console.WriteLine("================");
            PrintMainMenu();
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - dodaj hobby");
            Console.WriteLine("2 - dodaj użytkownika");
            Console.WriteLine("3 - dodaj wydarzenie");
            Console.WriteLine("4 - wybierz użytkownika");
            Console.WriteLine("5 - wybierz wydarzenie");
            Console.WriteLine("6 - wyświetl ukończone");
            Console.WriteLine("0 - zakończ program");
        }
    }
}
