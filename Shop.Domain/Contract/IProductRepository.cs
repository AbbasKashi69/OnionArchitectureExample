

using Shop.Domain.Entities;

namespace Shop.Domain.Contract
{
    public interface IProductRepository : 
        IGenericRepository<Product>
    {
        Task<List<Product>> GetByCategoryId(int categoryId);
    }
}
