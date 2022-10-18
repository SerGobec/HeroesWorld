using HeroesWorld.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.EntitiesConfigurations
{
    public class CharacterQualityOfBoxConfigurations : IEntityTypeConfiguration<CharacterQualityOfBox>
    {
        public void Configure(EntityTypeBuilder<CharacterQualityOfBox> builder)
        {
            builder.HasKey(el => el.Id);
            builder.Property(x => x.Id)
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 100);
            
        }
    }
}
