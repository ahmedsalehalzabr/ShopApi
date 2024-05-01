using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ShopApi.Core.Entities;
using ShopApi.Core.Interfaces;
using ShopApi.Data;

namespace ShopApi.Core.Impelemantation
{
    public class ProductRepository : IProudectRepository
    {
        private readonly AppDbContaxt db;

        public ProductRepository(AppDbContaxt db)
        {
            this.db = db;
        }
        public async Task<Product?> GetProductByIdAsync(Guid id)
        {
           return await db.Products.FirstOrDefaultAsync(p => p.Id == id);

            
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await db.Products.ToListAsync();
        }
    }
}
