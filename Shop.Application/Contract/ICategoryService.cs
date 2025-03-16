

using Shop.Application.Dto.Category;
using Shop.Domain.Entities;

namespace Shop.Application.Contract
{
    public interface ICategoryService :
        IGenericService<Category, CategoryDto>
    {
    }
}
