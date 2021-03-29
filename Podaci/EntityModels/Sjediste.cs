using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Podaci.EntityModels
{
    public class Sjediste
    {
        public int ID { get; set; }
        [StringLength(1)]
        public string RedOznaka { get; set; }
        [Range(1, 20)]
        public int KolonaOznaka { get; set; }
        public int SalaID { get; set; }
        public Sala Sala { get; set; }
        public bool LoveSjediste { get; set; }
    }
}
