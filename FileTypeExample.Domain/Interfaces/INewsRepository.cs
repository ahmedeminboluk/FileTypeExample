using FileTypeExample.Domain.Models;
using System.Collections.Generic;

namespace FileTypeExample.Domain.Interfaces
{
    public interface INewsRepository : IRepository<News>
    {
        IEnumerable<News> GetNewsWithSearch(string search);
        IEnumerable<News> GetNewsOrderAsc();
        IEnumerable<News> GetNewsOrderDesc();
        IEnumerable<News> GetNewsSPAsc();
        IEnumerable<News> GetNewsSPDesc();
    }
}
