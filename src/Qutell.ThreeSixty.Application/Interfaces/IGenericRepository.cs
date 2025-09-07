namespace Qutell.ThreeSixty.Application.Interfaces
{
    public interface IGenericRepository<TEntity,TKey> where TEntity : class
    {

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        Task Delete(TKey id);

    }
   
}
