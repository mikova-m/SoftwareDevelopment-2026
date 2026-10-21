using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment_2026
{
    internal class Program
    {
        static int nextId = 1; // Статична променлива за автоматично генериране на уникални Id-та
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
            Console.ForegroundColor = ConsoleColor.White;

            Student student = null;

            //Име и създаване на ученик
            while (student == null)
            {
                try
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    student = new Student(nextId, name);
                    nextId++;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            //Възраст
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.Write("Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a whole number.");//Проверяваме и дали отговаря на int, НЯМА ГО В УСЛОВИЕТО
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            //Клас
            while (true)
            {
                try
                {
                    Console.Write("Grade: ");
                    student.Grade = int.Parse(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a whole number.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            //Среден успех
            while (true)
            {
                try
                {
                    Console.Write("Average score (2-6): ");
                    student.AverageScore = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            //Такса
            while (true)
            {
                try
                {
                    Console.Write("Fee: ");
                    student.Fee = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // Scolarship eligibility check
            while (true)
            {
                try
                {
                    Console.Write("Has scholarship (true/false): ");
                    student.HasScholarship = bool.Parse(Console.ReadLine());
                    break; // Exit the loop if parsing is successful
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter 'true' or 'false'.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // Буква на паралелката
            while (true)
            {
                try
                {
                    Console.Write("Class letter: ");
                    student.ClassLetter = char.Parse(Console.ReadLine().ToUpper());
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a single letter.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            // Дата на раждане
            while (true)
            {
                try
                {
                    Console.Write("Date of birth (dd.MM.yyyy): ");//format for date?
                    student.BirthDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid date!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            //Извеждане на данните за ученика
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=== STUDENT DATA ===");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"Id: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Grade: {student.Grade}");
            Console.WriteLine($"Average score: {student.AverageScore}");
            Console.WriteLine($"Fee: {student.Fee}");
            Console.WriteLine($"Has scholarship: {student.HasScholarship}");
            Console.WriteLine($"Class letter: {student.ClassLetter}");
            Console.WriteLine($"Birth date: {student.BirthDate:d}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
