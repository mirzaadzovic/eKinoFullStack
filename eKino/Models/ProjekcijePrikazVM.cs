using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class ProjekcijePrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public int FilmID { get; set; }
            public string Film { get; set; }
            public DateTime Datum { get; set; }
            public string Vrijeme { get; set; }
            public string Trajanje { get; set; }
            public string SlikaUrl { get; set; }
            public byte[] Slika { get; set; }
            public string Sala { get; set; }
            public string Cijena { get; set; }
            public string Covid19 { get; set; }
        }
        public List<Row> Projekcije { get; set; }
    }
}
