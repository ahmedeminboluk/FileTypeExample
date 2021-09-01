using FileTypeExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FileTypeExample.Domain.Interfaces
{
    public interface IBigParaRepository : IRepository<BigPara>
    {
        IEnumerable<BigPara> GetBigParaWithSearch(string search);
        IEnumerable<BigPara> GetBigParaOrderAZ();
        IEnumerable<BigPara> GetBigParaOrderZA();
    }
}
