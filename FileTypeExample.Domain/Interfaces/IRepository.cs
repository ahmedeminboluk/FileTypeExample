using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
    }
}
