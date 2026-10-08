namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Регистрация на ученик =======");
            Console.WriteLine();

            //Name
            Console.Write("Име: ");
            string name = Console.ReadLine();

            //Age
            Console.Write("Възраст: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"Невалидна възраст! Опитайте пак!");
            }

            //Class
            Console.Write("Клас: ");
            byte grade;
            while (!(byte.TryParse(Console.ReadLine(), out grade) && (grade <= 12 && grade >= 1)))
            {
                Console.WriteLine("Невалиден клас! Опитайте пак!");
            }

            Console.WriteLine("Среден успех: ");
            double averageGrade;
            while (!(double.TryParse(Console.ReadLine(), out averageGrade)
                && (averageGrade <= 6.00 && averageGrade >= 2.00)))
            {
                Console.WriteLine("Невалидна оценка! Опитайте пак!");
            }

            Console.WriteLine("Парична стойност: ");
            decimal monetaryValue;
            if (!decimal.TryParse(Console.ReadLine(), out monetaryValue))
            {
                Console.WriteLine("Въведете реална парична стойност!");
            }

            Console.WriteLine("Имате ли право на стипендия: ");
            bool hasScholarship;
            if (bool.TryParse(Console.ReadLine(),out hasScholarship))
            {
                hasScholarship = hasScholarship;
            }

            Console.WriteLine("Буква на паралелката (с главна) :");
            char letter;
            while (!(char.TryParse(Console.ReadLine(), out letter) && 
                (letter == 'А' || letter == 'Б' || letter == 'В' || letter == 'Г')))
            {
                Console.WriteLine("Невалиден клас! Опитайте пак!");
            }

            Console.WriteLine("Дата на раждане: ");
            DateTime birthDate;
            //DateTime birthDate = DateTime.Parse(Console.ReadLine());
            while (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Въведете валидна дата");
            }
            Console.WriteLine();

            Console.WriteLine("======= Данни =======");
            Console.WriteLine("Име");//да довърша

        }
    }
}
