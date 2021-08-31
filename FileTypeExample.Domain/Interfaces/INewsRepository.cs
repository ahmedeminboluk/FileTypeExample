using FileTypeExample.Domain.Models;
using System.Collections.Generic;

namespace FileTypeExample.Domain.Interfaces
{
    public interface INewsRepository : IRepository<News>
    {
        IEnumerable<News> GetNewsWithSearchAsync(string search);
    }
}
