using HeroesWorld.Domain.Entities;
using HeroesWorld.Domain.Repositories;

namespace HeroesWorld.Infrastructure.Repositories
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        { 
        }
    }
}
