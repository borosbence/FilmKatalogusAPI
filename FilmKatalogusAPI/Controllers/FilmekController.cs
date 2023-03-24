using Microsoft.AspNetCore.Mvc;
using FilmKatalogusAPI.Models;
using FilmKatalogusAPI.Repositories;

namespace FilmKatalogusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmekController : CoreController<Film>
    {
        public FilmekController(IGenericRepository<Film> repository) : base(repository)
        {

        }
    }
}
