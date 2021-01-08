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
        public IActionResult DodajAdmina(string username, string password)
        {
            Administrator korisnik = new Administrator()
            {
                Email = "sandzak.bob@gmail.com",
                UserName = username,
                EmailConfirmed = true
            };

            IdentityResult result = _userManager.CreateAsync(korisnik, password).Result;
            if(!result.Succeeded)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }

            //Administrator admin = new Administrator()
            //{
            //    Korisnik = korisnik
            //};
            //_db.Administrator.Add(admin);
            //_db.SaveChanges();

            return View();
        }
        public IActionResult Index()
        {
            //var user = _userManager.GetUserAsync(User).Result;

            //if (user == null/*&& user.Posjetilac!=null*/)
            //    return RedirectToPage("/Account/Login", new { area = "Identity" });
            return View();
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
