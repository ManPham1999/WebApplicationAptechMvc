using System;
using AptechMVCProject.Entity;
using Microsoft.EntityFrameworkCore;

namespace AptechMVCProject
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catgory> Catgories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartType> CartTypes { get; set; }
        public DbSet<CartDetails> Detailses { get; set; }
        public DbSet<ProductListInCart> ProductListInCarts { get; set; }
        
    }
}
