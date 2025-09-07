

namespace Qutell.ThreeSixty.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity, TKey> Repository<TEntity, TKey>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }


}
