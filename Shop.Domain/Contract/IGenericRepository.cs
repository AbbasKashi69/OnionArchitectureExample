

using Microsoft.EntityFrameworkCore;
using Shop.Domain.Common.Interfaces;

namespace Shop.Domain.Contract
{
    public interface IGenericRepository<T> where T : class, IEntity
    {
        DbSet<T> Entities { get; }

        Task<T?> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync();

        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
