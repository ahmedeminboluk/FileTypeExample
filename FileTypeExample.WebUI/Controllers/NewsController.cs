using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.Controllers
{
    public class NewsController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly ISearchService _searchService;
        private readonly IOrderService _orderService;
        private readonly ISPService _spService;

        public NewsController(ICacheService cacheService, ISearchService searchService, IOrderService orderService, ISPService spService)
        {
            _cacheService = cacheService;
            _searchService = searchService;
            _orderService = orderService;
            _spService = spService;
        }

        public IActionResult OrderSpAsc()
        {
            var news = _spService.GetNewsSpAsc();
            return View(news);
        }

        public IActionResult OrderSpDesc()
        {
            var news = _spService.GetNewsSpDesc();
            return View(news);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<NewsDto> news = _searchService.GetNewsWithSearch(search);
            return View(news);
        }

        public async Task<IActionResult> News()
        {
            var list = await _cacheService.GetAsync<NewsDto>("news");
            return View(list);
        }

        [HttpPost]
        public IActionResult Order(string order)
        {
            IEnumerable<NewsDto> news = _orderService.GetNewsOrder(order);
            return View(news);
        }
    }
}
