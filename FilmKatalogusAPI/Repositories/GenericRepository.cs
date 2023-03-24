using FilmKatalogusAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public async Task<List<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            // return await _context.Set<TEntity>().ToListAsync();

            IQueryable<TEntity> query = _context.Set<TEntity>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetAsync(int id, params Expression<Func<TEntity, object>>[] includes)
        {
            // return await _context.Set<TEntity>().FindAsync(id);
            IQueryable<TEntity> query = _context.Set<TEntity>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.FirstOrDefaultAsync(x => x.Id == id);
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
                // _context.Set<TEntity>().Update(dbEntity);
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
