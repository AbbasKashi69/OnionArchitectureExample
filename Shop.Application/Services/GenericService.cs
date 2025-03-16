
using Mapster;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Contract;
using Shop.Application.Dto;
using Shop.Application.Dto.Category;
using Shop.Application.Extensions;
using Shop.Domain.Common;
using Shop.Domain.Contract;
using Shop.Domain.Entities;

namespace Shop.Application.Services
{
    public class GenericService<TModel, TViewModel> : 
        IGenericService<TModel, TViewModel>
        where TModel : BaseEntity
        where TViewModel : class
    {
        public IGenericRepository<TModel> Repository { get; set; }

        public GenericService(IGenericRepository<TModel> repository)
        {
            Repository = repository;
        }

        public async Task<List<TViewModel>> GetAllAsync()
        {
            return await Repository.Entities
                .ProjectToType<TViewModel>()
                .ToListAsync();
        }
        public async Task<TViewModel?> GetByIdAsync(int id)
        {
            return await Repository.Entities
                .Where(w => w.Id == id)
                .ProjectToType<TViewModel>()
                .SingleOrDefaultAsync();
        }

        public async Task<ResultObjectDto> AddAsync(TViewModel dto)
        {
            var model = TypeAdapter.Adapt<TModel>(dto);

            var response = await Repository.AddAsync(model);
            return new ResultObjectDto
            {
                Id = response.Id,
                Success = true,
                Message = "ثبت با موفقیت انجام شد."
            };
        }

        public async Task<ResultObjectDto> UpdateAsync(TViewModel dto)
        {
            var model = TypeAdapter.Adapt<TModel>(dto);

            await Repository.UpdateAsync(model);
            return new ResultObjectDto
            {
                Success = true,
                Message = "ویرایش با موفقیت انجام شد."
            };
        }

        public async Task<ResultObjectDto> DeleteAsync(int id)
        {
            var dto = await GetByIdAsync(id);
            if(dto is null)
            {
                return new ResultObjectDto
                {
                    Success = false,
                    Message = "آیتمی یافت نشد."
                };
            }

            var model = TypeAdapter.Adapt<TModel>(dto);

            await Repository.DeleteAsync(model);
            return new ResultObjectDto
            {
                Success = true,
                Message = "حذف با موفقیت انجام شد."
            };
        }

        public async Task<PaginatedResult<TViewModel>> GetAllPaginatedAsync(int page, int pageSize)
        {
            return await Repository.Entities
                .ProjectToType<TViewModel>()
                .ToPaginatedListAsync(page, pageSize);
        }
    }
}
