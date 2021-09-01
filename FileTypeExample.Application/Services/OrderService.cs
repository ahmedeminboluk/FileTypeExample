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
    public class OrderService : IOrderService
    {
        private readonly IBigParaRepository _bigParaRepository;
        private readonly IAdvRepository _advRepository;
        private readonly IMapper _mapper;
        private readonly INewsRepository _newsRepository;

        public OrderService(IBigParaRepository bigParaRepository, IMapper mapper, IAdvRepository advRepository, INewsRepository newsRepository)
        {
            _bigParaRepository = bigParaRepository;
            _mapper = mapper;
            _advRepository = advRepository;
            _newsRepository = newsRepository;
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

        public IEnumerable<AdvDto> GetAdvOrder(string order)
        {
            IEnumerable<Adv> adv = null;
            if (order == "AZ")
                adv = _advRepository.GetAdvOrderAZ();
            if (order == "ZA")
                adv = _advRepository.GetAdvOrderZA();
            return _mapper.Map<List<AdvDto>>(adv);
        }

        public IEnumerable<NewsDto> GetNewsOrder(string order)
        {
            IEnumerable<News> news = null;
            if (order == "AZ")
                news = _newsRepository.GetAdvOrderAsc();
            if (order == "ZA")
                news = _newsRepository.GetAdvOrderDesc();
            return _mapper.Map<List<NewsDto>>(news);
        }
    }
}
