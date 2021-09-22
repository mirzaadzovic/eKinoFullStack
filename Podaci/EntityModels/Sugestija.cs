using System;
using System.Collections.Generic;
using System.Text;

namespace Podaci.EntityModels
{
    public class Sugestija
    {
        public int SugestijaID { get; set; }
        public string Tekst { get; set; }
        public DateTime Datum { get; set; }
        public string KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
