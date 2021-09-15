using FileTypeExample.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface INewsService
    {
        Task<IEnumerable<NewsDto>> GetAllAsync();
        IEnumerable<NewsDto> GetAll();
        IEnumerable<NewsDto> GetAllCache(int cacheTime);
        IEnumerable<NewsDto> GetNewsOrder(string order);
        IEnumerable<NewsDto> GetNewsWithSearch(string search);
        IEnumerable<NewsDto> GetNewsSpAsc();
        IEnumerable<NewsDto> GetNewsSpDesc();
    }
}
