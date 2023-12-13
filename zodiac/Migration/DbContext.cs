using Microsoft.EntityFrameworkCore;
using zodiac.Models;
namespace zodiac.Migration
{
    public class ZodiacContext : DbContext
    {
        public ZodiacContext(DbContextOptions<ZodiacContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasIndex(user => user.Email).IsUnique();
            modelBuilder.Entity<UserModel>().HasIndex(user => user.Username).IsUnique();
        }
    }
}
