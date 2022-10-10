using HeroesWorld.Domain.Entities;
using HeroesWorld.Infrastructure.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;
using HeroesWorld.Domain.Enums;

namespace HeroesWorld.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "sd",
                Email = "",
                Coints = 100,
                Diamonds = 10,
                Expirience = 0,
                Password = "asd",
                Role = UserRole.Admin,
                TelegramId = null
            });
        }
        public DbSet<User> Users { get; set; }
    }
}
