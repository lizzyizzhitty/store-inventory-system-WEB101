using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store
{
    public class WebSystemContext
    {
        public WebSystemContext(DbContextOptions<WebSystemContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("customer");
        modelBuilder.Entity<Order>().ToTable("order");
        modelBuilder.Entity<Product>().ToTable("product");
        modelBuilder.Entity<User>().ToTable("user");
    }
    }
}