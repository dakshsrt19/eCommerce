using RKSoft.eShop.App.Interfaces;
using RKSoft.eShop.Domain.Entities;
using System.Linq.Expressions;

namespace RKSoft.eShop.App.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> CreateProductAsync(Product dbRecord)
        {
            return await _productRepository.CreateAsync(dbRecord);
        }

        public async Task<bool> DeleteProductAsync(Product dbRecord)
        {
            return await _productRepository.DeleteAsync(dbRecord);
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _productRepository.GetAllAsync();
        }


        public async Task<Product> GetProductByIdAsync(Expression<Func<Product, bool>> filter, bool useNoTracking = false)
        {
            return await _productRepository.GetByIdAsync(filter, useNoTracking);
        }

        public async Task<Product> GetProductByNameAsync(Expression<Func<Product, bool>> filter)
        {
            return await _productRepository.GetByNameAsync(filter);
        }
        public async Task<Product> UpdateProductAsync(Product dbRecord)
        {
            return await _productRepository.UpdateAsync(dbRecord);
        }
    }
}
