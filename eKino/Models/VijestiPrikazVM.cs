using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class VijestiPrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public string Naslov { get; set; }
            public string Sadrzaj { get; set; }
            public string SlikaUrl { get; set; }
            public DateTime Datum { get; set; }
            public string Korisnik { get; set; }
        }
        public List<Row> Vijesti { get; set; }
    }
}
