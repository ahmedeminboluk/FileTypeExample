using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using FileTypeExample.Domain.Models;
using System;
using System.Collections.Generic;

namespace FileTypeExample.Application.Services
{
    public class BigParaService : IBigParaService
    {
        private readonly IBigParaRepository _bigParaRepository;
        private readonly ICacheService _cacheService;
        private readonly IMapper _mapper;

        public BigParaService(IBigParaRepository bigParaRepository, ICacheService cacheService, IMapper mapper)
        {
            _bigParaRepository = bigParaRepository;
            _cacheService = cacheService;
            _mapper = mapper;
        }

        public IEnumerable<BigParaDto> GetAll()
        {
            var result = _bigParaRepository.GetAll();
            return _mapper.Map<List<BigParaDto>>(result);
        }

        public IEnumerable<BigParaDto> GetAllCache(int cacheTime)
        {
            var result = _cacheService.Get("bigpara", TimeSpan.FromMinutes(cacheTime), () => _bigParaRepository.GetAll());
            return _mapper.Map<List<BigParaDto>>(result);
        }

        public IEnumerable<BigParaDto> GetBigParaOrder(string order)
        {
            IEnumerable<BigPara> bigPara = null;
            if (order == "AZ")
                bigPara = _bigParaRepository.GetBigParaOrderAZ();
            if (order == "ZA")
                bigPara = _bigParaRepository.GetBigParaOrderZA();
            return _mapper.Map<List<BigParaDto>>(bigPara);
        }

        public IEnumerable<BigParaDto> GetBigParaWithSearch(string search)
        {
            var items = _bigParaRepository.GetBigParaWithSearch(search);
            return _mapper.Map<List<BigParaDto>>(items);
        }

        public IEnumerable<BigParaDto> GetBigParaSpAZ()
        {
            var items = _bigParaRepository.GetBigParaSpAZ();
            return _mapper.Map<List<BigParaDto>>(items);
        }

        public IEnumerable<BigParaDto> GetBigParaSpZA()
        {
            var items = _bigParaRepository.GetBigParaSpZA();
            return _mapper.Map<List<BigParaDto>>(items);
        }
    }
}
