using Microsoft.Extensions.DependencyInjection;

namespace Application.LearningSystem.Configuration
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }
    }
}
