using Microsoft.EntityFrameworkCore;
using Qutell.ThreeSixty.Application.Interfaces;
using Qutell.ThreeSixty.Infrastructure.Data;

namespace Qutell.ThreeSixty.Infrastructure.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
            => await _dbSet.AsNoTracking().ToListAsync();

        public async Task<TEntity> GetByIdAsync(TKey id)
            => await _dbSet.FindAsync(id);

        public async Task AddAsync(TEntity entity)
            => await _dbSet.AddAsync(entity);

        public void Update(TEntity entity)
            => _dbSet.Update(entity);

        public async Task Delete(TKey id)
        {

            var entity = await _dbSet.FindAsync(id);
            var property = typeof(TEntity).GetProperty("IsDeleted");
            if (entity! == null && property != null)
            {
                property.SetValue(entity, true);
                _dbSet.Update(entity);
            }
            else
            {
                _dbSet.Remove(entity);
            }

        }

    }
}
