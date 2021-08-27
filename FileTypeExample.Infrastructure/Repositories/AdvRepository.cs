using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class AdvRepository : Repository<Adv>, IAdvRepository
    {
        public AdvRepository(FileTypeExampleDbContext context) : base(context)
        {
        }
    }
}
