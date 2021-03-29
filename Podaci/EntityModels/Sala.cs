using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Podaci.EntityModels
{
    public class Sala
    {
        public int ID { get; set; }
        [StringLength(1)]
        public string Oznaka { get; set; }
        public int BrojSjedista { get; set; }

    }
}
