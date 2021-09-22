using eKino.Data;
using eKino.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKino.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private readonly UserManager<Korisnik> _userManager;
        private readonly SignInManager<Korisnik> _signInManager;
        public KorisnikController(UserManager<Korisnik> userManager, SignInManager<Korisnik> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public KorisnikModel Get(string email="", string password="")
        {

            var user = _userManager.FindByEmailAsync(email).Result;

            if (user==null)
            {
                return new KorisnikModel()
                {
                    id = null,
                    username = null
                };
            }

            var login = _signInManager.PasswordSignInAsync(user.UserName, password, false, lockoutOnFailure: false).Result;

            if (!login.Succeeded)
            {
                return new KorisnikModel()
                {
                    id = null,
                    username = null
                };
            }

            KorisnikModel korisnik = new KorisnikModel()
            {
                id = user.Id,
                username = user.UserName
            };
                return korisnik;         
        }
        //[HttpGet("{id}")]
        //public string GetUserName(string id)
        //{
        //    string username = _context.Korisnik.SingleOrDefault(k => k.Id == id).UserName;
        //    return username;
        //}
    }
}
