using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.Controllers
{
    public class AdvController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly ISearchService _searchService;

        public AdvController(ICacheService cacheService, ISearchService searchService)
        {
            _cacheService = cacheService;
            _searchService = searchService;
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<AdvDto> adv = _searchService.GetAdvWithSearchAsync(search);
            return View(adv);
        }

        public async Task<IActionResult> Adv()
        {
            var list = await _cacheService.GetAsync<AdvDto>("adv");
            return View(list);
        }
    }
}
