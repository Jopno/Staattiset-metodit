using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItParserApplication
{
    class ItParser
    {
        public static int Count(string line)
        {
            int[] array = line.Split(',').Select(Xline => int.Parse(Xline)).ToArray();
            return array.Length;
        }
        public static double Average(string line)
        {
            int[] array = line.Split(',').Select(Xline => int.Parse(Xline)).ToArray();
            return array.Average();
        }

        public static int Sum(string line)
        {
            int[] array = line.Split(',').Select(Xline => int.Parse(Xline)).ToArray();
            return array.Sum();
        }


    }
}
