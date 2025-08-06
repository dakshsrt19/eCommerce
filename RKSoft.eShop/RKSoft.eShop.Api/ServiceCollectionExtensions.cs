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

            // Register Services
            services.AddScoped<IStoreService, StoreService>();

            return services;
        }
    }
}
