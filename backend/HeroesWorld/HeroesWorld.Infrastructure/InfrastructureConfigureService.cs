using HeroesWorld.Domain.Repositories;
using HeroesWorld.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HeroesWorld.Infrastructure
{
    public static class InfrastructureConfigureService
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICharacterRepository, CharacterRepository>();
        }
    }
}
