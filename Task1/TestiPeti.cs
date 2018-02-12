using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItMathAppli

{
    class Testipeti
    {
        public static void Test()
        {
            Console.WriteLine("Unvalid numbers");

            Console.WriteLine(ItMath.IsItNumb("Kissa"));
            Console.WriteLine(ItMath.IsItNumb("abcABC1"));
            Console.WriteLine(ItMath.IsItNumb("1234."));
            Console.WriteLine(ItMath.IsItNumb(",1234"));
            Console.WriteLine(ItMath.IsItNumb("1234,"));
            Console.WriteLine(ItMath.IsItNumb("12-34"));

            Console.WriteLine("Valid numbers");

            Console.WriteLine(ItMath.IsItNumb("0"));
            Console.WriteLine(ItMath.IsItNumb("123"));
            Console.WriteLine(ItMath.IsItNumb("123,45"));
            Console.WriteLine(ItMath.IsItNumb("+123"));
            Console.WriteLine(ItMath.IsItNumb("-123"));
            Console.WriteLine(ItMath.IsItNumb("+123,45"));
            Console.WriteLine(ItMath.IsItNumb("-123,45"));
        }
    }
}