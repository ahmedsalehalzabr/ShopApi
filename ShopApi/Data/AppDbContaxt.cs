using Microsoft.EntityFrameworkCore;
using ShopApi.Core.Entities;

namespace ShopApi.Data
{
    public class AppDbContaxt : DbContext
    {
        public AppDbContaxt(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductBrand> ProductBrands { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
