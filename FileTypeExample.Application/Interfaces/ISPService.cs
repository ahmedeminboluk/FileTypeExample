using FileTypeExample.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface ISPService
    {
        IEnumerable<BigParaDto> GetBigParaSpAZ();
        IEnumerable<BigParaDto> GetBigParaSpZA();
        IEnumerable<AdvDto> GetAdvSpAZ();
        IEnumerable<AdvDto> GetAdvSpZA();
        IEnumerable<NewsDto> GetNewsSpAsc();
        IEnumerable<NewsDto> GetNewsSpDesc();
    }
}
