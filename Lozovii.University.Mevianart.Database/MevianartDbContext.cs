﻿using Microsoft.EntityFrameworkCore;
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
            options.UseSqlServer("Server=tcp:mevianart-db-server.database.windows.net,1433;Initial Catalog=mevianart-db;Persist Security Info=False;User ID=sqladmin;Password=Treqwe16;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        
        }
    }
}