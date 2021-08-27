using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface IDatabaseService
    {
        public Task<IEnumerable<T>> GetAllAsync<T>(string key);
    }
}
