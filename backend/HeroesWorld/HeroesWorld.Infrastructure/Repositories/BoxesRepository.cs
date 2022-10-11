using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Repositories
{
    public class BoxesRepository : GenericRepository<Chest>, IBoxesRepository
    {
        public BoxesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
