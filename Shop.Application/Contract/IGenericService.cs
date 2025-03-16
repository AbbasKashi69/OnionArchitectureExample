

using Shop.Application.Dto;
using Shop.Domain.Common;
using Shop.Domain.Contract;
using System.Linq.Expressions;

namespace Shop.Application.Contract
{
    public interface IGenericService<TModel, TViewModel> 
        where TModel : BaseEntity
        where TViewModel : class
    {
        IGenericRepository<TModel> Repository { get; set; }
        
        Task<List<TViewModel>> GetAllAsync();
        Task<PaginatedResult<TViewModel>> GetAllPaginatedAsync(int page, int pageSize);
        Task<TViewModel?> GetByIdAsync(int id);

        Task<ResultObjectDto> AddAsync(TViewModel dto);
        Task<ResultObjectDto> UpdateAsync(TViewModel dto);
        Task<ResultObjectDto> DeleteAsync(int id);

    }
}
