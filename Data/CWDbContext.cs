using Microsoft.EntityFrameworkCore;
using LTEHApps.Models; // Add this using directive
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LTEHApps.Data
{
    public class CWDbContext : DbContext
    {
        public CWDbContext(DbContextOptions<CWDbContext> options) : base(options)
        {
            
        }

        // DbSet properties for your database tables
        // For example, if you have a "Conflict" table, add it like this:
        public DbSet<Conflict> Conflicts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the "Conflicts" entity (table)
            modelBuilder.Entity<Conflict>()
                .HasKey("SerialNo");
                

            // You can add more entity configurations here if needed

            base.OnModelCreating(modelBuilder);
        }
    }
}
