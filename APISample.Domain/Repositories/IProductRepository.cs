using APISample.Domain.Models;

namespace APISample.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetPublishedProducts();
    }
}
