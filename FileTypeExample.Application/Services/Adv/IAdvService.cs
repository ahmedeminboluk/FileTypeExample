using FileTypeExample.Application.Dto;
using System.Collections.Generic;

namespace FileTypeExample.Application.Interfaces
{
    public interface IAdvService
    {
        IEnumerable<AdvDto> GetAll();
        IEnumerable<AdvDto> GetAllCache(int cacheTime);
        IEnumerable<AdvDto> GetAdvOrder(string order);
        IEnumerable<AdvDto> GetAdvWithSearch(string search);
        IEnumerable<AdvDto> GetAdvSpAZ();
        IEnumerable<AdvDto> GetAdvSpZA();
    }
}
