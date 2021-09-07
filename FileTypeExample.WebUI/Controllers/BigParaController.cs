using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using FileTypeExample.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.Controllers
{
    public class BigParaController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly ISearchService _searchService;
        private readonly IOrderService _orderService;
        private readonly IBigParaService _bigParaService;
        private readonly ISPService _spService;

        public BigParaController(ICacheService cacheService, ISearchService searchService, IOrderService orderService, ISPService spService, IBigParaService bigParaService)
        {
            _cacheService = cacheService;
            _searchService = searchService;
            _orderService = orderService;
            _spService = spService;
            _bigParaService = bigParaService;
        }

        public IActionResult OrderSpAz()
        {
            var bigPara = _spService.GetBigParaSpAZ();
            return View(bigPara);
        }

        public IActionResult OrderSpZa()
        {
            var bigPara = _spService.GetBigParaSpZA();
            return View(bigPara);
        }


        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<BigParaDto> bigPara = _searchService.GetBigParaWithSearch(search);
            return View(bigPara);
        }

        public  IActionResult BigPara()
        {
            //var list =  _cacheService.GetAsync<BigParaDto>("bigpara");
            var list2 = _bigParaService.GetAllAsync(5);
            return View(list2);
        }

        [HttpPost]
        public IActionResult Order(string order)
        {
            IEnumerable<BigParaDto> bigPara = _orderService.GetBigParaOrder(order);
            return View(bigPara);
        }

        public IActionResult Deneme()
        {
            return View();
        }
    }
}
