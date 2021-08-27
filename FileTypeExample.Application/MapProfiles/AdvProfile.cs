using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Domain.Models;

namespace FileTypeExample.Application.MapProfiles
{
    public class AdvProfile : Profile
    {
        public AdvProfile()
        {
            CreateMap<Adv, AdvDto>().ReverseMap();
        }
    }
}
