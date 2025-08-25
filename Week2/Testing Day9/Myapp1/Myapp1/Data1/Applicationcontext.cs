using Microsoft.EntityFrameworkCore;
using Myapp1.Model;

namespace Myapp1.Data1
{
    public class Applicationcontext:DbContext
    {
      public Applicationcontext(DbContextOptions<Applicationcontext> options)
            : base(options)
        {
        }

  
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
    
}
