using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }
        public DbSet<VmtCounty> VmtCounties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VmtCounty>(
                eb =>
                {
                    eb.HasNoKey();
                });
        }
    }
}
