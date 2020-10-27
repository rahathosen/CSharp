using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class New_8
    {
        public double DoMatch(double x, double y, MathType math)
        {
            double output = 0;

            output = math switch  //Switch Expression
            {
                MathType.Add => x + y,
                MathType.Sub => x - y,
                MathType.Mul => x * y,
                MathType.Div => x / y,
                _ => throw new Exception("Bad info passed in")
            };

            /* switch (math)         // Switch Statement
             {
                 case MathType.Add:
                     output = x + y;
                     break;

                 case MathType.Sub:
                     output = x - y;
                     break;

                 case MathType.Mul:
                     output = x * y;
                     break;

                 case MathType.Div:
                     output = x / y;
                     break;

                 default:
                     throw new Exception("Bad info passed in");
             }
             */
            return output;
        }

        public enum MathType
        {
            Add,
            Sub,
            Mul,
            Div
        }
    }

    public class test1
    {
        public void switch_()
        {
            int value = 4;
            string output2 = "";
            output2 = value switch
            {
                1 => "One number",
                2 => "two number ",
                _ => throw new Exception("not matching")
            };
            Console.WriteLine(output2);
        }
    }
}