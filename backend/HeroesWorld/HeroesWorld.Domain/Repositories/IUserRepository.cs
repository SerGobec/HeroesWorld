using HeroesWorld.Domain.Entities;

namespace HeroesWorld.Domain.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void Add(User user);
    }
}
