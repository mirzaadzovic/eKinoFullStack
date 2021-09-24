using eKino.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;
        public ApplicationDbContext _db;
        public AdminController(UserManager<Korisnik> userManager, ApplicationDbContext db, 
            SignInManager<Korisnik> signInManager)
        {
            _userManager = userManager;
            _db = db;
            _signInManager = signInManager;

        }
        public IActionResult Index()
        {
            var visitor = _userManager.GetUserAsync(User).Result;
            if (!visitor.IsAdmin && !visitor.IsModerator)
                return Forbid();

            Korisnik korisnik = _userManager.GetUserAsync(User).Result;
            if (korisnik.IsPosjetilac)
            {
                return Redirect("/Home/Index");
            }
            string m = _userManager.GetUserAsync(User).Result.UserName;
            return View("Index",m);
        }
        public IActionResult Filmovi(int ID)
        {
            return View(ID);
        }
    }
}
