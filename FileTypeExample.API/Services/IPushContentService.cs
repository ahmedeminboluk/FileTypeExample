using FileTypeExample.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.API.Services
{
    public interface IPushContentService
    {
        Task<PushContentViewModel> GetByIdAsync(string id);
        Task<IEnumerable<PushContentViewModel>> GetAllAsync();
        Task AddAsync(PushContentViewModel pushContentVM);
    }
}
