using eKino.Data;
using eKino.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    public class ProjekcijeController : Controller
    {
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;
        private ApplicationDbContext _db;
        public ProjekcijeController(ApplicationDbContext db, UserManager<Korisnik> userManager, SignInManager<Korisnik> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Dodaj(int ID)
        {
            List<SelectListItem> filmovi = _db.Film
                .Select(f => new SelectListItem()
                {
                    Text = f.Naziv,
                    Value = f.ID.ToString()
                })
                .OrderBy(f => f.Text)
                .ToList();

            List<ProjekcijeDodajVM.Filter> sale = _db.Sala
                .Select(s => new ProjekcijeDodajVM.Filter()
                {
                    Ime = s.Oznaka,
                    SalaID = s.ID,
                    Selected = false                  
                })
                .ToList();

            List<string> slike = _db.Film
                .Select(f => f.SlikaUrl)
                .ToList();

            ProjekcijeDodajVM model = new ProjekcijeDodajVM()
            {
                Filmovi = filmovi,
                Sale = sale,
                ProjekcijaId = ID,
                DatumOd = DateTime.Today,
                DatumDo=DateTime.Today,
                Slike=slike
            };
            
            return View(model);
        }
        public IActionResult Uredi()
        {
            List<ProjekcijeUrediVM.Row> projekcije = _db.Projekcija
                .Select(p => new ProjekcijeUrediVM.Row()
                {
                    ID=p.ID,
                    FilmID=p.FilmID,
                    Film=p.Film.Naziv,
                    Datum=p.Datum,
                    Vrijeme=p.Datum.ToString("H:mm"),
                    Sala=p.Sala.Oznaka,
                    Cijena=p.Cijena.ToString()+" KM",
                    SlikaUrl=p.Film.SlikaUrl,
                    Covid19=p.Covid19 ? "DA" : "NE",
                    Trajanje=p.Film.TrajanjeMinute.ToString() + " min"
                })
                .OrderByDescending(p=>p.Datum)
                .ToList();

            ProjekcijeUrediVM model = new ProjekcijeUrediVM()
            {
                Projekcije=projekcije
            };
            return View(model);
        }
        public IActionResult Snimi(ProjekcijeDodajVM model)
        { 
            if(model.DatumOd>model.DatumDo || !ModelState.IsValid)
            {
                ModelState.AddModelError("", "Pogrešan unos!");
                return Redirect("/Projekcije/Dodaj");
            }

            int BrojDana= int.Parse(model.MetodaZakazivanja);
            for (DateTime d = model.DatumOd; d.Date <= model.DatumDo; d = d.Date.AddDays(BrojDana))
            {
                DateTime datumStari = d;
                DateTime v = model.Vrijeme;
                DateTime datum = new DateTime(datumStari.Year, datumStari.Month, datumStari.Day, v.Hour, v.Minute, 0);

                foreach (var s in model.Sale)
                {
                    if (s.Selected)
                    {
                        Projekcija projekcija = new Projekcija()
                        {
                            FilmID = model.FilmId,
                            Datum = datum,
                            Covid19 = model.Covid19,
                            Cijena = 5,
                            SalaID=s.SalaID
                        };
                        _db.Projekcija.Add(projekcija);
                    }
                }
            }
            _db.SaveChanges();
            return View();
        }
    }
}
