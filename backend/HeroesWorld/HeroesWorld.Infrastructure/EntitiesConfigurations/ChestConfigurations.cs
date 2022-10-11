using HeroesWorld.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeroesWorld.Infrastructure.EntitiesConfigurations
{

    public class ChestConfigurations : IEntityTypeConfiguration<Chest>
    {
        public void Configure(EntityTypeBuilder<Chest> builder)
        {
            builder.Property(x => x.Id)
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 100);
            builder.HasKey(el => el.Id);
        }
    }
}
