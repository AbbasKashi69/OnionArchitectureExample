

using Microsoft.AspNetCore.Mvc;
using Shop.Application.Contract;
using Shop.Application.Dto;
using Shop.Application.Dto.Product;

namespace Shop.Presentation.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<List<ProductDto>> GetAll()
            => await _productService.GetAllAsync();

        [HttpGet]
        public async Task<PaginatedResult<ProductDto>> GetPagination(int page, int pageSize)
            => await _productService.GetAllPaginatedAsync(page, pageSize);

        [HttpGet]
        public async Task<ProductDto?> GetById(int id)
            => await _productService.GetByIdAsync(id);

        [HttpPost]
        public async Task<ResultObjectDto> Create(ProductDto productDto)
            => await _productService.AddAsync(productDto);

        [HttpPut]
        public async Task<ResultObjectDto> Update(ProductDto productDto)
            => await _productService.UpdateAsync(productDto);

        [HttpDelete("{id:int}")]
        public async Task<ResultObjectDto> Delete(int id)
            => await _productService.DeleteAsync(id);
    }
}
