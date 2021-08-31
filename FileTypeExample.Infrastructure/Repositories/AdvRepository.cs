using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class AdvRepository : Repository<Adv>, IAdvRepository
    {
        public AdvRepository(FileTypeExampleDbContext context) : base(context)
        {
        }

        public IEnumerable<Adv> GetAdvWithSearchAsync(string search)
        {
            return _context.Advertorial.Where(x => x.CityName.Contains(search));
        }
    }
}
