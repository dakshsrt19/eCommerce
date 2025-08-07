using RKSoft.eShop.App.Interfaces;
using RKSoft.eShop.App.Services;
using RKSoft.eShop.Infra.Repos;

namespace RKSoft.eShop.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // Register Repositories
            services.AddScoped<IStoreRepository, StoreRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            // Register Services
            services.AddScoped<IStoreService, StoreService>();
            services.AddScoped<IProductService, ProductService>();
             
            return services;
        }
    }
}
