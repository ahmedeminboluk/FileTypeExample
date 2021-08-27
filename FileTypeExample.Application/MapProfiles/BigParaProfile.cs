using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Domain.Models;

namespace FileTypeExample.Application.MapProfiles
{
    public class BigParaProfile : Profile
    {
        public BigParaProfile()
        {
            CreateMap<BigPara, BigParaDto>().ReverseMap();
        }
    }
}
