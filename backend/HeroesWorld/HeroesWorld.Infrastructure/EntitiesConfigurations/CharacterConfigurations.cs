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
    public class CharacterConfigurations : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasKey(el => el.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
