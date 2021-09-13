using FileTypeExample.Application.Dto;
using FileTypeExample.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace FileTypeExample.WebUI.Controllers
{
    public class BigParaController : Controller
    {
        private readonly IBigParaService _bigParaService;

        public BigParaController(IBigParaService bigParaService)
        {
            _bigParaService = bigParaService;
        }

        public IActionResult OrderSpAz()
        {
            var bigPara = _bigParaService.GetBigParaSpAZ();
            return View(bigPara);
        }

        public IActionResult OrderSpZa()
        {
            var bigPara = _bigParaService.GetBigParaSpZA();
            return View(bigPara);
        }


        [HttpPost]
        public IActionResult Index(string search)
        {
            IEnumerable<BigParaDto> bigPara = _bigParaService.GetBigParaWithSearch(search);
            return View(bigPara);
        }

        public  IActionResult BigPara()
        {
            var list2 = _bigParaService.GetAllCache(5);
            return View(list2);
        }

        [HttpPost]
        public IActionResult Order(string order)
        {
            IEnumerable<BigParaDto> bigPara = _bigParaService.GetBigParaOrder(order);
            return View(bigPara);
        }

        public async Task<IActionResult> GetAllAPI()
        {
            IEnumerable<BigParaDto> bigPara;
            using (var httpClient = new HttpClient())
            {
                bigPara = await httpClient.GetFromJsonAsync<IEnumerable<BigParaDto>>("http://localhost:20778/api/BigPara/AllBigPara");
            }
            return View(bigPara);
        }

        public IActionResult GetAllAjax()
        {
            return View();
        }
    }
}
