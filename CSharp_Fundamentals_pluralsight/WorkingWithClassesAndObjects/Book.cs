using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClassesAndObjects
{
    internal class Book
    {
        private List<double> grades;

        // private List<double> grades = new List<double>();
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}