

using Microsoft.AspNetCore.Mvc;
using Shop.Application.Contract;
using Shop.Application.Dto;
using Shop.Application.Dto.Category;
using Shop.Domain.Contract;

namespace Shop.Presentation.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<List<CategoryDto>> GetAll()
            => await _categoryService.GetAllAsync();

        [HttpGet]
        public async Task<PaginatedResult<CategoryDto>> GetPagination(int page, int pageSize)
            => await _categoryService.GetAllPaginatedAsync(page, pageSize);

        [HttpGet]
        public async Task<CategoryDto?> GetById(int id)
            => await _categoryService.GetByIdAsync(id);

        [HttpPost]
        public async Task<ResultObjectDto> Create(CategoryDto categoryDto)
            => await _categoryService.AddAsync(categoryDto);

        [HttpPut]
        public async Task<ResultObjectDto> Update(CategoryDto categoryDto)
            => await _categoryService.UpdateAsync(categoryDto);

        [HttpDelete("{id:int}")]
        public async Task<ResultObjectDto> Delete(int id)
            => await _categoryService.DeleteAsync(id);
    }
}
