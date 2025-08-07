using RKSoft.eShop.Domain.Entities;
using System.Linq.Expressions;

namespace RKSoft.eShop.App.Interfaces
{
    public interface IProductService
    {
        Task<Product> CreateProductAsync(Product dbRecord);
        Task<bool> DeleteProductAsync(Product dbRecord);
        Task<List<Product>> GetAllProductAsync();
        Task<Product> GetProductByIdAsync(Expression<Func<Product, bool>> filter, bool useNoTracking = false);
        Task<Product> GetProductByNameAsync(Expression<Func<Product, bool>> filter);
        Task<Product> UpdateProductAsync(Product dbRecord);
    }
}
