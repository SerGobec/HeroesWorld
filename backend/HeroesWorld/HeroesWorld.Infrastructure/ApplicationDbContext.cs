using HeroesWorld.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroesWorld.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "sd",
                Coints = 100,
                Diamonds = 10,
                Expirience = 0,
                Password = "asd",
                Role = Domain.Enums.UserRole.Player,
                TelegramId = null
            });
        }

        public DbSet<User> Users { get; set; }
    }
}
