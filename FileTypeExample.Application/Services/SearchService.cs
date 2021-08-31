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
    public class SearchService : ISearchService
    {
        private readonly IBigParaRepository _bigParaRepository;
        private readonly IAdvRepository _advRepository;
        private readonly INewsRepository _newsRepository;
        private readonly IMapper _mapper;

        public SearchService(IBigParaRepository bigParaRepository, IMapper mapper, IAdvRepository advRepository, INewsRepository newsRepository)
        {
            _bigParaRepository = bigParaRepository;
            _mapper = mapper;
            _advRepository = advRepository;
            _newsRepository = newsRepository;
        }

        public IEnumerable<AdvDto> GetAdvWithSearchAsync(string search)
        {
            var items = _advRepository.GetAdvWithSearchAsync(search);
            return _mapper.Map<List<AdvDto>>(items);
        }

        public IEnumerable<BigParaDto> GetBigParaWithSearchAsync(string search)
        {
            var items = _bigParaRepository.GetBigParaWithSearchAsync(search);
            return _mapper.Map<List<BigParaDto>>(items);
        }

        public IEnumerable<NewsDto> GetNewsWithSearchAsync(string search)
        {
            var items = _newsRepository.GetNewsWithSearchAsync(search);
            return _mapper.Map<List<NewsDto>>(items);
        }
    }
}
