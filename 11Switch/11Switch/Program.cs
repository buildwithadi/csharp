using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());
            string dayName;

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thrusday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day";
                    break;
            }

            Console.WriteLine("You entered " + dayName);

        }
    }
}
