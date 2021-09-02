using FileTypeExample.Domain.Models;
using System.Collections.Generic;

namespace FileTypeExample.Domain.Interfaces
{
    public interface IAdvRepository : IRepository<Adv>
    {
        IEnumerable<Adv> GetAdvWithSearch(string search);
        IEnumerable<Adv> GetAdvOrderAZ();
        IEnumerable<Adv> GetAdvOrderZA();
        IEnumerable<Adv> GetAdvSpAZ();
        IEnumerable<Adv> GetAdvSpZA();
    }
}
