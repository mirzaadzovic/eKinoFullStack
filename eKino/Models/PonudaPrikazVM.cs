using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class PonudaPrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public int FilmID { get; set; }
            public string Film { get; set; }
            public DateTime Datum { get; set; }
            public List<string> Termini { get; set; }
            public string Info { get; set; }
            public string Reditelj { get; set; }
            public string Godina { get; set; }
            public string Glumci { get; set; }
            public string Trajanje { get; set; }
            public string Zanr { get; set; }
            public string SlikaUrl { get; set; }
            public byte[] Slika { get; set; }
            public string Sala { get; set; }
            public string DanUSedmini { get; set; }
            public decimal Cijena { get; set; }
        }
        public class Termin
        {
            public int FilmID { get; set; }
            public DateTime Vrijeme { get; set; }
        }
        public List<Termin> Termini { get; set; }
        public List<Row> Ponuda { get; set; }
        public int dan { get; set; }
    }
}
