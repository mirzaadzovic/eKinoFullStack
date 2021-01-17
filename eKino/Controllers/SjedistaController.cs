using eKino.Data;
using eKino.Helper_Metode;
using eKino.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    [Authorize]
    public class SjedistaController : Controller
    {
        private ApplicationDbContext _db;
        public SjedistaController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Rezervisi(int Ponuda)
        {
            PonudaPrikazVM.Row ponuda = _db.Projekcija
               .Where(p => p.ID==Ponuda)
               .Select(p => new PonudaPrikazVM.Row()
               {
                   ID = p.ID,
                   Film = p.Film.Naziv,
                   FilmID = p.FilmID,
                   Datum = p.Datum,
                   Godina = p.Film.Godina.ToString(),
                   Zanr = p.Film.Zanr,
                   Glumci = p.Film.Glumci,
                   Reditelj = p.Film.Reditelj,
                   SlikaUrl = p.Film.SlikaUrl,
                   Trajanje = p.Film.TrajanjeMinute.ToString(),
                   Sala = p.Sala.Oznaka,
                   DanUSedmini = HelperMetode.DanUsedmiciBosanski(p.Datum),
                   Cijena = p.Cijena
               })
               .Single();

            var termini = _db.Projekcija
                .Where(p => p.FilmID == ponuda.FilmID && p.Datum.Date == ponuda.Datum.Date && p.Datum > DateTime.Now)
                .Select(p => new SelectListItem()
                {
                    Text = p.Datum.ToString("HH:mm"),
                    Value = p.ID.ToString()
                }).ToList();

            SjedistaRezervisiVM model = new SjedistaRezervisiVM()
            {
                Film = ponuda,
                Termini =termini
            };
            return PartialView(model);
        }
        public IActionResult Prikaz(int TerminID)
        {
            int salaID = _db.Projekcija.Find(TerminID).SalaID;

            List<SjedistaPrikazVM.Row> sjedista = _db.Sjediste
                .Where(s => s.SalaID == salaID)
                .Select(s => new SjedistaPrikazVM.Row()
                {
                    SjedisteID=s.ID,
                    Red=s.RedOznaka,
                    Kolona=s.KolonaOznaka
                })
                .OrderByDescending(s=>s.Red)
                .ThenBy(s=>s.Kolona)
                .ToList();

            List<Rezervacija> rezervacije = _db.Rezervacija.Where(r => r.ProjekcijaID == TerminID).ToList();
            foreach(var s in sjedista)
            {
                if(rezervacije.Find(p=>p.SjedisteID==s.SjedisteID)==null)
                {
                    s.cssClass = "seat";
                }
                else
                {
                    s.cssClass = "seat-zauzeto";
                }
            }
            List<SjedistaPrikazVM.Odabrana> odabrana = sjedista
                .Where(s => s.cssClass == "seat")
                .Select(s => new SjedistaPrikazVM.Odabrana()
                {
                    Odabrano = false,
                    SjedisteID=s.SjedisteID
                }).ToList();
            SjedistaPrikazVM model = new SjedistaPrikazVM()
            {
                Sjedista=sjedista,
                OdabranaSjedista=odabrana
            };
            return PartialView(model);
        }
    }
}
