using FilmKatalogusAPI.Models;
using System.Linq.Expressions;

namespace FilmKatalogusAPI.Repositories
{
    public interface IGenericRepository<T> where T : IEntity
    {
        Task<List<T>> GetAllAsync(params Expression<Func<T, object>>[] includes);
        Task<T?> GetAsync(int id, params Expression<Func<T, object>>[] includes);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
