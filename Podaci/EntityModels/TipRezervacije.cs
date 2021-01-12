using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Podaci.EntityModels
{
    public class TipRezervacije
    {
        public int ID { get; set; }
        public string TipNaziv { get; set; }
        [Range(0, 1)]
        public Decimal Popust { get; set; }
    }
}
