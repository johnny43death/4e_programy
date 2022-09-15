using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listazadan
{
    internal class Program
    {
        public static TaskManager taskManager = new TaskManager();

        static void Main(string[] args)
        {
            int key;
            do
            {
                Console.Clear();
                Console.WriteLine("LISTA ZADAŃ");
                Console.WriteLine("===========");
                taskManager.PrintAllTasks();
                Console.WriteLine();
                PrintMainMenu();
                key = PressedKey();
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Wybierz zadanie: ");
                        ChooseTask();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Dodaj zadanie: ");
                        AddTask();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("UKOŃCZONE: ");
                        Console.WriteLine("===========");
                        PrintFinished();
                        Console.ReadKey();
                        break;
                }
            }
            while (key!=0);
        }

        public static int PressedKey()
        {
            Console.Write("Akcja: ");
            string pressedkey = Console.ReadLine();
            if (string.IsNullOrEmpty(pressedkey))
            {
                return -1;
            }
            return int.Parse(pressedkey);
        }

        public static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("NOWE ZADANIE");
            Console.WriteLine("============");
            Console.Write("Nazwa: ");
            string name = Console.ReadLine();
            Console.Write("Opis zadania: ");
            string desc = Console.ReadLine();

            Task newTask = taskManager.CreateTask(name, desc);
            Console.WriteLine("============");
            Console.WriteLine("Zadanie dodano pomyślnie! ");
            Console.WriteLine();
            newTask.Print();
        }

        public static void ChooseTask()
        {
            taskManager.PrintAllTasks();
            Console.WriteLine();
            Console.WriteLine("Numer zadania: ");
            int taskID = int.Parse(Console.ReadLine());
            Task chosenTask = taskManager.SelectTask(taskID);
            Console.Clear();
            chosenTask.Print();
            Console.WriteLine();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - edytuj zadanie");
            Console.WriteLine("2 - dodaj do ukończonych");
            Console.WriteLine("3 - usuń");

            int pressedkey = PressedKey();
            switch (pressedkey)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Edytuj zadanie");
                    EditTask(chosenTask);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ukończono zadanie");
                    chosenTask.IsFinished = true;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Usunięto zadanie");
                    taskManager.RemoveTask(taskID);
                    break;
            }
        }

        public static void PrintFinished()
        {
            Console.Clear();
            taskManager.PrintFinishedTasks();
            Console.WriteLine();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - przywróć zadanie");
            Console.WriteLine("2 - cofnij");

            int pressedkey = PressedKey();
            if(pressedkey == 1)
            {
                Console.Write("Numer zadania: ");
                int taskID = int.Parse(Console.ReadLine());
                taskManager.SelectTask(taskID).IsFinished = false;

                Console.Clear();
                Console.WriteLine("Zadanie przywrócone");
            }
            else if(pressedkey == 2)
            {
                Console.Clear();
                Console.WriteLine("LISTA ZADAŃ");
                Console.WriteLine("===========");
                taskManager.PrintAllTasks();
                Console.WriteLine();
                PrintMainMenu();
            }
        }

        public static void EditTask(Task task)
        {
            task.Print();
            Console.WriteLine();
            Console.WriteLine("Edytowane zadanie:");
            Console.Write("Nazwa: ");
            string name = Console.ReadLine();
            Console.Write("Opis: ");
            string desc = Console.ReadLine();

            Task editedTask = taskManager.EditTask(task.ID, name, desc);
            Console.WriteLine("\nZadanie edytowane\n");
            editedTask.Print();
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("===========");
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - wybierz zadanie");
            Console.WriteLine("2 - dodaj zadanie");
            Console.WriteLine("3 - wyświetl ukończone");
            Console.WriteLine("0 - zakończ program");
        }
    }
}
