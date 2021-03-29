using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Podaci.EntityModels
{
    public class Film
    {
        [Key]
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public string Zanr { get; set; }
        public string Info { get; set; }
        public string Reditelj { get; set; }
        public string Glumci { get; set; }
        public byte[] Slika { get; set; }
        public string SlikaUrl { get; set; }
        public int TrajanjeMinute { get; set; }
        public string TrailerUrl { get; set; }
        public DateTime DatumPremijere { get; set; }
    }
}
