using Domain.LearningSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.LearningSystem.Configuration
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDomain(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            return services;
        }
    }
}
