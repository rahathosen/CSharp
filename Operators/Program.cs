using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 - Increment/Decrement operator
            int i = 3;
            Console.WriteLine(i);   // output: 3
            Console.WriteLine(i++); // output: 3
            Console.WriteLine(i);   // output: 4

            double a = 1.5;
            Console.WriteLine(a);   // output: 1.5
            Console.WriteLine(++a); // output: 2.5
            Console.WriteLine(a);   // output: 2.5

            int i2 = 3;
            Console.WriteLine(i2);   // output: 3
            Console.WriteLine(i2--); // output: 3
            Console.WriteLine(i2);   // output: 2

            double a2 = 1.5;
            Console.WriteLine(a2);   // output: 1.5
            Console.WriteLine(--a2); // output: 0.5
            Console.WriteLine(a2);   // output: 0.5

            #endregion

            #region Example 2 - Unary plus and minus operators

            Console.WriteLine(+4);     // output: 4
            Console.WriteLine(-4);     // output: -4
            Console.WriteLine(-(-4));  // output: 4
            #endregion

            #region Example 3 - Math operators
            Console.WriteLine(5 * 2);         // output: 10
            Console.WriteLine(0.5 * 2.5);     // output: 1.25
            Console.WriteLine(0.1m * 23.4m);  // output: 2.34

            Console.WriteLine(13 / 5);    // output: 2
            Console.WriteLine(-13 / 5);   // output: -2
            Console.WriteLine(13 / -5);   // output: -2
            Console.WriteLine(-13 / -5);  // output: 2

            Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
            Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
            Console.WriteLine(16.8m / 4.1m);   // output: 4.09756097560975609756097560

            Console.WriteLine(5 % 4);   // output: 1
            Console.WriteLine(5 % -4);  // output: 1
            Console.WriteLine(-5 % 4);  // output: -1
            Console.WriteLine(-5 % -4); // output: -1

            Console.WriteLine(-5.2f % 2.0f); // output: -1.2
            Console.WriteLine(5.9 % 3.1);    // output: 2.8
            Console.WriteLine(5.9m % 3.1m);  // output: 2.8

            Console.WriteLine(5 + 4);       // output: 9
            Console.WriteLine(5 + 4.3);     // output: 9.3
            Console.WriteLine(5.1m + 4.2m); // output: 9.3

            Console.WriteLine(47 - 3);      // output: 44
            Console.WriteLine(5 - 4.3);     // output: 0.7
            Console.WriteLine(7.5m - 2.3m); // output: 5.2

            int x = 5;
            x += 9;
            Console.WriteLine(x);  // output: 14

            x -= 4;
            Console.WriteLine(x);  // output: 10

            x *= 2;
            Console.WriteLine(x);  // output: 20

            x /= 4;
            Console.WriteLine(x);  // output: 5

            x %= 3;
            Console.WriteLine(x);  // output: 2

            #endregion

            #region Example 4 - Bitwise complement operator ~
            uint t = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~t;
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            // Output:
            // 11110000111100001111000011110011
            
            #endregion

            #region Example 5 Shift operators
            uint m = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");

            uint y = m << 4;
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
            // Output:
            // Before: 11001001000000000000000000010001
            // After:  10010000000000000000000100010000


            uint n = 0b_1001;
            Console.WriteLine($"Before: {Convert.ToString(n, toBase: 2),4}");

            uint n2 = n >> 2;
            Console.WriteLine($"After:  {Convert.ToString(n2, toBase: 2),4}");
            // Output:
            // Before: 1001
            // After:    10


            #endregion

            #region Example 6 Logical Operators
            uint a1 = 0b_1111_1000;
            uint b1 = 0b_1001_1101;
            uint c1 = a1 & b1;
            Console.WriteLine(Convert.ToString(c1, toBase: 2));
            // Output:
            // 10011000

            uint p = 0b_1111_1000;
            uint q = 0b_1001_1101;
            uint r = p | q;
            Console.WriteLine(Convert.ToString(r, toBase: 2));
            // Output:
            // 11111101

            uint w = 0b_1111_1000;
            uint v = 0b_0001_1100;
            uint z = w ^ v;
            Console.WriteLine(Convert.ToString(z, toBase: 2));
            // Output:
            // 11100100


            #endregion
        }
    }
}
