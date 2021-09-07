using FileTypeExample.Application.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IDatabaseService _databaseService;
        public TimeSpan CacheDuration => TimeSpan.FromSeconds(13);

        public CacheService(IMemoryCache memoryCache, IDatabaseService databaseService)
        {
            _memoryCache = memoryCache;
            _databaseService = databaseService;
        }

        public async Task<IEnumerable<T>> GetAsync<T>(string key)
        {
            if (!_memoryCache.TryGetValue(key, out List<T> fileDto))
            {
                var cacheOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(10),
                    Priority = CacheItemPriority.Normal
                };
                IEnumerable<T> file = await _databaseService.GetAllAsync<T>(key);
                _memoryCache.Set(key, file, cacheOptions);
            }
            _memoryCache.TryGetValue(key, out List<T> fileDtoo);
            return fileDtoo;
        }

        public T Get<T>(string key, TimeSpan cacheTime, Func<T> acquire)
        {
            if (!_memoryCache.TryGetValue(key, out T result))
            {
                result = acquire();
                if (!object.Equals(result, null) && cacheTime.TotalSeconds > 0)
                {
                    Set(key, result, cacheTime);
                }
            }
            return result;
        }

        public void Set<T>(string key, T value, TimeSpan cacheTime)
        {
            if (!object.Equals(value, null) && cacheTime.TotalSeconds > 0)
            {
                _memoryCache.Set(key, value, DateTimeOffset.Now.AddSeconds(cacheTime.TotalSeconds));
            }
        }

    }
}
