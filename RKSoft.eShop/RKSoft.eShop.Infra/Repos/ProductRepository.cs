using RKSoft.eShop.App.Interfaces;
using RKSoft.eShop.Domain.Entities;
using RKSoft.eShop.Infra.Data;
using RKSoft.eShop.Infra.Repositories;

namespace RKSoft.eShop.Infra.Repos
{
    public class ProductRepository : AppRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
