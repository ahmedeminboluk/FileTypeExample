using FileTypeExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FileTypeExample.Domain.Interfaces
{
    public interface IBigParaRepository : IRepository<BigPara>
    {
        IEnumerable<BigPara> GetBigParaWithSearchAsync(string search);
    }
}
