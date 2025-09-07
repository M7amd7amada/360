namespace Qutell.ThreeSixty.Application.Services
{
    public interface ILookupCacheService <TEntity,TKey > where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TKey id);
    }
}
