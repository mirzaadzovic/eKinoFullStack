using eKino.Helper_Metode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class HomeIndexVM
    {
        public class Dan
        {
            public int Value { get; set; }
            public string DanUSedmici { get; set; }
        }
        public class Row
        {
            public int ID { get; set; }
            public string SlikaUrl { get; set; }
            public string Naslov { get; set; }
        }
        public List<Dan> Dani { get; set; }
        public List<Row> Vijesti {get; set;}
        public HomeIndexVM()
        {
            Dani = new List<Dan>();
            for(int i=0; i<7; i++)
            {
                //INICIJALIZACIJA Dana u sedmici
                Dan dan = new Dan();
                dan.Value = i;

                DateTime danas = DateTime.Today;
                danas = danas.AddDays(i);
                //if (danas.DayOfWeek == DayOfWeek.Sunday)
                //    dan.DanUSedmici="Nedjelja";
                //else if (danas.DayOfWeek == DayOfWeek.Monday)
                //    dan.DanUSedmici = "Ponedjeljak";
                //else if (danas.DayOfWeek == DayOfWeek.Tuesday)
                //    dan.DanUSedmici = "Utorak";
                //else if (danas.DayOfWeek == DayOfWeek.Wednesday)
                //    dan.DanUSedmici = "Srijeda";
                //else if (danas.DayOfWeek == DayOfWeek.Thursday)
                //    dan.DanUSedmici = "Četvrtak";
                //else if (danas.DayOfWeek == DayOfWeek.Friday)
                //    dan.DanUSedmici = "Petak";
                //else if (danas.DayOfWeek == DayOfWeek.Saturday)
                //    dan.DanUSedmici = "Subota";
                dan.DanUSedmici = HelperMetode.DanUsedmiciBosanski(danas);

                Dani.Add(dan);
            }
        }
    }
}
