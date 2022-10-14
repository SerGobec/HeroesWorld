using HeroesWorld.Application.Interfaces;
using HeroesWorld.Domain.Repositories;
using HeroesWorld.Infrastructure.Repositories;
using HeroesWorld.Infrastructure.Services;
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
            services.AddTransient<IBoxesRepository, BoxesRepository>();
            services.AddTransient<IChestOpportunitiesRepository, ChestOportunitiesRepository>();
            services.AddTransient<ISpecialCharactersFBRepository, SpecialCharactersFromBoxRepository>();
            services.AddTransient<ICharactersQualitiesOfBoxRepository, CharactersQualitiesOfBoxRepository>();

           
            services.AddTransient<ICharacterQualityForBoxChooser, CharacterQualityForBoxChooserService>();
            services.AddTransient<IOpportunityChooser, OpportunityChooserService>();
            services.AddTransient<ICharacterByQualityFromBoxChooser, CharacterByQualityFromBoxChooser>();
            services.AddTransient<IBoxOpener, BoxOpenerService>();
            services.AddTransient<ISpecialCharacterChooser, SpecialCharacterChooser>();

        }
    }
}
