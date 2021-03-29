using eKino.Data;
using eKino.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    public class VijestiController : Controller
    {
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;
        private ApplicationDbContext _db;

        public VijestiController(ApplicationDbContext db, UserManager<Korisnik> userManager,
            SignInManager<Korisnik> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Dodaj(int ID)
        {
            VijestiDodajVM model = ID == 0 ? new VijestiDodajVM() :
                _db.Vijest
                .Select(v => new VijestiDodajVM()
                {
                    ID=v.ID,
                    Naslov=v.Naslov,
                    Sadrzaj=v.Sadrzaj,
                    SlikaUrl=v.SlikaUrl
                }).ToList()
                .Find(v=>v.ID==ID);

            return View(model);
        }
        public IActionResult Prikaz()
        {
            List<VijestiPrikazVM.Row> vijesti = _db.Vijest
                .Select(v => new VijestiPrikazVM.Row()
                {
                    ID = v.ID,
                    Naslov = v.Naslov,
                    Sadrzaj = v.Sadrzaj,
                    Datum = v.Datum,
                    SlikaUrl = v.SlikaUrl,
                    Korisnik = v.Korisnik.UserName
                })
                .OrderByDescending(v => v.Datum)
                .ToList();

            VijestiPrikazVM model = new VijestiPrikazVM()
            {
                Vijesti = vijesti
            };
            return View(model);
        }
        public IActionResult Snimi(VijestiDodajVM model)
        {
            Vijest vijest = model.ID == 0 ? new Vijest() :
                _db.Vijest.Find(model.ID);

            vijest.Naslov = model.Naslov;
            vijest.Sadrzaj = model.Sadrzaj;
            vijest.SlikaUrl = model.SlikaUrl;
            
            if(model.ID==0)
            {
                vijest.Datum = DateTime.Now;
                vijest.KorisnikID = _userManager.GetUserAsync(User).Result.Id;

                _db.Vijest.Add(vijest);
            }
            _db.SaveChanges();
            return Redirect("/Vijesti/Prikaz");
        }
        public IActionResult Obrisi(int ID)
        {
            Vijest vijest = _db.Vijest.Find(ID);
            _db.Vijest.Remove(vijest);
            _db.SaveChanges();
            return Redirect("/Vijesti/Prikaz");
        }
    }
}
