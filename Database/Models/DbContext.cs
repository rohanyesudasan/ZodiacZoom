using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class ZodiacContext : DbContext
    {
        public ZodiacContext(DbContextOptions<ZodiacContext> options) : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<Zodiac> Zodiacs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasIndex(user => user.Email).IsUnique();
            modelBuilder.Entity<UserModel>().HasIndex(user => user.Username).IsUnique();
        }
    }
}
