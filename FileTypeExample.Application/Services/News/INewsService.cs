using FileTypeExample.Application.Dto;
using System.Collections.Generic;

namespace FileTypeExample.Application.Interfaces
{
    public interface INewsService
    {
        IEnumerable<NewsDto> GetAll();
        IEnumerable<NewsDto> GetAllCache(int cacheTime);
        IEnumerable<NewsDto> GetNewsOrder(string order);
        IEnumerable<NewsDto> GetNewsWithSearch(string search);
        IEnumerable<NewsDto> GetNewsSpAsc();
        IEnumerable<NewsDto> GetNewsSpDesc();
    }
}
