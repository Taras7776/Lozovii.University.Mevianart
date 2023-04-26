using Microsoft.EntityFrameworkCore;
using Lozovii.University.Mevianart.Models;

namespace Lozovii.University.Mevianart.Database
{
    public class MevianartDbContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public MevianartDbContext() { }

        public MevianartDbContext(DbContextOptions<MevianartDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
            options.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        
        }
    }
}