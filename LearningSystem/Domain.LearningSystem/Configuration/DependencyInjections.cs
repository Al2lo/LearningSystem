using Microsoft.Extensions.DependencyInjection;

namespace Domain.LearningSystem.Configuration
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}
