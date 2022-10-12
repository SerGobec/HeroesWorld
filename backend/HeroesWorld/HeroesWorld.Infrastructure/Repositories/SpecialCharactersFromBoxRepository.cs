using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Repositories
{
    public class SpecialCharactersFromBoxRepository : GenericRepository<CharacterOfBox> , ISpecialCharactersFBRepository
    {
        public SpecialCharactersFromBoxRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
