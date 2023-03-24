using FilmKatalogusAPI.Models;
using FilmKatalogusAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FilmKatalogusAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class CoreController<TEntity> : ControllerBase
        where TEntity : class, IEntity
    {
        private readonly IGenericRepository<TEntity> _repository;

        public CoreController(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await _repository.GetAllAsync();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var enttiy = await _repository.GetAsync(id);
            if (enttiy == null)
            {
                return NotFound();
            }
            return enttiy;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await _repository.UpdateAsync(id, entity);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.AddAsync(entity);
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            await _repository.DeleteAsync(id);   
            return NoContent();
        }
    }
}
