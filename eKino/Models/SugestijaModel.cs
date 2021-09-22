using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class SugestijaModel
    {
        public int id { get; set; }
        public string Korisnik { get; set; }
        public string Datum { get; set; }
        public string Sugestija { get; set; }
    }
}
