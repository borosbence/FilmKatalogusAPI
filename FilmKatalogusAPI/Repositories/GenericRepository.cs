using FilmKatalogusAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmKatalogusAPI.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> 
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        private readonly TContext _context;
        public GenericRepository(TContext context)
        {
            _context = context;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, TEntity entity)
        {
            var dbEntity = await _context.Set<TEntity>().FindAsync(id);
            if (dbEntity != null)
            {
                _context.Entry(dbEntity).CurrentValues.SetValues(entity);
                // _context.Update(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
