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
    }
}
