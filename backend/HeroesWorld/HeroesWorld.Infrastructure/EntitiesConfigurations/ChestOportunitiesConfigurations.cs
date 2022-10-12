using HeroesWorld.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeroesWorld.Infrastructure.EntitiesConfigurations
{
    public class ChestOportunitiesConfigurations : IEntityTypeConfiguration<ChestOpportunity>
    {
        public void Configure(EntityTypeBuilder<ChestOpportunity> builder)
        {
            builder.Property(x => x.Id)
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 100);
            builder.HasKey(el => el.Id);
        }
    }
}
