
using Shop.Application.Dto.Product;
using Shop.Domain.Entities;

namespace Shop.Application.Contract
{
    public interface IProductService : IGenericService<Product, ProductDto>
    {
    }
}
