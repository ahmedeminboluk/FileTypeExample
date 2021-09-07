using FileTypeExample.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface IBigParaService
    {
        IEnumerable<BigParaDto> GetAllAsync(int cacheTime);
    }
}
