using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class NewsRepository : Repository<News>, INewsRepository
    {
        public NewsRepository(FileTypeExampleDbContext context) : base(context)
        {
        }
    }
}
