using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            Console.WriteLine(++age); // increment first then use the value
            Console.WriteLine(age++); // use first and then increment
            age += 10;
            Console.WriteLine(age);

            // '/' it can lead to integer or double any...

            string name = "Adam";
            name += " is programming";
            Console.WriteLine(name);


            int firstNum = 10;
            int secondNum = 3;
            int thirdNum = 5;

            Console.WriteLine(firstNum % secondNum); // this will give the remainder...
            Console.WriteLine(firstNum % thirdNum);           

        }
    }
}
