using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class ProjekcijeUrediVM
    {
        public int ProjekcijaID { get; set; }
        public List<SelectListItem> Sale { get; set; }
        public int SalaID { get; set; }
        public string FilmIme { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        public bool Covid19 { get; set; }
        [Required]
        public DateTime Vrijeme { get; set; }
        [Required]
        public string MetodaZakazivanja { get; set; }
        public string SlikaUrl { get; set; }
        [Required]
        public decimal Cijena { get; set; }

    }
}

