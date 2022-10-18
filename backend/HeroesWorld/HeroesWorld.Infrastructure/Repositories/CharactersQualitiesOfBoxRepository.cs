using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.Repositories
{
    public class CharactersQualitiesOfBoxRepository : GenericRepository<CharacterQualityOfBox>, ICharactersQualitiesOfBoxRepository
    {
        public CharactersQualitiesOfBoxRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
