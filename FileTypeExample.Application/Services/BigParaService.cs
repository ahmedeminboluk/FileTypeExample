using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public IEnumerable<BigParaDto> GetAllAsync(int cacheTime)
        {
            var result = _cacheService.Get("bigpara", TimeSpan.FromMinutes(cacheTime), () => _bigParaRepository.GetAll());
            //List<BigPara> bigPara = await _bigParaRepository.GetAllAsync();
            return _mapper.Map<List<BigParaDto>>(result);
        }
    }
}
