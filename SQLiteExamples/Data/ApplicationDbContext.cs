using Microsoft.EntityFrameworkCore;
using SQLiteExamples.Entities;

namespace SQLiteExamples.Data;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite("Data Source=shopping.db");
        }
    }
