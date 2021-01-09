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
    }
}
