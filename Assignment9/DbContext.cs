using Microsoft.EntityFrameworkCore;
using OrderApp.Models;
using OrderApp;
using System.Collections.Generic;

namespace OrderApp.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Products> Products{ get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}