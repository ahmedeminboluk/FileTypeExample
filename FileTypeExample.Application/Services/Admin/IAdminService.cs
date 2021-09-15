using FileTypeExample.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Services
{
    public interface IAdminService
    {
        Task<IEnumerable<NewsDto>> GetAllNewsAsync();
        Task<IEnumerable<BigParaDto>> GetAllBigParaAsync();
        Task<IEnumerable<AdvDto>> GetAllAdvAsync();
        BigParaDto UpdateBigPara(BigParaDto entityDto);
        NewsDto UpdateNews(NewsDto entityDto);
        AdvDto UpdateAdv(AdvDto entityDto);
        Task<BigParaDto> GetByIdBigParaAsync(int id);
        Task<NewsDto> GetByIdNewsAsync(int id);
        Task<AdvDto> GetByIdAdvAsync(int id);
        Task<bool> AddMongoAsync(PushContent content);

    }
}
