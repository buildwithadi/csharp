using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0 || age > 100)
            {
                Console.Write("Invalid Age");
            } 
            else if (age > 18)
            {
                Console.Write("You are eligible to Vote");
            }         
            else
            {
                Console.Write("You are not eligible to Vote");
            }

        }
    }
}
