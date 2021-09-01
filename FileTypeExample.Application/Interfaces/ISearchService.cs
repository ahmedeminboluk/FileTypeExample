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
        IEnumerable<BigParaDto> GetBigParaWithSearch(string search);
        IEnumerable<AdvDto> GetAdvWithSearch(string search);
        IEnumerable<NewsDto> GetNewsWithSearch(string search);
    }
}
