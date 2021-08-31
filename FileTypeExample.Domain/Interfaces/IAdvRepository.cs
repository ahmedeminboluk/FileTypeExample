using FileTypeExample.Domain.Models;
using System.Collections.Generic;

namespace FileTypeExample.Domain.Interfaces
{
    public interface IAdvRepository : IRepository<Adv>
    {
        IEnumerable<Adv> GetAdvWithSearchAsync(string search);
    }
}
