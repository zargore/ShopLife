using _16357367_ShopLife.Models;
using System.Data.Entity;

namespace _16357367_ShopLife.OSDB
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}