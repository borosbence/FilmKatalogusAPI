using FilmKatalogusAPI.Models;
using FilmKatalogusAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmKatalogusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzineszekController : CoreController<Szinesz>
    {
        public SzineszekController(IGenericRepository<Szinesz> repository) : base(repository)
        {
        }
    }
}
