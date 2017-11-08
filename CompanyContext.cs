using System;
using Microsoft.EntityFrameworkCore;

namespace Labo6_BDD
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers{get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Labo6");
        }
    }
}
