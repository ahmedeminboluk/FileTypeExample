using FileTypeExample.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface IBigParaService
    {
        Task<IEnumerable<BigParaDto>> GetAllAsync();
        IEnumerable<BigParaDto> GetAll();
        IEnumerable<BigParaDto> GetAllCache(int cacheTime);
        IEnumerable<BigParaDto> GetBigParaOrder(string order);
        IEnumerable<BigParaDto> GetBigParaWithSearch(string search);
        IEnumerable<BigParaDto> GetBigParaSpAZ();
        IEnumerable<BigParaDto> GetBigParaSpZA();
    }
}
