using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FileTypeExample.WebUI.Controllers
{
    public class FileTypeController : Controller
    {
        private readonly ICacheService _cacheService;

        public FileTypeController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public async Task<IActionResult> BigPara()
      {
            var list = await _cacheService.GetAsync<BigParaDto>("bigpara");
            return View(list);
        }

        public async Task<IActionResult> News()
        {
            var list = await _cacheService.GetAsync<NewsDto>("news");
            return View(list);
        }

        public async Task<IActionResult> Adv()
        {
            var list = await _cacheService.GetAsync<AdvDto>("adv");
            return View(list);
        }
    }
}
