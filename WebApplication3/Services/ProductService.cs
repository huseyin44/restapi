using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication3.Domain.Models;
using WebApplication3.Domain.Services;
using WebApplication3.Domain.Repositories;
namespace WebApplication3.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}