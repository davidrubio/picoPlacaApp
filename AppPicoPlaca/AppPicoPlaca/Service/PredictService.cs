using AppPicoPlaca.Utils;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPicoPlaca.Service
{
    public class PredictService
    {

        public static bool ProcessPicoYPlaca(LicensePlateEntitie licensePlate)
        {
            //process data
            return ExistRestriction(licensePlate);
        }

        public static bool ExistRestriction(LicensePlateEntitie licensePlate)
        {
            var lastNumber = UtilsApp.getLastNumber(licensePlate.LicensePlateNumber);
            string dayToGoOut = UtilsApp.getDay(licensePlate.DateGoOut);
            string dayOfRestriction = GetDayOfRestriction(lastNumber);
            if (dayToGoOut.ToUpper().Equals(dayOfRestriction.ToUpper()))
                return true;
            else
                return false;
        }

        private static string GetDayOfRestriction(int licensePlateNumber)
        {
            var roundDay = 5.0;
            if (licensePlateNumber != 0)
            {
                double dayOfRestriction = (double)licensePlateNumber / (double)2;
                roundDay = Math.Ceiling(dayOfRestriction);
            }            
            return UtilsApp.getDay(Convert.ToInt32(roundDay)) ;
        }

    }
}
