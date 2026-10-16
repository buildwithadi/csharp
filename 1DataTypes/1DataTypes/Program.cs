using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer
            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            // Long
            long bigNumber = -9000000000L; // Add 'L' to make the integer to long...
            Console.WriteLine(bigNumber);

            // Double
            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            // Float
            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            // Decimal
            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            // Multiple Variable Decalaration
            int x = 10,
                y = 20,
                z = 30;

            Console.WriteLine(x + " " + y + " " + z);


        }
    }
}
