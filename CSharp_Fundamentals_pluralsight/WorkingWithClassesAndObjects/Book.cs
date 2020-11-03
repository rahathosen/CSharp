using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClassesAndObjects
{
    internal class Book
    {
        // private List<double> grades = new List<double>();  // diclear as List
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void Showstatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (double number in grades)
            {
                //if (number > highGrade)
                //    highGrade = number;

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
                Console.WriteLine(number);
            }
            result /= grades.Count;

            Console.WriteLine($"The lowest Grade is {lowGrade}");
            Console.WriteLine($"The Height Grade is {highGrade}");
            Console.WriteLine($"The Average Grade is {result:N1}");
            Console.WriteLine("The name of Author is " + name);
        }

        private List<double> grades;
        private string name;
    }
}