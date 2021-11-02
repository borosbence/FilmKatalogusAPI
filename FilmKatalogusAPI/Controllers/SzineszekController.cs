using FilmKatalogusAPI.Data;
using FilmKatalogusAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmKatalogusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzineszekController : CoreController<Szinesz, SzineszRepository>
    {
        public SzineszekController(SzineszRepository repository) : base(repository)
        {

        }
    }
}
