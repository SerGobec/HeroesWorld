using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesWorld.Infrastructure.Repositories
{
    internal class CharacterRepository : GenericRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
