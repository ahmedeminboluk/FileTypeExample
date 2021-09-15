using AutoMapper;
using FileTypeExample.API.Models;
using FileTypeExample.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.API.Configuration
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<PushContent, PushContentViewModel>().ReverseMap();
        }
    }
}
