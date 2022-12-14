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
            modelBuilder.ApplyConfiguration(new CharacterConfigurations());
            modelBuilder.ApplyConfiguration(new ChestConfigurations());
            modelBuilder.ApplyConfiguration(new ChestOportunitiesConfigurations());
            modelBuilder.ApplyConfiguration(new SpecialCharactersConfigurations());
            modelBuilder.ApplyConfiguration(new CharacterQualityOfBoxConfigurations());
            DefaultDataInitializer.InitDefaultData(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Chest> Boxes { get; set; }
        public DbSet<ChestOpportunity> ChestsOpportunities { get; set; }
        public DbSet<CharacterOfBox> SpecialCharactersOfBoxes { get; set; }
        public DbSet<CharacterQualityOfBox> CharactersQualitiesOfBox { get; set; }
    }
}
