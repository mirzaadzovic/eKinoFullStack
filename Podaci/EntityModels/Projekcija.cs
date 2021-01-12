using System;
using System.Collections.Generic;
using System.Text;

namespace Podaci.EntityModels
{
    public class Projekcija
    {
        public int ID { get; set; }
        public int FilmID { get; set; }
        public Film Film { get; set; }
        public int SalaID { get; set; }
        public Sala Sala { get; set; }
        public DateTime Datum { get; set; }
        public Decimal Cijena { get; set; }
        public bool Covid19 { get; set; }
        public string GetTermin()
        {
            return Datum.ToString("HH:mm");
        }
    }
   
}
