using System;
using System.Globalization;

namespace AppPicoPlaca.Utils
{
    public class UtilsApp
    {        
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
