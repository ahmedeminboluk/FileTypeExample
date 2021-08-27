using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using FileTypeExample.Infrastructure.Context;

namespace FileTypeExample.Infrastructure.Repositories
{
    public class BigParaRepository : Repository<BigPara>, IBigParaRepository
    {
        public BigParaRepository(FileTypeExampleDbContext context) : base(context)
        {
        }
    }
}
