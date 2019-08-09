using LuizalabsWishesManager.Domains.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LuizalabsWishesManager.Data
{
    public class LuizalabsWishesManagerContext : DbContext
    {
        public LuizalabsWishesManagerContext() {}

        public LuizalabsWishesManagerContext(DbContextOptions<LuizalabsWishesManagerContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Wish> Wishs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }
    }
}
