using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment_2026
{
    internal class Student
    {
        public int Id { get;  }
        public string Name { get; private set; }
        
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 6 and 20!");
                }
                age = value;
            }
        }
       
        private int grade;
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 1 and 12!");
                }
                grade = value;
            }
        }
       
        private double averageScore;
        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2.00 || value > 6.00)
                {
                    throw new ArgumentOutOfRangeException("Average score must be between 2.00 and 6.00!");
                }
                averageScore = value;
            }
        }

        private decimal fee;
        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Fee must be a positive number!");
                }
                fee = value;
            }
        }

        public bool HasScholarship { get; set; }//Bool => по условие няма нужда от проверка, защото може да е само true или false
        private char classLetter;
        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))//проверяваме дали е char
                {
                    throw new ArgumentException("Class letter must be a real letter!");
                }
                classLetter = value;
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Today)//Синтаксисът на DateTime.Now е ако искаме да сравняваме само датата С времето!
                {
                    throw new ArgumentOutOfRangeException("Birth date cannot be in the future!");
                }
                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id must be a positive number!");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The name cannot be empty!");
            }

            Id = id;
            Name = name;
        }
    }
}
