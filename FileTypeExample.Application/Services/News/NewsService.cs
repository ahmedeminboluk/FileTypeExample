using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly ICacheService _cacheService;
        private readonly IMapper _mapper;

        public NewsService(INewsRepository newsRepository, IMapper mapper, ICacheService cacheService)
        {
            _newsRepository = newsRepository;
            _mapper = mapper;
            _cacheService = cacheService;
        }

        public async Task<IEnumerable<NewsDto>> GetAllAsync()
        {
            var result = await _newsRepository.GetAllAsync();
            return _mapper.Map<List<NewsDto>>(result);
        }

        public IEnumerable<NewsDto> GetAll()
        {
            var result = _newsRepository.GetAll();
            return _mapper.Map<List<NewsDto>>(result);
        }

        public IEnumerable<NewsDto> GetAllCache(int cacheTime)
        {
            var result = _cacheService.Get("news", TimeSpan.FromMinutes(cacheTime), () => _newsRepository.GetAll());
            return _mapper.Map<List<NewsDto>>(result);
        }

        public IEnumerable<NewsDto> GetNewsOrder(string order)
        {
            IEnumerable<News> news = null;
            if (order == "AZ")
                news = _newsRepository.GetNewsOrderAsc();
            if (order == "ZA")
                news = _newsRepository.GetNewsOrderDesc();
            return _mapper.Map<List<NewsDto>>(news);
        }

        public IEnumerable<NewsDto> GetNewsWithSearch(string search)
        {
            var items = _newsRepository.GetNewsWithSearch(search);
            return _mapper.Map<List<NewsDto>>(items);
        }

        public IEnumerable<NewsDto> GetNewsSpAsc()
        {
            var items = _newsRepository.GetNewsOrderAsc();
            return _mapper.Map<List<NewsDto>>(items);
        }

        public IEnumerable<NewsDto> GetNewsSpDesc()
        {
            var items = _newsRepository.GetNewsOrderDesc();
            return _mapper.Map<List<NewsDto>>(items);
        }
    }
}
