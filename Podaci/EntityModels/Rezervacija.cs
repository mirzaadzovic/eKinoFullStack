using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Podaci.EntityModels
{
    public class Rezervacija
    {
        public int ID { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public int ProjekcijaID {get; set;}
        public Projekcija Projekcija { get; set; }
        public int SjedisteID { get; set; }
        public Sjediste Sjediste { get; set; }
        public DateTime DatumRezervacije { get; set; }
        [DefaultValue(1)]
        public int TipRezervacijeID { get; set; }
        public TipRezervacije TipRezervacije { get; set; }
        public Guid Sifra { get; set; }
    }
}
