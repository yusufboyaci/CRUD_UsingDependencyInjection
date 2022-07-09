using CRUD_UsingDependencyInjection.Models.Entities;
using CRUD_UsingDependencyInjection.Models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CRUD_UsingDependencyInjection.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Detail> Details { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DetailMap());
            base.OnModelCreating(modelBuilder); 
        }
    }
}
