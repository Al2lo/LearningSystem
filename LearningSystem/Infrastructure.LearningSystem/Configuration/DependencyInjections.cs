using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.LearningSystem.Configuration
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services;
        }
    }
}
