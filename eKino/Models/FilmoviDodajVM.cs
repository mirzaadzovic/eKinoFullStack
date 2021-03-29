using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class FilmoviDodajVM
    {
        public int FilmID { get; set; }
        public string FilmIme { get; set; }
        public string Godina { get; set; }
        public string Zanr { get; set; }
        public string Reditelj { get; set; }
        public string Glumci { get; set; }
        public string Trajanje { get; set; }
        public string SlikaURL { get; set; }
        public string TrailerURL { get; set; }
        public string Info { get; set; }
    }
}
