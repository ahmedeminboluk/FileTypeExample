using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FileTypeExample.WebUI.Controllers
{
    public class NewsController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly INewsService _newsService;

        public NewsController(ICacheService cacheService, INewsService newsService)
        {
            _cacheService = cacheService;
            _newsService = newsService;
        }

        public IActionResult OrderSpAsc()
        {
            var news = _newsService.GetNewsSpAsc();
            return View(news);
        }

        public IActionResult OrderSpDesc()
        {
            var news = _newsService.GetNewsSpDesc();
            return View(news);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<NewsDto> news = _newsService.GetNewsWithSearch(search);
            return View(news);
        }

        public IActionResult News()
        {
            var list = _newsService.GetAllCache(5);
            return View(list);
        }

        [HttpPost]
        public IActionResult Order(string order)
        {
            IEnumerable<NewsDto> news = _newsService.GetNewsOrder(order);
            return View(news);
        }

        public IActionResult GetAllAjax()
        {
            return View();
        }
    }
}
