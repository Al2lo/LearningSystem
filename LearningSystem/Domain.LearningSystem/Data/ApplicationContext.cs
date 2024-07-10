using Domain.LearningSystem.Configurations;
using Domain.LearningSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.LearningSystem.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguratioin).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
