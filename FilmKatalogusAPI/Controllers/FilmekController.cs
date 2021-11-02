using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilmKatalogusAPI;
using FilmKatalogusAPI.Models;
using FilmKatalogusAPI.Repositories;

namespace FilmKatalogusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmekController : MyMDBController<Film, FilmRepository>
    {
        public FilmekController(FilmRepository repository) : base(repository)
        {

        }
    }
}
