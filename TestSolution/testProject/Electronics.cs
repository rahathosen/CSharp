using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Electronics : Product
    {
        public string BrandName { get; set; }

        public override double DiscountPrice()
        {
            return Price * 25 / 100.0;
        }
    }
}