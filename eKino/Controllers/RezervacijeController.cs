using eKino.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Korisnik> _userManager;
        public RezervacijeController(ApplicationDbContext context, UserManager<Korisnik>  userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<Rezervacija> Get()
        {
            string userId = _userManager.GetUserAsync(User).Result.Id;
            var rezervacije = _context.Rezervacija
                .Select(r=>new Rezervacija() 
                {
                    ID=r.ID,
                    Projekcija=r.Projekcija,
                    ProjekcijaID=r.ProjekcijaID,
                    Korisnik=r.Korisnik,
                    KorisnikID=r.KorisnikID,
                    DatumRezervacije=r.DatumRezervacije,
                    TipRezervacije=r.TipRezervacije,
                    TipRezervacijeID=r.TipRezervacijeID,
                    Sifra=r.Sifra,
                    Sjediste=r.Sjediste,
                    SjedisteID=r.SjedisteID
                })
                .Where(r=>r.KorisnikID==userId)
                .ToList();
            return rezervacije;
        }
        [HttpGet("{id}")]
        public Rezervacija GetById(int id)
        {
            var rezervacija = _context.Rezervacija
                .Include(r => r.TipRezervacije)
                .Include(r => r.Korisnik)
                .Include(r => r.Projekcija)
                .SingleOrDefault(r => r.ID == id);
            return rezervacija;
        }
    }
}
