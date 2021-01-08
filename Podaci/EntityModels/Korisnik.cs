using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Podaci.EntityModels
{
    public class Korisnik:IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool IsAdmin => this is Administrator;
        public bool IsPosjetilac => this is Posjetilac;
        public bool IsModerator => this is Moderator;

        public Administrator Administrator => this as Administrator;
        public Posjetilac Posjetilac => this as Posjetilac;
        public Moderator Moderator => this as Moderator;
        
        //Neobavezni-opcionalni
        //public Administrator Administrator { get; set; }
        //public Posjetilac Posjetilac { get; set; }
        //public Moderator Moderator { get; set; }
    }
}
