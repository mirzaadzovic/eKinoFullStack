using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class SjedistaPrikazVM
    {
        public class Row
        {
            public int SjedisteID { get; set; }
            public string Red { get; set; }
            public int Kolona { get; set; }
            public string cssClass { get; set; }
        }

        public List<SjedistaPrikazVM.Row> Sjedista { get; set; }
        public int TerminID { get; set; }
    }
}
