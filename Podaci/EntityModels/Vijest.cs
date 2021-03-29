using System;
using System.Collections.Generic;
using System.Text;

namespace Podaci.EntityModels
{
    public class Vijest
    {
        public int ID { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string SlikaUrl { get; set; }
        public DateTime Datum { get; set; }
        public string KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
