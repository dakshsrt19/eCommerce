
using RKSoft.eShop.Domain.Entities;

namespace RKSoft.eShop.App.Interfaces
{
    public interface IStoreRepository : IAppRepository<EStore>
    {
        //Task<List<EStore>> GetAllStoresAsync_Status(EStore dbRecord);
    }
}