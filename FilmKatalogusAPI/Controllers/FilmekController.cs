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

        public override async Task<ActionResult<IEnumerable<Film>>> GetAllAsync()
        {
            return await _repository.GetAllAsync(x => x.FilmMufaj);
        }

        public override async Task<ActionResult<Film>> GetAsync(int id)
        {
            var film = await _repository.GetAsync(id, x => x.FilmMufaj);
            if (film == null)
            {
                return NotFound();
            }
            return film;
        }
    }
}
