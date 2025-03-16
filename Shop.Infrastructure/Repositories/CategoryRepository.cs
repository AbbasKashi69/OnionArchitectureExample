

using Shop.Domain.Contract;
using Shop.Domain.Entities;
using Shop.Infrastructure.Contexts;

namespace Shop.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
