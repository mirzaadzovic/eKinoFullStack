using eKino.Data;
using eKino.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class SugestijeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SugestijeController(ApplicationDbContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IEnumerable<Sugestija> Get()
        {
            var sugestije = _context.Sugestija
                .Include(s=>s.Korisnik)
                .ToList();
            return sugestije;
        }
        [HttpGet("{id}")]
        public IEnumerable<SugestijaModel> GetByUser(string id)
        {
            var sugestije = _context.Sugestija
                .Include(s => s.Korisnik)
                .Where(s => s.KorisnikID == id)
                .OrderByDescending(s=>s.Datum)
                .Select(s=>new SugestijaModel()
                {
                    id=s.SugestijaID,
                    Korisnik=s.Korisnik.UserName,
                    Datum=s.Datum.ToString("dd/MM/yyyy"),
                    Sugestija=s.Tekst
                })
                .ToList();

            return sugestije;
        }
        [HttpPost]
        public SugestijaModel Post(SugestijaPost model)
        {
            Sugestija sugestija = new Sugestija()
            {
                KorisnikID = model.KorisnikId,
                Tekst = model.Sugestija,
                Datum = DateTime.Now,
            };

                _context.Sugestija.Add(sugestija);
                _context.SaveChanges();
            SugestijaModel nova = new SugestijaModel()
            {
                id = sugestija.SugestijaID,
                Korisnik = model.Korisnik,
                Datum = sugestija.Datum.ToString("dd/MM/yyyy"),
                Sugestija = model.Sugestija
            };
            return nova;
        }
        [HttpPut]
        public SugestijaModel Put(int id, SugestijaPost sugestija)
        {
            var sugestijaOld = _context.Sugestija.Find(id);
            sugestijaOld.Tekst = sugestija.Sugestija;
            sugestijaOld.Datum = DateTime.Now;

            _context.SaveChanges();
            SugestijaModel nova = new SugestijaModel()
            {
                id = sugestijaOld.SugestijaID,
                Korisnik = sugestija.Korisnik,
                Datum = sugestijaOld.Datum.ToString("dd/MM/yyyy"),
                Sugestija =sugestija.Sugestija
            };
            return nova;
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var sugestija = _context.Sugestija.Find(id);
            _context.Sugestija.Remove(sugestija);
            _context.SaveChanges();
        }
    }
}
