using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoManager
{
    internal class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=== Изберете опция: ===");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1. Добави нова задача");
                Console.WriteLine("2. Виж всички въведени задачи");
                Console.WriteLine("3. Маркирай задача като изпълнена");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("5. Прекрати работата на програмата");

                Console.Write("Вашият избор е: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (choice < 1 || choice > 5)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Невалидна опция!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White ;
                }
                else
                {
                    switch (choice)
                    {
                        case 1: AddTask(); break;
                        case 2: ShowTasks(); break;
                        case 3: CompleteTask(); break;
                        case 4: DeleteTask(); break;
                        case 5: Console.WriteLine("Край на програмата!"); return;
                    }
                }
               
            }
        }
        

        static void AddTask()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===== ДОБАВЯНЕ НА ЗАДАЧА =====");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Заглавие: ");
            string title = Console.ReadLine();
            Console.Write("Описание: ");
            string description = Console.ReadLine();
           
            DateTime deadline;

            //Specific
            while (true)
            {
                Console.Write("Краен срок (дд.ММ.гггг): ");

                if (DateTime.TryParse(Console.ReadLine(), out deadline))
                    break;

                Console.WriteLine("Невалидна дата. Опитайте отново.");
            }

            Task newTask = new Task(title, description, deadline);
            tasks.Add(newTask);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nЗадачата беше добавена успешно!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        static void ShowTasks()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===== ВСИЧКИ ЗАДАЧИ =====");
            Console.ForegroundColor = ConsoleColor.White;

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                return;
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++) 
                {

                    Console.WriteLine($"Задача номер: {i+1}");
                    Console.WriteLine($"Заглавие: {tasks[i].Title}");
                    Console.WriteLine($"Описание: {tasks[i].Description}");
                    Console.WriteLine($"Краен срок: {tasks[i].DeadLine: dd.MM.YYYY}");
                    Console.WriteLine($"Изпълнена ли е: {(tasks[i].IsCompleted ? "Изпълнена" : "Неизпълнена")}");
                    Console.WriteLine();
                }
            }
        }

        static void CompleteTask()
        {
            ShowTasks();

            Console.Write("\nВъведете номер на задачата, която да бъде маркикана като изпълнена: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= tasks.Count)
            {
                tasks[number - 1].IsCompleted = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Задачата е маркирана като изпълнена!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Невалиден номер!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        static void DeleteTask()
        {
            if (tasks.Count == 0) Console.WriteLine("Няма налични задачи!");
            else
            {
                Console.WriteLine("Въведете номера на задачата, която искате да изтриете: ");
                int number = int.Parse (Console.ReadLine());

                if (number > 0 && number <= tasks.Count)
                {
                    tasks.RemoveAt(number - 1);
                    Console.WriteLine("Задачата е изтрита");
                }
                else
                {
                    Console.WriteLine("Въведете номер на набична задача");
                }
            }              
        }

    }
}
