using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Models
{
    public class SjedistaRezervisiVM
    {
        public PonudaPrikazVM.Row Film { get; set; }
        public List<SelectListItem> Termini { get; set; }
        public int TerminID { get; set; }
    }
}
