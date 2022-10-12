using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Repositories
{
    public class ChestOportunitiesRepository : GenericRepository<ChestOpportunity> , IChestOpportunitiesRepository
    {
        public ChestOportunitiesRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
