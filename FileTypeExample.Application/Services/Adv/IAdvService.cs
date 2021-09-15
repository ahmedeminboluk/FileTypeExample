using FileTypeExample.Application.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface IAdvService
    {
        Task<IEnumerable<AdvDto>> GetAllAsync();
        IEnumerable<AdvDto> GetAll();
        IEnumerable<AdvDto> GetAllCache(int cacheTime);
        IEnumerable<AdvDto> GetAdvOrder(string order);
        IEnumerable<AdvDto> GetAdvWithSearch(string search);
        IEnumerable<AdvDto> GetAdvSpAZ();
        IEnumerable<AdvDto> GetAdvSpZA();
    }
}
