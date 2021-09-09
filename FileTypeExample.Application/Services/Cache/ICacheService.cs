using FileTypeExample.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Interfaces
{
    public interface ICacheService
    {
        T Get<T>(string key, TimeSpan cacheTime, Func<T> acquire);
    }
}
