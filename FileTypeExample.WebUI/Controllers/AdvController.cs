using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FileTypeExample.WebUI.Controllers
{
    public class AdvController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly IAdvService _advService;

        public AdvController(ICacheService cacheService, IAdvService advService)
        {
            _cacheService = cacheService;
            _advService = advService;
        }

        public IActionResult OrderSpAz()
        {
            var adv = _advService.GetAdvSpAZ();
            return View(adv);
        }

        public IActionResult OrderSpZa()
        {
            var adv = _advService.GetAdvSpZA();
            return View(adv);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<AdvDto> adv = _advService.GetAdvWithSearch(search);
            return View(adv);
        }

        public IActionResult Adv()
        {
            var list = _advService.GetAllCache(5);
            return View(list);
        }
        [HttpPost]
        public IActionResult Order(string order)
        {
            IEnumerable<AdvDto> adv = _advService.GetAdvOrder(order);
            return View(adv);
        }

        public IActionResult GetAllAjax()
        {
            return View();
        }
    }
}
