using HeroesWorld.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HeroesWorld.Infrastructure.EntitiesConfigurations
{
    public class SpecialCharactersConfigurations : IEntityTypeConfiguration<CharacterOfBox>
    {
        public void Configure(EntityTypeBuilder<CharacterOfBox> builder)
        {
            builder.Property(x => x.Id)
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 100);
            builder.HasKey(el => el.Id);
        }
    }
}
