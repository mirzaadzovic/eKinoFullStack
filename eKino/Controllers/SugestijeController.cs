using Microsoft.AspNetCore.Http;
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
    public class SugestijeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Sugestija> Get()
        {
            return new List<Sugestija>();
        }
    }
}
