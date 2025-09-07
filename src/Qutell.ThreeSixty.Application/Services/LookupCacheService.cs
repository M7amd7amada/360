using Microsoft.Extensions.Caching.Memory;
using Qutell.ThreeSixty.Application.Interfaces;


namespace Qutell.ThreeSixty.Application.Services
{

    public class LookupCacheService<TEntity, TKey> : ILookupCacheService<TEntity, TKey> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<TEntity, TKey> _repository;
        private readonly IMemoryCache _cache;
        private readonly String _cacheKey;
        public LookupCacheService(IUnitOfWork unitOfWork, IMemoryCache memoryCache)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.Repository<TEntity, TKey>();
            _cache = memoryCache;
            _cacheKey = $"Lookup : {typeof(TEntity).Name} ";
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            if (_cache.TryGetValue(_cacheKey, out IEnumerable<TEntity> cachedData))
            {
                return cachedData;
            }
            var options = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromMinutes(30))
                .SetSlidingExpiration(TimeSpan.FromHours(1))
                .SetPriority(CacheItemPriority.Normal);

            var data = await _repository.GetAllAsync();
            _cache.Set(_cacheKey, data, options);
            return data;
        }
        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            _cache.Remove(_cacheKey);
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _repository.Update(entity);
            await _unitOfWork.SaveChangesAsync();
            _cache.Remove(_cacheKey);
        }
        public async Task DeleteAsync(TKey id)
        {
            _repository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            _cache.Remove(_cacheKey);
        }





      
    }
}
