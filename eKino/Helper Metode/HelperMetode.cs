using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Helper_Metode
{
    public class HelperMetode
    {
        public static DateTime SpojiDatumIVrijeme(DateTime datumStari, DateTime vrijeme)
        {
            DateTime v = vrijeme;
            DateTime datum = new DateTime(datumStari.Year, datumStari.Month, datumStari.Day, v.Hour, v.Minute, 0);
            return datum;
        }
    }
}
