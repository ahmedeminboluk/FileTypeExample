using FileTypeExample.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<BigParaDto> GetBigParaOrder(string order);
        IEnumerable<AdvDto> GetAdvOrder(string order);
        IEnumerable<NewsDto> GetNewsOrder(string order);
    }
}
