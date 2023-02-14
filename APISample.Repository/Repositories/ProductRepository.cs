using APISample.Domain.Models;
using APISample.Domain.Repositories;

namespace APISample.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Keyboard", Cost = 30, Price = 50, Stock = 3, IsPublished = true },
                new Product { Id = Guid.NewGuid(), Name = "Mouse", Cost = 15, Price = 30, Stock = 5, IsPublished = true },
                new Product { Id = Guid.NewGuid(), Name = "Monitor", Cost = 80, Price = 160, Stock = 0, IsPublished = true },
            };
        }

        public async Task<List<Product>> GetPublishedProducts()
        {
            return await Task.Run(() => products.Where(p => p.IsPublished).ToList());
        }
    }
}
