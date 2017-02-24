using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Context
{
    public class InventoryManagementSystem_DBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purcheses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Sub_Category> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}