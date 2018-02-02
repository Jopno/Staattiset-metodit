using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItDay
{
    class DayApplication
    {
        internal static bool IsDay( string input)
        {
            DateTime date;
            string[] pattern = new string[] { "d.M.yyyy", "d.M.yy" };
            if (DateTime.TryParseExact(input, pattern, System.Globalization.CultureInfo.CurrentCulture,
                System.Globalization.DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString("d.M.yyyy"));
                return true;
            }
            else
            {
                return false;
            }
        }
        //zulul
    }
}
