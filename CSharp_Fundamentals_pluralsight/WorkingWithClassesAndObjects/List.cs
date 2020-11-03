using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClassesAndObjects
{
    internal class List
    {
        public void newlist()
        {
            Book book = new Book("Scott Grade Book");
            book.AddGrade(55.5);
            book.AddGrade(95.7);
            book.AddGrade(25.0);
            book.AddGrade(55.7);

            book.Showstatistics();
        }
    }
}