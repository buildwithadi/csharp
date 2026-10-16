using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of multiples: ");
            int multi = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=multi; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + num * i);
            }
        }
    }
}
