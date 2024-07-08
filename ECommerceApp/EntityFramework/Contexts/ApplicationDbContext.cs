using ECommerceApp.Entities;
using ECommerceApp.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ECommerceApp.EntityFramework.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=185.223.77.214;Port=5433;Database=ECommerceAppOzdemir;User Id=postgres;Password=TYuTkGlncrpMgCokpuibnodnEpNUATK2ACNfGDqwgWZRZBMJEx6KpklXY63YIYie;");
           
            base.OnConfiguring(optionsBuilder);
        }
    }
}
