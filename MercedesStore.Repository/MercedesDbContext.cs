using MercedesStore.Entities.Models;
using MercedesStore.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace MercedesStore.Repository
{
    public class MercedesDbContext: DbContext
    {
        public MercedesDbContext(DbContextOptions options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AutoConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
