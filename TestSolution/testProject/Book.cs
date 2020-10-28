using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Book : Product
    {
        public string Atuthor { get; set; }

        public override string FormatPrice()
        {
            return $"TK: {Price.ToString("0.00")}";
        }
    }
}