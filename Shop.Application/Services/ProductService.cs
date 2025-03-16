

using Shop.Application.Contract;
using Shop.Application.Dto.Product;
using Shop.Domain.Contract;
using Shop.Domain.Entities;

namespace Shop.Application.Services
{
    public class ProductService : 
        GenericService<Product, ProductDto>,
        IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }


    }
}
