using FilmKatalogusAPI.Models;

namespace FilmKatalogusAPI.Repositories
{
    public interface IGenericRepository<T> where T : IEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
