using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        private double _Price;

        public double Price
        {
            get { return _Price; }
            set { _Price = value < 0 ? 0 : value; }
            /* set
             {
                 if (value < 0)
                     _Price = 0;
                 else
                     _Price = value;
             }*/
        }
    }
}