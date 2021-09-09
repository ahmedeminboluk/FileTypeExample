using FileTypeExample.Application.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace FileTypeExample.Application.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;
        public TimeSpan CacheDuration => TimeSpan.FromSeconds(13);

        public CacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
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
