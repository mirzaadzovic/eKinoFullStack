using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class ProjekcijeDodajVM
    {
        public List<Filter> Sale { get; set; }
        public List<SelectListItem> Filmovi { get; set; }
        [Required]
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public bool Covid19 { get; set; }
        [Required]
        public DateTime Vrijeme { get; set; }
        [Required]
        public int FilmId { get; set; }
        public string MetodaZakazivanja { get; set; }
        public int ProjekcijaId { get; set; }
        public List<string> Slike { get; set; }

        public class Filter
        {
            public int SalaID { get; set; }
            public string Ime { get; set; }
            public bool Selected { get; set; }
        }
    }
}
