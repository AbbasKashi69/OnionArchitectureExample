

using Microsoft.Extensions.DependencyInjection;
using Shop.Domain.Contract;
using Shop.Infrastructure.Repositories;

namespace Shop.Infrastructure.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddRepository();
        }

        private static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddScoped<ICategoryRepository, CategoryRepository>()
                .AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
