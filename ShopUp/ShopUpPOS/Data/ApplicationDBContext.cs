using Microsoft.EntityFrameworkCore;
using ShopUpPOS.Models;

namespace ShopUpPOS.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users {Id = 1 , Name = "Jake", Status = "Admin"},
                new Users { Id = 2, Name = "Susan", Status = "Cashier" }
                );
        }
    }
}
