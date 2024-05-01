using ShopApi.Core.Entities;

namespace ShopApi.Core.Interfaces
{
    public interface IProudectRepository
    {
        Task<Product?> GetProductByIdAsync(Guid id);
        Task<IEnumerable< Product>> GetProductsAsync();
    }
}
