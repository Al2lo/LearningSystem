
using Domain.LearningSystem.Data.Repositories.Interfaces;
using Domain.LearningSystem.Entities;
using System.Data.Entity;

namespace Infrastructure.LearningSystem.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        { }

        
    }
}
