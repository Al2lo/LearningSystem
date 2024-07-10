using Domain.LearningSystem.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.LearningSystem.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _table;
        private System.Data.Entity.DbContext dbContext;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _table = this._context.Set<T>();
        }

        public BaseRepository(System.Data.Entity.DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var item =  await _table.FindAsync(id);
            if (item == null)
                throw new Exception("Element not found");
            return item;
        }

        public async Task UpdateAsync(T entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
