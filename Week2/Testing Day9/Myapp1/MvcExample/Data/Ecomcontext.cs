using Microsoft.EntityFrameworkCore;
using MvcExample.Models;

namespace MvcExample.Data
{
    public class Ecomcontext : DbContext
    {
        public Ecomcontext(DbContextOptions<Ecomcontext> options)
              : base(options)
        {
        }


        public DbSet<Catagory> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }

   
}

