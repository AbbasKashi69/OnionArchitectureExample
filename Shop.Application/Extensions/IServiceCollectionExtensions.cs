

using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Contract;
using Shop.Application.Services;
using Shop.Domain.Contract;
using System.Reflection;

namespace Shop.Application.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddValidators();
            services.AddServices();
        }

        private static void AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private static void AddServices(this IServiceCollection services)
        {
            services
                .AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>))
                .AddScoped<ICategoryService, CategoryService>()
                .AddScoped<IProductService, ProductService>();
        }
    }
}
