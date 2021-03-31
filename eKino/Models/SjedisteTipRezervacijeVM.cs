using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class SjedisteTipRezervacijeVM
    {
        public int TerminId { get; set; }
        public List<SjedistaVM> Sjedista { get; set; }
        public List<Row> TipoviRezervacije { get; set; }
        public class Row
        {
            public int TipId { get; set; }
            public string Opis { get; set; }
            public Decimal Popust { get; set; }
        }
        public class SjedistaVM
        {
            public int SjedisteID { get; set; }
            public string Opis { get; set; }
        }
    }
}
