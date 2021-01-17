using eKino.Data;
using eKino.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _db;
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;

        public HomeController(ApplicationDbContext db, UserManager<Korisnik> userManager, SignInManager<Korisnik> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //public IActionResult DodajAdmina(string username, string password)
        //{
        //    Administrator korisnik = new Administrator()
        //    {
        //        Email = "sandzak.bob@gmail.com",
        //        UserName = username,
        //        EmailConfirmed = true
        //    };

        //    IdentityResult result = _userManager.CreateAsync(korisnik, password).Result;
        //    if(!result.Succeeded)
        //    {
        //        return RedirectToPage("/Account/Login", new { area = "Identity" });
        //    }

        //    //Administrator admin = new Administrator()
        //    //{
        //    //    Korisnik = korisnik
        //    //};
        //    //_db.Administrator.Add(admin);
        //    //_db.SaveChanges();

        //    return View();
        //}
        public IActionResult Index()
        {
            HomeIndexVM model = new HomeIndexVM();

            ////Dodavanje sjedišta u bazu
            //string[] redovi = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Sjediste s = new Sjediste()
            //        {
            //            SalaID = 7,
            //            LoveSjediste = false,
            //            KolonaOznaka = j + 1,
            //            RedOznaka = redovi[i]
            //        };
            //        _db.Sjediste.Add(s);
            //        Console.Write($"{s.RedOznaka}{s.KolonaOznaka}");
            //        _db.SaveChanges();
            //    }
            //    Console.WriteLine();
            //}

            return View(model);
        }

        [Authorize]
        public IActionResult Privacy()
        {
            var korisnik = _userManager.GetUserAsync(User).Result;
            if (!korisnik.IsAdmin)
                return Redirect("/Home/Index");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
