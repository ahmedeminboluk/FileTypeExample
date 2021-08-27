using FileTypeExample.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface IBigParaService
    {
        Task<List<BigParaDto>> GetAllAsync();
    }
}
