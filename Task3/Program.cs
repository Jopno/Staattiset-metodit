using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItParserApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give numbers separated by comma. ");
            string line = Console.ReadLine();
            TestParser(line);
        }

        public static void TestParser(string line)
        {
            Console.WriteLine("Markline {0} include {1} numbers , sum of numbers is {2}" +
                " and average is {3}", line, ItParser.Count(line), ItParser.Sum(line), ItParser.Average(line));
        }
    }
}
