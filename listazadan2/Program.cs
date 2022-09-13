using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listazadan
{
    internal class Program
    {
        CurrentTasks _currtasks = new CurrentTasks();

        public void PrintAllTasks()
        {
            foreach (Task task in _currtasks)
            {
                if (!task.IsFinished)
                {
                    task.Print();
                }
                else
                {

                }
            }
        }
        private void PrintMainMenu()
        {
            Console.WriteLine("LISTA ZADAŃ");
            Console.WriteLine("===========");
            PrintAllTasks();
            Console.WriteLine();
            Console.WriteLine("===========");
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("A - wybierz zadanie");
            Console.WriteLine("B - dodaj zadanie");
            Console.WriteLine("C - zakończ program");
        }

        static void Main(string[] args)
        {
            
        }
    }
}
