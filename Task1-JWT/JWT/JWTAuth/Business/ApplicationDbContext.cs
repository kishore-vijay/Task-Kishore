using JWTAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.Business
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserName);
        }
    }


        
}
