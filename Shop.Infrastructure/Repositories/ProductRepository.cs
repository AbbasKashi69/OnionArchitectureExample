

using Microsoft.EntityFrameworkCore;
using Shop.Domain.Contract;
using Shop.Domain.Entities;
using Shop.Infrastructure.Contexts;

namespace Shop.Infrastructure.Repositories
{
    public class ProductRepository : 
        GenericRepository<Product>,
        IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task<List<Product>> GetByCategoryId(int categoryId)
        {
            return Entities.Where(w=> w.CategoryId == categoryId).ToListAsync();
        }
    }
}
