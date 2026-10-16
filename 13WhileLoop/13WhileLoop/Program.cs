using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int actualNumber = random.Next(1, 101);

            int guessedNumber = 0;

            while (guessedNumber != actualNumber)
            {
                Console.Write("Guess a number: ");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber > actualNumber)
                {
                    Console.WriteLine("Guess Smaller");
                }
                else if (guessedNumber < actualNumber) 
                {
                    Console.WriteLine("Guess Larger");
                }
            }

            Console.WriteLine("Finally You Guessed Correct");


            // Do While Loop

            int i = 0;
            do
            {
                Console.WriteLine("I am first doing " + i);
                i++;
            }
            while (i < 10);
        }
    }
}
