using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class FilmoviPrikazVM
    {
        public int ID { get; set; }
        public List<FilmoviDodajVM> Filmovi { get; set; }
    }
}
