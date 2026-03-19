using Microsoft.EntityFrameworkCore;
using Prakt12.Models;

namespace Prakt12.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<InterestGroup> InterestGroups { get; set; }
        public DbSet<UserInterestGroup> UserInterestGroups { get; set; }

        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
            ("Server=(localdb)\\MSSQLLocalDB;Database=prakt12;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.userProfile)
                .WithOne(up => up.user)
                .HasForeignKey<UserProfile>(up => up.UserId);

            modelBuilder.Entity<Role>()
                .HasMany(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId);

            modelBuilder.Entity<UserInterestGroup>()
                .HasKey(uig => new { uig.UserId, uig.InterestGroupId });

            modelBuilder.Entity<UserInterestGroup>()
                .HasOne(uig => uig.User)
                .WithMany(uig => uig.UserInterestGroups)
                .HasForeignKey(uig => uig.UserId);

            modelBuilder.Entity<UserInterestGroup>()
                .HasOne(uig => uig.InterestGroup)
                .WithMany(uig => uig.UserInterestGroups)
                .HasForeignKey(uig => uig.InterestGroupId);

        }
    }
}
