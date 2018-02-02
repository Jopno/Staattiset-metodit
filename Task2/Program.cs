using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItDay
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give a date");
            string line = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("It is finnish date: {0} ", DayApplication.IsDay(line));

        }
    }
}
