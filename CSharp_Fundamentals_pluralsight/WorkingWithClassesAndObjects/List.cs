using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClassesAndObjects
{
    internal class List
    {
        public void newlist()
        {
            Book book = new Book();
            book.AddGrade(55.5);
            var grade = new List<double>() { 55.5, 43, 60.5, 80, 75.5 };
            grade.Add(90.5);

            var result = 0.0;
            foreach (double item in grade)
            {
                result += item;
            }
            result /= grade.Count;
            Console.WriteLine($"The Average graede {result:N1}");
        }
    }
}