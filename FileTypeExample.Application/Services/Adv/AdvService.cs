using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using System;
using System.Collections.Generic;

namespace FileTypeExample.Application.Services
{
    public class AdvService : IAdvService
    {
        private readonly IAdvRepository _advRepository;
        private readonly ICacheService _cacheService;
        private readonly IMapper _mapper;

        public AdvService(IAdvRepository advRepository, IMapper mapper, ICacheService cacheService)
        {
            _advRepository = advRepository;
            _cacheService = cacheService;
            _mapper = mapper;
        }

        public IEnumerable<AdvDto> GetAll()
        {
            var result = _advRepository.GetAll();
            return _mapper.Map<List<AdvDto>>(result);
        }

        public IEnumerable<AdvDto> GetAllCache(int cacheTime)
        {
            var result = _cacheService.Get("adv", TimeSpan.FromMinutes(cacheTime), () => _advRepository.GetAll());
            return _mapper.Map<List<AdvDto>>(result);
        }

        public IEnumerable<AdvDto> GetAdvOrder(string order)
        {
            IEnumerable<Adv> adv = null;
            if (order == "AZ")
                adv = _advRepository.GetAdvOrderAZ();
            if (order == "ZA")
                adv = _advRepository.GetAdvOrderZA();
            return _mapper.Map<List<AdvDto>>(adv);
        }

        public IEnumerable<AdvDto> GetAdvWithSearch(string search)
        {
            var items = _advRepository.GetAdvWithSearch(search);
            return _mapper.Map<List<AdvDto>>(items);
        }

        public IEnumerable<AdvDto> GetAdvSpAZ()
        {
            var items = _advRepository.GetAdvSpAZ();
            return _mapper.Map<List<AdvDto>>(items);
        }

        public IEnumerable<AdvDto> GetAdvSpZA()
        {
            var items = _advRepository.GetAdvSpZA();
            return _mapper.Map<List<AdvDto>>(items);
        }
    }
}
