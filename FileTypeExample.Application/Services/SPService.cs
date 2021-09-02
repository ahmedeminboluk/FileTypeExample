using AutoMapper;
using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTypeExample.Application.Services
{
    public class SPService : ISPService
    {
        private readonly IBigParaRepository _bigParaRepository;
        private readonly INewsRepository _newsRepository;
        private readonly IAdvRepository _advRepository;
        private readonly IMapper _mapper;

        public SPService(IBigParaRepository bigParaRepository, INewsRepository newsRepository, IAdvRepository advRepository, IMapper mapper)
        {
            _bigParaRepository = bigParaRepository;
            _newsRepository = newsRepository;
            _advRepository = advRepository;
            _mapper = mapper;
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
