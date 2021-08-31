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

        public NewsController(ICacheService cacheService, ISearchService searchService)
        {
            _cacheService = cacheService;
            _searchService = searchService;
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<NewsDto> news = _searchService.GetNewsWithSearchAsync(search);
            return View(news);
        }

        public async Task<IActionResult> News()
        {
            var list = await _cacheService.GetAsync<NewsDto>("news");
            return View(list);
        }
    }
}
