using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IBigParaRepository _bigParaRepository;
        private readonly INewsRepository _newsRepository;
        private readonly IAdvRepository _advRepository;
        private readonly IMapper _mapper;

        public DatabaseService(IBigParaRepository bigParaRepository, INewsRepository newsRepository, IAdvRepository advRepository, IMapper mapper)
        {
            _bigParaRepository = bigParaRepository;
            _newsRepository = newsRepository;
            _advRepository = advRepository;
            _mapper = mapper;

        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(string key)
        {
            if (key == "bigpara")
            {
                List<BigPara> bigPara = await _bigParaRepository.GetAllAsync();
                List<BigParaDto> big = _mapper.Map<List<BigParaDto>>(bigPara);
                return (IEnumerable<T>)big;
            }
            if (key == "news")
            {
                List<News> news = await _newsRepository.GetAllAsync();
                List<NewsDto> newsDto = _mapper.Map<List<NewsDto>>(news);
                return (IEnumerable<T>)newsDto;
            }
            if (key == "adv")
            {
                List<Adv> adv = await _advRepository.GetAllAsync();
                List<AdvDto> advDto = _mapper.Map<List<AdvDto>>(adv);
                return (IEnumerable<T>)advDto;
            }
            return null;
        }
    }
}
