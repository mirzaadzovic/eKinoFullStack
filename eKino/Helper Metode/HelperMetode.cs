using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Helper_Metode
{
    public class HelperMetode
    {
        public static string DanUsedmiciBosanski(DateTime danas)
        {
            if (danas.DayOfWeek == DayOfWeek.Sunday)
                return  "Nedjelja";
            else if (danas.DayOfWeek == DayOfWeek.Monday)
                return "Ponedjeljak";
            else if (danas.DayOfWeek == DayOfWeek.Tuesday)
                return "Utorak";
            else if (danas.DayOfWeek == DayOfWeek.Wednesday)
                return "Srijeda";
            else if (danas.DayOfWeek == DayOfWeek.Thursday)
                return "Četvrtak";
            else if (danas.DayOfWeek == DayOfWeek.Friday)
                return "Petak";
            else /*danas.DayOfWeek == DayOfWeek.Saturday*/
                return "Subota";
        }
        public static DateTime SpojiDatumIVrijeme(DateTime datumStari, DateTime vrijeme)
        {
            DateTime v = vrijeme;
            DateTime datum = new DateTime(datumStari.Year, datumStari.Month, datumStari.Day, v.Hour, v.Minute, 0);
            return datum;
        }
    }
}
