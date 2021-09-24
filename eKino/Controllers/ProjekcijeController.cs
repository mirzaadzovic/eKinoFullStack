using eKino.Data;
using eKino.Hubs;
using eKino.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eKino.Helper_Metode;

namespace eKino.Controllers
{
    public class ProjekcijeController : Controller
    {
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;
        private ApplicationDbContext _db;
        private IHubContext<NotifikacijaHub> _hubContext;
        public ProjekcijeController(ApplicationDbContext db, UserManager<Korisnik> userManager, 
            SignInManager<Korisnik> signInManager, IHubContext<NotifikacijaHub>  hubContext)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
            _hubContext = hubContext;
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
        public IActionResult Prikaz()
        {

            List<ProjekcijePrikazVM.Row> projekcije = _db.Projekcija
                .Select(p => new ProjekcijePrikazVM.Row()
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
                    Trajanje=p.Film.TrajanjeMinute.ToString()
                })
                .OrderByDescending(p=>p.Datum)
                .ToList();

            ProjekcijePrikazVM model = new ProjekcijePrikazVM()
            {
                Projekcije=projekcije
            };
            return View(model);
        }
        public IActionResult Uredi(int ID)
        {
            List<SelectListItem> sale = _db.Sala
                .Select(s => new SelectListItem()
                {
                    Text = "Sala "+s.Oznaka,
                    Value= s.ID.ToString()
                })
                .ToList();

            Projekcija p = _db.Projekcija
                .Find(ID);
            p.Film = _db.Film.Find(p.FilmID);

            ProjekcijeUrediVM model = new ProjekcijeUrediVM()
            {
                ProjekcijaID = ID,
                FilmIme = p.Film.Naziv,
                SlikaUrl = p.Film.SlikaUrl,
                Datum = p.Datum,
                Vrijeme = p.Datum,
                Covid19 = p.Covid19,
                Cijena = p.Cijena,
                SalaID=p.SalaID,
                Sale=sale
            };
            return View(model);
        }
        public IActionResult Snimi(ProjekcijeDodajVM model)
        {
            if (model.DatumOd > model.DatumDo)
                model.DatumDo = model.DatumOd;

            if (!ModelState.IsValid)
            {
                _hubContext.Clients.User(_userManager
                    .GetUserAsync(User).Result.Id)
                    .SendAsync("prijemNotifikacije",
               _userManager
               .GetUserAsync(User).Result.UserName,
               " je fulio unos ");
                return Redirect("/Projekcije/Dodaj");
            }

            int BrojDana= int.Parse(model.MetodaZakazivanja);
            for (DateTime d = model.DatumOd; d.Date <= model.DatumDo; d = d.Date.AddDays(BrojDana))
            {
                DateTime datum = HelperMetode.SpojiDatumIVrijeme(d, model.Vrijeme);

                //DateTime datumStari = d;
                //DateTime v = model.Vrijeme;
                //DateTime datum = new DateTime(datumStari.Year, datumStari.Month, datumStari.Day, v.Hour, v.Minute, 0);

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

            //Film film = _db.Film.Find(model.FilmID);
            //string poruka = "Dodana projekcija!";
            //_hubContext.Clients.All.SendAsync("prijemNotifikacije", poruka);

            return View();
        }
        public IActionResult SnimiPromjene(ProjekcijeUrediVM model)
        {
            Projekcija p = _db.Projekcija.Find(model.ProjekcijaID);

            p.Datum = HelperMetode.SpojiDatumIVrijeme(model.Datum, model.Vrijeme);
            p.Cijena = model.Cijena;
            p.Covid19 = model.Covid19;
            p.SalaID = model.SalaID;

            _db.SaveChanges();

            return Redirect("/Projekcije/Prikaz");
        }
        public IActionResult Obrisi (int ID)
        {
            Projekcija projekcija = _db.Projekcija.Find(ID);
            _db.Remove(projekcija);
            _db.SaveChanges();

            Film film = _db.Film.Find(projekcija.FilmID);
            string poruka = $"Otkazana projekcija filma {film.Naziv} dana {projekcija.Datum.ToString("d.M.yyyy")}. u {projekcija.Datum.ToString("HH:mm")}!";
            _hubContext.Clients.All.SendAsync("prijemNotifikacije", poruka);

            return Redirect("/Projekcije/Prikaz");
        }
    }
}
