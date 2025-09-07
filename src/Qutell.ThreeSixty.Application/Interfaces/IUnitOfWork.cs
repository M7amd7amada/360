using Qutell.ThreeSixty.Infrastructure.Repositories;

namespace Qutell.ThreeSixty.Infrastructure.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity, TKey> Repository<TEntity, TKey>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }


}
