using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map the DateOfBirth property to a Date column
            modelBuilder.Entity<AppUser>()
                .Property(e => e.DateOfBirth)
                .HasColumnType("Date");
        }
    }
}