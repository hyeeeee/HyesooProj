using HyesooProj.Infrastructure.Ef.Configurations;
using HyesooProj.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HyesooProj.Infrastructure.Ef
{
    public class HyesooProjDbContext : DbContext
    {
        public HyesooProjDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FootPrint> FootPrints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FootPrintConfiguration());
            modelBuilder.ApplyConfiguration(new CoffeeTimeConfigration());
        }
    }
}
