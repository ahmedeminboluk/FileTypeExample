using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Domain.Models;

namespace FileTypeExample.Application.MapProfiles
{
    public class NewsProfile : Profile
    {
        public NewsProfile()
        {
            CreateMap<News, NewsDto>().ReverseMap();
        }
    }
}
