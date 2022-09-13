using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listazadan
{
    internal class Program
    {
        private void PrintMainMenu()
        {
            Console.WriteLine("LISTA ZADAŃ");
            Console.WriteLine("===========");
            CurrentTasks.PrintAllTasks();
            Console.WriteLine();
            Console.WriteLine("===========");
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("A - wybierz zadanie");
            Console.WriteLine("B - dodaj zadanie");
            Console.WriteLine("C - zakończ program");
        }
        static void Main(string[] args)
        {
            CurrentTasks currtasks = new CurrentTasks();
        }
    }
}
