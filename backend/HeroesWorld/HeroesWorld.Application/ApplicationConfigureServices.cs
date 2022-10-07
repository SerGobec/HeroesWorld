using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HeroesWorld.Application
{
    public static class ApplicationConfigureServices
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
