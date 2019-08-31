using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPicoPlaca.Utils
{
    public class UtilsApp
    {
        //Return the name of the day in spanish from specific date
        public static string getDayInSpanish(DateTime date)
        {                
            return date.ToString("dddd", new CultureInfo("es-ES"));
        }

        public static string getDay(DateTime date)
        {
            return date.ToString("dddd", new CultureInfo("en-US"));
        }

        public static string getDay(int numberofDay)
        {
            return Enum.GetName(typeof(DayOfWeek), numberofDay);
        }

        //Get the last char of a string 
        public static int getLastNumber(string licensePlateNumber)
        {
            var lastNumber = licensePlateNumber.Substring(licensePlateNumber.Length - 1);
            return Convert.ToInt32(lastNumber);
        }


    }
}
