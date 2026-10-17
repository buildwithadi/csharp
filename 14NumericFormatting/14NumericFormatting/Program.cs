using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0} {1}", value, 1000)); // {0} -> value and {1} -> 1000
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value)); // remove the tailing zeros

            double money = -10D / 3D;

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = {0:0.00}", money));
            Console.WriteLine(money.ToString());
            Console.WriteLine(money.ToString("C")); // 'C' stands for currency
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));
             
        }
    }
}
