using Microsoft.EntityFrameworkCore;
using Module;

namespace EcomRepository
{
    public class  EcomContext:DbContext
    {
        public EcomContext(DbContextOptions<EcomContext> options)
              : base(options)
        {
        }


        public DbSet<Customer> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Cart { get; set; }
        public DbSet<Product> Order { get; set; }
        public DbSet<Product> Order_Item { get; set; }
    }
}
