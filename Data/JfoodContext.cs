using EFrefresher.Models;
using Microsoft.EntityFrameworkCore;

namespace EFrefresher.Data
{
    public class JfoodContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ME-CORP\SQLEXPRESS;Initial Catalog=JTables;Integrated Security=True");
        }
    }
}
