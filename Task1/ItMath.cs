using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ItMathAppli
{
    class ItMath
    {
        public static bool IsItNumb(string input)
        {
            CultureInfo info = CultureInfo.GetCultureInfo("fi-Fi");
            float numb = 0;
            int length = input.Length - 1;
            if (input[0].ToString() != "," && input[length].ToString() != ",")
            {
                bool result = float.TryParse(input, NumberStyles.Any, info, out numb);
                if (result)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}