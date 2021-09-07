using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IBigParaRepository _bigParaRepository;
        private readonly INewsRepository _newsRepository;
        private readonly IAdvRepository _advRepository;
        private readonly IMapper _mapper;

        public AdminService(IBigParaRepository bigParaRepository, INewsRepository newsRepository, IAdvRepository advRepository, IMapper mapper)
        {
            _bigParaRepository = bigParaRepository;
            _newsRepository = newsRepository;
            _advRepository = advRepository;
            _mapper = mapper;
        }

        public async Task<BigParaDto> GetByIdBigParaAsync(int id)
        {
            BigPara bigPara = await _bigParaRepository.GetByIdAsync(id);
            return _mapper.Map<BigParaDto>(bigPara);
        }

        public async Task<NewsDto> GetByIdNewsAsync(int id)
        {
            News news = await _newsRepository.GetByIdAsync(id);
            return _mapper.Map<NewsDto>(news);
        }

        public async Task<AdvDto> GetByIdAdvAsync(int id)
        {
            Adv adv = await _advRepository.GetByIdAsync(id);
            return _mapper.Map<AdvDto>(adv);
        }

        public async Task<IEnumerable<BigParaDto>> GetAllBigParaAsync()
        {
            List<BigPara> bigPara = await _bigParaRepository.GetAllAsync();
            return _mapper.Map<List<BigParaDto>>(bigPara);
        }

        public async Task<IEnumerable<NewsDto>> GetAllNewsAsync()
        {
            List<News> news = await _newsRepository.GetAllAsync();
            return _mapper.Map<List<NewsDto>>(news);
        }

        public async Task<IEnumerable<AdvDto>> GetAllAdvAsync()
        {
            List<Adv> adv = await _advRepository.GetAllAsync();
            return _mapper.Map<List<AdvDto>>(adv);
        }

        public BigParaDto UpdateBigPara(BigParaDto entityDto)
        {
            BigPara bigPara = _mapper.Map<BigPara>(entityDto);
            var update = _bigParaRepository.Update(bigPara);
            if(update != null)
                return entityDto;
            return null;
        }

        public NewsDto UpdateNews(NewsDto entityDto)
        {
            News news = _mapper.Map<News>(entityDto);
            var update = _newsRepository.Update(news);
            if (update != null)
                return entityDto;
            return null;
        }

        public AdvDto UpdateAdv(AdvDto entityDto)
        {
            Adv adv = _mapper.Map<Adv>(entityDto);
            var update = _advRepository.Update(adv);
            if (update != null)
                return entityDto;
            return null;
        }
    }
}
