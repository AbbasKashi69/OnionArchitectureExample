

using Mapster;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Contract;
using Shop.Application.Dto;
using Shop.Application.Dto.Category;
using Shop.Domain.Contract;
using Shop.Domain.Entities;

namespace Shop.Application.Services
{
    public class CategoryService :
        GenericService<Category, CategoryDto>,
        ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository): 
            base(categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        
      
    }
}
