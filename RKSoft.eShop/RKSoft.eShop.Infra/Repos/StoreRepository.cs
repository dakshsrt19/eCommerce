using RKSoft.eShop.App.Interfaces;
using RKSoft.eShop.Domain.Entities;
using RKSoft.eShop.Infra.Data;
using RKSoft.eShop.Infra.Repositories;

namespace RKSoft.eShop.Infra.Repos
{
    public class StoreRepository : AppRepository<EStore>, IStoreRepository
    {
        private readonly AppDbContext _appDbContext;
        public StoreRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public async Task<List<EStore>> GetAllStoresAsync_Status(string status)
        //{
        //    return await _appDbContext.Stores.AsNoTracking().Where(store => store.Status == status).ToListAsync();
        //}
    }
}
