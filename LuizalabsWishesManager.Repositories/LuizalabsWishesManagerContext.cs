using LuizalabsWishesManager.Domains.Models;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<WishProduct> WishProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {                
                entity.HasKey(p => p.IdProduct);
            });

            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .Property(p => p.IdProduct)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Wish>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
