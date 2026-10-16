using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6Keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // var keyword:
            var age = 23; // dynamically typed variable
            Console.WriteLine(age);

            var bigNumber = 9000000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.0000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Adam";
            Console.WriteLine(name);

            var letter = 'A';
            Console.WriteLine(letter);

            // const keyword
            const int Vat = 20; // cannot be change, because it is constant
            Console.WriteLine(Vat);

            const double percentVAT = Vat / 100D;

            int balance = 1000;
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";
            Console.WriteLine(version);

        }
    }
}
