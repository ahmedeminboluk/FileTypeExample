using FileTypeExample.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface ISearchService
    {
        IEnumerable<BigParaDto> GetBigParaWithSearchAsync(string search);
        IEnumerable<AdvDto> GetAdvWithSearchAsync(string search);
        IEnumerable<NewsDto> GetNewsWithSearchAsync(string search);
    }
}
