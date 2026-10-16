using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataTypeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            char letter = 'A'; // char cannot be empty, if we want it to be empty we need to write it as '\0'

            Console.Write("Your name is ");
            Console.WriteLine(name);
            Console.WriteLine(letter);

        }
    }
}
