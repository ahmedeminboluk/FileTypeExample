using FileTypeExample.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.API.Repository
{
    public interface IRepository<T> where T : IDocument
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T document);
    }
}
